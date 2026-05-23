using MythicDuel.Core.Models;

namespace MythicDuel.Core.Cards;

public static class CardCatalog
{
    public static IReadOnlyDictionary<string, CardDefinition> CreateCardDefinitions()
    {
        var cards = new List<CardDefinition>
        {
            new(CoreIds.Red.YoungHunter, "Young Hunter", PlayerId.Red, "Red", CardType.Being, 1, 0, 2, 1, Keyword.None, ["Hunter"], PresenceCost: 1, CanAttackShrines: true, CanAttackUnits: true, MaxCopies: 3, RulesText: "2/1 Hunter.", Level: CardLevel.L1),
            new(CoreIds.Red.RiverHunter, "River Hunter", PlayerId.Red, "Red", CardType.Being, 2, 0, 3, 2, Keyword.None, ["Hunter"], PresenceCost: 1, CanAttackShrines: true, CanAttackUnits: true, MaxCopies: 3, RulesText: "Gain 1 Memory when it destroys an enemy.", Level: CardLevel.L1),
            new(CoreIds.Red.BaobabGuardian, "Baobab Guardian", PlayerId.Red, "Red", CardType.Being, 3, 0, 2, 4, Keyword.Guard, ["Guardian"], PresenceCost: 1, CanAttackShrines: true, CanAttackUnits: true, MaxCopies: 2, RulesText: "Guard. Restore 1 Vitality to a Shrine when this survives combat.", Level: CardLevel.L1),
            new(CoreIds.Red.PaleRiverSpirit, "Pale River Spirit", PlayerId.Red, "Red", CardType.Spirit, 2, 0, 2, 2, Keyword.Disperse, ["Spirit"], PresenceCost: 1, CanAttackUnits: true, MaxCopies: 2, RulesText: "Disperse. Gain 1 additional Memory when it disperses.", Level: CardLevel.L1),
            new(CoreIds.Red.DeepRiverSpirit, "Deep River Spirit", PlayerId.Red, "Red", CardType.Spirit, 4, 1, 3, 5, Keyword.Disperse | Keyword.Ascend, ["Spirit"], PresenceCost: 1, CanAttackUnits: true, MaxCopies: 2, RulesText: "Disperse. Restore 2 Vitality to a Shrine when it disperses. Ascend.", Level: CardLevel.L1),
            new(CoreIds.Red.EspritDuLeopard, "Esprit du Léopard", PlayerId.Red, "Red", CardType.Spirit, 2, 1, 0, 0, Keyword.Disperse | Keyword.Possession, ["Spirit", "Possession"], PresenceCost: 1, CanAttackUnits: false, MaxCopies: 2, RulesText: "Attach to a Being. Host gets +2 Attack and Ambush.", Level: CardLevel.L1),
            new(CoreIds.Red.RitualOfRedMoon, "Ritual of Red Moon", PlayerId.Red, "Red", CardType.Rite, 2, 0, 0, 0, Keyword.Fade, ["Rite"], MaxCopies: 3, RulesText: "Deal 2 damage to a Being. If it dies this turn, gain 1 Memory."),
            new(CoreIds.Red.OfferingOfMilkAndAsh, "Offering of Milk and Ash", PlayerId.Red, "Red", CardType.Rite, 1, 0, 0, 0, Keyword.Fade, ["Rite"], MaxCopies: 2, RulesText: "Restore 3 Vitality to a Shrine. If you attacked a Shrine this turn, this costs +1 Memory."),
            new(CoreIds.Red.SpearOfFirstDawn, "Spear of First Dawn", PlayerId.Red, "Red", CardType.Relic, 2, 0, 0, 0, Keyword.None, ["Relic"], MaxCopies: 2, RulesText: "Attach to a Being. +1 Attack; +2 more while Hunter attacks a Shrine."),
            new(CoreIds.Red.HuntersCall, "Hunter’s Call", PlayerId.Red, "Red", CardType.Tactic, 1, 0, 0, 0, Keyword.PreparedTactic | Keyword.Fade, ["Tactic"], PreparedTrigger: PreparedTrigger.FriendlyHunterAttacks, MaxCopies: 2, RulesText: "Prepared. Trigger on friendly Hunter attack."),
            new(CoreIds.Red.RootWovenGuard, "Root-Woven Guard", PlayerId.Red, "Red", CardType.Tactic, 1, 1, 0, 0, Keyword.PreparedTactic | Keyword.Fade, ["Tactic"], PreparedTrigger: PreparedTrigger.FriendlyShrineWouldTakeAttackDamage, MaxCopies: 2, RulesText: "Prepared. Reduce Shrine attack damage by 3."),
            new(CoreIds.Red.LeopardHunter, "Leopard Hunter", PlayerId.Red, "Red", CardType.Being, 5, 0, 4, 4, Keyword.Ambush | Keyword.WeaponMaster | Keyword.SoulSlayer, ["Hunter", "Leopard", "L2"], PresenceCost: 1, CanAttackShrines: true, CanAttackUnits: true, CanAttackOnEnter: true, IsEvolution: true, EvolveFromTag: "Hunter", EvolveCondition: EvolveConditionKind.DestroyedEnemyThisTurn, EvolveOfferingCost: 3, MaxCopies: 2, RulesText: "Ambush. WeaponMaster. SoulSlayer. Evolve from Hunter.", Level: CardLevel.L2),
            new(CoreIds.Red.KumaWhoWoundedTheSun, "Kuma Who Wounded the Sun", PlayerId.Red, "Red", CardType.Being, 8, 2, 6, 6, Keyword.Pierce | Keyword.Mythic | Keyword.Unique, ["Hunter", "Sun", "L3"], PresenceCost: 2, CanAttackShrines: true, CanAttackUnits: true, IsEvolution: true, EvolveFromTag: "L2", EvolveCondition: EvolveConditionKind.DamagedShrineThisTurn, EvolveOfferingCost: 4, EvolveMemoryCost: 2, MaxCopies: 1, RulesText: "Pierce. Evolve from Leopard Hunter.", Level: CardLevel.L3),
            new(CoreIds.Iron.BoneCrackerCub, "Bone-Cracker Cub", PlayerId.Iron, "Iron", CardType.Being, 1, 0, 2, 1, Keyword.Pack, ["Hyena"], PresenceCost: 1, CanAttackShrines: true, CanAttackUnits: true, MaxCopies: 4, RulesText: "+1 Attack while attacking damaged Shrines. Pack.", Level: CardLevel.L1),
            new(CoreIds.Iron.IronHyenaRaider, "Iron Hyena Raider", PlayerId.Iron, "Iron", CardType.Being, 2, 0, 3, 2, Keyword.Pack, ["Hyena"], PresenceCost: 1, CanAttackShrines: true, CanAttackUnits: true, MaxCopies: 3, RulesText: "Pack. When this attacks a Shrine, deal 1 damage to another Shrine controlled by same player.", Level: CardLevel.L1),
            new(CoreIds.Iron.BlackToothSmith, "Black-Tooth Smith", PlayerId.Iron, "Iron", CardType.Being, 3, 0, 2, 3, Keyword.None, ["Smith"], PresenceCost: 1, CanAttackShrines: true, CanAttackUnits: true, MaxCopies: 3, RulesText: "May attach a Relic from hand to a Being at 1 less Offering when entering.", Level: CardLevel.L1),
            new(CoreIds.Iron.IronGuard, "Iron Guard", PlayerId.Iron, "Iron", CardType.Being, 2, 0, 2, 3, Keyword.Guard, ["Guard"], PresenceCost: 1, CanAttackShrines: true, CanAttackUnits: true, MaxCopies: 2, RulesText: "Guard.", Level: CardLevel.L1),
            new(CoreIds.Iron.RustHyenaSpirit, "Rust Hyena Spirit", PlayerId.Iron, "Iron", CardType.Spirit, 2, 0, 2, 2, Keyword.Disperse, ["Spirit"], PresenceCost: 1, CanAttackUnits: true, MaxCopies: 2, RulesText: "Disperse. Deal 1 damage to a Shrine when it disperses.", Level: CardLevel.L1),
            new(CoreIds.Iron.BiteTheRoots, "Bite the Roots", PlayerId.Iron, "Iron", CardType.Rite, 2, 0, 0, 0, Keyword.Fade, ["Rite"], MaxCopies: 3, RulesText: "Deal 3 damage to a Shrine. If it breaks this turn, gain 1 Memory."),
            new(CoreIds.Iron.IronSnare, "Iron Snare", PlayerId.Iron, "Iron", CardType.Tactic, 1, 0, 0, 0, Keyword.PreparedTactic | Keyword.Fade, ["Tactic"], PreparedTrigger: PreparedTrigger.EnemyUnitAttackThreeOrMore, MaxCopies: 2, RulesText: "Prepared. Next enemy unit with 3+ Attack attacks gets -2 Attack and may disperse possession."),
            new(CoreIds.Iron.FalseOpening, "False Opening", PlayerId.Iron, "Iron", CardType.Tactic, 1, 1, 0, 0, Keyword.PreparedTactic | Keyword.Fade, ["Tactic"], PreparedTrigger: PreparedTrigger.EnemyBeingEvolves, MaxCopies: 2, RulesText: "Prepared. Trigger on enemy Being evolution."),
            new(CoreIds.Iron.FangRelic, "Fang Relic", PlayerId.Iron, "Iron", CardType.Relic, 2, 0, 0, 0, Keyword.None, ["Relic"], MaxCopies: 2, RulesText: "Attach to a Being. Host gets +1 Attack. When host attacks a damaged Shrine, deal 1 damage to another enemy Shrine."),
            new(CoreIds.Iron.BoneSpear, "Bone Spear", PlayerId.Iron, "Iron", CardType.Relic, 1, 0, 0, 0, Keyword.None, ["Relic"], MaxCopies: 2, RulesText: "Attach to a Being. +1 Attack and Pierce on damaged Shrine attack."),
            new(CoreIds.Iron.HyenaPackCall, "Hyena Pack Call", PlayerId.Iron, "Iron", CardType.Rite, 2, 0, 0, 0, Keyword.None, ["Rite"], MaxCopies: 2, RulesText: "Summon two 1/1 Hyena Beings."),
            new(CoreIds.Iron.IronHyenaChampion, "Iron Hyena Champion", PlayerId.Iron, "Iron", CardType.Being, 5, 0, 5, 3, Keyword.Pack, ["Hyena", "Iron", "L2"], PresenceCost: 1, CanAttackShrines: true, CanAttackUnits: true, IsEvolution: true, EvolveFromTag: "Hyena", EvolveCondition: EvolveConditionKind.DamagedShrineThisTurn, EvolveOfferingCost: 3, MaxCopies: 2, RulesText: "Pack. Evolve from Hyena. Deal 2 damage to same Shrine when evolved.", Level: CardLevel.L2),
            new(CoreIds.Iron.IronHyenaUnderworld, "Iron Hyena Underworld", PlayerId.Iron, "Iron", CardType.Being, 8, 2, 7, 5, Keyword.Pierce | Keyword.Mythic | Keyword.Unique, ["Hyena", "Iron", "L3"], PresenceCost: 2, CanAttackShrines: true, CanAttackUnits: true, IsEvolution: true, EvolveFromTag: "L2", EvolveCondition: EvolveConditionKind.DamagedShrineThisTurn, EvolveOfferingCost: 5, EvolveMemoryCost: 2, MaxCopies: 1, RulesText: "Pierce. Evolve from Iron Hyena Champion. Deal 2 to all enemy Shrines when evolved.", Level: CardLevel.L3),
            new(CoreIds.Iron.HyenaToken, "Hyena Token", PlayerId.Iron, "Iron", CardType.Token, 0, 0, 1, 1, Keyword.Pack, ["Hyena", "Token"], PresenceCost: 1, CanAttackShrines: true, CanAttackUnits: true, MaxCopies: 0, RulesText: "1/1 token from Hyena Pack Call. Pack.", Level: CardLevel.L1),
            new(CoreIds.Iron.PackHarrier, "Pack Harrier", PlayerId.Iron, "Iron", CardType.Being, 1, 0, 1, 1, Keyword.Pack, ["Hyena"], PresenceCost: 1, CanAttackShrines: true, CanAttackUnits: true, MaxCopies: 2, RulesText: "Pack. When this attacks a Shrine and is blocked, deal 1 damage to the attacked Shrine.", Level: CardLevel.L1),
            new(CoreIds.Iron.BloodScentHyena, "Blood-Scent Hyena", PlayerId.Iron, "Iron", CardType.Being, 2, 0, 2, 2, Keyword.Pack, ["Hyena"], PresenceCost: 1, CanAttackShrines: true, CanAttackUnits: true, MaxCopies: 2, RulesText: "Pack. When this attacks a damaged Shrine, deal 1 damage to another enemy Shrine.", Level: CardLevel.L1),
            new(CoreIds.Iron.PackAmbush, "Pack Ambush", PlayerId.Iron, "Iron", CardType.Rite, 1, 0, 0, 0, Keyword.Fade, ["Rite"], MaxCopies: 2, RulesText: "Summon a 1/1 Hyena Token. If you control another Pack Being, deal 1 damage to target Shrine."),
        };

        return cards.ToDictionary(card => card.Id, StringComparer.OrdinalIgnoreCase);
    }

