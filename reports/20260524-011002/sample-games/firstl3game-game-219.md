# Test Game #219

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red red --bot-iron iron --deck-red red-hunter-evolution --deck-iron iron-hyena-pack-pressure

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

Seed: 219
Winner: red-hunter-evolution
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Esprit du Léopard, Esprit du Léopard, Pale River Spirit, Ritual of Red Moon, River Hunter
- Starting hands — Iron: Bite the Roots, Black-Tooth Smith, Bone Spear, Iron Hyena Raider, Iron Hyena Raider
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Esprit du Léopard, Esprit du Léopard, Pale River Spirit, Ritual of Red Moon, River Hunter]

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
- discarded cards: Pale River Spirit, Esprit du Léopard, Esprit du Léopard, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: 

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Black-Tooth Smith, Bone Spear, Iron Hyena Raider, Iron Hyena Raider]

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
- discarded cards: Iron Hyena Raider, Black-Tooth Smith, Iron Hyena Raider, Bone Spear
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [River Hunter]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
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
- retained card: Spear of First Dawn
- discarded cards: Offering of Milk and Ash, River Hunter, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: River Hunter

## Turn 4 — Iron

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
- retained card: Bite the Roots
- discarded cards: Hyena Pack Call, Fang Relic, Black-Tooth Smith
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
Key events: Main 1: played River Hunter | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: played Pack Harrier

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Pack Harrier
- discarded cards: Hyena Pack Call, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Pack Harrier

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: attached Spear of First Dawn to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Pack Harrier
- Defender/blocker: Pack Harrier
- Prepared triggers: None
- Wounded/Pierce calculations: River Hunter becomes Wounded.
- Damage: Pack Harrier deals 1 to River Hunter. | River Hunter deals 4 to Pack Harrier.
- Result: River Hunter survives, Pack Harrier removed

Main 2:
- pass

End:
- retained card: Ritual of Red Moon
- discarded cards: Pale River Spirit, Offering of Milk and Ash, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
- board at end: River Hunter [Wounded, Relic:Spear of First Dawn], Spear of First Dawn

## Turn 7 — Iron

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
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Pack Harrier, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Pack Harrier

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: River Hunter [Wounded, Relic:Spear of First Dawn], Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Ritual of Red Moon, Spear of First Dawn, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter [Relic:Spear of First Dawn], Spear of First Dawn

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/1 | Iron 2/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 2
Key events: Pack Harrier deals 1 to River Hunter. | River Hunter deals 4 to Pack Harrier. | Main 1: attached Spear of First Dawn to River Hunter | Main 1: played Pack Harrier | Main 1: played Bone-Cracker Cub | Main 1: evolved River Hunter into Leopard Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Leopard Hunter [Relic:Spear of First Dawn], Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 8.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 2/10

Main 2:
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Deep River Spirit, Root-Woven Guard, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, Leopard Hunter [Relic:Spear of First Dawn], Spear of First Dawn

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: attached Fang Relic to Bone-Cracker Cub
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Hunter’s Root-Stone
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | Pack Harrier deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 4 to Pack Harrier. | Pack Harrier deals 2 to Leopard Hunter. | Shrine Hunter’s Root-Stone takes 1.
- Result: Pack Harrier left battle, Leopard Hunter survives, Hunter’s Root-Stone at 5/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 5 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed, Hunter’s Root-Stone at 5/10

Main 2:
- Main 2: played Blood-Scent Hyena

End:
- retained card: Hyena Pack Call
- discarded cards: Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Fang Relic

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 2

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Leopard Hunter [Relic:Spear of First Dawn], Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Bone-Fang Shrine and broke it)
- Main 1: played Young Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Baobab Guardian
- discarded cards: Hunter’s Call, Young Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
- board at end: Kuma Who Wounded the Sun [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Fang Relic
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Hunter’s Root-Stone
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 7 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Kuma Who Wounded the Sun.
- Result: Blood-Scent Hyena left battle, Kuma Who Wounded the Sun survives, Hunter’s Root-Stone at 5/10

Main 2:
- Main 2: played Bone-Cracker Cub

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Fang Relic, Hyena Token, Pack Harrier

# End of Phase 3 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/0 | Iron 3/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 3
Key events: Main 1: played Young Hunter | Kuma Who Wounded the Sun deals 7 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Kuma Who Wounded the Sun. | Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine) | Main 1: played Pack Harrier | Main 2: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Fang Relic, Hyena Token, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Hunter’s Root-Stone
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 7 to 5. | Kuma Who Wounded the Sun becomes Wounded. | Pack Harrier deals 1 to blocked Shrine.
- Damage: Kuma Who Wounded the Sun deals 5 to Pack Harrier. | Pack Harrier deals 1 to Kuma Who Wounded the Sun. | Shrine Hunter’s Root-Stone takes 1.
- Result: Pack Harrier left battle, Kuma Who Wounded the Sun survives, Hunter’s Root-Stone at 3/10

