# Test Game #188

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports\matrix_runs\strict_pack_vs_red --bot-red iron --bot-iron red --deck-red iron-hyena-pack-pressure --deck-iron red-hunter-evolution --rules strict-alternation

Seat 1:
- iron-hyena-pack-pressure [Iron] (IronHyenaBot)
Seat 2:
- red-hunter-evolution [Red] (RedBaobabBot)

Rules variant:
- Draw model: retain up to 1, discard rest, draw to 5
- Phase model: reverse every 4 player-turns
- Combat model: 2 standard Assault slots, plus Pack expansion up to 5 total attacks, separate resolution
- Battlefield capacity: 5 Presence per seat
- Prepared model: max 1 active tactic per player
- Special mechanics: Fade, Forgotten, Wounded, Pierce, Disperse, Possession, Evolution, Recall, Unique, Pack

Seed: 188
Winner: red-hunter-evolution
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting Shrines — Iron: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting hands — Red: Bite the Roots, Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear, Bone Spear
- Starting hands — Iron: Kuma Who Wounded the Sun, Pale River Spirit, River Hunter, Root-Woven Guard, Root-Woven Guard
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang
- Starting Lineage — Iron: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear, Bone Spear]

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
- discarded cards: Blood-Scent Hyena, Bone Spear, Blood-Scent Hyena, Bone Spear
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Kuma Who Wounded the Sun, Pale River Spirit, River Hunter, Root-Woven Guard, Root-Woven Guard]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- pass

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: River Hunter
- discarded cards: Kuma Who Wounded the Sun, Pale River Spirit, Root-Woven Guard, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: 

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
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
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Pack Call, Iron Hyena Raider, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [River Hunter]

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
- retained card: Pale River Spirit
- discarded cards: Young Hunter, Young Hunter, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: River Hunter

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10]
Resources: Red 0/0 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 0
Key events: Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone) | Main 1: played River Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Pack Harrier
- discarded cards: Iron Hyena Raider, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 6 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to River Hunter. | River Hunter deals 3 to Bone-Cracker Cub.
- Result: River Hunter left battle, Bone-Cracker Cub removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Pale River Spirit
- discarded cards: Deep River Spirit, River Hunter, Young Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
- board at end: River Hunter

## Turn 7 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Pack Harrier

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Blood-Scent Hyena, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Pack Harrier, Pack Harrier

## Turn 8 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Ritual of Red Moon (dealt 2 to Pack Harrier, destroyed it, gained 1 Memory)
- Main 1: played Pale River Spirit

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Baobab Guardian
- discarded cards: Offering of Milk and Ash, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
- board at end: Pale River Spirit, River Hunter

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10]
Resources: Red 2/0 | Iron 0/1
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 2 | Iron 1
Key events: Main 1: played River Hunter | Main 2: awakened First Hunter | Main 1: played Pack Harrier | Main 1: played Pack Harrier | Main 1: resolved Ritual of Red Moon (dealt 2 to Pack Harrier, destroyed it, gained 1 Memory) | Main 1: played Pale River Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: attached Fang Relic to Pack Harrier
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Hunter’s Root-Stone
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Pack Harrier deals 1 to blocked Shrine.
- Damage: River Hunter deals 3 to Pack Harrier. | Pack Harrier deals 3 to River Hunter. | Shrine Hunter’s Root-Stone takes 1.
- Result: Pack Harrier left battle, River Hunter removed, Hunter’s Root-Stone at 3/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Champion, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 2

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: Pale River Spirit
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter

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
- discarded cards: Baobab Guardian, Spear of First Dawn, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 8/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Iron Hyena Champion
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone-Cracker Cub, Pack Harrier

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 4

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Leopard Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 8/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to Leopard Hunter
- Main 1: attached Esprit du Léopard to Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 11.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 0/10

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Ritual of Red Moon
- discarded cards: Baobab Guardian, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, Leopard Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10]
Resources: Red 1/0 | Iron 2/1
Awakened Ancestors: Red None | Iron Grandmother Beneath the Roots
Forgotten cards: Red 2 | Iron 1
Key events: Main 1: played Bone-Cracker Cub | Main 2: played Black-Tooth Smith | Shrine Bone-Fang Shrine takes 11. | Main 1: attached Spear of First Dawn to Leopard Hunter | Main 1: attached Esprit du Léopard to Leopard Hunter | Main 2: awakened Grandmother Beneath the Roots
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone-Cracker Cub, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Black-Tooth Smith survives, Hunter’s Root-Stone at 0/10

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Black-Tooth Smith, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone-Cracker Cub, Bone-Cracker Cub, Hyena Token, Pack Harrier

