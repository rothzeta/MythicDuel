namespace MythicDuel.Core.Models;

public enum AncestorConditionKind
{
    None,
    DestroyedEnemyThisTurn,
    RestoredShrineThisTurnOrSkippedShrineAttacksLastTurn,
    SpiritDispersedSinceLastTurn,
    DamagedEnemyShrineThisTurn,
    SurvivedCombatThisTurn,
    PlayedRelicThisTurn,
    DeclaredPackAttackThisTurn,
    WoundedOrSurvivedCombatThisTurn,
}

public sealed record AncestorDefinition(
    string Id,
    string Name,
    PlayerId Owner,
    int AwakenMemoryCost,
    AncestorConditionKind AwakenCondition,
    IReadOnlyList<string> Tags,
    string RulesText);

public sealed class AncestorState
{
    public required string DefinitionId { get; init; }
    public required string Name { get; init; }
    public required PlayerId Owner { get; init; }
    public bool IsAwakened { get; set; }
}
