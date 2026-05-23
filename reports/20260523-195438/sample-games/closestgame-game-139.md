# Test Game #139

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

Seed: 139
Winner: iron
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Hunter’s Call, Kuma Who Wounded the Sun, Leopard Hunter, Pale River Spirit, Ritual of Red Moon
- Starting hands — Iron: Black-Tooth Smith, Black-Tooth Smith, Fang Relic, Hyena Pack Call, Hyena Pack Call
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the Iron Hyena, Tooth-Mother of the Dry Earth, Smith of Black Teeth

## Turn 1 — Red

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Hunter’s Call, Kuma Who Wounded the Sun, Leopard Hunter, Pale River Spirit, Ritual of Red Moon]

Board at start:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: prepared Hunter’s Call

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Ritual of Red Moon
- discarded cards: Kuma Who Wounded the Sun, Pale River Spirit, Leopard Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: 

## Turn 2 — Iron

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Black-Tooth Smith, Black-Tooth Smith, Fang Relic, Hyena Pack Call, Hyena Pack Call]

Board at start:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- pass

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Fang Relic, Hyena Pack Call, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 3 — Red

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Ritual of Red Moon]

Board at start:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Hunter’s Call]

Main 1:
- Main 1: played Young Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Ritual of Red Moon
- discarded cards: Baobab Guardian, Baobab Guardian, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 4 — Iron

Resources at start:
Offerings: 1
Memory: 0

Hand at start: [Black-Tooth Smith]

Board at start:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bite the Roots
- discarded cards: Black-Tooth Smith, Bone Spear, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

# End of Phase 1 Summary

Shrine damage: Red [Shrine of the Red Baobab 11/10, Hunter’s Root-Stone 11/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 12/10, Bone-Fang Shrine 13/10, Rusted Moon Shrine 0/10]
Resources: Red 6/2 | Iron 7/3
Awakened Ancestors: Red red.ancestor.grandmother | Iron iron.ancestor.smith
Forgotten cards: Red 7 | Iron 6
Key events: Bite the Roots moved to Forgotten (rite resolved). | Bite the Roots retained. | Black-Tooth Smith discarded at end step. | Bone Spear discarded at end step. | Fang Relic discarded at end step. | Turn 4 ended for iron.
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Bite the Roots]

Board at start:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots
- Main 1: prepared Iron Snare

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Raider
- discarded cards: Iron Guard, Rust Hyena Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 6 — Red

Resources at start:
Offerings: 1
Memory: 0

Hand at start: [Ritual of Red Moon]

Board at start:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Hunter’s Call]

Main 1:
- Main 1: played Young Hunter
- Main 1: resolved Ritual of Red Moon

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Young Hunter survives, Bone-Fang Shrine at 7/10

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Hunter’s Call, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
- board at end: Young Hunter, Young Hunter

## Turn 7 — Iron

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Iron Hyena Raider]

Board at start:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Black-Tooth Smith, False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider, Iron Hyena Raider

## Turn 8 — Red

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Esprit du Léopard]

Board at start:
Beings/Spirits: Young Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Hunter’s Call, Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to Young Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 3 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: resolved Ritual of Red Moon
- Main 2: awakened First Hunter

End:
- retained card: Leopard Hunter
- discarded cards: Esprit du Léopard, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
- board at end: Spear of First Dawn, Young Hunter

# End of Phase 2 Summary

Shrine damage: Red [Shrine of the Red Baobab 11/10, Hunter’s Root-Stone 11/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 12/10, Bone-Fang Shrine 13/10, Rusted Moon Shrine 0/10]
Resources: Red 6/2 | Iron 7/3
Awakened Ancestors: Red red.ancestor.grandmother | Iron iron.ancestor.smith
Forgotten cards: Red 7 | Iron 6
Key events: First Hunter awakened. | Hunter’s Root-Stone restored by 1 (Moonlit Roots restored a Shrine.). | Leopard Hunter retained. | Esprit du Léopard discarded at end step. | Deep River Spirit discarded at end step. | Turn 8 ended for red.
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Leopard Hunter]

Board at start:
Beings/Spirits: Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 4.
- Result: Young Hunter survives, Bone-Fang Shrine at 3/10

Main 2:
- Main 2: attached Spear of First Dawn to Young Hunter

