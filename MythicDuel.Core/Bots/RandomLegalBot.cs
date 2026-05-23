using MythicDuel.Core.Game;
using MythicDuel.Core.Models;

namespace MythicDuel.Core.Bots;

public sealed class RandomLegalBot : IGameBot
{
    public string Name => "random";

    public TurnDecision ChooseTurn(GameView view, PlayerId playerId, IReadOnlyList<PlayerAction> legalMain1, IReadOnlyList<AttackDecision> legalAttacks, IReadOnlyList<PlayerAction> legalMain2, IReadOnlyList<PlayerAction> legalAwakenings)
    {
        var random = new DeterministicRandom(view.Seed + (view.TurnNumber * 31) + (view.PhaseNumber * 17) + (int)playerId);
        var decision = new TurnDecision();
        decision.Main1Actions.AddRange(ChooseSubset(legalMain1, random));
        decision.Attacks.AddRange(legalAttacks.OrderBy(_ => random.Next(int.MaxValue)).Take(Math.Min(view.MaxPackAttacksPerCombat, legalAttacks.Count)).ToList());
        decision.Main2Actions.AddRange(ChooseSubset(legalMain2, random));

        return decision;
    }

    public int? ChooseRetainedCard(GameView view, PlayerId playerId, IReadOnlyList<int> handCardIds)
    {
        if (handCardIds.Count == 0)
        {
            return null;
        }

        var random = new DeterministicRandom(view.Seed + (view.TurnNumber * 41) + (view.PhaseNumber * 13) + (int)playerId);
        var choice = random.Next(handCardIds.Count + 1);
        return choice == handCardIds.Count ? null : handCardIds[choice];
    }

    public AwakenAncestorAction? ChooseAwakening(GameView view, PlayerId playerId, IReadOnlyList<AwakenAncestorAction> legalAwakenings)
    {
        if (legalAwakenings.Count == 0)
        {
            return null;
        }

        var random = new DeterministicRandom(view.Seed + (view.TurnNumber * 47) + (view.PhaseNumber * 19) + (int)playerId);
        return legalAwakenings[random.Next(legalAwakenings.Count)];
    }

    public BlockDecision? ChooseBlock(GameView view, PlayerId defender, AttackDecision attack, IReadOnlyList<BlockDecision> legalBlocks)
    {
        if (legalBlocks.Count == 0)
        {
            return null;
        }

        var random = new DeterministicRandom(view.Seed + (view.TurnNumber * 53) + (view.PhaseNumber * 23) + (int)defender);
        return legalBlocks[random.Next(legalBlocks.Count)];
    }

    public int? ChoosePreparedReplacement(GameView view, PlayerId playerId, IReadOnlyList<int> preparedTacticCardIds, int incomingPreparedCardId)
    {
        if (preparedTacticCardIds.Count == 0)
        {
            return null;
        }

        var random = new DeterministicRandom(view.Seed + (view.TurnNumber * 59) + (view.PhaseNumber * 29) + (int)playerId);
        return preparedTacticCardIds[random.Next(preparedTacticCardIds.Count)];
    }

    private static IEnumerable<PlayerAction> ChooseSubset(IReadOnlyList<PlayerAction> actions, DeterministicRandom random)
    {
        var count = actions.Count == 0 ? 0 : random.Next(actions.Count + 1);
        return actions.OrderBy(_ => random.Next(int.MaxValue)).Take(count).ToList();
    }
}
