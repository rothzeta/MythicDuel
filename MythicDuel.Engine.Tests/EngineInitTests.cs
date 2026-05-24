using MythicDuel.Engine.Game;
using MythicDuel.Engine.Commands;
using MythicDuel.Engine.Ids;
using Xunit;
namespace MythicDuel.Engine.Tests;
public class EngineInitTests
{
    [Fact]
    public void Engine_Can_Execute_EndTurnCommand()
    {
        var engine = new GameEngine();
        var state = new GameState();
        var cmd = new EndTurnCommand(PlayerId.Seat1);
        engine.Execute(state, cmd);
        Assert.NotNull(state);
    }
}
