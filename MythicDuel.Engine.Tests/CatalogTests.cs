using MythicDuel.Engine.Catalog;
using Xunit;

namespace MythicDuel.Engine.Tests;

public class CatalogTests
{
    [Fact]
    public void Catalog_Loads_Decks()
    {
        var deck = DeckCatalog.CreateDeck("red");
        Assert.NotNull(deck);
        Assert.True(deck.Count > 0);

        var cards = CardCatalog.CreateCardDefinitions();
        Assert.NotNull(cards);
        Assert.True(cards.Count > 0);
        Assert.True(cards.ContainsKey("red.hunter"));
        Assert.True(cards.ContainsKey("iron.hyena"));
    }
}
