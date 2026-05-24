using MythicDuel.Engine.Game;
using MythicDuel.Engine.Ids;
using MythicDuel.Engine.LegalActions;
using MythicDuel.Engine.Views;
using Xunit;

namespace MythicDuel.Engine.Tests;

public class LegalActionTests
{
    [Fact]
    public void Generator_Returns_Actions()
    {
        var generator = new LegalActionGenerator();
        var state = new GameState();
        var view = new GameView(PlayerId.Seat1);
        var actions = generator.Generate(state, view, PlayerId.Seat1);
        Assert.NotNull(actions);
    }
}
