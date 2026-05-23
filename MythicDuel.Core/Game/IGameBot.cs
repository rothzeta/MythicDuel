using MythicDuel.Core.Models;

namespace MythicDuel.Core.Game;

public interface IGameBot
{
    string Name { get; }
    TurnDecision ChooseTurn(GameView view, PlayerId playerId, IReadOnlyList<PlayerAction> legalMain1, IReadOnlyList<AttackDecision> legalAttacks, IReadOnlyList<PlayerAction> legalMain2, IReadOnlyList<PlayerAction> legalAwakenings);
    AwakenAncestorAction? ChooseAwakening(GameView view, PlayerId playerId, IReadOnlyList<AwakenAncestorAction> legalAwakenings);
    int? ChooseRetainedCard(GameView view, PlayerId playerId, IReadOnlyList<int> handCardIds);
    BlockDecision? ChooseBlock(GameView view, PlayerId defender, AttackDecision attack, IReadOnlyList<BlockDecision> legalBlocks);
    int? ChoosePreparedReplacement(GameView view, PlayerId playerId, IReadOnlyList<int> preparedTacticCardIds, int incomingPreparedCardId);
}
