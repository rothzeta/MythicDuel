# Test Game #124

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 20 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red red --bot-iron iron --deck-red red --deck-iron iron

Seat 1:
- red [Red] (RedBaobabBot)
Seat 2:
- iron [Iron] (IronHyenaBot)

Rules variant:
- Draw model: retain up to 1, discard rest, draw to 5
- Phase model: reverse every 4 player-turns
- Combat model: 2 standard Assault slots, plus Pack expansion up to 5 total attacks, separate resolution
- Battlefield capacity: 5 Presence per seat
- Prepared model: max 1 active tactic per player
- Special mechanics: Fade, Forgotten, Wounded, Pierce, Disperse, Possession, Evolution, Recall, Unique, Pack

Seed: 124
Winner: iron
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Baobab Guardian, Esprit du Léopard, Ritual of Red Moon, River Hunter, Spear of First Dawn
- Starting hands — Iron: Bite the Roots, Black-Tooth Smith, Black-Tooth Smith, Bone-Cracker Cub, False Opening
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the Iron Hyena, Tooth-Mother of the Dry Earth, Smith of Black Teeth

## Turn 1 — Red

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Baobab Guardian, Esprit du Léopard, Ritual of Red Moon, River Hunter, Spear of First Dawn]

Board at start:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- pass

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: River Hunter
- discarded cards: Baobab Guardian, Ritual of Red Moon, Spear of First Dawn, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: 

## Turn 2 — Iron

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Bite the Roots, Black-Tooth Smith, Black-Tooth Smith, Bone-Cracker Cub, False Opening]

Board at start:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bite the Roots
- discarded cards: Black-Tooth Smith, Black-Tooth Smith, False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 3 — Red

Resources at start:
Offerings: 1
Memory: 0

Hand at start: [River Hunter]

Board at start:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played River Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Young Hunter, Pale River Spirit, Young Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: River Hunter

## Turn 4 — Iron

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Bite the Roots]

Board at start:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 4.
- Result: Bone-Cracker Cub survives, Hunter’s Root-Stone at 3/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Snare, Rust Hyena Spirit, False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

# End of Phase 1 Summary

Shrine damage: Red [Shrine of the Red Baobab 10/10, Hunter’s Root-Stone 10/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 0/10, Bone-Fang Shrine 7/10, Rusted Moon Shrine 0/10]
Resources: Red 3/0 | Iron 3/1
Awakened Ancestors: Red red.ancestor.firsthunter | Iron iron.ancestor.hyena
Forgotten cards: Red 4 | Iron 4
Key events: Gained 1 Memory (Iron Hyena Den triggered.). | Black-Tooth Smith retained. | Iron Snare discarded at end step. | Rust Hyena Spirit discarded at end step. | False Opening discarded at end step. | Turn 4 ended for iron.
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Resources at start:
Offerings: 0
Memory: 1

Hand at start: [Black-Tooth Smith]

Board at start:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Black-Tooth Smith, Rust Hyena Spirit, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 2 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 6 — Red

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Leopard Hunter]

Board at start:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: attached Spear of First Dawn to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to River Hunter. | River Hunter deals 4 to Bone-Cracker Cub.
- Result: River Hunter left battle, Bone-Cracker Cub removed

Main 2:
- Main 2: resolved Offering of Milk and Ash
- Main 2: awakened First Hunter

End:
- retained card: Pale River Spirit
- discarded cards: Leopard Hunter, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
- board at end: Spear of First Dawn

## Turn 7 — Iron

Resources at start:
Offerings: 1
Memory: 2

Hand at start: [Fang Relic]

Board at start:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Guard

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Fang Relic, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 2 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Iron Guard

## Turn 8 — Red

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Pale River Spirit]

Board at start:
Beings/Spirits: Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Offering of Milk and Ash]

Main 1:
- Main 1: resolved Ritual of Red Moon
- Main 1: played Pale River Spirit

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Hunter’s Call, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
- board at end: Pale River Spirit, Spear of First Dawn

# End of Phase 2 Summary

