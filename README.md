# Mythic Duel v0 Simulator

This repository contains a headless, deterministic .NET 10 simulator for the Mythic Duel v0 ruleset.

## Purpose

The simulator is intentionally narrow:

```text
Run deterministic seat-vs-seat deck simulations.
Generate deterministic reports.
Expose whether the current rules are broken.
```

It is a rules microscope, not a product engine.

## Solution structure

```text
MythicDuel.Core   - explicit domain models, cards, rules, bots, metrics
MythicDuel.Sim    - console runner and report generation
MythicDuel.Tests  - rule and smoke tests
MythicDuel.slnx   - root solution
```

## Commands

Build:

```powershell
dotnet build .\MythicDuel.slnx
```

Test:

```powershell
dotnet test .\MythicDuel.slnx
```

Single game:

```powershell
dotnet run --project MythicDuel.Sim -- --mode single --seed 123 --deck-red red-hunter-evolution --deck-iron iron-hyena-aggro --out ./reports
```

Batch run:

```powershell
dotnet run --project MythicDuel.Sim -- --mode batch --games 20 --seed 123 --deck-red red-hunter-evolution --deck-iron iron-hyena-aggro --out ./reports
```

Catalog export:

```powershell
dotnet run --project MythicDuel.Sim -- --mode catalog --out ./reports --catalog-file catalog.json
```

Optional bot overrides:

```powershell
dotnet run --project MythicDuel.Sim -- --mode single --seed 123 --bot-red random --bot-iron iron --deck-red red-hunter-evolution --deck-iron iron-hyena-aggro --out ./reports
```

## CLI options

```text
--mode single|batch|catalog default: single
--games N             default: 1
--seed N              default: 123
--out PATH            default: ./reports
--bot-red random|red  default: red
--bot-iron random|iron default: iron
--deck-red NAME       default: red
--deck-iron NAME      default: iron
--catalog-file NAME   default: catalog.json
```

## Rules implemented in v0

The simulator includes explicit support for the documented v0 mechanics, including:

```text
3 named Shrines per player with persistent Shrine damage
Draw to 5 / retain 1 / discard the rest
Discard reshuffle with Forgotten exclusion
Phase reversal every 4 player-turns
Offerings ramp and refresh
Persistent Memory
Combat with 2 Standard Assault slots plus Pack Assault slots for ready Pack Beings, up to 5 total attacks
5 Presence per seat with card-defined Presence costs
Guard blocking for Shrine attacks
Wounded
Pierce
Disperse
Possession
Prepared Tactics
Fade and Forgotten zone
Ancestors
Evolution
Unique
Pack
Deterministic event logging and metrics
Seat/deck/faction-aware deck loading and reporting
```

## Reports generated

Single mode writes:

```text
reports/game-<seed>.md
reports/game-<seed>.json
```

Batch mode writes:

```text
reports/batch-summary.csv
reports/batch-summary.json
reports/sample-games/*.md
reports/sample-games/*.json
```

Catalog mode writes:

```text
reports/catalog.json
```

Reports include pre-resource turn snapshots, hand/resource summaries, phase summaries reconstructed from completed turn snapshots, Presence and Assault usage, Shrine state, Wounded and Pierce notes, Prepared Tactic activity, Forgotten/Fade activity, and end-of-game metrics.
Catalog export includes keywords, cards, shrines, ancestors, decks, shrine packages, ancestor packages, seat/faction-ready deck metadata, and registered bots.

## Known v0 limitations

```text
Bots are heuristic and intentionally simple.
Rule targeting is hardcoded for this matchup, not generic.
Some card decisions use deterministic heuristics instead of full choice UIs.
The engine is explicit and purpose-built, not a reusable TCG framework.
The current test suite is a smoke-focused baseline, not exhaustive coverage of every documented interaction.
```

## Design constraints

This project intentionally avoids:

```text
universal TCG framework design
JSON card scripting
web UI
database
generic ECS or event bus abstractions
deep card inheritance trees
```

Core v0 principle:

```text
First simulator: ugly but truthful.
```
