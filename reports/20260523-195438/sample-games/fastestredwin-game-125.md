# Test Game #125

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

Seed: 125
Winner: red
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Deep River Spirit, Deep River Spirit, Esprit du Léopard, Spear of First Dawn, Young Hunter
- Starting hands — Iron: Bite the Roots, Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, False Opening
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the Iron Hyena, Tooth-Mother of the Dry Earth, Smith of Black Teeth

## Turn 1 — Red

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Deep River Spirit, Deep River Spirit, Esprit du Léopard, Spear of First Dawn, Young Hunter]

Board at start:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Young Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit, Deep River Spirit, Spear of First Dawn
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 2 — Iron

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Bite the Roots, Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, False Opening]

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
- discarded cards: False Opening, Black-Tooth Smith, Bone Spear
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 3 — Red

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Esprit du Léopard]

Board at start:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Ritual of Red Moon

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Esprit du Léopard, Root-Woven Guard, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 4 — Iron

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Bite the Roots]

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
- retained card: Bone-Cracker Cub
- discarded cards: Fang Relic, Rust Hyena Spirit, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

# End of Phase 1 Summary

Shrine damage: Red [Shrine of the Red Baobab 2/10, Hunter’s Root-Stone 12/10, Moonlit Roots 12/10] | Iron [Iron Hyena Den 13/10, Bone-Fang Shrine 12/10, Rusted Moon Shrine 12/10]
Resources: Red 6/3 | Iron 1/2
Awakened Ancestors: Red red.ancestor.firsthunter | Iron iron.ancestor.hyena
Forgotten cards: Red 2 | Iron 6
Key events: Bite the Roots moved to Forgotten (rite resolved). | Bone-Cracker Cub retained. | Fang Relic discarded at end step. | Rust Hyena Spirit discarded at end step. | Iron Hyena Champion discarded at end step. | Turn 4 ended for iron.
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Bone-Cracker Cub]

Board at start:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: prepared Iron Snare
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Underworld
- discarded cards: False Opening, Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 6 — Red

Resources at start:
Offerings: 0
Memory: 1

Hand at start: [Leopard Hunter]

Board at start:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

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
- Damage: Bone-Cracker Cub deals 2 to Young Hunter. | Young Hunter deals 2 to Bone-Cracker Cub.
- Result: Young Hunter left battle, Bone-Cracker Cub removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Leopard Hunter
- discarded cards: Ritual of Red Moon, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: River Hunter, Young Hunter

## Turn 7 — Iron

Resources at start:
Offerings: 1
Memory: 0

Hand at start: [Iron Hyena Underworld]

Board at start:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Iron Snare]

Main 1:
- Main 1: prepared Iron Snare
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Underworld, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider

## Turn 8 — Red

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Leopard Hunter]

Board at start:
Beings/Spirits: River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played Pale River Spirit
- Main 1: resolved Offering of Milk and Ash

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to River Hunter. | River Hunter deals 3 to Iron Hyena Raider.
- Result: River Hunter left battle, Iron Hyena Raider removed

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Baobab Guardian, Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 2 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Pale River Spirit, Young Hunter

# End of Phase 2 Summary

Shrine damage: Red [Shrine of the Red Baobab 2/10, Hunter’s Root-Stone 12/10, Moonlit Roots 12/10] | Iron [Iron Hyena Den 13/10, Bone-Fang Shrine 12/10, Rusted Moon Shrine 12/10]
Resources: Red 6/3 | Iron 1/2
Awakened Ancestors: Red red.ancestor.firsthunter | Iron iron.ancestor.hyena
Forgotten cards: Red 2 | Iron 6
Key events: River Hunter died in combat. | Gained 1 Memory (Shrine of the Red Baobab triggered.). | Leopard Hunter retained. | Baobab Guardian discarded at end step. | Kuma Who Wounded the Sun discarded at end step. | Turn 8 ended for red.
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Resources at start:
Offerings: 1
Memory: 2

Hand at start: [Leopard Hunter]

Board at start:
Beings/Spirits: Pale River Spirit, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 4.
- Result: Young Hunter survives, Bone-Fang Shrine at 6/10

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Leopard Hunter
- discarded cards: Hunter’s Call, Baobab Guardian, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, Pale River Spirit, Young Hunter

## Turn 10 — Iron

Resources at start:
Offerings: 1
Memory: 0

Hand at start: [Black-Tooth Smith]

Board at start:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots
- Main 1: played Black-Tooth Smith

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Rust Hyena Spirit
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Relic:Bone Spear], Bone Spear

## Turn 11 — Red

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Leopard Hunter]

Board at start:
Beings/Spirits: Leopard Hunter, Pale River Spirit, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 5.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 1/10

Attack 2:
- Attacker: Young Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: Black-Tooth Smith becomes Wounded.
- Damage: Black-Tooth Smith deals 3 to Young Hunter. | Young Hunter deals 2 to Black-Tooth Smith.
- Result: Young Hunter left battle, Black-Tooth Smith survives

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Spear of First Dawn, Offering of Milk and Ash, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, Pale River Spirit, River Hunter

## Turn 12 — Iron

