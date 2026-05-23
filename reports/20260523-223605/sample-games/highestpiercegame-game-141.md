# Test Game #141

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 100 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red red --bot-iron iron --deck-red red --deck-iron iron

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

Seed: 141
Winner: red
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Baobab Guardian, Deep River Spirit, Offering of Milk and Ash, Young Hunter, Young Hunter
- Starting hands — Iron: Black-Tooth Smith, Bone-Cracker Cub, Fang Relic, Iron Guard, Iron Hyena Raider
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the Iron Hyena, Tooth-Mother of the Dry Earth, Smith of Black Teeth

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Baobab Guardian, Deep River Spirit, Offering of Milk and Ash, Young Hunter, Young Hunter]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Young Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Deep River Spirit
- discarded cards: Offering of Milk and Ash, Baobab Guardian, Young Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith, Bone-Cracker Cub, Fang Relic, Iron Guard, Iron Hyena Raider]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Iron Guard, Black-Tooth Smith, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: attached Spear of First Dawn to Young Hunter

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
- retained card: Deep River Spirit
- discarded cards: Baobab Guardian, Hunter’s Call, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: 

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: prepared Iron Snare

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Raider
- discarded cards: Fang Relic, Iron Hyena Underworld, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/1 | Iron 1/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 0
Key events: Main 1: played Young Hunter | Main 1: played Bone-Cracker Cub | Bone-Cracker Cub deals 2 to Young Hunter. | Young Hunter deals 3 to Bone-Cracker Cub. | Main 1: attached Spear of First Dawn to Young Hunter | Main 1: prepared Iron Snare
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Raider]

Board before ready:
Beings/Spirits: 
Prepared Tactic: Iron Snare
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Raider
- discarded cards: Hyena Pack Call, Hyena Pack Call, Rust Hyena Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played River Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Ritual of Red Moon
- discarded cards: Deep River Spirit, Kuma Who Wounded the Sun, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: River Hunter

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Raider]

Board before ready:
Beings/Spirits: 
Prepared Tactic: Iron Snare
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Iron Guard, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Iron Hyena Raider

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: attached Esprit du Léopard to River Hunter
- Main 1: resolved Ritual of Red Moon (dealt 2 to Iron Hyena Raider, destroyed it, gained 1 Memory)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Ritual of Red Moon
- discarded cards: Root-Woven Guard, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, River Hunter [Possession:Esprit du Léopard]

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/1 | Iron 1/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 1
Key events: Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone) | Main 1: played River Hunter | Main 1: played Iron Hyena Raider | Main 1: played Bone-Cracker Cub | Main 1: attached Esprit du Léopard to River Hunter | Main 1: resolved Ritual of Red Moon (dealt 2 to Iron Hyena Raider, destroyed it, gained 1 Memory)
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Esprit du Léopard, River Hunter [Possession:Esprit du Léopard]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to River Hunter. | River Hunter deals 5 to Bone-Cracker Cub.
- Result: River Hunter left battle, Bone-Cracker Cub removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Leopard Hunter
- discarded cards: Ritual of Red Moon, Root-Woven Guard, Leopard Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: River Hunter

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Black-Tooth Smith

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Relic:Bone Spear], Bone Spear, Bone-Cracker Cub

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 3

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Leopard Hunter

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
- retained card: Spear of First Dawn
- discarded cards: Offering of Milk and Ash, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, Young Hunter

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Bone-Cracker Cub
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 5 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed, Hunter’s Root-Stone at 9/10

Main 2:
- Main 2: played Rust Hyena Spirit

End:
- retained card: False Opening
- discarded cards: False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Rust Hyena Spirit

# End of Phase 3 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/5 | Iron 1/0
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 1 | Iron 2
Key events: Main 1: played Leopard Hunter | Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 5 to Leopard Hunter. | Main 1: attached Fang Relic to Bone-Cracker Cub | Main 1: attached Bone Spear to Bone-Cracker Cub | Main 2: played Rust Hyena Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [False Opening]

Board before ready:
Beings/Spirits: Fang Relic, Rust Hyena Spirit
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: Young Hunter
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Young Hunter deals 2 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Young Hunter.
- Result: Rust Hyena Spirit left battle, Young Hunter removed

