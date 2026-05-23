# 05 — Game State and Data Model

## Core principle

`GameState` is truth.

`CardCatalog` is static knowledge.

`RuleIndex` is derived cache.

`RuleModules` are behavior.

Do not store duplicate truth in multiple places unless one is explicitly a cache.

## ID-first model

Use strongly typed IDs:

```text
GameId
PlayerId
SeatId
DeckId
FactionId
CardDefinitionId
CardInstanceId
KeywordId
EffectId
RuleId
ShrineId
AncestorId
ZoneId
```

Avoid raw strings in core logic after catalog compilation.

## Seat/deck/faction separation

Do not hardcode Red and Iron.

Use:

```text
Seat1
Seat2
```

Each seat has:

```text
DeckId
FactionId
DisplayName
PlayerType
```

Example:

```text
Seat1:
  deckId = red.hunter_evolution
  factionId = red.baobab
  displayName = Red Hunter Evolution

Seat2:
  deckId = iron.hyena_pack
  factionId = iron.hyena
  displayName = Iron Hyena Pack
```

This supports:

```text
mirror matches
second Red deck
boss decks
third faction
PvP
PvE encounters
```

## GameState

Recommended conceptual shape:

```csharp
public sealed class GameState
{
    public GameId GameId { get; init; }
    public int TurnNumber { get; set; }
    public PlayerId ActivePlayer { get; set; }
    public Phase CurrentPhase { get; set; }

    public Dictionary<PlayerId, PlayerState> Players { get; } = new();
    public Dictionary<CardInstanceId, CardInstance> Cards { get; } = new();

    public GameOutcome? Outcome { get; set; }

    public List<GameEvent> Events { get; } = new();
    public GameDiagnostics Diagnostics { get; } = new();

    public DeterministicRandomState Random { get; set; }
}
```

Mutable state inside the engine is acceptable if all mutations go through controlled systems and command resolution remains deterministic.

## PlayerState

Recommended conceptual shape:

```csharp
public sealed class PlayerState
{
    public PlayerId Id { get; init; }
    public SeatId Seat { get; init; }

    public DeckId DeckId { get; init; }
    public FactionId FactionId { get; init; }

    public ZoneState Deck { get; } = new(Zone.Deck);
    public ZoneState Hand { get; } = new(Zone.Hand);
    public ZoneState Battlefield { get; } = new(Zone.Battlefield);
    public ZoneState Discard { get; } = new(Zone.Discard);
    public ZoneState Forgotten { get; } = new(Zone.Forgotten);
    public ZoneState Prepared { get; } = new(Zone.Prepared);

    public List<ShrineState> Shrines { get; } = new();
    public List<AncestorState> Lineage { get; } = new();

    public int MaxOfferings { get; set; }
    public int CurrentOfferings { get; set; }
    public int Memory { get; set; }

    public int PresenceLimit { get; set; } = 6;
}
```

## ZoneState

Use zone containers to preserve ordering when needed:

```csharp
public sealed class ZoneState
{
    public Zone Zone { get; }
    public List<CardInstanceId> Cards { get; } = new();
}
```

Deck and hand order matter.

Battlefield order may matter if you introduce positioning later.

## CardInstance

Recommended shape:

```csharp
public sealed class CardInstance
{
    public CardInstanceId Id { get; init; }
    public CardDefinitionId DefinitionId { get; init; }

    public PlayerId Owner { get; init; }
    public PlayerId Controller { get; set; }

    public Zone Zone { get; set; }

    public int Damage { get; set; }
    public bool IsExhausted { get; set; }
    public bool IsWounded { get; set; }

    public Dictionary<CounterType, int> Counters { get; } = new();
    public HashSet<CardStatus> Statuses { get; } = new();

    public CardInstanceId? AttachedRelicId { get; set; }
    public CardInstanceId? AttachedPossessionId { get; set; }
    public CardInstanceId? HostId { get; set; }

    public int CreatedOrder { get; init; }
}
```

Do not store local copies of keyword/effect objects on the instance.

Use `DefinitionId` to look up static rules.

Runtime keyword grants/removals are statuses/modifiers in state.

## ShrineState

```csharp
public sealed class ShrineState
{
    public ShrineId Id { get; init; }
    public PlayerId Owner { get; init; }

    public int Index { get; init; }
    public int Damage { get; set; }
    public bool IsBroken { get; set; }

    public HashSet<ShrineStatus> Statuses { get; } = new();
}
```

## AncestorState

```csharp
public sealed class AncestorState
{
    public AncestorId Id { get; init; }
    public PlayerId Owner { get; init; }

    public bool IsAwake { get; set; }
    public bool IsExhausted { get; set; }

    public int Charges { get; set; }
    public HashSet<AncestorStatus> Statuses { get; } = new();
}
```

## Runtime vs definition data

Definition data:

```text
name
base attack/vitality
cost
level
tags
printed keywords
printed effects
evolution links
deckbuilding constraints
```

Runtime data:

```text
zone
controller
damage
exhaustion
wounded
counters
temporary statuses
attachments
revealed/hidden state
```

## Hidden information

Hidden information should be represented in `GameView`, not by mutilating `GameState`.

`GameState` knows the true card identity.

`GameView` hides what the viewer should not see.

Examples:

```text
Opponent hand:
  count only

Opponent prepared tactic:
  card back / unknown prepared tactic id
  maybe reveal metadata only if rules allow

Opponent deck:
  count only
```

## Copying for simulation

Keep `GameState` copyable.

Rule modules and catalog should not be copied.

A simulation clone copies:

```text
primitive state
card instances
zone lists
player resources
shrine/ancestor state
rng state
```

It does not copy:

```text
CardCatalog
RuleRegistry
rule module singletons
UI assets
bot objects
```
