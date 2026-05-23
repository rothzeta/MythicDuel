# Batch Summary

Games: 100
Seeds: 123-222
Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 100 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red passive --bot-iron iron --deck-red passive --deck-iron iron-hyena-pack-pressure
Bots: Red=PassiveBot, Iron=IronHyenaBot
Wins: Red=0, Iron=100
Timeouts: 0
Average turns: 16.74
Sample games: 126, 125, 150

WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.
- HardCastChosenWhileLegalEvolveActionExistsRed = 0
- HardCastChosenWhileLegalEvolveActionExistsIron = 11
WARNING: Hard-cast evolution cards were chosen while an evolution base existed.
- HardCastChosenWhileEvolutionBaseExistsRed = 283
- HardCastChosenWhileEvolutionBaseExistsIron = 35
WARNING: WeaponMaster Pierce was never exercised.
- WeaponMasterPierceEvents = 0
WARNING: SoulSlayer Pierce was never exercised.
- SoulSlayerPierceEvents = 0
WARNING: Game exceeded 40 turns.

## Sample-game digest

### Game 126 — fastest Iron win
Tags: fastest Iron win
Winner: iron-hyena-pack-pressure by shrine break
Turns: 10
Seed: 126
Timeout: no
Shrines broken: Red 3, Iron 0
First Shrine damage: 4
First Shrine break: 5
First L2: 10
First L3: None
Layer entries: Red L2 0 (hard-cast 0, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 1 (hard-cast 0, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 6
Evolve actions chosen: Red 0, Iron 2
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 0 / Iron 0
Awakening flow: legal Red 0, Iron 3; chosen Red 0, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red None / 0 turns, Iron iron.ancestor.firstpack / 2 turns
Ancestor value: First Hunter +0, Grandmother healed 0, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 0, Iron 9
Blocks: Red 0/9 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 6; generated slots Red 0, Iron 6; skipped slots Red 0, Iron 1; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 0, Iron 0
Memory end: Red 0, Iron 2
Final battlefield: Red [River Hunter, Young Hunter, Spear of First Dawn, Young Hunter, Spear of First Dawn] | Iron [Hyena Token, Pack Harrier, Fang Relic, Bone-Cracker Cub, Fang Relic, Iron Hyena Champion]
Key issue: Iron closed shrine pressure before Red could stabilize
Observed loop: Iron found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 125 — highest reshuffle game
Tags: longest game; closest game; highest reshuffle game
Winner: iron-hyena-pack-pressure by shrine break
Turns: 45
Seed: 125
Timeout: no
Shrines broken: Red 3, Iron 0
First Shrine damage: 4
First Shrine break: 34
First L2: 9
First L3: None
Layer entries: Red L2 7 (hard-cast 7, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 4 (hard-cast 2, evolved 2), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 8
Evolve actions chosen: Red 0, Iron 8
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 11 / Iron 2
Awakening flow: legal Red 30, Iron 10; chosen Red 12, Iron 7; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.grandmother / 15 turns, Iron iron.ancestor.firstpack / 11 turns
Ancestor value: First Hunter +0, Grandmother healed 8, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 0, Iron 19
Blocks: Red 7/55 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 48; generated slots Red 0, Iron 43; skipped slots Red 0, Iron 8; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 4, Iron 4
Memory end: Red 5, Iron 4
Final battlefield: Red [Spear of First Dawn, Pale River Spirit, Young Hunter, Pale River Spirit] | Iron [Bone Spear, Fang Relic, Fang Relic, Bone-Cracker Cub, Iron Hyena Champion, Blood-Scent Hyena, Blood-Scent Hyena]
Key issue: deck cycling outran closure and created the batch's heaviest reshuffle load
Observed loop: both decks keep recycling through retain-1 turns while shrine damage advances slowly
Design meaning: the retain-1 loop can still create long deterministic grinds when shrine pressure is low
Next action: check whether shrine pressure heuristics or loop warnings need to be tightened

### Game 150 — highest Pierce game
Tags: highest Pierce game
Winner: iron-hyena-pack-pressure by shrine break
Turns: 21
Seed: 150
Timeout: no
Shrines broken: Red 3, Iron 0
First Shrine damage: 4
First Shrine break: 13
First L2: 9
First L3: None
Layer entries: Red L2 2 (hard-cast 2, evolved 0), Red L3 0 (hard-cast 0, evolved 0); Iron L2 2 (hard-cast 0, evolved 2), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 0, Iron 6
Evolve actions chosen: Red 0, Iron 6
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 2 / Iron 0
Awakening flow: legal Red 3, Iron 8; chosen Red 1, Iron 4; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.grandmother / 3 turns, Iron iron.ancestor.firstpack / 4 turns
Ancestor value: First Hunter +0, Grandmother healed 2, Child triggers 0, Iron Hyena +0, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 0, Iron 13
Blocks: Red 4/11 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 19; generated slots Red 0, Iron 19; skipped slots Red 0, Iron 6; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 1; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 1, Iron 3
Final battlefield: Red [None] | Iron [Fang Relic, Hyena Token, Bone Spear, Bone Spear, Black-Tooth Smith, Pack Harrier, Iron Hyena Champion]
Key issue: Pierce damage produced the strongest blocked-attack spillover in the batch
Observed loop: blocked Shrine attacks still leak damage through Pierce and accelerate the finish
Design meaning: Pierce is materially shaping blocked Shrine races instead of being cosmetic
Next action: review whether Pierce pressure is landing in the intended range for blocked Shrine attacks
