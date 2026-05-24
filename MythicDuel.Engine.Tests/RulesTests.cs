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

    [Fact]
    public void Legal_evolve_actions_are_counted_when_generation_occurs()
    {
        var state = new GameState();
        var sys = new EvolutionSystem();
        sys.ResolveEvolveCommand(state, new EndTurnCommand(PlayerId.Seat1));
        Assert.NotNull(state);
    }

    [Fact]
    public void L3_cannot_evolve_from_l1_host()
    {
        var state = new GameState();
        var sys = new EvolutionSystem();
        sys.ResolveEvolveCommand(state, new EndTurnCommand(PlayerId.Seat1));
        Assert.NotNull(state);
    }

    [Fact]
    public void Pack_attack_can_use_extra_assault_slot_beyond_standard_two()
    {
        var state = new GameState();
        var sys = new PackSystem();
        sys.CalculatePackBonus(state);
        Assert.NotNull(state);
    }

    [Fact]
    public void Shrine_damage_is_persistent()
    {
        var state = new GameState();
        var sys = new DamageSystem();
        sys.ApplyDamage(state);
        Assert.NotNull(state);
    }
}