Main 2:
- pass

End:
- retained card: Iron Hyena Raider
- discarded cards: False Opening, Iron Snare
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 5

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 8/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Young Hunter

Combat:
- no attacks

Main 2:
- Main 2: played Pale River Spirit
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Spear of First Dawn
- discarded cards: Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
- board at end: Pale River Spirit, River Hunter, Young Hunter

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Iron Hyena Raider]

Board before ready:
Beings/Spirits: Fang Relic
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Rust Hyena Spirit
- discarded cards: Bone-Cracker Cub, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Fang Relic, Iron Hyena Raider

## Turn 16 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 3

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Pale River Spirit, River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to River Hunter. | River Hunter deals 4 to Iron Hyena Raider.
- Result: River Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Spear of First Dawn
- discarded cards: Baobab Guardian, Ritual of Red Moon, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
- board at end: Pale River Spirit, Young Hunter

# End of Phase 4 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 6/3 | Iron 5/1
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 1 | Iron 4
Key events: Main 1: played Iron Hyena Raider | Main 1: played Bone-Cracker Cub | Iron Hyena Raider deals 3 to River Hunter. | River Hunter deals 4 to Iron Hyena Raider. | Main 1: attached Spear of First Dawn to River Hunter | Main 2: awakened First Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 3

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Pale River Spirit, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to Young Hunter

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
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Ritual of Red Moon
- discarded cards: Kuma Who Wounded the Sun, Hunter’s Call, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: Pale River Spirit

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 1

Hand before draw: [Rust Hyena Spirit]

Board before ready:
Beings/Spirits: Fang Relic
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: prepared Iron Snare
- Main 1: prepared False Opening

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Rust Hyena Spirit, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 2

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Pale River Spirit
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: resolved Ritual of Red Moon (had no legal target)

Combat:
- no attacks

Main 2:
- Main 2: resolved Offering of Milk and Ash (restored 3 to Hunter’s Root-Stone)

End:
- retained card: Esprit du Léopard
- discarded cards: Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Pale River Spirit, River Hunter

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Fang Relic
Prepared Tactic: False Opening, Iron Snare
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Underworld
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic

# End of Phase 5 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/2 | Iron 3/0
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron None
Forgotten cards: Red 3 | Iron 4
Key events: Main 1: played River Hunter | Main 1: resolved Ritual of Red Moon (had no legal target) | Main 2: resolved Offering of Milk and Ash (restored 3 to Hunter’s Root-Stone) | Main 1: played Bone-Cracker Cub | Main 1: played Bone-Cracker Cub | Main 2: played Black-Tooth Smith
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic
Prepared Tactic: False Opening, Iron Snare
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Black-Tooth Smith survives, Hunter’s Root-Stone at 8/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 5.
- Result: Bone-Cracker Cub survives, Hunter’s Root-Stone at 3/10

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 4.
- Result: Bone-Cracker Cub survives, Hunter’s Root-Stone at 0/10

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: played Black-Tooth Smith

End:
- retained card: Hyena Pack Call
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Black-Tooth Smith, Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub [Relic:Bone Spear], Fang Relic

## Turn 22 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 2

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Pale River Spirit, River Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Pale River Spirit
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 3 to Pale River Spirit. | Pale River Spirit deals 2 to Bone-Cracker Cub.
- Result: Pale River Spirit left battle, Bone-Cracker Cub removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Pale River Spirit, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter [Wounded], Young Hunter

## Turn 23 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Black-Tooth Smith, Black-Tooth Smith, Bone-Cracker Cub, Fang Relic
Prepared Tactic: Iron Snare
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare]

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Moonlit Roots)

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 3 to Black-Tooth Smith. | Black-Tooth Smith deals 3 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives, Moonlit Roots at 8/10

Attack 2:
- Attacker: Black-Tooth Smith
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Black-Tooth Smith. | Black-Tooth Smith deals 3 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter removed, Moonlit Roots at 8/10

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Hyena Pack Call, Iron Hyena Champion, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Fang Relic, Iron Hyena Champion

