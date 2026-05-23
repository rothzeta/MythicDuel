using MythicDuel.Core.Cards;
using MythicDuel.Core.Game;
using MythicDuel.Core.Models;

namespace MythicDuel.Core.Bots;

public sealed class RedEvolutionBot : IGameBot
{
    public string Name => "evolution";

    public TurnDecision ChooseTurn(GameView view, PlayerId playerId, IReadOnlyList<PlayerAction> legalMain1, IReadOnlyList<AttackDecision> legalAttacks, IReadOnlyList<PlayerAction> legalMain2, IReadOnlyList<PlayerAction> legalAwakenings)
    {
        var decision = new TurnDecision();
        var shrineThreatened = BotHelpers.HasThreatenedShrine(view, playerId);

        decision.Main1Actions.AddRange(BotHelpers.Prioritize(
                legalMain1,
                action => action is EvolveAction evolve && view.GetCard(evolve.CardId).DefinitionId == CoreIds.Red.KumaWhoWoundedTheSun,
                action => action is EvolveAction evolve && view.GetCard(evolve.CardId).DefinitionId == CoreIds.Red.LeopardHunter,
                action => action is PlayUnitAction play && view.GetCard(play.CardId).DefinitionId is CoreIds.Red.YoungHunter or CoreIds.Red.RiverHunter,
                action => action is PlayUnitAction play && view.GetCard(play.CardId).DefinitionId == CoreIds.Red.LeopardHunter,
                action => action is PlayRelicAction relic && view.GetCard(relic.HostId).DefinitionId == CoreIds.Red.LeopardHunter,
                action => action is PlayPossessionAction possession && view.GetCard(possession.HostId).DefinitionId == CoreIds.Red.LeopardHunter,
                action => action is PlayRelicAction,
                action => action is PlayPossessionAction,
                action => action is PlayRiteAction rite && view.GetCard(rite.CardId).DefinitionId == CoreIds.Red.RitualOfRedMoon,
                action => action is PrepareTacticAction prepare && view.GetCard(prepare.CardId).DefinitionId == CoreIds.Red.RootWovenGuard && shrineThreatened,
                action => action is PlayUnitAction play && view.GetCard(play.CardId).DefinitionId == CoreIds.Red.PaleRiverSpirit)
            .Take(2));

        decision.Attacks.AddRange(legalAttacks
            .OrderByDescending(attack => ScoreAttack(view, attack))
            .ThenBy(attack => attack.TargetName, StringComparer.Ordinal)
            .Take(Math.Min(view.MaxPackAttacksPerCombat, legalAttacks.Count)));

        decision.Main2Actions.AddRange(BotHelpers.Prioritize(
                legalMain2,
                action => action is EvolveAction evolve && view.GetCard(evolve.CardId).DefinitionId == CoreIds.Red.KumaWhoWoundedTheSun,
                action => action is EvolveAction evolve && view.GetCard(evolve.CardId).DefinitionId == CoreIds.Red.LeopardHunter,
                action => action is PlayUnitAction play && view.GetCard(play.CardId).DefinitionId == CoreIds.Red.LeopardHunter,
                action => action is PlayRelicAction relic && view.GetCard(relic.HostId).DefinitionId == CoreIds.Red.LeopardHunter,
                action => action is PlayPossessionAction possession && view.GetCard(possession.HostId).DefinitionId == CoreIds.Red.LeopardHunter,
                action => action is PlayRiteAction rite && view.GetCard(rite.CardId).DefinitionId == CoreIds.Red.OfferingOfMilkAndAsh && shrineThreatened,
                action => action is PrepareTacticAction prepare && view.GetCard(prepare.CardId).DefinitionId == CoreIds.Red.RootWovenGuard && shrineThreatened)
            .Take(2));

        return decision;
    }

    public int? ChooseRetainedCard(GameView view, PlayerId playerId, IReadOnlyList<int> handCardIds)
    {
        return handCardIds
            .Select(id => view.GetCard(id))
            .OrderByDescending(card => ScoreRetain(view, playerId, card))
            .ThenBy(card => card.Name, StringComparer.Ordinal)
            .Select(card => card.Id)
            .FirstOrDefault();
    }

    public AwakenAncestorAction? ChooseAwakening(GameView view, PlayerId playerId, IReadOnlyList<AwakenAncestorAction> legalAwakenings)
    {
        return legalAwakenings
            .OrderBy(action => action.AncestorDefinitionId == CoreIds.Red.AncestorFirstHunter ? 0 : action.AncestorDefinitionId == CoreIds.Red.AncestorGrandmother ? 1 : 2)
            .FirstOrDefault();
    }

