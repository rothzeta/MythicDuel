namespace MythicDuel.Engine.Game;

public enum SeatId
{
    Seat1 = 0,
    Seat2 = 1,
}

public enum CardType
{
    Shrine,
    Being,
    Spirit,
    Relic,
    Rite,
    Tactic,
    Ancestor,
    Token,
}

public enum Zone
{
    Deck,
    Hand,
    Battlefield,
    Prepared,
    Discard,
    Forgotten,
    Lineage,
    Attached,
    None,
}

public enum EventType
{
    TurnStarted,
    TurnEnded,
    CardDrawn,
    CardPlayed,
    AttackDeclared,
    DamageDealt,
    UnitDied,
    SpiritDispersed,
    ShrineDamaged,
    ShrineBroken,
    ShrineRestored,
    CardForgotten,
    TacticPrepared,
    PreparedTacticTriggered,
    PreparedTacticExpired,
    UnitEvolved,
    AncestorAwakened,
    MemoryGained,
    MemorySpent,
    OfferingSpent,
    CardRetained,
    CardDiscarded,
    DeckReshuffled,
}
