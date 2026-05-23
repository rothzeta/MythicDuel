# Test Game #468

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports\matrix_runs\strict_red_vs_pack --bot-red red --bot-iron iron --deck-red red-hunter-evolution --deck-iron iron-hyena-pack-pressure --rules strict-alternation

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

Seed: 468
Winner: red-hunter-evolution
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Deep River Spirit, Kuma Who Wounded the Sun, Pale River Spirit, Ritual of Red Moon, Young Hunter
- Starting hands — Iron: Bite the Roots, Blood-Scent Hyena, Bone-Cracker Cub, Pack Ambush, Pack Harrier
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Deep River Spirit, Kuma Who Wounded the Sun, Pale River Spirit, Ritual of Red Moon, Young Hunter]

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
- discarded cards: Pale River Spirit, Deep River Spirit, Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Blood-Scent Hyena, Bone-Cracker Cub, Pack Ambush, Pack Harrier]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bite the Roots
- discarded cards: Bone-Cracker Cub, Pack Harrier, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token

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
- Main 1: played Young Hunter

Combat:

Attack 1:
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
- retained card: Spear of First Dawn
- discarded cards: Ritual of Red Moon, Root-Woven Guard, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
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
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Pack Harrier
- discarded cards: Iron Hyena Champion, Iron Hyena Champion, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/1 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 2
Key events: Main 1: played Young Hunter | Main 1: resolved Pack Ambush (summoned Hyena Token) | Hyena Token deals 1 to Young Hunter. | Young Hunter deals 2 to Hyena Token. | Main 1: played Young Hunter | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: attached Spear of First Dawn to Young Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 6.
- Result: Young Hunter survives, Bone-Fang Shrine at 4/10

Main 2:
- Main 2: prepared Hunter’s Call

End:
- retained card: Leopard Hunter
- discarded cards: Spear of First Dawn, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn]

## Turn 6 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token)
- Main 1: played Pack Harrier

Combat:
- no attacks

Main 2:
- Main 2: played Pack Harrier

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token, Pack Harrier, Pack Harrier

## Turn 7 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn]
Prepared Tactic: Hunter’s Call
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played River Hunter
- Main 1: resolved Ritual of Red Moon (dealt 2 to Hyena Token, destroyed it, gained 1 Memory)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Baobab Guardian, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: River Hunter, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn]

## Turn 8 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Hunter’s Root-Stone
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Pack Harrier deals 1 to blocked Shrine.
- Damage: Young Hunter deals 3 to Pack Harrier. | Pack Harrier deals 2 to Young Hunter. | Shrine Hunter’s Root-Stone takes 1.
- Result: Pack Harrier left battle, Young Hunter removed, Hunter’s Root-Stone at 7/10

Attack 2:
- Attacker: Pack Harrier
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Pack Harrier survives, Hunter’s Root-Stone at 5/10

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub, Pack Harrier

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/2 | Iron 1/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 3
Key events: Young Hunter deals 3 to Pack Harrier. | Pack Harrier deals 2 to Young Hunter. | Shrine Hunter’s Root-Stone takes 1. | Shrine Hunter’s Root-Stone takes 2. | Main 1: played Blood-Scent Hyena | Main 1: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 3

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: Hunter’s Call
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: None
- Damage: Blood-Scent Hyena deals 2 to River Hunter. | River Hunter deals 3 to Blood-Scent Hyena.
- Result: River Hunter left battle, Blood-Scent Hyena removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Leopard Hunter
- discarded cards: Ritual of Red Moon, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
- board at end: River Hunter, Young Hunter

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Pack Harrier survives, Hunter’s Root-Stone at 4/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 5.
- Result: Bone-Cracker Cub survives, Hunter’s Root-Stone at 0/10

Main 2:
- Main 2: played Blood-Scent Hyena
- Main 2: played Blood-Scent Hyena
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Pack Harrier
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Pack Harrier

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 3

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Hunter’s Call, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter

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
- retained card: Leopard Hunter
- discarded cards: Esprit du Léopard, Esprit du Léopard, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, River Hunter

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Ancestor of the First Pack deals 1 to blocked Shrine.
- Damage: River Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to River Hunter. | Shrine Moonlit Roots takes 1.
- Result: Bone-Cracker Cub left battle, River Hunter removed, Moonlit Roots at 9/10