Shrine damage: Red [Shrine of the Red Baobab 10/10, Hunter’s Root-Stone 10/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 0/10, Bone-Fang Shrine 7/10, Rusted Moon Shrine 0/10]
Resources: Red 3/0 | Iron 3/1
Awakened Ancestors: Red red.ancestor.firsthunter | Iron iron.ancestor.hyena
Forgotten cards: Red 4 | Iron 4
Key events: Spent 2 Offerings on Pale River Spirit. | Pale River Spirit entered the battlefield. | Kuma Who Wounded the Sun retained. | Hunter’s Call discarded at end step. | Root-Woven Guard discarded at end step. | Turn 8 ended for red.
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Kuma Who Wounded the Sun]

Board at start:
Beings/Spirits: Pale River Spirit, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: Pale River Spirit
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to Pale River Spirit. | Pale River Spirit deals 2 to Bone-Cracker Cub.
- Result: Pale River Spirit left battle, Bone-Cracker Cub removed

Main 2:
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Offering of Milk and Ash, Baobab Guardian, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 2 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, Spear of First Dawn

## Turn 10 — Iron

Resources at start:
Offerings: 1
Memory: 2

Hand at start: [Bone Spear]

Board at start:
Beings/Spirits: Iron Guard [Wounded]
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: prepared Iron Snare
- Main 1: attached Bone Spear to Iron Guard

Combat:

Attack 1:
- Attacker: Iron Guard
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Guard from 3 to 2. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Iron Guard. | Iron Guard deals 2 to Leopard Hunter.
- Result: Iron Guard left battle, Leopard Hunter survives, Moonlit Roots at 10/10

Main 2:
- Main 2: played Iron Hyena Raider
- Main 2: awakened Smith of Black Teeth

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Hyena Raider

## Turn 11 — Red

Resources at start:
Offerings: 0
Memory: 2

Hand at start: [Kuma Who Wounded the Sun]

Board at start:
Beings/Spirits: Leopard Hunter [Wounded], Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 5 to 3. | Wounded reduces Leopard Hunter from 5 to 3.
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 7/10

Main 2:
- Main 2: prepared Hunter’s Call
- Main 2: awakened Child Who Remembered the Dead

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Deep River Spirit
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 2 Offerings / 0 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, River Hunter, Spear of First Dawn, Young Hunter

## Turn 12 — Iron

Resources at start:
Offerings: 1
Memory: 0

Hand at start: [Iron Hyena Underworld]

Board at start:
Beings/Spirits: Bone Spear, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Raider
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 4.
- Result: Iron Hyena Raider survives, Moonlit Roots at 6/10

Main 2:
- Main 2: played Iron Hyena Raider

End:
- retained card: Iron Hyena Underworld
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider, Iron Hyena Raider [Relic:Fang Relic]

# End of Phase 3 Summary

Shrine damage: Red [Shrine of the Red Baobab 10/10, Hunter’s Root-Stone 10/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 0/10, Bone-Fang Shrine 7/10, Rusted Moon Shrine 0/10]
Resources: Red 3/0 | Iron 3/1
Awakened Ancestors: Red red.ancestor.firsthunter | Iron iron.ancestor.hyena
Forgotten cards: Red 4 | Iron 4
Key events: Iron Hyena Raider entered the battlefield. | Hunter’s Call expired. | Hunter’s Call moved to Forgotten (prepared tactic expired). | Iron Hyena Underworld retained. | Hyena Pack Call discarded at end step. | Turn 12 ended for iron.
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Resources at start:
Offerings: 2
Memory: 1

Hand at start: [Iron Hyena Underworld]

Board at start:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider, Iron Hyena Raider [Relic:Fang Relic]
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: evolved Iron Hyena Raider into Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 4.
- Result: Bone-Cracker Cub survives, Moonlit Roots at 0/10

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: awakened Ancestor of the Iron Hyena

End:
- retained card: Bone Spear
- discarded cards: Iron Hyena Underworld, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Iron Hyena Champion [Relic:Fang Relic], Iron Hyena Raider

## Turn 14 — Red

Resources at start:
Offerings: 2
Memory: 0

Hand at start: [Kuma Who Wounded the Sun]

