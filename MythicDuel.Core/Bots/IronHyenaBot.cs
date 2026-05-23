using MythicDuel.Core.Cards;
using MythicDuel.Core.Game;
using MythicDuel.Core.Models;

namespace MythicDuel.Core.Bots;

public sealed class IronHyenaBot : IGameBot
{
    public string Name => "iron";

    public TurnDecision ChooseTurn(GameView view, PlayerId playerId, IReadOnlyList<PlayerAction> legalMain1, IReadOnlyList<AttackDecision> legalAttacks, IReadOnlyList<PlayerAction> legalMain2, IReadOnlyList<PlayerAction> legalAwakenings)
    {
        var decision = new TurnDecision();
        var endgameUrgent = view.TurnNumber >= 20;

        var sortedLegalMain1 = legalMain1
            .OrderByDescending(action =>
            {
                if (action is PlayRelicAction relic)
                {
                    var host = view.GetCard(relic.HostId);
                    var levelScore = host.DefinitionId == CoreIds.Iron.IronHyenaChampion ? 1000 : 0;
                    var packScore = host.HasKeyword(Keyword.Pack) ? 100 : 0;
                    var statsScore = host.BaseAttack * 10 + host.BaseVitality;
                    return levelScore + packScore + statsScore;
                }
                return 0;
            })
            .ToList();

        decision.Main1Actions.AddRange(BotHelpers.Prioritize(
                sortedLegalMain1,
                action => action is EvolveAction evolve && view.GetCard(evolve.CardId).DefinitionId == CoreIds.Iron.IronHyenaUnderworld,
                action => action is EvolveAction evolve && view.GetCard(evolve.CardId).DefinitionId == CoreIds.Iron.IronHyenaChampion,
                action => action is PlayRiteAction rite && view.GetCard(rite.CardId).DefinitionId == CoreIds.Iron.BiteTheRoots,
                action => action is PlayRiteAction rite && view.GetCard(rite.CardId).DefinitionId == CoreIds.Iron.PackAmbush,
                action => endgameUrgent && action is PlayRelicAction,
                action => action is PrepareTacticAction prepare && view.GetCard(prepare.CardId).DefinitionId == CoreIds.Iron.IronSnare,
                action => action is PrepareTacticAction prepare && view.GetCard(prepare.CardId).DefinitionId == CoreIds.Iron.FalseOpening,
                action => action is PlayRelicAction,
                action => action is PlayUnitAction play && view.GetCard(play.CardId).DefinitionId is CoreIds.Iron.BoneCrackerCub or CoreIds.Iron.IronHyenaRaider or CoreIds.Iron.PackHarrier or CoreIds.Iron.BloodScentHyena)
            .Take(2));

        decision.Attacks.AddRange(
            BotHelpers.ChooseAssaultsWithPack(
                view,
                legalAttacks,
                attack => ScoreAttack(view, playerId, attack)));

        decision.Main2Actions.AddRange(BotHelpers.Prioritize(
                legalMain2,
                action => action is PlayRiteAction rite && view.GetCard(rite.CardId).DefinitionId == CoreIds.Iron.BiteTheRoots,
                action => action is PrepareTacticAction,
                action => action is EvolveAction,
                action => action is PlayUnitAction)
            .Take(2));

        return decision;
    }

    public int? ChooseRetainedCard(GameView view, PlayerId playerId, IReadOnlyList<int> handCardIds)
    {
        return BotHelpers.PickRetainForIron(view, playerId, handCardIds);
    }

    public AwakenAncestorAction? ChooseAwakening(GameView view, PlayerId playerId, IReadOnlyList<AwakenAncestorAction> legalAwakenings)
    {
        return legalAwakenings
            .OrderBy(action => PriorityForAncestor(view, action.AncestorDefinitionId))
            .FirstOrDefault();
    }

    public BlockDecision? ChooseBlock(GameView view, PlayerId defender, AttackDecision attack, IReadOnlyList<BlockDecision> legalBlocks)
    {
        var attacker = view.GetCard(attack.AttackerId);
        var defendingPlayer = view.Self;
        var shrine = defendingPlayer.Shrines.First(x => x.Name == attack.TargetName);
        var incomingDamage = EstimateShrineAttackDamage(view, attacker);
        var shrineWouldBreak = shrine.Damage + incomingDamage >= shrine.Vitality;

        if (attacker.DefinitionId is CoreIds.Red.LeopardHunter or CoreIds.Red.KumaWhoWoundedTheSun || shrineWouldBreak)
        {
            return legalBlocks
                .Where(block => block.BlockerId.HasValue)
                .OrderBy(block => view.GetCard(block.BlockerId!.Value).BaseAttack + view.GetCard(block.BlockerId!.Value).BaseVitality)
                .FirstOrDefault() ?? legalBlocks.FirstOrDefault();
        }

        return legalBlocks.FirstOrDefault();
    }

    public int? ChoosePreparedReplacement(GameView view, PlayerId playerId, IReadOnlyList<int> preparedTacticCardIds, int incomingPreparedCardId)
    {
        return BotHelpers.ChoosePreparedReplacementByPriority(
            view,
            preparedTacticCardIds,
            incomingPreparedCardId,
            card => card.DefinitionId == CoreIds.Iron.IronSnare ? 90 : card.DefinitionId == CoreIds.Iron.FalseOpening ? 80 : 10);
    }

