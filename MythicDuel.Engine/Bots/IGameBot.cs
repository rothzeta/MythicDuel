using System.Collections.Generic;
using MythicDuel.Engine.LegalActions;
using MythicDuel.Engine.Views;
namespace MythicDuel.Engine.Bots;
public interface IGameBot
{
    LegalAction ChooseAction(GameView view, IReadOnlyList<LegalAction> legalActions);
}
