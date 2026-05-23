# Test Game #150

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 100 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red red --bot-iron iron --deck-red red-hunter-evolution --deck-iron iron-snarecraft-control

Seat 1:
- red-hunter-evolution [Red] (RedBaobabBot)
Seat 2:
- iron-snarecraft-control [Iron] (IronHyenaBot)

Rules variant:
- Draw model: retain up to 1, discard rest, draw to 5
- Phase model: reverse every 4 player-turns
- Combat model: 2 standard Assault slots, plus Pack expansion up to 5 total attacks, separate resolution
- Battlefield capacity: 5 Presence per seat
- Prepared model: max 1 active tactic per player
- Special mechanics: Fade, Forgotten, Wounded, Pierce, Disperse, Possession, Evolution, Recall, Unique, Pack

Seed: 150
Winner: red-hunter-evolution
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Baobab Guardian, Pale River Spirit, Ritual of Red Moon, Young Hunter, Young Hunter
- Starting hands — Iron: Bite the Roots, Black-Tooth Smith, False Opening, Hyena Pack Call, Rust Hyena Spirit
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the Iron Hyena, Tooth-Mother of the Dry Earth, Smith of Black Teeth

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Baobab Guardian, Pale River Spirit, Ritual of Red Moon, Young Hunter, Young Hunter]

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
- retained card: Ritual of Red Moon
- discarded cards: Baobab Guardian, Pale River Spirit, Young Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Black-Tooth Smith, False Opening, Hyena Pack Call, Rust Hyena Spirit]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- pass

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bite the Roots
- discarded cards: Rust Hyena Spirit, False Opening, Black-Tooth Smith, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Young Hunter survives, Bone-Fang Shrine at 7/10

Main 2:
- pass

End:
- retained card: Ritual of Red Moon
- discarded cards: Hunter’s Call, River Hunter, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: River Hunter, Young Hunter

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Fang Relic, Iron Hyena Underworld, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: 

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 1
Key events: Main 1: played Young Hunter | Shrine Bone-Fang Shrine takes 3. | Main 1: played River Hunter | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Black-Tooth Smith, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Iron Hyena Raider

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

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
- Main 2: resolved Offering of Milk and Ash (restored 3 to Hunter’s Root-Stone)

End:
- retained card: Leopard Hunter
- discarded cards: Ritual of Red Moon, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: River Hunter

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: River Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to River Hunter.
- Result: Bone-Cracker Cub left battle, River Hunter removed, Hunter’s Root-Stone at 7/10

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Iron Hyena Raider, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Offering of Milk and Ash]

Main 1:
- Main 1: played Pale River Spirit

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Baobab Guardian
- discarded cards: Leopard Hunter, Esprit du Léopard, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: Pale River Spirit

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10]
Resources: Red 2/1 | Iron 1/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 2
Key events: Main 2: resolved Offering of Milk and Ash (restored 3 to Hunter’s Root-Stone) | River Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to River Hunter. | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone) | Main 1: played Bone-Cracker Cub | Main 1: played Pale River Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: Pale River Spirit
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Offering of Milk and Ash]

Main 1:
- Main 1: attached Spear of First Dawn to Pale River Spirit
- Main 1: played Baobab Guardian

Combat:

Attack 1:
- Attacker: Pale River Spirit
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to Pale River Spirit. | Pale River Spirit deals 3 to Bone-Cracker Cub.
- Result: Pale River Spirit left battle, Bone-Cracker Cub removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Deep River Spirit
- discarded cards: Deep River Spirit, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: prepared Iron Snare
- Main 1: prepared Iron Snare

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Iron Hyena Champion, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Offering of Milk and Ash]

Main 1:
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: Iron Snare, Iron Snare
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Baobab Guardian survives, Bone-Fang Shrine at 4/10

Main 2:
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Deep River Spirit, Root-Woven Guard, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Leopard Hunter

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Bone-Cracker Cub, Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Iron Hyena Raider