End:
- retained card: Leopard Hunter
- discarded cards: Esprit du Léopard, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
- board at end: River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn]

## Turn 10 — Iron

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Iron Hyena Champion]

Board at start:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Iron Hyena Champion, False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 11 — Red

Resources at start:
Offerings: 1
Memory: 0

Hand at start: [Leopard Hunter]

Board at start:
Beings/Spirits: River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn]
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 8/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to Young Hunter. | Young Hunter deals 3 to Bone-Cracker Cub.
- Result: Young Hunter left battle, Bone-Cracker Cub removed

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Root-Woven Guard, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
- board at end: River Hunter, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter

## Turn 12 — Iron

Resources at start:
Offerings: 2
Memory: 0

Hand at start: [Bone-Cracker Cub]

Board at start:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: prepared Iron Snare
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Guard, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

# End of Phase 3 Summary

Shrine damage: Red [Shrine of the Red Baobab 11/10, Hunter’s Root-Stone 11/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 12/10, Bone-Fang Shrine 13/10, Rusted Moon Shrine 0/10]
Resources: Red 6/2 | Iron 7/3
Awakened Ancestors: Red red.ancestor.grandmother | Iron iron.ancestor.smith
Forgotten cards: Red 7 | Iron 6
Key events: Spent 1 Offerings on Bone-Cracker Cub. | Bone-Cracker Cub entered the battlefield. | Iron Hyena Underworld retained. | Iron Guard discarded at end step. | Iron Hyena Raider discarded at end step. | Turn 12 ended for iron.
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Resources at start:
Offerings: 4
Memory: 0

Hand at start: [Iron Hyena Underworld]

Board at start:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: Iron Snare
Awakened Ancestor: None
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: River Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to River Hunter. | Shrine Hunter’s Root-Stone takes 4.
- Result: Bone-Cracker Cub left battle, River Hunter removed, Hunter’s Root-Stone at 0/10

Main 2:
- Main 2: played Rust Hyena Spirit

End:
- retained card: Iron Hyena Champion
- discarded cards: Iron Hyena Underworld
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Bone-Cracker Cub, Rust Hyena Spirit

## Turn 14 — Red

Resources at start:
Offerings: 3
Memory: 1

Hand at start: [Leopard Hunter]

Board at start:
Beings/Spirits: River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter
- Main 1: attached Spear of First Dawn to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Rust Hyena Spirit
- Defender/blocker: Rust Hyena Spirit
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: None
- Damage: Rust Hyena Spirit deals 2 to River Hunter. | River Hunter deals 4 to Rust Hyena Spirit.
- Result: River Hunter left battle, Rust Hyena Spirit removed

Main 2:
- pass

End:
- retained card: Ritual of Red Moon
- discarded cards: Root-Woven Guard, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 3 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Young Hunter

## Turn 15 — Iron

Resources at start:
Offerings: 3
Memory: 2

Hand at start: [Iron Hyena Champion]

Board at start:
Beings/Spirits: Bone-Cracker Cub, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Young Hunter deals 2 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Young Hunter. | Shrine Moonlit Roots takes 3.
- Result: Bone-Cracker Cub left battle, Young Hunter removed, Moonlit Roots at 7/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to Leopard Hunter. | Shrine Moonlit Roots takes 4.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed, Moonlit Roots at 3/10

Main 2:
- Main 2: played Iron Hyena Champion
- Main 2: awakened Ancestor of the Iron Hyena

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Hyena Champion

## Turn 16 — Red

Resources at start:
Offerings: 0
Memory: 3

Hand at start: [Ritual of Red Moon]

Board at start:
Beings/Spirits: Spear of First Dawn, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 7/10
Forgotten zone count/list: 3 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: resolved Ritual of Red Moon

Combat:
- no attacks

Main 2:
- Main 2: played Deep River Spirit
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Esprit du Léopard
- discarded cards: Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 5/10
- board at end: Deep River Spirit, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Young Hunter

# End of Phase 4 Summary

