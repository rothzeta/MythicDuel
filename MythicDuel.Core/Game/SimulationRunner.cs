using MythicDuel.Core.Bots;
using MythicDuel.Core.Models;

namespace MythicDuel.Core.Game;

public sealed class SimulationRunner
{
    private static readonly string[] AvailableBotNames = ["red", "iron", "random", "evolution", "passive"];
    private readonly GameEngine _engine = new();

    public SimulationResult RunSingle(SimulationOptions options)
    {
        var state = GameFactory.Create(options.Seed, options.DeckRed, options.DeckIron);
        state.Rules = options.Rules;
        return _engine.Run(state, CreateBot(options.BotRed), CreateBot(options.BotIron));
    }

    public IReadOnlyList<SimulationResult> RunBatch(SimulationOptions options)
    {
        var results = new List<SimulationResult>();
        for (var i = 0; i < options.Games; i++)
        {
            var seed = options.Seed + i;
            results.Add(RunSingle(new SimulationOptions
            {
                Seed = seed,
                Games = 1,
                BotRed = options.BotRed,
                BotIron = options.BotIron,
                DeckRed = options.DeckRed,
                DeckIron = options.DeckIron,
                Rules = options.Rules,
            }));
        }

        return results;
    }

    public IGameBot CreateBot(string name)
    {
        return name.ToLowerInvariant() switch
        {
            "evolution" => new RedEvolutionBot(),
            "passive" => new PassiveBot(),
            "random" => new RandomLegalBot(),
            "red" => new RedBaobabBot(),
            "iron" => new IronHyenaBot(),
            _ => new RandomLegalBot(),
        };
    }

    public IReadOnlyList<(string Name, string Implementation)> GetAvailableBots()
    {
        return AvailableBotNames
            .Select(name => (Name: name, Implementation: CreateBot(name).GetType().Name))
            .ToList();
    }
}
