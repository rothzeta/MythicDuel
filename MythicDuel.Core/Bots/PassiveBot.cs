using MythicDuel.Core.Cards;
using MythicDuel.Core.Game;
using MythicDuel.Core.Models;

namespace MythicDuel.Core.Bots;

public sealed class PassiveBot : IGameBot
{
    public string Name => "passive";

    public TurnDecision ChooseTurn(GameView view, PlayerId playerId, IReadOnlyList<PlayerAction> legalMain1, IReadOnlyList<AttackDecision> legalAttacks, IReadOnlyList<PlayerAction> legalMain2, IReadOnlyList<PlayerAction> legalAwakenings)
    {
        var decision = new TurnDecision();
        var shrineThreatened = BotHelpers.HasThreatenedShrine(view, playerId);

        decision.Main1Actions.AddRange(BotHelpers.Prioritize(
                legalMain1,
                action => action is EvolveAction,
                action => action is PrepareTacticAction prepare && shrineThreatened,
                action => action is PlayUnitAction play && view.GetCard(play.CardId).CardType is CardType.Being or CardType.Token)
            .Take(1));

        decision.Main2Actions.AddRange(BotHelpers.Prioritize(
                legalMain2,
                action => action is EvolveAction,
                action => action is PrepareTacticAction prepare && shrineThreatened)
            .Take(1));

        return decision;
    }

    public int? ChooseRetainedCard(GameView view, PlayerId playerId, IReadOnlyList<int> handCardIds)
    {
        if (playerId == PlayerId.Red)
        {
            return BotHelpers.PickRetainForRed(view, playerId, handCardIds);
        }

        return BotHelpers.PickRetainForIron(view, playerId, handCardIds);
    }

    public AwakenAncestorAction? ChooseAwakening(GameView view, PlayerId playerId, IReadOnlyList<AwakenAncestorAction> legalAwakenings)
    {
        return legalAwakenings.FirstOrDefault();
    }

    public BlockDecision? ChooseBlock(GameView view, PlayerId defender, AttackDecision attack, IReadOnlyList<BlockDecision> legalBlocks)
    {
        var defendingPlayer = view.Self;
        var shrine = defendingPlayer.Shrines.First(x => x.Name == attack.TargetName);
        var attacker = view.GetCard(attack.AttackerId);
        var incomingDamage = attacker.BaseAttack;
        if (shrine.Damage + incomingDamage >= shrine.Vitality)
        {
            return legalBlocks.FirstOrDefault(block => block.BlockerId.HasValue) ?? legalBlocks.FirstOrDefault();
        }

        return legalBlocks.FirstOrDefault();
    }

    public int? ChoosePreparedReplacement(GameView view, PlayerId playerId, IReadOnlyList<int> preparedTacticCardIds, int incomingPreparedCardId)
    {
        return preparedTacticCardIds.FirstOrDefault();
    }
}