Attack 2:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 7 to 5. | Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 5 to Hyena Token. | Hyena Token deals 1 to Kuma Who Wounded the Sun.
- Result: Hyena Token left battle, Kuma Who Wounded the Sun survives, Hunter’s Root-Stone at 3/10

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 7 to 5. | Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 5 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Kuma Who Wounded the Sun.
- Result: Bone-Cracker Cub left battle, Kuma Who Wounded the Sun survives, Hunter’s Root-Stone at 3/10

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Bone-Cracker Cub
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub, Fang Relic, Hyena Token

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: Kuma Who Wounded the Sun [Wounded, Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 10 to 7.
- Damage: Shrine Iron Hyena Den takes 7.
- Result: Kuma Who Wounded the Sun survives, Iron Hyena Den at 3/10

Attack 2:
- Attacker: Young Hunter
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Blood-Scent Hyena deals 2 to Young Hunter. | Young Hunter deals 2 to Blood-Scent Hyena.
- Result: Young Hunter left battle, Blood-Scent Hyena removed

Main 2:
- Main 2: played Baobab Guardian
- Main 2: prepared Hunter’s Call

End:
- retained card: Hunter’s Call
- discarded cards: None
- forgotten cards: None
- Wounded clears: Kuma Who Wounded the Sun
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Kuma Who Wounded the Sun [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Young Hunter

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Fang Relic, Hyena Token
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Kuma Who Wounded the Sun
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 8 to Hyena Token. | Hyena Token deals 1 to Kuma Who Wounded the Sun.
- Result: Hyena Token left battle, Kuma Who Wounded the Sun survives

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Kuma Who Wounded the Sun
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 8 to 6. | Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 6 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Kuma Who Wounded the Sun.
- Result: Bone-Cracker Cub left battle, Kuma Who Wounded the Sun survives

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Pack Harrier, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub, Fang Relic

## Turn 16 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Hunter’s Call]

Board before ready:
Beings/Spirits: Baobab Guardian, Kuma Who Wounded the Sun [Wounded, Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: Hunter’s Call
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Ritual of Red Moon (dealt 2 to Blood-Scent Hyena, destroyed it, gained 1 Memory)
- Main 1: resolved Ritual of Red Moon (dealt 2 to Bone-Cracker Cub, destroyed it, gained 1 Memory)

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 10 to 7.
- Damage: Shrine Iron Hyena Den takes 7.
- Result: Kuma Who Wounded the Sun survives, Iron Hyena Den at 0/10

Main 2:
- Main 2: prepared Hunter’s Call

End:
- retained card: Deep River Spirit
- discarded cards: Deep River Spirit
- forgotten cards: None
- Wounded clears: Kuma Who Wounded the Sun
- resources at end: 3 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Kuma Who Wounded the Sun [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Young Hunter

# End of Phase 4 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 7/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/3 | Iron 5/0
Awakened Ancestors: Red None | Iron Ancestor of the First Pack
Forgotten cards: Red 3 | Iron 4
Key events: Main 1: played Bone-Cracker Cub | Main 1: played Blood-Scent Hyena | Shrine Iron Hyena Den takes 7. | Main 1: resolved Ritual of Red Moon (dealt 2 to Blood-Scent Hyena, destroyed it, gained 1 Memory) | Main 1: resolved Ritual of Red Moon (dealt 2 to Bone-Cracker Cub, destroyed it, gained 1 Memory) | Main 2: prepared Hunter’s Call
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 3

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian, Kuma Who Wounded the Sun [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: Hunter’s Call
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: prepared Root-Woven Guard
- Main 1: prepared Root-Woven Guard (replaced Root-Woven Guard)

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 10.
- Result: Kuma Who Wounded the Sun survives, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Deep River Spirit, Young Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Kuma Who Wounded the Sun [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Young Hunter

## End-of-game summary

Winner: red-hunter-evolution
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Shrine of the Red Baobab 1/10, Hunter’s Root-Stone 7/10, Moonlit Roots 0/10] | Iron [Iron Hyena Den 14/10, Bone-Fang Shrine 11/10, Rusted Moon Shrine 10/10]
Final resources: Red 6/1 | Iron 5/0
Final Presence: Seat 1 5/5 | Seat 2 0/5

Turn count: 17
Phase count: 5

First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 9)
First Shrine broken: 11 (Seat 1/Red: , Seat 2/Iron: 11)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 25, Iron 10
First Ancestor awakened: 13
First L2: 8
First L3: 11

Red L2 entries: 2 (hard-cast 1, evolved 1)
Red L3 entries: 1 (hard-cast 0, evolved 1)
Iron L2 entries: 0 (hard-cast 0, evolved 0)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 4, Iron 0
Legal L2 evolve actions: Red 2, Iron 0
Legal L3 evolve actions: Red 2, Iron 0
Evolve windows: Red 4, Iron 0
Turns with legal L2 evolution: Red 2, Iron 0
Turns with legal L3 evolution: Red 2, Iron 0
Evolve actions chosen: Red 4, Iron 0
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 0, Iron 1

Legal awaken actions generated: Red 0, Iron 1
Awaken actions chosen: Red 0, Iron 1
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red None, Iron iron.ancestor.firstpack
Ancestor switches: Red 0, Iron 0
Turns with awakened ancestor: Red 0, Iron 1
Memory spent on ancestors: Red 0, Iron 2
Ancestor realized value: First Hunter +0 damage, Grandmother healed 0, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 2, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 5, Iron 4
Wounded events: Red 8, Iron 0
Wounded reduced damage: Red 7, Iron 0
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 6, Iron 0
Blocks chosen: Red 6, Iron 0
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 6, pack 0 | Seat 2 standard 2, pack 6
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 18, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 6, generated 6, available 6, skipped 0, turns-with-bonus 4, max-attacks 22, prevented-by-limit 0
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