Resources at start:
Offerings: 0
Memory: 0

Hand at start: [Rust Hyena Spirit]

Board at start:
Beings/Spirits: Black-Tooth Smith [Wounded, Relic:Bone Spear], Bone Spear
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 4 to 3.
- Damage: Shrine Hunter’s Root-Stone takes 3.
- Result: Black-Tooth Smith survives, Hunter’s Root-Stone at 2/10

Main 2:
- Main 2: played Rust Hyena Spirit

End:
- retained card: Iron Hyena Champion
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: Black-Tooth Smith
- resources at end: 1 Offerings / 1 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Relic:Bone Spear], Bone Spear, Bone-Cracker Cub, Rust Hyena Spirit

# End of Phase 3 Summary

Shrine damage: Red [Shrine of the Red Baobab 2/10, Hunter’s Root-Stone 12/10, Moonlit Roots 12/10] | Iron [Iron Hyena Den 13/10, Bone-Fang Shrine 12/10, Rusted Moon Shrine 12/10]
Resources: Red 6/3 | Iron 1/2
Awakened Ancestors: Red red.ancestor.firsthunter | Iron iron.ancestor.hyena
Forgotten cards: Red 2 | Iron 6
Key events: Gained 1 Memory (Iron Hyena Den triggered.). | Spent 2 Offerings on Rust Hyena Spirit. | Rust Hyena Spirit entered the battlefield. | Iron Hyena Champion retained. | Iron Hyena Raider discarded at end step. | Turn 12 ended for iron.
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Resources at start:
Offerings: 1
Memory: 1

Hand at start: [Iron Hyena Champion]

Board at start:
Beings/Spirits: Black-Tooth Smith [Relic:Bone Spear], Bone Spear, Bone-Cracker Cub, Rust Hyena Spirit
Prepared Tactic: None
Awakened Ancestor: None
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Black-Tooth Smith

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 4.
- Result: Black-Tooth Smith survives, Hunter’s Root-Stone at 0/10

Attack 2:
- Attacker: Rust Hyena Spirit
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Leopard Hunter.
- Result: Rust Hyena Spirit left battle, Leopard Hunter survives

Main 2:
- Main 2: played Iron Hyena Champion
- Main 2: awakened Ancestor of the Iron Hyena

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Relic:Fang Relic], Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Champion

## Turn 14 — Red

Resources at start:
Offerings: 4
Memory: 1

Hand at start: [Leopard Hunter]

Board at start:
Beings/Spirits: Leopard Hunter [Wounded], Pale River Spirit, River Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Bone-Cracker Cub deals 2 to Leopard Hunter. | Leopard Hunter deals 3 to Bone-Cracker Cub. | Shrine Bone-Fang Shrine takes 3.
- Result: Leopard Hunter survives, Bone-Cracker Cub removed, Bone-Fang Shrine at 0/10

Attack 2:
- Attacker: River Hunter
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to River Hunter. | River Hunter deals 3 to Iron Hyena Champion.
- Result: River Hunter left battle, Iron Hyena Champion removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Leopard Hunter
- discarded cards: Esprit du Léopard, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine damage: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
- board at end: Leopard Hunter [Wounded], Pale River Spirit, River Hunter, Young Hunter

## Turn 15 — Iron

Resources at start:
Offerings: 0
Memory: 1

Hand at start: [Black-Tooth Smith]

Board at start:
Beings/Spirits: Black-Tooth Smith [Relic:Fang Relic], Bone Spear, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 3.
- Result: Black-Tooth Smith survives, Moonlit Roots at 6/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Hyena Pack Call
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 2 Memory
- shrine damage: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Black-Tooth Smith [Relic:Fang Relic], Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider

## Turn 16 — Red

Resources at start:
Offerings: 4
Memory: 1

Hand at start: [Leopard Hunter]

Board at start:
Beings/Spirits: Leopard Hunter [Wounded], Pale River Spirit, River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 4/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 5 to 3.
- Damage: Shrine Iron Hyena Den takes 3.
- Result: Leopard Hunter survives, Iron Hyena Den at 7/10

Attack 2:
- Attacker: River Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Black-Tooth Smith deals 3 to River Hunter. | River Hunter deals 3 to Black-Tooth Smith.
- Result: River Hunter left battle, Black-Tooth Smith removed

Main 2:
- Main 2: played Leopard Hunter

End:
- retained card: Spear of First Dawn
- discarded cards: Young Hunter, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 1 Offerings / 3 Memory
- shrine damage: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 4/10
- board at end: Leopard Hunter, Leopard Hunter, Pale River Spirit, River Hunter, Young Hunter

# End of Phase 4 Summary

Shrine damage: Red [Shrine of the Red Baobab 2/10, Hunter’s Root-Stone 12/10, Moonlit Roots 12/10] | Iron [Iron Hyena Den 13/10, Bone-Fang Shrine 12/10, Rusted Moon Shrine 12/10]
Resources: Red 6/3 | Iron 1/2
Awakened Ancestors: Red red.ancestor.firsthunter | Iron iron.ancestor.hyena
Forgotten cards: Red 2 | Iron 6
Key events: Spent 5 Offerings on Leopard Hunter. | Leopard Hunter entered the battlefield. | Spear of First Dawn retained. | Young Hunter discarded at end step. | Offering of Milk and Ash discarded at end step. | Turn 16 ended for red.
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Resources at start:
Offerings: 1
Memory: 3

