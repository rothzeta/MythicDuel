using MythicDuel.Core.Cards;
using MythicDuel.Core.Models;

namespace MythicDuel.Core.Game;

public static class GameFactory
{
    public static GameState Create(int seed)
    {
        return Create(seed, "red", "iron");
    }

    public static GameState Create(int seed, string seat1DeckName, string seat2DeckName)
    {
        var cardDefinitions = CardCatalog.CreateCardDefinitions();
        var shrineDefinitions = CardCatalog.CreateShrines();
        var ancestorDefinitions = CardCatalog.CreateAncestors();
        var random = new DeterministicRandom(seed);
        var seat1Faction = DeckCatalog.GetFactionForDeck(seat1DeckName);
        var seat2Faction = DeckCatalog.GetFactionForDeck(seat2DeckName);
        var state = new GameState
        {
            Seed = seed,
            GameId = seed.ToString(),
            Random = random,
            CardDefinitions = new Dictionary<string, CardDefinition>(cardDefinitions, StringComparer.OrdinalIgnoreCase),
            Cards = new Dictionary<int, CardInstance>(),
            AncestorDefinitions = new Dictionary<string, AncestorDefinition>(ancestorDefinitions, StringComparer.OrdinalIgnoreCase),
            ShrineDefinitions = new Dictionary<string, ShrineDefinition>(shrineDefinitions, StringComparer.OrdinalIgnoreCase),
            Red = new PlayerState { Id = PlayerId.Red, Seat = SeatId.Seat1, Name = seat1DeckName, DeckName = seat1DeckName, Faction = seat1Faction },
            Iron = new PlayerState { Id = PlayerId.Iron, Seat = SeatId.Seat2, Name = seat2DeckName, DeckName = seat2DeckName, Faction = seat2Faction },
            Metrics = new GameMetrics { GameId = $"game-{seed}", Seed = seed },
        };

        InitializePlayer(state, PlayerId.Red, seat1Faction, seat1DeckName, DeckCatalog.CreateDeck(seat1DeckName));
        InitializePlayer(state, PlayerId.Iron, seat2Faction, seat2DeckName, DeckCatalog.CreateDeck(seat2DeckName));
        return state;
    }

    private static void InitializePlayer(GameState state, PlayerId playerId, string faction, string deckName, IReadOnlyList<string> deckDefinitionIds)
    {
        var player = state.GetPlayer(playerId);
        foreach (var shrineId in DeckCatalog.CreateShrines(faction))
        {
            var shrineDefinition = state.ShrineDefinitions[shrineId];
            player.Shrines.Add(new ShrineState
            {
                DefinitionId = shrineDefinition.Id,
                Name = shrineDefinition.Name,
                Owner = playerId,
                Vitality = shrineDefinition.Vitality,
            });
        }

        foreach (var ancestorId in DeckCatalog.CreateAncestors(deckName))
        {
            var ancestor = state.AncestorDefinitions[ancestorId];
            player.Lineage.Add(new AncestorState
            {
                DefinitionId = ancestor.Id,
                Name = ancestor.Name,
                Owner = playerId,
                IsAwakened = false,
            });
        }

        foreach (var definitionId in deckDefinitionIds)
        {
            var instanceId = state.NextCardInstanceId++;
            var definition = state.CardDefinitions[definitionId];
            state.Cards[instanceId] = new CardInstance
            {
                Id = instanceId,
                DefinitionId = definition.Id,
                Name = definition.Name,
                Owner = playerId,
                Controller = playerId,
                CardType = definition.CardType,
                Zone = Zone.Deck,
                Tags = definition.Tags,
                BaseKeywords = definition.Keywords,
                BaseAttack = definition.Attack,
                BaseVitality = definition.Vitality,
            };
            player.Deck.Add(instanceId);
        }

        state.Random.Shuffle(player.Deck);
    }
}
