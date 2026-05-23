using MythicDuel.Core.Models;

namespace MythicDuel.Core.Cards;

public static class DeckCatalog
{
    public static IReadOnlyList<string> CreateDeck(string deckName)
    {
        return deckName.ToLowerInvariant() switch
        {
            "red" or "red-hunter-evolution" => CreateRedDeck(),
            "iron-hyena-pack-pressure" => CreateIronPackPressureDeck(),
            "iron-snarecraft-control" or "iron" or "iron-hyena-aggro" => CreateIronSnarecraftControlDeck(),
            _ => CreateRedDeck(),
        };
    }

    public static string GetFactionForDeck(string deckName)
    {
        return deckName.ToLowerInvariant() switch
        {
            "iron-hyena-pack-pressure" or "iron-snarecraft-control" or "iron" or "iron-hyena-aggro" => "Iron",
            _ => "Red",
        };
    }

    public static IReadOnlyList<string> CreateShrines(string faction)
    {
        return string.Equals(faction, "Iron", StringComparison.OrdinalIgnoreCase)
            ? [CoreIds.Iron.ShrineDen, CoreIds.Iron.ShrineBoneFang, CoreIds.Iron.ShrineRustedMoon]
            : [CoreIds.Red.ShrineRedBaobab, CoreIds.Red.ShrineRootStone, CoreIds.Red.ShrineMoonlitRoots];
    }

    public static IReadOnlyList<string> CreateAncestors(string deckNameOrFaction)
    {
        if (string.Equals(deckNameOrFaction, "iron-hyena-pack-pressure", StringComparison.OrdinalIgnoreCase))
        {
            return [CoreIds.Iron.AncestorFirstPack, CoreIds.Iron.AncestorBoneSplitterMother, CoreIds.Iron.AncestorSmithPassedFang];
        }
        if (string.Equals(deckNameOrFaction, "Iron", StringComparison.OrdinalIgnoreCase) || 
            string.Equals(deckNameOrFaction, "iron-snarecraft-control", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(deckNameOrFaction, "iron-hyena-aggro", StringComparison.OrdinalIgnoreCase))
        {
            return [CoreIds.Iron.AncestorIronHyena, CoreIds.Iron.AncestorToothMother, CoreIds.Iron.AncestorSmith];
        }
        return [CoreIds.Red.AncestorFirstHunter, CoreIds.Red.AncestorGrandmother, CoreIds.Red.AncestorChild];
    }

    public static IReadOnlyList<string> CreateRedDeck()
    {
        return Expand(
            (CoreIds.Red.YoungHunter, 3),
            (CoreIds.Red.RiverHunter, 3),
            (CoreIds.Red.BaobabGuardian, 2),
            (CoreIds.Red.PaleRiverSpirit, 2),
            (CoreIds.Red.DeepRiverSpirit, 2),
            (CoreIds.Red.EspritDuLeopard, 2),
            (CoreIds.Red.RitualOfRedMoon, 3),
            (CoreIds.Red.OfferingOfMilkAndAsh, 2),
            (CoreIds.Red.SpearOfFirstDawn, 2),
            (CoreIds.Red.HuntersCall, 2),
            (CoreIds.Red.RootWovenGuard, 2),
            (CoreIds.Red.LeopardHunter, 2),
            (CoreIds.Red.KumaWhoWoundedTheSun, 1));
    }

    public static IReadOnlyList<string> CreateIronPackPressureDeck()
    {
        return Expand(
            (CoreIds.Iron.BoneCrackerCub, 4),
            (CoreIds.Iron.PackHarrier, 4),
            (CoreIds.Iron.BloodScentHyena, 4),
            (CoreIds.Iron.IronHyenaRaider, 3),
            (CoreIds.Iron.HyenaPackCall, 3),
            (CoreIds.Iron.BlackToothSmith, 2),
            (CoreIds.Iron.IronHyenaChampion, 2),
            (CoreIds.Iron.BiteTheRoots, 2),
            (CoreIds.Iron.BoneSpear, 2),
            (CoreIds.Iron.FangRelic, 2),
            (CoreIds.Iron.PackAmbush, 2));
    }

    public static IReadOnlyList<string> CreateIronSnarecraftControlDeck()
    {
        // The original 30-card list prior to recent reactive tech cuts
        return Expand(
            (CoreIds.Iron.BoneCrackerCub, 4),
            (CoreIds.Iron.IronHyenaRaider, 3),
            (CoreIds.Iron.BlackToothSmith, 3),
            (CoreIds.Iron.IronHyenaChampion, 2),
            (CoreIds.Iron.HyenaPackCall, 2),
            (CoreIds.Iron.BiteTheRoots, 3),
            (CoreIds.Iron.BoneSpear, 2),
            (CoreIds.Iron.FangRelic, 2),
            (CoreIds.Iron.IronSnare, 2),
            (CoreIds.Iron.FalseOpening, 2),
            (CoreIds.Iron.IronGuard, 2),
            (CoreIds.Iron.RustHyenaSpirit, 2),
            (CoreIds.Iron.IronHyenaUnderworld, 1));
    }

    private static IReadOnlyList<string> Expand(params (string cardId, int copies)[] items)
    {
        var list = new List<string>();
        foreach (var (cardId, copies) in items)
        {
            for (var i = 0; i < copies; i++)
            {
                list.Add(cardId);
            }
        }

        return list;
    }
}
