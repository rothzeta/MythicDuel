using System.Collections.Generic;
using MythicDuel.Engine.Ids;
using MythicDuel.Engine.Cards;

namespace MythicDuel.Engine.Catalog;

public static class CardCatalog
{
    public static IReadOnlyDictionary<string, CardDefinition> CreateCardDefinitions()
    {
        return new Dictionary<string, CardDefinition>
        {
            { "red.hunter", new CardDefinition { Id = new CardDefinitionId("red.hunter") } },
            { "iron.hyena", new CardDefinition { Id = new CardDefinitionId("iron.hyena") } }
        };
    }
}
