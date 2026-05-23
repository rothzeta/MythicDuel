# Copilot instructions — Mythic Duel v0

This repository contains a .NET headless simulation engine for the Mythic Duel card game prototype.

## Project priority

The v0 simulator is a **rules microscope**, not a product.

Priorities:

```text
1. Deterministic game simulation.
2. Correct current rules.
3. Useful reports.
4. Simple bots.
5. Batch metrics.
6. Tests.
```

Do **not** build a universal TCG framework.

## Architecture guidance

Use simple, explicit C# code.

Prefer:

```text
simple records/classes
explicit fields
explicit rule methods
deterministic RNG
event logs
hardcoded cards/decks
clear reports
tests for rules
```

Avoid:

```text
deep card inheritance
generic scripting systems
reflection magic
async pub-sub event buses
database
UI
web API
premature ECS framework
```

Do not model cards as:

```csharp
class Being : Card
class Spirit : Card
class Hunter : Being
class LeopardHunter : Hunter
```

Instead use simple data:

```text
CardDefinition
CardInstance
Tags
Keywords
AttachedRelicId
AttachedPossessionId
IsWounded
Zone
```

## Resolution model

For v0, a full command/intent/action/event framework is **not required**, but the spirit should be preserved:

```text
validate command
create/log intent if useful
resolve state change synchronously
emit deterministic event
update DeedTracker and metrics
```

All resolution must be synchronous and deterministic.

## Required current patches

The simulator must include:

```text
Fade
Forgotten zone
Prepared Tactics
Pierce
Wounded
WeaponMaster
SoulSlayer
Disperse
Possession
Evolution
Recall
Phase reversal
Draw-to-5 retain-1 model
```

## Completion rule

Before finishing:

```bash
dotnet build
dotnet test
dotnet run --project MythicDuel.Sim -- --mode single --seed 123 --out ./reports
dotnet run --project MythicDuel.Sim -- --mode batch --games 20 --seed 123 --out ./reports
```

Fix errors until green.

Do not leave TODO stubs for core behavior.
