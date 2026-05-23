namespace MythicDuel.Core.Models;

public sealed class CardInstance
{
    public int Id { get; init; }
    public required string DefinitionId { get; init; }
    public required string Name { get; init; }
    public required PlayerId Owner { get; init; }
    public required PlayerId Controller { get; set; }
    public required CardType CardType { get; init; }
    public required Zone Zone { get; set; }
    public required IReadOnlyList<string> Tags { get; init; }
    public required Keyword BaseKeywords { get; init; }
    public int BaseAttack { get; init; }
    public int BaseVitality { get; init; }
    public int Damage { get; set; }
    public bool IsExhausted { get; set; }
    public bool IsWounded { get; set; }
    public int? WoundedClearsOnTurn { get; set; }
    public int? AttachedRelicId { get; set; }
    public int? AttachedPossessionId { get; set; }
    public int? HostId { get; set; }
    public int EnteredBattlefieldOnTurn { get; set; }
    public int PreparedOnTurn { get; set; }
    public int PreparedExpiresAfterTurn { get; set; }
    public bool RevealedPreparedTactic { get; set; }
    public bool HasTriggeredThisTurn { get; set; }
    public bool IsToken { get; set; }
    public bool HasDestroyedEnemy { get; set; }
    public bool HasDamagedShrine { get; set; }
    public bool HasBrokenShrine { get; set; }

    public bool IsUnit => CardType is CardType.Being or CardType.Spirit or CardType.Token;

    public bool HasTag(string tag)
    {
        return Tags.Contains(tag, StringComparer.OrdinalIgnoreCase);
    }

    public bool HasKeyword(Keyword keyword)
    {
        return (BaseKeywords & keyword) == keyword;
    }
}
