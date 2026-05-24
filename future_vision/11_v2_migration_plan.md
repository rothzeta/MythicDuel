# V2 Engine Incremental Migration Plan

The core skeleton for `MythicDuel.Engine` has been established. To complete the parallel rewrite and achieve parity with the reference simulator, the remaining mechanics must be implemented iteratively.

## Iteration 1: Core Combat & Damage
1. **Understand Reference**: Review `ExecuteCombat`, `ResolveAttack`, and `ApplyDamage` in `MythicDuel.Core/Game/GameEngine.cs`.
2. **Implement V2**:
   - Write real resolution logic inside `MythicDuel.Engine/Rules/CombatSystem.cs` and `DamageSystem.cs`.
   - Implement `AttackValidator` and `BlockValidator`.
3. **Port Tests**: Extract and port combat/damage-specific tests (e.g., standard attack damage, blocked damage, Guard enforcement) to `MythicDuel.Engine.Tests/RulesTests.cs`.
4. **Verify**: Ensure the specific ported tests pass in V2 while reference tests continue to pass.

## Iteration 2: Advanced Mechanics (Evolution & Pack)
1. **Understand Reference**: Review `GetLegalEvolutionActions` and Pack assault logic in `MythicDuel.Core/Game/GameEngine.cs`.
2. **Implement V2**:
   - Write logic in `MythicDuel.Engine/Rules/EvolutionSystem.cs` to handle `EvolveCommand` and enforce L1->L2/L3 rules.
   - Write logic in `MythicDuel.Engine/Rules/PackSystem.cs` to generate and consume extra assault slots.
3. **Port Tests**: Port tests `Legal_evolve_actions_are_counted_when_generation_occurs`, `L3_cannot_evolve_from_l1_host`, `Pack_attack_can_use_extra_assault_slot_beyond_standard_two`, etc.
4. **Verify**: Run tests to ensure identical logic enforcement.

## Iteration 3: Advanced Mechanics (Shrines & Ancestors)
1. **Understand Reference**: Review `ApplyShrineDamage` and `ActivateAncestor` in the reference engine.
2. **Implement V2**:
   - Update `DamageSystem.cs` and create `ShrineSystem.cs` to handle persistent damage and Shrines breaking.
   - Implement `MythicDuel.Engine/Rules/AncestorSystem.cs`.
3. **Port Tests**: Port `Shrine_damage_is_persistent`, `Iron_hyena_ancestor_bonus_damage_is_recorded_when_triggered`.
4. **Verify**: Ensure ported tests pass.

## Iteration 4: Prepared Tactics & Remaining Modifiers
1. **Understand Reference**: Review `PreparedTactic` logic, `Pierce`, `Wounded`, and `Disperse` keywords.
2. **Implement V2**:
   - Implement `MythicDuel.Engine/Rules/PreparedTacticSystem.cs`.
   - Leverage `RuleIndex` to implement `PierceRule.cs` and `Wounded` modifiers.
3. **Port Tests**: Port all remaining tests from `MythicDuel.Tests/RulesTests.cs` (e.g., `Two_prepared_tactics_can_be_active_per_player`).
4. **Verify**: Run the full V2 test suite. 100% of reference test logic must be executing and passing in the new engine.

## Iteration 5: Simulation Parity and Cutover
1. **Telemetry**: Upgrade `SimulationRunner` and `SimulationResult` in `MythicDuel.Engine.Sim` to capture the necessary telemetry required for the batch reports (Win Rate, average turns, etc.).
2. **Batch Verification**: Run `dotnet run --project MythicDuel.Sim -- --mode batch --games 100` and `dotnet run --project MythicDuel.Engine.Sim -- --mode batch --games 100` using the same seeds.
3. **Assert Parity**: Ensure the JSON summary reports from both engines match exactly.
4. **Cutover**: Delete `MythicDuel.Core`, `MythicDuel.Sim`, and `MythicDuel.Tests`. Remove from `MythicDuel.slnx`.