    public BlockDecision? ChooseBlock(GameView view, PlayerId defender, AttackDecision attack, IReadOnlyList<BlockDecision> legalBlocks)
    {
        return new RedBaobabBot().ChooseBlock(view, defender, attack, legalBlocks);
    }

    public int? ChoosePreparedReplacement(GameView view, PlayerId playerId, IReadOnlyList<int> preparedTacticCardIds, int incomingPreparedCardId)
    {
        return new RedBaobabBot().ChoosePreparedReplacement(view, playerId, preparedTacticCardIds, incomingPreparedCardId);
    }

    private static int ScoreRetain(GameView view, PlayerId playerId, CardPublicView card)
    {
        var hasHunterInPlay = BotHelpers.HasTagInPlay(view, playerId, "Hunter");
        var hasLeopardInPlay = BotHelpers.HasUnitInPlay(view, playerId, CoreIds.Red.LeopardHunter);

        return card.DefinitionId switch
        {
            CoreIds.Red.LeopardHunter when !hasLeopardInPlay => 150,
            CoreIds.Red.YoungHunter when !hasHunterInPlay => 140,
            CoreIds.Red.RiverHunter when !hasHunterInPlay => 135,
            CoreIds.Red.SpearOfFirstDawn when hasHunterInPlay || hasLeopardInPlay => 125,
            CoreIds.Red.EspritDuLeopard when hasHunterInPlay || hasLeopardInPlay => 125,
            CoreIds.Red.KumaWhoWoundedTheSun when hasLeopardInPlay => 120,
            CoreIds.Red.RitualOfRedMoon => 110,
            CoreIds.Red.PaleRiverSpirit => 60,
            CoreIds.Red.DeepRiverSpirit => 30,
            _ => 10,
        };
    }

    private static int ScoreAttack(GameView view, AttackDecision attack)
    {
        var attacker = view.GetCard(attack.AttackerId);
        var score = BotHelpers.ScoreAttack(view, PlayerId.Red, attack);
        var turnUrgency = view.TurnNumber >= 30 ? 60 : view.TurnNumber >= 20 ? 30 : 0;

        if (attack.TargetType == AttackTargetType.Unit && attack.TargetUnitId.HasValue)
        {
            var target = view.GetCard(attack.TargetUnitId.Value);
            var damage = EstimateAttackDamage(view, attacker, attack.TargetType == AttackTargetType.Shrine);
            if (attacker.HasTag("Hunter") && damage >= Math.Max(1, target.BaseVitality - target.Damage))
            {
                score += 140;
            }

            if (BotHelpers.HasUnitInPlay(view, PlayerId.Red, CoreIds.Red.LeopardHunter))
            {
                score -= 60;
            }

            return score;
        }

        if (attack.TargetType == AttackTargetType.Shrine)
        {
            score += turnUrgency;
            if (attacker.DefinitionId == CoreIds.Red.LeopardHunter)
            {
                score += 260;
                if (attacker.AttachedRelicId is not null || attacker.AttachedPossessionId is not null)
                {
                    score += 120;
                }
            }
            else if (attacker.DefinitionId == CoreIds.Red.KumaWhoWoundedTheSun)
            {
                score += 240;
            }
            else
            {
                score -= 40;
            }
        }

        return score;
    }

    private static int EstimateAttackDamage(GameView view, CardPublicView attacker, bool attackingShrine)
    {
        var modifier = 0;
        var player = view.Self;
        if (attacker.AttachedRelicId.HasValue && view.Cards.TryGetValue(attacker.AttachedRelicId.Value, out var relic))
        {
            modifier += 1;
            if (relic.DefinitionId == CoreIds.Red.SpearOfFirstDawn && attackingShrine && attacker.HasTag("Hunter"))
            {
                modifier += 2;
            }
        }

        if (attacker.AttachedPossessionId.HasValue)
        {
            modifier += 2;
        }

        if (attackingShrine && attacker.HasTag("Hunter") && player.Shrines.Any(x => x.DefinitionId == CoreIds.Red.ShrineRootStone && !x.IsBroken))
        {
            modifier += 1;
        }

        return Math.Max(1, attacker.BaseAttack + modifier);
    }
}