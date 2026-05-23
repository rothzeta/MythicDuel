# Test Game #482

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports\matrix_runs\phase6_red_vs_pack --bot-red red --bot-iron iron --deck-red red-hunter-evolution --deck-iron iron-hyena-pack-pressure --rules phase-length-6

Seat 1:
- red-hunter-evolution [Red] (RedBaobabBot)
Seat 2:
- iron-hyena-pack-pressure [Iron] (IronHyenaBot)

Rules variant:
- Draw model: retain up to 1, discard rest, draw to 5
- Phase model: reverse every 4 player-turns
- Combat model: 2 standard Assault slots, plus Pack expansion up to 5 total attacks, separate resolution
- Battlefield capacity: 5 Presence per seat
- Prepared model: max 1 active tactic per player
- Special mechanics: Fade, Forgotten, Wounded, Pierce, Disperse, Possession, Evolution, Recall, Unique, Pack

Seed: 482
Winner: red-hunter-evolution
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Deep River Spirit, Kuma Who Wounded the Sun, River Hunter, Root-Woven Guard, Young Hunter
- Starting hands — Iron: Bite the Roots, Black-Tooth Smith, Hyena Pack Call, Iron Hyena Champion, Pack Harrier
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Deep River Spirit, Kuma Who Wounded the Sun, River Hunter, Root-Woven Guard, Young Hunter]

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
- discarded cards: River Hunter, Root-Woven Guard, Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Black-Tooth Smith, Hyena Pack Call, Iron Hyena Champion, Pack Harrier]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Pack Harrier

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bite the Roots
- discarded cards: Black-Tooth Smith, Hyena Pack Call, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Pack Harrier

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
- Main 2: prepared Hunter’s Call

End:
- retained card: Leopard Hunter
- discarded cards: Deep River Spirit, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
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
- discarded cards: Pack Harrier, Blood-Scent Hyena, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/1 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 1
Key events: Main 1: played Pack Harrier | Pack Harrier deals 1 to Young Hunter. | Young Hunter deals 2 to Pack Harrier. | Main 1: played Young Hunter | Main 2: prepared Hunter’s Call | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: Hunter’s Call
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Ritual of Red Moon (had no legal target)

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Young Hunter survives, Bone-Fang Shrine at 7/10

Main 2:
- Main 2: prepared Hunter’s Call

End:
- retained card: Leopard Hunter
- discarded cards: Pale River Spirit, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 6 — Iron

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
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Iron Hyena Raider, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 5.
- Result: Bone-Cracker Cub survives, Hunter’s Root-Stone at 0/10

Main 2:
- Main 2: played Iron Hyena Raider

End:
- retained card: Bone Spear
- discarded cards: Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Hyena Token, Iron Hyena Raider

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: Hunter’s Call
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Hunter’s Call, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Spear of First Dawn to Young Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 3 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Leopard Hunter
- discarded cards: Ritual of Red Moon, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: River Hunter

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/1
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 3 | Iron 3
Key events: Main 2: played Iron Hyena Raider | Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 3 to Iron Hyena Raider. | Main 1: played River Hunter | Main 1: attached Spear of First Dawn to Young Hunter | Main 2: awakened First Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
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

Attack 2:
- Attacker: Hyena Token
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 2.
- Result: Hyena Token survives, Moonlit Roots at 5/10

Main 2:
- Main 2: played Blood-Scent Hyena
- Main 2: played Pack Harrier
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Hyena Token, Pack Harrier

## Turn 10 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 5/10
Forgotten zone count/list: 3 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Blood-Scent Hyena deals 2 to River Hunter. | River Hunter deals 3 to Blood-Scent Hyena.
- Result: River Hunter left battle, Blood-Scent Hyena removed

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Baobab Guardian, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 4/10
- board at end: River Hunter, Young Hunter

## Turn 11 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone Spear, Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Hyena Token, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Moonlit Roots)

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 2.
- Result: Pack Harrier survives, Moonlit Roots at 2/10

Attack 2:
- Attacker: Hyena Token
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 2.
- Result: Hyena Token survives, Moonlit Roots at 0/10

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Hyena Pack Call, Iron Hyena Raider, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Hyena Token, Iron Hyena Champion [Relic:Bone Spear], Pack Harrier