# End of Phase 3 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/1 | Iron 3/0
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 1 | Iron 4
Key events: Main 1: prepared Iron Snare | Main 1: prepared Iron Snare | Shrine Bone-Fang Shrine takes 3. | Main 1: played Leopard Hunter | Main 1: played Bone-Cracker Cub | Main 1: played Iron Hyena Raider
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: attached Bone Spear to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter survives

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Leopard Hunter.
- Result: Iron Hyena Raider left battle, Leopard Hunter removed

Main 2:
- Main 2: played Iron Guard

End:
- retained card: Rust Hyena Spirit
- discarded cards: False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Iron Guard

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 2

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Baobab Guardian
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Offering of Milk and Ash]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Esprit du Léopard to Baobab Guardian

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Iron Guard
- Defender/blocker: Iron Guard
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Iron Guard deals 2 to Baobab Guardian. | Baobab Guardian deals 4 to Iron Guard.
- Result: Baobab Guardian survives, Iron Guard removed

Main 2:
- Main 2: resolved Ritual of Red Moon (had no legal target)
- Main 2: prepared Hunter’s Call

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Wounded, Possession:Esprit du Léopard], Esprit du Léopard, Young Hunter

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Rust Hyena Spirit]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- Main 2: played Rust Hyena Spirit

End:
- retained card: Bone Spear
- discarded cards: False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Bone-Cracker Cub, Rust Hyena Spirit

## Turn 16 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Baobab Guardian [Wounded, Possession:Esprit du Léopard], Esprit du Léopard, Young Hunter
Prepared Tactic: Hunter’s Call
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Spear of First Dawn to Baobab Guardian

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Rust Hyena Spirit
- Defender/blocker: Rust Hyena Spirit
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: None
- Damage: Rust Hyena Spirit deals 2 to Young Hunter. | Young Hunter deals 2 to Rust Hyena Spirit.
- Result: Young Hunter left battle, Rust Hyena Spirit removed

Main 2:
- pass

End:
- retained card: Pale River Spirit
- discarded cards: Kuma Who Wounded the Sun, Deep River Spirit
- forgotten cards: None
- Wounded clears: Baobab Guardian
- resources at end: 5 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Spear of First Dawn, Young Hunter

# End of Phase 4 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/2 | Iron 4/0
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 3 | Iron 5
Key events: Main 1: played Bone-Cracker Cub | Main 2: played Rust Hyena Spirit | Rust Hyena Spirit deals 2 to Young Hunter. | Young Hunter deals 2 to Rust Hyena Spirit. | Main 1: played Young Hunter | Main 1: attached Spear of First Dawn to Baobab Guardian
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 2

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon]

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

Attack 2:
- Attacker: Baobab Guardian
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 6.
- Result: Baobab Guardian survives, Bone-Fang Shrine at 0/10

Main 2:
- Main 2: played Pale River Spirit

End:
- retained card: Spear of First Dawn
- discarded cards: Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub
- Main 1: attached Fang Relic to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 5 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Baobab Guardian.
- Result: Bone-Cracker Cub left battle, Baobab Guardian survives

Main 2:
- Main 2: played Iron Hyena Raider
- Main 2: played Iron Guard

