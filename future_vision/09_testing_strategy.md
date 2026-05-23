# 09 — Testing Strategy

## Testing goals

Tests should prove:

```text
rules are correct
illegal actions are impossible
legal action generation is reliable
hidden information is respected
simulation does not hang
metrics detect design problems
```

Do not overtest internal implementation details.

Favor black-box tests:

```text
Given state
When command/action
Then events/state/outcome
```

## Test layers

```text
1. Unit tests for pure small rules.
2. Scenario tests for board states.
3. Invariant tests for impossible states.
4. Catalog validation tests.
5. Golden reference tests.
6. Batch simulation sanity tests.
7. Replay determinism tests.
```

## 1. Unit tests

Use for small deterministic rules.

Examples:

```text
cost calculation
presence calculation
Pack max attacks calculation
keyword query
modifier ordering
replacement ordering
catalog validation
```

Example:

```text
Given 3 ready Pack Beings
When calculating attack allowance
Then maximum attacks is 5
And extra slots require Pack attackers
```

## 2. Scenario tests

Use explicit board setup.

Examples:

```text
Given Leopard Hunter wielding a weapon
When it attacks
Then it has Pierce.

Given SoulSlayer is Possessed
When it deals damage
Then Pierce is active.

Given Fade tactic resolves
When it would enter discard
Then it enters Forgotten.

Given opponent has face-down Prepared Tactic
When building my GameView
Then card identity is hidden.
```

## 3. Invariant tests

Run after every command in simulations.

Invariants:

```text
no card exists in two zones
all zone card IDs exist in GameState
no negative resources
presence usage <= presence limit
dead units are not on battlefield
forbidden hard-cast evolution did not occur
Mythic was not recalled if forbidden
downward evolution did not occur
non-Pack did not use extra Pack attack slot
hidden information not exposed in GameView
game outcome is not both Seat1 and Seat2 win
```

## 4. Catalog validation tests

Catalog should fail fast.

Tests:

```text
missing card reference fails
missing keyword id fails
invalid effect parameter fails
invalid evolution link fails
invalid max copies fails
duplicate definition id fails
deck has too many copies fails
card level invalid fails
```

## 5. Golden reference tests

The old simulator is not source code to migrate, but it is a reference.

Create tests from known rules:

```text
Mythic cannot hard-cast.
Mythic cannot Recall.
Evolution cannot go downward.
L1 -> L2 works.
L2 -> L3 works.
Presence blocks overfilled board.
Unique blocks duplicate Mythic.
Pack grants Pack-only extra attacks.
Retain zero is allowed.
Timeout is separate outcome.
Fade moves resolved card to Forgotten.
Prepared Tactics are hidden.
```

These tests are more important than exact old/new event equality.

## 6. Batch simulation sanity tests

Run 100+ games for sanity.

Do not assert exact win rates.

Assert:

```text
no crashes
timeout rate under threshold
legal action list is never empty unless game ended
L2 evolution appears at least once in evolution deck
forbidden hard-cast count is zero
Pack attack count > 0 in Pack deck
Prepared Tactic reveal count > 0 in tactic deck
hidden info leak count = 0
```

## 7. Replay determinism tests

Test:

```text
Given seed S and command list C
When replayed twice
Then final state hash is identical
And event log hash is identical
```

State hash should include gameplay-relevant state only, not debug timestamps.

## Test project layout

```text
tests/
  MythicDuel.Core.Tests/
    Rules/
    Scenarios/
    Invariants/
    Replay/

  MythicDuel.Content.Tests/
    CatalogValidation/
    DeckValidation/

  MythicDuel.Sim.Tests/
    BatchSanity/
    Metrics/
```

## Test naming style

Use readable names:

```text
Pack_extra_attack_slots_require_pack_attackers
Fade_moves_resolved_tactic_to_forgotten
Mythic_cannot_be_recalled
Prepared_tactic_identity_is_hidden_from_opponent_view
Evolution_cannot_go_downward
```

## Avoid

Avoid tests that know implementation details like:

```text
RuleIndex contains exactly 7 objects
CombatSystem calls DamageSystem once
ModifierSystem iterates before ReplacementSystem by mock verification
```

Prefer observable behavior.

## Scenario builder

Create a test scenario builder early.

Example DSL-ish C# builder:

```csharp
var state = Scenario
    .Game()
    .WithPlayer(Seat1, deck: "red.hunter")
    .WithPlayer(Seat2, deck: "iron.hyena")
    .WithBattlefield(Seat1, "red.leopard_hunter", out var leopard)
    .WithAttachedRelic(leopard, "red.iron_spear")
    .Build();
```

This will save enormous time.

## Debug outputs for failed tests

When a scenario test fails, print:

```text
seed
command
legal actions
event log
state summary
rule diagnostics
```
