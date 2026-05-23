namespace MythicDuel.Core.Models;

public sealed class GameState
{
    public required int Seed { get; init; }
    public required string GameId { get; init; }
    public required DeterministicRandom Random { get; init; }
    public required Dictionary<string, CardDefinition> CardDefinitions { get; init; }
    public required Dictionary<int, CardInstance> Cards { get; init; }
    public required Dictionary<string, AncestorDefinition> AncestorDefinitions { get; init; }
    public required Dictionary<string, ShrineDefinition> ShrineDefinitions { get; init; }
    public required PlayerState Red { get; init; }
    public required PlayerState Iron { get; init; }
    public int StandardAssaultSlotsPerCombat { get; set; } = 2;
    public int MaxPackAttacksPerCombat { get; set; } = 5;
    public PlayerId ActivePlayer { get; set; } = PlayerId.Red;
    public int TurnNumber { get; set; } = 1;
    public int PlayerTurnCount { get; set; }
    public int PhaseNumber { get; set; } = 1;
    public int ConsecutiveTurnCounter { get; set; }
    public string Rules { get; set; } = string.Empty;
    public int NextCardInstanceId { get; set; } = 1;
    public bool IsGameOver { get; set; }
    public PlayerId? Winner { get; set; }
    public GameEndReason EndReason { get; set; }
    public GameOutcome Outcome { get; set; }
    public List<GameEvent> Events { get; } = new();
    public List<TurnRecord> Turns { get; } = new();
    public GameMetrics Metrics { get; init; } = new() { GameId = string.Empty };

    public PlayerState GetPlayer(PlayerId playerId)
    {
        return playerId == PlayerId.Red ? Red : Iron;
    }

    public PlayerState GetOpponent(PlayerId playerId)
    {
        return playerId == PlayerId.Red ? Iron : Red;
    }
}

public sealed class TurnRecord
{
    public required int TurnNumber { get; init; }
    public required int PhaseNumber { get; init; }
    public required PlayerId Player { get; init; }
    public List<string> Main1Actions { get; } = new();
    public List<AttackRecord> Attacks { get; } = new();
    public List<string> Main2Actions { get; } = new();
    public required TurnSnapshot Start { get; init; }
    public TurnSnapshot? End { get; set; }
    public string? RetainedCard { get; set; }
    public List<string> DiscardedCards { get; } = new();
    public List<string> ForgottenCards { get; } = new();
    public List<string> WoundedClears { get; } = new();
}

public sealed class AttackRecord
{
    public string Attacker { get; set; } = string.Empty;
    public string Target { get; set; } = string.Empty;
    public string Defender { get; set; } = string.Empty;
    public List<string> PreparedTriggers { get; } = new();
    public List<string> Calculations { get; } = new();
    public List<string> DamageEvents { get; } = new();
    public string Result { get; set; } = string.Empty;
}

public sealed record TurnSnapshot(
    int Offerings,
    int Memory,
    IReadOnlyList<string> Hand,
    IReadOnlyList<string> Battlefield,
    string? PreparedTactic,
    string? AwakenedAncestor,
    IReadOnlyList<string> ShrineDamage,
    IReadOnlyList<string> Forgotten);