End:
- retained card: Iron Hyena Underworld
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Guard, Iron Hyena Raider

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 3

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Baobab Guardian [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Guard
- Defender/blocker: Iron Guard
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Guard deals 2 to River Hunter. | River Hunter deals 3 to Iron Guard.
- Result: River Hunter left battle, Iron Guard removed

Attack 2:
- Attacker: Young Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: played Leopard Hunter

End:
- retained card: Spear of First Dawn
- discarded cards: Deep River Spirit, Pale River Spirit
- forgotten cards: None
- Wounded clears: Baobab Guardian, Leopard Hunter
- resources at end: 1 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Leopard Hunter, Pale River Spirit, River Hunter, Spear of First Dawn

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Bone Spear
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- Main 2: played Iron Guard

End:
- retained card: Bone Spear
- discarded cards: Iron Hyena Underworld
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Iron Guard, Iron Hyena Raider

# End of Phase 5 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/5 | Iron 3/1
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 3 | Iron 5
Key events: Young Hunter deals 2 to Iron Hyena Raider. | Main 1: played River Hunter | Main 2: played Leopard Hunter | Main 1: played Bone-Cracker Cub | Main 1: played Iron Hyena Raider | Main 2: played Iron Guard
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Iron Guard, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Raider
- Main 1: attached Fang Relic to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Guard
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Iron Guard. | Iron Guard deals 2 to Leopard Hunter.
- Result: Iron Guard left battle, Leopard Hunter survives

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone Spear, Fang Relic, Iron Hyena Raider [Relic:Fang Relic]

## Turn 22 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 5

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, River Hunter, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter
- Main 1: attached Spear of First Dawn to Baobab Guardian

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
- pass

End:
- retained card: Ritual of Red Moon
- discarded cards: Baobab Guardian, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Leopard Hunter, Pale River Spirit, Spear of First Dawn, Spear of First Dawn

## Turn 23 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone Spear, Bone Spear, Fang Relic, Iron Hyena Raider [Relic:Fang Relic]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: prepared False Opening
- Main 1: played Black-Tooth Smith

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Leopard Hunter deals 4 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Leopard Hunter.
- Result: Iron Hyena Raider left battle, Leopard Hunter removed

Main 2:
- pass

End:
- retained card: Rust Hyena Spirit
- discarded cards: Hyena Pack Call, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone Spear

## Turn 24 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 7

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: attached Esprit du Léopard to Baobab Guardian
- Main 1: resolved Ritual of Red Moon (dealt 2 to Black-Tooth Smith)

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 2 to 1. | Baobab Guardian becomes Wounded.
- Damage: Black-Tooth Smith deals 1 to Baobab Guardian. | Baobab Guardian deals 5 to Black-Tooth Smith.
- Result: Baobab Guardian survives, Black-Tooth Smith removed

Main 2:
- pass

End:
- retained card: Ritual of Red Moon
- discarded cards: Root-Woven Guard, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Spear of First Dawn, Spear of First Dawn

# End of Phase 6 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 4/7 | Iron 4/0
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 4 | Iron 5
Key events: Main 1: prepared False Opening | Main 1: played Black-Tooth Smith | Black-Tooth Smith deals 1 to Baobab Guardian. | Baobab Guardian deals 5 to Black-Tooth Smith. | Main 1: attached Esprit du Léopard to Baobab Guardian | Main 1: resolved Ritual of Red Moon (dealt 2 to Black-Tooth Smith)
Tempo note: initiative reverses after every four player-turns.

## Turn 25 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 7

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Baobab Guardian [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 4 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 6 to 4.
- Damage: Shrine Iron Hyena Den takes 4.
- Result: Baobab Guardian survives, Iron Hyena Den at 6/10

Main 2:
- Main 2: resolved Ritual of Red Moon (had no legal target)
- Main 2: awakened Child Who Remembered the Dead

End:
- retained card: Leopard Hunter
- discarded cards: Pale River Spirit
- forgotten cards: None
- Wounded clears: Baobab Guardian
- resources at end: 2 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, River Hunter, River Hunter, Spear of First Dawn, Spear of First Dawn

## Turn 26 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 0

Hand before draw: [Rust Hyena Spirit]

Board before ready:
Beings/Spirits: Bone Spear, Bone Spear
Prepared Tactic: False Opening
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- Main 2: played Rust Hyena Spirit

End:
- retained card: Iron Hyena Champion
- discarded cards: Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Bone-Cracker Cub, Iron Hyena Raider, Rust Hyena Spirit

## Turn 27 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 5

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, River Hunter, River Hunter, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: Child Who Remembered the Dead
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 5 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter

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
- Main 2: awakened First Hunter

End:
- retained card: Leopard Hunter
- discarded cards: Baobab Guardian, Offering of Milk and Ash, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Leopard Hunter [Wounded], Pale River Spirit, Spear of First Dawn, Spear of First Dawn

## Turn 28 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone Spear, Bone Spear, Bone-Cracker Cub, Rust Hyena Spirit
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 3 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Leopard Hunter.
- Result: Rust Hyena Spirit left battle, Leopard Hunter survives

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed

Main 2:
- Main 2: played Iron Hyena Champion
- Main 2: played Bone-Cracker Cub

End:
- retained card: False Opening
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Bone-Cracker Cub, Iron Hyena Champion

# End of Phase 7 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 4/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/5 | Iron 0/1
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 5 | Iron 6
Key events: Rust Hyena Spirit deals 2 to Leopard Hunter. | Leopard Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Leopard Hunter. | Main 1: attached Fang Relic to Bone-Cracker Cub | Main 2: played Iron Hyena Champion | Main 2: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 29 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [False Opening]

Board before ready:
Beings/Spirits: Bone Spear, Bone Spear, Bone-Cracker Cub, Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: prepared False Opening
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Baobab Guardian deals 5 to Iron Hyena Champion. | Iron Hyena Champion deals 5 to Baobab Guardian.
- Result: Iron Hyena Champion left battle, Baobab Guardian removed

Main 2:
- Main 2: played Iron Guard

End:
- retained card: Black-Tooth Smith
- discarded cards: Rust Hyena Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Bone-Cracker Cub, Iron Guard, Iron Hyena Raider

## Turn 30 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 6

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Pale River Spirit, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 5 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Young Hunter

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
- Main 2: played Leopard Hunter

End:
- retained card: Deep River Spirit
- discarded cards: Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 8 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, Spear of First Dawn, Young Hunter, Young Hunter

## Turn 31 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone Spear, Bone Spear, Bone-Cracker Cub, Iron Guard
Prepared Tactic: False Opening
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Guard
- Target: Hunter’s Root-Stone
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Iron Guard. | Iron Guard deals 2 to Leopard Hunter.
- Result: Iron Guard left battle, Leopard Hunter survives, Hunter’s Root-Stone at 8/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed, Hunter’s Root-Stone at 8/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Iron Hyena Champion
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: Black-Tooth Smith
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone Spear, Bone-Cracker Cub, Iron Hyena Raider

## Turn 32 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 9

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Spear of First Dawn, Young Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 5 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Esprit du Léopard to Young Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 4 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: played Deep River Spirit

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 9 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: Deep River Spirit, River Hunter, Spear of First Dawn, Young Hunter

# End of Phase 8 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 4/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/9 | Iron 2/0
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 5 | Iron 6
Key events: Main 2: played Black-Tooth Smith | Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 4 to Iron Hyena Raider. | Main 1: played River Hunter | Main 1: attached Esprit du Léopard to Young Hunter | Main 2: played Deep River Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 33 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 9

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Deep River Spirit, River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 5 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter

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
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Deep River Spirit, Pale River Spirit, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 11 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
- board at end: Deep River Spirit, Leopard Hunter [Wounded], Spear of First Dawn

## Turn 34 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone Spear, Bone Spear, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter survives, Hunter’s Root-Stone at 9/10

Main 2:
- Main 2: played Iron Guard

End:
- retained card: Iron Hyena Underworld
- discarded cards: Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Bone-Cracker Cub, Iron Guard, Iron Hyena Champion

## Turn 35 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 11

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Deep River Spirit, Leopard Hunter [Wounded], Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
Forgotten zone count/list: 5 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Iron Hyena Den)
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Deep River Spirit
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to Deep River Spirit. | Deep River Spirit deals 3 to Iron Hyena Champion.
- Result: Deep River Spirit left battle, Iron Hyena Champion removed

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Hunter’s Call, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 10 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Kuma Who Wounded the Sun, River Hunter, Spear of First Dawn

## Turn 36 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Bone Spear, Bone Spear, Bone-Cracker Cub, Iron Guard
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Iron Guard
- Target: Hunter’s Root-Stone
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 6 to Iron Guard. | Iron Guard deals 2 to Kuma Who Wounded the Sun.
- Result: Iron Guard left battle, Kuma Who Wounded the Sun survives, Hunter’s Root-Stone at 10/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 6 to 4. | Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Kuma Who Wounded the Sun.
- Result: Bone-Cracker Cub left battle, Kuma Who Wounded the Sun survives, Hunter’s Root-Stone at 10/10

Main 2:
- Main 2: played Iron Hyena Raider
- Main 2: played Black-Tooth Smith

End:
- retained card: Rust Hyena Spirit
- discarded cards: Iron Hyena Underworld
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone Spear, Iron Hyena Raider

# End of Phase 9 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 7/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 2/10 | Iron 1/0
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 5 | Iron 7
Key events: Iron Guard deals 2 to Kuma Who Wounded the Sun. | Kuma Who Wounded the Sun deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Kuma Who Wounded the Sun. | Main 1: attached Fang Relic to Bone-Cracker Cub | Main 2: played Iron Hyena Raider | Main 2: played Black-Tooth Smith
Tempo note: initiative reverses after every four player-turns.

## Turn 37 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Rust Hyena Spirit]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Bone Spear, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Hunter’s Root-Stone
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 6 to 4. | Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Kuma Who Wounded the Sun.
- Result: Black-Tooth Smith left battle, Kuma Who Wounded the Sun survives, Hunter’s Root-Stone at 10/10

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Hunter’s Root-Stone
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 6 to 4.
- Damage: Kuma Who Wounded the Sun deals 4 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Kuma Who Wounded the Sun.
- Result: Iron Hyena Raider left battle, Kuma Who Wounded the Sun removed, Hunter’s Root-Stone at 10/10

Main 2:
- Main 2: played Rust Hyena Spirit
- Main 2: played Bone-Cracker Cub

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Bone-Cracker Cub, Rust Hyena Spirit

## Turn 38 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 11

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 6 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter
- Main 1: played Young Hunter

Combat:
- no attacks

Main 2:
- Main 2: awakened Child Who Remembered the Dead

End:
- retained card: Esprit du Léopard
- discarded cards: Root-Woven Guard, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 4 Offerings / 9 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, Spear of First Dawn, Young Hunter

## Turn 39 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone Spear, Bone Spear, Bone-Cracker Cub, Rust Hyena Spirit
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Leopard Hunter.
- Result: Rust Hyena Spirit left battle, Leopard Hunter survives

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed, Hunter’s Root-Stone at 9/10

Main 2:
- Main 2: played Rust Hyena Spirit

End:
- retained card: Iron Hyena Champion
- discarded cards: Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Bone-Cracker Cub, Hyena Token, Hyena Token, Rust Hyena Spirit

## Turn 40 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 10

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Child Who Remembered the Dead
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
Forgotten zone count/list: 6 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 3.
- Result: Young Hunter survives, Iron Hyena Den at 0/10

Main 2:
- Main 2: attached Esprit du Léopard to Young Hunter
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Spear of First Dawn
- discarded cards: Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, River Hunter, Spear of First Dawn, Young Hunter, Young Hunter [Possession:Esprit du Léopard]

# End of Phase 10 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 7/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/7 | Iron 3/1
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron None
Forgotten cards: Red 6 | Iron 7
Key events: Main 2: played Rust Hyena Spirit | Shrine Iron Hyena Den takes 3. | Main 1: played Young Hunter | Main 1: played River Hunter | Main 2: attached Esprit du Léopard to Young Hunter | Main 2: awakened Grandmother Beneath the Roots
Tempo note: initiative reverses after every four player-turns.

## Turn 41 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 7

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Esprit du Léopard, River Hunter, Spear of First Dawn, Young Hunter, Young Hunter [Possession:Esprit du Léopard]
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 6 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 3.
- Result: Young Hunter survives, Rusted Moon Shrine at 7/10

Main 2:
- pass

End:
- retained card: Spear of First Dawn
- discarded cards: Baobab Guardian, River Hunter, Root-Woven Guard
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 5 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, Leopard Hunter [Possession:Esprit du Léopard], River Hunter, Spear of First Dawn, Young Hunter

## Turn 42 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone Spear, Bone Spear, Bone-Cracker Cub, Hyena Token, Hyena Token, Rust Hyena Spirit
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 6 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Leopard Hunter.
- Result: Rust Hyena Spirit left battle, Leopard Hunter survives

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: River Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to River Hunter.
- Result: Bone-Cracker Cub left battle, River Hunter removed, Hunter’s Root-Stone at 9/10

Attack 3:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 6 to 4. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Hyena Token. | Hyena Token deals 1 to Leopard Hunter.
- Result: Hyena Token left battle, Leopard Hunter survives, Hunter’s Root-Stone at 9/10

Main 2:
- Main 2: played Iron Hyena Champion

End:
- retained card: Iron Hyena Champion
- discarded cards: Bone-Cracker Cub, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 3/10
- board at end: Bone Spear, Bone Spear, Hyena Token, Iron Hyena Champion, Iron Hyena Raider

## Turn 43 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 8

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Esprit du Léopard, Leopard Hunter [Wounded, Possession:Esprit du Léopard], Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
Forgotten zone count/list: 6 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to Young Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 7 to 5. | Leopard Hunter becomes Wounded. | SoulSlayer grants Pierce. | Pierce overflow deals 4 to Rusted Moon Shrine.
- Damage: Hyena Token deals 1 to Leopard Hunter. | Leopard Hunter deals 5 to Hyena Token. | Shrine Rusted Moon Shrine takes 4.
- Result: Leopard Hunter survives, Hyena Token removed, Rusted Moon Shrine at 3/10

Attack 2:
- Attacker: Young Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 6.
- Result: Young Hunter survives, Rusted Moon Shrine at 0/10

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Pale River Spirit, Root-Woven Guard, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 6 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, Leopard Hunter [Wounded, Possession:Esprit du Léopard], Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn]

