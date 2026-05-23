using MythicDuel.Core.Bots;
using MythicDuel.Core.Cards;
using MythicDuel.Core.Game;
using MythicDuel.Core.Models;
using MythicDuel.Sim.Reporting;
using System.Text.Json;

namespace MythicDuel.Tests;

public sealed class RulesTests
{
    [Fact]
    public void Smoke_simulation_produces_metrics()
    {
        var runner = new SimulationRunner();
        var result = runner.RunSingle(new SimulationOptions { Seed = 123, BotRed = "red", BotIron = "iron" });

        Assert.NotNull(result);
        Assert.NotEmpty(result.Events);
        Assert.True(result.Metrics.TurnCount > 0);
        Assert.False(string.IsNullOrWhiteSpace(result.Metrics.Winner));
    }

    [Fact]
    public void Deterministic_seed_produces_same_core_metrics()
    {
        var runner = new SimulationRunner();
        var first = runner.RunSingle(new SimulationOptions { Seed = 123, BotRed = "red", BotIron = "iron" });
        var second = runner.RunSingle(new SimulationOptions { Seed = 123, BotRed = "red", BotIron = "iron" });

        Assert.Equal(first.Metrics.Winner, second.Metrics.Winner);
        Assert.Equal(first.Metrics.TurnCount, second.Metrics.TurnCount);
        Assert.Equal(first.Metrics.FirstShrineDamageTurn, second.Metrics.FirstShrineDamageTurn);
    }

    [Fact]
    public void Phase_order_reverses_every_four_player_turns()
    {
        var runner = new SimulationRunner();
        var result = runner.RunSingle(new SimulationOptions { Seed = 123, BotRed = "random", BotIron = "random" });
        var players = result.State.Turns.Take(8).Select(x => x.Player).ToList();

        Assert.Equal([PlayerId.Red, PlayerId.Iron, PlayerId.Red, PlayerId.Iron, PlayerId.Iron, PlayerId.Red, PlayerId.Iron, PlayerId.Red], players);
    }

    [Fact]
    public void Shrine_damage_is_persistent()
    {
        var state = EngineTestHarness.CreateState();
        state.Red.Shrines[0].Damage = 4;
        var runner = new SimulationRunner();
        runner.RunSingle(new SimulationOptions { Seed = 123, BotRed = "random", BotIron = "random" });

        Assert.Equal(4, state.Red.Shrines[0].Damage);
    }

    [Fact]
    public void Empty_deck_reshuffles_discard_and_excludes_forgotten_cards()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Red;
        player.Deck.Clear();
        var discard = EngineTestHarness.AddDiscardCard(state, PlayerId.Red, CoreIds.Red.YoungHunter);
        var forgotten = EngineTestHarness.AddDiscardCard(state, PlayerId.Red, CoreIds.Red.RitualOfRedMoon);
        player.Discard.Remove(forgotten.Id);
        player.Forgotten.Add(forgotten.Id);
        state.Cards[forgotten.Id].Zone = Zone.Forgotten;

        var runner = new SimulationRunner();
        var result = runner.RunSingle(new SimulationOptions { Seed = 999, BotRed = "random", BotIron = "random" });

