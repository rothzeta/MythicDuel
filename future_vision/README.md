# Mythic Duel Architecture Dossier

This dossier proposes the architecture for the next version of the card game engine.

The central recommendation is:

> Build a new headless deterministic engine, keep the current simulator as a reference implementation, and make the first vertical slice a crude human-vs-bot playable duel.

The design combines:

1. A deterministic command/resolution pipeline.
2. Data-driven content catalog.
3. Stateless OO flyweight rule modules.
4. Lean runtime `GameState`.
5. Central `RuleIndex` / `HookIndex`.
6. Seat/deck/faction separation.
7. Hidden-information `GameView`.
8. Simulation and metrics built on top of the same engine.

## Contents

- `01_architecture_overview.md` — high-level architecture and boundaries.
- `02_core_game_engine.md` — command pipeline, state, events, rule index.
- `03_content_catalog_and_rule_modules.md` — data-driven cards and C# rule modules.
- `04_systems_architecture.md` — detailed subsystem responsibilities.
- `05_game_state_and_data_model.md` — runtime model, IDs, zones, seats, card instances.
- `06_bots_views_and_hidden_information.md` — bot API, views, prepared tactics, PvP readiness.
- `07_simulation_metrics_and_reports.md` — diagnostics and batch reporting.
- `08_development_plan.md` — detailed roadmap and milestones.
- `09_testing_strategy.md` — unit, scenario, invariant, golden, and simulation tests.
- `10_decision_records.md` — key architectural decisions and rationale.
- `appendix_minimal_csharp_skeleton.md` — illustrative C# skeleton.
- `project_structure.md` — proposed solution/project layout.
