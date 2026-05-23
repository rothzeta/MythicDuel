using MythicDuel.Core.Models;

namespace MythicDuel.Core.Game;

public sealed record SimulationResult(GameState State, IReadOnlyList<GameEvent> Events, GameMetrics Metrics);
