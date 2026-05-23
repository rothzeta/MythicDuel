# Batch Summary

Games: 500
Seeds: 123-622
Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports\matrix_runs\current_pack_vs_red --bot-red iron --bot-iron red --deck-red iron-hyena-pack-pressure --deck-iron red-hunter-evolution
Bots: Red=IronHyenaBot, Iron=RedBaobabBot
Wins: Red=323, Iron=177
Timeouts: 0
Average turns: 22.54
Sample games: 156, 188, 166, 411, 570, 489

WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.
- HardCastChosenWhileLegalEvolveActionExistsRed = 199
- HardCastChosenWhileLegalEvolveActionExistsIron = 153
WARNING: Hard-cast evolution cards were chosen while an evolution base existed.
- HardCastChosenWhileEvolutionBaseExistsRed = 481
- HardCastChosenWhileEvolutionBaseExistsIron = 1815
WARNING: More than 5 reshuffles occurred.
WARNING: Game exceeded 40 turns.

## Sample-game digest

### Game 156 — fastest Red win
Tags: fastest Red win
Winner: iron-hyena-pack-pressure by shrine break
Turns: 11
Seed: 156
Timeout: no
Shrines broken: Red 0, Iron 3
First Shrine damage: 3 (Seat 1/Red: None, Seat 2/Iron: 3)
First Shrine break: 8 (Seat 1/Red: None, Seat 2/Iron: 8)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 16, Iron 0
First L2: 8
First L3: None
Layer entries: Red L2 2 (hard-cast 0, evolved 2), Red L3 0 (hard-cast 0, evolved 0); Iron L2 0 (hard-cast 0, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 6, Iron 0
Evolve actions chosen: Red 6, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 1 / Iron 0
Awakening flow: legal Red 0, Iron 4; chosen Red 0, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron red.ancestor.grandmother / 2 turns
Ancestor value: First Hunter +0, Grandmother healed 2, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 8, Iron 0
Blocks: Red 0/0 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 10, Iron 0; generated slots Red 10, Iron 0; skipped slots Red 3, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 0
Memory end: Red 0, Iron 1
Final battlefield: Red [Pack Harrier, Iron Hyena Champion, Hyena Token, Bone Spear] | Iron [Young Hunter, River Hunter, Pale River Spirit]
Key issue: Red converted shrine pressure before Iron could race back
Observed loop: Red found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 188 — fastest Iron win
Tags: fastest Iron win
Winner: red-hunter-evolution by shrine break
Turns: 15
Seed: 188
Timeout: no
Shrines broken: Red 3, Iron 0
First Shrine damage: 3 (Seat 1/Red: 5, Seat 2/Iron: 3)
First Shrine break: 12 (Seat 1/Red: 12, Seat 2/Iron: None)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 3, Iron 21
First L2: 10
First L3: None
Layer entries: Red L2 1 (hard-cast 1, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 2 (hard-cast 2, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 0
Evolve actions chosen: Red 0, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 1 / Iron 2
Awakening flow: legal Red 0, Iron 4; chosen Red 0, Iron 1; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron red.ancestor.grandmother / 3 turns
Ancestor value: First Hunter +0, Grandmother healed 4, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 5, Iron 4
Blocks: Red 0/0 chosen, Iron 5/6 chosen
Pack pressure: ready units Red 4, Iron 0; generated slots Red 4, Iron 0; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 1
Memory end: Red 0, Iron 2
Final battlefield: Red [Hyena Token, Bone-Cracker Cub, Iron Hyena Champion] | Iron [Leopard Hunter, Spear of First Dawn, Esprit du Léopard, Young Hunter, Spear of First Dawn]
Key issue: Iron closed shrine pressure before Red could stabilize
Observed loop: Iron found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 166 — highest reshuffle game
Tags: longest game; highest reshuffle game
Winner: red-hunter-evolution by shrine break
Turns: 47
Seed: 166
Timeout: no
Shrines broken: Red 3, Iron 1
First Shrine damage: 3 (Seat 1/Red: 18, Seat 2/Iron: 3)
First Shrine break: 9 (Seat 1/Red: 26, Seat 2/Iron: 9)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 10, Iron 13
First L2: 10
First L3: 26
Layer entries: Red L2 4 (hard-cast 3, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 8 (hard-cast 1, evolved 7), Iron L3 1 (hard-cast 0, evolved 1)
Legal evolve actions: Red 4, Iron 22
Evolve actions chosen: Red 4, Iron 20
Hard-cast bypass: legal-window Red 1 / Iron 3; base-exists Red 4 / Iron 5
Awakening flow: legal Red 0, Iron 27; chosen Red 0, Iron 12; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron red.ancestor.firsthunter / 19 turns
Ancestor value: First Hunter +7, Grandmother healed 3, Child triggers 2, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 10, Iron 11
Blocks: Red 2/2 chosen, Iron 7/8 chosen
Pack pressure: ready units Red 26, Iron 0; generated slots Red 26, Iron 0; skipped slots Red 3, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 3, Iron 6
Memory end: Red 0, Iron 4
Final battlefield: Red [Fang Relic, Bone Spear, Pack Harrier, Blood-Scent Hyena, Black-Tooth Smith] | Iron [Spear of First Dawn, Pale River Spirit, Spear of First Dawn, Deep River Spirit, Leopard Hunter, Young Hunter, Young Hunter]
Key issue: deck cycling outran closure and created the batch's heaviest reshuffle load
Observed loop: both decks keep recycling through retain-1 turns while shrine damage advances slowly
Design meaning: the retain-1 loop can still create long deterministic grinds when shrine pressure is low
Next action: check whether shrine pressure heuristics or loop warnings need to be tightened

### Game 411 — closest game
Tags: closest game
Winner: red-hunter-evolution by shrine break
Turns: 44
Seed: 411
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 3 (Seat 1/Red: 15, Seat 2/Iron: 3)
First Shrine break: 9 (Seat 1/Red: 21, Seat 2/Iron: 9)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 16, Iron 17
First L2: 13
First L3: None
Layer entries: Red L2 3 (hard-cast 2, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 6 (hard-cast 1, evolved 5), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 6, Iron 12
Evolve actions chosen: Red 4, Iron 12
Hard-cast bypass: legal-window Red 0 / Iron 1; base-exists Red 2 / Iron 8
Awakening flow: legal Red 0, Iron 45; chosen Red 0, Iron 18; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron red.ancestor.grandmother / 19 turns
Ancestor value: First Hunter +5, Grandmother healed 7, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 12, Iron 8
Blocks: Red 1/2 chosen, Iron 7/7 chosen
Pack pressure: ready units Red 27, Iron 0; generated slots Red 27, Iron 0; skipped slots Red 6, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 3, Iron 5
Memory end: Red 0, Iron 6
Final battlefield: Red [Bone Spear, Iron Hyena Raider, Iron Hyena Raider] | Iron [Spear of First Dawn, River Hunter, River Hunter, Esprit du Léopard]
Key issue: the shrine race stayed narrow deep into the game
Observed loop: both players stayed in the shrine race until the final momentum swing
Design meaning: the current bots can produce a genuinely contested shrine race instead of a one-sided roll
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 570 — first L3 game
Tags: first L3 game
Winner: red-hunter-evolution by shrine break
Turns: 15
Seed: 570
Timeout: no
Shrines broken: Red 3, Iron 0
First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine break: 5 (Seat 1/Red: 5, Seat 2/Iron: None)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 5, Iron 25
First L2: 10
First L3: 13
Layer entries: Red L2 0 (hard-cast 0, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 2 (hard-cast 2, evolved 0), Iron L3 1 (hard-cast 0, evolved 1)
Legal evolve actions: Red 0, Iron 2
Evolve actions chosen: Red 0, Iron 2
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 3
Awakening flow: legal Red 0, Iron 4; chosen Red 0, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron red.ancestor.firsthunter / 3 turns
Ancestor value: First Hunter +4, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 5, Iron 7
Blocks: Red 0/0 chosen, Iron 5/10 chosen
Pack pressure: ready units Red 3, Iron 0; generated slots Red 3, Iron 0; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 1
Memory end: Red 0, Iron 1
Final battlefield: Red [Iron Hyena Raider] | Iron [Leopard Hunter, Kuma Who Wounded the Sun, River Hunter, Young Hunter]
Key issue: the batch reached L3 here earlier than anywhere else
Observed loop: an L2 path opened, then converted into the earliest L3 spike in the batch
Design meaning: the full evolution ladder is reachable and worth surfacing in batch diagnostics
Next action: use this sample to verify that L2-to-L3 sequencing matches the intended deed model

### Game 489 — highest Pierce game
Tags: highest Pierce game
Winner: iron-hyena-pack-pressure by shrine break
Turns: 25
Seed: 489
Timeout: no
Shrines broken: Red 2, Iron 3
First Shrine damage: 3 (Seat 1/Red: 5, Seat 2/Iron: 3)
First Shrine break: 11 (Seat 1/Red: 18, Seat 2/Iron: 11)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 24, Iron 16
First L2: 11
First L3: 21
Layer entries: Red L2 3 (hard-cast 0, evolved 3), Red L3 0 (hard-cast 0, evolved 0); Iron L2 2 (hard-cast 1, evolved 1), Iron L3 1 (hard-cast 0, evolved 1)
Legal evolve actions: Red 10, Iron 4
Evolve actions chosen: Red 8, Iron 4
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 1 / Iron 9
Awakening flow: legal Red 0, Iron 8; chosen Red 0, Iron 5; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron red.ancestor.grandmother / 7 turns
Ancestor value: First Hunter +5, Grandmother healed 1, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 14, Iron 6
Blocks: Red 2/3 chosen, Iron 5/5 chosen
Pack pressure: ready units Red 16, Iron 0; generated slots Red 15, Iron 0; skipped slots Red 4, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 2; WeaponMaster 2; SoulSlayer 1; LeopardHunter 3
Reshuffles: Red 1, Iron 2
Memory end: Red 0, Iron 2
Final battlefield: Red [Fang Relic, Fang Relic, Blood-Scent Hyena, Black-Tooth Smith, Iron Hyena Champion, Bone-Cracker Cub] | Iron [Spear of First Dawn, Esprit du Léopard, Pale River Spirit, Kuma Who Wounded the Sun]
Key issue: Pierce damage produced the strongest blocked-attack spillover in the batch
Observed loop: blocked Shrine attacks still leak damage through Pierce and accelerate the finish
Design meaning: Pierce is materially shaping blocked Shrine races instead of being cosmetic
Next action: review whether Pierce pressure is landing in the intended range for blocked Shrine attacks
