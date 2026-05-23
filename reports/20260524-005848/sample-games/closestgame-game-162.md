# Test Game #162

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

Seed: 162
Winner: iron-snarecraft-control
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Baobab Guardian, Esprit du Léopard, Root-Woven Guard, Root-Woven Guard, Young Hunter
- Starting hands — Iron: Black-Tooth Smith, Bone-Cracker Cub, Bone-Cracker Cub, Iron Guard, Iron Hyena Raider
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the Iron Hyena, Tooth-Mother of the Dry Earth, Smith of Black Teeth

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Baobab Guardian, Esprit du Léopard, Root-Woven Guard, Root-Woven Guard, Young Hunter]

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
- retained card: Esprit du Léopard
- discarded cards: Root-Woven Guard, Baobab Guardian, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith, Bone-Cracker Cub, Bone-Cracker Cub, Iron Guard, Iron Hyena Raider]

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
- retained card: Black-Tooth Smith
- discarded cards: Bone-Cracker Cub, Iron Guard, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: prepared Hunter’s Call

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to Young Hunter. | Young Hunter deals 2 to Bone-Cracker Cub.
- Result: Young Hunter left battle, Bone-Cracker Cub removed

Main 2:
- pass

End:
- retained card: Baobab Guardian
- discarded cards: Esprit du Léopard, Esprit du Léopard, Leopard Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: 

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Black-Tooth Smith, Iron Hyena Champion, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token, Hyena Token

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/1 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 0
Key events: Main 1: played Young Hunter | Main 1: played Bone-Cracker Cub | Bone-Cracker Cub deals 2 to Young Hunter. | Young Hunter deals 2 to Bone-Cracker Cub. | Main 1: prepared Hunter’s Call | Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Hyena Token, Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: prepared Iron Snare
- Main 1: attached Bone Spear to Hyena Token

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Hyena Token survives, Hunter’s Root-Stone at 8/10

Attack 2:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Hyena Token survives, Hunter’s Root-Stone at 6/10

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Black-Tooth Smith, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Hyena Token, Hyena Token [Relic:Bone Spear]

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Hunter’s Call]

Main 1:
- Main 1: played River Hunter

Combat:
- no attacks

Main 2:
- Main 2: resolved Offering of Milk and Ash (restored 3 to Hunter’s Root-Stone)

End:
- retained card: Ritual of Red Moon
- discarded cards: Baobab Guardian, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: River Hunter

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Bone Spear, Hyena Token, Hyena Token [Relic:Bone Spear]
Prepared Tactic: Iron Snare
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: prepared False Opening

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 3.
- Result: Hyena Token survives, Hunter’s Root-Stone at 4/10

Attack 2:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Hyena Token survives, Hunter’s Root-Stone at 2/10

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Rust Hyena Spirit, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Hyena Token, Hyena Token [Relic:Bone Spear]

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 8/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Hunter’s Call, Offering of Milk and Ash]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Spear of First Dawn to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Hyena Token
- Defender/blocker: Hyena Token
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: None
- Damage: Hyena Token deals 2 to River Hunter. | River Hunter deals 4 to Hyena Token.
- Result: River Hunter left battle, Hyena Token removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Offering of Milk and Ash
- discarded cards: Ritual of Red Moon, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
- board at end: River Hunter

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/1 | Iron 1/1
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 2 | Iron 1
Key events: Main 1: prepared False Opening | Hyena Token deals 2 to River Hunter. | River Hunter deals 4 to Hyena Token. | Main 1: played River Hunter | Main 1: attached Spear of First Dawn to River Hunter | Main 2: awakened First Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Offering of Milk and Ash]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Hunter’s Call, Offering of Milk and Ash]

Main 1:
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Hyena Token
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: River Hunter becomes Wounded.
- Damage: Hyena Token deals 1 to River Hunter. | River Hunter deals 3 to Hyena Token.
- Result: River Hunter survives, Hyena Token removed

Main 2:
- pass