## Turn 14 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Esprit du Léopard, Leopard Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: Pack Harrier
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | WeaponMaster grants Pierce. | SoulSlayer grants Pierce. | Pierce overflow deals 8 to Iron Hyena Den.
- Damage: Pack Harrier deals 1 to Leopard Hunter. | Leopard Hunter deals 9 to Pack Harrier. | Shrine Iron Hyena Den takes 8.
- Result: Leopard Hunter survives, Pack Harrier removed, Iron Hyena Den at 2/10

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Ritual of Red Moon, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, Leopard Hunter, Leopard Hunter [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn, Young Hunter

## Turn 15 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone-Cracker Cub, Bone-Cracker Cub, Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 8/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives, Moonlit Roots at 9/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed, Moonlit Roots at 9/10

Attack 3:
- Attacker: Hyena Token
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 1.
- Result: Hyena Token survives, Moonlit Roots at 8/10

Attack 4:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 3.
- Result: Bone-Cracker Cub survives, Moonlit Roots at 5/10

Main 2:
- Main 2: played Iron Hyena Champion
- Main 2: played Blood-Scent Hyena

End:
- retained card: Bone-Cracker Cub
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 8/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub, Hyena Token, Hyena Token, Iron Hyena Champion

## Turn 16 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 2

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Esprit du Léopard, Leopard Hunter [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 5/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 9 to 6.
- Damage: Shrine Iron Hyena Den takes 6.
- Result: Leopard Hunter survives, Iron Hyena Den at 0/10

Attack 2:
- Attacker: Young Hunter
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Blood-Scent Hyena deals 2 to Young Hunter. | Young Hunter deals 2 to Blood-Scent Hyena.
- Result: Young Hunter left battle, Blood-Scent Hyena removed

Main 2:
- Main 2: attached Esprit du Léopard to Leopard Hunter
- Main 2: awakened First Hunter

End:
- retained card: Baobab Guardian
- discarded cards: Root-Woven Guard, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 4 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 6/10
- board at end: Esprit du Léopard, Leopard Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn, Spear of First Dawn

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 8/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 6/10]
Resources: Red 0/0 | Iron 4/1
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 1
Key events: Shrine Iron Hyena Den takes 6. | Blood-Scent Hyena deals 2 to Young Hunter. | Young Hunter deals 2 to Blood-Scent Hyena. | Main 1: attached Spear of First Dawn to Leopard Hunter | Main 2: attached Esprit du Léopard to Leopard Hunter | Main 2: awakened First Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Hyena Token, Hyena Token, Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 14/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 1.
- Result: Hyena Token survives, Moonlit Roots at 3/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 3.
- Result: Bone-Cracker Cub survives, Moonlit Roots at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Pack Harrier, Pack Harrier, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 7 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 14/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Bone-Cracker Cub, Hyena Token, Hyena Token, Iron Hyena Champion

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: Esprit du Léopard, Leopard Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Pale River Spirit

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | WeaponMaster grants Pierce. | SoulSlayer grants Pierce. | Pierce overflow deals 9 to Rusted Moon Shrine.
- Damage: Hyena Token deals 1 to Leopard Hunter. | Leopard Hunter deals 10 to Hyena Token. | Shrine Rusted Moon Shrine takes 9.
- Result: Leopard Hunter survives, Hyena Token removed, Rusted Moon Shrine at 1/10

Main 2:
- Main 2: played Baobab Guardian
- Main 2: resolved Offering of Milk and Ash (had no damaged shrine to restore)

End:
- retained card: Baobab Guardian
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Esprit du Léopard, Leopard Hunter [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Pale River Spirit, River Hunter, Spear of First Dawn, Spear of First Dawn

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 7
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Bone-Cracker Cub, Hyena Token, Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 14/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 9/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Hyena Token into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab)

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 7 to 5. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 5 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter survives

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 7 to 5.
- Damage: Leopard Hunter deals 5 to Iron Hyena Champion. | Iron Hyena Champion deals 5 to Leopard Hunter.
- Result: Iron Hyena Champion left battle, Leopard Hunter removed

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Black-Tooth Smith, Blood-Scent Hyena, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 14/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 9/10
- board at end: Bone-Cracker Cub, Iron Hyena Champion

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 2

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: Baobab Guardian, Pale River Spirit, River Hunter, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to River Hunter. | River Hunter deals 4 to Bone-Cracker Cub.
- Result: River Hunter left battle, Bone-Cracker Cub removed, Rusted Moon Shrine at 1/10

Attack 2:
- Attacker: Baobab Guardian
- Target: Rusted Moon Shrine
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to Baobab Guardian. | Baobab Guardian deals 3 to Iron Hyena Champion.
- Result: Baobab Guardian left battle, Iron Hyena Champion removed, Rusted Moon Shrine at 1/10

Main 2:
- Main 2: played Baobab Guardian

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Pale River Spirit, River Hunter, River Hunter, Spear of First Dawn

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 14/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 9/10] | Iron [Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10]
Resources: Red 5/0 | Iron 1/4
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 2
Key events: River Hunter deals 4 to Bone-Cracker Cub. | Iron Hyena Champion deals 5 to Baobab Guardian. | Baobab Guardian deals 3 to Iron Hyena Champion. | Main 1: played River Hunter | Main 1: played River Hunter | Main 2: played Baobab Guardian
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 14/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 9/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Fang Relic, Bone Spear
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 14/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 9/10
- board at end: Bone-Cracker Cub, Iron Hyena Raider

