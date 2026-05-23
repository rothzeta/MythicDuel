namespace MythicDuel.Core.Models;

public sealed class DeedTracker
{
    public bool FirstBeingDeathMemoryGrantedThisTurn { get; set; }
    public bool FirstShrineAttackMemoryGrantedThisTurn { get; set; }
    public bool AncestorShrineBonusTriggeredThisTurn { get; set; }
    public bool UnitDamagedShrineThisTurn { get; set; }
    public bool UnitDestroyedEnemyThisTurn { get; set; }
    public bool UnitBrokeShrineThisTurn { get; set; }
    public bool PlayerAttackedShrineThisTurn { get; set; }
    public bool SpiritDispersedThisTurn { get; set; }
    public bool SpiritDispersedSinceLastTurn { get; set; }
    public bool ShrineRestoredThisTurn { get; set; }
    public bool PlayerSkippedShrineAttacksThisTurn { get; set; }
    public bool PlayerSkippedShrineAttacksLastTurn { get; set; }
    public bool UnitSurvivedCombatThisTurn { get; set; }
    public bool PlayedRelicThisTurn { get; set; }
    public bool GainedMemoryThisTurn { get; set; }
    public bool FirstMemoryGainTriggeredDrawThisTurn { get; set; }
    public int StandardAssaultSlotsAvailable { get; set; }
    public int PackAssaultSlotsAvailable { get; set; }
    public int StandardAssaultSlotsSpent { get; set; }
    public int PackAssaultSlotsSpent { get; set; }
    public HashSet<int> UnitsThatDestroyedEnemyThisTurn { get; } = new();
    public HashSet<int> UnitsThatDamagedShrineThisTurn { get; } = new();
    public HashSet<int> UnitsThatBrokeShrineThisTurn { get; } = new();
    public HashSet<int> HuntersThatAttackedThisTurn { get; } = new();
    public HashSet<int> OpponentUnitsThatBlockedThisTurn { get; } = new();
    public bool UnitBecameWoundedThisTurn { get; set; }
    public bool FirstPackAttackBlockedBonusTriggeredThisTurn { get; set; }
    public bool BoneSplitterMotherBonusTriggeredThisTurn { get; set; }

    public void ResetForNewTurn()
    {
        UnitDamagedShrineThisTurn = false;
        FirstBeingDeathMemoryGrantedThisTurn = false;
        FirstShrineAttackMemoryGrantedThisTurn = false;
        AncestorShrineBonusTriggeredThisTurn = false;
        UnitDestroyedEnemyThisTurn = false;
        UnitBrokeShrineThisTurn = false;
        PlayerAttackedShrineThisTurn = false;
        SpiritDispersedThisTurn = false;
        ShrineRestoredThisTurn = false;
        PlayerSkippedShrineAttacksThisTurn = true;
        UnitSurvivedCombatThisTurn = false;
        PlayedRelicThisTurn = false;
        GainedMemoryThisTurn = false;
        FirstMemoryGainTriggeredDrawThisTurn = false;
        UnitBecameWoundedThisTurn = false;
        FirstPackAttackBlockedBonusTriggeredThisTurn = false;
        BoneSplitterMotherBonusTriggeredThisTurn = false;
        StandardAssaultSlotsAvailable = 0;
        PackAssaultSlotsAvailable = 0;
        StandardAssaultSlotsSpent = 0;
        PackAssaultSlotsSpent = 0;
        UnitsThatDestroyedEnemyThisTurn.Clear();
        UnitsThatDamagedShrineThisTurn.Clear();
        UnitsThatBrokeShrineThisTurn.Clear();
        HuntersThatAttackedThisTurn.Clear();
        OpponentUnitsThatBlockedThisTurn.Clear();
    }

    public void CloseTurn()
    {
        PlayerSkippedShrineAttacksLastTurn = PlayerSkippedShrineAttacksThisTurn;
        SpiritDispersedSinceLastTurn = SpiritDispersedThisTurn;
    }
}
