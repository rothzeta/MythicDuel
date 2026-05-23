# 08 — Development Plan

## Strategy

Build a new engine cleanly.

Keep current simulator as reference.

First major target:

```text
New engine can run a crude human-vs-bot duel.
```

Do not wait months to play. Build the minimum playable vertical slice.

## Phase 0 — Freeze and inventory

### Goal

Stop expanding the old engine architecturally. Extract knowledge from it.

### Tasks

```text
- Freeze old simulator behavior.
- Write rule inventory.
- List known bugs already discovered.
- List current mechanics.
- List current cards/decks/shrines/ancestors.
- Capture current batch reports as reference documents.
- Add a few golden scenarios if easy.
```

### Deliverables

```text
rules_inventory.md
known_engine_bugs.md
reference_reports/
```

### Exit criteria

```text
You can describe all current rules without reading the old GameEngine line by line.
```

## Phase 1 — New core skeleton

### Goal

Create the new project and minimal deterministic game loop.

### Tasks

```text
- Create MythicDuel.Core.
- Create typed IDs.
- Create GameState.
- Create PlayerState.
- Create CardInstance.
- Create CardDefinition.
- Create Seat1/Seat2.
- Create DeckDefinition.
- Create deterministic RNG wrapper.
- Create GameEngine.Execute(command).
- Create basic event log.
```

### Mechanics included

```text
none or almost none
```

### Exit criteria

```text
A test can create a game with Seat1 and Seat2 and execute StartGameCommand.
```

## Phase 2 — Catalog and deck loading

### Goal

Load Red and Iron as decks, but without Red/Iron hardcoding.

### Tasks

```text
- Create MythicDuel.Content.
- Define CardDefinitionSpec.
- Define DeckDefinitionSpec.
- Implement catalog loader.
- Implement catalog validation.
- Port minimal Red and Iron card data.
- Compile specs into CardDefinitions.
```

### Exit criteria

```text
Seat1 loads red.hunter deck.
Seat2 loads iron.hyena deck.
No core code knows about "Red player" or "Iron player".
```

## Phase 3 — Legal actions foundation

### Goal

Make the engine produce legal actions.

### Tasks

```text
- Define LegalAction base model.
- Implement GameView.
- Implement LegalActionSystem.
- Generate EndTurn.
- Generate PlayCard for simple playable cards.
- Generate DeclareAttack for basic attackers.
- Generate DeclareBlock / PassBlock.
```

### Exit criteria

```text
Given a state, the engine can list legal actions for Seat1.
A bot can choose from the list.
```

## Phase 4 — Minimal battle loop

### Goal

One duel can start, progress, and end.

### Mechanics included

```text
draw
hand
deck
battlefield
discard
play Being
basic attack
basic block
damage
destroy
shrine damage
end turn
win condition
```

### Tasks

```text
- Implement TurnSystem.
- Implement DrawSystem.
- Implement ZoneSystem.
- Implement CombatSystem basic attack.
- Implement DamageSystem.
- Implement DeathSystem.
- Implement ShrineSystem.
- Implement WinConditionSystem.
- Implement RandomLegalBot.
```

### Exit criteria

```text
Bot vs bot can complete 10 games without crashing.
A command log can replay a game with the same result.
```

## Phase 5 — Crude human-vs-bot runner

### Goal

Make the new engine playable.

### UI can be one of:

```text
CLI menu
terminal TUI
minimal Godot debug screen
minimal web debug page
```

### Required UI features

```text
show hand
show battlefield
show shrines
show resources
show legal actions
choose action by number
show event log
```

### Exit criteria

```text
Human can play Seat1 against a simple bot on Seat2.
The game can end.
```

## Phase 6 — Rule modules and RuleIndex

### Goal

Add the architecture that will scale to real mechanics.

### Tasks

```text
- Add RuleIndex.
- Add RuleIndexBuilder.
- Add IKeywordModule.
- Add IEffectModule.
- Add IModifierProvider.
- Add IReplacementProvider.
- Add ITriggerProvider.
- Add ModifierSystem.
- Add ReplacementSystem.
- Add TriggerSystem.
```

