# Test Game #141

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
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Iron Snare]

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
Forgotten cards: Red 1 | Iron 2
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
- Prepared triggers: None
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
- resources at end: 3 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
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
Memory before resource: 2

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
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
- resources at end: 0 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
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
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter survives, Hunter’s Root-Stone at 10/10

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

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/4 | Iron 1/0
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 1 | Iron 2
Key events: Main 1: played Leopard Hunter | Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Leopard Hunter. | Main 1: attached Fang Relic to Bone-Cracker Cub | Main 1: attached Bone Spear to Bone-Cracker Cub | Main 2: played Rust Hyena Spirit
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
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 3 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Leopard Hunter.
- Result: Rust Hyena Spirit left battle, Leopard Hunter survives

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
Memory before resource: 4

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Leopard Hunter [Wounded], Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 6 to 4.
- Damage: Shrine Bone-Fang Shrine takes 4.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 6/10

Attack 2:
- Attacker: Young Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 4.
- Result: Young Hunter survives, Bone-Fang Shrine at 2/10

Main 2:
- Main 2: attached Spear of First Dawn to Young Hunter
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Pale River Spirit
- discarded cards: Deep River Spirit
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 1 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, River Hunter, River Hunter, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn]

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Iron Hyena Raider]

Board before ready:
Beings/Spirits: Fang Relic
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Bone-Cracker Cub, Rust Hyena Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Fang Relic, Iron Hyena Raider

## Turn 16 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 2

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Leopard Hunter, River Hunter, River Hunter, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn]
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Bone-Fang Shrine and broke it)

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
- Main 2: played Pale River Spirit

End:
- retained card: Ritual of Red Moon
- discarded cards: Baobab Guardian, Young Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
- board at end: Kuma Who Wounded the Sun, Pale River Spirit, River Hunter, River Hunter

# End of Phase 4 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/1 | Iron 5/1
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron None
Forgotten cards: Red 1 | Iron 4
Key events: Main 1: played Iron Hyena Raider | Main 1: played Bone-Cracker Cub | Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 3 to Iron Hyena Raider. | Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Bone-Fang Shrine and broke it) | Main 2: played Pale River Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Kuma Who Wounded the Sun, Pale River Spirit, River Hunter, River Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

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
- Main 2: resolved Ritual of Red Moon (had no legal target)
- Main 2: awakened First Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Baobab Guardian, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: Kuma Who Wounded the Sun, Pale River Spirit, River Hunter

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 1

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Fang Relic
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:
- no attacks

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Iron Hyena Underworld
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Relic:Bone Spear], Bone Spear, Bone-Cracker Cub, Fang Relic, Hyena Token, Hyena Token

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Kuma Who Wounded the Sun, Pale River Spirit, River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: Kuma Who Wounded the Sun becomes Wounded.
- Damage: Black-Tooth Smith deals 3 to Kuma Who Wounded the Sun. | Kuma Who Wounded the Sun deals 6 to Black-Tooth Smith.
- Result: Kuma Who Wounded the Sun survives, Black-Tooth Smith removed

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Pale River Spirit, Hunter’s Call, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: Kuma Who Wounded the Sun [Wounded], Leopard Hunter, Pale River Spirit

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Fang Relic, Hyena Token, Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Hyena Pack Call, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed, Hunter’s Root-Stone at 8/10

Attack 2:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 1.
- Result: Hyena Token survives, Hunter’s Root-Stone at 7/10

Attack 3:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 1.
- Result: Hyena Token survives, Hunter’s Root-Stone at 6/10

Main 2:
- Main 2: prepared Iron Snare
- Main 2: awakened Ancestor of the Iron Hyena

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Underworld, False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Hyena Token, Hyena Token