## Turn 12 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 2

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 3 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 6 to River Hunter. | River Hunter deals 3 to Iron Hyena Champion.
- Result: River Hunter left battle, Iron Hyena Champion removed

Attack 2:
- Attacker: Young Hunter
- Target: Hyena Token
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Hyena Token deals 1 to Young Hunter. | Young Hunter deals 2 to Hyena Token.
- Result: Young Hunter left battle, Hyena Token removed

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Root-Woven Guard, Spear of First Dawn, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Leopard Hunter

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/4 | Iron 3/1
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 3 | Iron 3
Key events: Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Moonlit Roots) | Iron Hyena Champion deals 6 to River Hunter. | River Hunter deals 3 to Iron Hyena Champion. | Hyena Token deals 1 to Young Hunter. | Young Hunter deals 2 to Hyena Token. | Main 1: played Leopard Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 4

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Leopard Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 3 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter
- Main 1: resolved Ritual of Red Moon (dealt 2 to Pack Harrier, destroyed it, gained 1 Memory)

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 5.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 2/10

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Baobab Guardian
- discarded cards: Offering of Milk and Ash, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Leopard Hunter, Leopard Hunter

## Turn 14 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Bone Spear
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token)
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- Main 2: played Pack Harrier

End:
- retained card: Fang Relic
- discarded cards: Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Hyena Token, Pack Harrier

## Turn 15 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 3

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: Leopard Hunter, Leopard Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 4 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 4.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 0/10

Main 2:
- Main 2: played Baobab Guardian
- Main 2: attached Esprit du Léopard to Leopard Hunter

End:
- retained card: Young Hunter
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Esprit du Léopard, Leopard Hunter, Leopard Hunter [Possession:Esprit du Léopard], River Hunter, Young Hunter

## Turn 16 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Hyena Token, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 6 to Hyena Token. | Hyena Token deals 1 to Leopard Hunter.
- Result: Hyena Token left battle, Leopard Hunter survives

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 6 to 4.
- Damage: Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed

Main 2:
- Main 2: played Blood-Scent Hyena

End:
- retained card: Iron Hyena Champion
- discarded cards: Bone-Cracker Cub, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Pack Harrier

# End of Phase 3 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/2 | Iron 4/1
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Ancestor of the First Pack
Forgotten cards: Red 4 | Iron 4
Key events: Leopard Hunter deals 6 to Hyena Token. | Hyena Token deals 1 to Leopard Hunter. | Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Leopard Hunter. | Main 1: attached Fang Relic to Bone-Cracker Cub | Main 2: played Blood-Scent Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 4

Hand before draw: [Young Hunter]

Board before ready:
Beings/Spirits: Baobab Guardian, Leopard Hunter, River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 4 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: Pack Harrier
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Pack Harrier deals 1 to Leopard Hunter. | Leopard Hunter deals 4 to Pack Harrier.
- Result: Leopard Hunter survives, Pack Harrier removed, Iron Hyena Den at 10/10

Attack 2:
- Attacker: River Hunter
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Blood-Scent Hyena deals 2 to River Hunter. | River Hunter deals 3 to Blood-Scent Hyena.
- Result: River Hunter left battle, Blood-Scent Hyena removed

Main 2:
- Main 2: played River Hunter
- Main 2: awakened First Hunter

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Pale River Spirit, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Leopard Hunter [Wounded], River Hunter, Young Hunter, Young Hunter

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone Spear
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Iron Hyena Champion
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Black-Tooth Smith, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Hyena Token, Hyena Token, Iron Hyena Champion

## Turn 19 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone Spear, Hyena Token, Hyena Token, Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Leopard Hunter.
- Result: Iron Hyena Champion left battle, Leopard Hunter removed

Main 2:
- Main 2: played Blood-Scent Hyena
- Main 2: played Bone-Cracker Cub

End:
- retained card: Pack Harrier
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub, Hyena Token, Hyena Token

## Turn 20 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 4

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Baobab Guardian, River Hunter, Young Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 4 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Esprit du Léopard to Young Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Blood-Scent Hyena deals 2 to Young Hunter. | Young Hunter deals 4 to Blood-Scent Hyena.
- Result: Young Hunter left battle, Blood-Scent Hyena removed

Main 2:
- Main 2: played Deep River Spirit

End:
- retained card: Ritual of Red Moon
- discarded cards: Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Deep River Spirit, River Hunter, Young Hunter, Young Hunter

