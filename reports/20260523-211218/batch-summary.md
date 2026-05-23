# Batch Summary

Games: 20
Seeds: 123-142
Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 20 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red red --bot-iron iron --deck-red red --deck-iron iron
Bots: Red=RedBaobabBot, Iron=IronHyenaBot
Wins: Red=17, Iron=3
Timeouts: 0
Average turns: 28.3
Sample games: 125, 136, 132, 141

WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.
- HardCastChosenWhileLegalEvolveActionExistsRed = 10
- HardCastChosenWhileLegalEvolveActionExistsIron = 3
WARNING: Hard-cast evolution cards were chosen while an evolution base existed.
- HardCastChosenWhileEvolutionBaseExistsRed = 112
- HardCastChosenWhileEvolutionBaseExistsIron = 23
WARNING: WeaponMaster Pierce was never exercised.
- WeaponMasterPierceEvents = 0
WARNING: SoulSlayer Pierce was never exercised.
- SoulSlayerPierceEvents = 0
WARNING: Game exceeded 40 turns.

## Sample-game digest

### Game 125 — fastest Red win
Tags: fastest Red win
Winner: red by shrine break
Turns: 19
Seed: 125
Timeout: no
Shrines broken: Red 1, Iron 3
First Shrine damage: 4
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
Final battlefield: Red [Pale River Spirit, Leopard Hunter, Leopard Hunter, Spear of First Dawn, Esprit du Léopard] | Iron [Bone Spear, Bone-Cracker Cub, Black-Tooth Smith, Hyena Token, Hyena Token, Iron Hyena Champion]
Key issue: Red converted shrine pressure before Iron could race back
Observed loop: Red found the cleaner pressure line and ended the game quickly
Design meaning: this sample is a good representative tempo check for the current bot matchup
Next action: use this sample as a quick replay anchor before diving into the full game log

### Game 136 — first L3 game
Tags: fastest Iron win; first L3 game
Winner: iron by shrine break
Turns: 21
Seed: 136
Timeout: no
Shrines broken: Red 3, Iron 0
First Shrine damage: 4
First Shrine break: 5
First L2: 9
First L3: 14
Layer entries: Red L2 3 (hard-cast 3, evolved 0), Red L3 1 (hard-cast 0, evolved 1); Iron L2 0 (hard-cast 0, evolved 0), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 2, Iron 0
Evolve actions chosen: Red 2, Iron 0
Hard-cast bypass: legal-window Red 0 / Iron 0; base-exists Red 7 / Iron 1
Awakening flow: legal Red 11, Iron 4; chosen Red 5, Iron 3; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 7 turns, Iron iron.ancestor.hyena / 8 turns
Ancestor value: First Hunter +1, Grandmother healed 1, Child triggers 0, Iron Hyena +3, Smith saved 0, Tooth-Mother +0
Shrine attacks: Red 1, Iron 10
Blocks: Red 4/4 chosen, Iron 0/0 chosen
Pack pressure: ready units Red 0, Iron 9; generated slots Red 0, Iron 9; skipped slots Red 0, Iron 9; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 1, Iron 1
Memory end: Red 1, Iron 3
Final battlefield: Red [Young Hunter, River Hunter] | Iron [Fang Relic, Bone-Cracker Cub, Iron Hyena Raider, Bone Spear]
Key issue: the batch reached L3 here earlier than anywhere else
Observed loop: an L2 path opened, then converted into the earliest L3 spike in the batch
Design meaning: the full evolution ladder is reachable and worth surfacing in batch diagnostics
Next action: use this sample to verify that L2-to-L3 sequencing matches the intended deed model

### Game 132 — highest reshuffle game
Tags: longest game; closest game; highest reshuffle game
Winner: red by shrine break
Turns: 46
Seed: 132
Timeout: no
Shrines broken: Red 2, Iron 3
First Shrine damage: 4
First Shrine break: 7
First L2: 5
First L3: 14
Layer entries: Red L2 7 (hard-cast 2, evolved 5), Red L3 1 (hard-cast 0, evolved 1); Iron L2 5 (hard-cast 2, evolved 3), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 26, Iron 8
Evolve actions chosen: Red 22, Iron 8
Hard-cast bypass: legal-window Red 3 / Iron 1; base-exists Red 2 / Iron 0
Awakening flow: legal Red 41, Iron 2; chosen Red 17, Iron 2; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 20 turns, Iron iron.ancestor.hyena / 20 turns
Ancestor value: First Hunter +7, Grandmother healed 5, Child triggers 0, Iron Hyena +2, Smith saved 2, Tooth-Mother +0
Shrine attacks: Red 9, Iron 10
Blocks: Red 5/5 chosen, Iron 1/2 chosen
Pack pressure: ready units Red 0, Iron 18; generated slots Red 0, Iron 18; skipped slots Red 0, Iron 18; prevented by limit Red 0, Iron 0
Pierce signal: overflow Red 0, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 4, Iron 4
Memory end: Red 1, Iron 1
Final battlefield: Red [Pale River Spirit, Baobab Guardian, Esprit du Léopard, Spear of First Dawn] | Iron [Bone-Cracker Cub, Rust Hyena Spirit]
Key issue: deck cycling outran closure and created the batch's heaviest reshuffle load
Observed loop: both decks keep recycling through retain-1 turns while shrine damage advances slowly
Design meaning: the retain-1 loop can still create long deterministic grinds when shrine pressure is low
Next action: check whether shrine pressure heuristics or loop warnings need to be tightened

### Game 141 — highest Pierce game
Tags: highest Pierce game
Winner: red by shrine break
Turns: 38
Seed: 141
Timeout: no
Shrines broken: Red 1, Iron 3
First Shrine damage: 5
First Shrine break: 16
First L2: 11
First L3: 16
Layer entries: Red L2 4 (hard-cast 2, evolved 2), Red L3 1 (hard-cast 0, evolved 1); Iron L2 2 (hard-cast 1, evolved 1), Iron L3 0 (hard-cast 0, evolved 0)
Legal evolve actions: Red 8, Iron 8
Evolve actions chosen: Red 8, Iron 4
Hard-cast bypass: legal-window Red 1 / Iron 0; base-exists Red 7 / Iron 0
Awakening flow: legal Red 40, Iron 5; chosen Red 13, Iron 3; skipped Red 0, Iron 0
Awakened ancestors: Red red.ancestor.firsthunter / 14 turns, Iron iron.ancestor.hyena / 9 turns
Ancestor value: First Hunter +6, Grandmother healed 4, Child triggers 0, Iron Hyena +2, Smith saved 2, Tooth-Mother +0
Shrine attacks: Red 6, Iron 13
Blocks: Red 8/11 chosen, Iron 1/1 chosen
Pack pressure: ready units Red 0, Iron 6; generated slots Red 0, Iron 6; skipped slots Red 0, Iron 5; prevented by limit Red 0, Iron 1
Pierce signal: overflow Red 1, Iron 0; WeaponMaster 0; SoulSlayer 0; LeopardHunter 0
Reshuffles: Red 3, Iron 2
Memory end: Red 3, Iron 1
Final battlefield: Red [Leopard Hunter, Young Hunter, River Hunter, Esprit du Léopard] | Iron [Fang Relic, Black-Tooth Smith, Iron Hyena Champion]
Key issue: Pierce damage produced the strongest blocked-attack spillover in the batch
Observed loop: blocked Shrine attacks still leak damage through Pierce and accelerate the finish
Design meaning: Pierce is materially shaping blocked Shrine races instead of being cosmetic
Next action: review whether Pierce pressure is landing in the intended range for blocked Shrine attacks