Shrine damage: Red [Shrine of the Red Baobab 11/10, Hunter’s Root-Stone 11/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 12/10, Bone-Fang Shrine 13/10, Rusted Moon Shrine 0/10]
Resources: Red 6/2 | Iron 7/3
Awakened Ancestors: Red red.ancestor.grandmother | Iron iron.ancestor.smith
Forgotten cards: Red 7 | Iron 6
Key events: Grandmother Beneath the Roots awakened. | Moonlit Roots restored by 1 (Moonlit Roots restored a Shrine.). | Moonlit Roots restored by 1 (Grandmother Beneath the Roots restored a Shrine.). | Esprit du Léopard retained. | Esprit du Léopard discarded at end step. | Turn 16 ended for red.
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Resources at start:
Offerings: 1
Memory: 0

Hand at start: [Esprit du Léopard]

Board at start:
Beings/Spirits: Deep River Spirit, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 5/10
Forgotten zone count/list: 4 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Baobab Guardian

Combat:

Attack 1:
- Attacker: Deep River Spirit
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 5 to 3. | Deep River Spirit becomes Wounded.
- Damage: Iron Hyena Champion deals 3 to Deep River Spirit. | Deep River Spirit deals 3 to Iron Hyena Champion.
- Result: Deep River Spirit survives, Iron Hyena Champion removed

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 3/10
- board at end: Baobab Guardian, Deep River Spirit [Wounded], River Hunter, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Young Hunter

## Turn 18 — Iron

Resources at start:
Offerings: 2
Memory: 1

Hand at start: [Black-Tooth Smith]

Board at start:
Beings/Spirits: Bone Spear
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: prepared False Opening
- Main 1: played Black-Tooth Smith

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Guard
- discarded cards: Iron Hyena Champion, Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear

## Turn 19 — Red

Resources at start:
Offerings: 3
Memory: 0

Hand at start: [Esprit du Léopard]

Board at start:
Beings/Spirits: Baobab Guardian, Deep River Spirit [Wounded], River Hunter, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 3/10
Forgotten zone count/list: 4 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Black-Tooth Smith deals 2 to River Hunter. | River Hunter deals 3 to Black-Tooth Smith.
- Result: River Hunter left battle, Black-Tooth Smith removed

Main 2:
- Main 2: played Pale River Spirit
- Main 2: awakened First Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Root-Woven Guard, Baobab Guardian
- forgotten cards: None
- Wounded clears: Deep River Spirit
- resources at end: 4 Offerings / 0 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
- board at end: Baobab Guardian, Deep River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Young Hunter

## Turn 20 — Iron

Resources at start:
Offerings: 4
Memory: 0

Hand at start: [Iron Guard]

Board at start:
Beings/Spirits: Bone Spear
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- Main 2: played Iron Guard

End:
- retained card: Black-Tooth Smith
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Guard, Iron Hyena Raider, Iron Hyena Raider

# End of Phase 5 Summary

Shrine damage: Red [Shrine of the Red Baobab 11/10, Hunter’s Root-Stone 11/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 12/10, Bone-Fang Shrine 13/10, Rusted Moon Shrine 0/10]
Resources: Red 6/2 | Iron 7/3
Awakened Ancestors: Red red.ancestor.grandmother | Iron iron.ancestor.smith
Forgotten cards: Red 7 | Iron 6
Key events: Iron Hyena Raider entered the battlefield. | Spent 2 Offerings on Iron Guard. | Iron Guard entered the battlefield. | Black-Tooth Smith retained. | Bone-Cracker Cub discarded at end step. | Turn 20 ended for iron.
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Iron

Resources at start:
Offerings: 2
Memory: 0

Hand at start: [Black-Tooth Smith]

Board at start:
Beings/Spirits: Bone Spear, Iron Guard, Iron Hyena Raider, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Guard
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Iron Guard. | Iron Guard deals 2 to Deep River Spirit.
- Result: Iron Guard left battle, Deep River Spirit survives

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2.
- Damage: Deep River Spirit deals 2 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Deep River Spirit.
- Result: Iron Hyena Raider left battle, Deep River Spirit removed

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Black-Tooth Smith
- discarded cards: False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Iron Hyena Raider, Iron Hyena Raider

## Turn 22 — Red

Resources at start:
Offerings: 4
Memory: 1

Hand at start: [Esprit du Léopard]