    private static int ScoreAttack(GameView view, PlayerId playerId, AttackDecision attack)
    {
        var score = BotHelpers.ScoreAttack(view, playerId, attack);
        var attacker = view.GetCard(attack.AttackerId);
        var turnUrgency = view.TurnNumber >= 30 ? 60 : view.TurnNumber >= 20 ? 30 : 0;
        var opponent = view.Opponent;
        var oneShrineLeft = opponent.Shrines.Count(shrine => !shrine.IsBroken) == 1;
        if (attack.TargetType == AttackTargetType.Shrine)
        {
            // Base Shrine attack preference: significantly higher to prefer Shrine attacks aggressively
            score += 100;
            score += turnUrgency;
            if (oneShrineLeft)
            {
                score += 150;
            }

            // Bleed / Pack Attack / Relic / Pierce bonuses
            if (attacker.HasKeyword(Keyword.Pack))
            {
                score += 30; // General pack attack value
            }

            // Pack Harrier blocked-Shrine bleed
            if (attacker.DefinitionId == CoreIds.Iron.PackHarrier)
            {
                score += 40;
            }

            // Blood-Scent Hyena attacking damaged Shrine
            if (attacker.DefinitionId == CoreIds.Iron.BloodScentHyena && opponent.Shrines.Any(x => x.Damage > 0 && !x.IsBroken))
            {
                score += 40;
            }

            // Iron Hyena Raider extra Shrine damage
            if (attacker.DefinitionId == CoreIds.Iron.IronHyenaRaider)
            {
                score += 40;
            }

            // Ancestor of the Iron Hyena active attack trigger
            if (view.Self.AwakenedAncestorDefinitionId == CoreIds.Iron.AncestorIronHyena)
            {
                score += 30;
            }

            // Pierce or Bone Spear attached
            var hasPierce = attacker.HasKeyword(Keyword.Pierce);
            if (attacker.AttachedRelicId.HasValue && view.Cards.TryGetValue(attacker.AttachedRelicId.Value, out var relic))
            {
                score += 40; // Relic bonus
                if (relic.DefinitionId == CoreIds.Iron.BoneSpear)
                {
                    hasPierce = true;
                }
            }

            if (hasPierce)
            {
                score += 50; // High value for Pierce bleed
            }
        }
        else if (turnUrgency > 0)
        {
            score -= turnUrgency / 2;
        }

        return score;
    }

    private static int PriorityForAncestor(GameView view, string ancestorDefinitionId)
    {
        return ancestorDefinitionId switch
        {
            CoreIds.Iron.AncestorFirstPack when view.Self.Battlefield.Any(id => view.GetCard(id).HasKeyword(Keyword.Pack)) => 0,
            CoreIds.Iron.AncestorSmithPassedFang when view.Self.Hand.Any(id => view.GetCard(id).CardType == CardType.Relic) => 1,
            CoreIds.Iron.AncestorBoneSplitterMother when view.Self.Battlefield.Any(id => view.GetCard(id).IsWounded && view.GetCard(id).HasKeyword(Keyword.Pack)) => 2,

            CoreIds.Iron.AncestorIronHyena when view.Self.Battlefield.Any(id => view.GetCard(id).CardType == CardType.Being) => 3,
            CoreIds.Iron.AncestorSmith when view.Self.Hand.Any(id => view.GetCard(id).CardType == CardType.Relic) => 4,
            CoreIds.Iron.AncestorToothMother when view.Self.Battlefield.Any(id => view.GetCard(id).IsWounded) => 5,

            CoreIds.Iron.AncestorFirstPack => 6,
            CoreIds.Iron.AncestorSmithPassedFang => 7,
            CoreIds.Iron.AncestorBoneSplitterMother => 8,

            CoreIds.Iron.AncestorIronHyena => 9,
            CoreIds.Iron.AncestorSmith => 10,
            CoreIds.Iron.AncestorToothMother => 11,
            _ => 99,
        };
    }

    private static int EstimateShrineAttackDamage(GameView view, CardPublicView attacker)
    {
        var modifier = 0;
        var player = view.Opponent;

        if (attacker.AttachedRelicId.HasValue && view.Cards.TryGetValue(attacker.AttachedRelicId.Value, out var relic))
        {
            modifier += 1;
            if (relic.DefinitionId == CoreIds.Red.SpearOfFirstDawn && attacker.HasTag("Hunter"))
            {
                modifier += 2;
            }
        }

        if (attacker.AttachedPossessionId.HasValue)
        {
            modifier += 2;
        }

        if (attacker.HasTag("Hunter") && player.Shrines.Any(x => x.DefinitionId == CoreIds.Red.ShrineRootStone && !x.IsBroken))
        {
            modifier += 1;
        }

        if (player.AwakenedAncestorDefinitionId == CoreIds.Red.AncestorFirstHunter)
        {
            modifier += 1;
        }

        var damage = attacker.BaseAttack + modifier;
        if (attacker.IsWounded)
        {
            damage = Math.Max(1, (int)Math.Floor(damage * 0.75m));
        }

        return Math.Max(1, damage);
    }
}
