using System;
using System.Collections.Generic;
using MythicDuel.Engine.LegalActions;
using MythicDuel.Engine.Views;
namespace MythicDuel.Engine.Bots;
public sealed class RandomLegalBot : IGameBot
{
    private readonly Random _random = new();
    public LegalAction ChooseAction(GameView view, IReadOnlyList<LegalAction> legalActions)
    {
        if (legalActions.Count == 0) return null;
        return legalActions[_random.Next(legalActions.Count)];
    }
}