### Exit criteria

```text
At least one keyword and one replacement effect work through RuleIndex.
```

Recommended first mechanics:

```text
Pierce
Fade
WeaponMaster
SoulSlayer
```

## Phase 7 — Evolution and Mythic rules

### Goal

Port evolution correctly.

### Tasks

```text
- Implement EvolutionSystem.
- Add L1/L2/L3 definitions.
- Generate legal evolve actions.
- Forbid downward evolution.
- Forbid hard-cast evolution cards when rule flag enabled.
- Forbid Mythic Recall if that is a rule.
- Enforce duplicate/unique rules.
```

### Exit criteria

```text
L1 -> L2 works.
L2 -> L3 works.
Downward evolution impossible.
Forbidden hard-cast count is zero.
```

## Phase 8 — Pack, Presence, Prepared Tactics, Ancestors

### Goal

Bring the game closer to current design parity.

### Tasks

```text
- Implement PresenceSystem.
- Implement PackSystem.
- Implement PreparedTacticSystem with hidden GameView.
- Implement AncestorSystem.
- Implement RecallSystem.
- Add metrics for each.
```

### Exit criteria

```text
Pack extra attacks work.
Presence blocks overfill.
Prepared Tactics are hidden from opponent view.
Ancestors can be activated and reported.
Recall respects restrictions.
```

## Phase 9 — Simulation and reports

### Goal

Replace current batch reports with new-engine reports.

### Tasks

```text
- Create MythicDuel.Sim.
- Add bot-vs-bot batch runner.
- Add CSV/JSON/Markdown report writer.
- Add metrics collector.
- Add invariant report.
- Add seed replay support.
```

### Exit criteria

```text
100 games Seat1(red.hunter) vs Seat2(iron.hyena) produce a readable report.
Reports are not Red/Iron hardcoded.
```

## Phase 10 — Second deck / content expansion

### Goal

Prove the architecture is generic.

### Tasks

```text
- Add second Red deck.
- Run Red mirror.
- Run Red deck A vs Red deck B.
- Run Red deck B vs Iron.
- Fix any deck/faction assumptions.
```

### Exit criteria

```text
No engine code changes are needed to support second deck except new data/effects.
```

## Phase 11 — UI prototype upgrade

### Goal

Start making the game feel like a game.

### Options

```text
Godot UI
web UI
MonoGame UI
desktop debug UI
```

### Keep UI separate

The UI consumes:

```text
GameView
LegalActions
Events
```

and sends:

```text
Command
```

### Exit criteria

```text
The UI does not contain battle rules.
The same core engine still runs simulations headlessly.
```

## Phase 12 — Roguelite wrapper

### Goal

Add mode layer without contaminating battle core.

### Tasks

```text
- Create RunService.
- Create EncounterDefinition.
- Create Reward system.
- Modify deck between battles.
- Start battles with run-modified deck/state.
- Record run progression.
```

### Exit criteria

```text
Roguelite mode can start a battle, complete it, award a card/reward, and start the next battle.
```

## Phase 13 — PvP readiness

### Goal

Prepare server-authoritative play.

### Tasks

```text
- Verify command serialization.
- Verify deterministic replay.
- Verify GameView hiding.
- Verify server validation.
- Add desync diagnostics.
- Add match event stream.
```

### Exit criteria

```text
A server process can own GameState and clients can play by submitting commands.
```

## Recommended immediate next 10 tasks

```text
1. Create new solution/project skeleton.
2. Add typed IDs.
3. Add GameState, PlayerState, CardInstance.
4. Add Seat1/Seat2.
5. Add CardDefinition and DeckDefinition.
6. Add basic catalog with 5-10 cards.
7. Add StartGameCommand and EndTurnCommand.
8. Add LegalAction generation for EndTurn and PlayCard.
9. Add simple bot choosing legal actions.
10. Add crude CLI human-vs-bot runner.
```
