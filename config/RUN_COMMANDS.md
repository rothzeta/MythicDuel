# Mythic Duel — v0 Run Commands

## Build

```bash
dotnet build
```

## Test

```bash
dotnet test
```

## Run one game

```bash
dotnet run --project MythicDuel.Sim -- --mode single --seed 123 --deck-red red-hunter-evolution --deck-iron iron-hyena-aggro --out ./reports
```

## Run a batch

```bash
dotnet run --project MythicDuel.Sim -- --mode batch --games 100 --seed 123 --deck-red red-hunter-evolution --deck-iron iron-hyena-aggro --out ./reports
```

## Export catalog JSON

```bash
dotnet run --project MythicDuel.Sim -- --mode catalog --out ./reports --catalog-file catalog.json
```

## Run with random bots

```bash
dotnet run --project MythicDuel.Sim -- --mode single --seed 123 --bot-red random --bot-iron random --deck-red red-hunter-evolution --deck-iron iron-hyena-aggro --out ./reports
```

## Expected output

Single mode:

```text
reports/game-123.md
reports/game-123.json
```

Batch mode:

```text
reports/batch-summary.csv
reports/batch-summary.json
reports/sample-games/*.md
```

Catalog mode:

```text
reports/catalog.json
```

## Determinism check

```bash
dotnet run --project MythicDuel.Sim -- --mode single --seed 123 --deck-red red-hunter-evolution --deck-iron iron-hyena-aggro --out ./reports/run1
dotnet run --project MythicDuel.Sim -- --mode single --seed 123 --deck-red red-hunter-evolution --deck-iron iron-hyena-aggro --out ./reports/run2
```

Winner, turn count, phase count, and core metrics should match.