Board at start:
Beings/Spirits: Leopard Hunter, River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Child Who Remembered the Dead
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 3 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: resolved Ritual of Red Moon

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Iron Hyena Raider deals 3 to Leopard Hunter. | Leopard Hunter deals 4 to Iron Hyena Raider. | Shrine Bone-Fang Shrine takes 4.
- Result: Leopard Hunter survives, Iron Hyena Raider removed, Bone-Fang Shrine at 3/10

Attack 2:
- Attacker: River Hunter
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 6 to 4.
- Damage: Iron Hyena Champion deals 4 to River Hunter. | River Hunter deals 3 to Iron Hyena Champion.
- Result: River Hunter left battle, Iron Hyena Champion removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Deep River Spirit, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: Leopard Hunter [Wounded], River Hunter, Spear of First Dawn, Young Hunter

## Turn 15 — Iron

Resources at start:
Offerings: 3
Memory: 0

Hand at start: [Bone Spear]

Board at start:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion
- Main 1: resolved Bite the Roots

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Shrine of the Red Baobab
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Young Hunter deals 2 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to Young Hunter. | Shrine Shrine of the Red Baobab takes 4.
- Result: Bone-Cracker Cub left battle, Young Hunter removed, Shrine of the Red Baobab at 0/10

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Rust Hyena Spirit, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Fang Relic, Iron Hyena Champion

## End-of-game summary

Winner: iron
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Shrine of the Red Baobab 10/10, Hunter’s Root-Stone 10/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 0/10, Bone-Fang Shrine 7/10, Rusted Moon Shrine 0/10]
Final resources: Red 3/0 | Iron 3/1
Final Presence: Seat 1 2/5 | Seat 2 1/5

Turn count: 15
Phase count: 4

First Shrine damage: 4
First Shrine broken: 13
First Ancestor awakened: 6
First L2: 9
First L3: 

Red L2 entries: 1 (hard-cast 1, evolved 0)
Red L3 entries: 0 (hard-cast 0, evolved 0, recalled 0)
Iron L2 entries: 2 (hard-cast 0, evolved 2)
Iron L3 entries: 0 (hard-cast 0, evolved 0, recalled 0)

Legal evolve actions generated: Red 0, Iron 4
Legal L2 evolve actions: Red 0, Iron 4
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 0, Iron 4
Turns with legal L2 evolution: Red 0, Iron 4
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 0, Iron 3
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 0, Iron 0

Legal awaken actions generated: Red 9, Iron 2
Awaken actions chosen: Red 4, Iron 2
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.firsthunter, Iron iron.ancestor.smith
Ancestor switches: Red 2, Iron 1
Turns with awakened ancestor: Red 4, Iron 3
Memory spent on ancestors: Red 6, Iron 4
Ancestor realized value: First Hunter +2 damage, Grandmother healed 0, Child draw/discard 1, Iron Hyena +1 damage, Smith saved 1 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 1
Prepared Tactics expired: Red 1, Iron 0
Fade cards Forgotten: Red 4, Iron 4
Wounded events: Red 2, Iron 2
Wounded reduced damage: Red 2, Iron 2
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 2, Iron 2
Blocks chosen: Red 2, Iron 1
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 5, pack 0 | Seat 2 standard 5, pack 0
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 14, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 8, generated 8, available 8, skipped 8, turns-with-bonus 5, max-attacks 24, prevented-by-limit 0
Deck reshuffles: Red 1, Iron 1

Analysis:
- What felt good: deterministic event log and reproducible combat flow.
- What felt bad / slow: simple bots can overcommit and miss better sequencing.
- Combat findings: Wounded and Pierce materially change blocked Shrine races.
- Shrine pressure findings: Iron pushes damage faster while Red stabilizes with restoration.
- Memory findings: Spirit dispersal and shrine triggers strongly influence evolution windows.
- Evolution findings: L2/L3 timings are highly deed-dependent.
- Phase / initiative findings: the reversal rule changes who gets the momentum swing.
- Card balance notes: generated from current deterministic bots only.
- Rule changes to test next: tweak shrine damage pacing, Memory generation, and Prepared timing.
