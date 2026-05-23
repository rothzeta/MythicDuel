# 10 — Decision Records

## ADR-001 — Build a new engine beside the old simulator

### Decision

Build a new engine cleanly while keeping the current simulator as reference.

### Rationale

The current engine is structurally unlike the desired engine. A class-by-class refactor would produce a hybrid monster.

### Consequences

Positive:

```text
clean architecture
no forced old abstractions
old simulator remains a source of truth
```

Negative:

```text
some behavior must be reimplemented
temporary duplication
requires discipline to avoid expanding old engine
```

## ADR-002 — Use Seat1/Seat2 instead of Red/Iron

### Decision

Players are seats. Deck/faction are loaded content.

### Rationale

Required for:

```text
mirror matches
second Red deck
boss decks
third faction
PvP
PvE encounters
```

### Consequences

All metrics, reports, and state must use seat/deck/faction dimensions instead of Red/Iron fields.

## ADR-003 — Use data-driven content with C# rule modules

### Decision

Card definitions are data-driven. Complex mechanics are C# modules.

### Rationale

This gives fast iteration without premature DSL complexity.

### Consequences

Data can define most cards. New mechanics still require code.

## ADR-004 — Use stateless OO flyweight rules

### Decision

Keywords/effects/modifiers/triggers are stateless shared rule objects.

### Rationale

This preserves semantic clarity while keeping runtime state lean and copyable.

### Consequences

Runtime state must live in `GameState`, not in rule objects.

## ADR-005 — Use a central RuleIndex

### Decision

Build a `RuleIndex` from state/catalog and query it during resolution.

### Rationale

Avoids naive OO callback soup and avoids polling every card every time.

### Consequences

Need to keep index synchronized. Initial strategy: rebuild at safe boundaries.

## ADR-006 — No full ECS yet

### Decision

Do not build a generic ECS framework for the card game.

### Rationale

A card game does not currently need archetypes, component pools, or system schedulers. ECS would be infrastructure cosplay at this stage.

### Consequences

Use ECS-like ideas selectively:

```text
IDs
lean state
tags/statuses
rule systems
central queries
```

but keep the domain model explicit.

## ADR-007 — No scripting DSL yet

### Decision

Do not build a full card scripting language now.

### Rationale

The game grammar is still changing. A DSL would harden assumptions too early.

### Consequences

Use JSON specs plus C# effect registry.

Reconsider DSL after:

```text
100-200 cards
stable repeated effect grammar
clear content-authoring bottleneck
```

## ADR-008 — Legal action generation is first-class

### Decision

The engine must generate legal actions.

### Rationale

Supports:

```text
bots
UI
PvP
tests
tutorials
debugging
```

### Consequences

UI and bots should not duplicate rules.

## ADR-009 — Hidden-information GameView

### Decision

Bots and UI consume `GameView`, not full `GameState`.

### Rationale

Prepared Tactics and future PvP require real hidden information.

### Consequences

Every player-facing/bot-facing API must go through view projection.

## ADR-010 — Deterministic RNG and replay

### Decision

All randomness comes from seeded engine RNG.

### Rationale

Needed for:

```text
debugging
replays
AI simulations
PvP desync diagnosis
batch report reproducibility
```

### Consequences

No uncontrolled randomness inside rule modules.

## ADR-011 — First vertical slice is human-vs-bot

### Decision

The first playable target is a crude human-vs-bot duel using the new engine.

### Rationale

This gives gameplay feedback early while validating the new architecture.

### Consequences

Do not build a beautiful UI first. The UI can be CLI/debug-level.