## Turn 22 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 4

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Baobab Guardian, Pale River Spirit, River Hunter, River Hunter, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played Pale River Spirit
- Main 1: prepared Root-Woven Guard

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 4.
- Result: River Hunter survives, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Deep River Spirit
- discarded cards: Kuma Who Wounded the Sun, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Pale River Spirit, Pale River Spirit, River Hunter, River Hunter, Spear of First Dawn

## End-of-game summary

Winner: red-hunter-evolution
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Iron Hyena Den 14/10, Bone-Fang Shrine 11/10, Rusted Moon Shrine 13/10] | Iron [Shrine of the Red Baobab 3/10, Hunter’s Root-Stone 10/10, Moonlit Roots 10/10]
Final resources: Red 5/0 | Iron 5/3
Final Presence: Seat 1 2/5 | Seat 2 5/5

Turn count: 22
Phase count: 1

First Shrine damage: 3 (Seat 1/Red: 12, Seat 2/Iron: 3)
First Shrine broken: 12 (Seat 1/Red: 12, Seat 2/Iron: 13)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 0, Iron 0
First Ancestor awakened: 6
First L2: 10
First L3: 

Red L2 entries: 2 (hard-cast 1, evolved 1)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 2 (hard-cast 2, evolved 0)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 4, Iron 0
Legal L2 evolve actions: Red 4, Iron 0
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 2, Iron 0
Turns with legal L2 evolution: Red 2, Iron 0
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 4, Iron 0
Hard-cast chosen while legal evolve action existed: Red 1, Iron 0
Hard-cast chosen while evolution base existed: Red 2, Iron 2

Legal awaken actions generated: Red 0, Iron 11
Awaken actions chosen: Red 0, Iron 5
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red None, Iron red.ancestor.firsthunter
Ancestor switches: Red 0, Iron 2
Turns with awakened ancestor: Red 0, Iron 8
Memory spent on ancestors: Red 0, Iron 6
Ancestor realized value: First Hunter +5 damage, Grandmother healed 2, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 4, Iron 2
Wounded events: Red 0, Iron 4
Wounded reduced damage: Red 0, Iron 4
Pierce overflow events: Red 0, Iron 2
WeaponMaster Pierce events: 2
SoulSlayer Pierce events: 2
Legal block options: Red 7, Iron 3
Blocks chosen: Red 4, Iron 3
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 3, pack 7 | Seat 2 standard 10, pack 0
Pack diagnostics: Seat 1 ready-at-combat 11, generated 10, available 10, skipped 3, turns-with-bonus 5, max-attacks 32, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 22, prevented-by-limit 0
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
