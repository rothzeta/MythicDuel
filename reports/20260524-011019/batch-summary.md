# Batch Summary

Games: 500
Seeds: 123-622
Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red iron --bot-iron iron --deck-red iron-hyena-pack-pressure --deck-iron iron-hyena-pack-pressure
Bots: Red=IronHyenaBot, Iron=IronHyenaBot
Wins: Red=156, Iron=344
Timeouts: 0
Average turns: 12.63
Sample games: 139, 134, 201, 425

WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.
- HardCastChosenWhileLegalEvolveActionExistsRed = 29
- HardCastChosenWhileLegalEvolveActionExistsIron = 14
WARNING: Hard-cast evolution cards were chosen while an evolution base existed.
- HardCastChosenWhileEvolutionBaseExistsRed = 52
- HardCastChosenWhileEvolutionBaseExistsIron = 32
WARNING: WeaponMaster Pierce was never exercised.
- WeaponMasterPierceEvents = 0
WARNING: SoulSlayer Pierce was never exercised.
- SoulSlayerPierceEvents = 0

## Sample-game digest

### Game 139 — fastest Red win
Tags: fastest Red win
Winner: iron-hyena-pack-pressure by shrine break
Turns: 9
Seed: 139
Timeout: no
Shrines broken: Red 0, Iron 3
First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine break: 6 (Seat 1/Red: None, Seat 2/Iron: 6)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 20, Iron 3
First L2: 9
First L3: None
Layer entries: Red L2 1 (hard-cast 0, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 0 (hard-cast 0, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 8, Iron 0
Evolve actions chosen: Red 2, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 0
Awakening flow: legal Red 0, Iron 0; chosen Red 0, Iron 0; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron None / 0 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 9, Iron 2
Blocks: Red 0/0 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 7, Iron 2; generated slots Red 7, Iron 2; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 0
Memory end: Red 0, Iron 1
Final battlefield: Red [Hyena Token, Hyena Token, Bone Spear, Iron Hyena Raider, Pack Harrier, Iron Hyena Champion] | Iron [Blood-Scent Hyena, Pack Harrier, Hyena Token, Hyena Token, Blood-Scent Hyena]
Key issue: Red converted shrine pressure before Iron could race back
Observed loop: Red found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 134 — fastest Iron win
Tags: fastest Iron win
Winner: iron-hyena-pack-pressure by shrine break
Turns: 10
Seed: 134
Timeout: no
Shrines broken: Red 3, Iron 1
First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine break: 5 (Seat 1/Red: 5, Seat 2/Iron: 9)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 7, Iron 10
First L2: 5
First L3: None
Layer entries: Red L2 0 (hard-cast 0, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 1 (hard-cast 0, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 2
Evolve actions chosen: Red 0, Iron 2
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 0
Awakening flow: legal Red 0, Iron 3; chosen Red 0, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron iron.ancestor.firstpack / 2 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 6, Iron 4
Blocks: Red 0/1 chosen, Iron 1/5 chosen
Pack pressure: ready units Red 5, Iron 4; generated slots Red 5, Iron 4; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 0
Memory end: Red 0, Iron 2
Final battlefield: Red [Pack Harrier, Pack Harrier, Hyena Token, Bone-Cracker Cub, Bone Spear] | Iron [Bone Spear, Iron Hyena Champion, Bone Spear, Fang Relic]
Key issue: Iron closed shrine pressure before Red could stabilize
Observed loop: Iron found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 201 — highest reshuffle game
Tags: longest game; closest game; highest reshuffle game
Winner: iron-hyena-pack-pressure by shrine break
Turns: 19
Seed: 201
Timeout: no
Shrines broken: Red 2, Iron 3
First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine break: 7 (Seat 1/Red: 7, Seat 2/Iron: 11)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 20, Iron 16
First L2: 5
First L3: None
Layer entries: Red L2 4 (hard-cast 1, evolved 3), Red L3 0 (hard-cast 0, evolved 0); Iron L2 3 (hard-cast 1, evolved 2), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 8, Iron 6
Evolve actions chosen: Red 8, Iron 6
Hard-cast bypass: legal-window Red 2 / Iron 1; base-exists Red 1 / Iron 0
Awakening flow: legal Red 0, Iron 2; chosen Red 0, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron iron.ancestor.smithpassedfang / 5 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 1, Tooth-Mother +0
Shrine attacks: Red 9, Iron 10
Blocks: Red 2/18 chosen, Iron 3/3 chosen
Pack pressure: ready units Red 14, Iron 12; generated slots Red 14, Iron 11; skipped slots Red 6, Iron 3; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 1, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 0, Iron 0
Final battlefield: Red [Fang Relic, Hyena Token, Bone Spear, Iron Hyena Champion, Iron Hyena Champion, Blood-Scent Hyena, Fang Relic] | Iron [Bone Spear, Hyena Token, Hyena Token, Iron Hyena Raider, Pack Harrier, Fang Relic, Iron Hyena Champion]
Key issue: deck cycling outran closure and created the batch's heaviest reshuffle load
Observed loop: both decks keep recycling through retain-1 turns while shrine damage advances slowly
Design meaning: the retain-1 loop can still create long deterministic grinds when shrine pressure is low
Next action: check whether shrine pressure heuristics or loop warnings need to be tightened

### Game 425 — highest Pierce game
Tags: highest Pierce game
Winner: iron-hyena-pack-pressure by shrine break
Turns: 15
Seed: 425
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine break: 7 (Seat 1/Red: 7, Seat 2/Iron: 11)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 4, Iron 22
First L2: 5
First L3: None
Layer entries: Red L2 2 (hard-cast 0, evolved 2), Red L3 0 (hard-cast 0, evolved 0); Iron L2 2 (hard-cast 0, evolved 2), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 4, Iron 4
Evolve actions chosen: Red 4, Iron 3
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 1 / Iron 0
Awakening flow: legal Red 0, Iron 7; chosen Red 0, Iron 4; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron iron.ancestor.firstpack / 5 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 7, Iron 9
Blocks: Red 2/13 chosen, Iron 3/7 chosen
Pack pressure: ready units Red 11, Iron 13; generated slots Red 11, Iron 12; skipped slots Red 5, Iron 4; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 2; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 1
Memory end: Red 0, Iron 3
Final battlefield: Red [Iron Hyena Raider, Iron Hyena Champion, Bone Spear, Bone-Cracker Cub] | Iron [Bone Spear, Iron Hyena Champion, Hyena Token, Fang Relic, Bone Spear, Bone-Cracker Cub, Pack Harrier, Bone-Cracker Cub]
Key issue: Pierce damage produced the strongest blocked-attack spillover in the batch
Observed loop: blocked Shrine attacks still leak damage through Pierce and accelerate the finish
Design meaning: Pierce is materially shaping blocked Shrine races instead of being cosmetic
Next action: review whether Pierce pressure is landing in the intended range for blocked Shrine attacks
