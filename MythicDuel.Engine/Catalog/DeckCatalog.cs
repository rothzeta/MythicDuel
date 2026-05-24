using System.Collections.Generic;

namespace MythicDuel.Engine.Catalog;

public static class DeckCatalog
{
    public static IReadOnlyList<string> CreateDeck(string deckName)
    {
        return new List<string> { "red.hunter", "iron.hyena" };
    }
}
