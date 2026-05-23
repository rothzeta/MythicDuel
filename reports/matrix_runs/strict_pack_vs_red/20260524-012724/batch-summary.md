# Batch Summary

Games: 500
Seeds: 123-622
Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports\matrix_runs\strict_pack_vs_red --bot-red iron --bot-iron red --deck-red iron-hyena-pack-pressure --deck-iron red-hunter-evolution --rules strict-alternation
Bots: Red=IronHyenaBot, Iron=RedBaobabBot
Wins: Red=355, Iron=145
Timeouts: 0
Average turns: 22.27
Sample games: 145, 140, 256, 479, 525, 188

WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.
- HardCastChosenWhileLegalEvolveActionExistsRed = 188
- HardCastChosenWhileLegalEvolveActionExistsIron = 150
WARNING: Hard-cast evolution cards were chosen while an evolution base existed.
- HardCastChosenWhileEvolutionBaseExistsRed = 419
- HardCastChosenWhileEvolutionBaseExistsIron = 1694
WARNING: Game exceeded 40 turns.
WARNING: Both players made fewer than 10 Shrine attacks by turn 40.

## Sample-game digest

### Game 145 — fastest Red win
Tags: fastest Red win
Winner: iron-hyena-pack-pressure by shrine break
Turns: 11
Seed: 145
Timeout: no
Shrines broken: Red 0, Iron 3
First Shrine damage: 3 (Seat 1/Red: None, Seat 2/Iron: 3)
First Shrine break: 5 (Seat 1/Red: None, Seat 2/Iron: 5)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 0, Iron 0
First L2: 9
First L3: None
Layer entries: Red L2 1 (hard-cast 0, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 0 (hard-cast 0, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 4, Iron 0
Evolve actions chosen: Red 4, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 1
Awakening flow: legal Red 0, Iron 8; chosen Red 0, Iron 3; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron red.ancestor.firsthunter / 2 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 6, Iron 0
Blocks: Red 0/0 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 6, Iron 0; generated slots Red 6, Iron 0; skipped slots Red 1, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 0
Memory end: Red 0, Iron 3
Final battlefield: Red [Iron Hyena Champion, Pack Harrier] | Iron [Pale River Spirit, River Hunter, River Hunter]
Key issue: Red converted shrine pressure before Iron could race back
Observed loop: Red found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 140 — fastest Iron win
Tags: fastest Iron win
Winner: red-hunter-evolution by shrine break
Turns: 16
Seed: 140
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 3 (Seat 1/Red: 12, Seat 2/Iron: 3)
First Shrine break: 7 (Seat 1/Red: 12, Seat 2/Iron: 7)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 0, Iron 0
First L2: 9
First L3: None
Layer entries: Red L2 1 (hard-cast 0, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 1 (hard-cast 1, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 2, Iron 0
Evolve actions chosen: Red 2, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 1 / Iron 1
Awakening flow: legal Red 0, Iron 4; chosen Red 0, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron red.ancestor.grandmother / 5 turns
Ancestor value: First Hunter +3, Grandmother healed 2, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 6, Iron 3
Blocks: Red 0/0 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 5, Iron 0; generated slots Red 5, Iron 0; skipped slots Red 1, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 1, Iron 1
Final battlefield: Red [Hyena Token, Pack Harrier, Bone Spear, Blood-Scent Hyena, Blood-Scent Hyena] | Iron [Leopard Hunter, Spear of First Dawn, Esprit du Léopard, River Hunter, Pale River Spirit, River Hunter, Spear of First Dawn]
Key issue: Iron closed shrine pressure before Red could stabilize
Observed loop: Iron found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 256 — longest game
Tags: longest game; closest game
Winner: red-hunter-evolution by shrine break
Turns: 46
Seed: 256
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 3 (Seat 1/Red: 16, Seat 2/Iron: 3)
First Shrine break: 7 (Seat 1/Red: 24, Seat 2/Iron: 7)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 0, Iron 0
First L2: 12
First L3: None
Layer entries: Red L2 5 (hard-cast 2, evolved 3), Red L3 0 (hard-cast 0, evolved 0); Iron L2 6 (hard-cast 2, evolved 4), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 6, Iron 12
Evolve actions chosen: Red 6, Iron 12
Hard-cast bypass: legal-window Red 1 / Iron 1; base-exists Red 1 / Iron 5
Awakening flow: legal Red 0, Iron 17; chosen Red 0, Iron 7; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron red.ancestor.firsthunter / 19 turns
Ancestor value: First Hunter +5, Grandmother healed 8, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 9, Iron 11
Blocks: Red 2/3 chosen, Iron 6/8 chosen
Pack pressure: ready units Red 27, Iron 0; generated slots Red 27, Iron 0; skipped slots Red 5, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 3, Iron 4
Memory end: Red 0, Iron 0
Final battlefield: Red [Fang Relic, Bone Spear, Blood-Scent Hyena, Pack Harrier, Hyena Token, Hyena Token, Iron Hyena Champion] | Iron [River Hunter, River Hunter, Young Hunter, Pale River Spirit, Esprit du Léopard]
Key issue: the game stretched unusually long before closing
Observed loop: combat, blocking, and resource generation keep repeating without enough shrine closure
Design meaning: the retain-1 loop can still create long deterministic grinds when shrine pressure is low
Next action: check whether shrine pressure heuristics or loop warnings need to be tightened

### Game 479 — first L3 game
Tags: first L3 game
Winner: red-hunter-evolution by shrine break
Turns: 20
Seed: 479
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 3 (Seat 1/Red: 10, Seat 2/Iron: 3)
First Shrine break: 5 (Seat 1/Red: 12, Seat 2/Iron: 5)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 0, Iron 0
First L2: 8
First L3: 12
Layer entries: Red L2 1 (hard-cast 1, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 3 (hard-cast 2, evolved 1), Iron L3 1 (hard-cast 0, evolved 1)
Legal evolve actions: Red 0, Iron 4
Evolve actions chosen: Red 0, Iron 4
Hard-cast bypass: legal-window Red 1 / Iron 0; base-exists Red 1 / Iron 3
Awakening flow: legal Red 0, Iron 6; chosen Red 0, Iron 4; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron red.ancestor.firsthunter / 6 turns
Ancestor value: First Hunter +6, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 13, Iron 6
Blocks: Red 1/1 chosen, Iron 6/6 chosen
Pack pressure: ready units Red 11, Iron 0; generated slots Red 11, Iron 0; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 1; WeaponMaster 1; SoulSlayer 1; LeopardHunter 2
Reshuffles: Red 1, Iron 1
Memory end: Red 1, Iron 3
Final battlefield: Red [Fang Relic, Hyena Token, Iron Hyena Champion, Fang Relic, Bone-Cracker Cub, Pack Harrier, Bone-Cracker Cub] | Iron [Leopard Hunter, Spear of First Dawn, Esprit du Léopard, River Hunter, River Hunter, Pale River Spirit, River Hunter, Spear of First Dawn]
Key issue: the batch reached L3 here earlier than anywhere else
Observed loop: an L2 path opened, then converted into the earliest L3 spike in the batch
Design meaning: the full evolution ladder is reachable and worth surfacing in batch diagnostics
Next action: use this sample to verify that L2-to-L3 sequencing matches the intended deed model

### Game 525 — highest reshuffle game
Tags: highest reshuffle game
Winner: red-hunter-evolution by shrine break
Turns: 44
Seed: 525
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 3 (Seat 1/Red: 26, Seat 2/Iron: 3)
First Shrine break: 7 (Seat 1/Red: 30, Seat 2/Iron: 7)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 0, Iron 0
First L2: 5
First L3: 28
Layer entries: Red L2 4 (hard-cast 1, evolved 3), Red L3 0 (hard-cast 0, evolved 0); Iron L2 6 (hard-cast 2, evolved 4), Iron L3 1 (hard-cast 0, evolved 1)
Legal evolve actions: Red 6, Iron 14
Evolve actions chosen: Red 6, Iron 12
Hard-cast bypass: legal-window Red 0 / Iron 1; base-exists Red 2 / Iron 11
Awakening flow: legal Red 0, Iron 42; chosen Red 0, Iron 15; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron red.ancestor.firsthunter / 19 turns
Ancestor value: First Hunter +3, Grandmother healed 6, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 10, Iron 10
Blocks: Red 1/4 chosen, Iron 6/7 chosen
Pack pressure: ready units Red 23, Iron 0; generated slots Red 23, Iron 0; skipped slots Red 3, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 3, Iron 5
Memory end: Red 1, Iron 10
Final battlefield: Red [Bone Spear, Blood-Scent Hyena, Iron Hyena Raider] | Iron [Pale River Spirit, Spear of First Dawn, Young Hunter, River Hunter, River Hunter]
Key issue: deck cycling outran closure and created the batch's heaviest reshuffle load
Observed loop: both decks keep recycling through retain-1 turns while shrine damage advances slowly
Design meaning: the retain-1 loop can still create long deterministic grinds when shrine pressure is low
Next action: check whether shrine pressure heuristics or loop warnings need to be tightened

### Game 188 — highest Pierce game
Tags: highest Pierce game
Winner: red-hunter-evolution by shrine break
Turns: 22
Seed: 188
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 3 (Seat 1/Red: 12, Seat 2/Iron: 3)
First Shrine break: 12 (Seat 1/Red: 12, Seat 2/Iron: 13)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 0, Iron 0
First L2: 10
First L3: None
Layer entries: Red L2 2 (hard-cast 1, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 2 (hard-cast 2, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 4, Iron 0
Evolve actions chosen: Red 4, Iron 0
Hard-cast bypass: legal-window Red 1 / Iron 0; base-exists Red 2 / Iron 2
Awakening flow: legal Red 0, Iron 11; chosen Red 0, Iron 5; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron red.ancestor.firsthunter / 8 turns
Ancestor value: First Hunter +5, Grandmother healed 2, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 8, Iron 7
Blocks: Red 4/7 chosen, Iron 3/3 chosen
Pack pressure: ready units Red 11, Iron 0; generated slots Red 10, Iron 0; skipped slots Red 3, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 2; WeaponMaster 2; SoulSlayer 2; LeopardHunter 4
Reshuffles: Red 1, Iron 1
Memory end: Red 0, Iron 3
Final battlefield: Red [Iron Hyena Raider, Bone-Cracker Cub] | Iron [Spear of First Dawn, Pale River Spirit, River Hunter, River Hunter, Baobab Guardian, Pale River Spirit]
Key issue: Pierce damage produced the strongest blocked-attack spillover in the batch
Observed loop: blocked Shrine attacks still leak damage through Pierce and accelerate the finish
Design meaning: Pierce is materially shaping blocked Shrine races instead of being cosmetic
Next action: review whether Pierce pressure is landing in the intended range for blocked Shrine attacks
