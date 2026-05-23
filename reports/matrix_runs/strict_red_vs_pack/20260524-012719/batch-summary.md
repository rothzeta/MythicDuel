# Batch Summary

Games: 500
Seeds: 123-622
Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports\matrix_runs\strict_red_vs_pack --bot-red red --bot-iron iron --deck-red red-hunter-evolution --deck-iron iron-hyena-pack-pressure --rules strict-alternation
Bots: Red=RedBaobabBot, Iron=IronHyenaBot
Wins: Red=308, Iron=192
Timeouts: 0
Average turns: 25.25
Sample games: 191, 124, 468, 561, 417, 233

WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.
- HardCastChosenWhileLegalEvolveActionExistsRed = 232
- HardCastChosenWhileLegalEvolveActionExistsIron = 190
WARNING: Hard-cast evolution cards were chosen while an evolution base existed.
- HardCastChosenWhileEvolutionBaseExistsRed = 2176
- HardCastChosenWhileEvolutionBaseExistsIron = 577
WARNING: More than 5 reshuffles occurred.
WARNING: Game exceeded 40 turns.
WARNING: Both players made fewer than 10 Shrine attacks by turn 40.

## Sample-game digest

### Game 191 — fastest Red win
Tags: fastest Red win
Winner: red-hunter-evolution by shrine break
Turns: 15
Seed: 191
Timeout: no
Shrines broken: Red 0, Iron 3
First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 9)
First Shrine break: 11 (Seat 1/Red: None, Seat 2/Iron: 11)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 0, Iron 0
First L2: 7
First L3: None
Layer entries: Red L2 2 (hard-cast 1, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 0 (hard-cast 0, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 2, Iron 0
Evolve actions chosen: Red 2, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 2 / Iron 0
Awakening flow: legal Red 2, Iron 2; chosen Red 1, Iron 1; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 4 turns, Iron iron.ancestor.firstpack / 3 turns
Ancestor value: First Hunter +6, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 6, Iron 2
Blocks: Red 1/2 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 2; generated slots Red 0, Iron 2; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 0
Memory end: Red 2, Iron 0
Final battlefield: Red [Leopard Hunter, River Hunter, Leopard Hunter, Young Hunter, Baobab Guardian] | Iron [Fang Relic]
Key issue: Red converted shrine pressure before Iron could race back
Observed loop: Red found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 124 — fastest Iron win
Tags: fastest Iron win
Winner: iron-hyena-pack-pressure by shrine break
Turns: 14
Seed: 124
Timeout: no
Shrines broken: Red 3, Iron 0
First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: None)
First Shrine break: 9 (Seat 1/Red: 9, Seat 2/Iron: None)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 0, Iron 0
First L2: 6
First L3: None
Layer entries: Red L2 1 (hard-cast 1, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 2 (hard-cast 0, evolved 2), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 4
Evolve actions chosen: Red 0, Iron 4
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 1
Awakening flow: legal Red 10, Iron 5; chosen Red 4, Iron 3; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 4 turns, Iron iron.ancestor.firstpack / 3 turns
Ancestor value: First Hunter +0, Grandmother healed 1, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 0, Iron 8
Blocks: Red 1/1 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 8; generated slots Red 0, Iron 8; skipped slots Red 0, Iron 2; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 0
Memory end: Red 1, Iron 3
Final battlefield: Red [River Hunter] | Iron [Hyena Token, Pack Harrier, Fang Relic]
Key issue: Iron closed shrine pressure before Red could stabilize
Observed loop: Iron found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 468 — highest reshuffle game
Tags: longest game; highest reshuffle game
Winner: red-hunter-evolution by shrine break
Turns: 53
Seed: 468
Timeout: no
Shrines broken: Red 1, Iron 3
First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 5)
First Shrine break: 10 (Seat 1/Red: 10, Seat 2/Iron: 23)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 0, Iron 0
First L2: 11
First L3: None
Layer entries: Red L2 9 (hard-cast 3, evolved 6), Red L3 0 (hard-cast 0, evolved 0); Iron L2 6 (hard-cast 2, evolved 4), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 20, Iron 8
Evolve actions chosen: Red 16, Iron 8
Hard-cast bypass: legal-window Red 3 / Iron 2; base-exists Red 10 / Iron 4
Awakening flow: legal Red 55, Iron 7; chosen Red 19, Iron 5; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 22 turns, Iron iron.ancestor.firstpack / 21 turns
Ancestor value: First Hunter +8, Grandmother healed 6, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 14, Iron 17
Blocks: Red 11/12 chosen, Iron 3/3 chosen
Pack pressure: ready units Red 0, Iron 31; generated slots Red 0, Iron 31; skipped slots Red 0, Iron 3; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 6, Iron 3
Memory end: Red 12, Iron 0
Final battlefield: Red [Spear of First Dawn, Pale River Spirit, River Hunter, Young Hunter, River Hunter, Spear of First Dawn] | Iron [Iron Hyena Raider, Fang Relic, Fang Relic, Blood-Scent Hyena]
Key issue: deck cycling outran closure and created the batch's heaviest reshuffle load
Observed loop: both decks keep recycling through retain-1 turns while shrine damage advances slowly
Design meaning: the retain-1 loop can still create long deterministic grinds when shrine pressure is low
Next action: check whether shrine pressure heuristics or loop warnings need to be tightened

### Game 561 — closest game
Tags: closest game
Winner: iron-hyena-pack-pressure by shrine break
Turns: 51
Seed: 561
Timeout: no
Shrines broken: Red 3, Iron 3
First Shrine damage: 8 (Seat 1/Red: 8, Seat 2/Iron: 33)
First Shrine break: 12 (Seat 1/Red: 12, Seat 2/Iron: 35)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 0, Iron 0
First L2: 7
First L3: 45
Layer entries: Red L2 7 (hard-cast 1, evolved 6), Red L3 1 (hard-cast 0, evolved 1); Iron L2 5 (hard-cast 2, evolved 3), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 16, Iron 8
Evolve actions chosen: Red 15, Iron 8
Hard-cast bypass: legal-window Red 2 / Iron 0; base-exists Red 6 / Iron 4
Awakening flow: legal Red 50, Iron 21; chosen Red 18, Iron 15; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.grandmother / 21 turns, Iron iron.ancestor.firstpack / 19 turns
Ancestor value: First Hunter +7, Grandmother healed 3, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 8, Iron 17
Blocks: Red 9/9 chosen, Iron 2/2 chosen
Pack pressure: ready units Red 0, Iron 25; generated slots Red 0, Iron 25; skipped slots Red 0, Iron 3; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 1, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 5, Iron 3
Memory end: Red 10, Iron 8
Final battlefield: Red [Spear of First Dawn, Deep River Spirit, Deep River Spirit, Leopard Hunter] | Iron [Bone Spear, Fang Relic, Bone-Cracker Cub, Pack Harrier]
Key issue: the shrine race stayed narrow deep into the game
Observed loop: both players stayed in the shrine race until the final momentum swing
Design meaning: the current bots can produce a genuinely contested shrine race instead of a one-sided roll
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 417 — first L3 game
Tags: first L3 game
Winner: red-hunter-evolution by shrine break
Turns: 19
Seed: 417
Timeout: no
Shrines broken: Red 0, Iron 3
First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 9)
First Shrine break: 13 (Seat 1/Red: None, Seat 2/Iron: 13)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 0, Iron 0
First L2: 7
First L3: 11
Layer entries: Red L2 3 (hard-cast 2, evolved 1), Red L3 1 (hard-cast 0, evolved 1); Iron L2 1 (hard-cast 1, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 6, Iron 0
Evolve actions chosen: Red 6, Iron 0
Hard-cast bypass: legal-window Red 1 / Iron 0; base-exists Red 5 / Iron 1
Awakening flow: legal Red 9, Iron 2; chosen Red 4, Iron 1; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 6 turns, Iron iron.ancestor.firstpack / 3 turns
Ancestor value: First Hunter +3, Grandmother healed 3, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 5, Iron 7
Blocks: Red 6/8 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 4; generated slots Red 0, Iron 4; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 1, Iron 1
Final battlefield: Red [Kuma Who Wounded the Sun, Pale River Spirit, Young Hunter, Spear of First Dawn, Leopard Hunter, Esprit du Léopard] | Iron [Bone-Cracker Cub, Pack Harrier]
Key issue: the batch reached L3 here earlier than anywhere else
Observed loop: an L2 path opened, then converted into the earliest L3 spike in the batch
Design meaning: the full evolution ladder is reachable and worth surfacing in batch diagnostics
Next action: use this sample to verify that L2-to-L3 sequencing matches the intended deed model

### Game 233 — highest Pierce game
Tags: highest Pierce game
Winner: red-hunter-evolution by shrine break
Turns: 23
Seed: 233
Timeout: no
Shrines broken: Red 2, Iron 3
First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 13)
First Shrine break: 15 (Seat 1/Red: 18, Seat 2/Iron: 15)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 0, Iron 0
First L2: 11
First L3: None
Layer entries: Red L2 2 (hard-cast 1, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 2 (hard-cast 1, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 2, Iron 4
Evolve actions chosen: Red 2, Iron 4
Hard-cast bypass: legal-window Red 0 / Iron 2; base-exists Red 7 / Iron 0
Awakening flow: legal Red 7, Iron 8; chosen Red 4, Iron 4; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 8 turns, Iron iron.ancestor.firstpack / 4 turns
Ancestor value: First Hunter +5, Grandmother healed 1, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 6, Iron 9
Blocks: Red 3/3 chosen, Iron 2/6 chosen
Pack pressure: ready units Red 0, Iron 12; generated slots Red 0, Iron 10; skipped slots Red 0, Iron 4; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 2, Iron 0; WeaponMaster 2; SoulSlayer 2; LeopardHunter 4
Reshuffles: Red 2, Iron 1
Memory end: Red 0, Iron 2
Final battlefield: Red [Leopard Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter, Esprit du Léopard, Deep River Spirit, River Hunter] | Iron [Bone Spear, Iron Hyena Champion, Iron Hyena Champion, Fang Relic, Iron Hyena Raider, Fang Relic, Iron Hyena Raider]
Key issue: Pierce damage produced the strongest blocked-attack spillover in the batch
Observed loop: blocked Shrine attacks still leak damage through Pierce and accelerate the finish
Design meaning: Pierce is materially shaping blocked Shrine races instead of being cosmetic
Next action: review whether Pierce pressure is landing in the intended range for blocked Shrine attacks
