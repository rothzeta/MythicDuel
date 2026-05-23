# Batch Summary

Games: 500
Seeds: 123-622
Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red iron --bot-iron iron --deck-red iron-snarecraft-control --deck-iron iron-hyena-pack-pressure
Bots: Red=IronHyenaBot, Iron=IronHyenaBot
Wins: Red=97, Iron=403
Timeouts: 0
Average turns: 13.23
Sample games: 388, 134, 462, 172

WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.
- HardCastChosenWhileLegalEvolveActionExistsRed = 23
- HardCastChosenWhileLegalEvolveActionExistsIron = 27
WARNING: Hard-cast evolution cards were chosen while an evolution base existed.
- HardCastChosenWhileEvolutionBaseExistsRed = 39
- HardCastChosenWhileEvolutionBaseExistsIron = 54
WARNING: WeaponMaster Pierce was never exercised.
- WeaponMasterPierceEvents = 0
WARNING: SoulSlayer Pierce was never exercised.
- SoulSlayerPierceEvents = 0

## Sample-game digest

### Game 388 — fastest Red win
Tags: fastest Red win
Winner: iron-snarecraft-control by shrine break
Turns: 9
Seed: 388
Timeout: no
Shrines broken: Red 0, Iron 3
First Shrine damage: 3 (Seat 1/Red: 5, Seat 2/Iron: 3)
First Shrine break: 6 (Seat 1/Red: None, Seat 2/Iron: 6)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 25, Iron 6
First L2: None
First L3: None
Layer entries: Red L2 0 (hard-cast 0, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 0 (hard-cast 0, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 0
Evolve actions chosen: Red 0, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 0
Awakening flow: legal Red 0, Iron 1; chosen Red 0, Iron 1; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron iron.ancestor.smithpassedfang / 0 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 7, Iron 2
Blocks: Red 0/0 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 7, Iron 0; generated slots Red 7, Iron 0; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 0
Memory end: Red 0, Iron 0
Final battlefield: Red [Bone-Cracker Cub, Bone Spear, Bone-Cracker Cub, Iron Hyena Raider, Fang Relic] | Iron [Hyena Token, Bone Spear, Bone Spear, Pack Harrier]
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
First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 6)
First Shrine break: 5 (Seat 1/Red: 5, Seat 2/Iron: 9)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 9, Iron 10
First L2: 5
First L3: None
Layer entries: Red L2 1 (hard-cast 0, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 1 (hard-cast 0, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 2, Iron 2
Evolve actions chosen: Red 2, Iron 2
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 0
Awakening flow: legal Red 0, Iron 3; chosen Red 0, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron iron.ancestor.firstpack / 2 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 3, Iron 4
Blocks: Red 0/0 chosen, Iron 1/2 chosen
Pack pressure: ready units Red 4, Iron 4; generated slots Red 4, Iron 4; skipped slots Red 1, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 0
Memory end: Red 0, Iron 2
Final battlefield: Red [Bone Spear, Fang Relic, Iron Hyena Champion, Bone-Cracker Cub, Bone-Cracker Cub] | Iron [Bone Spear, Iron Hyena Champion, Bone Spear, Fang Relic]
Key issue: Iron closed shrine pressure before Red could stabilize
Observed loop: Iron found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 462 — highest reshuffle game
Tags: longest game; closest game; highest reshuffle game
Winner: iron-hyena-pack-pressure by shrine break
Turns: 21
Seed: 462
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 3 (Seat 1/Red: 5, Seat 2/Iron: 3)
First Shrine break: 10 (Seat 1/Red: 10, Seat 2/Iron: 11)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 6, Iron 22
First L2: 7
First L3: None
Layer entries: Red L2 1 (hard-cast 0, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 3 (hard-cast 0, evolved 3), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 4, Iron 10
Evolve actions chosen: Red 4, Iron 8
Hard-cast bypass: legal-window Red 1 / Iron 0; base-exists Red 0 / Iron 0
Awakening flow: legal Red 0, Iron 7; chosen Red 0, Iron 4; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron iron.ancestor.firstpack / 5 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 9, Iron 9
Blocks: Red 0/2 chosen, Iron 5/8 chosen
Pack pressure: ready units Red 8, Iron 15; generated slots Red 8, Iron 14; skipped slots Red 2, Iron 6; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 0, Iron 2
Final battlefield: Red [Fang Relic, Iron Hyena Raider, Hyena Token, Hyena Token, Rust Hyena Spirit] | Iron [Black-Tooth Smith, Blood-Scent Hyena, Pack Harrier, Bone-Cracker Cub, Iron Hyena Champion]
Key issue: deck cycling outran closure and created the batch's heaviest reshuffle load
Observed loop: both decks keep recycling through retain-1 turns while shrine damage advances slowly
Design meaning: the retain-1 loop can still create long deterministic grinds when shrine pressure is low
Next action: check whether shrine pressure heuristics or loop warnings need to be tightened

### Game 172 — highest Pierce game
Tags: highest Pierce game
Winner: iron-hyena-pack-pressure by shrine break
Turns: 15
Seed: 172
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine break: 7 (Seat 1/Red: 7, Seat 2/Iron: 8)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 14, Iron 20
First L2: 6
First L3: None
Layer entries: Red L2 1 (hard-cast 0, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 2 (hard-cast 0, evolved 2), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 2, Iron 4
Evolve actions chosen: Red 2, Iron 4
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 0
Awakening flow: legal Red 0, Iron 1; chosen Red 0, Iron 1; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron iron.ancestor.firstpack / 5 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 5, Iron 7
Blocks: Red 1/2 chosen, Iron 4/10 chosen
Pack pressure: ready units Red 7, Iron 11; generated slots Red 7, Iron 11; skipped slots Red 2, Iron 4; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 2, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 1
Memory end: Red 1, Iron 0
Final battlefield: Red [Fang Relic, Black-Tooth Smith] | Iron [Fang Relic, Blood-Scent Hyena, Iron Hyena Champion, Pack Harrier, Blood-Scent Hyena, Black-Tooth Smith]
Key issue: Pierce damage produced the strongest blocked-attack spillover in the batch
Observed loop: blocked Shrine attacks still leak damage through Pierce and accelerate the finish
Design meaning: Pierce is materially shaping blocked Shrine races instead of being cosmetic
Next action: review whether Pierce pressure is landing in the intended range for blocked Shrine attacks
