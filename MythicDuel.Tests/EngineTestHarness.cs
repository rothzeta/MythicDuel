using MythicDuel.Core.Cards;
using MythicDuel.Core.Game;
using MythicDuel.Core.Models;

namespace MythicDuel.Tests;

internal static class EngineTestHarness
{
    public static GameState CreateState(int seed = 123)
    {
        return GameFactory.Create(seed);
    }

    public static CardInstance AddBattlefieldCard(GameState state, PlayerId playerId, string definitionId, bool exhausted = false)
    {
        var player = state.GetPlayer(playerId);
        var id = state.NextCardInstanceId++;
        var definition = state.CardDefinitions[definitionId];
        var card = new CardInstance
        {
            Id = id,
            DefinitionId = definition.Id,
            Name = definition.Name,
            Owner = playerId,
            Controller = playerId,
            CardType = definition.CardType,
            Zone = Zone.Battlefield,
            Tags = definition.Tags,
            BaseKeywords = definition.Keywords,
            BaseAttack = definition.Attack,
            BaseVitality = definition.Vitality,
            IsExhausted = exhausted,
        };
        state.Cards[id] = card;
        player.Battlefield.Add(id);
        return card;
    }

    public static CardInstance AddHandCard(GameState state, PlayerId playerId, string definitionId)
    {
        var player = state.GetPlayer(playerId);
        var id = state.NextCardInstanceId++;
        var definition = state.CardDefinitions[definitionId];
        var card = new CardInstance
        {
            Id = id,
            DefinitionId = definition.Id,
            Name = definition.Name,
            Owner = playerId,
            Controller = playerId,
            CardType = definition.CardType,
            Zone = Zone.Hand,
            Tags = definition.Tags,
            BaseKeywords = definition.Keywords,
            BaseAttack = definition.Attack,
            BaseVitality = definition.Vitality,
        };
        state.Cards[id] = card;
        player.Hand.Add(id);
        return card;
    }

    public static CardInstance AddDiscardCard(GameState state, PlayerId playerId, string definitionId)
    {
        var player = state.GetPlayer(playerId);
        var id = state.NextCardInstanceId++;
        var definition = state.CardDefinitions[definitionId];
        var card = new CardInstance
        {
            Id = id,
            DefinitionId = definition.Id,
            Name = definition.Name,
            Owner = playerId,
            Controller = playerId,
            CardType = definition.CardType,
            Zone = Zone.Discard,
            Tags = definition.Tags,
            BaseKeywords = definition.Keywords,
            BaseAttack = definition.Attack,
            BaseVitality = definition.Vitality,
        };
        state.Cards[id] = card;
        player.Discard.Add(id);
        return card;
    }

    public static IGameBot ScriptedBot(params TurnDecision[] turns)
    {
        return new SequenceBot(turns);
    }

    public static IGameBot BlockingBot(params TurnDecision[] turns)
    {
        return new BlockingSequenceBot(turns);
    }

    public static GameView CreateView(GameState state, PlayerId perspective)
    {
        var self = state.GetPlayer(perspective);
        var opponent = state.GetOpponent(perspective);
        var visibleCardIds = new HashSet<int>(self.Hand);

        foreach (var cardId in self.Battlefield.Concat(opponent.Battlefield).Concat(self.Discard).Concat(opponent.Discard).Concat(self.Forgotten).Concat(opponent.Forgotten))
        {
            visibleCardIds.Add(cardId);
        }

        foreach (var preparedId in self.PreparedTacticIds)
        {
            visibleCardIds.Add(preparedId);
        }

        var cards = visibleCardIds
            .Where(state.Cards.ContainsKey)
            .ToDictionary(
                id => id,
                id =>
                {
                    var card = state.Cards[id];
                    var definition = state.CardDefinitions[card.DefinitionId];
                    return new CardPublicView(
                        Id: card.Id,
                        DefinitionId: card.DefinitionId,
                        Name: card.Name,
                        Owner: card.Owner,
                        Controller: card.Controller,
                        CardType: card.CardType,
                        Zone: card.Zone,
                        Tags: card.Tags.ToList(),
                        Keywords: card.BaseKeywords,
                        Level: definition.Level,
                        PresenceCost: definition.PresenceCost,
                        BaseAttack: card.BaseAttack,
                        BaseVitality: card.BaseVitality,
                        Damage: card.Damage,
                        IsExhausted: card.IsExhausted,
                        IsWounded: card.IsWounded,
                        HostId: card.HostId,
                        AttachedRelicId: card.AttachedRelicId,
                        AttachedPossessionId: card.AttachedPossessionId);
                });

        return new GameView(
            Perspective: perspective,
            Seed: state.Seed,
            TurnNumber: state.TurnNumber,
            PhaseNumber: state.PhaseNumber,
            StandardAssaultSlotsPerCombat: state.StandardAssaultSlotsPerCombat,
            MaxPackAttacksPerCombat: state.MaxPackAttacksPerCombat,
            Cards: cards,
            Self: CreatePlayerView(state, self, cards, revealPreparedTactic: true),
            Opponent: CreatePlayerView(state, opponent, cards, revealPreparedTactic: false),
            PublicEvents: state.Events.ToList());
    }