Hand at start: [Spear of First Dawn]

Board at start:
Beings/Spirits: Leopard Hunter, Leopard Hunter, Pale River Spirit, River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 4/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to Pale River Spirit

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 5.
- Result: Leopard Hunter survives, Iron Hyena Den at 2/10

Attack 2:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 5.
- Result: Leopard Hunter survives, Iron Hyena Den at 0/10

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Young Hunter, Hunter’s Call, Spear of First Dawn
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 3 Memory
- shrine damage: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 4/10
- board at end: Leopard Hunter, Leopard Hunter, Pale River Spirit [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Young Hunter

## Turn 18 — Iron

Resources at start:
Offerings: 2
Memory: 2

Hand at start: [Hyena Pack Call]

Board at start:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine damage: Iron Hyena Den: 13/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: resolved Hyena Pack Call

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Moonlit Roots
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Black-Tooth Smith becomes Wounded.
- Damage: Young Hunter deals 2 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Young Hunter. | Shrine Moonlit Roots takes 2.
- Result: Black-Tooth Smith survives, Young Hunter removed, Moonlit Roots at 4/10

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Moonlit Roots
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: River Hunter deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to River Hunter. | Shrine Moonlit Roots takes 3.
- Result: Iron Hyena Raider left battle, River Hunter removed, Moonlit Roots at 1/10

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 3.
- Result: Bone-Cracker Cub survives, Moonlit Roots at 0/10

Main 2:
- Main 2: played Iron Hyena Champion

End:
- retained card: Iron Hyena Champion
- discarded cards: Iron Hyena Underworld, Rust Hyena Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 2 Memory
- shrine damage: Iron Hyena Den: 13/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Wounded], Bone Spear, Bone-Cracker Cub, Fang Relic, Hyena Token, Hyena Token, Iron Hyena Champion

## Turn 19 — Red

Resources at start:
Offerings: 6
Memory: 4

Hand at start: [Esprit du Léopard]

Board at start:
Beings/Spirits: Leopard Hunter, Leopard Hunter, Pale River Spirit [Relic:Spear of First Dawn], Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine damage: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 12/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: attached Esprit du Léopard to Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 7.
- Result: Leopard Hunter survives, Rusted Moon Shrine at 3/10

Attack 2:
- Attacker: Leopard Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 5.
- Result: Leopard Hunter survives, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Deep River Spirit
- discarded cards: Baobab Guardian, Root-Woven Guard, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 3 Memory
- shrine damage: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 12/10
- board at end: Esprit du Léopard, Leopard Hunter, Leopard Hunter [Possession:Esprit du Léopard], Pale River Spirit [Relic:Spear of First Dawn], Spear of First Dawn

## End-of-game summary

Winner: red
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Shrine of the Red Baobab 2/10, Hunter’s Root-Stone 12/10, Moonlit Roots 12/10] | Iron [Iron Hyena Den 13/10, Bone-Fang Shrine 12/10, Rusted Moon Shrine 12/10]
Final resources: Red 6/3 | Iron 1/2
Final Presence: Seat 1 3/5 | Seat 2 5/5

Turn count: 19
Phase count: 5

First Shrine damage: 9
First Shrine broken: 13
First Ancestor awakened: 6
First L2: 9
First L3: 

Red L2 entries: 2 (hard-cast 2, evolved 0)
Red L3 entries: 0 (hard-cast 0, evolved 0, recalled 0)
Iron L2 entries: 2 (hard-cast 2, evolved 0)
Iron L3 entries: 0 (hard-cast 0, evolved 0, recalled 0)

Legal evolve actions generated: Red 0, Iron 0
Legal L2 evolve actions: Red 0, Iron 0
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 0, Iron 0
Turns with legal L2 evolution: Red 0, Iron 0
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 0, Iron 0
Hard-cast chosen while legal evolve action existed: Red 1, Iron 1
Hard-cast chosen while evolution base existed: Red 7, Iron 2

Legal awaken actions generated: Red 8, Iron 5
Awaken actions chosen: Red 5, Iron 3
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.firsthunter, Iron iron.ancestor.hyena
Ancestor switches: Red 2, Iron 0
Turns with awakened ancestor: Red 7, Iron 2
Memory spent on ancestors: Red 6, Iron 2
Ancestor realized value: First Hunter +6 damage, Grandmother healed 1, Child draw/discard 0, Iron Hyena +2 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 1
Prepared Tactics expired: Red 0, Iron 1
Fade cards Forgotten: Red 2, Iron 6
Wounded events: Red 2, Iron 2
Wounded reduced damage: Red 2, Iron 1
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 3, Iron 1
Blocks chosen: Red 2, Iron 1
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 13, pack 0 | Seat 2 standard 6, pack 1
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 20, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 3, generated 3, available 3, skipped 2, turns-with-bonus 2, max-attacks 21, prevented-by-limit 0
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