Attack 2:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | Pack Harrier deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 4 to Pack Harrier. | Pack Harrier deals 2 to Leopard Hunter. | Shrine Moonlit Roots takes 1.
- Result: Pack Harrier left battle, Leopard Hunter survives, Moonlit Roots at 8/10

Attack 3:
- Attacker: Blood-Scent Hyena
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Leopard Hunter.
- Result: Blood-Scent Hyena left battle, Leopard Hunter removed, Moonlit Roots at 8/10

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Pack Call, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Pack Harrier

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/4 | Iron 4/1
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 2 | Iron 3
Key events: Pack Harrier deals 2 to Leopard Hunter. | Shrine Moonlit Roots takes 1. | Leopard Hunter deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Leopard Hunter. | Main 1: played Pack Harrier | Main 1: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 4

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
Forgotten zone count/list: 2 [Hunter’s Call, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Leopard Hunter

Combat:
- no attacks

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Baobab Guardian
- discarded cards: Root-Woven Guard, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, River Hunter

## Turn 14 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Shrine of the Red Baobab)
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | Pack Harrier deals 1 to blocked Shrine. | Ancestor of the First Pack deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 4 to Pack Harrier. | Pack Harrier deals 2 to Leopard Hunter. | Shrine Shrine of the Red Baobab takes 2.
- Result: Pack Harrier left battle, Leopard Hunter survives, Shrine of the Red Baobab at 4/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 5 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed, Shrine of the Red Baobab at 4/10

Main 2:
- Main 2: played Bone-Cracker Cub

End:
- retained card: Fang Relic
- discarded cards: Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 15 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 3

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Hunter’s Call, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Pale River Spirit

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
- Main 2: played Baobab Guardian
- Main 2: awakened First Hunter

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 5/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Pale River Spirit, Young Hunter

## Turn 16 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 2

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Black-Tooth Smith
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Relic:Fang Relic], Bone-Cracker Cub, Fang Relic, Iron Hyena Raider

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 5/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10]
Resources: Red 2/3 | Iron 1/2
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 2 | Iron 4
Key events: Main 1: played Pale River Spirit | Main 2: played Baobab Guardian | Main 2: awakened First Hunter | Main 1: played Bone-Cracker Cub | Main 1: played Iron Hyena Raider | Main 2: played Black-Tooth Smith
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 3

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Baobab Guardian, Pale River Spirit, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 5/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Hunter’s Call, Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter
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
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Baobab Guardian, Spear of First Dawn
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 4 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 5/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Leopard Hunter, Young Hunter

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 2

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Relic:Fang Relic], Bone-Cracker Cub, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 3 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives

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
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Pack Harrier, Pack Harrier

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 6

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Baobab Guardian, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 5/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Hunter’s Call, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: resolved Ritual of Red Moon (dealt 2 to Black-Tooth Smith)

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
- retained card: Deep River Spirit
- discarded cards: Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, River Hunter

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 2

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Wounded], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab)

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 2 to 1. | Black-Tooth Smith becomes Wounded. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 2 to Black-Tooth Smith. | Black-Tooth Smith deals 1 to Baobab Guardian.
- Result: Black-Tooth Smith survives, Baobab Guardian survives

Main 2:
- Main 2: played Blood-Scent Hyena
- Main 2: awakened Bone-Splitter Mother

End:
- retained card: Fang Relic
- discarded cards: Bone-Cracker Cub, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Wounded], Blood-Scent Hyena, Iron Hyena Champion

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/7 | Iron 3/0
Awakened Ancestors: Red First Hunter | Iron Bone-Splitter Mother
Forgotten cards: Red 3 | Iron 4
Key events: Main 2: prepared Hunter’s Call | Baobab Guardian deals 2 to Black-Tooth Smith. | Black-Tooth Smith deals 1 to Baobab Guardian. | Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab) | Main 2: played Blood-Scent Hyena | Main 2: awakened Bone-Splitter Mother
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 7

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian [Wounded], River Hunter
Prepared Tactic: Hunter’s Call
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to River Hunter. | River Hunter deals 4 to Iron Hyena Champion.
- Result: River Hunter left battle, Iron Hyena Champion removed, Bone-Fang Shrine at 4/10

