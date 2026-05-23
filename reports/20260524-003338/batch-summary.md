# Batch Summary

Games: 100
Seeds: 123-222
Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 100 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red red --bot-iron iron --deck-red red-hunter-evolution --deck-iron iron-hyena-aggro
Bots: Red=RedBaobabBot, Iron=IronHyenaBot
Wins: Red=78, Iron=22
Timeouts: 0
Average turns: 24.52
Sample games: 174, 210, 163, 175, 219, 127

WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.
- HardCastChosenWhileLegalEvolveActionExistsRed = 48
- HardCastChosenWhileLegalEvolveActionExistsIron = 34
WARNING: Hard-cast evolution cards were chosen while an evolution base existed.
- HardCastChosenWhileEvolutionBaseExistsRed = 469
- HardCastChosenWhileEvolutionBaseExistsIron = 68
WARNING: Game exceeded 40 turns.

## Sample-game digest

### Game 174 — fastest Red win
Tags: fastest Red win
Winner: red-hunter-evolution by shrine break
Turns: 16
Seed: 174
Timeout: no
Shrines broken: Red 0, Iron 3
First Shrine damage: 3
First Shrine break: 6
First L2: 9
First L3: None
Layer entries: Red L2 2 (hard-cast 2, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 0 (hard-cast 0, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 0
Evolve actions chosen: Red 0, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 6 / Iron 2
Awakening flow: legal Red 2, Iron 0; chosen Red 1, Iron 0; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 3 turns, Iron None / 0 turns
Ancestor value: First Hunter +4, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 7, Iron 4
Blocks: Red 4/10 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 2; generated slots Red 0, Iron 2; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 0, Iron 0
Final battlefield: Red [Leopard Hunter, Leopard Hunter, River Hunter, Deep River Spirit, Esprit du Léopard] | Iron [Bone-Cracker Cub]
Key issue: Red converted shrine pressure before Iron could race back
Observed loop: Red found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 210 — fastest Iron win
Tags: fastest Iron win
Winner: iron-hyena-aggro by shrine break
Turns: 15
Seed: 210
Timeout: no
Shrines broken: Red 3, Iron 1
First Shrine damage: 4
First Shrine break: 5
First L2: 9
First L3: None
Layer entries: Red L2 1 (hard-cast 1, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 0 (hard-cast 0, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 0
Evolve actions chosen: Red 0, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 1; base-exists Red 2 / Iron 0
Awakening flow: legal Red 4, Iron 7; chosen Red 3, Iron 3; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 4 turns, Iron iron.ancestor.hyena / 5 turns
Ancestor value: First Hunter +5, Grandmother healed 0, Child triggers 0, Iron Hyena +3, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 4, Iron 8
Blocks: Red 2/2 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 6; generated slots Red 0, Iron 6; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 4, Iron 3
Final battlefield: Red [Leopard Hunter, Pale River Spirit] | Iron [Fang Relic, Black-Tooth Smith, Pack Harrier, Bone Spear]
Key issue: Iron closed shrine pressure before Red could stabilize
Observed loop: Iron found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 163 — highest reshuffle game
Tags: longest game; highest reshuffle game
Winner: red-hunter-evolution by shrine break
Turns: 48
Seed: 163
Timeout: no
Shrines broken: Red 0, Iron 3
First Shrine damage: 4
First Shrine break: 33
First L2: 5
First L3: 41
Layer entries: Red L2 6 (hard-cast 2, evolved 4), Red L3 1 (hard-cast 0, evolved 1); Iron L2 5 (hard-cast 3, evolved 2), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 14, Iron 4
Evolve actions chosen: Red 12, Iron 4
Hard-cast bypass: legal-window Red 1 / Iron 2; base-exists Red 5 / Iron 3
Awakening flow: legal Red 39, Iron 3; chosen Red 17, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.grandmother / 21 turns, Iron iron.ancestor.smith / 18 turns
Ancestor value: First Hunter +4, Grandmother healed 7, Child triggers 0, Iron Hyena +0, Smith saved 8, Tooth-Mother +0
Shrine attacks: Red 10, Iron 8
Blocks: Red 6/6 chosen, Iron 2/2 chosen
Pack pressure: ready units Red 0, Iron 23; generated slots Red 0, Iron 23; skipped slots Red 0, Iron 3; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 4, Iron 4
Memory end: Red 6, Iron 2
Final battlefield: Red [Spear of First Dawn, Pale River Spirit, Spear of First Dawn, Young Hunter, Pale River Spirit, River Hunter] | Iron [Fang Relic, Bone Spear, Pack Harrier]
Key issue: deck cycling outran closure and created the batch's heaviest reshuffle load
Observed loop: both decks keep recycling through retain-1 turns while shrine damage advances slowly
Design meaning: the retain-1 loop can still create long deterministic grinds when shrine pressure is low
Next action: check whether shrine pressure heuristics or loop warnings need to be tightened

### Game 175 — closest game
Tags: closest game
Winner: iron-hyena-aggro by shrine break
Turns: 39
Seed: 175
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 4
First Shrine break: 7
First L2: 5
First L3: None
Layer entries: Red L2 6 (hard-cast 1, evolved 5), Red L3 0 (hard-cast 0, evolved 0); Iron L2 4 (hard-cast 2, evolved 2), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 24, Iron 4
Evolve actions chosen: Red 16, Iron 4
Hard-cast bypass: legal-window Red 0 / Iron 1; base-exists Red 9 / Iron 2
Awakening flow: legal Red 29, Iron 4; chosen Red 14, Iron 3; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 14 turns, Iron iron.ancestor.hyena / 17 turns
Ancestor value: First Hunter +11, Grandmother healed 1, Child triggers 1, Iron Hyena +2, Smith saved 5, Tooth-Mother +0
Shrine attacks: Red 11, Iron 7
Blocks: Red 2/2 chosen, Iron 3/4 chosen
Pack pressure: ready units Red 0, Iron 21; generated slots Red 0, Iron 21; skipped slots Red 0, Iron 6; prevented by limit Red 0, Iron 1
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 4, Iron 3
Memory end: Red 11, Iron 1
Final battlefield: Red [Spear of First Dawn, Pale River Spirit, Young Hunter] | Iron [Fang Relic, Iron Hyena Champion, Bone-Cracker Cub, Iron Hyena Raider]
Key issue: the shrine race stayed narrow deep into the game
Observed loop: both players stayed in the shrine race until the final momentum swing
Design meaning: the current bots can produce a genuinely contested shrine race instead of a one-sided roll
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 219 — first L3 game
Tags: first L3 game
Winner: iron-hyena-aggro by shrine break
Turns: 29
Seed: 219
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 4
First Shrine break: 11
First L2: 8
First L3: 11
Layer entries: Red L2 4 (hard-cast 2, evolved 2), Red L3 1 (hard-cast 0, evolved 1); Iron L2 2 (hard-cast 1, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 6, Iron 2
Evolve actions chosen: Red 6, Iron 2
Hard-cast bypass: legal-window Red 1 / Iron 1; base-exists Red 3 / Iron 0
Awakening flow: legal Red 10, Iron 3; chosen Red 6, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 7 turns, Iron iron.ancestor.hyena / 9 turns
Ancestor value: First Hunter +2, Grandmother healed 3, Child triggers 0, Iron Hyena +1, Smith saved 3, Tooth-Mother +0
Shrine attacks: Red 4, Iron 16
Blocks: Red 6/6 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 21; generated slots Red 0, Iron 20; skipped slots Red 0, Iron 1; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 2, Iron 2
Memory end: Red 1, Iron 0
Final battlefield: Red [Young Hunter, River Hunter] | Iron [Bone Spear, Iron Hyena Champion, Iron Hyena Champion, Pack Harrier, Fang Relic, Black-Tooth Smith, Bone-Cracker Cub, Bone Spear]
Key issue: the batch reached L3 here earlier than anywhere else
Observed loop: an L2 path opened, then converted into the earliest L3 spike in the batch
Design meaning: the full evolution ladder is reachable and worth surfacing in batch diagnostics
Next action: use this sample to verify that L2-to-L3 sequencing matches the intended deed model

### Game 127 — highest Pierce game
Tags: highest Pierce game
Winner: iron-hyena-aggro by shrine break
Turns: 33
Seed: 127
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 4
First Shrine break: 5
First L2: 11
First L3: None
Layer entries: Red L2 6 (hard-cast 3, evolved 3), Red L3 0 (hard-cast 0, evolved 0); Iron L2 2 (hard-cast 1, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 10, Iron 4
Evolve actions chosen: Red 8, Iron 4
Hard-cast bypass: legal-window Red 2 / Iron 0; base-exists Red 4 / Iron 1
Awakening flow: legal Red 21, Iron 5; chosen Red 9, Iron 4; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 11 turns, Iron iron.ancestor.hyena / 10 turns
Ancestor value: First Hunter +5, Grandmother healed 2, Child triggers 0, Iron Hyena +5, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 6, Iron 15
Blocks: Red 9/15 chosen, Iron 2/3 chosen
Pack pressure: ready units Red 0, Iron 18; generated slots Red 0, Iron 18; skipped slots Red 0, Iron 5; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 1, Iron 0; WeaponMaster 1; SoulSlayer 1; LeopardHunter 2
Reshuffles: Red 3, Iron 2
Memory end: Red 5, Iron 0
Final battlefield: Red [Spear of First Dawn, Leopard Hunter, Esprit du Léopard] | Iron [Bone Spear, Bone Spear, Pack Harrier, Iron Guard]
Key issue: Pierce damage produced the strongest blocked-attack spillover in the batch
Observed loop: blocked Shrine attacks still leak damage through Pierce and accelerate the finish
Design meaning: Pierce is materially shaping blocked Shrine races instead of being cosmetic
Next action: review whether Pierce pressure is landing in the intended range for blocked Shrine attacks
