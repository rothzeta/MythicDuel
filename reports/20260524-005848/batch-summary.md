# Batch Summary

Games: 100
Seeds: 123-222
Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 100 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red red --bot-iron iron --deck-red red-hunter-evolution --deck-iron iron-snarecraft-control
Bots: Red=RedBaobabBot, Iron=IronHyenaBot
Wins: Red=68, Iron=32
Timeouts: 0
Average turns: 25.17
Sample games: 191, 134, 150, 162, 216

WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.
- HardCastChosenWhileLegalEvolveActionExistsRed = 61
- HardCastChosenWhileLegalEvolveActionExistsIron = 25
WARNING: Hard-cast evolution cards were chosen while an evolution base existed.
- HardCastChosenWhileEvolutionBaseExistsRed = 499
- HardCastChosenWhileEvolutionBaseExistsIron = 95
WARNING: Game exceeded 40 turns.

## Sample-game digest

### Game 191 — fastest Red win
Tags: fastest Red win
Winner: red-hunter-evolution by shrine break
Turns: 11
Seed: 191
Timeout: no
Shrines broken: Red 1, Iron 3
First Shrine damage: 4
First Shrine break: 7
First L2: 5
First L3: None
Layer entries: Red L2 1 (hard-cast 1, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 1 (hard-cast 0, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 2
Evolve actions chosen: Red 0, Iron 2
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 3 / Iron 0
Awakening flow: legal Red 2, Iron 0; chosen Red 1, Iron 0; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 3 turns, Iron None / 0 turns
Ancestor value: First Hunter +7, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 6, Iron 1
Blocks: Red 0/0 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 2; generated slots Red 0, Iron 2; skipped slots Red 0, Iron 1; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 0
Memory end: Red 0, Iron 1
Final battlefield: Red [Young Hunter, River Hunter, Spear of First Dawn, Young Hunter, River Hunter, Leopard Hunter] | Iron [None]
Key issue: Red converted shrine pressure before Iron could race back
Observed loop: Red found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 134 — fastest Iron win
Tags: fastest Iron win
Winner: iron-snarecraft-control by shrine break
Turns: 15
Seed: 134
Timeout: no
Shrines broken: Red 3, Iron 0
First Shrine damage: 4
First Shrine break: 5
First L2: 5
First L3: None
Layer entries: Red L2 2 (hard-cast 2, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 2 (hard-cast 0, evolved 2), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 6
Evolve actions chosen: Red 0, Iron 5
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 8 / Iron 0
Awakening flow: legal Red 12, Iron 4; chosen Red 5, Iron 3; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 4 turns, Iron iron.ancestor.hyena / 5 turns
Ancestor value: First Hunter +1, Grandmother healed 1, Child triggers 0, Iron Hyena +3, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 1, Iron 8
Blocks: Red 3/3 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 8; generated slots Red 0, Iron 8; skipped slots Red 0, Iron 2; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 1, Iron 1
Final battlefield: Red [Pale River Spirit, River Hunter, Leopard Hunter] | Iron [Bone Spear]
Key issue: Iron closed shrine pressure before Red could stabilize
Observed loop: Iron found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 150 — highest Pierce game
Tags: longest game; highest reshuffle game; highest Pierce game
Winner: red-hunter-evolution by shrine break
Turns: 43
Seed: 150
Timeout: no
Shrines broken: Red 0, Iron 3
First Shrine damage: 3
First Shrine break: 17
First L2: 11
First L3: 35
Layer entries: Red L2 8 (hard-cast 4, evolved 4), Red L3 1 (hard-cast 0, evolved 1); Iron L2 3 (hard-cast 3, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 18, Iron 0
Evolve actions chosen: Red 16, Iron 0
Hard-cast bypass: legal-window Red 2 / Iron 0; base-exists Red 5 / Iron 4
Awakening flow: legal Red 42, Iron 0; chosen Red 15, Iron 0; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 17 turns, Iron None / 0 turns
Ancestor value: First Hunter +5, Grandmother healed 1, Child triggers 2, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 8, Iron 11
Blocks: Red 11/12 chosen, Iron 1/1 chosen
Pack pressure: ready units Red 0, Iron 16; generated slots Red 0, Iron 16; skipped slots Red 0, Iron 2; prevented by limit Red 0, Iron 1
Pierce signal: overflow Red 1, Iron 0; WeaponMaster 0; SoulSlayer 1; LeopardHunter 1
Reshuffles: Red 4, Iron 3
Memory end: Red 6, Iron 2
Final battlefield: Red [Spear of First Dawn, Young Hunter, Esprit du Léopard, Leopard Hunter, Spear of First Dawn] | Iron [Bone Spear, Bone Spear, Iron Hyena Raider, Iron Hyena Champion]
Key issue: Pierce damage produced the strongest blocked-attack spillover in the batch
Observed loop: both decks keep recycling through retain-1 turns while shrine damage advances slowly
Design meaning: Pierce is materially shaping blocked Shrine races instead of being cosmetic
Next action: check whether shrine pressure heuristics or loop warnings need to be tightened

### Game 162 — closest game
Tags: closest game
Winner: iron-snarecraft-control by shrine break
Turns: 42
Seed: 162
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 5
First Shrine break: 13
First L2: 9
First L3: 38
Layer entries: Red L2 5 (hard-cast 1, evolved 4), Red L3 1 (hard-cast 0, evolved 1); Iron L2 3 (hard-cast 2, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 10, Iron 2
Evolve actions chosen: Red 10, Iron 2
Hard-cast bypass: legal-window Red 2 / Iron 0; base-exists Red 4 / Iron 2
Awakening flow: legal Red 40, Iron 8; chosen Red 14, Iron 6; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 17 turns, Iron iron.ancestor.smith / 14 turns
Ancestor value: First Hunter +5, Grandmother healed 3, Child triggers 0, Iron Hyena +3, Smith saved 7, Tooth-Mother +0
Shrine attacks: Red 7, Iron 15
Blocks: Red 7/11 chosen, Iron 1/1 chosen
Pack pressure: ready units Red 0, Iron 14; generated slots Red 0, Iron 14; skipped slots Red 0, Iron 3; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 4, Iron 3
Memory end: Red 5, Iron 2
Final battlefield: Red [Spear of First Dawn, Young Hunter, Pale River Spirit, Deep River Spirit, River Hunter, Young Hunter, Esprit du Léopard] | Iron [Bone-Cracker Cub, Bone Spear, Rust Hyena Spirit]
Key issue: the shrine race stayed narrow deep into the game
Observed loop: both players stayed in the shrine race until the final momentum swing
Design meaning: the current bots can produce a genuinely contested shrine race instead of a one-sided roll
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 216 — first L3 game
Tags: first L3 game
Winner: red-hunter-evolution by shrine break
Turns: 17
Seed: 216
Timeout: no
Shrines broken: Red 0, Iron 3
First Shrine damage: 3
First Shrine break: 9
First L2: 9
First L3: 14
Layer entries: Red L2 1 (hard-cast 1, evolved 0), Red L3 1 (hard-cast 0, evolved 1); Iron L2 1 (hard-cast 1, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 2, Iron 0
Evolve actions chosen: Red 2, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 2 / Iron 0
Awakening flow: legal Red 2, Iron 0; chosen Red 1, Iron 0; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 5 turns, Iron None / 0 turns
Ancestor value: First Hunter +6, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 6, Iron 4
Blocks: Red 4/5 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 2; generated slots Red 0, Iron 2; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 1, Iron 1
Final battlefield: Red [Kuma Who Wounded the Sun, River Hunter, River Hunter, Spear of First Dawn, Young Hunter, Spear of First Dawn] | Iron [None]
Key issue: the batch reached L3 here earlier than anywhere else
Observed loop: an L2 path opened, then converted into the earliest L3 spike in the batch
Design meaning: the full evolution ladder is reachable and worth surfacing in batch diagnostics
Next action: use this sample to verify that L2-to-L3 sequencing matches the intended deed model
