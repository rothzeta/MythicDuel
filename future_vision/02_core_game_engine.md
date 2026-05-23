# 02 — Core Game Engine

## Design goal

The core engine should be a deterministic function-like system:

```text
GameState + Command + Catalog + Rules + Seeded RNG
    -> New GameState + Events + Diagnostics
```

The engine can be implemented with mutable objects internally for simplicity, but the observable behavior must be deterministic and replayable.

## Main loop

```text
1. Build GameView for active player.
2. Generate legal actions.
3. Player/bot chooses a legal action.
4. Convert legal action to command.
5. Validate command.
6. Resolve command through pipeline.
7. Apply events/state mutations.
8. Rebuild/refresh RuleIndex if needed.
9. Check win/loss/timeout.
10. Continue.
```

## Command pipeline

Recommended command flow:

```text
Command
  -> Validate
  -> Build ResolutionContext
  -> Modify / cost adjustment
  -> Intercept / replacement effects
  -> Resolve primary effect
  -> Emit events
  -> Apply state mutations
  -> Collect triggers
  -> Resolve trigger queue
  -> Cleanup
  -> Check win conditions
```

Do not make cards randomly mutate the world. Everything meaningful passes through a command or an internal resolution step.

## Commands

Commands represent player intent or forced system actions.

Examples:

```text
StartGameCommand
DrawForTurnCommand
PlayCardCommand
PrepareTacticCommand
DeclareAttackCommand
DeclareBlockCommand
PassBlockCommand
EvolveCommand
ActivateAncestorCommand
RecallCommand
EndTurnCommand
RetainCardsCommand
ConcedeCommand
```

Commands should be explicit and serializable.

A future PvP server can receive exactly these commands.

## Legal actions

Legal action generation is as important as validation.

The engine should answer:

```text
Given this state and this player's view, what can this player legally do?
```

This supports:

```text
bots
UI
PvP client validation
scenario tests
debugging
tutorial hints
```

Recommended distinction:

```text
LegalAction = engine-generated option
Command     = selected player intent submitted for validation/resolution
```

Example:

```text
LegalAction:
  Type = Evolve
  Source = CardInstanceId(17)
  TargetEvolution = CardDefinitionId("red.leopard_hunter_l2")
  CostPreview = ...
  Explanation = "L1 can evolve to L2 because conditions are met"

Command:
  EvolveCommand(PlayerId.Seat1, SourceId, TargetDefinitionId)
```

The UI should mostly render legal actions rather than duplicate rules.

## Events vs state mutations

Avoid turning the engine into noisy enterprise event sourcing.

Use events for facts worth replaying, displaying, debugging, or reporting.

Possible event categories:

```text
Public     - visible game fact
Internal   - needed for deterministic replay but not UI-worthy
Metric     - diagnostic only
Debug      - verbose development detail
```

Examples of useful public/replay events:

```text
CardDrawn
CardPlayed
CardPrepared
CardRevealed
AttackDeclared
BlockDeclared
DamageDealt
ShrineDamaged
ShrineBroken
CardDestroyed
CardMoved
CardEvolved
KeywordApplied
ReplacementApplied
TriggerResolved
TurnEnded
GameEnded
```

For tiny internal state changes, either use internal events or direct state mutation through a controlled `StateApplier`.

## ResolutionContext

Resolution needs temporary data that is not part of permanent state.

Examples:

```text
source card
targets
attacker
blocker
pending damage
pending movement
cost calculation
active replacement effects
trigger queue
rng
event buffer
diagnostic buffer
```

Recommended shape:

```text
ResolutionContext
  Command
  ActingPlayer
  Phase
  RuleIndex
  Catalog
  Random
  PendingEvents
  PendingTriggers
  Diagnostics
```

## RuleIndex

The `RuleIndex` is a derived lookup cache built from:

```text
GameState
CardCatalog
active zones
attachments
statuses
temporary effects
global effects
```

It should contain pre-filtered lists:

```text
ActiveModifiers
ActiveTriggers
ActiveReplacementEffects
ActiveStaticRules
ActionProviders
CostModifiers
TargetingModifiers
CombatModifiers
DamageModifiers
```

The pipeline queries the `RuleIndex` instead of broadcasting to every card.

## RuleIndex update strategy

Recommended for v0.2:

```text
Rebuild from scratch at safe boundaries.
```

Use a dirty flag:

```text
- Start of command: ensure RuleIndex is fresh.
- During resolution: if structural state changes, mark dirty.
- Before next major phase/window: rebuild if dirty.
```

This is safer than incremental updates.

Later, if performance demands it, add incremental indexing.

## Deterministic RNG

All randomness must come from a controlled RNG service.

Store:

```text
seed
rng step count
command log
```

This allows replaying a strange game exactly.

Do not call `Random.Shared` or uncontrolled randomness from rule modules.

## Determinism rules

To preserve deterministic behavior:

```text
- Sort all ambiguous rule lists deterministically.
- Use stable IDs.
- Avoid dictionary iteration order as gameplay order.
- Use seeded RNG only.
- Avoid real time inside rules.
- Avoid UI callbacks inside core.
- Avoid async inside core resolution unless it is purely adapter-level.
```

Recommended stable rule ordering:

```text
1. layer
2. priority
3. source timestamp
4. source card instance id
5. rule id
```

## Core engine responsibilities

The core engine owns:

```text
turn progression
phase progression
resource refresh/spend
card movement
combat
damage
death/destruction
evolution
prepared tactics
hidden-information correctness
ancestor activation
keyword/modifier/replacement/trigger resolution
win/loss/timeout
legal action generation
deterministic event log
```

The core engine does not own:

```text
deck collection ownership
visual assets
audio
save/load format
network protocol
account identity
matchmaking
reward selection
roguelite map
```
