namespace MythicDuel.Core.Models;

public sealed record ShrineDefinition(
    string Id,
    string Name,
    PlayerId Owner,
    int Vitality,
    string RulesText);

public sealed class ShrineState
{
    public required string DefinitionId { get; init; }
    public required string Name { get; init; }
    public required PlayerId Owner { get; init; }
    public int Vitality { get; init; } = 10;
    public int Damage { get; set; }
    public bool IsBroken => Damage >= Vitality;
}
