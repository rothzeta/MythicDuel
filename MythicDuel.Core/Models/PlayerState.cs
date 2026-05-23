namespace MythicDuel.Core.Models;

public sealed class PlayerState
{
    public required PlayerId Id { get; init; }
    public required SeatId Seat { get; init; }
    public required string Name { get; init; }
    public string Faction { get; set; } = string.Empty;
    public string DeckName { get; set; } = string.Empty;
    public int TurnsTaken { get; set; }
    public int MaxOfferings { get; set; }
    public int CurrentOfferings { get; set; }
    public int Memory { get; set; }
    public int PresenceLimit { get; set; } = 5;
    public List<int> Deck { get; } = new();
    public List<int> Hand { get; } = new();
    public List<int> Battlefield { get; } = new();
    public List<int> Discard { get; } = new();
    public List<int> Forgotten { get; } = new();
    public List<AncestorState> Lineage { get; } = new();
    public List<ShrineState> Shrines { get; } = new();
    public List<int> PreparedTacticIds { get; } = new();
    public string? AwakenedAncestorDefinitionId { get; set; }
    public DeedTracker CurrentTurn { get; } = new();
}