End:
- retained card: Spear of First Dawn
- discarded cards: Offering of Milk and Ash, Deep River Spirit, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, River Hunter [Wounded]

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: 
Prepared Tactic: False Opening
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: prepared Iron Snare

Combat:
- no attacks

Main 2:
- Main 2: prepared False Opening (replaced Iron Snare)

End:
- retained card: Rust Hyena Spirit
- discarded cards: Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 2

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Leopard Hunter, River Hunter [Wounded]
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 9/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Hunter’s Call, Offering of Milk and Ash]

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 6.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 4/10

Attack 2:
- Attacker: River Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces River Hunter from 5 to 3.
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: River Hunter survives, Bone-Fang Shrine at 1/10

Main 2:
- Main 2: attached Spear of First Dawn to River Hunter
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Pale River Spirit
- forgotten cards: None
- Wounded clears: River Hunter
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 8/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, River Hunter, River Hunter [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Rust Hyena Spirit]

Board before ready:
Beings/Spirits: 
Prepared Tactic: False Opening, False Opening
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Rust Hyena Spirit

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Iron Hyena Underworld, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider, Rust Hyena Spirit

# End of Phase 3 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 8/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/0 | Iron 2/0
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron None
Forgotten cards: Red 2 | Iron 4
Key events: Main 1: played Young Hunter | Main 1: played River Hunter | Main 2: attached Spear of First Dawn to River Hunter | Main 2: awakened Grandmother Beneath the Roots | Main 1: played Iron Hyena Raider | Main 1: played Rust Hyena Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Iron Hyena Raider, Rust Hyena Spirit
Prepared Tactic: False Opening, False Opening
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone, broke it, gained 1 Memory)
- Main 1: attached Bone Spear to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Leopard Hunter.
- Result: Rust Hyena Spirit left battle, Leopard Hunter survives

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: awakened Smith of Black Teeth

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Iron Hyena Raider [Relic:Bone Spear]

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Leopard Hunter [Wounded], River Hunter, River Hunter [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
Forgotten zone count/list: 2 [Hunter’s Call, Offering of Milk and Ash]

Main 1:
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Iron Hyena Raider deals 4 to Leopard Hunter. | Leopard Hunter deals 3 to Iron Hyena Raider.
- Result: Leopard Hunter left battle, Iron Hyena Raider removed, Bone-Fang Shrine at 1/10

Main 2:
- Main 2: played Pale River Spirit

End:
- retained card: Deep River Spirit
- discarded cards: Kuma Who Wounded the Sun, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Pale River Spirit, River Hunter, River Hunter [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter, Young Hunter

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: False Opening, False Opening
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Bone-Cracker Cub
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Young Hunter deals 2 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Young Hunter.
- Result: Bone-Cracker Cub left battle, Young Hunter removed, Moonlit Roots at 10/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Rust Hyena Spirit
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone-Cracker Cub

## Turn 16 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Pale River Spirit, River Hunter, River Hunter [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Hunter’s Call, Offering of Milk and Ash]

Main 1:
- Main 1: resolved Ritual of Red Moon (dealt 2 to Black-Tooth Smith)
- Main 1: played Deep River Spirit

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 2 to 1. | River Hunter becomes Wounded.
- Damage: Black-Tooth Smith deals 1 to River Hunter. | River Hunter deals 4 to Black-Tooth Smith.
- Result: River Hunter survives, Black-Tooth Smith removed

Main 2:
- Main 2: resolved Offering of Milk and Ash (had no damaged shrine to restore)

End:
- retained card: Baobab Guardian
- discarded cards: Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Deep River Spirit, Pale River Spirit, River Hunter, River Hunter [Wounded, Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter

# End of Phase 4 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/1 | Iron 3/0
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Smith of Black Teeth
Forgotten cards: Red 4 | Iron 5
Key events: Main 2: played Black-Tooth Smith | Black-Tooth Smith deals 1 to River Hunter. | River Hunter deals 4 to Black-Tooth Smith. | Main 1: resolved Ritual of Red Moon (dealt 2 to Black-Tooth Smith) | Main 1: played Deep River Spirit | Main 2: resolved Offering of Milk and Ash (had no damaged shrine to restore)
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: Deep River Spirit, Pale River Spirit, River Hunter, River Hunter [Wounded, Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 4 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces River Hunter from 4 to 3.
- Damage: Bone-Cracker Cub deals 2 to River Hunter. | River Hunter deals 3 to Bone-Cracker Cub.
- Result: River Hunter left battle, Bone-Cracker Cub removed

Main 2:
- Main 2: resolved Ritual of Red Moon (had no legal target)
- Main 2: awakened First Hunter

End:
- retained card: Baobab Guardian
- discarded cards: Young Hunter, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Deep River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Rust Hyena Spirit]

Board before ready:
Beings/Spirits: 
Prepared Tactic: False Opening, False Opening
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Rust Hyena Spirit

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Black-Tooth Smith, Rust Hyena Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider, Rust Hyena Spirit

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: Deep River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 5 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Esprit du Léopard to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to River Hunter. | River Hunter deals 5 to Iron Hyena Raider.
- Result: River Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: played Baobab Guardian

End:
- retained card: Esprit du Léopard
- discarded cards: Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Deep River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Rust Hyena Spirit
Prepared Tactic: False Opening, False Opening
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Black-Tooth Smith

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Deep River Spirit.
- Result: Rust Hyena Spirit left battle, Deep River Spirit survives

Main 2:
- pass

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Hyena Champion, Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Iron Hyena Raider

# End of Phase 5 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/3 | Iron 3/1
Awakened Ancestors: Red First Hunter | Iron Smith of Black Teeth
Forgotten cards: Red 5 | Iron 5
Key events: Main 1: attached Esprit du Léopard to River Hunter | Main 2: played Baobab Guardian | Deep River Spirit deals 3 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Deep River Spirit. | Main 1: played Iron Hyena Raider | Main 1: played Black-Tooth Smith
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Iron Hyena Raider
Prepared Tactic: False Opening, False Opening
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2. | Black-Tooth Smith becomes Wounded. | Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 2 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Deep River Spirit.
- Result: Black-Tooth Smith survives, Deep River Spirit survives

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2.
- Damage: Deep River Spirit deals 2 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Deep River Spirit.
- Result: Iron Hyena Raider left battle, Deep River Spirit removed

Main 2:
- Main 2: played Iron Hyena Champion
- Main 2: played Iron Guard

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Wounded], Iron Guard, Iron Hyena Champion

## Turn 22 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 4

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
Forgotten zone count/list: 5 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Hyena Champion becomes Wounded.
- Damage: Iron Hyena Champion deals 5 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Champion.
- Result: Young Hunter left battle, Iron Hyena Champion survives

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit, Hunter’s Call, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Leopard Hunter [Wounded], Pale River Spirit, Spear of First Dawn

## Turn 23 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Wounded], Iron Guard, Iron Hyena Champion [Wounded]
Prepared Tactic: False Opening
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 2 to 1. | Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 3 to Black-Tooth Smith. | Black-Tooth Smith deals 1 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives

Attack 2:
- Attacker: Iron Guard
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 3 to Iron Guard. | Iron Guard deals 2 to Leopard Hunter.
- Result: Iron Guard left battle, Leopard Hunter survives

Attack 3:
- Attacker: Iron Hyena Champion
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 6 to 4. | Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Iron Hyena Champion. | Iron Hyena Champion deals 4 to Leopard Hunter.
- Result: Iron Hyena Champion left battle, Leopard Hunter removed

Main 2:
- Main 2: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

End:
- retained card: Iron Hyena Underworld
- discarded cards: Hyena Token, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token, Hyena Token

## Turn 24 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 3

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian, Pale River Spirit, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 5 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 2.
- Result: Baobab Guardian survives, Bone-Fang Shrine at 0/10

Attack 2:
- Attacker: Pale River Spirit
- Target: Hyena Token
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Pale River Spirit becomes Wounded.
- Damage: Hyena Token deals 1 to Pale River Spirit. | Pale River Spirit deals 2 to Hyena Token.
- Result: Pale River Spirit survives, Hyena Token removed

Main 2:
- Main 2: attached Esprit du Léopard to Baobab Guardian
- Main 2: prepared Hunter’s Call
- Main 2: awakened First Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: None
- forgotten cards: None
- Wounded clears: River Hunter
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit [Wounded], River Hunter, River Hunter, Spear of First Dawn

# End of Phase 6 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/0 | Iron 6/1
Awakened Ancestors: Red First Hunter | Iron Smith of Black Teeth
Forgotten cards: Red 5 | Iron 6
Key events: Pale River Spirit deals 2 to Hyena Token. | Main 1: played River Hunter | Main 1: played River Hunter | Main 2: attached Esprit du Léopard to Baobab Guardian | Main 2: prepared Hunter’s Call | Main 2: awakened First Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 25 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit [Wounded], River Hunter, River Hunter, Spear of First Dawn
Prepared Tactic: Hunter’s Call
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 5 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Pale River Spirit

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Hyena Token
- Defender/blocker: Hyena Token
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: River Hunter becomes Wounded.
- Damage: Hyena Token deals 1 to River Hunter. | River Hunter deals 3 to Hyena Token.
- Result: River Hunter survives, Hyena Token removed

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Kuma Who Wounded the Sun, Baobab Guardian, Deep River Spirit
- forgotten cards: None
- Wounded clears: Pale River Spirit
- resources at end: 6 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Pale River Spirit, River Hunter, River Hunter [Wounded], Spear of First Dawn

## Turn 26 — Iron

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 1

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: 
Prepared Tactic: False Opening
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Iron Hyena Underworld, Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Iron Hyena Raider

## Turn 27 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 1

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Pale River Spirit, River Hunter, River Hunter [Wounded], Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 6 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: attached Esprit du Léopard to Baobab Guardian

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces River Hunter from 3 to 2.
- Damage: Iron Hyena Raider deals 3 to River Hunter. | River Hunter deals 2 to Iron Hyena Raider.
- Result: River Hunter left battle, Iron Hyena Raider removed

Main 2:
- pass

End:
- retained card: Ritual of Red Moon
- discarded cards: Young Hunter, Deep River Spirit, Young Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn

## Turn 28 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 1

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: False Opening
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Bone-Cracker Cub
- Main 1: played Black-Tooth Smith

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Baobab Guardian.
- Result: Bone-Cracker Cub left battle, Baobab Guardian survives

Main 2:
- Main 2: played Rust Hyena Spirit

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Rust Hyena Spirit

# End of Phase 7 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10]
Resources: Red 6/3 | Iron 2/1
Awakened Ancestors: Red First Hunter | Iron Smith of Black Teeth
Forgotten cards: Red 6 | Iron 6
Key events: Main 1: attached Esprit du Léopard to Baobab Guardian | Baobab Guardian deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Baobab Guardian. | Main 1: attached Fang Relic to Bone-Cracker Cub | Main 1: played Black-Tooth Smith | Main 2: played Rust Hyena Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 29 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Rust Hyena Spirit
Prepared Tactic: False Opening
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Black-Tooth Smith

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 4 to 3. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 3 to Black-Tooth Smith. | Black-Tooth Smith deals 3 to Baobab Guardian.
- Result: Black-Tooth Smith left battle, Baobab Guardian survives

Attack 2:
- Attacker: Rust Hyena Spirit
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 4 to 3.
- Damage: Baobab Guardian deals 3 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Baobab Guardian.
- Result: Rust Hyena Spirit left battle, Baobab Guardian removed

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: played Black-Tooth Smith

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: Black-Tooth Smith, Black-Tooth Smith
- resources at end: 1 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Black-Tooth Smith

## Turn 30 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 4

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Pale River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
Forgotten zone count/list: 6 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Pale River Spirit
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: Black-Tooth Smith becomes Wounded.
- Damage: Black-Tooth Smith deals 2 to Pale River Spirit. | Pale River Spirit deals 2 to Black-Tooth Smith.
- Result: Pale River Spirit left battle, Black-Tooth Smith survives

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Spear of First Dawn
- discarded cards: Ritual of Red Moon, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
- board at end: Leopard Hunter [Wounded], Pale River Spirit, River Hunter, Spear of First Dawn

## Turn 31 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 2

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Black-Tooth Smith [Wounded]
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Black-Tooth Smith

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 3 to 2. | Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 3 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives, Moonlit Roots at 9/10

Attack 2:
- Attacker: Black-Tooth Smith
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter removed, Moonlit Roots at 9/10

Main 2:
- Main 2: played Iron Hyena Champion
- Main 2: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

End:
- retained card: Hyena Token
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: Iron Hyena Champion
- resources at end: 1 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token, Hyena Token, Iron Hyena Champion

## Turn 32 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 5

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Pale River Spirit, River Hunter, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
Forgotten zone count/list: 6 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Pale River Spirit
- Target: Hyena Token
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Pale River Spirit becomes Wounded.
- Damage: Hyena Token deals 1 to Pale River Spirit. | Pale River Spirit deals 2 to Hyena Token.
- Result: Pale River Spirit survives, Hyena Token removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Spear of First Dawn
- discarded cards: Root-Woven Guard, Pale River Spirit
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 4 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, Pale River Spirit [Wounded], Spear of First Dawn, Young Hunter

# End of Phase 8 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10]
Resources: Red 4/3 | Iron 1/2
Awakened Ancestors: Red First Hunter | Iron Smith of Black Teeth
Forgotten cards: Red 6 | Iron 7
Key events: Main 2: resolved Hyena Pack Call (summoned 2 Hyena Tokens) | Hyena Token deals 1 to Pale River Spirit. | Pale River Spirit deals 2 to Hyena Token. | Main 1: evolved River Hunter into Leopard Hunter | Main 1: played Young Hunter | Main 2: awakened First Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 33 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 3

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Leopard Hunter, Pale River Spirit [Wounded], Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 6 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 5.
- Result: Leopard Hunter survives, Iron Hyena Den at 5/10

Attack 2:
- Attacker: Young Hunter
- Target: Hyena Token
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Hyena Token deals 1 to Young Hunter. | Young Hunter deals 2 to Hyena Token.
- Result: Young Hunter left battle, Hyena Token removed

Main 2:
- Main 2: attached Spear of First Dawn to Pale River Spirit

End:
- retained card: Esprit du Léopard
- discarded cards: Baobab Guardian
- forgotten cards: None
- Wounded clears: River Hunter, Pale River Spirit
- resources at end: 3 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, Pale River Spirit [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter

## Turn 34 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 2

Hand before draw: [Hyena Token]

Board before ready:
Beings/Spirits: Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 5/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Champion
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 6.
- Result: Iron Hyena Champion survives, Moonlit Roots at 4/10

Main 2:
- Main 2: played Iron Hyena Raider
- Main 2: awakened Ancestor of the Iron Hyena

End:
- retained card: Hyena Token
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 5/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Iron Hyena Champion [Relic:Bone Spear], Iron Hyena Raider

## Turn 35 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 4

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Leopard Hunter, Pale River Spirit [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 6/10
Forgotten zone count/list: 6 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Esprit du Léopard to Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 7.
- Result: Leopard Hunter survives, Iron Hyena Den at 0/10

Attack 2:
- Attacker: River Hunter
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 6 to River Hunter. | River Hunter deals 3 to Iron Hyena Champion.
- Result: River Hunter left battle, Iron Hyena Champion removed

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 6/10
- board at end: Esprit du Léopard, Leopard Hunter [Possession:Esprit du Léopard], Pale River Spirit [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter

## Turn 36 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 1

Hand before draw: [Hyena Token]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Rust Hyena Spirit

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Moonlit Roots
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Young Hunter deals 2 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Young Hunter.
- Result: Iron Hyena Raider left battle, Young Hunter removed, Moonlit Roots at 4/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 3.
- Result: Bone-Cracker Cub survives, Moonlit Roots at 1/10

Main 2:
- Main 2: played Iron Guard

End:
- retained card: Iron Hyena Champion
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Iron Guard, Iron Hyena Raider, Rust Hyena Spirit

# End of Phase 9 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 6/10] | Iron [Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10]
Resources: Red 4/5 | Iron 2/1
Awakened Ancestors: Red First Hunter | Iron Ancestor of the Iron Hyena
Forgotten cards: Red 6 | Iron 7
Key events: Young Hunter deals 2 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Young Hunter. | Shrine Moonlit Roots takes 3. | Main 1: played Iron Hyena Raider | Main 1: played Rust Hyena Spirit | Main 2: played Iron Guard
Tempo note: initiative reverses after every four player-turns.

## Turn 37 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Iron Guard, Iron Hyena Raider, Rust Hyena Spirit
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Moonlit Roots and broke it)
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 6 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Leopard Hunter.
- Result: Rust Hyena Spirit left battle, Leopard Hunter survives

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Bone-Cracker Cub, Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Iron Guard, Iron Hyena Champion, Iron Hyena Raider

## Turn 38 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 5

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Esprit du Léopard, Leopard Hunter [Wounded, Possession:Esprit du Léopard], Pale River Spirit [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 11/10
Forgotten zone count/list: 6 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Rusted Moon Shrine)
- Main 1: evolved River Hunter into Leopard Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Ritual of Red Moon, Baobab Guardian
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 1 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 11/10
- board at end: Esprit du Léopard, Kuma Who Wounded the Sun [Possession:Esprit du Léopard], Leopard Hunter, Pale River Spirit [Relic:Spear of First Dawn], Spear of First Dawn, Spear of First Dawn

## Turn 39 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 2

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Iron Guard, Iron Hyena Champion, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Champion
- Main 1: attached Bone Spear to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Iron Guard
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Iron Guard. | Iron Guard deals 2 to Leopard Hunter.
- Result: Iron Guard left battle, Leopard Hunter survives, Shrine of the Red Baobab at 7/10

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Leopard Hunter.
- Result: Iron Hyena Raider left battle, Leopard Hunter removed, Shrine of the Red Baobab at 7/10

Attack 3:
- Attacker: Iron Hyena Champion
- Target: Shrine of the Red Baobab
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Kuma Who Wounded the Sun deals 8 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Kuma Who Wounded the Sun.
- Result: Iron Hyena Champion left battle, Kuma Who Wounded the Sun removed, Shrine of the Red Baobab at 6/10

Attack 4:
- Attacker: Bone-Cracker Cub
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 3.
- Result: Bone-Cracker Cub survives, Shrine of the Red Baobab at 3/10

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: played Black-Tooth Smith

End:
- retained card: Hyena Token
- discarded cards: None
- forgotten cards: None
- Wounded clears: Black-Tooth Smith
- resources at end: 0 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10
- board at end: Black-Tooth Smith, Black-Tooth Smith, Bone Spear, Bone-Cracker Cub

## Turn 40 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 5

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Pale River Spirit [Relic:Spear of First Dawn], Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 11/10
Forgotten zone count/list: 7 [Hunter’s Call, Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Pale River Spirit

Combat:

Attack 1:
- Attacker: Pale River Spirit
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Black-Tooth Smith deals 2 to Pale River Spirit. | Pale River Spirit deals 3 to Black-Tooth Smith.
- Result: Pale River Spirit left battle, Black-Tooth Smith removed

Main 2:
- Main 2: played Deep River Spirit

End:
- retained card: Esprit du Léopard
- discarded cards: Esprit du Léopard
- forgotten cards: None
- Wounded clears: Deep River Spirit
- resources at end: 1 Offerings / 6 Memory
- shrine state: Shrine of the Red Baobab: 8/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 11/10
- board at end: Deep River Spirit, Pale River Spirit, Spear of First Dawn, Young Hunter

# End of Phase 10 Summary

Shrine state: Red [Shrine of the Red Baobab: 8/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 11/10] | Iron [Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10]
Resources: Red 1/6 | Iron 0/2
Awakened Ancestors: Red First Hunter | Iron Ancestor of the Iron Hyena
Forgotten cards: Red 7 | Iron 7
Key events: Main 2: played Black-Tooth Smith | Black-Tooth Smith deals 2 to Pale River Spirit. | Pale River Spirit deals 3 to Black-Tooth Smith. | Main 1: played Young Hunter | Main 1: played Pale River Spirit | Main 2: played Deep River Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 41 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 6

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Deep River Spirit, Pale River Spirit, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 8/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 11/10
Forgotten zone count/list: 7 [Hunter’s Call, Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 3.
- Result: Young Hunter survives, Rusted Moon Shrine at 4/10

Attack 2:
- Attacker: Deep River Spirit
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Black-Tooth Smith deals 2 to Deep River Spirit. | Deep River Spirit deals 3 to Black-Tooth Smith.
- Result: Deep River Spirit survives, Black-Tooth Smith removed

Main 2:
- Main 2: attached Esprit du Léopard to Young Hunter

End:
- retained card: Leopard Hunter
- discarded cards: River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 8/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 11/10
- board at end: Deep River Spirit [Wounded], Esprit du Léopard, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter, Young Hunter [Possession:Esprit du Léopard]

## Turn 42 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 2

Hand before draw: [Hyena Token]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 6/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Rust Hyena Spirit

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 3.
- Result: Bone-Cracker Cub survives, Shrine of the Red Baobab at 0/10

Main 2:
- pass

End:
- retained card: Hyena Token
- discarded cards: Hyena Token, Hyena Token, Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 6/10
- board at end: Bone Spear, Bone-Cracker Cub, Rust Hyena Spirit

## End-of-game summary

Winner: iron-snarecraft-control
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Shrine of the Red Baobab 12/10, Hunter’s Root-Stone 11/10, Moonlit Roots 11/10] | Iron [Iron Hyena Den 12/10, Bone-Fang Shrine 11/10, Rusted Moon Shrine 6/10]
Final resources: Red 3/5 | Iron 6/2
Final Presence: Seat 1 5/5 | Seat 2 2/5

Turn count: 42
Phase count: 11

First Shrine damage: 5
First Shrine broken: 13
First Ancestor awakened: 8
First L2: 9
First L3: 38

Red L2 entries: 5 (hard-cast 1, evolved 4)
Red L3 entries: 1 (hard-cast 0, evolved 1)
Iron L2 entries: 3 (hard-cast 2, evolved 1)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 10, Iron 2
Legal L2 evolve actions: Red 8, Iron 2
Legal L3 evolve actions: Red 2, Iron 0
Evolve windows: Red 8, Iron 2
Turns with legal L2 evolution: Red 8, Iron 2
Turns with legal L3 evolution: Red 2, Iron 0
Evolve actions chosen: Red 10, Iron 2
Hard-cast chosen while legal evolve action existed: Red 2, Iron 0
Hard-cast chosen while evolution base existed: Red 4, Iron 2

Legal awaken actions generated: Red 40, Iron 8
Awaken actions chosen: Red 14, Iron 6
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.firsthunter, Iron iron.ancestor.smith
Ancestor switches: Red 6, Iron 1
Turns with awakened ancestor: Red 17, Iron 14
Memory spent on ancestors: Red 14, Iron 4
Ancestor realized value: First Hunter +5 damage, Grandmother healed 3, Child draw/discard 0, Iron Hyena +3 damage, Smith saved 7 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 2, Iron 3
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 7, Iron 7
Wounded events: Red 18, Iron 4
Wounded reduced damage: Red 14, Iron 4
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 11, Iron 1
Blocks chosen: Red 7, Iron 1
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 23, pack 0 | Seat 2 standard 15, pack 11
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 42, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 14, generated 14, available 14, skipped 3, turns-with-bonus 10, max-attacks 56, prevented-by-limit 0
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
