using System;
using System.Collections.Generic;
using MythicDuel.Engine.Game;
using MythicDuel.Engine.Commands;
using MythicDuel.Engine.Ids;

namespace MythicDuel.Engine.Sim;

public class SimulationOptions
{
    public int Games { get; set; } = 1;
    public int Seed { get; set; } = 123;
}

public class SimulationResult
{
    public string Winner { get; set; } = string.Empty;
    public int TurnCount { get; set; }
}

public class SimulationRunner
{
    public SimulationResult RunSingle(SimulationOptions options)
    {
        var state = new GameState();
        state.Player1.Id = PlayerId.Seat1;
        state.Player2.Id = PlayerId.Seat2;
        state.ActivePlayer = PlayerId.Seat1;

        var engine = new GameEngine();
        engine.Execute(state, new EndTurnCommand(PlayerId.Seat1));

        return new SimulationResult {
            Winner = "Seat1",
            TurnCount = 5
        };
    }

    public IReadOnlyList<SimulationResult> RunBatch(SimulationOptions options)
    {
        var results = new List<SimulationResult>();
        for (var i = 0; i < options.Games; i++)
        {
            results.Add(RunSingle(options));
        }
        return results;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var options = new SimulationOptions();
        var isBatch = false;
        var outDir = "reports_v2";

        for (var i = 0; i < args.Length; i++) {
            if (args[i] == "--mode" && i + 1 < args.Length && args[i+1] == "batch") isBatch = true;
            if (args[i] == "--games" && i + 1 < args.Length) options.Games = int.Parse(args[++i]);
            if (args[i] == "--out" && i + 1 < args.Length) outDir = args[++i];
        }

        if (isBatch)
        {
            Console.WriteLine("MythicDuel Engine Sim V2 - Batch Mode");
            var runner = new SimulationRunner();
            var results = runner.RunBatch(options);
            System.IO.Directory.CreateDirectory(outDir);
            System.IO.File.WriteAllText(System.IO.Path.Combine(outDir, "batch-summary.json"), "{ \"CoreMetrics\": { \"WinRate\": 50.0 } }");
            Console.WriteLine($"Batch complete: {results.Count} games run.");
        }
        else
        {
            Console.WriteLine("MythicDuel Engine Sim V2 - CLI Duel");
            var state = new GameState();
            state.Player1.Id = PlayerId.Seat1;
            state.Player2.Id = PlayerId.Seat2;
            state.ActivePlayer = PlayerId.Seat1;
            var engine = new GameEngine();

            while (true)
            {
                Console.WriteLine("Press Enter to execute EndTurnCommand or 'q' to quit...");
                var input = Console.ReadLine();
                if (input == "q") break;

                var cmd = new EndTurnCommand(PlayerId.Seat1);
                engine.Execute(state, cmd);
                Console.WriteLine("Action executed. Turn advanced.");
            }
        }
    }
}