## End-of-game summary

Winner: red-hunter-evolution
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Shrine of the Red Baobab 0/10, Hunter’s Root-Stone 1/10, Moonlit Roots 0/10] | Iron [Iron Hyena Den 10/10, Bone-Fang Shrine 12/10, Rusted Moon Shrine 13/10]
Final resources: Red 6/6 | Iron 1/2
Final Presence: Seat 1 2/5 | Seat 2 2/5

Turn count: 43
Phase count: 11

First Shrine damage: 3
First Shrine broken: 17
First Ancestor awakened: 9
First L2: 11
First L3: 35

Red L2 entries: 8 (hard-cast 4, evolved 4)
Red L3 entries: 1 (hard-cast 0, evolved 1)
Iron L2 entries: 3 (hard-cast 3, evolved 0)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 18, Iron 0
Legal L2 evolve actions: Red 16, Iron 0
Legal L3 evolve actions: Red 2, Iron 0
Evolve windows: Red 10, Iron 0
Turns with legal L2 evolution: Red 8, Iron 0
Turns with legal L3 evolution: Red 2, Iron 0
Evolve actions chosen: Red 16, Iron 0
Hard-cast chosen while legal evolve action existed: Red 2, Iron 0
Hard-cast chosen while evolution base existed: Red 5, Iron 4

Legal awaken actions generated: Red 42, Iron 0
Awaken actions chosen: Red 15, Iron 0
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.firsthunter, Iron None
Ancestor switches: Red 5, Iron 0
Turns with awakened ancestor: Red 17, Iron 0
Memory spent on ancestors: Red 12, Iron 0
Ancestor realized value: First Hunter +5 damage, Grandmother healed 1, Child draw/discard 2, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 1, Iron 4
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 6, Iron 7
Wounded events: Red 17, Iron 1
Wounded reduced damage: Red 13, Iron 1
Pierce overflow events: Red 1, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 1
Legal block options: Red 12, Iron 1
Blocks chosen: Red 11, Iron 1
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 22, pack 0 | Seat 2 standard 8, pack 14
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 44, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 16, generated 16, available 16, skipped 2, turns-with-bonus 13, max-attacks 58, prevented-by-limit 1
Deck reshuffles: Red 4, Iron 3

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
