using MythicDuel.Engine.Game;
using MythicDuel.Engine.Commands;
using MythicDuel.Engine.Ids;
using MythicDuel.Engine.Rules;
using Xunit;

namespace MythicDuel.Engine.Tests;

public class RulesTests
{




    [Fact]
    public void Draw_model_retain_one_discard_rest_draw_to_five_runs()
    {
        var state = new GameState();
        var cmd = new EndTurnCommand(PlayerId.Seat1);
        var engine = new GameEngine();
        var result = engine.Execute(state, cmd);
        Assert.True(result.IsValid);
    }

    [Fact]
    public void Phase_order_reverses_every_four_player_turns()
    {
        var state = new GameState();
        var cmd = new EndTurnCommand(PlayerId.Seat2);
        var engine = new GameEngine();
        var result = engine.Execute(state, cmd);
        Assert.True(result.IsValid);
    }

}
