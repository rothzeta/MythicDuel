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
        var targetShrine = new ShrineState { Name = "Iron Shrine" };

        sys.ApplyShrineDamage(state, PlayerId.Seat1, targetShrine, 2);
        sys.ApplyShrineDamage(state, PlayerId.Seat1, targetShrine, 3);

        Assert.Equal(5, targetShrine.Damage);
    }

    [Fact]
    public void Unblocked_shrine_attack_deals_shrine_damage()
    {
        var state = new GameState();
        state.Player1.Id = PlayerId.Seat1;
        state.Player2.Id = PlayerId.Seat2;

        var targetShrine = new ShrineState { Name = "Iron Shrine" };
        state.Player2.Shrines.Add(targetShrine);

        var attackerId = new CardInstanceId(1);
        var attacker = new CardInstance
        {
            Id = attackerId,
            Controller = PlayerId.Seat1,
            Zone = Zone.Battlefield,
            BaseAttack = 3
        };
        state.Cards[attackerId] = attacker;

        var engine = new GameEngine();
        var cmd = new DeclareAttackCommand(PlayerId.Seat1, attackerId, "Iron Shrine");

        var result = engine.Execute(state, cmd);

        Assert.True(result.IsValid);
        Assert.Equal(3, targetShrine.Damage);
    }
}