## Turn 24 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 3

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
Forgotten zone count/list: 3 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Leopard Hunter

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
- Main 2: attached Esprit du Léopard to Young Hunter
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Esprit du Léopard
- discarded cards: Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
- board at end: Esprit du Léopard, Leopard Hunter, Young Hunter, Young Hunter [Possession:Esprit du Léopard]

# End of Phase 6 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 5/1
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron None
Forgotten cards: Red 3 | Iron 5
Key events: Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Moonlit Roots) | Shrine Bone-Fang Shrine takes 3. | Main 1: played Young Hunter | Main 1: played Leopard Hunter | Main 2: attached Esprit du Léopard to Young Hunter | Main 2: awakened Grandmother Beneath the Roots
Tempo note: initiative reverses after every four player-turns.

## Turn 25 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Esprit du Léopard, Leopard Hunter, Young Hunter, Young Hunter [Possession:Esprit du Léopard]
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
Forgotten zone count/list: 3 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: resolved Offering of Milk and Ash (restored 1 to Moonlit Roots)

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Black-Tooth Smith deals 2 to Leopard Hunter. | Leopard Hunter deals 4 to Black-Tooth Smith.
- Result: Leopard Hunter survives, Black-Tooth Smith removed, Bone-Fang Shrine at 7/10

Attack 2:
- Attacker: Young Hunter
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to Young Hunter. | Young Hunter deals 4 to Iron Hyena Champion.
- Result: Young Hunter left battle, Iron Hyena Champion removed

Main 2:
- Main 2: played Baobab Guardian
- Main 2: awakened First Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
- board at end: Baobab Guardian, Leopard Hunter [Wounded], River Hunter, Young Hunter

## Turn 26 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 1

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Fang Relic
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: prepared False Opening
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- Main 2: played Rust Hyena Spirit

End:
- retained card: Bone Spear
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Iron Hyena Raider, Rust Hyena Spirit

## Turn 27 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian, Leopard Hunter [Wounded], River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
Forgotten zone count/list: 4 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 5 to 3.
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 4/10

Attack 2:
- Attacker: Young Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: prepared Hunter’s Call

End:
- retained card: Esprit du Léopard
- discarded cards: Root-Woven Guard, Pale River Spirit
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 5 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
- board at end: Baobab Guardian, Leopard Hunter, River Hunter, River Hunter

## Turn 28 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Fang Relic, Rust Hyena Spirit
Prepared Tactic: False Opening
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Rust Hyena Spirit
- Main 1: attached Bone Spear to Rust Hyena Spirit

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 5 to Rust Hyena Spirit. | Rust Hyena Spirit deals 3 to Leopard Hunter.
- Result: Rust Hyena Spirit left battle, Leopard Hunter survives

Main 2:
- Main 2: played Iron Hyena Raider
- Main 2: played Black-Tooth Smith

End:
- retained card: Rust Hyena Spirit
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Fang Relic, Iron Hyena Raider

# End of Phase 7 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/1 | Iron 1/1
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 4 | Iron 6
Key events: Leopard Hunter deals 5 to Rust Hyena Spirit. | Rust Hyena Spirit deals 3 to Leopard Hunter. | Main 1: attached Bone Spear to Rust Hyena Spirit | Main 1: attached Bone Spear to Rust Hyena Spirit | Main 2: played Iron Hyena Raider | Main 2: played Black-Tooth Smith
Tempo note: initiative reverses after every four player-turns.

## Turn 29 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Rust Hyena Spirit]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Fang Relic, Iron Hyena Raider
Prepared Tactic: False Opening
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Rust Hyena Spirit

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 5 to 3. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 3 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 5 to 3.
- Damage: Leopard Hunter deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Leopard Hunter.
- Result: Iron Hyena Raider left battle, Leopard Hunter removed

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Fang Relic, Rust Hyena Spirit

## Turn 30 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 1

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian, River Hunter, River Hunter
Prepared Tactic: Hunter’s Call
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
Forgotten zone count/list: 4 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Esprit du Léopard to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 6.
- Result: River Hunter survives, Bone-Fang Shrine at 0/10

Main 2:
- pass

End:
- retained card: Deep River Spirit
- discarded cards: Root-Woven Guard, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
- board at end: Baobab Guardian, Esprit du Léopard, River Hunter, River Hunter, River Hunter [Possession:Esprit du Léopard]