# End of Phase 5 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/1 | Iron 5/0
Awakened Ancestors: Red First Hunter | Iron Ancestor of the Iron Hyena
Forgotten cards: Red 2 | Iron 5
Key events: Bone-Cracker Cub deals 4 to Leopard Hunter. | Shrine Hunter’s Root-Stone takes 1. | Shrine Hunter’s Root-Stone takes 1. | Main 1: attached Fang Relic to Bone-Cracker Cub | Main 2: prepared Iron Snare | Main 2: awakened Ancestor of the Iron Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Fang Relic, Hyena Token, Hyena Token
Prepared Tactic: Iron Snare
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Hyena Pack Call, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Black-Tooth Smith

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 1.
- Result: Hyena Token survives, Hunter’s Root-Stone at 5/10

Attack 2:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 1.
- Result: Hyena Token survives, Hunter’s Root-Stone at 4/10

Main 2:
- Main 2: played Rust Hyena Spirit

End:
- retained card: Black-Tooth Smith
- discarded cards: False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Fang Relic, Hyena Token, Hyena Token, Iron Hyena Raider, Rust Hyena Spirit

## Turn 22 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 2

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Kuma Who Wounded the Sun [Wounded], Pale River Spirit
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Esprit du Léopard to Kuma Who Wounded the Sun

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 8 to 6. | Kuma Who Wounded the Sun becomes Wounded.
- Damage: Black-Tooth Smith deals 2 to Kuma Who Wounded the Sun. | Kuma Who Wounded the Sun deals 6 to Black-Tooth Smith.
- Result: Kuma Who Wounded the Sun survives, Black-Tooth Smith removed

Attack 2:
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
- retained card: Root-Woven Guard
- discarded cards: Offering of Milk and Ash, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
- board at end: Kuma Who Wounded the Sun [Wounded, Possession:Esprit du Léopard], River Hunter

## Turn 23 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Fang Relic, Hyena Token, Hyena Token, Rust Hyena Spirit
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, Hyena Pack Call, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Hyena Token

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: Kuma Who Wounded the Sun
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 8 to 6. | Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 6 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Kuma Who Wounded the Sun.
- Result: Rust Hyena Spirit left battle, Kuma Who Wounded the Sun survives

Attack 2:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Hyena Token survives, Hunter’s Root-Stone at 0/10

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: played Iron Guard

End:
- retained card: Hyena Pack Call
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 3 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Fang Relic, Hyena Token, Hyena Token [Relic:Bone Spear], Iron Guard

## Turn 24 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 4

Hand before draw: [Root-Woven Guard]

Board before ready:
Beings/Spirits: Kuma Who Wounded the Sun [Wounded, Possession:Esprit du Léopard], River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Esprit du Léopard to Kuma Who Wounded the Sun

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 8 to 6. | Kuma Who Wounded the Sun becomes Wounded.
- Damage: Black-Tooth Smith deals 2 to Kuma Who Wounded the Sun. | Kuma Who Wounded the Sun deals 6 to Black-Tooth Smith.
- Result: Kuma Who Wounded the Sun survives, Black-Tooth Smith removed

Main 2:
- Main 2: prepared Root-Woven Guard

End:
- retained card: Offering of Milk and Ash
- discarded cards: Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, Kuma Who Wounded the Sun [Wounded, Possession:Esprit du Léopard], River Hunter, Young Hunter

# End of Phase 6 Summary

Shrine state: Red [Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10]
Resources: Red 4/3 | Iron 2/3
Awakened Ancestors: Red First Hunter | Iron Ancestor of the Iron Hyena
Forgotten cards: Red 2 | Iron 6
Key events: Main 2: played Iron Guard | Black-Tooth Smith deals 2 to Kuma Who Wounded the Sun. | Kuma Who Wounded the Sun deals 6 to Black-Tooth Smith. | Main 1: played Young Hunter | Main 1: attached Esprit du Léopard to Kuma Who Wounded the Sun | Main 2: prepared Root-Woven Guard
Tempo note: initiative reverses after every four player-turns.

## Turn 25 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 3

