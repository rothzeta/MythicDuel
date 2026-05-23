# Proposed Project Structure

## Initial structure

Start with:

```text
MythicDuel.slnx

src/
  MythicDuel.Core/
  MythicDuel.Content/
  MythicDuel.Sim/

tests/
  MythicDuel.Core.Tests/
  MythicDuel.Content.Tests/
  MythicDuel.Sim.Tests/
```

## Later structure

Add these only when needed:

```text
src/
  MythicDuel.App/
  MythicDuel.UI.Godot/
  MythicDuel.UI.Web/
  MythicDuel.Server/
  MythicDuel.Persistence/
```

## MythicDuel.Core

No UI. No database. No file system dependency.

```text
MythicDuel.Core/
  Game/
    GameEngine.cs
    GameState.cs
    PlayerState.cs
    CardInstance.cs
    GameOutcome.cs

  Ids/
    PlayerId.cs
    CardInstanceId.cs
    CardDefinitionId.cs
    DeckId.cs
    FactionId.cs

  Commands/
    IGameCommand.cs
    PlayCardCommand.cs
    DeclareAttackCommand.cs
    DeclareBlockCommand.cs
    EndTurnCommand.cs
    EvolveCommand.cs

  LegalActions/
    LegalAction.cs
    LegalActionGenerator.cs
    PlayCardAction.cs
    AttackAction.cs
    EvolveAction.cs

  Events/
    GameEvent.cs
    CardPlayedEvent.cs
    AttackDeclaredEvent.cs
    DamageDealtEvent.cs
    CardMovedEvent.cs
    GameEndedEvent.cs

  Views/
    GameView.cs
    CardView.cs
    HiddenCardView.cs
    ViewBuilder.cs

  Pipeline/
    ResolutionPipeline.cs
    ResolutionContext.cs
    CommandResult.cs
    ValidationResult.cs

  Rules/
    RuleIndex.cs
    RuleIndexBuilder.cs

    Turn/
      TurnSystem.cs
      DrawSystem.cs

    Resources/
      ResourceSystem.cs
      OfferingSystem.cs
      MemorySystem.cs

    Zones/
      ZoneSystem.cs
      CardMovement.cs

    Combat/
      CombatSystem.cs
      AttackValidator.cs
      BlockValidator.cs
      PackSystem.cs

    Damage/
      DamageSystem.cs
      DeathSystem.cs
      PierceRule.cs

    Evolution/
      EvolutionSystem.cs
      EvolutionValidator.cs

    PreparedTactics/
      PreparedTacticSystem.cs

    Ancestors/
      AncestorSystem.cs

    Modifiers/
      ModifierSystem.cs
      IModifier.cs
      IModifierProvider.cs

    Replacement/
      ReplacementSystem.cs
      IReplacementEffect.cs

    Triggers/
      TriggerSystem.cs
      ITrigger.cs

    WinConditions/
      WinConditionSystem.cs
      TimeoutSystem.cs

  Random/
    IDeterministicRandom.cs
    XorShiftRandom.cs
```

## MythicDuel.Content

Owns data loading and validation.

```text
MythicDuel.Content/
  Catalog/
    CardCatalog.cs
    DeckCatalog.cs
    FactionCatalog.cs
    CatalogCompiler.cs
    CatalogValidator.cs

  Specs/
    CardDefinitionSpec.cs
    DeckDefinitionSpec.cs
    KeywordSpec.cs
    EffectSpec.cs
    ShrineDefinitionSpec.cs
    AncestorDefinitionSpec.cs

  Registries/
    KeywordRegistry.cs
    EffectRegistry.cs
    ConditionRegistry.cs

  BuiltIn/
    cards.red.json
    cards.iron.json
    decks.red.json
    decks.iron.json
    shrines.json
    ancestors.json
```

## MythicDuel.Sim

Owns bots, batch runner, reports.

```text
MythicDuel.Sim/
  Bots/
    IGameBot.cs
    RandomLegalBot.cs
    GreedyBot.cs
    ScriptedTestBot.cs

  Runner/
    SingleGameRunner.cs
    BatchRunner.cs
    ReplayRunner.cs

  Reports/
    MetricCollector.cs
    GameReport.cs
    BatchReport.cs
    MarkdownReportWriter.cs
    CsvReportWriter.cs
    JsonReportWriter.cs

  Cli/
    Program.cs
    HumanVsBotCli.cs
```

## MythicDuel.App

Add later.

```text
MythicDuel.App/
  BattleService.cs
  RunService.cs
  PlayerProfileService.cs
  RewardService.cs
  SaveLoadService.cs
```

## MythicDuel.UI

Add later.

```text
MythicDuel.UI.Godot/
  adapters to GameView/LegalActions
  visual card rendering
  animation
  input mapping
```

UI calls App/Core. UI does not own rules.
