# Batch Summary

Games: 20
Seeds: 123-142
Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 20 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red red --bot-iron iron --deck-red red --deck-iron iron
Bots: Red=RedBaobabBot, Iron=IronHyenaBot
Wins: Red=10, Iron=10
Timeouts: 0
Average turns: 24.4
Sample games: 125, 124, 141, 139, 136

WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.
- HardCastChosenWhileLegalEvolveActionExistsRed = 9
- HardCastChosenWhileLegalEvolveActionExistsIron = 3
WARNING: Hard-cast evolution cards were chosen while an evolution base existed.
- HardCastChosenWhileEvolutionBaseExistsRed = 97
- HardCastChosenWhileEvolutionBaseExistsIron = 21
WARNING: WeaponMaster Pierce was never exercised.
- WeaponMasterPierceEvents = 0
WARNING: SoulSlayer Pierce was never exercised.
- SoulSlayerPierceEvents = 0

## Sample-game digest

### Game 125 — fastest Red win
Tags: fastest Red win
Winner: red by shrine break
Turns: 19
Seed: 125
Timeout: no
Shrines broken: Red 2, Iron 3
First Shrine damage: 9
First Shrine break: 13
First L2: 9
First L3: None
Layer entries: Red L2 2 (hard-cast 2, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 2 (hard-cast 2, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 0
Evolve actions chosen: Red 0, Iron 0
Hard-cast bypass: legal-window Red 1 / Iron 1; base-exists Red 7 / Iron 2
Awakening flow: legal Red 8, Iron 5; chosen Red 5, Iron 3; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 7 turns, Iron iron.ancestor.hyena / 2 turns
Ancestor value: First Hunter +6, Grandmother healed 1, Child triggers 0, Iron Hyena +2, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 8, Iron 6
Blocks: Red 2/3 chosen, Iron 1/1 chosen
Pack pressure: ready units Red 0, Iron 3; generated slots Red 0, Iron 3; skipped slots Red 0, Iron 2; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 3, Iron 2
Final battlefield: Red [Pale River Spirit, Leopard Hunter, Leopard Hunter, Spear of First Dawn, Esprit du Léopard] | Iron [Bone Spear, Fang Relic, Bone-Cracker Cub, Black-Tooth Smith, Hyena Token, Hyena Token, Iron Hyena Champion]
Key issue: Red converted shrine pressure before Iron could race back
Observed loop: Red found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 124 — fastest Iron win
Tags: fastest Iron win
Winner: iron by shrine break
Turns: 15
Seed: 124
Timeout: no
Shrines broken: Red 3, Iron 0
First Shrine damage: 4
First Shrine break: 13
First L2: 9
First L3: None
Layer entries: Red L2 1 (hard-cast 1, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 2 (hard-cast 0, evolved 2), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 4
Evolve actions chosen: Red 0, Iron 3
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 0
Awakening flow: legal Red 9, Iron 2; chosen Red 4, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 4 turns, Iron iron.ancestor.smith / 3 turns
Ancestor value: First Hunter +2, Grandmother healed 0, Child triggers 1, Iron Hyena +1, Smith saved 1, Tooth-Mother +0
Shrine attacks: Red 2, Iron 5
Blocks: Red 2/2 chosen, Iron 1/2 chosen
Pack pressure: ready units Red 0, Iron 8; generated slots Red 0, Iron 8; skipped slots Red 0, Iron 8; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 0, Iron 1
Final battlefield: Red [Spear of First Dawn, Leopard Hunter, River Hunter] | Iron [Bone Spear, Fang Relic, Iron Hyena Champion]
Key issue: Iron closed shrine pressure before Red could stabilize
Observed loop: Iron found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 141 — highest Pierce game
Tags: longest game; highest reshuffle game; highest Pierce game
Winner: red by shrine break
Turns: 38
Seed: 141
Timeout: no
Shrines broken: Red 1, Iron 3
First Shrine damage: 14
First Shrine break: 21
First L2: 11
First L3: 16
Layer entries: Red L2 4 (hard-cast 2, evolved 2), Red L3 1 (hard-cast 0, evolved 1); Iron L2 2 (hard-cast 1, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 8, Iron 8
Evolve actions chosen: Red 8, Iron 4
Hard-cast bypass: legal-window Red 1 / Iron 0; base-exists Red 7 / Iron 0
Awakening flow: legal Red 40, Iron 10; chosen Red 13, Iron 7; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 14 turns, Iron iron.ancestor.hyena / 9 turns
Ancestor value: First Hunter +6, Grandmother healed 4, Child triggers 0, Iron Hyena +4, Smith saved 2, Tooth-Mother +0
Shrine attacks: Red 6, Iron 13
Blocks: Red 8/13 chosen, Iron 1/1 chosen
Pack pressure: ready units Red 0, Iron 6; generated slots Red 0, Iron 6; skipped slots Red 0, Iron 5; prevented by limit Red 0, Iron 1
Pierce signal: overflow Red 1, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 3, Iron 2
Memory end: Red 3, Iron 1
Final battlefield: Red [Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Leopard Hunter, Leopard Hunter, Young Hunter, River Hunter, Esprit du Léopard] | Iron [Bone Spear, Fang Relic, Bone Spear, Bone Spear, Fang Relic, Bone Spear, Fang Relic, Bone Spear, Bone Spear, Black-Tooth Smith, Iron Hyena Champion]
Key issue: Pierce damage produced the strongest blocked-attack spillover in the batch
Observed loop: both decks keep recycling through retain-1 turns while shrine damage advances slowly
Design meaning: Pierce is materially shaping blocked Shrine races instead of being cosmetic
Next action: check whether shrine pressure heuristics or loop warnings need to be tightened

### Game 139 — closest game
Tags: closest game
Winner: iron by shrine break
Turns: 36
Seed: 139
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 6
First Shrine break: 13
First L2: 14
First L3: 25
Layer entries: Red L2 4 (hard-cast 2, evolved 2), Red L3 1 (hard-cast 0, evolved 1); Iron L2 2 (hard-cast 1, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 6, Iron 4
Evolve actions chosen: Red 6, Iron 4
Hard-cast bypass: legal-window Red 3 / Iron 0; base-exists Red 5 / Iron 1
Awakening flow: legal Red 29, Iron 9; chosen Red 11, Iron 5; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 14 turns, Iron iron.ancestor.hyena / 10 turns
Ancestor value: First Hunter +3, Grandmother healed 3, Child triggers 0, Iron Hyena +4, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 4, Iron 9
Blocks: Red 7/10 chosen, Iron 1/1 chosen
Pack pressure: ready units Red 0, Iron 11; generated slots Red 0, Iron 11; skipped slots Red 0, Iron 10; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 3, Iron 3
Memory end: Red 2, Iron 3
Final battlefield: Red [Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Kuma Who Wounded the Sun, Spear of First Dawn, Spear of First Dawn, Deep River Spirit, Esprit du Léopard] | Iron [Bone Spear, Fang Relic, Bone Spear, Fang Relic, Bone Spear, Fang Relic, Bone Spear]
Key issue: the shrine race stayed narrow deep into the game
Observed loop: both players stayed in the shrine race until the final momentum swing
Design meaning: the current bots can produce a genuinely contested shrine race instead of a one-sided roll
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 136 — first L3 game
Tags: first L3 game
Winner: iron by shrine break
Turns: 15
Seed: 136
Timeout: no
Shrines broken: Red 3, Iron 0
First Shrine damage: 4
First Shrine break: 5
First L2: 9
First L3: 14
Layer entries: Red L2 2 (hard-cast 2, evolved 0), Red L3 1 (hard-cast 0, evolved 1); Iron L2 0 (hard-cast 0, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 2, Iron 0
Evolve actions chosen: Red 2, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 5 / Iron 0
Awakening flow: legal Red 7, Iron 3; chosen Red 3, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 4 turns, Iron iron.ancestor.hyena / 5 turns
Ancestor value: First Hunter +1, Grandmother healed 0, Child triggers 0, Iron Hyena +2, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 1, Iron 7
Blocks: Red 3/3 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 5; generated slots Red 0, Iron 5; skipped slots Red 0, Iron 5; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 2, Iron 1
Final battlefield: Red [Spear of First Dawn] | Iron [Bone Spear, Fang Relic, Fang Relic, Bone Spear, Bone-Cracker Cub, Iron Hyena Raider]
Key issue: the batch reached L3 here earlier than anywhere else
Observed loop: an L2 path opened, then converted into the earliest L3 spike in the batch
Design meaning: the full evolution ladder is reachable and worth surfacing in batch diagnostics
Next action: use this sample to verify that L2-to-L3 sequencing matches the intended deed model