Hand before draw: [Offering of Milk and Ash]

Board before ready:
Beings/Spirits: Esprit du Léopard, Kuma Who Wounded the Sun [Wounded, Possession:Esprit du Léopard], River Hunter, Young Hunter
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Esprit du Léopard to Kuma Who Wounded the Sun

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Iron Guard
- Defender/blocker: Iron Guard
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 8 to 6. | Kuma Who Wounded the Sun becomes Wounded.
- Damage: Iron Guard deals 2 to Kuma Who Wounded the Sun. | Kuma Who Wounded the Sun deals 6 to Iron Guard.
- Result: Kuma Who Wounded the Sun survives, Iron Guard removed

Main 2:
- Main 2: resolved Offering of Milk and Ash (restored 3 to Shrine of the Red Baobab)

End:
- retained card: Pale River Spirit
- discarded cards: Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, Kuma Who Wounded the Sun [Wounded, Possession:Esprit du Léopard], River Hunter, Young Hunter, Young Hunter

## Turn 26 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 3

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone Spear, Fang Relic, Hyena Token, Hyena Token [Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, Hyena Pack Call, Iron Snare, Iron Snare]

Main 1:
- Main 1: evolved Hyena Token into Iron Hyena Champion (dealt 2 to Moonlit Roots)

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Moonlit Roots
- Defender/blocker: Young Hunter
- Prepared triggers: Root-Woven Guard
- Wounded/Pierce calculations: None
- Damage: Young Hunter deals 2 to Hyena Token. | Hyena Token deals 1 to Young Hunter.
- Result: Hyena Token left battle, Young Hunter removed, Moonlit Roots at 8/10

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Pack Call, Iron Guard, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 3 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Fang Relic, Iron Hyena Champion [Relic:Bone Spear]

## Turn 27 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 4

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Esprit du Léopard, Kuma Who Wounded the Sun [Wounded, Possession:Esprit du Léopard], River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 2/10
Forgotten zone count/list: 4 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Spear of First Dawn to Kuma Who Wounded the Sun

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 12 to 9. | Pierce overflow deals 6 to Iron Hyena Den.
- Damage: Iron Hyena Champion deals 6 to Kuma Who Wounded the Sun. | Kuma Who Wounded the Sun deals 9 to Iron Hyena Champion. | Shrine Iron Hyena Den takes 6.
- Result: Kuma Who Wounded the Sun left battle, Iron Hyena Champion removed, Iron Hyena Den at 4/10

Main 2:
- Main 2: played Pale River Spirit
- Main 2: prepared Hunter’s Call

End:
- retained card: Ritual of Red Moon
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 6 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 3/10
- board at end: Pale River Spirit, River Hunter, Young Hunter, Young Hunter

## Turn 28 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 3

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Fang Relic
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, Hyena Pack Call, Iron Snare, Iron Snare]

Main 1:
- Main 1: prepared False Opening
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Rust Hyena Spirit
- discarded cards: Hyena Pack Call, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Fang Relic

# End of Phase 7 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 3/10] | Iron [Iron Hyena Den: 6/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10]
Resources: Red 2/6 | Iron 6/2
Awakened Ancestors: Red First Hunter | Iron Ancestor of the Iron Hyena
Forgotten cards: Red 5 | Iron 6
Key events: Main 1: played Young Hunter | Main 1: attached Spear of First Dawn to Kuma Who Wounded the Sun | Main 2: played Pale River Spirit | Main 2: prepared Hunter’s Call | Main 1: prepared False Opening | Main 1: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 29 — Iron

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 2

Hand before draw: [Rust Hyena Spirit]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Fang Relic
Prepared Tactic: False Opening
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, Hyena Pack Call, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Young Hunter deals 2 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Young Hunter.
- Result: Bone-Cracker Cub left battle, Young Hunter removed, Moonlit Roots at 7/10

