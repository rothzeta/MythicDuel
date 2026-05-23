namespace MythicDuel.Core.Models;

public sealed record GameEvent(
    int Turn,
    int Phase,
    PlayerId? Player,
    EventType Type,
    string Message,
    IReadOnlyDictionary<string, string>? Data = null);