Board at start:
Beings/Spirits: Baobab Guardian, Pale River Spirit, River Hunter, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
Forgotten zone count/list: 4 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Spear of First Dawn to Young Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 6 to Iron Hyena Raider. | Shrine Bone-Fang Shrine takes 6.
- Result: Young Hunter left battle, Iron Hyena Raider removed, Bone-Fang Shrine at 0/10

Main 2:
- Main 2: attached Esprit du Léopard to Baobab Guardian

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
- board at end: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, River Hunter, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Young Hunter

## Turn 23 — Iron

Resources at start:
Offerings: 2
Memory: 0

Hand at start: [Black-Tooth Smith]

Board at start:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Baobab Guardian.
- Result: Black-Tooth Smith left battle, Baobab Guardian survives

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 4 to 3.
- Damage: Baobab Guardian deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Baobab Guardian.
- Result: Bone-Cracker Cub left battle, Baobab Guardian removed

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: played Rust Hyena Spirit

End:
- retained card: Fang Relic
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Relic:Bone Spear], Bone Spear, Bone Spear, Fang Relic, Iron Hyena Raider, Rust Hyena Spirit

## Turn 24 — Red

Resources at start:
Offerings: 3
Memory: 2

Hand at start: [Kuma Who Wounded the Sun]

Board at start:
Beings/Spirits: Pale River Spirit, River Hunter, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
Forgotten zone count/list: 4 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Black-Tooth Smith deals 3 to River Hunter. | River Hunter deals 3 to Black-Tooth Smith.
- Result: River Hunter left battle, Black-Tooth Smith removed

Main 2:
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Hunter’s Call, Offering of Milk and Ash, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 4 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
- board at end: Leopard Hunter, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn

# End of Phase 6 Summary

Shrine damage: Red [Shrine of the Red Baobab 11/10, Hunter’s Root-Stone 11/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 12/10, Bone-Fang Shrine 13/10, Rusted Moon Shrine 0/10]
Resources: Red 6/2 | Iron 7/3
Awakened Ancestors: Red red.ancestor.grandmother | Iron iron.ancestor.smith
Forgotten cards: Red 7 | Iron 6
Key events: Moonlit Roots restored by 1 (Moonlit Roots restored a Shrine.). | Kuma Who Wounded the Sun retained. | Hunter’s Call discarded at end step. | Offering of Milk and Ash discarded at end step. | Baobab Guardian discarded at end step. | Turn 24 ended for red.
Tempo note: initiative reverses after every four player-turns.

## Turn 25 — Red

Resources at start:
Offerings: 5
Memory: 4

Hand at start: [Kuma Who Wounded the Sun]

Board at start:
Beings/Spirits: Leopard Hunter, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
Forgotten zone count/list: 4 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Pale River Spirit
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Pale River Spirit. | Pale River Spirit deals 2 to Iron Hyena Raider.
- Result: Pale River Spirit left battle, Iron Hyena Raider removed

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Baobab Guardian, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 4 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
- board at end: Kuma Who Wounded the Sun, River Hunter, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn

## Turn 26 — Iron

Resources at start:
Offerings: 1
Memory: 0

Hand at start: [Fang Relic]

Board at start:
Beings/Spirits: Bone Spear, Bone Spear, Fang Relic, Rust Hyena Spirit
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine damage: Iron Hyena Den: 3/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Rust Hyena Spirit
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: Kuma Who Wounded the Sun
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 6 to Rust Hyena Spirit. | Rust Hyena Spirit deals 3 to Kuma Who Wounded the Sun.
- Result: Rust Hyena Spirit left battle, Kuma Who Wounded the Sun survives

Main 2:
- Main 2: played Rust Hyena Spirit

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine damage: Iron Hyena Den: 3/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic, Rust Hyena Spirit

## Turn 27 — Red

Resources at start:
Offerings: 1
Memory: 4

Hand at start: [Esprit du Léopard]

Board at start:
Beings/Spirits: Kuma Who Wounded the Sun [Wounded], River Hunter, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
Forgotten zone count/list: 4 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to Kuma Who Wounded the Sun

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Rust Hyena Spirit
- Defender/blocker: Rust Hyena Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 7 to 5. | Kuma Who Wounded the Sun becomes Wounded.
- Damage: Rust Hyena Spirit deals 2 to Kuma Who Wounded the Sun. | Kuma Who Wounded the Sun deals 5 to Rust Hyena Spirit.
- Result: Kuma Who Wounded the Sun survives, Rust Hyena Spirit removed