Main 2:
- Main 2: played Rust Hyena Spirit

End:
- retained card: Iron Hyena Underworld
- discarded cards: False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Iron Hyena Raider, Iron Hyena Raider, Rust Hyena Spirit

## Turn 30 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 6

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Pale River Spirit, River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 3/10
Forgotten zone count/list: 6 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Spear of First Dawn to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 7.
- Result: River Hunter survives, Iron Hyena Den at 0/10

Attack 2:
- Attacker: Young Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: resolved Ritual of Red Moon (dealt 2 to Iron Hyena Raider, destroyed it, gained 1 Memory)

End:
- retained card: Deep River Spirit
- discarded cards: Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 8 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 3/10
- board at end: Pale River Spirit, River Hunter, River Hunter [Relic:Spear of First Dawn], Spear of First Dawn

## Turn 31 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 2

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Fang Relic, Rust Hyena Spirit
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Hyena Pack Call, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Rust Hyena Spirit
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: River Hunter
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: River Hunter deals 4 to Rust Hyena Spirit. | Rust Hyena Spirit deals 3 to River Hunter.
- Result: Rust Hyena Spirit left battle, River Hunter removed

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: awakened Smith of Black Teeth

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone-Cracker Cub, Fang Relic

## Turn 32 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 8

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Pale River Spirit, River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 4/10
Forgotten zone count/list: 7 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter

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
- retained card: Leopard Hunter
- discarded cards: Deep River Spirit, Baobab Guardian, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 10 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 4/10
- board at end: Leopard Hunter

# End of Phase 8 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 4/10] | Iron [Iron Hyena Den: 13/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/10 | Iron 2/1
Awakened Ancestors: Red First Hunter | Iron Smith of Black Teeth
Forgotten cards: Red 7 | Iron 7
Key events: Main 1: played Bone-Cracker Cub | Main 2: played Black-Tooth Smith | Main 2: awakened Smith of Black Teeth | Bone-Cracker Cub deals 2 to Pale River Spirit. | Pale River Spirit deals 2 to Bone-Cracker Cub. | Main 1: evolved River Hunter into Leopard Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 33 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 10

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Leopard Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 4/10
Forgotten zone count/list: 7 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: played River Hunter
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 5.
- Result: Leopard Hunter survives, Rusted Moon Shrine at 5/10

Main 2:
- Main 2: prepared Root-Woven Guard
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Baobab Guardian
- discarded cards: Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 3/10
- board at end: Leopard Hunter, Leopard Hunter, River Hunter

## Turn 34 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 5/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Hyena Pack Call, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Black-Tooth Smith
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: Root-Woven Guard
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 3 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives, Moonlit Roots at 7/10

Main 2:
- Main 2: played Iron Guard

End:
- retained card: Iron Hyena Underworld
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 5/10
- board at end: Bone-Cracker Cub, Fang Relic, Iron Guard

## Turn 35 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 7

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: Leopard Hunter, Leopard Hunter [Wounded], River Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 3/10
Forgotten zone count/list: 8 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Guard
- Defender/blocker: Iron Guard
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Iron Guard deals 2 to Leopard Hunter. | Leopard Hunter deals 4 to Iron Guard.
- Result: Leopard Hunter survives, Iron Guard removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Baobab Guardian, Young Hunter
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 5 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 2/10
- board at end: Leopard Hunter, Leopard Hunter [Wounded], River Hunter, River Hunter, Young Hunter

## Turn 36 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 1

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 5/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Hyena Pack Call, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Black-Tooth Smith

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: River Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to River Hunter.
- Result: Bone-Cracker Cub left battle, River Hunter removed, Moonlit Roots at 8/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Underworld, Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 5/10
- board at end: Black-Tooth Smith, Bone-Cracker Cub, Fang Relic