# End of Phase 4 Summary

Shrine state: Red [Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/4 | Iron 4/1
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 4 | Iron 4
Key events: Main 2: played Bone-Cracker Cub | Blood-Scent Hyena deals 2 to Young Hunter. | Young Hunter deals 4 to Blood-Scent Hyena. | Main 1: played Young Hunter | Main 1: attached Esprit du Léopard to Young Hunter | Main 2: played Deep River Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Hyena Token, Hyena Token
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Hyena Token. | Hyena Token deals 1 to Deep River Spirit.
- Result: Hyena Token left battle, Deep River Spirit survives

Attack 2:
- Attacker: Hyena Token
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2. | Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 2 to Hyena Token. | Hyena Token deals 1 to Deep River Spirit.
- Result: Hyena Token left battle, Deep River Spirit survives

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2. | Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 2 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Deep River Spirit.
- Result: Bone-Cracker Cub left battle, Deep River Spirit survives

Main 2:
- Main 2: played Iron Hyena Champion

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Hyena Champion, Iron Hyena Raider, Pack Harrier

## Turn 22 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 4

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Baobab Guardian, Deep River Spirit [Wounded], River Hunter, Young Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 4 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to Baobab Guardian

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to River Hunter. | River Hunter deals 3 to Iron Hyena Champion.
- Result: River Hunter left battle, Iron Hyena Champion removed

Attack 2:
- Attacker: Young Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: resolved Ritual of Red Moon (dealt 2 to Pack Harrier, destroyed it, gained 1 Memory)
- Main 2: prepared Root-Woven Guard

End:
- retained card: Pale River Spirit
- discarded cards: Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: Deep River Spirit
- resources at end: 3 Offerings / 6 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn], Deep River Spirit, Spear of First Dawn, Young Hunter

## Turn 23 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone Spear
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Iron Hyena Raider, Pack Harrier

## Turn 24 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 6

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian [Relic:Spear of First Dawn], Deep River Spirit, Spear of First Dawn, Young Hunter
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 5 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Attack 2:
- Attacker: Baobab Guardian
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Black-Tooth Smith deals 2 to Baobab Guardian. | Baobab Guardian deals 3 to Black-Tooth Smith.
- Result: Baobab Guardian survives, Black-Tooth Smith removed

Main 2:
- Main 2: played Pale River Spirit
- Main 2: attached Spear of First Dawn to Baobab Guardian

End:
- retained card: Deep River Spirit
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian [Wounded, Relic:Spear of First Dawn], Deep River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter

# End of Phase 4 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/7 | Iron 2/1
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 5 | Iron 4
Key events: Black-Tooth Smith deals 2 to Baobab Guardian. | Baobab Guardian deals 3 to Black-Tooth Smith. | Main 1: played River Hunter | Main 1: played Young Hunter | Main 2: played Pale River Spirit | Main 2: attached Spear of First Dawn to Baobab Guardian
Tempo note: initiative reverses after every four player-turns.

## Turn 25 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 7

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian [Wounded, Relic:Spear of First Dawn], Deep River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 5 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: attached Esprit du Léopard to Baobab Guardian

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Pack Harrier
- Defender/blocker: Pack Harrier
- Prepared triggers: None
- Wounded/Pierce calculations: River Hunter becomes Wounded.
- Damage: Pack Harrier deals 1 to River Hunter. | River Hunter deals 3 to Pack Harrier.
- Result: River Hunter survives, Pack Harrier removed

Main 2:
- pass

End:
- retained card: Deep River Spirit
- discarded cards: River Hunter, Kuma Who Wounded the Sun, Young Hunter
- forgotten cards: None
- Wounded clears: Baobab Guardian
- resources at end: 6 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Deep River Spirit, Esprit du Léopard, Pale River Spirit, River Hunter [Wounded], Spear of First Dawn, Spear of First Dawn, Young Hunter

## Turn 26 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone Spear
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Pack Harrier

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Pack Harrier

## Turn 27 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 7

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Deep River Spirit, Esprit du Léopard, Pale River Spirit, River Hunter [Wounded], Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 5 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Blood-Scent Hyena deals 2 to Young Hunter. | Young Hunter deals 2 to Blood-Scent Hyena.
- Result: Young Hunter left battle, Blood-Scent Hyena removed

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit, Root-Woven Guard, Pale River Spirit
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 5 Offerings / 8 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Deep River Spirit, Esprit du Léopard, Leopard Hunter, Pale River Spirit, Spear of First Dawn, Spear of First Dawn

