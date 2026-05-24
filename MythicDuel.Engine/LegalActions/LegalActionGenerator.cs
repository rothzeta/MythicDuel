using System.Collections.Generic;
using MythicDuel.Engine.Ids;
using MythicDuel.Engine.Views;
using MythicDuel.Engine.Game;
namespace MythicDuel.Engine.LegalActions;

public class LegalActionGenerator
{
    public IReadOnlyList<LegalAction> Generate(GameState state, GameView view, PlayerId playerId)
    {
        return new List<LegalAction>();
    }
}
