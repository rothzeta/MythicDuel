# Batch Summary

Games: 100
Seeds: 123-222
Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 100 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red red --bot-iron iron --deck-red red-hunter-evolution --deck-iron iron-hyena-pack-pressure
Bots: Red=RedBaobabBot, Iron=IronHyenaBot
Wins: Red=35, Iron=65
Timeouts: 0
Average turns: 25.54
Sample games: 165, 202, 200, 199, 219, 182

WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.
- HardCastChosenWhileLegalEvolveActionExistsRed = 55
- HardCastChosenWhileLegalEvolveActionExistsIron = 49
WARNING: Hard-cast evolution cards were chosen while an evolution base existed.
- HardCastChosenWhileEvolutionBaseExistsRed = 437
- HardCastChosenWhileEvolutionBaseExistsIron = 126
WARNING: Game exceeded 40 turns.
WARNING: Both players made fewer than 10 Shrine attacks by turn 40.

## Sample-game digest

### Game 165 — fastest Red win
Tags: fastest Red win
Winner: red-hunter-evolution by shrine break
Turns: 17
Seed: 165
Timeout: no
Shrines broken: Red 1, Iron 3
First Shrine damage: 4
First Shrine break: 7
First L2: 5
First L3: None
Layer entries: Red L2 2 (hard-cast 2, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 1 (hard-cast 0, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 2
Evolve actions chosen: Red 0, Iron 2
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 6 / Iron 2
Awakening flow: legal Red 5, Iron 5; chosen Red 3, Iron 4; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 6 turns, Iron iron.ancestor.firstpack / 5 turns
Ancestor value: First Hunter +3, Grandmother healed 3, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 7, Iron 7
Blocks: Red 4/7 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 6; generated slots Red 0, Iron 6; skipped slots Red 0, Iron 1; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 1, Iron 2
Final battlefield: Red [Leopard Hunter, Young Hunter, Leopard Hunter, Young Hunter, Spear of First Dawn, Pale River Spirit] | Iron [Bone-Cracker Cub]
Key issue: Red converted shrine pressure before Iron could race back
Observed loop: Red found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 202 — fastest Iron win
Tags: fastest Iron win
Winner: iron-hyena-pack-pressure by shrine break
Turns: 13
Seed: 202
Timeout: no
Shrines broken: Red 3, Iron 0
First Shrine damage: 4
First Shrine break: 5
First L2: 9
First L3: None
Layer entries: Red L2 1 (hard-cast 1, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 1 (hard-cast 0, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 8
Evolve actions chosen: Red 0, Iron 2
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 2 / Iron 0
Awakening flow: legal Red 4, Iron 7; chosen Red 2, Iron 4; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.grandmother / 3 turns, Iron iron.ancestor.firstpack / 4 turns
Ancestor value: First Hunter +0, Grandmother healed 2, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 1, Iron 9
Blocks: Red 1/1 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 9; generated slots Red 0, Iron 8; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 0
Memory end: Red 1, Iron 4
Final battlefield: Red [Pale River Spirit, Leopard Hunter, Young Hunter] | Iron [Pack Harrier, Fang Relic, Blood-Scent Hyena, Pack Harrier, Iron Hyena Champion]
Key issue: Iron closed shrine pressure before Red could stabilize
Observed loop: Iron found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 200 — highest reshuffle game
Tags: longest game; highest reshuffle game
Winner: iron-hyena-pack-pressure by shrine break
Turns: 50
Seed: 200
Timeout: no
Shrines broken: Red 3, Iron 1
First Shrine damage: 5
First Shrine break: 21
First L2: 11
First L3: None
Layer entries: Red L2 7 (hard-cast 2, evolved 5), Red L3 0 (hard-cast 0, evolved 0); Iron L2 5 (hard-cast 2, evolved 3), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 14, Iron 8
Evolve actions chosen: Red 14, Iron 6
Hard-cast bypass: legal-window Red 1 / Iron 1; base-exists Red 8 / Iron 6
Awakening flow: legal Red 59, Iron 24; chosen Red 21, Iron 17; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 22 turns, Iron iron.ancestor.firstpack / 21 turns
Ancestor value: First Hunter +5, Grandmother healed 2, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 6, Iron 18
Blocks: Red 8/9 chosen, Iron 2/2 chosen
Pack pressure: ready units Red 0, Iron 26; generated slots Red 0, Iron 26; skipped slots Red 0, Iron 4; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 5, Iron 4
Memory end: Red 9, Iron 6
Final battlefield: Red [Pale River Spirit, Spear of First Dawn, Spear of First Dawn, River Hunter, River Hunter, Esprit du Léopard, Deep River Spirit] | Iron [Bone Spear, Pack Harrier, Iron Hyena Champion]
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
First Shrine damage: 4
First Shrine break: 13
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
First Shrine damage: 4
First Shrine break: 11
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

### Game 182 — highest Pierce game
Tags: highest Pierce game
Winner: red-hunter-evolution by shrine break
Turns: 22
Seed: 182
Timeout: no
Shrines broken: Red 2, Iron 3
First Shrine damage: 5
First Shrine break: 13
First L2: 7
First L3: 22
Layer entries: Red L2 2 (hard-cast 1, evolved 1), Red L3 1 (hard-cast 0, evolved 1); Iron L2 3 (hard-cast 1, evolved 2), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 4, Iron 8
Evolve actions chosen: Red 3, Iron 7
Hard-cast bypass: legal-window Red 1 / Iron 0; base-exists Red 2 / Iron 0
Awakening flow: legal Red 11, Iron 5; chosen Red 6, Iron 4; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 8 turns, Iron iron.ancestor.firstpack / 7 turns
Ancestor value: First Hunter +4, Grandmother healed 2, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 6, Iron 9
Blocks: Red 3/5 chosen, Iron 3/5 chosen
Pack pressure: ready units Red 0, Iron 13; generated slots Red 0, Iron 13; skipped slots Red 0, Iron 4; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 2, Iron 0; WeaponMaster 1; SoulSlayer 2; LeopardHunter 3
Reshuffles: Red 1, Iron 1
Memory end: Red 1, Iron 2
Final battlefield: Red [Esprit du Léopard, Pale River Spirit, Spear of First Dawn, Kuma Who Wounded the Sun, Young Hunter] | Iron [Iron Hyena Champion]
Key issue: Pierce damage produced the strongest blocked-attack spillover in the batch
Observed loop: blocked Shrine attacks still leak damage through Pierce and accelerate the finish
Design meaning: Pierce is materially shaping blocked Shrine races instead of being cosmetic
Next action: review whether Pierce pressure is landing in the intended range for blocked Shrine attacks
