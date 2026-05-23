# Test Game #221

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 100 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red red --bot-iron iron --deck-red red-hunter-evolution --deck-iron iron-hyena-aggro --rules single-block-per-combat

Seat 1:
- red-hunter-evolution [Red] (RedBaobabBot)
Seat 2:
- iron-hyena-aggro [Iron] (IronHyenaBot)

Rules variant:
- Draw model: retain up to 1, discard rest, draw to 5
- Phase model: reverse every 4 player-turns
- Combat model: 2 standard Assault slots, plus Pack expansion up to 5 total attacks, separate resolution
- Battlefield capacity: 5 Presence per seat
- Prepared model: max 1 active tactic per player
- Special mechanics: Fade, Forgotten, Wounded, Pierce, Disperse, Possession, Evolution, Recall, Unique, Pack

Seed: 221
Winner: red-hunter-evolution
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Deep River Spirit, Hunter’s Call, Kuma Who Wounded the Sun, River Hunter, River Hunter
- Starting hands — Iron: Bite the Roots, Iron Guard, Iron Hyena Champion, Iron Snare, Rust Hyena Spirit
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the Iron Hyena, Tooth-Mother of the Dry Earth, Smith of Black Teeth

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Deep River Spirit, Hunter’s Call, Kuma Who Wounded the Sun, River Hunter, River Hunter]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: prepared Hunter’s Call

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: River Hunter
- discarded cards: Deep River Spirit, Kuma Who Wounded the Sun, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: 

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Iron Guard, Iron Hyena Champion, Iron Snare, Rust Hyena Spirit]

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
- retained card: Bite the Roots
- discarded cards: Iron Hyena Champion, Rust Hyena Spirit, Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [River Hunter]

Board before ready:
Beings/Spirits: 
Prepared Tactic: Hunter’s Call
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played River Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Young Hunter, Deep River Spirit, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: River Hunter

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots]

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
- retained card: Bite the Roots
- discarded cards: Iron Snare, Bone-Cracker Cub, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 1
Key events: Main 1: prepared Hunter’s Call | Main 1: prepared Iron Snare | Main 1: played River Hunter | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: 
Prepared Tactic: Iron Snare
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Raider
- discarded cards: Black-Tooth Smith, Hyena Pack Call, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: Hunter’s Call
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Ritual of Red Moon (had no legal target)

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: Hunter’s Call, Iron Snare
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 4.
- Result: River Hunter survives, Bone-Fang Shrine at 6/10

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Root-Woven Guard, Esprit du Léopard, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
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
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Pack Harrier

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider, Pack Harrier

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Hunter’s Call, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
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
- retained card: Leopard Hunter
- discarded cards: Pale River Spirit, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
- board at end: Young Hunter

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/0 | Iron 1/0
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 2 | Iron 3
Key events: Main 1: played Pack Harrier | Iron Hyena Raider deals 3 to River Hunter. | River Hunter deals 4 to Iron Hyena Raider. | Main 1: played Young Hunter | Main 1: attached Spear of First Dawn to River Hunter | Main 2: awakened First Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Hunter’s Call, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Pack Harrier
- Defender/blocker: Pack Harrier
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Pack Harrier deals 1 to Young Hunter. | Young Hunter deals 2 to Pack Harrier.
- Result: Young Hunter left battle, Pack Harrier removed

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Ritual of Red Moon, Hunter’s Call, Leopard Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Fang Relic
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Relic:Bone Spear], Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Hunter’s Call, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter

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
- pass

End:
- retained card: Spear of First Dawn
- discarded cards: Ritual of Red Moon, Root-Woven Guard, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Relic:Bone Spear], Bone Spear, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: attached Fang Relic to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Hunter’s Root-Stone
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 4 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter removed, Hunter’s Root-Stone at 4/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 5.
- Result: Bone-Cracker Cub survives, Hunter’s Root-Stone at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Blood-Scent Hyena, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub [Relic:Fang Relic], Fang Relic