    public static IReadOnlyDictionary<string, ShrineDefinition> CreateShrines()
    {
        return new[]
        {
            new ShrineDefinition(CoreIds.Red.ShrineRedBaobab, "Shrine of the Red Baobab", PlayerId.Red, 10, "First time each turn one of your Beings dies, gain 1 Memory."),
            new ShrineDefinition(CoreIds.Red.ShrineRootStone, "Hunter’s Root-Stone", PlayerId.Red, 10, "Hunters get +1 Attack while attacking Shrines."),
            new ShrineDefinition(CoreIds.Red.ShrineMoonlitRoots, "Moonlit Roots", PlayerId.Red, 10, "End of turn, if you did not attack a Shrine this turn, restore 1 Vitality to a Shrine."),
            new ShrineDefinition(CoreIds.Iron.ShrineDen, "Iron Hyena Den", PlayerId.Iron, 10, "First time each turn one of your Beings attacks a Shrine, gain 1 Memory."),
            new ShrineDefinition(CoreIds.Iron.ShrineBoneFang, "Bone-Fang Shrine", PlayerId.Iron, 10, "Your Beings get +1 Attack while attacking damaged Shrines."),
            new ShrineDefinition(CoreIds.Iron.ShrineRustedMoon, "Rusted Moon Shrine", PlayerId.Iron, 10, "Whenever an enemy Spirit disperses, deal 1 damage to an enemy Shrine."),
        }.ToDictionary(shrine => shrine.Id, StringComparer.OrdinalIgnoreCase);
    }