## Turn 28 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 1

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone Spear, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Pack Harrier
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Pack Harrier. | Pack Harrier deals 2 to Deep River Spirit.
- Result: Pack Harrier left battle, Deep River Spirit survives

Main 2:
- Main 2: played Bone-Cracker Cub

End:
- retained card: Hyena Token
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub [Relic:Bone Spear]

# End of Phase 5 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/8 | Iron 3/1
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 5 | Iron 4
Key events: Main 1: evolved River Hunter into Leopard Hunter | Deep River Spirit deals 3 to Pack Harrier. | Pack Harrier deals 2 to Deep River Spirit. | Main 1: attached Fang Relic to Pack Harrier | Main 1: played Blood-Scent Hyena | Main 2: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 29 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 8

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Deep River Spirit [Wounded], Esprit du Léopard, Leopard Hunter, Pale River Spirit, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 5 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter

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
- Attacker: Baobab Guardian
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Blood-Scent Hyena deals 2 to Baobab Guardian. | Baobab Guardian deals 5 to Blood-Scent Hyena.
- Result: Baobab Guardian survives, Blood-Scent Hyena removed

Main 2:
- Main 2: attached Esprit du Léopard to Baobab Guardian

End:
- retained card: Leopard Hunter
- discarded cards: Baobab Guardian, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: Deep River Spirit
- resources at end: 4 Offerings / 8 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Deep River Spirit, Esprit du Léopard, Leopard Hunter, Pale River Spirit, River Hunter, Spear of First Dawn, Spear of First Dawn

## Turn 30 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Hyena Token]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub [Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 5/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab)
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Pack Harrier
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 5/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Iron Hyena Champion [Relic:Bone Spear], Iron Hyena Raider

## Turn 31 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Iron Hyena Champion [Relic:Bone Spear], Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 5/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
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
- Attacker: Iron Hyena Champion
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2. | Iron Hyena Champion becomes Wounded.
- Damage: Deep River Spirit deals 2 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Deep River Spirit.
- Result: Iron Hyena Champion survives, Deep River Spirit removed

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 5/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Iron Hyena Champion [Wounded, Relic:Bone Spear], Iron Hyena Raider, Pack Harrier

## Turn 32 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 9

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Baobab Guardian [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Leopard Hunter, Pale River Spirit, River Hunter, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 5 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Iron Hyena Den)
- Main 1: evolved River Hunter into Leopard Hunter

Combat:
- no attacks

Main 2:
- Main 2: awakened Child Who Remembered the Dead

End:
- retained card: Offering of Milk and Ash
- discarded cards: River Hunter, Root-Woven Guard
- forgotten cards: None
- Wounded clears: Baobab Guardian, Leopard Hunter
- resources at end: 1 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Kuma Who Wounded the Sun, Leopard Hunter, Pale River Spirit, Spear of First Dawn, Spear of First Dawn

# End of Phase 6 Summary

Shrine state: Red [Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10] | Iron [Iron Hyena Den: 5/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/5 | Iron 3/1
Awakened Ancestors: Red Child Who Remembered the Dead | Iron Ancestor of the First Pack
Forgotten cards: Red 5 | Iron 4
Key events: Main 1: played Pack Harrier | Main 1: played Bone-Cracker Cub | Main 2: played Black-Tooth Smith | Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Iron Hyena Den) | Main 1: evolved River Hunter into Leopard Hunter | Main 2: awakened Child Who Remembered the Dead
Tempo note: initiative reverses after every four player-turns.

## Turn 33 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Iron Hyena Champion [Wounded, Relic:Bone Spear], Iron Hyena Raider, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 8/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Kuma Who Wounded the Sun
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 6 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Kuma Who Wounded the Sun.
- Result: Black-Tooth Smith left battle, Kuma Who Wounded the Sun survives

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Kuma Who Wounded the Sun
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 6 to 4. | Wounded reduces Kuma Who Wounded the Sun from 6 to 4.
- Damage: Kuma Who Wounded the Sun deals 4 to Iron Hyena Champion. | Iron Hyena Champion deals 4 to Kuma Who Wounded the Sun.
- Result: Iron Hyena Champion left battle, Kuma Who Wounded the Sun removed

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Bone-Cracker Cub, Pack Harrier, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 7 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 8/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Iron Hyena Raider, Pack Harrier