# End of Phase 3 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/2 | Iron 2/1
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 2 | Iron 4
Key events: Main 1: played Leopard Hunter | Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 4 to Leopard Hunter. | Shrine Hunter’s Root-Stone takes 5. | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone) | Main 1: attached Fang Relic to Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone-Cracker Cub [Relic:Fang Relic], Fang Relic
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: prepared False Opening
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 3.
- Result: Bone-Cracker Cub survives, Moonlit Roots at 7/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Blood-Scent Hyena
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Fang Relic

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 2

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 3/10
Forgotten zone count/list: 2 [Hunter’s Call, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Baobab Guardian

Combat:
- no attacks

Main 2:
- Main 2: resolved Offering of Milk and Ash (restored 3 to Moonlit Roots)
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Esprit du Léopard
- discarded cards: Spear of First Dawn
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, River Hunter

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Fang Relic
Prepared Tactic: False Opening
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: prepared Iron Snare
- Main 1: attached Fang Relic to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Black-Tooth Smith becomes Wounded. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 2 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Baobab Guardian.
- Result: Black-Tooth Smith survives, Baobab Guardian survives

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1.
- Damage: Baobab Guardian deals 1 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Baobab Guardian.
- Result: Bone-Cracker Cub left battle, Baobab Guardian removed

Main 2:
- Main 2: played Blood-Scent Hyena

End:
- retained card: Black-Tooth Smith
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Wounded], Blood-Scent Hyena, Bone Spear, Fang Relic

## Turn 16 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Spear of First Dawn to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 2 to 1. | River Hunter becomes Wounded.
- Damage: Black-Tooth Smith deals 1 to River Hunter. | River Hunter deals 4 to Black-Tooth Smith.
- Result: River Hunter survives, Black-Tooth Smith removed

