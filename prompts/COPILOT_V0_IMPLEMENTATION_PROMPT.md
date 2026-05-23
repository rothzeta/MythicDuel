# Copilot Agent Prompt — Mythic Duel v0 Simulator

You are implementing **v0** of a headless automated playtest simulator for a card game prototype called **Mythic Duel**.

Do not stop after planning. Do not ask clarifying questions. Make reasonable implementation decisions when details are missing. Continue until the solution builds, tests pass, and the sample simulations run from the command line.

The v0 goal is not to build a beautiful scalable engine.

The v0 goal is:

```text
Run Red Baobab vs Iron Hyena automatically.
Generate deterministic reports.
Expose whether the current rules are broken.
```

Build the simplest deterministic simulator that can do that.

Do **not** build:
- a universal TCG framework
- a JSON card scripting system
- a web UI
- a database
- a Vue app
- a generic ECS framework
- deep OOP inheritance for card types

It is acceptable and expected that v0 has hardcoded cards, hardcoded decks, hardcoded rules, and simple bots.

============================================================
PROJECT STRUCTURE
============================================================

Create a .NET solution with these projects:

1. MythicDuel.Core
   - Pure-ish game engine/domain logic.
   - No UI.
   - Deterministic.
   - Contains game state, cards, rules, combat, events, metrics models.

2. MythicDuel.Sim
   - Console app.
   - Runs single or batch simulations.
   - Generates reports.

3. MythicDuel.Tests
   - Unit tests for core rules.
   - Use xUnit or MSTest. Prefer xUnit if starting from scratch.

You may add a MythicDuel.Reports project only if it stays simple. Otherwise put reporting in Sim.

============================================================
ARCHITECTURE GUARDRAILS FOR V0
============================================================

Use simple records/classes with explicit fields.

Avoid deep inheritance.

Do not model cards as:
- class Being : Card
- class Spirit : Card
- class Hunter : Being
- class LeopardHunter : Hunter

Instead use:
- CardDefinition
- CardInstance
- CardType enum
- Keyword flags/list
- Tags
- Zone enum
- simple state fields

Example state fields:
- Attack
- Vitality
- Damage
- IsExhausted
- IsWounded
- WoundedClearsOnTurn
- AttachedRelicId
- AttachedPossessionId
- Controller
- Zone
- Tags
- Keywords

Use a deterministic event log.

Every important state change should emit an event:
- CardPlayed
- AttackDeclared
- DamageDealt
- UnitDied
- SpiritDispersed
- ShrineDamaged
- ShrineBroken
- CardForgotten
- TacticPrepared
- PreparedTacticTriggered
- PreparedTacticExpired
- UnitEvolved
- AncestorAwakened
- MemoryGained
- MemorySpent
- OfferingSpent
- CardRetained
- CardDiscarded
- DeckReshuffled

Use a DeedTracker / TurnHistory to track facts for current turn:
- Unit damaged a Shrine this turn
- Unit destroyed an enemy this turn
- Unit broke a Shrine this turn
- Player attacked a Shrine this turn
- Spirit Dispersed this turn
- Shrine restored this turn
- Player skipped Shrine attacks this turn

Evolution and Ancestor conditions should query DeedTracker / TurnHistory.

For v0, a full Command -> Intent -> Action -> Event architecture is optional. But resolution must be synchronous and deterministic, and Prepared Tactics/passives must be applied before damage commits.

No async pub-sub event bus.

============================================================
CORE RULES
============================================================

Implement the rules from docs/RULES_V0.md.

Important current rules:
- 3 named Shrines per player.
- 10 Vitality each.
- Shrine damage persists.
- Destroy all 3 enemy Shrines to win.
- Offerings increase by 1 each turn, cap 8, refresh each turn.
- Memory persists until spent.
- Start hand 5.
- End turn: retain up to 1 card, discard the rest.
- Start turn: draw until hand has 5.
- Empty deck: shuffle discard into deck. Forgotten cards do not return.
- Turn structure:
  Ready -> Resource -> Draw -> Main 1 -> Combat -> Main 2 -> End
- Phase contains 4 player-turns.
- Phase 1 order: Red -> Iron -> Red -> Iron.
- Phase 2 order: Iron -> Red -> Iron -> Red.
- Continue reversing each phase.
- Max 2 attacks per combat.
- Each attack resolves separately:
  Attack -> Defend -> Resolve
