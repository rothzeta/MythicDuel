using MythicDuel.Core.Cards;
using MythicDuel.Core.Game;
using MythicDuel.Core.Models;

namespace MythicDuel.Core.Bots;

public sealed class RedBaobabBot : IGameBot
{
    public string Name => "red";

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
                action => action is PlayRelicAction,
                action => action is PlayPossessionAction,
                action => action is PlayRiteAction rite && view.GetCard(rite.CardId).DefinitionId == CoreIds.Red.RitualOfRedMoon,
                action => action is PrepareTacticAction prepare && view.GetCard(prepare.CardId).DefinitionId == CoreIds.Red.RootWovenGuard && shrineThreatened,
                action => action is PlayUnitAction play && view.GetCard(play.CardId).DefinitionId == CoreIds.Red.PaleRiverSpirit)
            .Take(2));

        decision.Attacks.AddRange(
            BotHelpers.ChooseAssaultsWithPack(
                view,
                legalAttacks,
                attack => ScoreAttack(view, playerId, attack)));

        decision.Main2Actions.AddRange(BotHelpers.Prioritize(
                legalMain2,
                action => action is EvolveAction evolve && view.GetCard(evolve.CardId).DefinitionId == CoreIds.Red.KumaWhoWoundedTheSun,
                action => action is EvolveAction evolve && view.GetCard(evolve.CardId).DefinitionId == CoreIds.Red.LeopardHunter,
                action => action is PlayUnitAction play && view.GetCard(play.CardId).DefinitionId == CoreIds.Red.LeopardHunter,
                action => action is PlayRiteAction rite && view.GetCard(rite.CardId).DefinitionId == CoreIds.Red.OfferingOfMilkAndAsh && shrineThreatened,
                action => action is PrepareTacticAction prepare && view.GetCard(prepare.CardId).DefinitionId == CoreIds.Red.RootWovenGuard && shrineThreatened)
            .Take(2));

        return decision;
    }

    public int? ChooseRetainedCard(GameView view, PlayerId playerId, IReadOnlyList<int> handCardIds)
    {
        return BotHelpers.PickRetainForRed(view, playerId, handCardIds);
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
        var incomingDamage = EstimateAttackDamage(view, attacker, attack);
        var shrineWouldBreak = shrine.Damage + incomingDamage >= shrine.Vitality;

        if (shrineWouldBreak)
        {
            return legalBlocks.FirstOrDefault(block => block.BlockerId.HasValue) ?? legalBlocks.FirstOrDefault();
        }

        var keyShrine = shrine.DefinitionId is CoreIds.Red.ShrineRedBaobab or CoreIds.Red.ShrineRootStone;
        if (keyShrine && shrine.Damage + incomingDamage >= shrine.Vitality - 2)
        {
            return legalBlocks.FirstOrDefault(block => block.BlockerId.HasValue) ?? legalBlocks.FirstOrDefault();
        }

        return legalBlocks
            .Where(block => block.BlockerId.HasValue)
            .OrderBy(block => view.GetCard(block.BlockerId!.Value).BaseAttack + view.GetCard(block.BlockerId!.Value).BaseVitality)
            .FirstOrDefault() ?? legalBlocks.FirstOrDefault();
    }

    public int? ChoosePreparedReplacement(GameView view, PlayerId playerId, IReadOnlyList<int> preparedTacticCardIds, int incomingPreparedCardId)
    {
        return BotHelpers.ChoosePreparedReplacementByPriority(
            view,
            preparedTacticCardIds,
            incomingPreparedCardId,
            card => card.DefinitionId == CoreIds.Red.RootWovenGuard && BotHelpers.HasThreatenedShrine(view, playerId) ? 100 : 10);
    }

    private static int ScoreAttack(GameView view, PlayerId playerId, AttackDecision attack)
    {
        var attacker = view.GetCard(attack.AttackerId);
        var score = BotHelpers.ScoreAttack(view, playerId, attack);
        var turnUrgency = view.TurnNumber >= 30 ? 60 : view.TurnNumber >= 20 ? 30 : 0;
        var opponent = view.Opponent;
        var oneShrineLeft = opponent.Shrines.Count(shrine => !shrine.IsBroken) == 1;

        if (attack.TargetType == AttackTargetType.Unit && attack.TargetUnitId.HasValue)
        {
            var target = view.GetCard(attack.TargetUnitId.Value);
            var attackerDamage = EstimateAttackDamage(view, attacker, attack);
            var targetDies = attackerDamage >= Math.Max(1, target.BaseVitality - target.Damage);
            if (attacker.HasTag("Hunter") && targetDies)
            {
                score += 100;
            }

            if (targetDies)
            {
                score += 40;
            }

             if (turnUrgency > 0 && !attacker.HasTag("Hunter"))
            {
                score -= turnUrgency / 2;
            }

            return score;
        }

        if (attack.TargetType == AttackTargetType.Shrine)
        {
            var shrine = opponent.Shrines.First(x => x.Name == attack.TargetName);
            var canBreak = shrine.Damage + EstimateAttackDamage(view, attacker, attack) >= shrine.Vitality;
            score += turnUrgency;
            if (canBreak)
            {
                score += 120;
            }

            if (attacker.DefinitionId == CoreIds.Red.LeopardHunter)
            {
                score += 100;
                if (attacker.AttachedRelicId is not null || attacker.AttachedPossessionId is not null)
                {
                    score += 80;
                }
            }

            if (attacker.DefinitionId != CoreIds.Red.LeopardHunter && !canBreak)
            {
                score -= 20;
            }

            if (oneShrineLeft)
            {
                score += 120;
            }

            if (attacker.DefinitionId is CoreIds.Red.LeopardHunter or CoreIds.Red.KumaWhoWoundedTheSun)
            {
                score += 120;
                if (attacker.AttachedRelicId is not null || attacker.AttachedPossessionId is not null)
                {
                    score += 100;
                }
            }
        }

        return score;
    }

    private static int EstimateAttackDamage(GameView view, CardPublicView attacker, AttackDecision attack)
    {
        var attackingShrine = attack.TargetType == AttackTargetType.Shrine;
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

        if (attackingShrine && player.AwakenedAncestorDefinitionId == CoreIds.Red.AncestorFirstHunter)
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

    private static int PriorityForAncestor(GameView view, string ancestorDefinitionId)
    {
        return ancestorDefinitionId switch
        {
            CoreIds.Red.AncestorFirstHunter when view.Self.Battlefield.Any(id => view.GetCard(id).CardType == CardType.Being) => 0,
            CoreIds.Red.AncestorGrandmother when view.Self.Shrines.Any(shrine => shrine.Damage > 0 && !shrine.IsBroken) => 1,
            CoreIds.Red.AncestorChild => 2,
            CoreIds.Red.AncestorFirstHunter => 3,
            CoreIds.Red.AncestorGrandmother => 4,
            _ => 99,
        };
    }
}