Main 2:
- Main 2: attached Esprit du Léopard to River Hunter

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, River Hunter, River Hunter [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn

# End of Phase 4 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10]
Resources: Red 2/1 | Iron 3/1
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron None
Forgotten cards: Red 3 | Iron 4
Key events: Main 2: played Blood-Scent Hyena | Black-Tooth Smith deals 1 to River Hunter. | River Hunter deals 4 to Black-Tooth Smith. | Main 1: played River Hunter | Main 1: attached Spear of First Dawn to River Hunter | Main 2: attached Esprit du Léopard to River Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Esprit du Léopard, River Hunter, River Hunter [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: resolved Ritual of Red Moon (dealt 2 to Blood-Scent Hyena, destroyed it, gained 1 Memory)
- Main 1: played Pale River Spirit

Combat:
- no attacks

Main 2:
- Main 2: played Deep River Spirit

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Root-Woven Guard
- forgotten cards: None
- Wounded clears: River Hunter
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Deep River Spirit, Esprit du Léopard, Pale River Spirit, River Hunter, River Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone Spear, Fang Relic
Prepared Tactic: False Opening
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Black-Tooth Smith

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Hyena Pack Call
- discarded cards: Iron Hyena Champion, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Fang Relic

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Deep River Spirit, Esprit du Léopard, Pale River Spirit, River Hunter, River Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 4 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter
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
- Main 2: awakened First Hunter

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Root-Woven Guard, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Deep River Spirit, Esprit du Léopard, Leopard Hunter [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Pale River Spirit, River Hunter, Spear of First Dawn

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Fang Relic
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 7 to 5. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 5 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter survives, Moonlit Roots at 10/10

Main 2:
- pass

End:
- retained card: Pack Harrier
- discarded cards: Hyena Pack Call, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Fang Relic, Iron Hyena Raider, Iron Hyena Raider

# End of Phase 5 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/1 | Iron 4/1
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 4 | Iron 6
Key events: Main 1: played River Hunter | Main 2: awakened First Hunter | Leopard Hunter deals 5 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Leopard Hunter. | Main 1: played Iron Hyena Raider | Main 1: played Iron Hyena Raider
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Bone Spear, Fang Relic, Iron Hyena Raider, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 7 to 5. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 5 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Leopard Hunter.
- Result: Iron Hyena Raider left battle, Leopard Hunter survives, Moonlit Roots at 10/10

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 3.
- Result: Iron Hyena Raider survives, Moonlit Roots at 7/10

Main 2:
- Main 2: awakened Ancestor of the Iron Hyena

End:
- retained card: Iron Hyena Champion
- discarded cards: Black-Tooth Smith, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Fang Relic, Iron Hyena Raider, Iron Hyena Raider, Pack Harrier

## Turn 22 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Deep River Spirit, Esprit du Léopard, Leopard Hunter [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Pale River Spirit, River Hunter, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 3/10
Forgotten zone count/list: 4 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 10 to 7.
- Damage: Shrine Bone-Fang Shrine takes 7.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 0/10

Attack 2:
- Attacker: River Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to River Hunter. | River Hunter deals 3 to Iron Hyena Raider.
- Result: River Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: played Young Hunter

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Pale River Spirit, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 6 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 3/10
- board at end: Deep River Spirit, Esprit du Léopard, Leopard Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Pale River Spirit, Spear of First Dawn, Young Hunter, Young Hunter

## Turn 23 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone Spear, Fang Relic, Iron Hyena Raider, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 1.
- Result: Pack Harrier survives, Moonlit Roots at 6/10

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 4.
- Result: Iron Hyena Raider survives, Moonlit Roots at 2/10

Main 2:
- Main 2: played Iron Hyena Champion
- Main 2: played Iron Guard

End:
- retained card: Blood-Scent Hyena
- discarded cards: Rust Hyena Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Fang Relic, Iron Guard, Iron Hyena Champion, Iron Hyena Raider [Relic:Bone Spear], Pack Harrier

## Turn 24 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 3

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Deep River Spirit, Esprit du Léopard, Leopard Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Pale River Spirit, Spear of First Dawn, Young Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 8/10
Forgotten zone count/list: 4 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to Leopard Hunter. | Leopard Hunter deals 7 to Iron Hyena Champion.
- Result: Leopard Hunter left battle, Iron Hyena Champion removed

Main 2:
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Young Hunter, Baobab Guardian, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 8/10
- board at end: Deep River Spirit, Leopard Hunter, Pale River Spirit, Young Hunter

# End of Phase 6 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 8/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/5 | Iron 0/1
Awakened Ancestors: Red First Hunter | Iron Ancestor of the Iron Hyena
Forgotten cards: Red 4 | Iron 6
Key events: Main 1: attached Bone Spear to Iron Hyena Raider | Main 2: played Iron Hyena Champion | Main 2: played Iron Guard | Iron Hyena Champion deals 5 to Leopard Hunter. | Leopard Hunter deals 7 to Iron Hyena Champion. | Main 1: evolved Young Hunter into Leopard Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 25 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 5

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Deep River Spirit, Leopard Hunter, Pale River Spirit, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 8/10
Forgotten zone count/list: 4 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Guard
- Defender/blocker: Iron Guard
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Iron Guard deals 2 to Leopard Hunter. | Leopard Hunter deals 4 to Iron Guard.
- Result: Leopard Hunter survives, Iron Guard removed

Attack 2:
- Attacker: Young Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 4 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: attached Esprit du Léopard to Leopard Hunter

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Esprit du Léopard, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 7/10
- board at end: Deep River Spirit, Esprit du Léopard, Leopard Hunter [Wounded, Possession:Esprit du Léopard], Pale River Spirit, Young Hunter

## Turn 26 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone Spear, Fang Relic, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Moonlit Roots)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Bone-Cracker Cub, Pack Harrier, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Fang Relic, Iron Hyena Champion

## Turn 27 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 5

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Deep River Spirit, Esprit du Léopard, Leopard Hunter [Wounded, Possession:Esprit du Léopard], Pale River Spirit, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 9/10
Forgotten zone count/list: 4 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to Pale River Spirit

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 7 to 5.
- Damage: Iron Hyena Champion deals 5 to Leopard Hunter. | Leopard Hunter deals 5 to Iron Hyena Champion.
- Result: Leopard Hunter left battle, Iron Hyena Champion removed, Iron Hyena Den at 10/10

Main 2:
- Main 2: played Baobab Guardian
- Main 2: played Baobab Guardian

End:
- retained card: Ritual of Red Moon
- discarded cards: Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: Baobab Guardian
- resources at end: 0 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Baobab Guardian, Deep River Spirit, Pale River Spirit [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter

## Turn 28 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 1

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone Spear, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Blood-Scent Hyena

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Rust Hyena Spirit
- discarded cards: Iron Hyena Raider, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear, Fang Relic

# End of Phase 7 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/7 | Iron 4/1
Awakened Ancestors: Red First Hunter | Iron Ancestor of the Iron Hyena
Forgotten cards: Red 4 | Iron 6
Key events: Leopard Hunter deals 5 to Iron Hyena Champion. | Main 1: attached Spear of First Dawn to Pale River Spirit | Main 2: played Baobab Guardian | Main 2: played Baobab Guardian | Main 1: played Blood-Scent Hyena | Main 1: played Blood-Scent Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 29 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Rust Hyena Spirit]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Deep River Spirit.
- Result: Blood-Scent Hyena left battle, Deep River Spirit survives

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2.
- Damage: Deep River Spirit deals 2 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Deep River Spirit.
- Result: Blood-Scent Hyena left battle, Deep River Spirit removed

Main 2:
- Main 2: played Rust Hyena Spirit
- Main 2: played Iron Hyena Raider

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Fang Relic, Iron Hyena Raider, Rust Hyena Spirit

## Turn 30 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 8

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Baobab Guardian, Baobab Guardian, Pale River Spirit [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 4 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 3.
- Result: Baobab Guardian survives, Iron Hyena Den at 7/10

Main 2:
- Main 2: awakened Child Who Remembered the Dead

End:
- retained card: Ritual of Red Moon
- discarded cards: Hunter’s Call, Pale River Spirit, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 6 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Baobab Guardian, Leopard Hunter, Pale River Spirit [Relic:Spear of First Dawn], Spear of First Dawn

## Turn 31 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Bone Spear, Fang Relic, Iron Hyena Raider, Rust Hyena Spirit
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 3/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
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

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Leopard Hunter.
- Result: Iron Hyena Raider left battle, Leopard Hunter removed

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: played Black-Tooth Smith
- Main 2: awakened Smith of Black Teeth

End:
- retained card: Hyena Pack Call
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 3/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Fang Relic

## Turn 32 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 7

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Baobab Guardian, Baobab Guardian, Pale River Spirit [Relic:Spear of First Dawn], Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: Child Who Remembered the Dead
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 4 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Spear of First Dawn to Pale River Spirit

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 2.
- Result: Baobab Guardian survives, Iron Hyena Den at 5/10

Attack 2:
- Attacker: Baobab Guardian
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 2.
- Result: Baobab Guardian survives, Iron Hyena Den at 3/10

Main 2:
- Main 2: resolved Ritual of Red Moon (dealt 2 to Black-Tooth Smith)
- Main 2: resolved Offering of Milk and Ash (restored 2 to Shrine of the Red Baobab)
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Deep River Spirit
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Baobab Guardian, Pale River Spirit [Relic:Spear of First Dawn], River Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn, Spear of First Dawn

# End of Phase 8 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10] | Iron [Iron Hyena Den: 3/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/4 | Iron 3/0
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Smith of Black Teeth
Forgotten cards: Red 6 | Iron 6
Key events: Shrine Iron Hyena Den takes 2. | Main 1: played River Hunter | Main 1: attached Spear of First Dawn to Pale River Spirit | Main 2: resolved Ritual of Red Moon (dealt 2 to Black-Tooth Smith) | Main 2: resolved Offering of Milk and Ash (restored 2 to Shrine of the Red Baobab) | Main 2: awakened Grandmother Beneath the Roots
Tempo note: initiative reverses after every four player-turns.

## Turn 33 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 4

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian, Baobab Guardian, Pale River Spirit [Relic:Spear of First Dawn], River Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 6 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 8.
- Result: River Hunter survives, Iron Hyena Den at 0/10

Main 2:
- Main 2: prepared Root-Woven Guard

End:
- retained card: Deep River Spirit
- discarded cards: Young Hunter, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Baobab Guardian, Pale River Spirit [Relic:Spear of First Dawn], River Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn, Spear of First Dawn, Young Hunter

## Turn 34 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Wounded], Bone Spear, Bone-Cracker Cub, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 15/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Bone-Cracker Cub

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
- Attacker: Bone-Cracker Cub
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 1 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Baobab Guardian.
- Result: Bone-Cracker Cub left battle, Baobab Guardian survives

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 15/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Black-Tooth Smith [Wounded], Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider

## Turn 35 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 3

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian, Baobab Guardian [Wounded], Pale River Spirit [Relic:Spear of First Dawn], River Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 6 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1.
- Damage: Shrine Rusted Moon Shrine takes 1.
- Result: Baobab Guardian survives, Rusted Moon Shrine at 9/10

Attack 2:
- Attacker: Baobab Guardian
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 2.
- Result: Baobab Guardian survives, Rusted Moon Shrine at 7/10

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit, Young Hunter, Deep River Spirit
- forgotten cards: None
- Wounded clears: Baobab Guardian, Leopard Hunter
- resources at end: 5 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Baobab Guardian, Leopard Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Pale River Spirit [Relic:Spear of First Dawn], Spear of First Dawn, Spear of First Dawn, Young Hunter

## Turn 36 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Black-Tooth Smith [Wounded], Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 15/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: evolved Iron Hyena Raider into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab)
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 2 to 1. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 7 to Black-Tooth Smith. | Black-Tooth Smith deals 1 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives

Attack 2:
- Attacker: Black-Tooth Smith
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 7 to 5. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 5 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 7 to 5.
- Damage: Leopard Hunter deals 5 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Iron Guard
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: Black-Tooth Smith
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 15/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena, Bone Spear, Fang Relic, Iron Hyena Champion

# End of Phase 9 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10] | Iron [Iron Hyena Den: 15/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10]
Resources: Red 5/3 | Iron 0/0
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Smith of Black Teeth
Forgotten cards: Red 6 | Iron 6
Key events: Black-Tooth Smith deals 2 to Leopard Hunter. | Leopard Hunter deals 5 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Leopard Hunter. | Main 1: evolved Iron Hyena Raider into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab) | Main 1: played Blood-Scent Hyena | Main 2: played Black-Tooth Smith
Tempo note: initiative reverses after every four player-turns.

## Turn 37 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Iron Guard]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Blood-Scent Hyena, Bone Spear, Fang Relic, Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 15/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Black-Tooth Smith becomes Wounded. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 2 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Baobab Guardian.
- Result: Black-Tooth Smith survives, Baobab Guardian survives

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1. | Iron Hyena Champion becomes Wounded.
- Damage: Baobab Guardian deals 1 to Iron Hyena Champion. | Iron Hyena Champion deals 5 to Baobab Guardian.
- Result: Iron Hyena Champion survives, Baobab Guardian removed

Main 2:
- pass

End:
- retained card: Pack Harrier
- discarded cards: Iron Guard, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 15/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10
- board at end: Black-Tooth Smith [Wounded], Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Iron Hyena Champion [Wounded]

## Turn 38 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 5

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian, Pale River Spirit [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 6 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: attached Esprit du Léopard to Baobab Guardian

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 4.
- Result: Baobab Guardian survives, Rusted Moon Shrine at 3/10

Attack 2:
- Attacker: Young Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 2.
- Result: Young Hunter survives, Rusted Moon Shrine at 1/10

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Root-Woven Guard, Hunter’s Call, Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter

## Turn 39 — Iron

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 0

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Wounded], Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Iron Hyena Champion [Wounded]
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 15/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 9/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 2 to 1. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 1 to Baobab Guardian.
- Result: Black-Tooth Smith left battle, Baobab Guardian survives

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 6 to 4. | Wounded reduces Baobab Guardian from 4 to 3.
- Damage: Baobab Guardian deals 3 to Iron Hyena Champion. | Iron Hyena Champion deals 4 to Baobab Guardian.
- Result: Iron Hyena Champion left battle, Baobab Guardian removed

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Pack Harrier, Hyena Pack Call, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 7 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 15/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 9/10
- board at end: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic

## Turn 40 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 6

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Pale River Spirit [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 6 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Pale River Spirit
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Blood-Scent Hyena deals 2 to Pale River Spirit. | Pale River Spirit deals 3 to Blood-Scent Hyena.
- Result: Pale River Spirit left battle, Blood-Scent Hyena removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Pale River Spirit, Young Hunter
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 3 Offerings / 6 Memory
- shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Leopard Hunter, River Hunter, Spear of First Dawn

# End of Phase 10 Summary

Shrine state: Red [Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10] | Iron [Iron Hyena Den: 15/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 9/10]
Resources: Red 3/6 | Iron 7/0
Awakened Ancestors: Red First Hunter | Iron Smith of Black Teeth
Forgotten cards: Red 6 | Iron 6
Key events: Main 1: attached Fang Relic to Iron Hyena Champion | Blood-Scent Hyena deals 2 to Pale River Spirit. | Pale River Spirit deals 3 to Blood-Scent Hyena. | Main 1: evolved Young Hunter into Leopard Hunter | Main 1: played River Hunter | Main 2: awakened First Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 41 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 6

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Leopard Hunter, River Hunter, Spear of First Dawn
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 6 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Bone-Cracker Cub deals 2 to Leopard Hunter. | Leopard Hunter deals 5 to Bone-Cracker Cub.
- Result: Leopard Hunter survives, Bone-Cracker Cub removed, Rusted Moon Shrine at 1/10

Attack 2:
- Attacker: River Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to River Hunter. | River Hunter deals 4 to Bone-Cracker Cub.
- Result: River Hunter left battle, Bone-Cracker Cub removed, Rusted Moon Shrine at 1/10

Main 2:
- Main 2: attached Esprit du Léopard to Leopard Hunter

End:
- retained card: Baobab Guardian
- discarded cards: Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Esprit du Léopard, Leopard Hunter [Wounded, Possession:Esprit du Léopard], River Hunter, Spear of First Dawn, Young Hunter

## Turn 42 — Iron

Pre-resource snapshot:
Offerings before resource: 7
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone Spear, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 15/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 9/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- Main 2: played Iron Hyena Champion

End:
- retained card: Bone Spear
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 15/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 9/10
- board at end: Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Champion, Pack Harrier

## Turn 43 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 7

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: Esprit du Léopard, Leopard Hunter [Wounded, Possession:Esprit du Léopard], River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 6 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Rusted Moon Shrine and broke it)
- Main 1: evolved River Hunter into Leopard Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Baobab Guardian, Deep River Spirit
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 1 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Esprit du Léopard, Kuma Who Wounded the Sun [Possession:Esprit du Léopard], Leopard Hunter, Spear of First Dawn, Young Hunter

## End-of-game summary

Winner: red-hunter-evolution
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Shrine of the Red Baobab 4/10, Hunter’s Root-Stone 11/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 15/10, Bone-Fang Shrine 11/10, Rusted Moon Shrine 12/10]
Final resources: Red 1/5 | Iron 1/0
Final Presence: Seat 1 4/5 | Seat 2 3/5

Turn count: 43
Phase count: 11

First Shrine damage: 4
First Shrine broken: 12
First Ancestor awakened: 8
First L2: 11
First L3: 43

Red L2 entries: 7 (hard-cast 1, evolved 6)
Red L3 entries: 1 (hard-cast 0, evolved 1)
Iron L2 entries: 4 (hard-cast 2, evolved 2)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 18, Iron 6
Legal L2 evolve actions: Red 16, Iron 6
Legal L3 evolve actions: Red 2, Iron 0
Evolve windows: Red 12, Iron 4
Turns with legal L2 evolution: Red 12, Iron 4
Turns with legal L3 evolution: Red 2, Iron 0
Evolve actions chosen: Red 16, Iron 6
Hard-cast chosen while legal evolve action existed: Red 1, Iron 2
Hard-cast chosen while evolution base existed: Red 6, Iron 0

Legal awaken actions generated: Red 27, Iron 2
Awaken actions chosen: Red 12, Iron 2
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.firsthunter, Iron iron.ancestor.hyena
Ancestor switches: Red 5, Iron 1
Turns with awakened ancestor: Red 18, Iron 10
Memory spent on ancestors: Red 12, Iron 4
Ancestor realized value: First Hunter +5 damage, Grandmother healed 1, Child draw/discard 1, Iron Hyena +1 damage, Smith saved 1 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 1, Iron 3
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 6, Iron 6
Wounded events: Red 15, Iron 5
Wounded reduced damage: Red 13, Iron 5
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 3, Iron 6
Blocks chosen: Red 3, Iron 3
Blocks declined: Red 0, Iron 2
Assault slots spent: Seat 1 standard 23, pack 0 | Seat 2 standard 8, pack 15
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 44, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 21, generated 20, available 20, skipped 5, turns-with-bonus 13, max-attacks 62, prevented-by-limit 0
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
