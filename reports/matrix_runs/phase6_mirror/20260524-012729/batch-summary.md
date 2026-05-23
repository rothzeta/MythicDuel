# Batch Summary

Games: 500
Seeds: 123-622
Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports\matrix_runs\phase6_mirror --bot-red iron --bot-iron iron --deck-red iron-hyena-pack-pressure --deck-iron iron-hyena-pack-pressure --rules phase-length-6
Bots: Red=IronHyenaBot, Iron=IronHyenaBot
Wins: Red=247, Iron=253
Timeouts: 0
Average turns: 12.6
Sample games: 178, 134, 340, 187

WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.
- HardCastChosenWhileLegalEvolveActionExistsRed = 27
- HardCastChosenWhileLegalEvolveActionExistsIron = 18
WARNING: Hard-cast evolution cards were chosen while an evolution base existed.
- HardCastChosenWhileEvolutionBaseExistsRed = 45
- HardCastChosenWhileEvolutionBaseExistsIron = 45
WARNING: WeaponMaster Pierce was never exercised.
- WeaponMasterPierceEvents = 0
WARNING: SoulSlayer Pierce was never exercised.
- SoulSlayerPierceEvents = 0

## Sample-game digest

### Game 178 — fastest Red win
Tags: fastest Red win
Winner: iron-hyena-pack-pressure by shrine break
Turns: 10
Seed: 178
Timeout: no
Shrines broken: Red 2, Iron 3
First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine break: 5 (Seat 1/Red: 6, Seat 2/Iron: 5)
Wins in odd phase: 0
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 0, Iron 12
First L2: 10
First L3: None
Layer entries: Red L2 1 (hard-cast 0, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 0 (hard-cast 0, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 6, Iron 0
Evolve actions chosen: Red 3, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 0
Awakening flow: legal Red 0, Iron 2; chosen Red 0, Iron 1; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron iron.ancestor.firstpack / 2 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 10, Iron 6
Blocks: Red 0/0 chosen, Iron 1/12 chosen
Pack pressure: ready units Red 10, Iron 7; generated slots Red 10, Iron 7; skipped slots Red 0, Iron 2; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 0
Memory end: Red 1, Iron 1
Final battlefield: Red [Pack Harrier, Bone-Cracker Cub, Bone Spear, Fang Relic, Iron Hyena Champion] | Iron [Bone-Cracker Cub, Bone Spear, Pack Harrier, Hyena Token, Pack Harrier]
Key issue: Red converted shrine pressure before Iron could race back
Observed loop: Red found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 134 — fastest Iron win
Tags: fastest Iron win
Winner: iron-hyena-pack-pressure by shrine break
Turns: 9
Seed: 134
Timeout: no
Shrines broken: Red 3, Iron 0
First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine break: 6 (Seat 1/Red: 6, Seat 2/Iron: None)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 0, Iron 14
First L2: 6
First L3: None
Layer entries: Red L2 0 (hard-cast 0, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 1 (hard-cast 0, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 2
Evolve actions chosen: Red 0, Iron 2
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 0
Awakening flow: legal Red 0, Iron 3; chosen Red 0, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron iron.ancestor.firstpack / 2 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 2, Iron 4
Blocks: Red 0/0 chosen, Iron 0/2 chosen
Pack pressure: ready units Red 2, Iron 4; generated slots Red 2, Iron 4; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 0
Memory end: Red 0, Iron 2
Final battlefield: Red [Pack Harrier, Pack Harrier, Hyena Token, Hyena Token, Bone-Cracker Cub] | Iron [Hyena Token, Bone Spear, Iron Hyena Champion, Bone Spear, Fang Relic]
Key issue: Iron closed shrine pressure before Red could stabilize
Observed loop: Iron found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 340 — highest reshuffle game
Tags: longest game; closest game; highest reshuffle game
Winner: iron-hyena-pack-pressure by shrine break
Turns: 18
Seed: 340
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine break: 9 (Seat 1/Red: 9, Seat 2/Iron: 12)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 12, Iron 6
First L2: 5
First L3: None
Layer entries: Red L2 1 (hard-cast 0, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 3 (hard-cast 0, evolved 3), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 2, Iron 8
Evolve actions chosen: Red 2, Iron 8
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 1
Awakening flow: legal Red 0, Iron 2; chosen Red 0, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron iron.ancestor.smithpassedfang / 4 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 1, Tooth-Mother +0
Shrine attacks: Red 10, Iron 8
Blocks: Red 2/7 chosen, Iron 2/9 chosen
Pack pressure: ready units Red 12, Iron 15; generated slots Red 11, Iron 14; skipped slots Red 4, Iron 7; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 1, Iron 0
Final battlefield: Red [Bone Spear, Iron Hyena Raider, Bone-Cracker Cub, Bone-Cracker Cub, Iron Hyena Raider, Black-Tooth Smith] | Iron [Bone Spear, Fang Relic, Blood-Scent Hyena, Iron Hyena Champion, Iron Hyena Champion, Hyena Token, Fang Relic]
Key issue: deck cycling outran closure and created the batch's heaviest reshuffle load
Observed loop: both decks keep recycling through retain-1 turns while shrine damage advances slowly
Design meaning: the retain-1 loop can still create long deterministic grinds when shrine pressure is low
Next action: check whether shrine pressure heuristics or loop warnings need to be tightened

### Game 187 — highest Pierce game
Tags: highest Pierce game
Winner: iron-hyena-pack-pressure by shrine break
Turns: 15
Seed: 187
Timeout: no
Shrines broken: Red 2, Iron 3
First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine break: 7 (Seat 1/Red: 7, Seat 2/Iron: 8)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 8, Iron 9
First L2: 11
First L3: None
Layer entries: Red L2 0 (hard-cast 0, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 1 (hard-cast 0, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 4
Evolve actions chosen: Red 0, Iron 3
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 0
Awakening flow: legal Red 0, Iron 7; chosen Red 0, Iron 4; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron iron.ancestor.firstpack / 4 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 11, Iron 7
Blocks: Red 2/13 chosen, Iron 2/11 chosen
Pack pressure: ready units Red 10, Iron 9; generated slots Red 10, Iron 9; skipped slots Red 4, Iron 3; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 1, Iron 1; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 0
Memory end: Red 1, Iron 3
Final battlefield: Red [Fang Relic, Blood-Scent Hyena, Bone Spear, Bone Spear, Black-Tooth Smith, Bone-Cracker Cub, Iron Hyena Raider, Pack Harrier] | Iron [Fang Relic, Fang Relic, Bone Spear, Bone Spear, Iron Hyena Raider, Iron Hyena Champion, Hyena Token, Iron Hyena Raider, Black-Tooth Smith]
Key issue: Pierce damage produced the strongest blocked-attack spillover in the batch
Observed loop: blocked Shrine attacks still leak damage through Pierce and accelerate the finish
Design meaning: Pierce is materially shaping blocked Shrine races instead of being cosmetic
Next action: review whether Pierce pressure is landing in the intended range for blocked Shrine attacks