Attack 2:
- Attacker: Baobab Guardian
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 3 to 2.
- Damage: Shrine Bone-Fang Shrine takes 2.
- Result: Baobab Guardian survives, Bone-Fang Shrine at 2/10

Main 2:
- Main 2: played Deep River Spirit

End:
- retained card: Pale River Spirit
- discarded cards: Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: Baobab Guardian
- resources at end: 1 Offerings / 8 Memory
- shrine state: Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Deep River Spirit, River Hunter, Young Hunter

## Turn 22 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Wounded], Blood-Scent Hyena
Prepared Tactic: None
Awakened Ancestor: Bone-Splitter Mother
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 2 to 1. | Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Black-Tooth Smith. | Black-Tooth Smith deals 1 to Deep River Spirit.
- Result: Black-Tooth Smith left battle, Deep River Spirit survives

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2. | Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 2 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Deep River Spirit.
- Result: Blood-Scent Hyena left battle, Deep River Spirit survives

Main 2:
- Main 2: played Blood-Scent Hyena
- Main 2: played Blood-Scent Hyena

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena

## Turn 23 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 8

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian, Deep River Spirit [Wounded], River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 4 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to Baobab Guardian

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 4.
- Result: Baobab Guardian survives, Bone-Fang Shrine at 0/10

Main 2:
- Main 2: played Pale River Spirit
- Main 2: resolved Ritual of Red Moon (dealt 2 to Blood-Scent Hyena, destroyed it, gained 1 Memory)

End:
- retained card: Esprit du Léopard
- discarded cards: Esprit du Léopard
- forgotten cards: None
- Wounded clears: Deep River Spirit
- resources at end: 2 Offerings / 9 Memory
- shrine state: Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn], Deep River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter

## Turn 24 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Blood-Scent Hyena
Prepared Tactic: None
Awakened Ancestor: Bone-Splitter Mother
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Deep River Spirit.
- Result: Blood-Scent Hyena left battle, Deep River Spirit survives

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Hyena Pack Call, Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token, Hyena Token, Iron Hyena Raider

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 2/9 | Iron 4/0
Awakened Ancestors: Red First Hunter | Iron Bone-Splitter Mother
Forgotten cards: Red 5 | Iron 4
Key events: Main 2: played Pale River Spirit | Main 2: resolved Ritual of Red Moon (dealt 2 to Blood-Scent Hyena, destroyed it, gained 1 Memory) | Deep River Spirit deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Deep River Spirit. | Main 1: played Iron Hyena Raider | Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)
Tempo note: initiative reverses after every four player-turns.

## Turn 25 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 9

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian [Relic:Spear of First Dawn], Deep River Spirit [Wounded], Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 5 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to Baobab Guardian

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: attached Esprit du Léopard to Baobab Guardian

End:
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit, River Hunter
- forgotten cards: None
- Wounded clears: Deep River Spirit
- resources at end: 4 Offerings / 9 Memory
- shrine state: Shrine of the Red Baobab: 5/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Deep River Spirit, Esprit du Léopard, Pale River Spirit, River Hunter, Spear of First Dawn, Spear of First Dawn

## Turn 26 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Hyena Token, Hyena Token
Prepared Tactic: None
Awakened Ancestor: Bone-Splitter Mother
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Bone-Cracker Cub

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

Main 2:
- Main 2: played Iron Hyena Champion

End:
- retained card: Bone-Cracker Cub
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub, Iron Hyena Champion

## Turn 27 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 9

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Deep River Spirit [Wounded], Esprit du Léopard, Pale River Spirit, River Hunter, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 5/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 5 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to Baobab Guardian. | Baobab Guardian deals 5 to Iron Hyena Champion.
- Result: Baobab Guardian left battle, Iron Hyena Champion removed

Main 2:
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Esprit du Léopard, Offering of Milk and Ash, Baobab Guardian
- forgotten cards: None
- Wounded clears: Deep River Spirit, Leopard Hunter
- resources at end: 5 Offerings / 11 Memory
- shrine state: Shrine of the Red Baobab: 5/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Deep River Spirit, Leopard Hunter, Pale River Spirit, Spear of First Dawn

