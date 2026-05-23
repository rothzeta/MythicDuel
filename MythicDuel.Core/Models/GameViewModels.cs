namespace MythicDuel.Core.Models;

public sealed record CardPublicView(
    int Id,
    string DefinitionId,
    string Name,
    PlayerId Owner,
    PlayerId Controller,
    CardType CardType,
    Zone Zone,
    IReadOnlyList<string> Tags,
    Keyword Keywords,
    CardLevel Level,
    int PresenceCost,
    int BaseAttack,
    int BaseVitality,
    int Damage,
    bool IsExhausted,
    bool IsWounded,
    int? HostId,
    int? AttachedRelicId,
    int? AttachedPossessionId)
{
    public bool HasTag(string tag)
    {
        return Tags.Contains(tag, StringComparer.OrdinalIgnoreCase);
    }

    public bool HasKeyword(Keyword keyword)
    {
        return (Keywords & keyword) == keyword;
    }

    public bool IsUnit => CardType is CardType.Being or CardType.Spirit or CardType.Token;

    public bool IsMythic => HasKeyword(Keyword.Mythic);
}

public sealed record ShrinePublicView(
    string DefinitionId,
    string Name,
    PlayerId Owner,
    int Vitality,
    int Damage)
{
    public bool IsBroken => Damage >= Vitality;
}

public sealed record PlayerPublicView(
    PlayerId Id,
    SeatId Seat,
    string Name,
    string Faction,
    string DeckName,
    int CurrentOfferings,
    int Memory,
    int MaxOfferings,
    int PresenceLimit,
    int PresenceUsed,
    IReadOnlyList<int> Hand,
    IReadOnlyList<int> Battlefield,
    IReadOnlyList<string> Forgotten,
    IReadOnlyList<ShrinePublicView> Shrines,
    string? AwakenedAncestorDefinitionId,
    IReadOnlyList<int> PreparedTacticCardIds,
    bool HasPreparedTactic);

public sealed record GameView(
    PlayerId Perspective,
    int Seed,
    int TurnNumber,
    int PhaseNumber,
    int StandardAssaultSlotsPerCombat,
    int MaxPackAttacksPerCombat,
    IReadOnlyDictionary<int, CardPublicView> Cards,
    PlayerPublicView Self,
    PlayerPublicView Opponent,
    IReadOnlyList<GameEvent> PublicEvents)
{
    public CardPublicView GetCard(int cardId)
    {
        return Cards[cardId];
    }
}