    public static IReadOnlyDictionary<string, AncestorDefinition> CreateAncestors()
    {
        return new[]
        {
            new AncestorDefinition(CoreIds.Red.AncestorFirstHunter, "First Hunter", PlayerId.Red, 2, AncestorConditionKind.DestroyedEnemyThisTurn, ["Hunt"], "Your Beings get +1 Attack while attacking Shrines."),
            new AncestorDefinition(CoreIds.Red.AncestorGrandmother, "Grandmother Beneath the Roots", PlayerId.Red, 2, AncestorConditionKind.RestoredShrineThisTurnOrSkippedShrineAttacksLastTurn, ["Root", "Moon"], "End of turn restore 1 Vitality to your most damaged Shrine."),
            new AncestorDefinition(CoreIds.Red.AncestorChild, "Child Who Remembered the Dead", PlayerId.Red, 2, AncestorConditionKind.SpiritDispersedSinceLastTurn, ["Memory", "Spirit"], "First time each turn you gain Memory, draw 1 then discard 1."),
            new AncestorDefinition(CoreIds.Iron.AncestorIronHyena, "Ancestor of the Iron Hyena", PlayerId.Iron, 2, AncestorConditionKind.DamagedEnemyShrineThisTurn, ["Iron", "Hyena"], "First time each turn one of your Beings attacks a Shrine, deal 1 damage to another enemy Shrine."),
            new AncestorDefinition(CoreIds.Iron.AncestorToothMother, "Tooth-Mother of the Dry Earth", PlayerId.Iron, 2, AncestorConditionKind.SurvivedCombatThisTurn, ["Hyena", "Earth"], "Your Wounded Beings get +1 Attack."),
            new AncestorDefinition(CoreIds.Iron.AncestorSmith, "Smith of Black Teeth", PlayerId.Iron, 2, AncestorConditionKind.PlayedRelicThisTurn, ["Iron"], "Your Relics cost 1 less Offering."),
            new AncestorDefinition(CoreIds.Iron.AncestorFirstPack, "Ancestor of the First Pack", PlayerId.Iron, 2, AncestorConditionKind.DeclaredPackAttackThisTurn, ["Iron", "Hyena", "Pack"], "The first time each combat a Pack attack is blocked, deal 1 damage to the attacked Shrine."),
            new AncestorDefinition(CoreIds.Iron.AncestorBoneSplitterMother, "Bone-Splitter Mother", PlayerId.Iron, 2, AncestorConditionKind.WoundedOrSurvivedCombatThisTurn, ["Hyena", "Earth", "Pack"], "Your Wounded Pack Beings get +1 Attack while attacking Shrines. The first time each turn a Wounded Pack Being attacks a Shrine, deal 1 damage to that Shrine."),
            new AncestorDefinition(CoreIds.Iron.AncestorSmithPassedFang, "Smith Who Passed the Fang", PlayerId.Iron, 2, AncestorConditionKind.PlayedRelicThisTurn, ["Iron", "Relic"], "Your first Relic each turn costs 1 less. When a Pack Being with a Relic dies, you may move that Relic to another ready Pack Being."),
        }.ToDictionary(ancestor => ancestor.Id, StringComparer.OrdinalIgnoreCase);
    }
}