## Turn 28 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: Bone-Splitter Mother
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab)
- Main 1: attached Bone Spear to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Leopard Hunter.
- Result: Blood-Scent Hyena left battle, Leopard Hunter survives, Shrine of the Red Baobab at 3/10

Main 2:
- Main 2: played Bone-Cracker Cub

End:
- retained card: Bone Spear
- discarded cards: Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Iron Hyena Champion

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 5/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/11 | Iron 3/0
Awakened Ancestors: Red First Hunter | Iron Bone-Splitter Mother
Forgotten cards: Red 5 | Iron 4
Key events: Main 1: evolved River Hunter into Leopard Hunter | Leopard Hunter deals 4 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Leopard Hunter. | Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab) | Main 1: attached Bone Spear to Blood-Scent Hyena | Main 2: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 29 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 11

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Deep River Spirit, Leopard Hunter [Wounded], Pale River Spirit, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
Forgotten zone count/list: 5 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 5 to 3.
- Damage: Iron Hyena Champion deals 5 to Leopard Hunter. | Leopard Hunter deals 3 to Iron Hyena Champion.
- Result: Leopard Hunter left battle, Iron Hyena Champion removed, Iron Hyena Den at 10/10

Main 2:
- Main 2: played Leopard Hunter
- Main 2: prepared Root-Woven Guard

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: None
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 0 Offerings / 11 Memory
- shrine state: Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
- board at end: Deep River Spirit, Leopard Hunter, Pale River Spirit, Spear of First Dawn, Young Hunter, Young Hunter

## Turn 30 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: Bone-Splitter Mother
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: Root-Woven Guard
- Wounded/Pierce calculations: None
- Damage: Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed, Shrine of the Red Baobab at 3/10

Main 2:
- Main 2: played Blood-Scent Hyena

End:
- retained card: Pack Harrier
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena

## Turn 31 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 11

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Deep River Spirit, Pale River Spirit, Spear of First Dawn, Young Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
Forgotten zone count/list: 6 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: played River Hunter
- Main 1: prepared Root-Woven Guard

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
- Main 2: resolved Offering of Milk and Ash (restored 3 to Shrine of the Red Baobab)

End:
- retained card: Pale River Spirit
- discarded cards: Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 11 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
- board at end: Deep River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter

## Turn 32 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Blood-Scent Hyena
Prepared Tactic: None
Awakened Ancestor: Bone-Splitter Mother
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Shrine of the Red Baobab
- Defender/blocker: Young Hunter
- Prepared triggers: Root-Woven Guard
- Wounded/Pierce calculations: None
- Damage: Young Hunter deals 2 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Young Hunter.
- Result: Blood-Scent Hyena left battle, Young Hunter removed, Shrine of the Red Baobab at 7/10

Main 2:
- pass

End:
- retained card: Hyena Pack Call
- discarded cards: Iron Hyena Raider, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider, Pack Harrier

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 4/11 | Iron 5/0
Awakened Ancestors: Red First Hunter | Iron Bone-Splitter Mother
Forgotten cards: Red 7 | Iron 4
Key events: Main 1: prepared Root-Woven Guard | Main 2: resolved Offering of Milk and Ash (restored 3 to Shrine of the Red Baobab) | Young Hunter deals 2 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Young Hunter. | Main 1: played Pack Harrier | Main 1: played Iron Hyena Raider
Tempo note: initiative reverses after every four player-turns.

## Turn 33 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 11

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Deep River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
Forgotten zone count/list: 8 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

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
- Main 2: played Pale River Spirit

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 13 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
- board at end: Deep River Spirit, Pale River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter

## Turn 34 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Bone-Splitter Mother
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Pack Harrier
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 2.
- Result: Pack Harrier survives, Moonlit Roots at 6/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Iron Hyena Champion
- discarded cards: Black-Tooth Smith
- forgotten cards: None
- Wounded clears: Black-Tooth Smith
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Fang Relic, Hyena Token, Hyena Token, Pack Harrier [Relic:Fang Relic]