Main 2:
- Main 2: attached Esprit du Léopard to Kuma Who Wounded the Sun

End:
- retained card: Deep River Spirit
- discarded cards: Offering of Milk and Ash, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 3 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
- board at end: Esprit du Léopard, Kuma Who Wounded the Sun [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], River Hunter, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn

## Turn 28 — Iron

Resources at start:
Offerings: 3
Memory: 2

Hand at start: [Iron Hyena Underworld]

Board at start:
Beings/Spirits: Bone Spear, Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine damage: Iron Hyena Den: 3/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: River Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to River Hunter. | Shrine Moonlit Roots takes 4.
- Result: Bone-Cracker Cub left battle, River Hunter removed, Moonlit Roots at 4/10

Main 2:
- Main 2: played Iron Guard

End:
- retained card: Iron Hyena Underworld
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 3 Memory
- shrine damage: Iron Hyena Den: 3/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Guard

# End of Phase 7 Summary

Shrine damage: Red [Shrine of the Red Baobab 11/10, Hunter’s Root-Stone 11/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 12/10, Bone-Fang Shrine 13/10, Rusted Moon Shrine 0/10]
Resources: Red 6/2 | Iron 7/3
Awakened Ancestors: Red red.ancestor.grandmother | Iron iron.ancestor.smith
Forgotten cards: Red 7 | Iron 6
Key events: Ancestor of the Iron Hyena deals 1 to Shrine of the Red Baobab. | Spent 2 Offerings on Iron Guard. | Iron Guard entered the battlefield. | Iron Hyena Underworld retained. | Hyena Pack Call discarded at end step. | Turn 28 ended for iron.
Tempo note: initiative reverses after every four player-turns.

## Turn 29 — Iron

Resources at start:
Offerings: 4
Memory: 3

Hand at start: [Iron Hyena Underworld]

Board at start:
Beings/Spirits: Bone Spear, Bone Spear, Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Guard
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine damage: Iron Hyena Den: 3/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Iron Guard
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 2.
- Result: Iron Guard survives, Moonlit Roots at 0/10

Main 2:
- pass

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Hyena Champion, Iron Hyena Raider, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: Iron Hyena Champion
- resources at end: 5 Offerings / 4 Memory
- shrine damage: Iron Hyena Den: 3/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Bone Spear, Fang Relic, Fang Relic, Iron Guard, Iron Hyena Champion

## Turn 30 — Red

Resources at start:
Offerings: 4
Memory: 4

Hand at start: [Deep River Spirit]

