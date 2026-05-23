# 07 — Simulation Metrics and Reports

## Goal

Metrics should reveal design and engine problems without being tied to Red/Iron hardcoding.

Use seat/deck/faction/card/keyword based metrics.

## Metric dimensions

Every report row should include:

```text
run id
seed
engine version
rules version
catalog version
seat1 deck id
seat2 deck id
seat1 faction id
seat2 faction id
bot1 id
bot2 id
winner
outcome type
turn count
timeout flag
```

## Avoid Red/Iron-specific metrics

Bad:

```text
RedL3Evolved
IronL3Evolved
RedPackAttacks
IronPackAttacks
```

Good:

```text
Seat1L3Evolved
Seat2L3Evolved
Seat1PackAttacks
Seat2PackAttacks
```

Better for aggregation:

```text
EvolutionsBySeat
EvolutionsByDeck
EvolutionsByCard
KeywordUsageBySeat
KeywordUsageByDeck
```

## Core diagnostic metrics

### Game flow

```text
games played
wins by seat
wins by deck
wins by faction
timeout count
average turns
median turns
turn count distribution
average cards drawn
average cards played
average cards remaining in deck
```

### Evolution

```text
legal L2 evolution windows
legal L3 evolution windows
L2 evolutions chosen
L3 evolutions chosen
hard-cast evolution attempts
hard-cast evolution successes
illegal downward evolution attempts
evolution blocked by cost
evolution blocked by lineage
```

### Mythic

```text
mythic in hand
mythic legal play windows
mythic hard-cast attempts
mythic recall attempts
mythic successfully evolved
mythic duplicate blocked
```

### Combat

```text
attacks declared
blocks available
blocks chosen
blocks declined
damage dealt to Beings
damage dealt to Shrines
shrines broken
units destroyed by combat
Pierce damage applied
Wounded applied
```

### Pack

```text
ready Pack count at attack window
max attacks after Pack
Pack attacks in normal slots
Pack attacks in extra slots
non-Pack extra attack attempts blocked
```

### Prepared Tactics

```text
tactics prepared
prepared tactics revealed
prepared tactics triggered
prepared tactics expired
prepared tactics forgotten by Fade
```

### Fade / Forgotten

```text
Fade cards resolved
Fade replacements applied
cards moved to Forgotten
cards moved to Discard after resolution
```

### Ancestors

```text
ancestor activation windows
ancestor activations chosen
ancestor value events
ancestor prevented/lost value
```

### Presence

```text
presence used
presence limit reached
play blocked by presence
average board occupancy
```

## Report types

### Single-game log

Detailed event trace for one seed.

Useful for debugging.

### Batch summary

Aggregate over many games.

Useful for balance and design.

### Invariant report

List any impossible/illegal occurrences:

```text
L3 hard-cast when forbidden
Mythic recalled
downward evolution
extra non-Pack attack
presence exceeded
hidden card leaked to bot
negative resource
duplicate unique card
```

### Card usage report

Per card:

```text
drawn
played
prepared
evolved into
attacked
blocked
destroyed
damage dealt
cards drawn
shrines damaged
win contribution proxy
```

## Metrics architecture

Do not let metrics mutate gameplay.

Recommended:

```text
EventLog + Diagnostics -> MetricCollector -> Report
```

Metrics consume events after the fact.

## Reproducibility

Every report should include enough data to reproduce a weird game:

```text
engine version
catalog version
rule flags
seed
deck ids
bot ids
command log if available
```

## Batch tests

Batch simulation tests should not assert exact win rates.

They should assert sanity:

```text
timeout rate below threshold
L2 evolves at least once in 100 games
L3 hard-cast count is zero when forbidden
Pack attacks occur when Pack decks play
Prepared Tactics are sometimes revealed
no hidden info leaks
```