## Turn 35 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 13

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Deep River Spirit, Pale River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 4/10
Forgotten zone count/list: 8 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: attached Spear of First Dawn to Deep River Spirit

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Black-Tooth Smith deals 2 to River Hunter. | River Hunter deals 3 to Black-Tooth Smith.
- Result: River Hunter left battle, Black-Tooth Smith removed

Attack 2:
- Attacker: Young Hunter
- Target: Hyena Token
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Hyena Token deals 1 to Young Hunter. | Young Hunter deals 2 to Hyena Token.
- Result: Young Hunter left battle, Hyena Token removed

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Young Hunter
- discarded cards: Kuma Who Wounded the Sun, River Hunter, Young Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 13 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
- board at end: Deep River Spirit [Relic:Spear of First Dawn], Pale River Spirit, Pale River Spirit, Spear of First Dawn, Spear of First Dawn

## Turn 36 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Fang Relic, Hyena Token, Pack Harrier [Relic:Fang Relic]
Prepared Tactic: None
Awakened Ancestor: Bone-Splitter Mother
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab)
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 1.
- Result: Hyena Token survives, Shrine of the Red Baobab at 4/10

Main 2:
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Pack Harrier
- discarded cards: Hyena Token, Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Hyena Token, Iron Hyena Champion [Relic:Fang Relic], Pack Harrier

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 6/13 | Iron 4/0
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Ancestor of the First Pack
Forgotten cards: Red 8 | Iron 4
Key events: Main 1: attached Spear of First Dawn to Deep River Spirit | Main 2: awakened Grandmother Beneath the Roots | Shrine Shrine of the Red Baobab takes 1. | Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab) | Main 1: played Pack Harrier | Main 2: awakened Ancestor of the First Pack
Tempo note: initiative reverses after every four player-turns.

## Turn 37 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 13

Hand before draw: [Young Hunter]

Board before ready:
Beings/Spirits: Deep River Spirit [Relic:Spear of First Dawn], Pale River Spirit, Pale River Spirit, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
Forgotten zone count/list: 8 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Baobab Guardian

Combat:

Attack 1:
- Attacker: Deep River Spirit
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 6 to Deep River Spirit. | Deep River Spirit deals 4 to Iron Hyena Champion.
- Result: Deep River Spirit left battle, Iron Hyena Champion removed

Attack 2:
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
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 12 Memory
- shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
- board at end: Baobab Guardian, Pale River Spirit, Pale River Spirit [Wounded], Spear of First Dawn, Young Hunter

## Turn 38 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 0

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Pack Harrier
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 2 to Pack Harrier. | Pack Harrier deals 2 to Baobab Guardian.
- Result: Pack Harrier left battle, Baobab Guardian survives

Main 2:
- Main 2: played Bone-Cracker Cub

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Pack Harrier

## Turn 39 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 12

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian [Wounded], Pale River Spirit, Pale River Spirit [Wounded], Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
Forgotten zone count/list: 8 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 3 to 2.
- Damage: Shrine Iron Hyena Den takes 2.
- Result: Baobab Guardian survives, Iron Hyena Den at 8/10

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Leopard Hunter
- discarded cards: Esprit du Léopard, Esprit du Léopard, River Hunter
- forgotten cards: None
- Wounded clears: Baobab Guardian, Pale River Spirit
- resources at end: 5 Offerings / 10 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
- board at end: Baobab Guardian, Leopard Hunter, Pale River Spirit, Pale River Spirit, Spear of First Dawn

## Turn 40 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 2/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Pack Harrier. | Pack Harrier deals 1 to Leopard Hunter.
- Result: Pack Harrier left battle, Leopard Hunter survives

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter survives

