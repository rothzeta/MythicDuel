# Batch Summary

Games: 500
Seeds: 123-622
Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports\matrix_runs\phase6_pack_vs_red --bot-red iron --bot-iron red --deck-red iron-hyena-pack-pressure --deck-iron red-hunter-evolution --rules phase-length-6
Bots: Red=IronHyenaBot, Iron=RedBaobabBot
Wins: Red=284, Iron=216
Timeouts: 0
Average turns: 23.69
Sample games: 123, 137, 209, 522, 183, 285

WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.
- HardCastChosenWhileLegalEvolveActionExistsRed = 217
- HardCastChosenWhileLegalEvolveActionExistsIron = 212
WARNING: Hard-cast evolution cards were chosen while an evolution base existed.
- HardCastChosenWhileEvolutionBaseExistsRed = 502
- HardCastChosenWhileEvolutionBaseExistsIron = 1930
WARNING: Game exceeded 40 turns.
WARNING: Both players made fewer than 10 Shrine attacks by turn 40.

## Sample-game digest

### Game 123 — fastest Red win
Tags: fastest Red win
Winner: iron-hyena-pack-pressure by shrine break
Turns: 13
Seed: 123
Timeout: no
Shrines broken: Red 1, Iron 3
First Shrine damage: 3 (Seat 1/Red: 9, Seat 2/Iron: 3)
First Shrine break: 5 (Seat 1/Red: 11, Seat 2/Iron: 5)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 12, Iron 0
First L2: 7
First L3: None
Layer entries: Red L2 1 (hard-cast 0, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 1 (hard-cast 0, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 4, Iron 2
Evolve actions chosen: Red 2, Iron 2
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 0
Awakening flow: legal Red 0, Iron 3; chosen Red 0, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron red.ancestor.firsthunter / 2 turns
Ancestor value: First Hunter +2, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 8, Iron 2
Blocks: Red 0/0 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 8, Iron 0; generated slots Red 8, Iron 0; skipped slots Red 1, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 0
Memory end: Red 0, Iron 4
Final battlefield: Red [Pack Harrier, Bone-Cracker Cub, Black-Tooth Smith, Iron Hyena Champion] | Iron [Leopard Hunter, Spear of First Dawn, Young Hunter, Young Hunter]
Key issue: Red converted shrine pressure before Iron could race back
Observed loop: Red found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 137 — fastest Iron win
Tags: fastest Iron win
Winner: red-hunter-evolution by shrine break
Turns: 16
Seed: 137
Timeout: no
Shrines broken: Red 3, Iron 1
First Shrine damage: 3 (Seat 1/Red: 7, Seat 2/Iron: 3)
First Shrine break: 7 (Seat 1/Red: 7, Seat 2/Iron: 15)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 2, Iron 12
First L2: 9
First L3: 14
Layer entries: Red L2 1 (hard-cast 1, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 2 (hard-cast 2, evolved 0), Iron L3 1 (hard-cast 0, evolved 1)
Legal evolve actions: Red 0, Iron 2
Evolve actions chosen: Red 0, Iron 2
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 2 / Iron 5
Awakening flow: legal Red 0, Iron 6; chosen Red 0, Iron 3; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron red.ancestor.firsthunter / 5 turns
Ancestor value: First Hunter +6, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 4, Iron 6
Blocks: Red 1/1 chosen, Iron 3/3 chosen
Pack pressure: ready units Red 5, Iron 0; generated slots Red 5, Iron 0; skipped slots Red 1, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 1; WeaponMaster 1; SoulSlayer 0; LeopardHunter 1
Reshuffles: Red 1, Iron 1
Memory end: Red 0, Iron 1
Final battlefield: Red [Bone Spear, Iron Hyena Champion, Blood-Scent Hyena] | Iron [Leopard Hunter, Kuma Who Wounded the Sun, River Hunter, Young Hunter, Spear of First Dawn]
Key issue: Iron closed shrine pressure before Red could stabilize
Observed loop: Iron found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 209 — highest reshuffle game
Tags: longest game; highest reshuffle game
Winner: red-hunter-evolution by shrine break
Turns: 45
Seed: 209
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine break: 17 (Seat 1/Red: 26, Seat 2/Iron: 17)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 12, Iron 9
First L2: 12
First L3: None
Layer entries: Red L2 4 (hard-cast 2, evolved 2), Red L3 0 (hard-cast 0, evolved 0); Iron L2 6 (hard-cast 2, evolved 4), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 4, Iron 16
Evolve actions chosen: Red 4, Iron 12
Hard-cast bypass: legal-window Red 0 / Iron 2; base-exists Red 4 / Iron 7
Awakening flow: legal Red 0, Iron 41; chosen Red 0, Iron 16; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron red.ancestor.firsthunter / 19 turns
Ancestor value: First Hunter +9, Grandmother healed 1, Child triggers 1, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 8, Iron 13
Blocks: Red 3/8 chosen, Iron 4/4 chosen
Pack pressure: ready units Red 28, Iron 0; generated slots Red 28, Iron 0; skipped slots Red 8, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 3, Iron 5
Memory end: Red 0, Iron 8
Final battlefield: Red [Bone Spear, Fang Relic, Blood-Scent Hyena, Pack Harrier] | Iron [Baobab Guardian, Pale River Spirit, Esprit du Léopard, Spear of First Dawn, Young Hunter, Young Hunter, River Hunter, Spear of First Dawn]
Key issue: deck cycling outran closure and created the batch's heaviest reshuffle load
Observed loop: both decks keep recycling through retain-1 turns while shrine damage advances slowly
Design meaning: the retain-1 loop can still create long deterministic grinds when shrine pressure is low
Next action: check whether shrine pressure heuristics or loop warnings need to be tightened

### Game 522 — closest game
Tags: closest game
Winner: red-hunter-evolution by shrine break
Turns: 26
Seed: 522
Timeout: no
Shrines broken: Red 3, Iron 3
First Shrine damage: 3 (Seat 1/Red: 16, Seat 2/Iron: 3)
First Shrine break: 13 (Seat 1/Red: 18, Seat 2/Iron: 13)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 14, Iron 16
First L2: 5
First L3: 21
Layer entries: Red L2 2 (hard-cast 0, evolved 2), Red L3 0 (hard-cast 0, evolved 0); Iron L2 2 (hard-cast 1, evolved 1), Iron L3 1 (hard-cast 0, evolved 1)
Legal evolve actions: Red 6, Iron 4
Evolve actions chosen: Red 6, Iron 4
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 2
Awakening flow: legal Red 0, Iron 22; chosen Red 0, Iron 9; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron red.ancestor.grandmother / 10 turns
Ancestor value: First Hunter +6, Grandmother healed 3, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 13, Iron 6
Blocks: Red 3/4 chosen, Iron 5/8 chosen
Pack pressure: ready units Red 13, Iron 0; generated slots Red 13, Iron 0; skipped slots Red 5, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 2; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 2
Memory end: Red 1, Iron 6
Final battlefield: Red [Black-Tooth Smith, Black-Tooth Smith, Pack Harrier] | Iron [Pale River Spirit, Leopard Hunter, Spear of First Dawn, River Hunter]
Key issue: the shrine race stayed narrow deep into the game
Observed loop: both players stayed in the shrine race until the final momentum swing
Design meaning: the current bots can produce a genuinely contested shrine race instead of a one-sided roll
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 183 — first L3 game
Tags: first L3 game
Winner: iron-hyena-pack-pressure by shrine break
Turns: 20
Seed: 183
Timeout: no
Shrines broken: Red 2, Iron 3
First Shrine damage: 3 (Seat 1/Red: 7, Seat 2/Iron: 3)
First Shrine break: 9 (Seat 1/Red: 9, Seat 2/Iron: 10)
Wins in odd phase: 0
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 2, Iron 12
First L2: 7
First L3: 11
Layer entries: Red L2 2 (hard-cast 1, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 3 (hard-cast 1, evolved 2), Iron L3 1 (hard-cast 0, evolved 1)
Legal evolve actions: Red 4, Iron 6
Evolve actions chosen: Red 2, Iron 6
Hard-cast bypass: legal-window Red 1 / Iron 1; base-exists Red 2 / Iron 3
Awakening flow: legal Red 0, Iron 4; chosen Red 0, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron red.ancestor.firsthunter / 7 turns
Ancestor value: First Hunter +3, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 14, Iron 3
Blocks: Red 0/0 chosen, Iron 6/6 chosen
Pack pressure: ready units Red 14, Iron 0; generated slots Red 13, Iron 0; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 0, Iron 1
Final battlefield: Red [Iron Hyena Champion, Bone-Cracker Cub, Pack Harrier, Iron Hyena Champion] | Iron [Leopard Hunter, River Hunter, Esprit du Léopard]
Key issue: the batch reached L3 here earlier than anywhere else
Observed loop: an L2 path opened, then converted into the earliest L3 spike in the batch
Design meaning: the full evolution ladder is reachable and worth surfacing in batch diagnostics
Next action: use this sample to verify that L2-to-L3 sequencing matches the intended deed model

### Game 285 — highest Pierce game
Tags: highest Pierce game
Winner: red-hunter-evolution by shrine break
Turns: 19
Seed: 285
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 3 (Seat 1/Red: 11, Seat 2/Iron: 3)
First Shrine break: 13 (Seat 1/Red: 14, Seat 2/Iron: 13)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 9, Iron 18
First L2: 9
First L3: None
Layer entries: Red L2 1 (hard-cast 0, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 2 (hard-cast 1, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 4, Iron 2
Evolve actions chosen: Red 3, Iron 2
Hard-cast bypass: legal-window Red 1 / Iron 0; base-exists Red 1 / Iron 2
Awakening flow: legal Red 0, Iron 7; chosen Red 0, Iron 3; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron red.ancestor.firsthunter / 6 turns
Ancestor value: First Hunter +6, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 7, Iron 6
Blocks: Red 3/7 chosen, Iron 2/2 chosen
Pack pressure: ready units Red 10, Iron 0; generated slots Red 9, Iron 0; skipped slots Red 5, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 3; WeaponMaster 3; SoulSlayer 3; LeopardHunter 6
Reshuffles: Red 1, Iron 1
Memory end: Red 0, Iron 1
Final battlefield: Red [Black-Tooth Smith, Blood-Scent Hyena, Pack Harrier] | Iron [Leopard Hunter, Spear of First Dawn, Esprit du Léopard, Deep River Spirit, Leopard Hunter, River Hunter, Young Hunter]
Key issue: Pierce damage produced the strongest blocked-attack spillover in the batch
Observed loop: blocked Shrine attacks still leak damage through Pierce and accelerate the finish
Design meaning: Pierce is materially shaping blocked Shrine races instead of being cosmetic
Next action: review whether Pierce pressure is landing in the intended range for blocked Shrine attacks