Board at start:
Beings/Spirits: Esprit du Léopard, Kuma Who Wounded the Sun [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 4 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Spear of First Dawn to Kuma Who Wounded the Sun

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 9 to 6. | Kuma Who Wounded the Sun becomes Wounded.
- Damage: Iron Hyena Champion deals 5 to Kuma Who Wounded the Sun. | Kuma Who Wounded the Sun deals 6 to Iron Hyena Champion.
- Result: Kuma Who Wounded the Sun survives, Iron Hyena Champion removed

Main 2:
- Main 2: played Deep River Spirit
- Main 2: prepared Root-Woven Guard

End:
- retained card: Esprit du Léopard
- discarded cards: None
- forgotten cards: None
- Wounded clears: Deep River Spirit
- resources at end: 0 Offerings / 2 Memory
- shrine damage: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Deep River Spirit, Esprit du Léopard, Kuma Who Wounded the Sun [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Young Hunter

## Turn 31 — Iron

Resources at start:
Offerings: 5
Memory: 4

Hand at start: [Iron Hyena Underworld]

Board at start:
Beings/Spirits: Bone Spear, Bone Spear, Bone Spear, Fang Relic, Fang Relic, Iron Guard
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine damage: Iron Hyena Den: 3/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Iron Guard
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Iron Guard
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: Root-Woven Guard
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 3.
- Result: Iron Guard survives, Shrine of the Red Baobab at 4/10

Main 2:
- Main 2: played Iron Guard

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Underworld
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 5 Memory
- shrine damage: Iron Hyena Den: 3/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic, Fang Relic, Iron Guard, Iron Guard [Relic:Fang Relic]

## Turn 32 — Red

Resources at start:
Offerings: 0
Memory: 2

Hand at start: [Esprit du Léopard]

Board at start:
Beings/Spirits: Deep River Spirit, Esprit du Léopard, Kuma Who Wounded the Sun [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 5 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Iron Guard
- Defender/blocker: Iron Guard
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 9 to 6. | Kuma Who Wounded the Sun becomes Wounded.
- Damage: Iron Guard deals 3 to Kuma Who Wounded the Sun. | Kuma Who Wounded the Sun deals 6 to Iron Guard.
- Result: Kuma Who Wounded the Sun survives, Iron Guard removed

Attack 2:
- Attacker: Young Hunter
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to Young Hunter. | Young Hunter deals 2 to Bone-Cracker Cub.
- Result: Young Hunter left battle, Bone-Cracker Cub removed

Main 2:
- Main 2: played Leopard Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit, Young Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 3 Memory
- shrine damage: Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Deep River Spirit, Esprit du Léopard, Kuma Who Wounded the Sun [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Leopard Hunter, River Hunter, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn

# End of Phase 8 Summary

Shrine damage: Red [Shrine of the Red Baobab 11/10, Hunter’s Root-Stone 11/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 12/10, Bone-Fang Shrine 13/10, Rusted Moon Shrine 0/10]
Resources: Red 6/2 | Iron 7/3
Awakened Ancestors: Red red.ancestor.grandmother | Iron iron.ancestor.smith
Forgotten cards: Red 7 | Iron 6
Key events: Spent 5 Offerings on Leopard Hunter. | Leopard Hunter entered the battlefield. | Esprit du Léopard retained. | Deep River Spirit discarded at end step. | Young Hunter discarded at end step. | Turn 32 ended for red.
Tempo note: initiative reverses after every four player-turns.

## Turn 33 — Red

Resources at start:
Offerings: 1
Memory: 3

Hand at start: [Esprit du Léopard]

Board at start:
Beings/Spirits: Deep River Spirit, Esprit du Léopard, Kuma Who Wounded the Sun [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Leopard Hunter, River Hunter, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 5 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter
- Main 1: attached Esprit du Léopard to Kuma Who Wounded the Sun

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Iron Guard
- Defender/blocker: Iron Guard
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 9 to 6. | Kuma Who Wounded the Sun becomes Wounded.
- Damage: Iron Guard deals 2 to Kuma Who Wounded the Sun. | Kuma Who Wounded the Sun deals 6 to Iron Guard.
- Result: Kuma Who Wounded the Sun survives, Iron Guard removed

Main 2:
- pass

End:
- retained card: Pale River Spirit
- discarded cards: Baobab Guardian, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 3 Memory
- shrine damage: Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Deep River Spirit, Esprit du Léopard, Kuma Who Wounded the Sun [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Leopard Hunter, Leopard Hunter, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn

## Turn 34 — Iron

Resources at start:
Offerings: 3
Memory: 5

Hand at start: [Black-Tooth Smith]

Board at start:
Beings/Spirits: Bone Spear, Bone Spear, Bone Spear, Fang Relic, Fang Relic, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine damage: Iron Hyena Den: 3/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 5 Memory
- shrine damage: Iron Hyena Den: 3/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone Spear, Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic, Fang Relic, Iron Hyena Raider

## Turn 35 — Red

Resources at start:
Offerings: 3
Memory: 3

Hand at start: [Pale River Spirit]

Board at start:
Beings/Spirits: Deep River Spirit, Esprit du Léopard, Kuma Who Wounded the Sun [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Leopard Hunter, Leopard Hunter, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 5 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: resolved Offering of Milk and Ash
- Main 1: prepared Hunter’s Call

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 12 to 9.
- Damage: Shrine Iron Hyena Den takes 9.
- Result: Kuma Who Wounded the Sun survives, Iron Hyena Den at 0/10

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Pale River Spirit
- discarded cards: Young Hunter, Young Hunter
- forgotten cards: None
- Wounded clears: Kuma Who Wounded the Sun
- resources at end: 6 Offerings / 1 Memory
- shrine damage: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Deep River Spirit, Esprit du Léopard, Kuma Who Wounded the Sun [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Leopard Hunter, Leopard Hunter, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn, Spear of First Dawn

## Turn 36 — Iron

Resources at start:
Offerings: 2
Memory: 5

Hand at start: [Black-Tooth Smith]

Board at start:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Bone Spear, Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic, Fang Relic, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine damage: Iron Hyena Den: 12/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives, Shrine of the Red Baobab at 7/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to Leopard Hunter. | Shrine Shrine of the Red Baobab takes 4.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed, Shrine of the Red Baobab at 2/10

Attack 3:
- Attacker: Iron Hyena Raider
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Leopard Hunter. | Shrine Shrine of the Red Baobab takes 3.
- Result: Iron Hyena Raider left battle, Leopard Hunter removed, Shrine of the Red Baobab at 0/10

Main 2:
- Main 2: awakened Smith of Black Teeth

End:
- retained card: Bone-Cracker Cub
- discarded cards: Black-Tooth Smith, False Opening, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 7 Offerings / 3 Memory
- shrine damage: Iron Hyena Den: 12/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Bone Spear, Bone Spear, Fang Relic, Fang Relic, Fang Relic

# End of Phase 9 Summary

Shrine damage: Red [Shrine of the Red Baobab 11/10, Hunter’s Root-Stone 11/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 12/10, Bone-Fang Shrine 13/10, Rusted Moon Shrine 0/10]
Resources: Red 6/2 | Iron 7/3
Awakened Ancestors: Red red.ancestor.grandmother | Iron iron.ancestor.smith
Forgotten cards: Red 7 | Iron 6
Key events: Smith of Black Teeth awakened. | Bone-Cracker Cub retained. | Black-Tooth Smith discarded at end step. | False Opening discarded at end step. | Fang Relic discarded at end step. | Turn 36 ended for iron.
Tempo note: initiative reverses after every four player-turns.

## End-of-game summary

Winner: iron
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Shrine of the Red Baobab 11/10, Hunter’s Root-Stone 11/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 12/10, Bone-Fang Shrine 13/10, Rusted Moon Shrine 0/10]
Final resources: Red 6/2 | Iron 7/3
Final Presence: Seat 1 3/5 | Seat 2 0/5

Turn count: 36
Phase count: 9

First Shrine damage: 6
First Shrine broken: 13
First Ancestor awakened: 8
First L2: 14
First L3: 25

Red L2 entries: 4 (hard-cast 2, evolved 2)
Red L3 entries: 1 (hard-cast 0, evolved 1, recalled 0)
Iron L2 entries: 2 (hard-cast 1, evolved 1)
Iron L3 entries: 0 (hard-cast 0, evolved 0, recalled 0)

Legal evolve actions generated: Red 6, Iron 4
Legal L2 evolve actions: Red 4, Iron 4
Legal L3 evolve actions: Red 2, Iron 0
Evolve windows: Red 6, Iron 2
Turns with legal L2 evolution: Red 4, Iron 2
Turns with legal L3 evolution: Red 2, Iron 0
Evolve actions chosen: Red 6, Iron 4
Hard-cast chosen while legal evolve action existed: Red 3, Iron 0
Hard-cast chosen while evolution base existed: Red 5, Iron 1

Legal awaken actions generated: Red 29, Iron 9
Awaken actions chosen: Red 11, Iron 5
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.firsthunter, Iron iron.ancestor.hyena
Ancestor switches: Red 3, Iron 1
Turns with awakened ancestor: Red 14, Iron 10
Memory spent on ancestors: Red 8, Iron 4
Ancestor realized value: First Hunter +3 damage, Grandmother healed 3, Child draw/discard 0, Iron Hyena +4 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 2, Iron 2
Prepared Tactics expired: Red 1, Iron 1
Fade cards Forgotten: Red 7, Iron 6
Wounded events: Red 9, Iron 1
Wounded reduced damage: Red 8, Iron 1
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 10, Iron 1
Blocks chosen: Red 7, Iron 1
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 16, pack 0 | Seat 2 standard 13, pack 1
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 36, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 11, generated 11, available 11, skipped 10, turns-with-bonus 7, max-attacks 47, prevented-by-limit 0
Deck reshuffles: Red 3, Iron 3

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