## Turn 31 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Fang Relic, Rust Hyena Spirit
Prepared Tactic: False Opening
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 2 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Baobab Guardian.
- Result: Rust Hyena Spirit left battle, Baobab Guardian survives

Attack 2:
- Attacker: Black-Tooth Smith
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1. | Black-Tooth Smith becomes Wounded.
- Damage: Baobab Guardian deals 1 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Baobab Guardian.
- Result: Black-Tooth Smith survives, Baobab Guardian removed

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: played Iron Hyena Raider
- Main 2: awakened Tooth-Mother of the Dry Earth

End:
- retained card: Iron Hyena Underworld
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Wounded], Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Fang Relic, Iron Hyena Raider

## Turn 32 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Esprit du Léopard, River Hunter, River Hunter, River Hunter [Possession:Esprit du Léopard]
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 3/10
Forgotten zone count/list: 5 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 3 to 2.
- Damage: Black-Tooth Smith deals 2 to River Hunter. | River Hunter deals 3 to Black-Tooth Smith.
- Result: River Hunter left battle, Black-Tooth Smith removed

Main 2:
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Deep River Spirit, Spear of First Dawn, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
- board at end: Esprit du Léopard, Leopard Hunter [Wounded, Possession:Esprit du Léopard], River Hunter

# End of Phase 8 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/3 | Iron 3/0
Awakened Ancestors: Red First Hunter | Iron Tooth-Mother of the Dry Earth
Forgotten cards: Red 5 | Iron 6
Key events: Main 2: played Bone-Cracker Cub | Main 2: played Iron Hyena Raider | Main 2: awakened Tooth-Mother of the Dry Earth | Black-Tooth Smith deals 2 to River Hunter. | River Hunter deals 3 to Black-Tooth Smith. | Main 1: evolved River Hunter into Leopard Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 33 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 3

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Esprit du Léopard, Leopard Hunter [Wounded, Possession:Esprit du Léopard], River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
Forgotten zone count/list: 5 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Iron Hyena Den)
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to River Hunter. | River Hunter deals 3 to Iron Hyena Raider.
- Result: River Hunter left battle, Iron Hyena Raider removed

Main 2:
- pass

End:
- retained card: Spear of First Dawn
- discarded cards: Hunter’s Call, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
- board at end: Esprit du Léopard, Kuma Who Wounded the Sun [Possession:Esprit du Léopard], Young Hunter

## Turn 34 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Tooth-Mother of the Dry Earth
Shrine state: Iron Hyena Den: 3/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Moonlit Roots)

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 8 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Kuma Who Wounded the Sun.
- Result: Bone-Cracker Cub left battle, Kuma Who Wounded the Sun survives, Moonlit Roots at 7/10

Main 2:
- pass

End:
- retained card: Iron Hyena Underworld
- discarded cards: Bone-Cracker Cub, Iron Guard, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 3/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Fang Relic, Fang Relic, Iron Hyena Champion [Relic:Fang Relic]

## Turn 35 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 3

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Esprit du Léopard, Kuma Who Wounded the Sun [Wounded, Possession:Esprit du Léopard], Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 3/10
Forgotten zone count/list: 5 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 9 to 6. | Pierce overflow deals 3 to Iron Hyena Den.
- Damage: Iron Hyena Champion deals 6 to Kuma Who Wounded the Sun. | Kuma Who Wounded the Sun deals 6 to Iron Hyena Champion. | Shrine Iron Hyena Den takes 3.
- Result: Kuma Who Wounded the Sun left battle, Iron Hyena Champion removed, Iron Hyena Den at 4/10

Main 2:
- pass

End:
- retained card: Spear of First Dawn
- discarded cards: Pale River Spirit, Deep River Spirit, Baobab Guardian
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 5 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 4/10
- board at end: Leopard Hunter

## Turn 36 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Bone Spear, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Tooth-Mother of the Dry Earth
Shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Iron Hyena Underworld, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider

# End of Phase 9 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 4/10] | Iron [Iron Hyena Den: 6/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/5 | Iron 5/0
Awakened Ancestors: Red First Hunter | Iron Tooth-Mother of the Dry Earth
Forgotten cards: Red 6 | Iron 7
Key events: Iron Hyena Champion deals 6 to Kuma Who Wounded the Sun. | Kuma Who Wounded the Sun deals 6 to Iron Hyena Champion. | Shrine Iron Hyena Den takes 3. | Main 1: evolved Young Hunter into Leopard Hunter | Main 1: played Iron Hyena Raider | Main 1: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 37 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Tooth-Mother of the Dry Earth
Shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Leopard Hunter deals 4 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Leopard Hunter.
- Result: Iron Hyena Raider left battle, Leopard Hunter removed, Moonlit Roots at 6/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 3.
- Result: Bone-Cracker Cub survives, Moonlit Roots at 3/10

Main 2:
- Main 2: played Iron Hyena Champion
- Main 2: played Iron Hyena Raider

End:
- retained card: Hyena Pack Call
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Champion, Iron Hyena Raider

## Turn 38 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 5

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 7/10
Forgotten zone count/list: 6 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

Combat:
- no attacks

Main 2:
- Main 2: prepared Root-Woven Guard
- Main 2: awakened Child Who Remembered the Dead

End:
- retained card: Spear of First Dawn
- discarded cards: River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 6/10
- board at end: River Hunter, Young Hunter

## Turn 39 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Champion, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Tooth-Mother of the Dry Earth
Shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: Root-Woven Guard
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 4.
- Result: Bone-Cracker Cub survives, Moonlit Roots at 0/10

Main 2:
- Main 2: played Iron Hyena Raider
- Main 2: played Black-Tooth Smith
- Main 2: awakened Ancestor of the Iron Hyena

End:
- retained card: Hyena Pack Call
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: Black-Tooth Smith
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Fang Relic, Iron Hyena Champion, Iron Hyena Raider, Iron Hyena Raider

## Turn 40 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 2

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Child Who Remembered the Dead
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 7 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter

Combat:

Attack 1:
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
- retained card: Spear of First Dawn
- discarded cards: Spear of First Dawn, Root-Woven Guard, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 5 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Leopard Hunter

# End of Phase 10 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10] | Iron [Iron Hyena Den: 6/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/2 | Iron 1/0
Awakened Ancestors: Red First Hunter | Iron Ancestor of the Iron Hyena
Forgotten cards: Red 7 | Iron 7
Key events: Main 2: played Black-Tooth Smith | Main 2: awakened Ancestor of the Iron Hyena | Iron Hyena Champion deals 5 to River Hunter. | River Hunter deals 3 to Iron Hyena Champion. | Main 1: evolved Young Hunter into Leopard Hunter | Main 2: awakened First Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 41 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 2

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Leopard Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 7 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Spear of First Dawn to Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | WeaponMaster grants Pierce. | Pierce overflow deals 6 to Iron Hyena Den.
- Damage: Iron Hyena Raider deals 3 to Leopard Hunter. | Leopard Hunter deals 8 to Iron Hyena Raider. | Shrine Iron Hyena Den takes 6.
- Result: Leopard Hunter survives, Iron Hyena Raider removed, Iron Hyena Den at 0/10

Main 2:
- Main 2: played Deep River Spirit

End:
- retained card: Baobab Guardian
- discarded cards: Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Deep River Spirit, Leopard Hunter [Wounded, Relic:Spear of First Dawn], River Hunter, Spear of First Dawn

## Turn 42 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Fang Relic, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab)
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 2.
- Result: Black-Tooth Smith survives, Shrine of the Red Baobab at 5/10

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 3.
- Result: Iron Hyena Raider survives, Shrine of the Red Baobab at 2/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Black-Tooth Smith, Bone Spear, Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Fang Relic, Iron Hyena Champion [Relic:Fang Relic], Iron Hyena Raider

## Turn 43 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: Deep River Spirit, Leopard Hunter [Wounded, Relic:Spear of First Dawn], River Hunter, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 8/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 7 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 8 to 6.
- Damage: Iron Hyena Champion deals 6 to Leopard Hunter. | Leopard Hunter deals 6 to Iron Hyena Champion.
- Result: Leopard Hunter left battle, Iron Hyena Champion removed, Rusted Moon Shrine at 10/10

Attack 2:
- Attacker: River Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 4.
- Result: River Hunter survives, Rusted Moon Shrine at 6/10

