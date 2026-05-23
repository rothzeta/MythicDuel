namespace MythicDuel.Core.Models;

public enum PlayerId
{
    Red = 0,
    Iron = 1,
}

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

public enum TargetKind
{
    None,
    EnemyUnit,
    FriendlyUnit,
    EnemyShrine,
    FriendlyShrine,
    HostBeing,
}

public enum PreparedTrigger
{
    None,
    FriendlyHunterAttacks,
    FriendlyShrineWouldTakeAttackDamage,
    EnemyUnitAttackThreeOrMore,
    EnemyBeingEvolves,
}

public enum EvolveConditionKind
{
    None,
    DestroyedEnemyThisTurn,
    DamagedShrineThisTurn,
    BrokeShrineThisTurn,
}

public enum CardLevel
{
    None = 0,
    L1 = 1,
    L2 = 2,
    L3 = 3,
}

public enum GameEndReason
{
    None,
    ShrineBreak,
    Timeout,
}

public enum GameOutcome
{
    None,
    RedWin,
    IronWin,
    Draw,
    AdjudicatedRed,
    AdjudicatedIron,
}

[System.Flags]
public enum Keyword
{
    None = 0,
    Disperse = 1 << 0,
    Possession = 1 << 1,
    PreparedTactic = 1 << 2,
    Pierce = 1 << 3,
    Guard = 1 << 4,
    Ambush = 1 << 5,
    Recall = 1 << 6,
    Fade = 1 << 7,
    WeaponMaster = 1 << 8,
    SoulSlayer = 1 << 9,
    Mythic = 1 << 10,
    Ascend = 1 << 11,
    Unique = 1 << 12,
    Pack = 1 << 13,
}
