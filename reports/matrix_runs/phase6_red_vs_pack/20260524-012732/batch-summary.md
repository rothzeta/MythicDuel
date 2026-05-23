# Batch Summary

Games: 500
Seeds: 123-622
Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports\matrix_runs\phase6_red_vs_pack --bot-red red --bot-iron iron --deck-red red-hunter-evolution --deck-iron iron-hyena-pack-pressure --rules phase-length-6
Bots: Red=RedBaobabBot, Iron=IronHyenaBot
Wins: Red=177, Iron=323
Timeouts: 0
Average turns: 22.22
Sample games: 207, 160, 270, 512, 482, 128

WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.
- HardCastChosenWhileLegalEvolveActionExistsRed = 149
- HardCastChosenWhileLegalEvolveActionExistsIron = 169
WARNING: Hard-cast evolution cards were chosen while an evolution base existed.
- HardCastChosenWhileEvolutionBaseExistsRed = 1937
- HardCastChosenWhileEvolutionBaseExistsIron = 448
WARNING: Game exceeded 40 turns.
WARNING: Both players made fewer than 10 Shrine attacks by turn 40.

## Sample-game digest

### Game 207 — fastest Red win
Tags: fastest Red win
Winner: red-hunter-evolution by shrine break
Turns: 15
Seed: 207
Timeout: no
Shrines broken: Red 1, Iron 3
First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 5)
First Shrine break: 12 (Seat 1/Red: 14, Seat 2/Iron: 12)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 20, Iron 6
First L2: 10
First L3: None
Layer entries: Red L2 2 (hard-cast 2, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 0 (hard-cast 0, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 0
Evolve actions chosen: Red 0, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 1; base-exists Red 2 / Iron 1
Awakening flow: legal Red 2, Iron 0; chosen Red 1, Iron 0; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 4 turns, Iron None / 0 turns
Ancestor value: First Hunter +5, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 6, Iron 5
Blocks: Red 2/3 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 4; generated slots Red 0, Iron 4; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 0
Memory end: Red 0, Iron 1
Final battlefield: Red [Leopard Hunter, Leopard Hunter, Esprit du Léopard, Young Hunter, Young Hunter] | Iron [Pack Harrier, Black-Tooth Smith, Bone Spear]
Key issue: Red converted shrine pressure before Iron could race back
Observed loop: Red found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 160 — fastest Iron win
Tags: fastest Iron win
Winner: iron-hyena-pack-pressure by shrine break
Turns: 11
Seed: 160
Timeout: no
Shrines broken: Red 3, Iron 0
First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: None)
First Shrine break: 7 (Seat 1/Red: 7, Seat 2/Iron: None)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 0, Iron 8
First L2: 7
First L3: None
Layer entries: Red L2 0 (hard-cast 0, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 1 (hard-cast 0, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 4
Evolve actions chosen: Red 0, Iron 4
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 2 / Iron 0
Awakening flow: legal Red 4, Iron 3; chosen Red 2, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 2 turns, Iron iron.ancestor.firstpack / 3 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 0, Iron 6
Blocks: Red 1/1 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 8; generated slots Red 0, Iron 8; skipped slots Red 0, Iron 3; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 0
Memory end: Red 3, Iron 2
Final battlefield: Red [River Hunter, River Hunter] | Iron [Fang Relic, Iron Hyena Champion, Hyena Token]
Key issue: Iron closed shrine pressure before Red could stabilize
Observed loop: Iron found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 270 — longest game
Tags: longest game; closest game
Winner: iron-hyena-pack-pressure by shrine break
Turns: 45
Seed: 270
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 27)
First Shrine break: 7 (Seat 1/Red: 7, Seat 2/Iron: 34)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 0, Iron 16
First L2: 11
First L3: None
Layer entries: Red L2 6 (hard-cast 3, evolved 3), Red L3 0 (hard-cast 0, evolved 0); Iron L2 5 (hard-cast 1, evolved 4), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 16, Iron 8
Evolve actions chosen: Red 12, Iron 8
Hard-cast bypass: legal-window Red 2 / Iron 1; base-exists Red 2 / Iron 2
Awakening flow: legal Red 40, Iron 22; chosen Red 16, Iron 15; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.grandmother / 18 turns, Iron iron.ancestor.firstpack / 19 turns
Ancestor value: First Hunter +8, Grandmother healed 4, Child triggers 0, Iron Hyena +0, Smith saved 1, Tooth-Mother +0
Shrine attacks: Red 9, Iron 14
Blocks: Red 5/7 chosen, Iron 2/3 chosen
Pack pressure: ready units Red 0, Iron 24; generated slots Red 0, Iron 24; skipped slots Red 0, Iron 5; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 4, Iron 3
Memory end: Red 12, Iron 2
Final battlefield: Red [Spear of First Dawn, Pale River Spirit, Young Hunter] | Iron [Fang Relic, Bone-Cracker Cub, Blood-Scent Hyena, Bone-Cracker Cub]
Key issue: the game stretched unusually long before closing
Observed loop: combat, blocking, and resource generation keep repeating without enough shrine closure
Design meaning: the retain-1 loop can still create long deterministic grinds when shrine pressure is low
Next action: check whether shrine pressure heuristics or loop warnings need to be tightened

### Game 512 — first L3 game
Tags: first L3 game
Winner: red-hunter-evolution by shrine break
Turns: 15
Seed: 512
Timeout: no
Shrines broken: Red 0, Iron 3
First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine break: 5 (Seat 1/Red: None, Seat 2/Iron: 5)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 13, Iron 9
First L2: 10
First L3: 13
Layer entries: Red L2 2 (hard-cast 2, evolved 0), Red L3 1 (hard-cast 0, evolved 1); Iron L2 0 (hard-cast 0, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 2, Iron 0
Evolve actions chosen: Red 2, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 2 / Iron 2
Awakening flow: legal Red 5, Iron 0; chosen Red 2, Iron 0; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 3 turns, Iron None / 0 turns
Ancestor value: First Hunter +4, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 6, Iron 7
Blocks: Red 5/5 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 4; generated slots Red 0, Iron 4; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 0
Memory end: Red 1, Iron 1
Final battlefield: Red [Leopard Hunter, Kuma Who Wounded the Sun, Young Hunter, Pale River Spirit] | Iron [Hyena Token]
Key issue: the batch reached L3 here earlier than anywhere else
Observed loop: an L2 path opened, then converted into the earliest L3 spike in the batch
Design meaning: the full evolution ladder is reachable and worth surfacing in batch diagnostics
Next action: use this sample to verify that L2-to-L3 sequencing matches the intended deed model

### Game 482 — highest reshuffle game
Tags: highest reshuffle game
Winner: red-hunter-evolution by shrine break
Turns: 41
Seed: 482
Timeout: no
Shrines broken: Red 2, Iron 3
First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 5)
First Shrine break: 7 (Seat 1/Red: 7, Seat 2/Iron: 15)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 16, Iron 12
First L2: 11
First L3: 32
Layer entries: Red L2 6 (hard-cast 2, evolved 4), Red L3 1 (hard-cast 0, evolved 1); Iron L2 4 (hard-cast 2, evolved 2), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 14, Iron 6
Evolve actions chosen: Red 13, Iron 6
Hard-cast bypass: legal-window Red 1 / Iron 1; base-exists Red 4 / Iron 3
Awakening flow: legal Red 34, Iron 2; chosen Red 14, Iron 1; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 17 turns, Iron iron.ancestor.firstpack / 15 turns
Ancestor value: First Hunter +3, Grandmother healed 0, Child triggers 4, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 12, Iron 5
Blocks: Red 0/0 chosen, Iron 3/6 chosen
Pack pressure: ready units Red 0, Iron 20; generated slots Red 0, Iron 19; skipped slots Red 0, Iron 4; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 5, Iron 3
Memory end: Red 5, Iron 1
Final battlefield: Red [Spear of First Dawn, Pale River Spirit, Baobab Guardian, Leopard Hunter, River Hunter] | Iron [Bone Spear, Blood-Scent Hyena, Iron Hyena Raider]
Key issue: deck cycling outran closure and created the batch's heaviest reshuffle load
Observed loop: both decks keep recycling through retain-1 turns while shrine damage advances slowly
Design meaning: the retain-1 loop can still create long deterministic grinds when shrine pressure is low
Next action: check whether shrine pressure heuristics or loop warnings need to be tightened

### Game 128 — highest Pierce game
Tags: highest Pierce game
Winner: red-hunter-evolution by shrine break
Turns: 25
Seed: 128
Timeout: no
Shrines broken: Red 2, Iron 3
First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 15)
First Shrine break: 7 (Seat 1/Red: 7, Seat 2/Iron: 17)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 16, Iron 18
First L2: 9
First L3: None
Layer entries: Red L2 4 (hard-cast 2, evolved 2), Red L3 0 (hard-cast 0, evolved 0); Iron L2 3 (hard-cast 0, evolved 3), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 4, Iron 6
Evolve actions chosen: Red 3, Iron 6
Hard-cast bypass: legal-window Red 2 / Iron 0; base-exists Red 6 / Iron 2
Awakening flow: legal Red 4, Iron 5; chosen Red 3, Iron 4; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 9 turns, Iron iron.ancestor.firstpack / 5 turns
Ancestor value: First Hunter +3, Grandmother healed 3, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 6, Iron 13
Blocks: Red 5/6 chosen, Iron 2/4 chosen
Pack pressure: ready units Red 0, Iron 13; generated slots Red 0, Iron 13; skipped slots Red 0, Iron 4; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 2, Iron 0; WeaponMaster 2; SoulSlayer 1; LeopardHunter 3
Reshuffles: Red 2, Iron 1
Memory end: Red 0, Iron 0
Final battlefield: Red [Leopard Hunter, Spear of First Dawn, Deep River Spirit, Spear of First Dawn, River Hunter, Esprit du Léopard, Leopard Hunter] | Iron [Fang Relic, Pack Harrier, Pack Harrier]
Key issue: Pierce damage produced the strongest blocked-attack spillover in the batch
Observed loop: blocked Shrine attacks still leak damage through Pierce and accelerate the finish
Design meaning: Pierce is materially shaping blocked Shrine races instead of being cosmetic
Next action: review whether Pierce pressure is landing in the intended range for blocked Shrine attacks