Main 2:
- pass

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Pack Call, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 2/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10] | Iron [Iron Hyena Den: 2/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/10 | Iron 5/0
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Ancestor of the First Pack
Forgotten cards: Red 8 | Iron 4
Key events: Leopard Hunter deals 4 to Pack Harrier. | Pack Harrier deals 1 to Leopard Hunter. | Leopard Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Leopard Hunter. | Main 1: played Blood-Scent Hyena | Main 1: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 41 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 10

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Baobab Guardian, Leopard Hunter [Wounded], Pale River Spirit, Pale River Spirit, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
Forgotten zone count/list: 8 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Shrine Iron Hyena Den takes 3.
- Result: Leopard Hunter survives, Iron Hyena Den at 5/10

Attack 2:
- Attacker: Baobab Guardian
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 2.
- Result: Baobab Guardian survives, Iron Hyena Den at 3/10

Main 2:
- Main 2: resolved Offering of Milk and Ash (restored 3 to Shrine of the Red Baobab)

End:
- retained card: Leopard Hunter
- discarded cards: River Hunter, Spear of First Dawn
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 6 Offerings / 9 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
- board at end: Baobab Guardian, Leopard Hunter, Pale River Spirit, Pale River Spirit, Spear of First Dawn, Young Hunter

## Turn 42 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Leopard Hunter.
- Result: Blood-Scent Hyena left battle, Leopard Hunter survives

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
- retained card: Pack Harrier
- discarded cards: Hyena Pack Call, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena

## Turn 43 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 10

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Baobab Guardian, Pale River Spirit, Pale River Spirit, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
Forgotten zone count/list: 9 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 2.
- Result: Baobab Guardian survives, Iron Hyena Den at 1/10

Main 2:
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: River Hunter, Baobab Guardian
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 4 Offerings / 10 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Leopard Hunter, Pale River Spirit, Pale River Spirit, Spear of First Dawn, Young Hunter

## Turn 44 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 0

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Blood-Scent Hyena
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Leopard Hunter.
- Result: Blood-Scent Hyena left battle, Leopard Hunter survives

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Leopard Hunter.
- Result: Blood-Scent Hyena left battle, Leopard Hunter removed

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Token, Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Champion, Pack Harrier

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 9/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 4/10 | Iron 2/0
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Ancestor of the First Pack
Forgotten cards: Red 9 | Iron 4
Key events: Leopard Hunter deals 4 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Leopard Hunter. | Leopard Hunter deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Leopard Hunter. | Main 1: played Pack Harrier | Main 1: played Iron Hyena Champion
Tempo note: initiative reverses after every four player-turns.

## Turn 45 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 11

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Baobab Guardian, Pale River Spirit, Pale River Spirit, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 9 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Esprit du Léopard to Baobab Guardian

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 4.
- Result: Baobab Guardian survives, Iron Hyena Den at 0/10

Main 2:
- pass

End:
- retained card: Deep River Spirit
- discarded cards: Kuma Who Wounded the Sun, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 10 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter

## Turn 46 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Iron Hyena Champion, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 4 to Pack Harrier. | Pack Harrier deals 1 to Baobab Guardian.
- Result: Pack Harrier left battle, Baobab Guardian survives

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 4 to 3.
- Damage: Baobab Guardian deals 3 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Baobab Guardian.
- Result: Iron Hyena Champion left battle, Baobab Guardian removed

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: played Iron Hyena Raider

End:
- retained card: Hyena Token
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Iron Hyena Raider

## Turn 47 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 12

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Pale River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
Forgotten zone count/list: 9 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 3.
- Result: River Hunter survives, Rusted Moon Shrine at 7/10

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Deep River Spirit, Baobab Guardian, Spear of First Dawn
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 5 Offerings / 12 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, Pale River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn

## Turn 48 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Hyena Token]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives, Moonlit Roots at 10/10

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Ancestor of the First Pack deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Leopard Hunter. | Shrine Moonlit Roots takes 1.
- Result: Iron Hyena Raider left battle, Leopard Hunter removed, Moonlit Roots at 9/10

Main 2:
- pass

End:
- retained card: Hyena Token
- discarded cards: Hyena Token, Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 3/10
- board at end: Bone-Cracker Cub, Pack Harrier

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 13/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 3/10]
Resources: Red 5/12 | Iron 6/0
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Ancestor of the First Pack
Forgotten cards: Red 9 | Iron 4
Key events: Black-Tooth Smith deals 2 to Leopard Hunter. | Leopard Hunter deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Leopard Hunter. | Shrine Moonlit Roots takes 1. | Main 1: played Pack Harrier | Main 1: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 49 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 13

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Pale River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
Forgotten zone count/list: 9 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter
- Main 1: played River Hunter

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
- Main 2: awakened First Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Young Hunter, River Hunter
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 3 Offerings / 13 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
- board at end: Leopard Hunter, Pale River Spirit, River Hunter, Spear of First Dawn

