# 04 — Systems Architecture

This document lists the major systems and their responsibilities.

The systems are not necessarily ECS systems. They are focused rule services/modules inside the deterministic core.

## System map

```text
GameEngine
  LegalActionSystem
  ValidationSystem
  ResolutionPipeline
  RuleIndexBuilder
  StateApplier

Rules
  TurnSystem
  PhaseSystem
  DrawSystem
  ResourceSystem
  ZoneSystem
  CombatSystem
  DamageSystem
  DeathSystem
  ShrineSystem
  EvolutionSystem
  PresenceSystem
  PackSystem
  PreparedTacticSystem
  AncestorSystem
  RecallSystem
  ModifierSystem
  ReplacementSystem
  TriggerSystem
  WinConditionSystem
  TimeoutSystem
```

## GameEngine

### Responsibilities

```text
execute commands
coordinate validation
coordinate resolution
ensure deterministic order
return command result
record events/diagnostics
```

### Not responsible for

```text
knowing every card's special behavior
rendering UI
bot decisions
deck construction
save/load
```

## LegalActionSystem

### Responsibilities

```text
generate all legal actions for a player
respect hidden-information view where needed
support bots and UI
provide explanations for why actions are legal
optionally provide illegal-action diagnostics for debugging
```

### Legal action categories

```text
PlayCard
PrepareTactic
DeclareAttack
DeclareBlock
PassBlock
Evolve
ActivateAncestor
Recall
Retain
EndTurn
Concede
```

### Key rule

Bots and UI should choose from legal actions. They should not duplicate gameplay rules.

## ValidationSystem

### Responsibilities

```text
validate submitted commands
detect stale/forged/illegal commands
return clear error codes
protect future PvP server authority
```

Validation should still run even when command came from `LegalActionSystem`.

## TurnSystem

### Responsibilities

```text
start game
start turn
refresh units/resources
draw for turn
advance phases
end turn
cleanup temporary effects
manage first-player rules
```

## ResourceSystem

### Responsibilities

```text
Offerings
Memory
cost payment
resource refresh
cost modifiers
spend validation
refund/cancel behavior if needed
```

Questions it should answer:

```text
Can this player pay this cost?
What is the modified cost?
What resources are consumed?
```

## ZoneSystem

### Responsibilities

```text
move cards between deck, hand, battlefield, discard, forgotten, prepared, banished if added
enforce ownership/controller rules
emit movement events
respect replacement effects such as Fade
```

Zones should be generic per player where appropriate.

Recommended zones:

```text
Deck
Hand
Battlefield
Discard
Forgotten
Prepared
Limbo/Stack/Pending if needed
```

## CombatSystem

### Responsibilities

```text
declare attack
validate attacker
validate target
handle attack slots
handle blocking window
apply Guard/evasion/blocking rules
invoke DamageSystem
mark attacker exhausted
track HasDamagedShrine / HasDestroyedEnemy / HasBrokenShrine if those matter
```

Combat should not hardcode every keyword. It should query modifiers/rules.

## DamageSystem

### Responsibilities

```text
calculate damage
apply damage modifiers
apply prevention/replacement
apply Pierce
mark damage
emit DamageDealt
ask DeathSystem to resolve lethal damage
```

Damage should be staged:

```text
PendingDamage
  -> modifiers
  -> prevention/replacement
  -> final damage event
  -> state application
```

## DeathSystem

### Responsibilities

```text
detect lethal damage
destroy units
move cards to correct zones
emit death/destruction events
trigger death-related effects
```

Do not scatter "if health <= 0" everywhere.

## ShrineSystem

### Responsibilities

```text
represent shrine state
handle shrine damage
handle shrine breaks
handle win/loss conditions tied to shrines
provide shrine target legality
```

Shrines are not just health bars if they interact with ancestors, offerings, memory, or card effects.

## EvolutionSystem

### Responsibilities

```text
generate legal evolution actions
validate L1 -> L2 -> L3 rules
forbid downward evolution
forbid illegal hard-cast evolution cards if rule enabled
handle Mythic constraints
move/replace/evolve card instances
preserve or transform damage/status/attachments according to game rules
emit CardEvolved events
```

Evolution should be its own system, not a special case inside PlayCard.

## PresenceSystem

### Responsibilities

```text
calculate presence usage
enforce presence limit
apply presence modifiers
block overfilled board states
support diagnostics
```

## PackSystem

### Responsibilities

```text
count ready Pack Beings
increase maximum attacks up to 5
enforce that extra attack slots beyond normal slots must be made by Pack members
track Pack attack diagnostics
```

Potential rule expression:

```text
Normal max attacks = 2.
Pack increases max attacks by number of ready Pack Beings, capped at 5.
Attack slots 1-2 may be any legal attacker.
Attack slots 3-5 must be Pack attackers.
```

If the design changes, this is the one system to modify.

## PreparedTacticSystem

### Responsibilities

```text
prepare tactics face-down
keep identity hidden from opponent
reveal when triggered/played
validate prepared tactic timing
move resolved Fade tactics to Forgotten if applicable
```

This system must be designed with hidden information from the beginning.

## AncestorSystem

### Responsibilities

```text
represent lineage/ancestor state
generate legal ancestor actions
activate ancestors
track ancestor value/diagnostics
apply ancestor modifiers/triggers
```

Ancestors should not be hardcoded into player-specific logic.

## RecallSystem

### Responsibilities

```text
generate legal recall actions
validate recall restrictions
forbid Mythic Recall if that is a rule
move cards from discard/forgotten/etc. according to rules
apply recall costs
```

## ModifierSystem

### Responsibilities

```text
answer derived property queries
apply stat modifiers
apply keyword grants/removals
apply cost modifiers
apply targeting modifiers
apply action availability modifiers
```

Example queries:

```text
GetAttack(card)
GetVitality(card)
HasKeyword(card, Pierce)
CanBlock(card)
CanAttack(card)
GetCost(card)
```

Derived values should be queried through systems, not recalculated ad hoc.

## ReplacementSystem

### Responsibilities

```text
handle "instead" effects
replace pending events before they commit
resolve replacement ordering
prevent double-application
```

Examples:

```text
Fade replaces move-to-discard-after-resolution with move-to-forgotten.
Prevent destruction replaces destruction event with no-op or shield removal.
```

## TriggerSystem

### Responsibilities

```text
collect triggers from committed events
order triggers deterministically
resolve trigger queue
prevent infinite loops
record trigger diagnostics
```

## WinConditionSystem

### Responsibilities

```text
check shrine-loss win condition
check deck-out if applicable
check concession
check timeout
check special win/loss effects
```

## TimeoutSystem

### Responsibilities

```text
prevent infinite simulations
distinguish timeout from normal loss
record why timeout happened
support batch diagnostics
```

Timeout should be a separate outcome, not silently counted as a win for either side.

## MetricSystem

### Responsibilities

```text
consume event log / diagnostics
aggregate by seat, deck, faction, matchup, card, keyword
avoid Red/Iron-specific metric names
```

MetricSystem should not affect gameplay.