- No live reactions.
- Prepared Tactics auto-trigger.
- Prepared Tactics last until end of opponent's next turn.
- Max 1 Prepared Tactic per player.
- Fade cards go to Forgotten instead of discard.
- Forgotten cards are excluded from reshuffle.

============================================================
KEYWORDS / STATES
============================================================

Implement:

1. Disperse
When a Spirit would die, remove it from battlefield, gain 1 Memory, then put it into discard unless the card says otherwise.

2. Possession
A Possession is a Spirit attached to a Being.
A Being can have only 1 Possession.
If a second Possession attaches, the old Possession Disperses.
If the host dies, the Possession Disperses.

3. Prepared Tactic
During Main 1 or Main 2, pay the cost and place a Tactic face-down.
Max 1 active Prepared Tactic per player.
When its trigger happens, it reveals and resolves automatically.
If it does not trigger by the end of the opponent’s next turn, discard it or Forgotten if it has Fade.

4. Pierce
When this unit attacks a Shrine and is blocked, if it deals fatal combat damage to the blocker, excess damage is dealt to the original Shrine target.

5. Wounded
If a Being or Spirit takes non-fatal damage, it becomes Wounded.
A Wounded unit deals 25% less combat damage.
Wounded damage = floor(Attack * 0.75), minimum 1.
Wounded clears at the end of that unit controller’s next turn.

6. Guard
Enemy attacks must target a Guard Being before attacking Shrines, if able.

7. Ambush
This unit may attack enemy units the turn it enters.
Ambush does not allow attacking Shrines the turn it enters unless stated.

8. Recall
Allows an evolution card to be played/evolved from discard by paying extra Memory.

9. Evolve
Evolution cards can be played normally for full cost.
Or, if the player controls a matching lower form and the evolve condition is met, play the card over that Being for its Evolve cost.
When evolving:
- replace old card with new card
- move Relics and Possessions to the evolved card
- move damage unless card says otherwise
- old card goes to discard

10. Fade
After this card resolves, move it to the Forgotten zone instead of discard.
If a Prepared Tactic with Fade expires without triggering, move it to Forgotten instead of discard.
Forgotten cards do not return when discard is shuffled into deck.
Forgotten zone is public/reportable.

11. WeaponMaster
This unit has Pierce while it has a Relic attached.

12. SoulSlayer
This unit has Pierce while it has a Possession attached.

============================================================
DECKS AND CARDS
============================================================

Implement hardcoded Red Baobab and Iron Hyena decks from docs/CARDS_V0.md.

Do not build a card loader for v0.

============================================================
BOTS
============================================================

Implement at least:

1. RandomLegalBot
- Chooses random legal actions.
- Used for smoke tests.

2. RedBaobabBot
Priorities:
- Generate Memory.
- Play early Hunters and Spirits.
- Use Possession on Hunters when it can win combat or push Shrine damage.
- Awaken First Hunter when possible.
- Hard-play Leopard Hunter if evolution is stalled.
- Evolve into Leopard Hunter if legal.
- Evolve into Kuma if legal and useful.
- Prepare Root-Woven Guard when Shrines are threatened.
- Attack Shrines when it enables L3 or can break a Shrine.
- Otherwise control board.

3. IronHyenaBot
Priorities:
- Attack Shrines aggressively.
- Use Bite the Roots on damaged or important Shrines.
- Prefer breaking Hunter’s Root-Stone or Shrine of the Red Baobab.
- Use Iron Snare when Red has a big attacker or Possessed unit.
- Use False Opening if Red is close to evolving.
- Use Bone Spear/Pierce to push damage through blockers.
- Awaken Ancestor of the Iron Hyena when possible.
- Block to prevent L3 condition when possible.

Bots can be simple heuristics. They do not need to be smart. They must choose legal actions and be deterministic under seed.

============================================================
REPORTING
============================================================

Implement:

Single game:
```bash
dotnet run --project MythicDuel.Sim -- --mode single --seed 123 --out ./reports
```

Batch:
```bash
dotnet run --project MythicDuel.Sim -- --mode batch --games 100 --seed 123 --out ./reports
```