    private static PlayerPublicView CreatePlayerView(GameState state, PlayerState player, IReadOnlyDictionary<int, CardPublicView> cards, bool revealPreparedTactic)
    {
        return new PlayerPublicView(
            Id: player.Id,
            Seat: player.Seat,
            Name: player.Name,
            Faction: player.Faction,
            DeckName: player.DeckName,
            CurrentOfferings: player.CurrentOfferings,
            Memory: player.Memory,
            MaxOfferings: player.MaxOfferings,
            PresenceLimit: player.PresenceLimit,
            PresenceUsed: player.Battlefield.Where(cards.ContainsKey).Select(id => cards[id]).Sum(card => card.PresenceCost),
            Hand: player.Hand.Where(cards.ContainsKey).ToList(),
            Battlefield: player.Battlefield.Where(cards.ContainsKey).ToList(),
            Forgotten: player.Forgotten.Where(cards.ContainsKey).Select(id => cards[id].Name).ToList(),
            Shrines: player.Shrines.Select(shrine => new ShrinePublicView(shrine.DefinitionId, shrine.Name, shrine.Owner, shrine.Vitality, shrine.Damage)).ToList(),
            AwakenedAncestorDefinitionId: player.AwakenedAncestorDefinitionId,
            PreparedTacticCardIds: revealPreparedTactic ? player.PreparedTacticIds.Where(cards.ContainsKey).ToList() : [],
            HasPreparedTactic: player.PreparedTacticIds.Count > 0);
    }

    private sealed class SequenceBot : IGameBot
    {
        private readonly Queue<TurnDecision> _turns;

        public SequenceBot(IEnumerable<TurnDecision> turns)
        {
            _turns = new Queue<TurnDecision>(turns);
        }

        public string Name => "scripted";

        public TurnDecision ChooseTurn(GameView view, PlayerId playerId, IReadOnlyList<PlayerAction> legalMain1, IReadOnlyList<AttackDecision> legalAttacks, IReadOnlyList<PlayerAction> legalMain2, IReadOnlyList<PlayerAction> legalAwakenings)
        {
            return _turns.Count > 0 ? _turns.Dequeue() : new TurnDecision();
        }

        public int? ChooseRetainedCard(GameView view, PlayerId playerId, IReadOnlyList<int> handCardIds)
        {
            return handCardIds.FirstOrDefault();
        }

        public AwakenAncestorAction? ChooseAwakening(GameView view, PlayerId playerId, IReadOnlyList<AwakenAncestorAction> legalAwakenings)
        {
            return legalAwakenings.FirstOrDefault();
        }

        public BlockDecision? ChooseBlock(GameView view, PlayerId defender, AttackDecision attack, IReadOnlyList<BlockDecision> legalBlocks)
        {
            return legalBlocks.FirstOrDefault();
        }

        public int? ChoosePreparedReplacement(GameView view, PlayerId playerId, IReadOnlyList<int> preparedTacticCardIds, int incomingPreparedCardId)
        {
            return preparedTacticCardIds.FirstOrDefault();
        }
    }

    private sealed class BlockingSequenceBot : IGameBot
    {
        private readonly Queue<TurnDecision> _turns;

        public BlockingSequenceBot(IEnumerable<TurnDecision> turns)
        {
            _turns = new Queue<TurnDecision>(turns);
        }

        public string Name => "blocking-scripted";

        public TurnDecision ChooseTurn(GameView view, PlayerId playerId, IReadOnlyList<PlayerAction> legalMain1, IReadOnlyList<AttackDecision> legalAttacks, IReadOnlyList<PlayerAction> legalMain2, IReadOnlyList<PlayerAction> legalAwakenings)
        {
            return _turns.Count > 0 ? _turns.Dequeue() : new TurnDecision();
        }

        public int? ChooseRetainedCard(GameView view, PlayerId playerId, IReadOnlyList<int> handCardIds)
        {
            return handCardIds.FirstOrDefault();
        }

        public AwakenAncestorAction? ChooseAwakening(GameView view, PlayerId playerId, IReadOnlyList<AwakenAncestorAction> legalAwakenings)
        {
            return legalAwakenings.FirstOrDefault();
        }

        public BlockDecision? ChooseBlock(GameView view, PlayerId defender, AttackDecision attack, IReadOnlyList<BlockDecision> legalBlocks)
        {
            return legalBlocks.FirstOrDefault(block => block.BlockerId.HasValue) ?? legalBlocks.FirstOrDefault();
        }

        public int? ChoosePreparedReplacement(GameView view, PlayerId playerId, IReadOnlyList<int> preparedTacticCardIds, int incomingPreparedCardId)
        {
            return preparedTacticCardIds.FirstOrDefault();
        }
    }
}
