# Batch Summary

Games: 500
Seeds: 123-622
Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports\matrix_runs\current_red_vs_pack --bot-red red --bot-iron iron --deck-red red-hunter-evolution --deck-iron iron-hyena-pack-pressure
Bots: Red=RedBaobabBot, Iron=IronHyenaBot
Wins: Red=192, Iron=308
Timeouts: 0
Average turns: 24.37
Sample games: 321, 478, 516, 199, 219, 329

WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.
- HardCastChosenWhileLegalEvolveActionExistsRed = 247
- HardCastChosenWhileLegalEvolveActionExistsIron = 236
WARNING: Hard-cast evolution cards were chosen while an evolution base existed.
- HardCastChosenWhileEvolutionBaseExistsRed = 2085
- HardCastChosenWhileEvolutionBaseExistsIron = 568
WARNING: Game exceeded 40 turns.
WARNING: Both players made fewer than 10 Shrine attacks by turn 40.

## Sample-game digest

### Game 321 — fastest Red win
Tags: fastest Red win
Winner: red-hunter-evolution by shrine break
Turns: 14
Seed: 321
Timeout: no
Shrines broken: Red 1, Iron 3
First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 9)
First Shrine break: 9 (Seat 1/Red: 12, Seat 2/Iron: 9)
Wins in odd phase: 0
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 10, Iron 10
First L2: 8
First L3: None
Layer entries: Red L2 2 (hard-cast 1, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 1 (hard-cast 0, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 2, Iron 2
Evolve actions chosen: Red 2, Iron 2
Hard-cast bypass: legal-window Red 0 / Iron 1; base-exists Red 2 / Iron 1
Awakening flow: legal Red 1, Iron 0; chosen Red 1, Iron 0; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 1 turns, Iron None / 0 turns
Ancestor value: First Hunter +1, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 3, Iron 5
Blocks: Red 3/3 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 7; generated slots Red 0, Iron 7; skipped slots Red 0, Iron 3; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 0
Memory end: Red 1, Iron 1
Final battlefield: Red [Spear of First Dawn, Leopard Hunter, Esprit du Léopard, Young Hunter, River Hunter, Young Hunter] | Iron [Bone-Cracker Cub, Black-Tooth Smith]
Key issue: Red converted shrine pressure before Iron could race back
Observed loop: Red found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 478 — fastest Iron win
Tags: fastest Iron win
Winner: iron-hyena-pack-pressure by shrine break
Turns: 12
Seed: 478
Timeout: no
Shrines broken: Red 3, Iron 0
First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: None)
First Shrine break: 5 (Seat 1/Red: 5, Seat 2/Iron: None)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 0, Iron 19
First L2: 5
First L3: None
Layer entries: Red L2 1 (hard-cast 0, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 2 (hard-cast 0, evolved 2), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 2, Iron 6
Evolve actions chosen: Red 2, Iron 5
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 1 / Iron 0
Awakening flow: legal Red 7, Iron 3; chosen Red 3, Iron 3; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 3 turns, Iron iron.ancestor.firstpack / 3 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 0, Iron 9
Blocks: Red 2/3 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 8; generated slots Red 0, Iron 8; skipped slots Red 0, Iron 1; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 0
Memory end: Red 3, Iron 4
Final battlefield: Red [Spear of First Dawn, Leopard Hunter, Young Hunter] | Iron [Iron Hyena Champion]
Key issue: Iron closed shrine pressure before Red could stabilize
Observed loop: Iron found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 516 — highest reshuffle game
Tags: longest game; highest reshuffle game
Winner: red-hunter-evolution by shrine break
Turns: 51
Seed: 516
Timeout: no
Shrines broken: Red 1, Iron 3
First Shrine damage: 5 (Seat 1/Red: 5, Seat 2/Iron: 33)
First Shrine break: 31 (Seat 1/Red: 31, Seat 2/Iron: 35)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 18, Iron 24
First L2: 14
First L3: 35
Layer entries: Red L2 7 (hard-cast 2, evolved 5), Red L3 1 (hard-cast 0, evolved 1); Iron L2 5 (hard-cast 4, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 16, Iron 2
Evolve actions chosen: Red 16, Iron 2
Hard-cast bypass: legal-window Red 1 / Iron 0; base-exists Red 6 / Iron 8
Awakening flow: legal Red 61, Iron 6; chosen Red 20, Iron 5; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 23 turns, Iron iron.ancestor.smithpassedfang / 21 turns
Ancestor value: First Hunter +3, Grandmother healed 7, Child triggers 0, Iron Hyena +0, Smith saved 4, Tooth-Mother +0
Shrine attacks: Red 6, Iron 18
Blocks: Red 13/16 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 34; generated slots Red 0, Iron 34; skipped slots Red 0, Iron 2; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 5, Iron 4
Memory end: Red 15, Iron 3
Final battlefield: Red [Spear of First Dawn, Leopard Hunter, Leopard Hunter, River Hunter, Young Hunter, River Hunter] | Iron [Fang Relic, Bone Spear, Fang Relic, Pack Harrier, Pack Harrier, Black-Tooth Smith]
Key issue: deck cycling outran closure and created the batch's heaviest reshuffle load
Observed loop: both decks keep recycling through retain-1 turns while shrine damage advances slowly
Design meaning: the retain-1 loop can still create long deterministic grinds when shrine pressure is low
Next action: check whether shrine pressure heuristics or loop warnings need to be tightened

### Game 199 — closest game
Tags: closest game
Winner: iron-hyena-pack-pressure by shrine break
Turns: 47
Seed: 199
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 17)
First Shrine break: 13 (Seat 1/Red: 13, Seat 2/Iron: 19)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 6, Iron 22
First L2: 9
First L3: None
Layer entries: Red L2 10 (hard-cast 5, evolved 5), Red L3 0 (hard-cast 0, evolved 0); Iron L2 6 (hard-cast 2, evolved 4), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 16, Iron 8
Evolve actions chosen: Red 16, Iron 8
Hard-cast bypass: legal-window Red 1 / Iron 1; base-exists Red 10 / Iron 5
Awakening flow: legal Red 22, Iron 22; chosen Red 8, Iron 15; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.grandmother / 19 turns, Iron iron.ancestor.firstpack / 21 turns
Ancestor value: First Hunter +6, Grandmother healed 5, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 8, Iron 17
Blocks: Red 8/9 chosen, Iron 3/4 chosen
Pack pressure: ready units Red 0, Iron 34; generated slots Red 0, Iron 34; skipped slots Red 0, Iron 9; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 4, Iron 3
Memory end: Red 2, Iron 8
Final battlefield: Red [Spear of First Dawn, Pale River Spirit, Young Hunter] | Iron [Bone Spear, Bone Spear, Fang Relic, Iron Hyena Champion, Bone-Cracker Cub, Bone-Cracker Cub]
Key issue: the shrine race stayed narrow deep into the game
Observed loop: both players stayed in the shrine race until the final momentum swing
Design meaning: the current bots can produce a genuinely contested shrine race instead of a one-sided roll
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 219 — first L3 game
Tags: first L3 game
Winner: red-hunter-evolution by shrine break
Turns: 17
Seed: 219
Timeout: no
Shrines broken: Red 0, Iron 3
First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 9)
First Shrine break: 11 (Seat 1/Red: None, Seat 2/Iron: 11)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 25, Iron 10
First L2: 8
First L3: 11
Layer entries: Red L2 2 (hard-cast 1, evolved 1), Red L3 1 (hard-cast 0, evolved 1); Iron L2 0 (hard-cast 0, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 4, Iron 0
Evolve actions chosen: Red 4, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 1
Awakening flow: legal Red 0, Iron 1; chosen Red 0, Iron 1; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron iron.ancestor.firstpack / 1 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 4, Iron 6
Blocks: Red 6/6 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 6; generated slots Red 0, Iron 6; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 1, Iron 0
Final battlefield: Red [Spear of First Dawn, Kuma Who Wounded the Sun, Young Hunter, River Hunter, Baobab Guardian] | Iron [Fang Relic]
Key issue: the batch reached L3 here earlier than anywhere else
Observed loop: an L2 path opened, then converted into the earliest L3 spike in the batch
Design meaning: the full evolution ladder is reachable and worth surfacing in batch diagnostics
Next action: use this sample to verify that L2-to-L3 sequencing matches the intended deed model

### Game 329 — highest Pierce game
Tags: highest Pierce game
Winner: red-hunter-evolution by shrine break
Turns: 35
Seed: 329
Timeout: no
Shrines broken: Red 2, Iron 3
First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 25)
First Shrine break: 27 (Seat 1/Red: 28, Seat 2/Iron: 27)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 20, Iron 24
First L2: 9
First L3: None
Layer entries: Red L2 6 (hard-cast 3, evolved 3), Red L3 0 (hard-cast 0, evolved 0); Iron L2 3 (hard-cast 1, evolved 2), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 6, Iron 4
Evolve actions chosen: Red 5, Iron 4
Hard-cast bypass: legal-window Red 0 / Iron 1; base-exists Red 7 / Iron 1
Awakening flow: legal Red 22, Iron 10; chosen Red 10, Iron 7; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.grandmother / 15 turns, Iron iron.ancestor.firstpack / 12 turns
Ancestor value: First Hunter +6, Grandmother healed 5, Child triggers 2, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 8, Iron 15
Blocks: Red 8/11 chosen, Iron 3/7 chosen
Pack pressure: ready units Red 0, Iron 17; generated slots Red 0, Iron 17; skipped slots Red 0, Iron 4; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 2, Iron 0; WeaponMaster 2; SoulSlayer 2; LeopardHunter 4
Reshuffles: Red 3, Iron 2
Memory end: Red 0, Iron 1
Final battlefield: Red [Leopard Hunter, Deep River Spirit, Spear of First Dawn, Pale River Spirit, Esprit du Léopard, Spear of First Dawn, Leopard Hunter, Young Hunter] | Iron [Bone Spear, Black-Tooth Smith, Iron Hyena Raider, Fang Relic, Bone-Cracker Cub, Pack Harrier, Blood-Scent Hyena]
Key issue: Pierce damage produced the strongest blocked-attack spillover in the batch
Observed loop: blocked Shrine attacks still leak damage through Pierce and accelerate the finish
Design meaning: Pierce is materially shaping blocked Shrine races instead of being cosmetic
Next action: review whether Pierce pressure is landing in the intended range for blocked Shrine attacks