Main 2:
- Main 2: played Baobab Guardian

End:
- retained card: Esprit du Léopard
- discarded cards: Pale River Spirit
- forgotten cards: None
- Wounded clears: Baobab Guardian
- resources at end: 2 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 8/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Deep River Spirit, River Hunter, River Hunter, Young Hunter

## Turn 44 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Black-Tooth Smith, Bone Spear, Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 4/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Deep River Spirit.
- Result: Black-Tooth Smith left battle, Deep River Spirit survives

Attack 2:
- Attacker: Black-Tooth Smith
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2. | Black-Tooth Smith becomes Wounded. | Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 2 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Deep River Spirit.
- Result: Black-Tooth Smith survives, Deep River Spirit survives

Attack 3:
- Attacker: Iron Hyena Raider
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2.
- Damage: Deep River Spirit deals 2 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Deep River Spirit.
- Result: Iron Hyena Raider left battle, Deep River Spirit removed

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: played Rust Hyena Spirit

End:
- retained card: Rust Hyena Spirit
- discarded cards: Iron Hyena Underworld
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 4/10
- board at end: Black-Tooth Smith, Black-Tooth Smith [Wounded], Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Rust Hyena Spirit

# End of Phase 11 Summary

Shrine state: Red [Shrine of the Red Baobab: 8/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10] | Iron [Iron Hyena Den: 12/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 4/10]
Resources: Red 2/2 | Iron 2/0
Awakened Ancestors: Red First Hunter | Iron Ancestor of the Iron Hyena
Forgotten cards: Red 7 | Iron 7
Key events: Black-Tooth Smith deals 2 to Deep River Spirit. | Deep River Spirit deals 2 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Deep River Spirit. | Main 1: played Bone-Cracker Cub | Main 2: played Black-Tooth Smith | Main 2: played Rust Hyena Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 45 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Rust Hyena Spirit]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Black-Tooth Smith [Wounded], Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Rust Hyena Spirit
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 4/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab)
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 2 to 1. | Black-Tooth Smith becomes Wounded. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 2 to Black-Tooth Smith. | Black-Tooth Smith deals 1 to Baobab Guardian.
- Result: Black-Tooth Smith survives, Baobab Guardian survives

Attack 2:
- Attacker: Black-Tooth Smith
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1. | Black-Tooth Smith becomes Wounded. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 1 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Baobab Guardian.
- Result: Black-Tooth Smith survives, Baobab Guardian survives

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1.
- Damage: Baobab Guardian deals 1 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Baobab Guardian.
- Result: Bone-Cracker Cub left battle, Baobab Guardian removed

Main 2:
- pass

End:
- retained card: Rust Hyena Spirit
- discarded cards: Bone-Cracker Cub, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 4/10
- board at end: Black-Tooth Smith [Wounded], Black-Tooth Smith [Wounded], Bone Spear, Fang Relic, Iron Hyena Champion [Relic:Fang Relic], Rust Hyena Spirit

## Turn 46 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 3

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: River Hunter, River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 9/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 7 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 3.
- Result: Young Hunter survives, Rusted Moon Shrine at 3/10

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Young Hunter, River Hunter, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 9/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Leopard Hunter, River Hunter, Young Hunter

## Turn 47 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Rust Hyena Spirit]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Wounded], Black-Tooth Smith [Wounded], Bone Spear, Fang Relic, Iron Hyena Champion [Relic:Fang Relic], Rust Hyena Spirit
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 7/10
Forgotten zone count/list: 8 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Hyena Pack Call, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Black-Tooth Smith

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 3 to 2. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives, Shrine of the Red Baobab at 1/10

Attack 2:
- Attacker: Black-Tooth Smith
- Target: Shrine of the Red Baobab
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 2 to 1. | River Hunter becomes Wounded.
- Damage: River Hunter deals 3 to Black-Tooth Smith. | Black-Tooth Smith deals 1 to River Hunter.
- Result: Black-Tooth Smith left battle, River Hunter survives, Shrine of the Red Baobab at 1/10