## Turn 50 — Iron

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 0

Hand before draw: [Hyena Token]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Moonlit Roots)
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Token, Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 3/10
- board at end: Iron Hyena Champion, Iron Hyena Raider

## Turn 51 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 13

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Leopard Hunter, Pale River Spirit, River Hunter, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 3/10
Forgotten zone count/list: 9 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Esprit du Léopard to Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to Leopard Hunter. | Leopard Hunter deals 7 to Iron Hyena Champion.
- Result: Leopard Hunter left battle, Iron Hyena Champion removed, Rusted Moon Shrine at 7/10

Attack 2:
- Attacker: River Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 4.
- Result: River Hunter survives, Rusted Moon Shrine at 3/10

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 14 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 4/10
- board at end: Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter

## Turn 52 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 7/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Raider
- Main 1: attached Fang Relic to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 4.
- Result: Iron Hyena Raider survives, Moonlit Roots at 2/10

Main 2:
- Main 2: played Blood-Scent Hyena

End:
- retained card: Black-Tooth Smith
- discarded cards: Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 7/10
- board at end: Blood-Scent Hyena, Fang Relic, Fang Relic, Iron Hyena Raider [Relic:Fang Relic]

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 4/10] | Iron [Iron Hyena Den: 13/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 7/10]
Resources: Red 5/14 | Iron 2/0
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 9 | Iron 4
Key events: Main 1: played Young Hunter | Main 1: attached Esprit du Léopard to Leopard Hunter | Shrine Moonlit Roots takes 4. | Main 1: attached Fang Relic to Iron Hyena Raider | Main 1: attached Fang Relic to Iron Hyena Raider | Main 2: played Blood-Scent Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 53 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 14

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 8/10
Forgotten zone count/list: 9 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Spear of First Dawn to Pale River Spirit

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
- Main 2: awakened Child Who Remembered the Dead

End:
- retained card: Esprit du Léopard
- discarded cards: Pale River Spirit, Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 12 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 8/10
- board at end: Pale River Spirit [Relic:Spear of First Dawn], River Hunter, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter

## End-of-game summary

Winner: red-hunter-evolution
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Shrine of the Red Baobab 1/10, Hunter’s Root-Stone 11/10, Moonlit Roots 8/10] | Iron [Iron Hyena Den 13/10, Bone-Fang Shrine 12/10, Rusted Moon Shrine 11/10]
Final resources: Red 4/12 | Iron 2/0
Final Presence: Seat 1 4/5 | Seat 2 2/5

Turn count: 53
Phase count: 1

First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 5)
First Shrine broken: 10 (Seat 1/Red: 10, Seat 2/Iron: 23)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 0, Iron 0
First Ancestor awakened: 9
First L2: 11
First L3: 

Red L2 entries: 9 (hard-cast 3, evolved 6)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 6 (hard-cast 2, evolved 4)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 20, Iron 8
Legal L2 evolve actions: Red 20, Iron 8
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 12, Iron 8
Turns with legal L2 evolution: Red 12, Iron 8
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 16, Iron 8
Hard-cast chosen while legal evolve action existed: Red 3, Iron 2
Hard-cast chosen while evolution base existed: Red 10, Iron 4

Legal awaken actions generated: Red 55, Iron 7
Awaken actions chosen: Red 19, Iron 5
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.firsthunter, Iron iron.ancestor.firstpack
Ancestor switches: Red 7, Iron 2
Turns with awakened ancestor: Red 22, Iron 21
Memory spent on ancestors: Red 16, Iron 6
Ancestor realized value: First Hunter +8 damage, Grandmother healed 6, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 4, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 9, Iron 4
Wounded events: Red 18, Iron 2
Wounded reduced damage: Red 14, Iron 2
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 12, Iron 3
Blocks chosen: Red 11, Iron 3
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 29, pack 0 | Seat 2 standard 6, pack 28
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 54, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 31, generated 31, available 31, skipped 3, turns-with-bonus 21, max-attacks 83, prevented-by-limit 0
Deck reshuffles: Red 6, Iron 3

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
