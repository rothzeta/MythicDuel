# Batch Summary

Games: 100
Seeds: 123-222
Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 100 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red red --bot-iron iron --deck-red red --deck-iron iron
Bots: Red=RedBaobabBot, Iron=IronHyenaBot
Wins: Red=78, Iron=22
Timeouts: 0
Average turns: 26.12
Sample games: 176, 151, 211, 215, 141

WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.
- HardCastChosenWhileLegalEvolveActionExistsRed = 49
- HardCastChosenWhileLegalEvolveActionExistsIron = 16
WARNING: Hard-cast evolution cards were chosen while an evolution base existed.
- HardCastChosenWhileEvolutionBaseExistsRed = 506
- HardCastChosenWhileEvolutionBaseExistsIron = 126
WARNING: Game exceeded 40 turns.

## Sample-game digest

### Game 176 — fastest Red win
Tags: fastest Red win
Winner: red by shrine break
Turns: 16
Seed: 176
Timeout: no
Shrines broken: Red 1, Iron 3
First Shrine damage: 5
First Shrine break: 9
First L2: 9
First L3: None
Layer entries: Red L2 2 (hard-cast 2, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 1 (hard-cast 1, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 0
Evolve actions chosen: Red 0, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 6 / Iron 1
Awakening flow: legal Red 3, Iron 2; chosen Red 2, Iron 1; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 5 turns, Iron iron.ancestor.toothmother / 1 turns
Ancestor value: First Hunter +10, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +1
Shrine attacks: Red 8, Iron 5
Blocks: Red 4/7 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 3; generated slots Red 0, Iron 3; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 2, Iron 0
Final battlefield: Red [Leopard Hunter, River Hunter, Leopard Hunter, Young Hunter, Esprit du Léopard] | Iron [Bone Spear, Bone-Cracker Cub, Iron Hyena Champion]
Key issue: Red converted shrine pressure before Iron could race back
Observed loop: Red found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 151 — fastest Iron win
Tags: fastest Iron win
Winner: iron by shrine break
Turns: 15
Seed: 151
Timeout: no
Shrines broken: Red 3, Iron 0
First Shrine damage: 3
First Shrine break: 12
First L2: 15
First L3: None
Layer entries: Red L2 0 (hard-cast 0, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 1 (hard-cast 0, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 4
Evolve actions chosen: Red 0, Iron 2
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 0
Awakening flow: legal Red 7, Iron 3; chosen Red 3, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 2 turns, Iron iron.ancestor.hyena / 2 turns
Ancestor value: First Hunter +0, Grandmother healed 1, Child triggers 0, Iron Hyena +2, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 1, Iron 7
Blocks: Red 0/0 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 8; generated slots Red 0, Iron 8; skipped slots Red 0, Iron 2; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 0, Iron 2
Final battlefield: Red [River Hunter, Pale River Spirit] | Iron [Bone-Cracker Cub, Fang Relic, Iron Hyena Raider, Black-Tooth Smith, Iron Hyena Champion]
Key issue: Iron closed shrine pressure before Red could stabilize
Observed loop: Iron found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 211 — highest reshuffle game
Tags: longest game; closest game; highest reshuffle game
Winner: red by shrine break
Turns: 54
Seed: 211
Timeout: no
Shrines broken: Red 2, Iron 3
First Shrine damage: 3
First Shrine break: 21
First L2: 11
First L3: None
Layer entries: Red L2 9 (hard-cast 3, evolved 6), Red L3 0 (hard-cast 0, evolved 0); Iron L2 4 (hard-cast 3, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 20, Iron 8
Evolve actions chosen: Red 20, Iron 4
Hard-cast bypass: legal-window Red 5 / Iron 0; base-exists Red 3 / Iron 4
Awakening flow: legal Red 64, Iron 3; chosen Red 21, Iron 3; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 23 turns, Iron iron.ancestor.hyena / 15 turns
Ancestor value: First Hunter +2, Grandmother healed 8, Child triggers 0, Iron Hyena +2, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 7, Iron 19
Blocks: Red 11/11 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 25; generated slots Red 0, Iron 24; skipped slots Red 0, Iron 1; prevented by limit Red 0, Iron 1
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 4, Iron 5
Memory end: Red 9, Iron 1
Final battlefield: Red [River Hunter, Spear of First Dawn] | Iron [Bone Spear, Bone Spear, Rust Hyena Spirit, Black-Tooth Smith, Fang Relic]
Key issue: deck cycling outran closure and created the batch's heaviest reshuffle load
Observed loop: both decks keep recycling through retain-1 turns while shrine damage advances slowly
Design meaning: the retain-1 loop can still create long deterministic grinds when shrine pressure is low
Next action: check whether shrine pressure heuristics or loop warnings need to be tightened

### Game 215 — first L3 game
Tags: first L3 game
Winner: red by shrine break
Turns: 17
Seed: 215
Timeout: no
Shrines broken: Red 1, Iron 3
First Shrine damage: 3
First Shrine break: 9
First L2: 9
First L3: 14
Layer entries: Red L2 2 (hard-cast 2, evolved 0), Red L3 1 (hard-cast 0, evolved 1); Iron L2 1 (hard-cast 1, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 2, Iron 0
Evolve actions chosen: Red 2, Iron 0
Hard-cast bypass: legal-window Red 1 / Iron 1; base-exists Red 7 / Iron 0
Awakening flow: legal Red 7, Iron 0; chosen Red 4, Iron 0; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 5 turns, Iron None / 0 turns
Ancestor value: First Hunter +6, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 7, Iron 2
Blocks: Red 1/1 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 2; generated slots Red 0, Iron 2; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 3, Iron 2
Final battlefield: Red [Kuma Who Wounded the Sun, River Hunter, Young Hunter, Leopard Hunter, Spear of First Dawn] | Iron [Iron Hyena Champion]
Key issue: the batch reached L3 here earlier than anywhere else
Observed loop: an L2 path opened, then converted into the earliest L3 spike in the batch
Design meaning: the full evolution ladder is reachable and worth surfacing in batch diagnostics
Next action: use this sample to verify that L2-to-L3 sequencing matches the intended deed model

### Game 141 — highest Pierce game
Tags: highest Pierce game
Winner: iron by shrine break
Turns: 47
Seed: 141
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 5
First Shrine break: 21
First L2: 11
First L3: 33
Layer entries: Red L2 7 (hard-cast 2, evolved 5), Red L3 1 (hard-cast 0, evolved 1); Iron L2 5 (hard-cast 1, evolved 4), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 22, Iron 12
Evolve actions chosen: Red 18, Iron 12
Hard-cast bypass: legal-window Red 1 / Iron 1; base-exists Red 8 / Iron 0
Awakening flow: legal Red 40, Iron 4; chosen Red 15, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 18 turns, Iron iron.ancestor.toothmother / 8 turns
Ancestor value: First Hunter +9, Grandmother healed 3, Child triggers 1, Iron Hyena +2, Smith saved 0, Tooth-Mother +1
Shrine attacks: Red 9, Iron 13
Blocks: Red 6/7 chosen, Iron 4/8 chosen
Pack pressure: ready units Red 0, Iron 20; generated slots Red 0, Iron 20; skipped slots Red 0, Iron 9; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 2, Iron 0; WeaponMaster 1; SoulSlayer 0; LeopardHunter 1
Reshuffles: Red 4, Iron 4
Memory end: Red 3, Iron 0
Final battlefield: Red [Young Hunter, River Hunter, Leopard Hunter] | Iron [Fang Relic, Bone Spear, Black-Tooth Smith, Rust Hyena Spirit, Iron Hyena Champion]
Key issue: Pierce damage produced the strongest blocked-attack spillover in the batch
Observed loop: blocked Shrine attacks still leak damage through Pierce and accelerate the finish
Design meaning: Pierce is materially shaping blocked Shrine races instead of being cosmetic
Next action: review whether Pierce pressure is landing in the intended range for blocked Shrine attacks