## Turn 34 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 6

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Leopard Hunter, Pale River Spirit, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: Child Who Remembered the Dead
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 6 [Hunter’s Call, Hunter’s Call, Kuma Who Wounded the Sun, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Esprit du Léopard to Baobab Guardian

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: Pack Harrier
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Pack Harrier deals 1 to Leopard Hunter. | Leopard Hunter deals 4 to Pack Harrier.
- Result: Leopard Hunter survives, Pack Harrier removed, Iron Hyena Den at 2/10

Attack 2:
- Attacker: Baobab Guardian
- Target: Iron Hyena Den
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Bone-Cracker Cub deals 2 to Baobab Guardian. | Baobab Guardian deals 5 to Bone-Cracker Cub.
- Result: Baobab Guardian survives, Bone-Cracker Cub removed, Iron Hyena Den at 2/10

Main 2:
- Main 2: played Baobab Guardian
- Main 2: awakened First Hunter

End:
- retained card: Deep River Spirit
- discarded cards: Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Baobab Guardian [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Leopard Hunter [Wounded], Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter

## Turn 35 — Iron

Pre-resource snapshot:
Offerings before resource: 7
Memory before resource: 1

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone Spear, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 8/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Raider
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Leopard Hunter.
- Result: Iron Hyena Raider left battle, Leopard Hunter removed

Main 2:
- Main 2: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 8/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Hyena Token, Hyena Token

## Turn 36 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 5

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian, Baobab Guardian [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 6 [Hunter’s Call, Hunter’s Call, Kuma Who Wounded the Sun, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 6 to 4.
- Damage: Shrine Iron Hyena Den takes 4.
- Result: Baobab Guardian survives, Iron Hyena Den at 0/10

Main 2:
- Main 2: awakened Child Who Remembered the Dead

End:
- retained card: Pale River Spirit
- discarded cards: Deep River Spirit, Deep River Spirit, River Hunter
- forgotten cards: None
- Wounded clears: Baobab Guardian
- resources at end: 7 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter, Young Hunter

# End of Phase 6 Summary

Shrine state: Red [Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10] | Iron [Iron Hyena Den: 8/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 7/3 | Iron 2/1
Awakened Ancestors: Red Child Who Remembered the Dead | Iron Ancestor of the First Pack
Forgotten cards: Red 6 | Iron 4
Key events: Main 1: attached Fang Relic to Iron Hyena Raider | Main 1: played Blood-Scent Hyena | Main 2: resolved Hyena Pack Call (summoned 2 Hyena Tokens) | Shrine Iron Hyena Den takes 4. | Main 1: played Young Hunter | Main 2: awakened Child Who Remembered the Dead
Tempo note: initiative reverses after every four player-turns.

## Turn 37 — Red

Pre-resource snapshot:
Offerings before resource: 7
Memory before resource: 3

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian, Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter, Young Hunter
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: Child Who Remembered the Dead
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 6 [Hunter’s Call, Hunter’s Call, Kuma Who Wounded the Sun, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: prepared Root-Woven Guard

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 5.
- Result: Baobab Guardian survives, Rusted Moon Shrine at 5/10

Attack 2:
- Attacker: Young Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 2.
- Result: Young Hunter survives, Rusted Moon Shrine at 3/10

Main 2:
- pass

End:
- retained card: Pale River Spirit
- discarded cards: River Hunter, Deep River Spirit, Young Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 7 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter, Young Hunter

## Turn 38 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Hyena Token, Hyena Token
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 7/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 5 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Baobab Guardian.
- Result: Blood-Scent Hyena left battle, Baobab Guardian survives

Attack 2:
- Attacker: Hyena Token
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 5 to 3. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 3 to Hyena Token. | Hyena Token deals 1 to Baobab Guardian.
- Result: Hyena Token left battle, Baobab Guardian survives

Attack 3:
- Attacker: Hyena Token
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 5 to 3.
- Damage: Baobab Guardian deals 3 to Hyena Token. | Hyena Token deals 1 to Baobab Guardian.
- Result: Hyena Token left battle, Baobab Guardian removed

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Hyena Pack Call, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 7/10
- board at end: Bone Spear, Bone-Cracker Cub, Iron Hyena Raider

## Turn 39 — Red

Pre-resource snapshot:
Offerings before resource: 7
Memory before resource: 4

Hand before draw: [Offering of Milk and Ash]

Board before ready:
Beings/Spirits: Baobab Guardian, Pale River Spirit, Spear of First Dawn, Young Hunter, Young Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: Child Who Remembered the Dead
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 6 [Hunter’s Call, Hunter’s Call, Kuma Who Wounded the Sun, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 2.
- Result: Baobab Guardian survives, Rusted Moon Shrine at 1/10

Main 2:
- pass

End:
- retained card: Deep River Spirit
- discarded cards: Offering of Milk and Ash, River Hunter, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Leopard Hunter, Pale River Spirit, Spear of First Dawn, Young Hunter

## Turn 40 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 1

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 9/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Leopard Hunter.
- Result: Iron Hyena Raider left battle, Leopard Hunter survives

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Bone-Cracker Cub, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 9/10
- board at end: Blood-Scent Hyena, Bone Spear, Iron Hyena Raider

# End of Phase 7 Summary

Shrine state: Red [Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10] | Iron [Iron Hyena Den: 12/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 9/10]
Resources: Red 5/4 | Iron 4/1
Awakened Ancestors: Red Child Who Remembered the Dead | Iron Ancestor of the First Pack
Forgotten cards: Red 6 | Iron 4
Key events: Leopard Hunter deals 4 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Leopard Hunter. | Leopard Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Leopard Hunter. | Main 1: played Blood-Scent Hyena | Main 1: played Iron Hyena Raider
Tempo note: initiative reverses after every four player-turns.

## Turn 41 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 5

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian, Pale River Spirit, Spear of First Dawn, Young Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: Child Who Remembered the Dead
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 6 [Hunter’s Call, Hunter’s Call, Kuma Who Wounded the Sun, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 2.
- Result: Baobab Guardian survives, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Deep River Spirit
- discarded cards: Young Hunter, Deep River Spirit
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 3 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Leopard Hunter, Pale River Spirit, River Hunter, Spear of First Dawn

## End-of-game summary

Winner: red-hunter-evolution
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Shrine of the Red Baobab 3/10, Hunter’s Root-Stone 12/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 12/10, Bone-Fang Shrine 12/10, Rusted Moon Shrine 11/10]
Final resources: Red 3/5 | Iron 4/1
Final Presence: Seat 1 4/5 | Seat 2 2/5

Turn count: 41
Phase count: 7

First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 5)
First Shrine broken: 7 (Seat 1/Red: 7, Seat 2/Iron: 15)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 16, Iron 12
First Ancestor awakened: 8
First L2: 11
First L3: 32

Red L2 entries: 6 (hard-cast 2, evolved 4)
Red L3 entries: 1 (hard-cast 0, evolved 1)
Iron L2 entries: 4 (hard-cast 2, evolved 2)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 14, Iron 6
Legal L2 evolve actions: Red 12, Iron 6
Legal L3 evolve actions: Red 2, Iron 0
Evolve windows: Red 8, Iron 4
Turns with legal L2 evolution: Red 8, Iron 4
Turns with legal L3 evolution: Red 2, Iron 0
Evolve actions chosen: Red 13, Iron 6
Hard-cast chosen while legal evolve action existed: Red 1, Iron 1
Hard-cast chosen while evolution base existed: Red 4, Iron 3

Legal awaken actions generated: Red 34, Iron 2
Awaken actions chosen: Red 14, Iron 1
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.firsthunter, Iron iron.ancestor.firstpack
Ancestor switches: Red 5, Iron 0
Turns with awakened ancestor: Red 17, Iron 15
Memory spent on ancestors: Red 12, Iron 2
Ancestor realized value: First Hunter +3 damage, Grandmother healed 0, Child draw/discard 4, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 2, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 6, Iron 4
Wounded events: Red 16, Iron 1
Wounded reduced damage: Red 11, Iron 1
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 0, Iron 6
Blocks chosen: Red 0, Iron 3
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 26, pack 0 | Seat 2 standard 7, pack 15
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 42, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 20, generated 19, available 19, skipped 4, turns-with-bonus 13, max-attacks 59, prevented-by-limit 0
Deck reshuffles: Red 5, Iron 3

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
