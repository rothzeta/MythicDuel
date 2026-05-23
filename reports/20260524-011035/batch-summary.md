# Batch Summary

Games: 500
Seeds: 123-622
Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red iron --bot-iron iron --deck-red iron-hyena-pack-pressure --deck-iron iron-snarecraft-control
Bots: Red=IronHyenaBot, Iron=IronHyenaBot
Wins: Red=304, Iron=196
Timeouts: 0
Average turns: 13.22
Sample games: 133, 280, 211, 560, 191

WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.
- HardCastChosenWhileLegalEvolveActionExistsRed = 32
- HardCastChosenWhileLegalEvolveActionExistsIron = 20
WARNING: Hard-cast evolution cards were chosen while an evolution base existed.
- HardCastChosenWhileEvolutionBaseExistsRed = 59
- HardCastChosenWhileEvolutionBaseExistsIron = 42
WARNING: WeaponMaster Pierce was never exercised.
- WeaponMasterPierceEvents = 0
WARNING: SoulSlayer Pierce was never exercised.
- SoulSlayerPierceEvents = 0

## Sample-game digest

### Game 133 — fastest Red win
Tags: fastest Red win
Winner: iron-hyena-pack-pressure by shrine break
Turns: 9
Seed: 133
Timeout: no
Shrines broken: Red 0, Iron 3
First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine break: 6 (Seat 1/Red: None, Seat 2/Iron: 6)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 20, Iron 6
First L2: None
First L3: None
Layer entries: Red L2 0 (hard-cast 0, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 0 (hard-cast 0, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 0
Evolve actions chosen: Red 0, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 0
Awakening flow: legal Red 0, Iron 0; chosen Red 0, Iron 0; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron None / 0 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 6, Iron 1
Blocks: Red 0/0 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 7, Iron 1; generated slots Red 7, Iron 1; skipped slots Red 1, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 0
Memory end: Red 0, Iron 1
Final battlefield: Red [Bone-Cracker Cub, Fang Relic, Pack Harrier, Blood-Scent Hyena, Hyena Token, Fang Relic] | Iron [Bone-Cracker Cub, Bone-Cracker Cub, Black-Tooth Smith]
Key issue: Red converted shrine pressure before Iron could race back
Observed loop: Red found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 280 — fastest Iron win
Tags: fastest Iron win
Winner: iron-snarecraft-control by shrine break
Turns: 10
Seed: 280
Timeout: no
Shrines broken: Red 3, Iron 1
First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 6)
First Shrine break: 5 (Seat 1/Red: 5, Seat 2/Iron: 8)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 11, Iron 12
First L2: 9
First L3: None
Layer entries: Red L2 1 (hard-cast 0, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 0 (hard-cast 0, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 2, Iron 0
Evolve actions chosen: Red 2, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 0
Awakening flow: legal Red 0, Iron 3; chosen Red 0, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron iron.ancestor.hyena / 2 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +2, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 4, Iron 6
Blocks: Red 0/2 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 4, Iron 6; generated slots Red 4, Iron 6; skipped slots Red 0, Iron 0; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 0
Memory end: Red 0, Iron 2
Final battlefield: Red [Hyena Token, Bone Spear, Pack Harrier, Iron Hyena Champion, Bone-Cracker Cub] | Iron [Bone-Cracker Cub, Fang Relic, Bone-Cracker Cub, Fang Relic, Bone Spear]
Key issue: Iron closed shrine pressure before Red could stabilize
Observed loop: Iron found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 211 — highest reshuffle game
Tags: longest game; closest game; highest reshuffle game
Winner: iron-snarecraft-control by shrine break
Turns: 21
Seed: 211
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine break: 7 (Seat 1/Red: 7, Seat 2/Iron: 9)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 9, Iron 8
First L2: 10
First L3: None
Layer entries: Red L2 2 (hard-cast 1, evolved 1), Red L3 0 (hard-cast 0, evolved 0); Iron L2 3 (hard-cast 0, evolved 3), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 4, Iron 6
Evolve actions chosen: Red 4, Iron 6
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 1 / Iron 0
Awakening flow: legal Red 0, Iron 0; chosen Red 0, Iron 0; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron None / 0 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 5, Iron 12
Blocks: Red 6/15 chosen, Iron 1/2 chosen
Pack pressure: ready units Red 18, Iron 8; generated slots Red 15, Iron 8; skipped slots Red 4, Iron 3; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 0, Iron 1
Final battlefield: Red [Fang Relic, Fang Relic] | Iron [Iron Guard, Rust Hyena Spirit, Fang Relic, Black-Tooth Smith, Iron Hyena Champion, Iron Hyena Raider]
Key issue: deck cycling outran closure and created the batch's heaviest reshuffle load
Observed loop: both decks keep recycling through retain-1 turns while shrine damage advances slowly
Design meaning: the retain-1 loop can still create long deterministic grinds when shrine pressure is low
Next action: check whether shrine pressure heuristics or loop warnings need to be tightened

### Game 560 — first L3 game
Tags: first L3 game
Winner: iron-snarecraft-control by shrine break
Turns: 15
Seed: 560
Timeout: no
Shrines broken: Red 3, Iron 2
First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine break: 7 (Seat 1/Red: 7, Seat 2/Iron: 8)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 7, Iron 23
First L2: 5
First L3: 10
Layer entries: Red L2 0 (hard-cast 0, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 1 (hard-cast 0, evolved 1), Iron L3 1 (hard-cast 0, evolved 1)
Legal evolve actions: Red 0, Iron 4
Evolve actions chosen: Red 0, Iron 3
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 0
Awakening flow: legal Red 0, Iron 0; chosen Red 0, Iron 0; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron None / 0 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 5, Iron 5
Blocks: Red 3/8 chosen, Iron 1/4 chosen
Pack pressure: ready units Red 7, Iron 4; generated slots Red 7, Iron 4; skipped slots Red 2, Iron 3; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 1; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 1
Memory end: Red 0, Iron 1
Final battlefield: Red [Bone Spear, Bone-Cracker Cub] | Iron [Bone Spear, Iron Guard, Bone-Cracker Cub, Bone Spear]
Key issue: the batch reached L3 here earlier than anywhere else
Observed loop: an L2 path opened, then converted into the earliest L3 spike in the batch
Design meaning: the full evolution ladder is reachable and worth surfacing in batch diagnostics
Next action: use this sample to verify that L2-to-L3 sequencing matches the intended deed model

### Game 191 — highest Pierce game
Tags: highest Pierce game
Winner: iron-hyena-pack-pressure by shrine break
Turns: 16
Seed: 191
Timeout: no
Shrines broken: Red 2, Iron 3
First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine break: 8 (Seat 1/Red: 10, Seat 2/Iron: 8)
Wins in odd phase: 0
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 15, Iron 16
First L2: 6
First L3: None
Layer entries: Red L2 2 (hard-cast 0, evolved 2), Red L3 0 (hard-cast 0, evolved 0); Iron L2 1 (hard-cast 0, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 4, Iron 2
Evolve actions chosen: Red 4, Iron 2
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 2 / Iron 0
Awakening flow: legal Red 0, Iron 0; chosen Red 0, Iron 0; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron None / 0 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 6, Iron 7
Blocks: Red 4/16 chosen, Iron 1/2 chosen
Pack pressure: ready units Red 14, Iron 9; generated slots Red 13, Iron 8; skipped slots Red 7, Iron 2; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 1, Iron 1; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 0, Iron 0
Final battlefield: Red [Iron Hyena Champion, Hyena Token, Bone Spear, Bone Spear, Blood-Scent Hyena, Blood-Scent Hyena, Pack Harrier] | Iron [Bone Spear, Iron Hyena Champion, Bone-Cracker Cub, Rust Hyena Spirit]
Key issue: Pierce damage produced the strongest blocked-attack spillover in the batch
Observed loop: blocked Shrine attacks still leak damage through Pierce and accelerate the finish
Design meaning: Pierce is materially shaping blocked Shrine races instead of being cosmetic
Next action: review whether Pierce pressure is landing in the intended range for blocked Shrine attacks
