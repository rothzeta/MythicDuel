using System.Text.Json;
using MythicDuel.Core.Cards;
using MythicDuel.Core.Game;
using MythicDuel.Core.Models;

namespace MythicDuel.Sim.Reporting;

public sealed class CatalogWriter
{
    private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };

    public string CreateCatalogJson(SimulationRunner runner, string command)
    {
        var cards = CardCatalog.CreateCardDefinitions().Values
            .OrderBy(card => card.DeckOwner)
            .ThenBy(card => card.Name, StringComparer.Ordinal)
            .Select(card => new
            {
                card.Id,
                card.Name,
                DeckOwner = card.DeckOwner.ToString(),
                card.Faction,
                CardType = card.CardType.ToString(),
                card.OfferingCost,
                card.MemoryCost,
                card.Attack,
                card.Vitality,
                card.PresenceCost,
                Keywords = ExpandKeywords(card.Keywords),
                card.Tags,
                card.CanAttackShrines,
                card.CanAttackUnits,
                card.CanAttackOnEnter,
                card.IsEvolution,
                card.EvolveFromTag,
                EvolveCondition = card.EvolveCondition.ToString(),
                card.EvolveOfferingCost,
                card.EvolveMemoryCost,
                card.RecallMemoryCost,
                PreparedTrigger = card.PreparedTrigger.ToString(),
                card.MaxCopies,
                card.RulesText,
            })
            .ToList();

        var shrines = CardCatalog.CreateShrines().Values
            .OrderBy(shrine => shrine.Owner)
            .ThenBy(shrine => shrine.Name, StringComparer.Ordinal)
            .Select(shrine => new
            {
                shrine.Id,
                shrine.Name,
                Owner = shrine.Owner.ToString(),
                shrine.Vitality,
                shrine.RulesText,
            })
            .ToList();

        var ancestors = CardCatalog.CreateAncestors().Values
            .OrderBy(ancestor => ancestor.Owner)
            .ThenBy(ancestor => ancestor.Name, StringComparer.Ordinal)
            .Select(ancestor => new
            {
                ancestor.Id,
                ancestor.Name,
                Owner = ancestor.Owner.ToString(),
                ancestor.AwakenMemoryCost,
                AwakenCondition = ancestor.AwakenCondition.ToString(),
                ancestor.Tags,
                ancestor.RulesText,
            })
            .ToList();

        var decks = new[]
        {
            CreateDeck("red", PlayerId.Red, "Red", DeckCatalog.CreateDeck("red")),
            CreateDeck("red-hunter-evolution", PlayerId.Red, "Red", DeckCatalog.CreateDeck("red-hunter-evolution")),
            CreateDeck("iron", PlayerId.Iron, "Iron", DeckCatalog.CreateDeck("iron")),
            CreateDeck("iron-hyena-aggro", PlayerId.Iron, "Iron", DeckCatalog.CreateDeck("iron-hyena-aggro")),
        };

        var shrinesByDeck = new[]
        {
            new { Deck = "red", Faction = "Red", Shrines = DeckCatalog.CreateShrines("Red") },
            new { Deck = "red-hunter-evolution", Faction = "Red", Shrines = DeckCatalog.CreateShrines("Red") },
            new { Deck = "iron", Faction = "Iron", Shrines = DeckCatalog.CreateShrines("Iron") },
            new { Deck = "iron-hyena-aggro", Faction = "Iron", Shrines = DeckCatalog.CreateShrines("Iron") },
        };

        var ancestorsByDeck = new[]
        {
            new { Deck = "red", Faction = "Red", Ancestors = DeckCatalog.CreateAncestors("Red") },
            new { Deck = "red-hunter-evolution", Faction = "Red", Ancestors = DeckCatalog.CreateAncestors("Red") },
            new { Deck = "iron", Faction = "Iron", Ancestors = DeckCatalog.CreateAncestors("Iron") },
            new { Deck = "iron-hyena-aggro", Faction = "Iron", Ancestors = DeckCatalog.CreateAncestors("Iron") },
        };

        var export = new
        {
            Command = command,
            GeneratedAtUtc = DateTimeOffset.UtcNow,
            Keywords = ExpandEnum<Keyword>(excludeNone: true),
            PreparedTriggers = ExpandEnum<PreparedTrigger>(),
            EvolveConditions = ExpandEnum<EvolveConditionKind>(),
            AncestorConditions = ExpandEnum<AncestorConditionKind>(),
            CardTypes = ExpandEnum<CardType>(),
            Players = ExpandEnum<PlayerId>(),
            Bots = runner.GetAvailableBots().Select(bot => new { bot.Name, bot.Implementation }).ToList(),
            Cards = cards,
            Shrines = shrines,
            Ancestors = ancestors,
            Decks = decks,
            ShrinePackages = shrinesByDeck,
            AncestorPackages = ancestorsByDeck,
        };

        return JsonSerializer.Serialize(export, JsonOptions);
    }

    private static object CreateDeck(string name, PlayerId owner, string faction, IReadOnlyList<string> cardIds)
    {
        var grouped = cardIds
            .GroupBy(id => id, StringComparer.OrdinalIgnoreCase)
            .OrderBy(group => group.Key, StringComparer.OrdinalIgnoreCase)
            .Select(group => new
            {
                CardId = group.Key,
                Copies = group.Count(),
            })
            .ToList();

        return new
        {
            Name = name,
            Owner = owner.ToString(),
            Faction = faction,
            CardCount = cardIds.Count,
            Cards = grouped,
        };
    }

    private static IReadOnlyList<string> ExpandKeywords(Keyword keywords)
    {
        return Enum.GetValues<Keyword>()
            .Where(value => value != Keyword.None && keywords.HasFlag(value))
            .Select(value => value.ToString())
            .ToList();
    }

    private static IReadOnlyList<string> ExpandEnum<TEnum>(bool excludeNone = false) where TEnum : struct, Enum
    {
        return Enum.GetValues<TEnum>()
            .Select(value => value.ToString())
            .Where(name => !excludeNone || !string.Equals(name, "None", StringComparison.Ordinal))
            .ToList();
    }
}