# End of Phase 9 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 2/10] | Iron [Iron Hyena Den: 13/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 5/10]
Resources: Red 5/5 | Iron 4/1
Awakened Ancestors: Red First Hunter | Iron Smith of Black Teeth
Forgotten cards: Red 8 | Iron 7
Key events: Main 1: played River Hunter | Main 2: awakened First Hunter | River Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to River Hunter. | Main 1: played Bone-Cracker Cub | Main 1: played Black-Tooth Smith
Tempo note: initiative reverses after every four player-turns.

## Turn 37 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone-Cracker Cub, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 5/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Hyena Pack Call, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives, Moonlit Roots at 8/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed, Moonlit Roots at 8/10

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: played Iron Hyena Champion

End:
- retained card: Rust Hyena Spirit
- discarded cards: Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 5/10
- board at end: Black-Tooth Smith, Fang Relic, Iron Hyena Champion

## Turn 38 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 6

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Leopard Hunter [Wounded], River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 2/10
Forgotten zone count/list: 8 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: attached Esprit du Léopard to Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 7 to 5.
- Damage: Shrine Rusted Moon Shrine takes 5.
- Result: Leopard Hunter survives, Rusted Moon Shrine at 0/10

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Esprit du Léopard
- discarded cards: Pale River Spirit, Deep River Spirit, Deep River Spirit
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 6 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 1/10
- board at end: Esprit du Léopard, Leopard Hunter [Possession:Esprit du Léopard], River Hunter, Young Hunter

## End-of-game summary

Winner: red
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Shrine of the Red Baobab 0/10, Hunter’s Root-Stone 10/10, Moonlit Roots 1/10] | Iron [Iron Hyena Den 13/10, Bone-Fang Shrine 11/10, Rusted Moon Shrine 10/10]
Final resources: Red 6/3 | Iron 0/1
Final Presence: Seat 1 3/5 | Seat 2 2/5

Turn count: 38
Phase count: 10

First Shrine damage: 5
First Shrine broken: 16
First Ancestor awakened: 9
First L2: 11
First L3: 16

Red L2 entries: 4 (hard-cast 2, evolved 2)
Red L3 entries: 1 (hard-cast 0, evolved 1, recalled 0)
Iron L2 entries: 2 (hard-cast 1, evolved 1)
Iron L3 entries: 0 (hard-cast 0, evolved 0, recalled 0)

Legal evolve actions generated: Red 8, Iron 8
Legal L2 evolve actions: Red 6, Iron 8
Legal L3 evolve actions: Red 2, Iron 0
Evolve windows: Red 6, Iron 2
Turns with legal L2 evolution: Red 4, Iron 2
Turns with legal L3 evolution: Red 2, Iron 0
Evolve actions chosen: Red 8, Iron 4
Hard-cast chosen while legal evolve action existed: Red 1, Iron 0
Hard-cast chosen while evolution base existed: Red 7, Iron 0

Legal awaken actions generated: Red 40, Iron 5
Awaken actions chosen: Red 13, Iron 3
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.firsthunter, Iron iron.ancestor.hyena
Ancestor switches: Red 5, Iron 1
Turns with awakened ancestor: Red 14, Iron 9
Memory spent on ancestors: Red 12, Iron 4
Ancestor realized value: First Hunter +6 damage, Grandmother healed 4, Child draw/discard 0, Iron Hyena +2 damage, Smith saved 2 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 2, Iron 1
Prepared Tactics expired: Red 1, Iron 2
Fade cards Forgotten: Red 8, Iron 7
Wounded events: Red 10, Iron 0
Wounded reduced damage: Red 10, Iron 0
Pierce overflow events: Red 1, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 11, Iron 1
Blocks chosen: Red 8, Iron 1
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 19, pack 0 | Seat 2 standard 15, pack 1
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 38, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 6, generated 6, available 6, skipped 5, turns-with-bonus 6, max-attacks 44, prevented-by-limit 1
Deck reshuffles: Red 3, Iron 2

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