CLI args:
- --mode single|batch
- --games N
- --seed N
- --out PATH
- --bot-red random|red
- --bot-iron random|iron

Defaults:
- mode single
- games 1
- seed 123
- out ./reports
- bot-red red
- bot-iron iron

Output files:

Single:
- reports/game-123.md
- reports/game-123.json

Batch:
- reports/batch-summary.csv
- reports/batch-summary.json
- reports/sample-games/*.md

In batch mode, generate detailed markdown for selected interesting games:
- closest game
- fastest win
- longest game
- game where L3 appeared
- game where L3 appeared but lost

Detailed markdown must follow docs/REPORT_FORMAT_V0.md.

Aggregate metrics must follow docs/METRICS_V0.md.

============================================================
TESTS
============================================================

Implement unit tests for:

1. Shrine damage is persistent.
2. Being/Spirit damage clears at end of turn.
3. Wounded applies when non-fatal damage is dealt.
4. Wounded reduces combat damage by floor(attack * 0.75), minimum 1.
5. Wounded clears at the end of controller’s next turn.
6. Disperse gives Memory.
7. Possession disperses when host dies.
8. Second Possession displaces first and causes Disperse.
9. Pierce overflow hits original Shrine target if blocker dies.
10. Prepared Tactic auto-triggers.
11. Prepared Tactic expires at end of opponent’s next turn.
12. Only 1 Prepared Tactic can be active per player.
13. Fade cards move to Forgotten after resolving.
14. Fade Prepared Tactics move to Forgotten after triggering.
15. Fade Prepared Tactics move to Forgotten after expiring.
16. Forgotten cards are not shuffled back into deck.
17. WeaponMaster grants Pierce while a Relic is attached.
18. SoulSlayer grants Pierce while a Possession is attached.
19. Leopard Hunter with Relic or Possession applies Pierce.
20. Leopard Hunter without Relic/Possession does not apply Pierce unless another effect grants it.
21. Evolution replaces old card and moves Relics/Possessions.
22. Recall evolution from discard charges extra Memory.
23. Only one Ancestor can be Awakened at a time.
24. Phase order reverses every 4 player-turns.
25. Draw model: retain up to 1, discard rest, draw to 5.
26. Empty deck shuffles discard into deck and excludes Forgotten cards.

Smoke/integration test:
- Run RedBaobabBot vs IronHyenaBot with fixed seed.
- Assert game finishes or times out without exceptions.
- Assert metrics are produced.

============================================================
ACCEPTANCE CRITERIA
============================================================

Do not stop until all are true:

1. `dotnet build` succeeds.
2. `dotnet test` succeeds.
3. Single sim runs:
   `dotnet run --project MythicDuel.Sim -- --mode single --seed 123 --out ./reports`
4. Batch sim runs:
   `dotnet run --project MythicDuel.Sim -- --mode batch --games 20 --seed 123 --out ./reports`
5. Reports are generated:
   - detailed markdown game report
   - JSON game report
   - batch-summary.csv
   - batch-summary.json
6. Reports include:
   - turn-by-turn hands
   - resources
   - Shrine damage
   - Wounded events
   - Pierce events
   - Prepared Tactic events
   - Fade/Forgotten events
   - evolution events
   - phase summaries
   - end-of-game summary
7. Determinism:
   Running same command twice with same seed gives same winner, turn count, and core metrics.
8. README.md exists with:
   - project purpose
   - commands
   - rules implemented
   - known v0 limitations
9. No TODO stubs for core behavior.

============================================================
IMPLEMENTATION ORDER
============================================================

1. Create solution/projects.
2. Implement core state models.
3. Implement hardcoded cards/decks.
4. Implement deterministic RNG.
5. Implement turn loop and phase reversal.
6. Implement draw/retain/discard/reshuffle/Forgotten.
7. Implement resources.
8. Implement combat basics.
9. Implement Wounded and Pierce.
10. Implement Disperse and Possession.
11. Implement Prepared Tactics.
12. Implement Fade.
13. Implement Ancestors.
14. Implement Evolution and Recall.
15. Implement bots.
16. Implement metrics.
17. Implement markdown/json/csv reports.
18. Implement tests.
19. Add README.
20. Run build/test/sample commands.
21. Fix until green.

Remember: v0 should be ugly but truthful. Do not over-architect.