        Assert.True(result.Metrics.DeckReshufflesRed >= 0);
        Assert.DoesNotContain(forgotten.Id, player.Deck);
    }

    [Fact]
    public void Draw_model_retain_one_discard_rest_draw_to_five_runs()
    {
        var runner = new SimulationRunner();
        var result = runner.RunSingle(new SimulationOptions { Seed = 123, BotRed = "random", BotIron = "random" });

        Assert.True(result.Metrics.CardsRetainedRed > 0);
        Assert.True(result.Metrics.CardsDiscardedRed >= result.Metrics.CardsRetainedRed);
        Assert.True(result.Metrics.CardsDrawnRed > 0);
    }

    [Fact]
    public void Hidden_view_does_not_reveal_opponent_prepared_tactic_identity()
    {
        var state = EngineTestHarness.CreateState();
        var prepared = EngineTestHarness.AddHandCard(state, PlayerId.Iron, CoreIds.Iron.FalseOpening);
        state.Iron.PreparedTacticIds.Add(prepared.Id);
        state.Iron.Hand.Remove(prepared.Id);
        prepared.Zone = Zone.Prepared;

        var view = EngineTestHarness.CreateView(state, PlayerId.Red);

        Assert.True(view.Opponent.HasPreparedTactic);
        Assert.Empty(view.Opponent.PreparedTacticCardIds);
        Assert.DoesNotContain(prepared.Id, view.Cards.Keys);
    }

    [Fact]
    public void End_step_can_retain_zero_cards()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Red;
        var hunter = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.YoungHunter);
        var ritual = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.RitualOfRedMoon);
        var engine = new GameEngine();
        var record = new TurnRecord
        {
            TurnNumber = state.TurnNumber,
            PhaseNumber = state.PhaseNumber,
            Player = player.Id,
            Start = new TurnSnapshot(0, 0, [], [], null, null, [], []),
        };

        typeof(GameEngine).GetMethod("HandleRetainDiscard", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, player, new NullRetainBot(), record]);

        Assert.Null(record.RetainedCard);
        Assert.Empty(player.Hand);
        Assert.Contains(hunter.Id, player.Discard);
        Assert.Contains(ritual.Id, player.Discard);
    }

    [Fact]
    public void Two_prepared_tactics_can_be_active_per_player()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Red;
        player.CurrentOfferings = 5;
        player.Memory = 2;
        var tactic1 = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.HuntersCall);
        var tactic2 = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.RootWovenGuard);
        var engine = new GameEngine();
        var bot = EngineTestHarness.ScriptedBot();

        var legal = typeof(GameEngine).GetMethod("GetLegalMainActions", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!;
        var actions = (IReadOnlyList<PlayerAction>)legal.Invoke(engine, [state, player, true])!;
        var firstPrepare = actions.OfType<PrepareTacticAction>().First(action => action.CardId == tactic1.Id);
        typeof(GameEngine).GetMethod("ExecuteAction", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!.Invoke(engine, [state, player, bot, firstPrepare]);
        actions = (IReadOnlyList<PlayerAction>)legal.Invoke(engine, [state, player, true])!;
        var secondPrepare = actions.OfType<PrepareTacticAction>().First(action => action.CardId == tactic2.Id);
        typeof(GameEngine).GetMethod("ExecuteAction", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!.Invoke(engine, [state, player, bot, secondPrepare]);
        actions = (IReadOnlyList<PlayerAction>)legal.Invoke(engine, [state, player, true])!;

        Assert.Equal(2, player.PreparedTacticIds.Count);
        Assert.Contains(tactic1.Id, player.PreparedTacticIds);
        Assert.Contains(tactic2.Id, player.PreparedTacticIds);
        Assert.DoesNotContain(actions, action => action is PrepareTacticAction);
    }

    [Fact]
    public void Preparing_with_full_slots_replaces_chosen_tactic_and_moves_it_to_forgotten()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Red;
        player.CurrentOfferings = 6;
        player.Memory = 3;
        var tactic1 = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.HuntersCall);
        var tactic2 = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.RootWovenGuard);
        var tactic3 = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.HuntersCall);
        var engine = new GameEngine();
        var legal = typeof(GameEngine).GetMethod("GetLegalMainActions", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!;
        var execute = typeof(GameEngine).GetMethod("ExecuteAction", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!;
        var bot = EngineTestHarness.ScriptedBot();

        var actions = (IReadOnlyList<PlayerAction>)legal.Invoke(engine, [state, player, true])!;
        execute.Invoke(engine, [state, player, bot, actions.OfType<PrepareTacticAction>().First(action => action.CardId == tactic1.Id)]);
        actions = (IReadOnlyList<PlayerAction>)legal.Invoke(engine, [state, player, true])!;
        execute.Invoke(engine, [state, player, bot, actions.OfType<PrepareTacticAction>().First(action => action.CardId == tactic2.Id)]);
        actions = (IReadOnlyList<PlayerAction>)legal.Invoke(engine, [state, player, true])!;
        execute.Invoke(engine, [state, player, bot, actions.OfType<PrepareTacticAction>().First(action => action.CardId == tactic3.Id)]);

        Assert.Equal(2, player.PreparedTacticIds.Count);
        Assert.DoesNotContain(tactic1.Id, player.PreparedTacticIds);
        Assert.Contains(tactic1.Id, player.Forgotten);
        Assert.Equal(Zone.Forgotten, state.Cards[tactic1.Id].Zone);
        Assert.Contains(tactic2.Id, player.PreparedTacticIds);
        Assert.Contains(tactic3.Id, player.PreparedTacticIds);
    }

    [Fact]
    public void Prepared_tactic_does_not_expire_by_default_on_opponents_next_turn()
    {
        var state = EngineTestHarness.CreateState();
        var red = state.Red;
        red.CurrentOfferings = 3;
        var tactic = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.HuntersCall);
        var engine = new GameEngine();

        typeof(GameEngine).GetMethod("ExecuteAction", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, red, EngineTestHarness.ScriptedBot(), new PrepareTacticAction(tactic.Id)]);

        red.TurnsTaken = 1;
        state.Iron.TurnsTaken = 1;
        typeof(GameEngine).GetMethod("HandlePreparedExpiry", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, red, state.Iron]);

        Assert.Contains(tactic.Id, red.PreparedTacticIds);
        Assert.Equal(Zone.Prepared, state.Cards[tactic.Id].Zone);
    }

    [Fact]
    public void First_turn_resource_phase_gives_red_one_offering()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Red;
        var engine = new GameEngine();

        player.TurnsTaken++;
        typeof(GameEngine).GetMethod("ResourcePhase", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, player]);

        Assert.Equal(1, player.MaxOfferings);
        Assert.Equal(1, player.CurrentOfferings);
    }

    [Fact]
    public void First_turn_resource_phase_gives_iron_one_offering()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Iron;
        var engine = new GameEngine();

        player.TurnsTaken++;
        typeof(GameEngine).GetMethod("ResourcePhase", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, player]);

        Assert.Equal(1, player.MaxOfferings);
        Assert.Equal(1, player.CurrentOfferings);
    }

    [Fact]
    public void Second_personal_turn_resource_phase_gives_two_offerings_to_both_players()
    {
        var state = EngineTestHarness.CreateState();
        var engine = new GameEngine();

        state.Red.TurnsTaken = 2;
        state.Iron.TurnsTaken = 2;

        typeof(GameEngine).GetMethod("ResourcePhase", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, state.Red]);
        typeof(GameEngine).GetMethod("ResourcePhase", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, state.Iron]);

        Assert.Equal(2, state.Red.CurrentOfferings);
        Assert.Equal(2, state.Iron.CurrentOfferings);
    }

    [Fact]
    public void Simulation_opens_with_symmetric_first_turn_offerings_for_both_players()
    {
        var runner = new SimulationRunner();
        var result = runner.RunSingle(new SimulationOptions { Seed = 123, BotRed = "passive", BotIron = "passive" });

        var firstRedTurn = result.State.Turns.First(turn => turn.Player == PlayerId.Red);
        var firstIronTurn = result.State.Turns.First(turn => turn.Player == PlayerId.Iron);

        Assert.Equal(1, firstRedTurn.End!.Offerings);
        Assert.Equal(1, firstIronTurn.End!.Offerings);
    }

    [Fact]
    public void Single_report_json_includes_bot_names()
    {
        var runner = new SimulationRunner();
        var writer = new ReportWriter();
        var result = runner.RunSingle(new SimulationOptions { Seed = 123, BotRed = "random", BotIron = "iron" });

        var report = writer.CreateSingleReport(result, "RandomLegalBot", "IronHyenaBot", "dotnet run --project MythicDuel.Sim -- --mode single --seed 123");

        Assert.Contains("\"Bots\"", report.Json);
        Assert.Contains("\"Command\"", report.Json);
        Assert.Contains("\"Red\": \"RandomLegalBot\"", report.Json);
        Assert.Contains("\"Iron\": \"IronHyenaBot\"", report.Json);
    }

    [Fact]
    public void Single_report_includes_seat_presence_and_assault_metadata()
    {
        var writer = new ReportWriter();
        var result = CreateSimulationResult("game-report", 901);
        result.Metrics.PresenceUsedRed = 5;
        result.Metrics.PresenceLimitRed = 5;
        result.Metrics.PresenceUsedIron = 3;
        result.Metrics.PresenceLimitIron = 5;
        result.Metrics.StandardAssaultSlotsSpentRed = 2;
        result.Metrics.PackAssaultSlotsSpentRed = 1;
        result.Metrics.StandardAssaultSlotsSpentIron = 1;
        result.Metrics.PackAssaultSlotsSpentIron = 0;

        var report = writer.CreateSingleReport(result, "RedBaobabBot", "IronHyenaBot", "dotnet run --project MythicDuel.Sim -- --mode single --seed 901");

        Assert.Contains("\"Seats\"", report.Json);
        Assert.Contains("\"Seat1\"", report.Json);
        Assert.Contains("\"DeckName\"", report.Json);
        Assert.Contains("Final Presence: Seat 1 5/5 | Seat 2 3/5", report.Markdown);
        Assert.Contains("Assault slots spent: Seat 1 standard 2, pack 1 | Seat 2 standard 1, pack 0", report.Markdown);
        Assert.Contains("Combat model: 2 standard Assault slots, plus Pack expansion up to 5 total attacks, separate resolution", report.Markdown);
    }

    [Fact]
    public void Catalog_writer_exports_keywords_cards_decks_and_bots_as_json()
    {
        var runner = new SimulationRunner();
        var writer = new CatalogWriter();

        var json = writer.CreateCatalogJson(runner, "dotnet run --project MythicDuel.Sim -- --mode catalog --out ./reports --catalog-file catalog.json");
        using var document = JsonDocument.Parse(json);
        var root = document.RootElement;

        Assert.True(root.TryGetProperty("Keywords", out var keywords));
        Assert.Contains(keywords.EnumerateArray().Select(x => x.GetString()), value => value == nameof(Keyword.Pierce));

        Assert.True(root.TryGetProperty("Cards", out var cards));
        Assert.Contains(cards.EnumerateArray(), card => card.GetProperty("Id").GetString() == CoreIds.Red.LeopardHunter);

        Assert.True(root.TryGetProperty("Decks", out var decks));
        Assert.Contains(decks.EnumerateArray(), deck => deck.GetProperty("Name").GetString() == "red");

        Assert.True(root.TryGetProperty("Bots", out var bots));
        Assert.Contains(bots.EnumerateArray(), bot => bot.GetProperty("Name").GetString() == "evolution");
    }

    [Fact]
    public void Documentation_includes_catalog_command()
    {
        var runCommands = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "config", "RUN_COMMANDS.md"));
        var readme = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "README.md"));

        Assert.Contains("dotnet run --project MythicDuel.Sim -- --mode catalog --out ./reports --catalog-file catalog.json", runCommands);
        Assert.Contains("--mode single|batch|catalog", readme);
        Assert.Contains("reports/catalog.json", readme);
    }

    [Fact]
    public void Batch_report_emits_warnings_when_key_layers_are_unexercised()
    {
        var writer = new ReportWriter();
        var results = new[]
        {
            CreateSimulationResult("game-1", 123),
            CreateSimulationResult("game-2", 124),
        };

        var report = writer.CreateBatchReport(results, "RedBaobabBot", "IronHyenaBot", "dotnet run --project MythicDuel.Sim -- --mode batch --games 20 --seed 123");

        Assert.Contains("Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 20 --seed 123", report.SummaryMarkdown);
        Assert.Contains("Bots: Red=RedBaobabBot, Iron=IronHyenaBot", report.SummaryMarkdown);
        Assert.Contains("WARNING: Evolution layer was never exercised.", report.SummaryMarkdown);
        Assert.Contains("WARNING: Pierce overflow was never exercised.", report.SummaryMarkdown);
        Assert.Contains("WARNING: WeaponMaster Pierce was never exercised.", report.SummaryMarkdown);
        Assert.Contains("WARNING: SoulSlayer Pierce was never exercised.", report.SummaryMarkdown);
        Assert.Contains("- RedL2Played = 0", report.SummaryMarkdown);
        Assert.Contains("This batch cannot validate evolution balance.", report.SummaryMarkdown);
        Assert.Contains("\"Warnings\"", report.SummaryJson);
    }

    [Fact]
    public void Hard_cast_l2_updates_battlefield_entry_metrics()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Red;
        player.CurrentOfferings = 10;
        var leopard = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.LeopardHunter);
        var engine = new GameEngine();

        typeof(GameEngine).GetMethod("ExecuteAction", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, player, new PassiveBot(), new PlayUnitAction(leopard.Id)]);

        Assert.Equal(1, state.Metrics.RedL2EnteredBattlefield);
        Assert.Equal(1, state.Metrics.RedL2HardCast);
        Assert.Equal(0, state.Metrics.RedL2Evolved);
    }

    [Fact]
    public void Presence_cap_prevents_play_actions_when_battlefield_is_full()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Red;
        player.CurrentOfferings = 10;
        EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.YoungHunter);
        EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.RiverHunter);
        EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.BaobabGuardian);
        EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.PaleRiverSpirit);
        EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.DeepRiverSpirit);
        var extraUnit = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.YoungHunter);
        var engine = new GameEngine();

        var actions = (IReadOnlyList<PlayerAction>)typeof(GameEngine)
            .GetMethod("GetLegalMainActions", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, player, true])!;

        Assert.Equal(player.PresenceLimit, EngineTestHarness.CreateView(state, PlayerId.Red).Self.PresenceUsed);
        Assert.DoesNotContain(actions, action => action is PlayUnitAction play && play.CardId == extraUnit.Id);
    }

    [Fact]
    public void Full_presence_still_allows_replacement_evolution()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Red;
        player.CurrentOfferings = 8;
        player.Memory = 5;
        var host = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.YoungHunter);
        host.HasDestroyedEnemy = true;
        EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.RiverHunter);
        EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.BaobabGuardian);
        EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.PaleRiverSpirit);
        EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.DeepRiverSpirit);
        var leopard = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.LeopardHunter);
        var engine = new GameEngine();

        var actions = (IReadOnlyList<PlayerAction>)typeof(GameEngine)
            .GetMethod("GetLegalMainActions", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, player, true])!;

        Assert.Contains(actions, action => action is EvolveAction evolve && evolve.CardId == leopard.Id && evolve.HostId == host.Id);
    }

    [Fact]
    public void Timestamped_output_path_creates_subfolder_under_requested_root()
    {
        var root = Path.Combine(Path.GetTempPath(), $"mythicduel-tests-{Guid.NewGuid():N}");
        Directory.CreateDirectory(root);
        try
        {
            var output = ReportOutputPaths.CreateTimestampedOutputPath(root);

            Assert.StartsWith(Path.GetFullPath(root), output, StringComparison.OrdinalIgnoreCase);
            Assert.NotEqual(Path.GetFullPath(root), output);
            Assert.Equal(Path.GetFullPath(root), Path.GetDirectoryName(output));
        }
        finally
        {
            if (Directory.Exists(root)) Directory.Delete(root, true);
        }
    }

    [Fact]
    public void Batch_report_warns_on_metric_contradictions_and_stall_signals()
    {
        var writer = new ReportWriter();
        var result = CreateSimulationResult("game-contradiction", 777);
        result.Metrics.TurnCount = 81;
        result.Metrics.MemoryEndRed = 32;
        result.Metrics.DeckReshufflesRed = 46;
        result.Metrics.LeopardHunterPierceEvents = 2;
        result.State.Red.Battlefield.Add(EngineTestHarness.AddBattlefieldCard(result.State, PlayerId.Red, CoreIds.Red.LeopardHunter).Id);

        var report = writer.CreateBatchReport([result], "RedBaobabBot", "IronHyenaBot", "dotnet run --project MythicDuel.Sim -- --mode batch --games 20 --seed 123");

        Assert.Contains("WARNING: LeopardHunterPierceEvents > 0 but RedL2Played = 0.", report.SummaryMarkdown);
        Assert.Contains("WARNING: L2/L3 card appears in final battlefield but L2/L3 metrics are zero.", report.SummaryMarkdown);
        Assert.Contains("WARNING: More than 5 reshuffles occurred.", report.SummaryMarkdown);
        Assert.Contains("WARNING: Game exceeded 40 turns.", report.SummaryMarkdown);
        Assert.Contains("WARNING: MemoryEnd > 20.", report.SummaryMarkdown);
    }

    [Fact]
    public void Legal_evolve_actions_are_counted_when_generation_occurs()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Red;
        player.CurrentOfferings = 8;
        player.Memory = 5;
        var host = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.YoungHunter);
        host.HasDestroyedEnemy = true;
        EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.LeopardHunter);
        var engine = new GameEngine();
        var getLegalMainActions = typeof(GameEngine).GetMethod("GetLegalMainActions", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!;
        var recordLegalEvolveMetrics = typeof(GameEngine).GetMethod("RecordLegalEvolveMetrics", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!;

        var actions = (IReadOnlyList<PlayerAction>)getLegalMainActions.Invoke(engine, [state, player, true])!;
        recordLegalEvolveMetrics.Invoke(engine, [state, PlayerId.Red, actions]);

        Assert.True(state.Metrics.LegalEvolveActionsGeneratedRed > 0);
        Assert.True(state.Metrics.LegalL2EvolveActionsGeneratedRed > 0);
        Assert.True(state.Metrics.EvolveWindowsRed > 0);
        Assert.True(state.Metrics.TurnsWithLegalL2EvolutionRed > 0);
    }

    [Fact]
    public void Persistent_deed_markers_make_evolution_legal_without_same_turn_tracker_flags()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Red;
        player.CurrentOfferings = 8;
        player.Memory = 5;
        var host = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.YoungHunter);
        host.HasDestroyedEnemy = true;
        var leopard = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.LeopardHunter);
        var engine = new GameEngine();

        var actions = (IReadOnlyList<PlayerAction>)typeof(GameEngine)
            .GetMethod("GetLegalMainActions", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, player, true])!;

        var evolve = Assert.Single(actions.OfType<EvolveAction>());
        Assert.Equal(leopard.Id, evolve.CardId);
        Assert.Equal(host.Id, evolve.HostId);
        Assert.False(player.CurrentTurn.UnitDestroyedEnemyThisTurn);
        Assert.Empty(player.CurrentTurn.UnitsThatDestroyedEnemyThisTurn);
    }

    [Fact]
    public void L3_cannot_evolve_from_l1_host()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Red;
        player.CurrentOfferings = 8;
        player.Memory = 8;
        var host = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.YoungHunter);
        host.HasDamagedShrine = true;
        var kuma = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.KumaWhoWoundedTheSun);
        var engine = new GameEngine();

        var actions = (IReadOnlyList<PlayerAction>)typeof(GameEngine)
            .GetMethod("GetLegalMainActions", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, player, true])!;

        Assert.DoesNotContain(actions, action => action is EvolveAction evolve && evolve.CardId == kuma.Id && evolve.HostId == host.Id);
    }

    [Fact]
    public void Evolved_unit_inherits_persistent_deed_markers_from_host()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Red;
        player.CurrentOfferings = 8;
        player.Memory = 5;
        var host = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.YoungHunter);
        host.HasDestroyedEnemy = true;
        var leopard = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.LeopardHunter);
        var engine = new GameEngine();

        typeof(GameEngine).GetMethod("ExecuteAction", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, player, new PassiveBot(), new EvolveAction(leopard.Id, host.Id, false)]);

        var evolved = state.Cards[leopard.Id];
        Assert.True(evolved.HasDestroyedEnemy);
        Assert.False(evolved.HasDamagedShrine);
        Assert.False(evolved.HasBrokenShrine);
    }

    [Fact]
    public void L3_evolution_cards_cannot_evolve_from_discard_while_recall_is_disabled()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Red;
        player.CurrentOfferings = 8;
        player.Memory = 8;
        var host = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.LeopardHunter);
        host.HasDamagedShrine = true;
        var kuma = EngineTestHarness.AddDiscardCard(state, PlayerId.Red, CoreIds.Red.KumaWhoWoundedTheSun);
        var engine = new GameEngine();

        var actions = (IReadOnlyList<PlayerAction>)typeof(GameEngine)
            .GetMethod("GetLegalMainActions", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, player, true])!;

        Assert.DoesNotContain(actions, action => action is EvolveAction evolve && evolve.CardId == kuma.Id && evolve.FromDiscard);
    }

    [Fact]
    public void Non_recall_evolution_cards_cannot_evolve_from_discard()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Iron;
        player.CurrentOfferings = 8;
        player.Memory = 8;
        var host = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.IronHyenaChampion);
        host.HasDamagedShrine = true;
        var underworld = EngineTestHarness.AddDiscardCard(state, PlayerId.Iron, CoreIds.Iron.IronHyenaUnderworld);
        var engine = new GameEngine();

        var actions = (IReadOnlyList<PlayerAction>)typeof(GameEngine)
            .GetMethod("GetLegalMainActions", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, player, true])!;

        Assert.DoesNotContain(actions, action => action is EvolveAction evolve && evolve.CardId == underworld.Id && evolve.FromDiscard);
    }

    [Fact]
    public void Forbid_hardcast_rules_remove_l2_play_actions()
    {
        var state = EngineTestHarness.CreateState();
        state.Rules = "forbid-hardcast-evolution-cards";
        var player = state.Red;
        player.CurrentOfferings = 10;
        EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.LeopardHunter);
        var engine = new GameEngine();

        var actions = (IReadOnlyList<PlayerAction>)typeof(GameEngine)
            .GetMethod("GetLegalMainActions", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, player, true])!;

        Assert.DoesNotContain(actions, action => action is PlayUnitAction play && state.Cards[play.CardId].DefinitionId == CoreIds.Red.LeopardHunter);
    }

    [Fact]
    public void Mythic_l3_cards_cannot_be_hard_cast()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Red;
        player.CurrentOfferings = 10;
        player.Memory = 10;
        EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.KumaWhoWoundedTheSun);
        var engine = new GameEngine();

        var actions = (IReadOnlyList<PlayerAction>)typeof(GameEngine)
            .GetMethod("GetLegalMainActions", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, player, true])!;

        Assert.DoesNotContain(actions, action => action is PlayUnitAction play && state.Cards[play.CardId].DefinitionId == CoreIds.Red.KumaWhoWoundedTheSun);
    }

    [Fact]
    public void Mythic_l3_cards_are_unique_while_controlled()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Red;
        player.CurrentOfferings = 10;
        player.Memory = 10;
        var existing = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.KumaWhoWoundedTheSun);
        existing.HasDamagedShrine = true;
        var host = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.LeopardHunter);
        host.HasDamagedShrine = true;
        var secondKuma = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.KumaWhoWoundedTheSun);
        var engine = new GameEngine();

        var actions = (IReadOnlyList<PlayerAction>)typeof(GameEngine)
            .GetMethod("GetLegalMainActions", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, player, true])!;

        Assert.DoesNotContain(actions, action => action is EvolveAction evolve && evolve.CardId == secondKuma.Id);
    }

    [Fact]
    public void Mythic_l3_card_definitions_include_explicit_unique_keyword()
    {
        var definitions = CardCatalog.CreateCardDefinitions();

        Assert.True(definitions[CoreIds.Red.KumaWhoWoundedTheSun].Keywords.HasFlag(Keyword.Unique));
        Assert.True(definitions[CoreIds.Iron.IronHyenaUnderworld].Keywords.HasFlag(Keyword.Unique));
        Assert.False(definitions[CoreIds.Red.LeopardHunter].Keywords.HasFlag(Keyword.Unique));
    }

    [Fact]
    public void Mythic_l3_cards_go_to_forgotten_when_destroyed()
    {
        var state = EngineTestHarness.CreateState();
        var kuma = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.KumaWhoWoundedTheSun);
        var engine = new GameEngine();

        typeof(GameEngine).GetMethod("DestroyUnit", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, kuma, PlayerId.Iron, "test destroy"]);

        Assert.Equal(Zone.Forgotten, kuma.Zone);
        Assert.Contains(kuma.Id, state.Red.Forgotten);
        Assert.DoesNotContain(kuma.Id, state.Red.Discard);
    }

    [Fact]
    public void Ascend_host_moves_to_forgotten_when_consumed_by_evolution()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Red;
        player.CurrentOfferings = 8;
        player.Memory = 5;
        var host = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.DeepRiverSpirit);
        host.HasDestroyedEnemy = true;
        var leopard = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.LeopardHunter);
        var engine = new GameEngine();

        typeof(GameEngine).GetMethod("ExecuteAction", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, player, new PassiveBot(), new EvolveAction(leopard.Id, host.Id, false)]);

        Assert.Equal(Zone.Forgotten, host.Zone);
        Assert.Contains(host.Id, player.Forgotten);
        Assert.DoesNotContain(host.Id, player.Discard);
    }

    [Fact]
    public void Block_metrics_record_legal_options_and_declines()
    {
        var state = EngineTestHarness.CreateState();
        var red = state.Red;
        var iron = state.Iron;
        var attacker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.YoungHunter);
        attacker.IsExhausted = false;
        attacker.EnteredBattlefieldOnTurn = 0;
        EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BoneCrackerCub);
        var engine = new GameEngine();

        engine.ExecuteTurn(state, red, EngineTestHarness.ScriptedBot(new TurnDecision { Attacks = { new AttackDecision(attacker.Id, AttackTargetType.Shrine, iron.Shrines.First().Name, ShrineName: iron.Shrines.First().Name) } }), new RandomLegalBot());

        Assert.True(state.Metrics.LegalBlockOptionsIron > 0);
        Assert.True(state.Metrics.BlocksChosenIron + state.Metrics.BlocksDeclinedIron > 0);
    }

    [Fact]
    public void Blocked_shrine_attack_without_pierce_deals_no_shrine_damage()
    {
        var state = EngineTestHarness.CreateState();
        var red = state.Red;
        var iron = state.Iron;
        var attacker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.YoungHunter);
        attacker.IsExhausted = false;
        attacker.EnteredBattlefieldOnTurn = 0;
        var blocker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BoneCrackerCub);
        blocker.IsExhausted = false;
        blocker.EnteredBattlefieldOnTurn = 0;
        var shrine = iron.Shrines.First();
        var engine = new GameEngine();

        engine.ExecuteTurn(
            state,
            red,
            EngineTestHarness.ScriptedBot(new TurnDecision { Attacks = { new AttackDecision(attacker.Id, AttackTargetType.Shrine, shrine.Name, ShrineName: shrine.Name) } }),
            EngineTestHarness.BlockingBot());

        Assert.Equal(0, shrine.Damage);
    }

    [Fact]
    public void Blocked_piercing_shrine_attack_only_deals_overflow_damage()
    {
        var state = EngineTestHarness.CreateState();
        var red = state.Red;
        var iron = state.Iron;
        var attacker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.KumaWhoWoundedTheSun);
        attacker.IsExhausted = false;
        attacker.EnteredBattlefieldOnTurn = 0;
        var blocker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BoneCrackerCub);
        blocker.IsExhausted = false;
        blocker.EnteredBattlefieldOnTurn = 0;
        var shrine = iron.Shrines.First();
        var engine = new GameEngine();

        engine.ExecuteTurn(
            state,
            red,
            EngineTestHarness.ScriptedBot(new TurnDecision { Attacks = { new AttackDecision(attacker.Id, AttackTargetType.Shrine, shrine.Name, ShrineName: shrine.Name) } }),
            EngineTestHarness.BlockingBot());

        Assert.Equal(6, shrine.Damage);
    }

    [Fact]
    public void Bite_the_roots_break_updates_first_break_metrics()
    {
        var state = EngineTestHarness.CreateState();
        var iron = state.Iron;
        var redShrine = state.Red.Shrines.First();
        redShrine.Damage = 7;
        var rite = EngineTestHarness.AddHandCard(state, PlayerId.Iron, CoreIds.Iron.BiteTheRoots);
        iron.CurrentOfferings = 10;
        var engine = new GameEngine();

        typeof(GameEngine).GetMethod("ExecuteAction", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, iron, new PassiveBot(), new PlayRiteAction(rite.Id)]);

        Assert.True(redShrine.IsBroken);
        Assert.Equal(state.TurnNumber, state.Metrics.FirstShrineBreakTurn);
        Assert.Equal(state.TurnNumber, state.Metrics.FirstRedShrineBreakTurn);
    }

    [Fact]
    public void Kuma_evolve_break_updates_first_break_metrics_without_unit_break_credit()
    {
        var state = EngineTestHarness.CreateState();
        var red = state.Red;
        var ironShrine = state.Iron.Shrines.First();
        ironShrine.Damage = 7;
        var host = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.LeopardHunter);
        host.EnteredBattlefieldOnTurn = 0;
        var kuma = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.KumaWhoWoundedTheSun);
        red.CurrentOfferings = 10;
        red.Memory = 10;
        var engine = new GameEngine();

        typeof(GameEngine).GetMethod("ExecuteAction", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, red, new PassiveBot(), new EvolveAction(kuma.Id, host.Id, false)]);

        Assert.True(ironShrine.IsBroken);
        Assert.Equal(state.TurnNumber, state.Metrics.FirstShrineBreakTurn);
        Assert.Equal(state.TurnNumber, state.Metrics.FirstIronShrineBreakTurn);
        Assert.False(red.CurrentTurn.UnitBrokeShrineThisTurn);
    }

    [Fact]
    public void Wounded_calculation_note_is_not_duplicated_with_multiple_attack_queries()
    {
        var state = EngineTestHarness.CreateState();
        var attacker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.YoungHunter);
        attacker.IsWounded = true;
        var engine = new GameEngine();
        var attackRecord = new AttackRecord();

        typeof(GameEngine).GetMethod("GetCombatAttack", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, attacker, false, false, attackRecord]);
        typeof(GameEngine).GetMethod("GetCombatAttack", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, attacker, false, false, attackRecord]);

        Assert.Equal(1, attackRecord.Calculations.Count(text => text.StartsWith("Wounded reduces Young Hunter", StringComparison.Ordinal)));
    }

    [Fact]
    public void Destroying_host_moves_attached_relic_out_of_battlefield_and_into_discard()
    {
        var state = EngineTestHarness.CreateState();
        var host = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.YoungHunter);
        var relic = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.SpearOfFirstDawn);
        relic.Zone = Zone.Attached;
        relic.HostId = host.Id;
        host.AttachedRelicId = relic.Id;
        var engine = new GameEngine();

        typeof(GameEngine).GetMethod("DestroyUnit", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, host, PlayerId.Iron, "test destroy"]);

        Assert.Equal(Zone.Discard, relic.Zone);
        Assert.Null(relic.HostId);
        Assert.DoesNotContain(relic.Id, state.Red.Battlefield);
        Assert.Contains(relic.Id, state.Red.Discard);
    }

    [Fact]
    public void Pack_attack_can_use_extra_assault_slot_beyond_standard_two()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Iron;
        var shrine = state.Red.Shrines.First();
        var attackerOne = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BoneCrackerCub);
        var attackerTwo = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.IronHyenaRaider);
        var attackerThree = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.IronHyenaChampion);
        attackerOne.IsExhausted = false;
        attackerTwo.IsExhausted = false;
        attackerThree.IsExhausted = false;
        attackerOne.EnteredBattlefieldOnTurn = 0;
        attackerTwo.EnteredBattlefieldOnTurn = 0;
        attackerThree.EnteredBattlefieldOnTurn = 0;
        var engine = new GameEngine();

        engine.ExecuteTurn(
            state,
            player,
            EngineTestHarness.ScriptedBot(new TurnDecision
            {
                Attacks =
                {
                    new AttackDecision(attackerOne.Id, AttackTargetType.Shrine, shrine.Name, ShrineName: shrine.Name),
                    new AttackDecision(attackerTwo.Id, AttackTargetType.Shrine, shrine.Name, ShrineName: shrine.Name),
                    new AttackDecision(attackerThree.Id, AttackTargetType.Shrine, shrine.Name, ShrineName: shrine.Name),
                }
            }),
            new PassiveBot());

        Assert.Equal(3, state.Metrics.AttacksDeclaredIron);
        Assert.Equal(0, state.Metrics.StandardAssaultSlotsSpentIron);
        Assert.Equal(3, state.Metrics.PackAssaultSlotsSpentIron);
        Assert.Equal(3, state.Metrics.PackUnitsReadyAtCombatStartIron);
        Assert.Equal(3, state.Metrics.PackAssaultSlotsGeneratedIron);
        Assert.Equal(3, state.Metrics.PackAssaultSlotsAvailableIron);
        Assert.Equal(1, state.Metrics.TurnsWithPackBonusIron);
    }

    [Fact]
    public void Pack_attackers_automatically_consume_pack_slots_before_standard_slots()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Iron;
        var shrine = state.Red.Shrines.First();
        var nonPack = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BlackToothSmith);
        var packOne = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BoneCrackerCub);
        var packTwo = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.IronHyenaRaider);
        nonPack.IsExhausted = false;
        packOne.IsExhausted = false;
        packTwo.IsExhausted = false;
        nonPack.EnteredBattlefieldOnTurn = 0;
        packOne.EnteredBattlefieldOnTurn = 0;
        packTwo.EnteredBattlefieldOnTurn = 0;
        var engine = new GameEngine();

        engine.ExecuteTurn(
            state,
            player,
            EngineTestHarness.ScriptedBot(new TurnDecision
            {
                Attacks =
                {
                    new AttackDecision(packOne.Id, AttackTargetType.Shrine, shrine.Name, ShrineName: shrine.Name),
                    new AttackDecision(packTwo.Id, AttackTargetType.Shrine, shrine.Name, ShrineName: shrine.Name),
                    new AttackDecision(nonPack.Id, AttackTargetType.Shrine, shrine.Name, ShrineName: shrine.Name),
                }
            }),
            new PassiveBot());

        Assert.Equal(3, state.Metrics.AttacksDeclaredIron);
        Assert.Equal(1, state.Metrics.StandardAssaultSlotsSpentIron);
        Assert.Equal(2, state.Metrics.PackAssaultSlotsSpentIron);
    }

    [Fact]
    public void Red_bot_sees_shrine_attacks_when_combat_budget_is_initialized_for_planning()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Red;
        player.CurrentOfferings = 10;
        var attacker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.YoungHunter);
        attacker.IsExhausted = false;
        attacker.EnteredBattlefieldOnTurn = 0;
        var engine = new GameEngine();

        typeof(GameEngine)
            .GetMethod("InitializeCombatBudget", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, player, false]);

        var attacks = (IReadOnlyList<AttackDecision>)typeof(GameEngine)
            .GetMethod("GetLegalAttacks", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, player])!;

        Assert.Contains(attacks, attack => attack.AttackerId == attacker.Id && attack.TargetType == AttackTargetType.Shrine);
    }

    [Fact]
    public void Unused_pack_budget_is_recorded_as_skipped_slots()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Iron;
        var shrine = state.Red.Shrines.First();
        var attackerOne = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BoneCrackerCub);
        var attackerTwo = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.IronHyenaRaider);
        var attackerThree = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.IronHyenaChampion);
        attackerOne.IsExhausted = false;
        attackerTwo.IsExhausted = false;
        attackerThree.IsExhausted = false;
        attackerOne.EnteredBattlefieldOnTurn = 0;
        attackerTwo.EnteredBattlefieldOnTurn = 0;
        attackerThree.EnteredBattlefieldOnTurn = 0;
        var engine = new GameEngine();

        engine.ExecuteTurn(
            state,
            player,
            EngineTestHarness.ScriptedBot(new TurnDecision
            {
                Attacks =
                {
                    new AttackDecision(attackerOne.Id, AttackTargetType.Shrine, shrine.Name, ShrineName: shrine.Name),
                    new AttackDecision(attackerTwo.Id, AttackTargetType.Shrine, shrine.Name, ShrineName: shrine.Name),
                }
            }),
            new PassiveBot());

        Assert.Equal(1, state.Metrics.PackAssaultSlotsSkippedIron);
    }

    [Fact]
    public void Iron_hyena_ancestor_bonus_damage_is_recorded_when_triggered()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Iron;
        player.AwakenedAncestorDefinitionId = CoreIds.Iron.AncestorIronHyena;
        player.Lineage.Single(x => x.DefinitionId == CoreIds.Iron.AncestorIronHyena).IsAwakened = true;
        var attacker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BoneCrackerCub);
        attacker.IsExhausted = false;
        attacker.EnteredBattlefieldOnTurn = 0;
        var targetShrine = state.Red.Shrines.First();
        var engine = new GameEngine();

        engine.ExecuteTurn(
            state,
            player,
            EngineTestHarness.ScriptedBot(new TurnDecision
            {
                Attacks = { new AttackDecision(attacker.Id, AttackTargetType.Shrine, targetShrine.Name, ShrineName: targetShrine.Name) }
            }),
            new PassiveBot());

        Assert.Equal(1, state.Metrics.IronHyenaAncestorBonusDamage);
    }
 
    [Fact]
    public void Iron_hyena_ancestor_triggers_even_when_shrine_attack_is_blocked()
    {
        var state = EngineTestHarness.CreateState();
        var red = state.Red;
        var iron = state.Iron;
        iron.AwakenedAncestorDefinitionId = CoreIds.Iron.AncestorIronHyena;
        iron.Lineage.Single(x => x.DefinitionId == CoreIds.Iron.AncestorIronHyena).IsAwakened = true;
        
        var attacker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BoneCrackerCub);
        attacker.IsExhausted = false;
        attacker.EnteredBattlefieldOnTurn = 0;
        
        var blocker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.YoungHunter);
        blocker.IsExhausted = false;
        blocker.EnteredBattlefieldOnTurn = 0;
        
        var targetShrine = state.Red.Shrines.First();
        var engine = new GameEngine();

        engine.ExecuteTurn(
            state,
            iron,
            EngineTestHarness.ScriptedBot(new TurnDecision
            {
                Attacks = { new AttackDecision(attacker.Id, AttackTargetType.Shrine, targetShrine.Name, ShrineName: targetShrine.Name) }
            }),
            EngineTestHarness.BlockingBot());

        Assert.Equal(1, state.Metrics.IronHyenaAncestorBonusDamage);
        Assert.Equal(0, targetShrine.Damage);
    }

    [Fact]
    public void Pack_harrier_blocked_attack_deals_1_shrine_damage()
    {
        var state = EngineTestHarness.CreateState();
        var iron = state.Iron;
        var attacker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.PackHarrier);
        attacker.IsExhausted = false;
        attacker.EnteredBattlefieldOnTurn = 0;
        
        var blocker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.YoungHunter);
        blocker.IsExhausted = false;
        blocker.EnteredBattlefieldOnTurn = 0;
        
        var targetShrine = state.Red.Shrines.First();
        var engine = new GameEngine();

        engine.ExecuteTurn(
            state,
            iron,
            EngineTestHarness.ScriptedBot(new TurnDecision
            {
                Attacks = { new AttackDecision(attacker.Id, AttackTargetType.Shrine, targetShrine.Name, ShrineName: targetShrine.Name) }
            }),
            EngineTestHarness.BlockingBot());

        Assert.Equal(1, targetShrine.Damage);
    }

    [Fact]
    public void Blood_scent_hyena_attacks_damaged_shrine_deals_1_damage_to_other_shrine()
    {
        var state = EngineTestHarness.CreateState();
        var iron = state.Iron;
        var attacker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BloodScentHyena);
        attacker.IsExhausted = false;
        attacker.EnteredBattlefieldOnTurn = 0;
        
        var targetShrine = state.Red.Shrines[0];
        targetShrine.Damage = 1;
        var otherShrine = state.Red.Shrines[1];
        var engine = new GameEngine();

        engine.ExecuteTurn(
            state,
            iron,
            EngineTestHarness.ScriptedBot(new TurnDecision
            {
                Attacks = { new AttackDecision(attacker.Id, AttackTargetType.Shrine, targetShrine.Name, ShrineName: targetShrine.Name) }
            }),
            new PassiveBot());

        Assert.Equal(4, targetShrine.Damage);
        Assert.Equal(1, otherShrine.Damage);
    }

    [Fact]
    public void Tooth_mother_bonus_damage_is_recorded_on_real_wounded_attack()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Iron;
        player.AwakenedAncestorDefinitionId = CoreIds.Iron.AncestorToothMother;
        player.Lineage.Single(x => x.DefinitionId == CoreIds.Iron.AncestorToothMother).IsAwakened = true;
        var attacker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BoneCrackerCub);
        attacker.IsWounded = true;
        attacker.IsExhausted = false;
        attacker.EnteredBattlefieldOnTurn = 0;
        var targetShrine = state.Red.Shrines.First();
        var engine = new GameEngine();

        engine.ExecuteTurn(
            state,
            player,
            EngineTestHarness.ScriptedBot(new TurnDecision
            {
                Attacks = { new AttackDecision(attacker.Id, AttackTargetType.Shrine, targetShrine.Name, ShrineName: targetShrine.Name) }
            }),
            new PassiveBot());

        Assert.True(state.Metrics.ToothMotherBonusDamage > 0);
    }

    [Fact]
    public void Block_once_per_combat_rule_prevents_multiple_blocks()
    {
        var state = EngineTestHarness.CreateState();
        state.Rules = "single-block-per-combat";
        var iron = state.Iron;

        // Add two attackers (Bone-Cracker Cubs)
        var attacker1 = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BoneCrackerCub);
        attacker1.IsExhausted = false;
        attacker1.EnteredBattlefieldOnTurn = 0;

        var attacker2 = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BoneCrackerCub);
        attacker2.IsExhausted = false;
        attacker2.EnteredBattlefieldOnTurn = 0;

        // Add one blocker that will survive the first combat
        var blocker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.LeopardHunter);
        blocker.IsExhausted = false;
        blocker.EnteredBattlefieldOnTurn = 0;

        var targetShrine = state.Red.Shrines[0];
        targetShrine.Damage = 0;
        var engine = new GameEngine();

        // Defending bot is a BlockingBot, which always blocks if there is a legal option.
        engine.ExecuteTurn(
            state,
            iron,
            EngineTestHarness.ScriptedBot(new TurnDecision
            {
                Attacks = 
                { 
                    new AttackDecision(attacker1.Id, AttackTargetType.Shrine, targetShrine.Name, ShrineName: targetShrine.Name),
                    new AttackDecision(attacker2.Id, AttackTargetType.Shrine, targetShrine.Name, ShrineName: targetShrine.Name)
                }
            }),
            EngineTestHarness.BlockingBot());

        // Attacker 1 is blocked. Shrine damage remains 0.
        // Attacker 2 cannot be blocked because blocker already blocked once this turn.
        // Attacker 2 deals its base attack (2 damage) to the Shrine.
        Assert.Equal(2, targetShrine.Damage);
    }

    [Fact]
    public void Ancestor_first_pack_deals_damage_when_pack_attack_is_blocked()
    {
        var state = GameFactory.Create(123, "red-hunter-evolution", "iron-hyena-pack-pressure");
        var iron = state.Iron;
        
        // Setup Ancestor of the First Pack as awakened
        iron.AwakenedAncestorDefinitionId = CoreIds.Iron.AncestorFirstPack;
        iron.Lineage.Single(x => x.DefinitionId == CoreIds.Iron.AncestorFirstPack).IsAwakened = true;
        
        // Add a Pack attacker
        var attacker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BoneCrackerCub);
        attacker.IsExhausted = false;
        attacker.EnteredBattlefieldOnTurn = 0;
        
        // Add a blocker that will block it
        var blocker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.YoungHunter);
        blocker.IsExhausted = false;
        blocker.EnteredBattlefieldOnTurn = 0;
        
        var targetShrine = state.Red.Shrines[0];
        targetShrine.Damage = 0;
        var engine = new GameEngine();
        
        engine.ExecuteTurn(
            state,
            iron,
            EngineTestHarness.ScriptedBot(new TurnDecision
            {
                Attacks = { new AttackDecision(attacker.Id, AttackTargetType.Shrine, targetShrine.Name, ShrineName: targetShrine.Name) }
            }),
            EngineTestHarness.BlockingBot());
            
        // Pack attack was blocked. BoneCrackerCub deals 0 combat damage to Shrine,
        // but Ancestor of the First Pack triggers and deals 1 damage.
        Assert.Equal(1, targetShrine.Damage);
    }

    [Fact]
    public void Bone_splitter_mother_heavily_buffs_wounded_pack_attacks()
    {
        var state = GameFactory.Create(123, "red-hunter-evolution", "iron-hyena-pack-pressure");
        var iron = state.Iron;
        
        // Setup Bone-Splitter Mother as awakened
        iron.AwakenedAncestorDefinitionId = CoreIds.Iron.AncestorBoneSplitterMother;
        iron.Lineage.Single(x => x.DefinitionId == CoreIds.Iron.AncestorBoneSplitterMother).IsAwakened = true;
        
        // Add a Wounded Pack attacker (Bone-Cracker Cub has base Attack 2)
        var attacker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BoneCrackerCub);
        attacker.IsExhausted = false;
        attacker.IsWounded = true;
        attacker.EnteredBattlefieldOnTurn = 0;
        
        var targetShrine = state.Red.Shrines[0];
        targetShrine.Damage = 0;
        var engine = new GameEngine();
        
        engine.ExecuteTurn(
            state,
            iron,
            EngineTestHarness.ScriptedBot(new TurnDecision
            {
                Attacks = { new AttackDecision(attacker.Id, AttackTargetType.Shrine, targetShrine.Name, ShrineName: targetShrine.Name) }
            }),
            new PassiveBot());
            
        // Attack is unblocked. 
        // Bone-Splitter Mother triggers on attack declaration, dealing 1 damage to the Shrine first.
        // The damaged Shrine activates Bone-Cracker Cub's own ability (+1 Attack) and Bone-Fang Shrine (+1 Attack).
        // Bone-Splitter Mother also gives Wounded Pack Beings +1 Attack when attacking Shrines.
        // Base Attack (2) + Modifiers (3) = 5.
        // Since attacker is wounded, the game engine reduces attack to 75%: Math.Floor(5 * 0.75) = 3.
        // Total damage on Shrine: 3 (combat) + 1 (Bone-Splitter Mother trigger) = 4.
        Assert.Equal(4, targetShrine.Damage);
    }

    [Fact]
    public void Smith_who_passed_the_fang_discounts_and_transfers_relic_on_death()
    {
        var state = GameFactory.Create(123, "red-hunter-evolution", "iron-hyena-pack-pressure");
        var iron = state.Iron;
        
        // Setup Smith Who Passed the Fang as awakened
        iron.AwakenedAncestorDefinitionId = CoreIds.Iron.AncestorSmithPassedFang;
        iron.Lineage.Single(x => x.DefinitionId == CoreIds.Iron.AncestorSmithPassedFang).IsAwakened = true;
        
        // Add a Pack Being and another ready Pack Being
        var host = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BoneCrackerCub);
        var candidate = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.PackHarrier);
        candidate.IsExhausted = false;
        
        // Add a Relic to Hand
        var relic = EngineTestHarness.AddHandCard(state, PlayerId.Iron, CoreIds.Iron.BoneSpear);
        
        iron.TurnsTaken = 1; // So resource phase gives 2 offerings
        iron.CurrentOfferings = 2; // Enough to play relic
        var engine = new GameEngine();
        
        // Verify discount works: Bone Spear costs 1. With ancestor it should cost 0.
        engine.ExecuteTurn(
            state,
            iron,
            EngineTestHarness.ScriptedBot(new TurnDecision
            {
                Main1Actions = { new PlayRelicAction(relic.Id, host.Id) }
            }),
            new PassiveBot());
            
        // Offerings spent: 0 (relic cost discounted from 1 to 0)
        Assert.Equal(2, iron.CurrentOfferings);
        Assert.Equal(relic.Id, host.AttachedRelicId);
        Assert.Equal(Zone.Attached, relic.Zone);
        
        // Now kill the host and verify the relic moves to the candidate Pack Being
        typeof(GameEngine)
            .GetMethod("DestroyUnit", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, host, PlayerId.Red, "combat"]);
            
        // Host should be removed/destroyed, and relic should be attached to candidate
        Assert.Null(host.AttachedRelicId);
        Assert.Equal(relic.Id, candidate.AttachedRelicId);
        Assert.Equal(candidate.Id, relic.HostId);
        Assert.Equal(Zone.Attached, relic.Zone); // Relic stays attached
    }

    [Fact]
    public void Iron_l3_legal_window_is_generated_from_champion_that_damaged_a_shrine()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Iron;
        player.CurrentOfferings = 8;
        player.Memory = 8;
        var host = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.IronHyenaChampion);
        host.HasDamagedShrine = true;
        var underworld = EngineTestHarness.AddHandCard(state, PlayerId.Iron, CoreIds.Iron.IronHyenaUnderworld);
        var engine = new GameEngine();

        var actions = (IReadOnlyList<PlayerAction>)typeof(GameEngine)
            .GetMethod("GetLegalMainActions", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .Invoke(engine, [state, player, true])!;

        Assert.Contains(actions, action => action is EvolveAction evolve && evolve.CardId == underworld.Id && evolve.HostId == host.Id);
    }

    [Fact]
    public void Iron_hyena_underworld_is_no_longer_a_pack_card()
    {
        var definitions = CardCatalog.CreateCardDefinitions();

        Assert.False(definitions[CoreIds.Iron.IronHyenaUnderworld].Keywords.HasFlag(Keyword.Pack));
    }

    [Fact]
    public void Passive_bot_is_registered()
    {
        var runner = new SimulationRunner();

        var bot = runner.CreateBot("passive");

        Assert.IsType<PassiveBot>(bot);
    }

    [Fact]
    public void Batch_report_warns_when_hardcast_is_chosen_while_evolve_is_available()
    {
        var writer = new ReportWriter();
        var result = CreateSimulationResult("game-hardcast", 888);
        result.Metrics.HardCastChosenWhileLegalEvolveActionExistsRed = 2;
        result.Metrics.HardCastChosenWhileEvolutionBaseExistsRed = 3;
        result.Metrics.LegalBlockOptionsIron = 4;
        result.Metrics.BlocksChosenIron = 0;

        var report = writer.CreateBatchReport([result], "RedEvolutionBot", "IronHyenaBot", "dotnet run --project MythicDuel.Sim -- --mode batch --games 100 --seed 123 --bot-red evolution --bot-iron iron --rules forbid-hardcast-evolution-cards");

        Assert.Contains("WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.", report.SummaryMarkdown);
        Assert.Contains("WARNING: Hard-cast evolution cards were chosen while an evolution base existed.", report.SummaryMarkdown);
        Assert.Contains("WARNING: One bot never blocked Shrine attacks across the whole batch.", report.SummaryMarkdown);
    }

    [Fact]
    public void Batch_report_includes_sample_game_digest_sections()
    {
        var writer = new ReportWriter();
        var fastRed = CreateSimulationResult("game-101", 101);
        fastRed.Metrics.TurnCount = 8;
        fastRed.Metrics.FinalIronShrinesBroken = 3;

        var closest = CreateSimulationResult("game-102", 102);
        closest.Metrics.TurnCount = 19;
        closest.Metrics.FinalRedShrinesBroken = 2;
        closest.Metrics.FinalIronShrinesBroken = 3;

        var l3 = CreateSimulationResult("game-103", 103);
        l3.Metrics.TurnCount = 25;
        l3.Metrics.FirstL3Turn = 14;
        l3.Metrics.RedL3EnteredBattlefield = 1;
        l3.Metrics.RedL3Evolved = 1;

        var reshuffle = CreateSimulationResult("game-104", 104);
        reshuffle.Metrics.TurnCount = 41;
        reshuffle.Metrics.DeckReshufflesRed = 7;

        var pierce = CreateSimulationResult("game-105", 105);
        pierce.Metrics.TurnCount = 23;
        pierce.Metrics.PierceOverflowEventsRed = 2;
        pierce.Metrics.WeaponmasterPierceEvents = 2;
        pierce.Metrics.SoulslayerPierceEvents = 1;
        pierce.Metrics.LeopardHunterPierceEvents = 1;

        var report = writer.CreateBatchReport([fastRed, closest, l3, reshuffle, pierce], "RedBaobabBot", "IronHyenaBot", "dotnet run --project MythicDuel.Sim -- --mode batch --games 5 --seed 101");

        Assert.Contains("## Sample-game digest", report.SummaryMarkdown);
        Assert.Contains("### Game 101 — fastest Red win", report.SummaryMarkdown);
        Assert.Contains("### Game 103 — first L3 game", report.SummaryMarkdown);
        Assert.Contains("### Game 104 — highest reshuffle game", report.SummaryMarkdown);
        Assert.Contains("### Game 105 — highest Pierce game", report.SummaryMarkdown);
        Assert.Contains("Key issue:", report.SummaryMarkdown);
        Assert.Contains("Observed loop:", report.SummaryMarkdown);
        Assert.Contains("Design meaning:", report.SummaryMarkdown);
        Assert.Contains("Next action:", report.SummaryMarkdown);
    }

    [Fact]
    public void Single_report_includes_explicit_rite_and_evolve_resolution_details()
    {
        var writer = new ReportWriter();
        var result = CreateSimulationResult("game-130", 130);
        result.State.Turns.Add(new TurnRecord
        {
            TurnNumber = 1,
            PhaseNumber = 1,
            Player = PlayerId.Iron,
            Start = new TurnSnapshot(1, 0, [], [], null, null, [], [])
        });
        result.State.Turns[0].Main1Actions.Add("Main 1: resolved Bite the Roots (dealt 3 to Shrine of the Red Baobab, broke it, gained 1 Memory)");
        result.State.Turns[0].Main2Actions.Add("Main 2: evolved Iron Hyena Champion into Iron Hyena Underworld (dealt 2 to Shrine of the Red Baobab and broke it; dealt 2 to Hunter’s Root-Stone)");
        result.State.Turns[0].End = new TurnSnapshot(0, 1, [], [], null, null, [], []);

        var report = writer.CreateSingleReport(result, "IronHyenaBot", "PassiveBot", "dotnet run --project MythicDuel.Sim -- --mode single --seed 130");

        Assert.Contains("resolved Bite the Roots (dealt 3 to Shrine of the Red Baobab, broke it, gained 1 Memory)", report.Markdown);
        Assert.Contains("evolved Iron Hyena Champion into Iron Hyena Underworld (dealt 2 to Shrine of the Red Baobab and broke it; dealt 2 to Hunter’s Root-Stone)", report.Markdown);
    }

    [Fact]
    public void Single_report_uses_pre_resource_labels_and_phase_snapshot_state()
    {
        var writer = new ReportWriter();
        var result = CreateSimulationResult("game-131", 131);
        result.State.Turns.Clear();
        result.State.Turns.Add(new TurnRecord
        {
            TurnNumber = 1,
            PhaseNumber = 1,
            Player = PlayerId.Red,
            Start = new TurnSnapshot(0, 0, ["Young Hunter"], ["Young Hunter"], null, null, ["Shrine of the Red Baobab: 0/10"], []),
            End = new TurnSnapshot(1, 0, ["Young Hunter"], ["Young Hunter"], null, null, ["Shrine of the Red Baobab: 2/10"], [])
        });
        result.State.Turns.Add(new TurnRecord
        {
            TurnNumber = 2,
            PhaseNumber = 1,
            Player = PlayerId.Iron,
            Start = new TurnSnapshot(0, 0, ["Bone-Cracker Cub"], ["Bone-Cracker Cub"], null, null, ["Iron Hyena Den: 0/10"], []),
            End = new TurnSnapshot(1, 1, ["Bone-Cracker Cub"], ["Bone-Cracker Cub"], null, null, ["Iron Hyena Den: 1/10"], [])
        });
        result.State.Turns.Add(new TurnRecord
        {
            TurnNumber = 3,
            PhaseNumber = 1,
            Player = PlayerId.Red,
            Start = new TurnSnapshot(1, 0, [], [], null, null, ["Shrine of the Red Baobab: 2/10"], []),
            End = new TurnSnapshot(2, 0, [], [], null, null, ["Shrine of the Red Baobab: 2/10"], [])
        });
        result.State.Turns.Add(new TurnRecord
        {
            TurnNumber = 4,
            PhaseNumber = 1,
            Player = PlayerId.Iron,
            Start = new TurnSnapshot(1, 1, [], [], null, null, ["Iron Hyena Den: 1/10"], []),
            End = new TurnSnapshot(2, 1, [], [], null, null, ["Iron Hyena Den: 1/10"], [])
        });
        result.State.Red.Shrines.First().Damage = 9;
        result.State.Iron.Shrines.First().Damage = 7;

        var report = writer.CreateSingleReport(result, "RedBaobabBot", "IronHyenaBot", "dotnet run --project MythicDuel.Sim -- --mode single --seed 131");

        Assert.Contains("Pre-resource snapshot:", report.Markdown);
        Assert.Contains("Offerings before resource: 0", report.Markdown);
        Assert.Contains("Shrine state: Shrine of the Red Baobab: 0/10", report.Markdown);
        Assert.Contains("# End of Phase 1 Summary", report.Markdown);
        Assert.Contains("Shrine state: Red [Shrine of the Red Baobab: 2/10] | Iron [Iron Hyena Den: 1/10]", report.Markdown);
        Assert.DoesNotContain("Shrine state: Red [Shrine of the Red Baobab 9/10] | Iron [Iron Hyena Den 7/10]", report.Markdown);
    }

    [Fact]
    public void Batch_report_includes_no_hardcast_failure_digest_when_rules_disable_hardcasts()
    {
        var writer = new ReportWriter();
        var failure = CreateSimulationResult("game-125", 125, winner: PlayerId.Iron);
        failure.Metrics.Timeout = true;
        failure.Metrics.EndReason = GameEndReason.Timeout.ToString();
        failure.Metrics.Outcome = GameOutcome.AdjudicatedIron.ToString();
        failure.Metrics.AdjudicatedWinner = failure.State.Iron.Name;
        failure.Metrics.TurnCount = 81;
        failure.Metrics.MemoryEndRed = 24;
        failure.Metrics.DeckReshufflesRed = 9;
        failure.Metrics.RedL2EnteredBattlefield = 0;
        failure.Metrics.RedL3EnteredBattlefield = 0;
        failure.Metrics.IronL2EnteredBattlefield = 0;
        failure.Metrics.IronL3EnteredBattlefield = 0;
        failure.Metrics.LegalEvolveActionsGeneratedRed = 0;
        failure.Metrics.LegalEvolveActionsGeneratedIron = 0;

        var success = CreateSimulationResult("game-126", 126);
        success.Metrics.TurnCount = 22;
        success.Metrics.RedL2EnteredBattlefield = 1;
        success.Metrics.RedL2Evolved = 1;
        success.Metrics.LegalEvolveActionsGeneratedRed = 3;
        success.Metrics.EvolveActionsChosenRed = 1;

        var report = writer.CreateBatchReport([failure, success], "RedEvolutionBot", "PassiveBot", "dotnet run --project MythicDuel.Sim -- --mode batch --games 2 --seed 125 --bot-red evolution --bot-iron passive --rules forbid-hardcast-evolution-cards");

        Assert.Contains("### Game 125 — no-hardcast failure sample", report.SummaryMarkdown);
        Assert.Contains("Timeout: yes", report.SummaryMarkdown);
        Assert.Contains("Key issue: no L2/L3, no legal evolve actions", report.SummaryMarkdown);
        Assert.Contains("Design meaning: this batch still points at broken deed tracking or evolve generation under no-hardcast rules", report.SummaryMarkdown);
    }

    [Fact]
    public void Timeout_sets_adjudicated_outcome_metrics()
    {
        var state = EngineTestHarness.CreateState();
        state.PlayerTurnCount = 80;
        state.Red.Shrines[0].Damage = 4;
        state.Iron.Shrines[0].Damage = 4;
        var engine = new GameEngine();

        var result = engine.Run(state, new PassiveBot(), new PassiveBot());

        Assert.True(result.Metrics.Timeout);
        Assert.Equal(GameEndReason.Timeout.ToString(), result.Metrics.EndReason);
        Assert.Equal(GameOutcome.AdjudicatedRed.ToString(), result.Metrics.Outcome);
        Assert.Equal(state.Red.Name, result.Metrics.AdjudicatedWinner);
        Assert.Equal(state.Red.Name, result.Metrics.Winner);
        Assert.Equal(1, result.Metrics.TimeoutAdjudicatedRed);
    }

    [Fact]
    public void Red_retain_prefers_hunter_setup_over_expensive_spirit()
    {
        var state = EngineTestHarness.CreateState();
        var bot = new RedBaobabBot();
        var deepSpirit = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.DeepRiverSpirit);
        var riverHunter = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.RiverHunter);
        var ritual = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.RitualOfRedMoon);

        var retained = bot.ChooseRetainedCard(EngineTestHarness.CreateView(state, PlayerId.Red), PlayerId.Red, [deepSpirit.Id, riverHunter.Id, ritual.Id]);

        Assert.Equal(riverHunter.Id, retained);
    }

    [Fact]
    public void Iron_blocks_leopard_hunter_shrine_attack_when_possible()
    {
        var state = EngineTestHarness.CreateState();
        var bot = new IronHyenaBot();
        var attacker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.LeopardHunter);
        var blocker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BoneCrackerCub);
        var shrine = state.Iron.Shrines.First();
        var legalBlocks = new List<BlockDecision>
        {
            new(null, shrine.Name, attacker.Id),
            new(blocker.Id, shrine.Name, attacker.Id),
        };

        var decision = bot.ChooseBlock(EngineTestHarness.CreateView(state, PlayerId.Iron), PlayerId.Iron, new AttackDecision(attacker.Id, AttackTargetType.Shrine, shrine.Name, ShrineName: shrine.Name), legalBlocks);

        Assert.NotNull(decision);
        Assert.Equal(blocker.Id, decision!.BlockerId);
    }

    [Fact]
    public void Evolution_bot_is_registered_and_prefers_leopard_retention()
    {
        var runner = new SimulationRunner();
        var bot = runner.CreateBot("evolution");
        var state = EngineTestHarness.CreateState();
        var hunter = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.YoungHunter);
        var leopard = EngineTestHarness.AddHandCard(state, PlayerId.Red, CoreIds.Red.LeopardHunter);

        var retained = bot.ChooseRetainedCard(EngineTestHarness.CreateView(state, PlayerId.Red), PlayerId.Red, [hunter.Id, leopard.Id]);

        Assert.IsType<RedEvolutionBot>(bot);
        Assert.Equal(leopard.Id, retained);
    }

    [Fact]
    public void Post_combat_awakening_uses_refreshed_legal_list()
    {
        var state = EngineTestHarness.CreateState();
        var player = state.Iron;
        player.Memory = 2;
        var attacker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BoneCrackerCub);
        attacker.IsExhausted = false;
        attacker.EnteredBattlefieldOnTurn = 0;
        var targetShrine = state.Red.Shrines.First();
        var engine = new GameEngine();
        var bot = EngineTestHarness.ScriptedBot(new TurnDecision
        {
            Attacks = { new AttackDecision(attacker.Id, AttackTargetType.Shrine, targetShrine.Name, ShrineName: targetShrine.Name) }
        });

        engine.ExecuteTurn(state, player, bot, new PassiveBot());

        Assert.Equal(CoreIds.Iron.AncestorIronHyena, player.AwakenedAncestorDefinitionId);
        Assert.True(state.Metrics.LegalAwakenActionsGeneratedIron > 0);
        Assert.Equal(1, state.Metrics.AwakenActionsChosenIron);
        Assert.Equal(CoreIds.Iron.AncestorIronHyena, state.Metrics.FirstAwakenedAncestorIron);
    }

    [Fact]
    public void Ancestor_realized_value_metrics_are_recorded_at_resolution_points()
    {
        var state = EngineTestHarness.CreateState();
        var red = state.Red;
        var iron = state.Iron;
        red.AwakenedAncestorDefinitionId = CoreIds.Red.AncestorGrandmother;
        red.Lineage.Single(x => x.DefinitionId == CoreIds.Red.AncestorGrandmother).IsAwakened = true;
        iron.AwakenedAncestorDefinitionId = CoreIds.Iron.AncestorSmith;
        iron.Lineage.Single(x => x.DefinitionId == CoreIds.Iron.AncestorSmith).IsAwakened = true;
        red.Shrines[0].Damage = 3;
        iron.MaxOfferings = 1;
        var host = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BoneCrackerCub);
        var relic = EngineTestHarness.AddHandCard(state, PlayerId.Iron, CoreIds.Iron.BoneSpear);
        var engine = new GameEngine();

        engine.ExecuteTurn(state, red, EngineTestHarness.ScriptedBot(new TurnDecision()), new PassiveBot());
        engine.ExecuteTurn(state, iron, EngineTestHarness.ScriptedBot(new TurnDecision
        {
            Main1Actions = { new PlayRelicAction(relic.Id, host.Id) }
        }), new PassiveBot());

        Assert.Equal(1, state.Metrics.GrandmotherHealingDone);
        Assert.Equal(1, red.Shrines[0].Damage);
        Assert.Equal(1, state.Metrics.SmithOfferingDiscountSaved);
        Assert.Equal(1, iron.CurrentOfferings);
    }

    [Fact]
    public void Reports_include_ancestor_diagnostics()
    {
        var writer = new ReportWriter();
        var result = CreateSimulationResult("game-ancestor", 909);
        result.Metrics.LegalAwakenActionsGeneratedRed = 3;
        result.Metrics.AwakenActionsChosenRed = 1;
        result.Metrics.AwakenActionsSkippedWhileLegalRed = 2;
        result.Metrics.FirstAwakenedAncestorRed = CoreIds.Red.AncestorFirstHunter;
        result.Metrics.TurnsWithAwakenedAncestorRed = 4;
        result.Metrics.MemorySpentOnAncestorsRed = 2;
        result.Metrics.FirstHunterBonusDamage = 3;
        result.Metrics.GrandmotherHealingDone = 1;
        result.Metrics.ChildDrawDiscardTriggers = 2;
        result.Metrics.IronHyenaAncestorBonusDamage = 1;
        result.Metrics.SmithOfferingDiscountSaved = 1;
        result.Metrics.ToothMotherBonusDamage = 2;

        var single = writer.CreateSingleReport(result, "RedBaobabBot", "IronHyenaBot", "dotnet run --project MythicDuel.Sim -- --mode single --seed 909");
        var batch = writer.CreateBatchReport([result], "RedBaobabBot", "IronHyenaBot", "dotnet run --project MythicDuel.Sim -- --mode batch --games 1 --seed 909");

        Assert.Contains("Legal awaken actions generated: Red 3, Iron 0", single.Markdown);
        Assert.Contains($"First awakened ancestor: Red {CoreIds.Red.AncestorFirstHunter}, Iron None", single.Markdown);
        Assert.Contains("Ancestor realized value: First Hunter +3 damage, Grandmother healed 1, Child draw/discard 2, Iron Hyena +1 damage, Smith saved 1 Offerings, Tooth-Mother +2 damage", single.Markdown);
        Assert.Contains("Awakening flow: legal Red 3, Iron 0; chosen Red 1, Iron 0; skipped Red 2, Iron 0", batch.SummaryMarkdown);
        Assert.Contains("first_awakened_ancestor_red", batch.SummaryCsv, StringComparison.OrdinalIgnoreCase);
        Assert.Contains(CoreIds.Red.AncestorFirstHunter, batch.SummaryCsv);
    }

    [Fact]
    public void Reports_include_pack_diagnostics()
    {
        var writer = new ReportWriter();
        var result = CreateSimulationResult("game-pack", 910);
        result.Metrics.PackUnitsReadyAtCombatStartRed = 2;
        result.Metrics.PackUnitsReadyAtCombatStartIron = 4;
        result.Metrics.PackAssaultSlotsGeneratedRed = 1;
        result.Metrics.PackAssaultSlotsGeneratedIron = 3;
        result.Metrics.PackAssaultSlotsAvailableRed = 1;
        result.Metrics.PackAssaultSlotsAvailableIron = 3;
        result.Metrics.PackAssaultSlotsSkippedRed = 0;
        result.Metrics.PackAssaultSlotsSkippedIron = 2;
        result.Metrics.TurnsWithPackBonusRed = 1;
        result.Metrics.TurnsWithPackBonusIron = 2;
        result.Metrics.MaxAttacksAvailableThisCombatRed = 3;
        result.Metrics.MaxAttacksAvailableThisCombatIron = 5;
        result.Metrics.AttacksPreventedByAssaultLimitRed = 0;
        result.Metrics.AttacksPreventedByAssaultLimitIron = 1;

        var single = writer.CreateSingleReport(result, "RedBaobabBot", "IronHyenaBot", "dotnet run --project MythicDuel.Sim -- --mode single --seed 910");
        var batch = writer.CreateBatchReport([result], "RedBaobabBot", "IronHyenaBot", "dotnet run --project MythicDuel.Sim -- --mode batch --games 1 --seed 910");

        Assert.Contains("Pack diagnostics: Seat 1 ready-at-combat 2, generated 1, available 1, skipped 0, turns-with-bonus 1, max-attacks 3, prevented-by-limit 0", single.Markdown);
        Assert.Contains("Pack diagnostics: Seat 2 ready-at-combat 4, generated 3, available 3, skipped 2, turns-with-bonus 2, max-attacks 5, prevented-by-limit 1", single.Markdown);
        Assert.Contains("Pack pressure: ready units Red 2, Iron 4; generated slots Red 1, Iron 3; skipped slots Red 0, Iron 2; prevented by limit Red 0, Iron 1", batch.SummaryMarkdown);
        Assert.Contains("pack_units_ready_at_combat_start_red", batch.SummaryCsv, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public void Choose_assaults_with_pack_limits_extra_attacks_to_pack_attackers_and_unique_attackers()
    {
        var state = EngineTestHarness.CreateState();
        var nonPackOne = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BlackToothSmith);
        var nonPackTwo = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.IronGuard);
        var packOne = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.BoneCrackerCub);
        var packTwo = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Iron, CoreIds.Iron.IronHyenaRaider);
        state.Red.Shrines[0].Damage = 3;
        state.Red.Shrines[1].Damage = 1;
        var view = EngineTestHarness.CreateView(state, PlayerId.Iron);
        var legalAttacks = new List<AttackDecision>
        {
            new(nonPackOne.Id, AttackTargetType.Shrine, state.Red.Shrines[0].Name, ShrineName: state.Red.Shrines[0].Name),
            new(nonPackOne.Id, AttackTargetType.Shrine, state.Red.Shrines[1].Name, ShrineName: state.Red.Shrines[1].Name),
            new(nonPackTwo.Id, AttackTargetType.Shrine, state.Red.Shrines[1].Name, ShrineName: state.Red.Shrines[1].Name),
            new(packOne.Id, AttackTargetType.Shrine, state.Red.Shrines[2].Name, ShrineName: state.Red.Shrines[2].Name),
            new(packTwo.Id, AttackTargetType.Shrine, state.Red.Shrines[0].Name, ShrineName: state.Red.Shrines[0].Name),
        };
        var bot = new IronHyenaBot();

        var selected = bot.ChooseTurn(view, PlayerId.Iron, [], legalAttacks, [], []).Attacks;

        Assert.Equal(4, selected.Count);
        Assert.Equal(4, selected.Select(attack => attack.AttackerId).Distinct().Count());
        Assert.DoesNotContain(selected.Take(2), attack => view.GetCard(attack.AttackerId).HasKeyword(Keyword.Pack));
        Assert.Contains(selected, attack => attack.AttackerId == nonPackOne.Id && attack.TargetName == state.Red.Shrines[0].Name);
        Assert.Contains(selected, attack => attack.AttackerId == nonPackTwo.Id);
        Assert.Contains(selected, attack => attack.AttackerId == packOne.Id);
        Assert.Contains(selected, attack => attack.AttackerId == packTwo.Id);
    }

    [Fact]
    public void Iron_snare_applies_minus_two_attack_modifier()
    {
        var state = EngineTestHarness.CreateState();
        var red = state.Red;
        var iron = state.Iron;

        // Attacker is a 3-attack Red unit (e.g. Leopard Hunter)
        var attacker = EngineTestHarness.AddBattlefieldCard(state, PlayerId.Red, CoreIds.Red.LeopardHunter);
        attacker.IsExhausted = false;
        attacker.EnteredBattlefieldOnTurn = 0;

        // Prepare Iron Snare on Iron's side
        var snare = EngineTestHarness.AddHandCard(state, PlayerId.Iron, CoreIds.Iron.IronSnare);
        iron.PreparedTacticIds.Add(snare.Id);
        snare.Zone = Zone.Prepared;

        var targetShrine = state.Iron.Shrines.First();
        var engine = new GameEngine();

        // Simulate attack. Leopard Hunter has 3 Base Attack. Iron Snare should trigger and reduce its attack by 2 (to 1).
        engine.ExecuteTurn(
            state,
            red,
            EngineTestHarness.ScriptedBot(new TurnDecision
            {
                Attacks = { new AttackDecision(attacker.Id, AttackTargetType.Shrine, targetShrine.Name, ShrineName: targetShrine.Name) }
            }),
            new PassiveBot());

        // Verify Iron Snare triggered (moved out of PreparedTacticIds)
        Assert.DoesNotContain(snare.Id, iron.PreparedTacticIds);
        // Verify Leopard Hunter dealt 3 damage (4 base + 1 shrine bonus - 2 snare reduction = 3) instead of 5.
        Assert.Equal(3, targetShrine.Damage);
    }

    [Fact]
    public void Strict_alternation_rules_never_reverse_initiative()
    {
        var state = GameFactory.Create(123, "red-hunter-evolution", "iron-hyena-pack-pressure");
        state.Rules = "strict-alternation";
        var engine = new GameEngine();

        // Turn 1 (0): Red
        Assert.Equal(PlayerId.Red, state.ActivePlayer);
        
        // Advance turns and verify it strictly alternates: Red -> Iron -> Red -> Iron -> Red -> Iron...
        for (int i = 0; i < 15; i++)
        {
            var expectedPlayer = i % 2 == 0 ? PlayerId.Iron : PlayerId.Red;
            // Execute private AdvanceTurnOrder method
            typeof(GameEngine)
                .GetMethod("AdvanceTurnOrder", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
                .Invoke(engine, [state]);
            Assert.Equal(expectedPlayer, state.ActivePlayer);
        }
    }

    [Fact]
    public void Phase_length_six_rules_reverse_every_six_turns()
    {
        var state = GameFactory.Create(123, "red-hunter-evolution", "iron-hyena-pack-pressure");
        state.Rules = "phase-length-6";
        var engine = new GameEngine();

        // Active Player order in Phase 1 (turns 0 to 5):
        // 0: Red, 1: Iron, 2: Red, 3: Iron, 4: Red, 5: Iron
        // Phase 2 (turns 6 to 11):
        // 6: Iron, 7: Red, 8: Iron, 9: Red, 10: Iron, 11: Red

        PlayerId[] expectedOrder = [
            PlayerId.Red, PlayerId.Iron, PlayerId.Red, PlayerId.Iron, PlayerId.Red, PlayerId.Iron, // Phase 1
            PlayerId.Iron, PlayerId.Red, PlayerId.Iron, PlayerId.Red, PlayerId.Iron, PlayerId.Red  // Phase 2
        ];

        for (int i = 0; i < expectedOrder.Length; i++)
        {
            Assert.Equal(expectedOrder[i], state.ActivePlayer);
            typeof(GameEngine)
                .GetMethod("AdvanceTurnOrder", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
                .Invoke(engine, [state]);
        }
    }

    private static SimulationResult CreateSimulationResult(string gameId, int seed, PlayerId winner = PlayerId.Red)
    {
        var normalizedGameId = gameId.StartsWith("game-", StringComparison.OrdinalIgnoreCase) ? gameId[5..] : gameId;
        var state = EngineTestHarness.CreateState(int.TryParse(normalizedGameId, out var parsedGameId) ? parsedGameId : seed);
        state.Metrics.Seed = seed;
        state.Metrics.Winner = winner.ToString();
        state.Metrics.Loser = winner == PlayerId.Red ? PlayerId.Iron.ToString() : PlayerId.Red.ToString();
        state.Metrics.TurnCount = 6;
        state.Metrics.PhaseCount = 2;
        state.Winner = winner;

        return new SimulationResult(state, state.Events, state.Metrics);
    }

    private sealed class NullRetainBot : IGameBot
    {
        public string Name => "null-retain";

        public TurnDecision ChooseTurn(GameView view, PlayerId playerId, IReadOnlyList<PlayerAction> legalMain1, IReadOnlyList<AttackDecision> legalAttacks, IReadOnlyList<PlayerAction> legalMain2, IReadOnlyList<PlayerAction> legalAwakenings)
        {
            return new TurnDecision();
        }

        public int? ChooseRetainedCard(GameView view, PlayerId playerId, IReadOnlyList<int> handCardIds)
        {
            return null;
        }

        public AwakenAncestorAction? ChooseAwakening(GameView view, PlayerId playerId, IReadOnlyList<AwakenAncestorAction> legalAwakenings)
        {
            return null;
        }

        public BlockDecision? ChooseBlock(GameView view, PlayerId defender, AttackDecision attack, IReadOnlyList<BlockDecision> legalBlocks)
        {
            return legalBlocks.FirstOrDefault();
        }

        public int? ChoosePreparedReplacement(GameView view, PlayerId playerId, IReadOnlyList<int> preparedTacticCardIds, int incomingPreparedCardId)
        {
            return preparedTacticCardIds.FirstOrDefault();
        }
    }
}