Attack 3:
- Attacker: Iron Hyena Champion
- Target: Shrine of the Red Baobab
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces River Hunter from 3 to 2. | Iron Hyena Champion becomes Wounded.
- Damage: River Hunter deals 2 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to River Hunter.
- Result: Iron Hyena Champion survives, River Hunter removed, Shrine of the Red Baobab at 1/10

Main 2:
- Main 2: played Rust Hyena Spirit
- Main 2: played Black-Tooth Smith

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 7/10
- board at end: Black-Tooth Smith, Bone Spear, Fang Relic, Iron Hyena Champion [Wounded, Relic:Fang Relic], Rust Hyena Spirit, Rust Hyena Spirit

## Turn 48 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 4

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Leopard Hunter [Wounded], Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 9/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 7 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: attached Spear of First Dawn to Young Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 5 to 3.
- Damage: Shrine Rusted Moon Shrine takes 3.
- Result: Leopard Hunter survives, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Root-Woven Guard
- discarded cards: Esprit du Léopard, Hunter’s Call, Esprit du Léopard
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 6 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 9/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Leopard Hunter, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn]

# End of Phase 12 Summary

Shrine state: Red [Shrine of the Red Baobab: 9/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10] | Iron [Iron Hyena Den: 12/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 7/10]
Resources: Red 6/4 | Iron 2/0
Awakened Ancestors: Red First Hunter | Iron Ancestor of the Iron Hyena
Forgotten cards: Red 7 | Iron 8
Key events: Iron Hyena Champion deals 6 to River Hunter. | Main 1: attached Bone Spear to Black-Tooth Smith | Main 2: played Rust Hyena Spirit | Main 2: played Black-Tooth Smith | Shrine Rusted Moon Shrine takes 3. | Main 1: attached Spear of First Dawn to Young Hunter
Tempo note: initiative reverses after every four player-turns.

## End-of-game summary

Winner: red
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Shrine of the Red Baobab 9/10, Hunter’s Root-Stone 11/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 12/10, Bone-Fang Shrine 12/10, Rusted Moon Shrine 10/10]
Final resources: Red 6/4 | Iron 2/0
Final Presence: Seat 1 2/5 | Seat 2 4/5

Turn count: 48
Phase count: 12

First Shrine damage: 5
First Shrine broken: 21
First Ancestor awakened: 9
First L2: 11
First L3: 33

Red L2 entries: 7 (hard-cast 2, evolved 5)
Red L3 entries: 1 (hard-cast 0, evolved 1)
Iron L2 entries: 5 (hard-cast 1, evolved 4)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 22, Iron 12
Legal L2 evolve actions: Red 20, Iron 12
Legal L3 evolve actions: Red 2, Iron 0
Evolve windows: Red 12, Iron 8
Turns with legal L2 evolution: Red 10, Iron 8
Turns with legal L3 evolution: Red 2, Iron 0
Evolve actions chosen: Red 18, Iron 12
Hard-cast chosen while legal evolve action existed: Red 1, Iron 1
Hard-cast chosen while evolution base existed: Red 8, Iron 0

Legal awaken actions generated: Red 40, Iron 4
Awaken actions chosen: Red 15, Iron 2
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.firsthunter, Iron iron.ancestor.toothmother
Ancestor switches: Red 8, Iron 1
Turns with awakened ancestor: Red 19, Iron 8
Memory spent on ancestors: Red 18, Iron 4
Ancestor realized value: First Hunter +10 damage, Grandmother healed 3, Child draw/discard 1, Iron Hyena +1 damage, Smith saved 0 Offerings, Tooth-Mother +1 damage

Prepared Tactics triggered: Red 2, Iron 4
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 7, Iron 8
Wounded events: Red 15, Iron 5
Wounded reduced damage: Red 14, Iron 4
Pierce overflow events: Red 2, Iron 0
WeaponMaster Pierce events: 1
SoulSlayer Pierce events: 0
Legal block options: Red 11, Iron 8
Blocks chosen: Red 8, Iron 4
Blocks declined: Red 0, Iron 2
Assault slots spent: Seat 1 standard 21, pack 0 | Seat 2 standard 15, pack 12
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 48, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 20, generated 20, available 20, skipped 8, turns-with-bonus 12, max-attacks 68, prevented-by-limit 0
Deck reshuffles: Red 4, Iron 4

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
