# Mythic Duel — v0 Architecture Notes

## Principle

```text
Ugly but truthful.
```

The simulator should answer design questions:
- Is Red Memory too high?
- Does Iron break Shrines too fast?
- Does Wounded stall combat?
- Does Pierce solve blockers?
- Does Fade stop toxic reshuffle loops?
- Does Leopard Hunter reach Kuma too often or too rarely?
- Does phase reversal dominate outcomes?

## Minimal model

Use:

```text
GameState
PlayerState
CardDefinition
CardInstance
ShrineState
AncestorState
GameEngine
CombatResolver
Bot
MetricsCollector
Reporter
```

## Avoid

```text
deep card inheritance
generic ECS framework
scripting language
JSON card loader
web UI
database
async pub-sub
complex middleware
universal TCG abstraction
```

## Good enough resolution model

For v0, direct methods are okay:

```text
ResolveTurn()
ResolveMainPhase()
ResolveCombat()
ResolveAttack()
ApplyDamage()
HandleDeathOrDisperse()
HandlePreparedTactics()
HandleFade()
HandleEvolution()
```

But emit events:

```text
EventLog.Add(new DamageDealtEvent(...))
```

Use events for:
- reports
- metrics
- DeedTracker
- debugging

## Determinism

Every game must be reproducible from:
- seed
- bot choices
- decklists
- rules

No nondeterministic ordering.

## Reports drive the design

If a rule is implemented but not visible in reports, it is hard to evaluate.
