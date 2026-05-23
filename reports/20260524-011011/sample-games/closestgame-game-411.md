# Test Game #411

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red iron --bot-iron red --deck-red iron-hyena-pack-pressure --deck-iron red-hunter-evolution

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

Seed: 411
Winner: red-hunter-evolution
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting Shrines — Iron: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting hands — Red: Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Pack Ambush
- Starting hands — Iron: Baobab Guardian, Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Spear of First Dawn
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang
- Starting Lineage — Iron: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Pack Ambush]

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
- retained card: Bone Spear
- discarded cards: Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Baobab Guardian, Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Spear of First Dawn]

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
- retained card: Ritual of Red Moon
- discarded cards: Spear of First Dawn, Hunter’s Call, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: 

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: attached Bone Spear to Hyena Token

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 3.
- Result: Hyena Token survives, Hunter’s Root-Stone at 6/10

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Iron Hyena Raider, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Hyena Token, Hyena Token [Relic:Bone Spear]

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: 
Prepared Tactic: Hunter’s Call
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Ritual of Red Moon (dealt 2 to Hyena Token, destroyed it, gained 1 Memory)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Ritual of Red Moon
- discarded cards: Offering of Milk and Ash, Leopard Hunter, Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
- board at end: 

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10]
Resources: Red 0/0 | Iron 0/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 2 | Iron 1
Key events: Main 1: resolved Pack Ambush (summoned Hyena Token) | Main 1: prepared Hunter’s Call | Shrine Hunter’s Root-Stone takes 3. | Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine) | Main 1: attached Bone Spear to Hyena Token | Main 1: resolved Ritual of Red Moon (dealt 2 to Hyena Token, destroyed it, gained 1 Memory)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: 
Prepared Tactic: Hunter’s Call
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: resolved Ritual of Red Moon (dealt 2 to Hyena Token, destroyed it, gained 1 Memory)

Combat:
- no attacks

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Pale River Spirit
- discarded cards: Deep River Spirit, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Pack Ambush, Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: played Pack Harrier

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Iron Hyena Champion, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Pack Harrier

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: Hunter’s Call
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Pack Harrier
- Defender/blocker: Pack Harrier
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: None
- Damage: Pack Harrier deals 1 to Young Hunter. | Young Hunter deals 2 to Pack Harrier.
- Result: Young Hunter left battle, Pack Harrier removed

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Pale River Spirit, Spear of First Dawn
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
- board at end: River Hunter, Young Hunter

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Blood-Scent Hyena

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena

# End of Phase 2 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10]
Resources: Red 0/0 | Iron 1/1
Awakened Ancestors: Red None | Iron Grandmother Beneath the Roots
Forgotten cards: Red 3 | Iron 3
Key events: Pack Harrier deals 1 to Young Hunter. | Young Hunter deals 2 to Pack Harrier. | Main 1: played River Hunter | Main 1: played Young Hunter | Main 1: played Blood-Scent Hyena | Main 1: played Blood-Scent Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Blood-Scent Hyena
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 3.
- Result: Blood-Scent Hyena survives, Hunter’s Root-Stone at 0/10

Main 2:
- pass

End:
- retained card: Pack Harrier
- discarded cards: Bone-Cracker Cub, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena, Blood-Scent Hyena

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
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
- Main 2: awakened First Hunter

End:
- retained card: Leopard Hunter
- discarded cards: Esprit du Léopard, Pale River Spirit, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: River Hunter, Young Hunter

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Blood-Scent Hyena
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Shrine of the Red Baobab
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Young Hunter deals 2 to Blood-Scent Hyena. | Blood-Scent Hyena deals 4 to Young Hunter.
- Result: Blood-Scent Hyena left battle, Young Hunter removed, Shrine of the Red Baobab at 9/10

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 3.
- Result: Blood-Scent Hyena survives, Shrine of the Red Baobab at 6/10

Main 2:
- Main 2: played Pack Harrier
- Main 2: played Iron Hyena Raider

End:
- retained card: Fang Relic
- discarded cards: Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Iron Hyena Raider, Pack Harrier

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
Forgotten zone count/list: 3 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
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
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Esprit du Léopard, Baobab Guardian, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
- board at end: River Hunter

# End of Phase 3 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10]
Resources: Red 2/0 | Iron 4/3
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 3
Key events: Main 1: attached Bone Spear to Blood-Scent Hyena | Main 2: played Pack Harrier | Main 2: played Iron Hyena Raider | Iron Hyena Raider deals 3 to River Hunter. | River Hunter deals 3 to Iron Hyena Raider. | Main 1: played River Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 3

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
Forgotten zone count/list: 3 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Leopard Hunter

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
- Main 2: resolved Offering of Milk and Ash (restored 3 to Shrine of the Red Baobab)

End:
- retained card: Baobab Guardian
- discarded cards: Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
- board at end: Leopard Hunter, Young Hunter

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Pack Harrier
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | Pack Harrier deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 4 to Pack Harrier. | Pack Harrier deals 3 to Leopard Hunter. | Shrine Moonlit Roots takes 1.
- Result: Pack Harrier left battle, Leopard Hunter survives, Moonlit Roots at 7/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Blood-Scent Hyena
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Pack Harrier

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 5

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: Leopard Hunter [Wounded], Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 3/10
Forgotten zone count/list: 4 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 5 to 3.
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 7/10

Attack 2:
- Attacker: Young Hunter
- Target: Pack Harrier
- Defender/blocker: Pack Harrier
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Pack Harrier deals 1 to Young Hunter. | Young Hunter deals 2 to Pack Harrier.
- Result: Young Hunter left battle, Pack Harrier removed

Main 2:
- Main 2: played Baobab Guardian
- Main 2: resolved Offering of Milk and Ash (restored 3 to Moonlit Roots)

End:
- retained card: Esprit du Léopard
- discarded cards: None
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 0 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Leopard Hunter, River Hunter, River Hunter

## Turn 16 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Black-Tooth Smith
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Black-Tooth Smith
- Main 1: attached Fang Relic to Black-Tooth Smith

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 3 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives

Main 2:
- Main 2: played Blood-Scent Hyena
- Main 2: played Iron Hyena Raider

End:
- retained card: Iron Hyena Raider
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Iron Hyena Raider

# End of Phase 4 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10]
Resources: Red 1/0 | Iron 0/5
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 5
Key events: Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 3 to Leopard Hunter. | Main 1: attached Bone Spear to Black-Tooth Smith | Main 1: attached Fang Relic to Black-Tooth Smith | Main 2: played Blood-Scent Hyena | Main 2: played Iron Hyena Raider
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Raider]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Leopard Hunter.
- Result: Blood-Scent Hyena left battle, Leopard Hunter survives

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Leopard Hunter.
- Result: Iron Hyena Raider left battle, Leopard Hunter removed

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Hyena Raider, Pack Harrier

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 5

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian, River Hunter, River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 5 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

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
- Main 2: attached Esprit du Léopard to River Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Baobab Guardian, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 6 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Esprit du Léopard, River Hunter [Possession:Esprit du Léopard]

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone Spear, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 2 to Pack Harrier. | Pack Harrier deals 1 to Baobab Guardian.
- Result: Pack Harrier left battle, Baobab Guardian survives

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Pack Harrier
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 6

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian [Wounded], Esprit du Léopard, River Hunter [Possession:Esprit du Léopard]
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 5 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1. | Baobab Guardian becomes Wounded.
- Damage: Bone-Cracker Cub deals 2 to Baobab Guardian. | Baobab Guardian deals 1 to Bone-Cracker Cub.
- Result: Baobab Guardian survives, Bone-Cracker Cub removed

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Pale River Spirit, Deep River Spirit, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 6 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Wounded], Esprit du Léopard, Leopard Hunter [Possession:Esprit du Léopard]

# End of Phase 5 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10]
Resources: Red 2/0 | Iron 5/6
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 5
Key events: Main 1: played Bone-Cracker Cub | Main 1: played Blood-Scent Hyena | Main 2: played Black-Tooth Smith | Bone-Cracker Cub deals 2 to Baobab Guardian. | Baobab Guardian deals 1 to Bone-Cracker Cub. | Main 1: evolved River Hunter into Leopard Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 6

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian [Wounded], Esprit du Léopard, Leopard Hunter [Possession:Esprit du Léopard]
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 5 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Spear of First Dawn to Baobab Guardian

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 7.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 0/10

Main 2:
- Main 2: attached Esprit du Léopard to Baobab Guardian
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Deep River Spirit
- discarded cards: Root-Woven Guard
- forgotten cards: None
- Wounded clears: Baobab Guardian
- resources at end: 3 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Esprit du Léopard, Leopard Hunter [Possession:Esprit du Léopard], Spear of First Dawn, Young Hunter

## Turn 22 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Blood-Scent Hyena, Bone Spear
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 6 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 6 to 4.
- Damage: Leopard Hunter deals 4 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Leopard Hunter.
- Result: Blood-Scent Hyena left battle, Leopard Hunter removed

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Blood-Scent Hyena, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Pack Harrier

## Turn 23 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 5

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 1/10
Forgotten zone count/list: 5 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: resolved Ritual of Red Moon (dealt 2 to Bone-Cracker Cub, destroyed it, gained 1 Memory)

Combat:
- no attacks

Main 2:
- Main 2: played Deep River Spirit

End:
- retained card: Pale River Spirit
- discarded cards: Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Deep River Spirit, Esprit du Léopard, Spear of First Dawn, Young Hunter, Young Hunter

## Turn 24 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone Spear, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Pack Harrier
- Main 1: played Iron Hyena Raider

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
- pass

End:
- retained card: Hyena Token
- discarded cards: Iron Hyena Champion, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Hyena Raider

# End of Phase 6 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10]
Resources: Red 4/0 | Iron 1/5
Awakened Ancestors: Red None | Iron Grandmother Beneath the Roots
Forgotten cards: Red 4 | Iron 6
Key events: Main 1: resolved Ritual of Red Moon (dealt 2 to Bone-Cracker Cub, destroyed it, gained 1 Memory) | Main 2: played Deep River Spirit | Deep River Spirit deals 3 to Pack Harrier. | Pack Harrier deals 2 to Deep River Spirit. | Main 1: attached Fang Relic to Pack Harrier | Main 1: played Iron Hyena Raider
Tempo note: initiative reverses after every four player-turns.

## Turn 25 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 0

Hand before draw: [Hyena Token]

Board before ready:
Beings/Spirits: Bone Spear, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Raider
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2. | Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 2 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Deep River Spirit.
- Result: Iron Hyena Raider left battle, Deep River Spirit survives

Main 2:
- Main 2: played Blood-Scent Hyena

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub

## Turn 26 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 5

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Deep River Spirit [Wounded], Esprit du Léopard, Spear of First Dawn, Young Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 6 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter

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
- Main 2: played Pale River Spirit
- Main 2: awakened First Hunter

End:
- retained card: Deep River Spirit
- discarded cards: Root-Woven Guard, Hunter’s Call
- forgotten cards: None
- Wounded clears: Deep River Spirit
- resources at end: 4 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Deep River Spirit, Esprit du Léopard, Pale River Spirit, River Hunter [Possession:Esprit du Léopard], Spear of First Dawn, Young Hunter

## Turn 27 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Deep River Spirit.
- Result: Bone-Cracker Cub left battle, Deep River Spirit survives

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Hyena Pack Call, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub

## Turn 28 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 4

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Deep River Spirit [Wounded], Esprit du Léopard, Pale River Spirit, River Hunter [Possession:Esprit du Léopard], Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 6 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to Baobab Guardian

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
- retained card: Deep River Spirit
- discarded cards: River Hunter, Baobab Guardian, River Hunter
- forgotten cards: None
- Wounded clears: Deep River Spirit
- resources at end: 6 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Deep River Spirit, Esprit du Léopard, Pale River Spirit, River Hunter [Possession:Esprit du Léopard], Spear of First Dawn, Spear of First Dawn

# End of Phase 7 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10]
Resources: Red 5/0 | Iron 6/5
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 6
Key events: Bone-Cracker Cub deals 2 to Deep River Spirit. | Main 1: played Bone-Cracker Cub | Main 1: played Blood-Scent Hyena | Blood-Scent Hyena deals 2 to Young Hunter. | Young Hunter deals 2 to Blood-Scent Hyena. | Main 1: attached Spear of First Dawn to Baobab Guardian
Tempo note: initiative reverses after every four player-turns.

## Turn 29 — Iron

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 5

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Deep River Spirit, Esprit du Léopard, Pale River Spirit, River Hunter [Possession:Esprit du Léopard], Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 6 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Bone-Cracker Cub deals 2 to Baobab Guardian. | Baobab Guardian deals 5 to Bone-Cracker Cub.
- Result: Baobab Guardian survives, Bone-Cracker Cub removed

Main 2:
- pass

End:
- retained card: Pale River Spirit
- discarded cards: Deep River Spirit, Root-Woven Guard
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 4 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Deep River Spirit, Esprit du Léopard, Leopard Hunter [Possession:Esprit du Léopard], Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter

## Turn 30 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone Spear
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Pack Harrier

Combat:
- no attacks

Main 2:
- Main 2: played Iron Hyena Champion

End:
- retained card: Bone Spear
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Hyena Champion, Iron Hyena Raider, Pack Harrier

## Turn 31 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 5

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Deep River Spirit, Esprit du Léopard, Leopard Hunter [Possession:Esprit du Léopard], Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 6 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter
- Main 1: attached Esprit du Léopard to Baobab Guardian

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 7.
- Result: Leopard Hunter survives, Iron Hyena Den at 3/10

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Pale River Spirit
- discarded cards: River Hunter, River Hunter
- forgotten cards: None
- Wounded clears: Baobab Guardian, Leopard Hunter
- resources at end: 3 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Deep River Spirit, Esprit du Léopard, Leopard Hunter, Leopard Hunter [Possession:Esprit du Léopard], Pale River Spirit, Spear of First Dawn, Spear of First Dawn

## Turn 32 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone Spear, Iron Hyena Champion, Iron Hyena Raider, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Deep River Spirit.
- Result: Iron Hyena Raider left battle, Deep River Spirit survives

Attack 2:
- Attacker: Pack Harrier
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2. | Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 2 to Pack Harrier. | Pack Harrier deals 1 to Deep River Spirit.
- Result: Pack Harrier left battle, Deep River Spirit survives

Attack 3:
- Attacker: Iron Hyena Champion
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2. | Iron Hyena Champion becomes Wounded.
- Damage: Deep River Spirit deals 2 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Deep River Spirit.
- Result: Iron Hyena Champion survives, Deep River Spirit removed

Main 2:
- Main 2: played Iron Hyena Champion

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Token, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Iron Hyena Champion, Iron Hyena Champion [Wounded, Relic:Bone Spear]

# End of Phase 8 Summary

Shrine state: Red [Iron Hyena Den: 7/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10]
Resources: Red 2/0 | Iron 3/3
Awakened Ancestors: Red None | Iron Grandmother Beneath the Roots
Forgotten cards: Red 4 | Iron 6
Key events: Deep River Spirit deals 2 to Pack Harrier. | Pack Harrier deals 1 to Deep River Spirit. | Deep River Spirit deals 2 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Deep River Spirit. | Main 1: attached Bone Spear to Iron Hyena Champion | Main 2: played Iron Hyena Champion
Tempo note: initiative reverses after every four player-turns.

## Turn 33 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone Spear, Bone Spear, Iron Hyena Champion, Iron Hyena Champion [Wounded, Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 6 to 4.
- Damage: Leopard Hunter deals 6 to Iron Hyena Champion. | Iron Hyena Champion deals 4 to Leopard Hunter.
- Result: Iron Hyena Champion left battle, Leopard Hunter removed

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Blood-Scent Hyena
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena, Bone Spear, Iron Hyena Champion, Pack Harrier

## Turn 34 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 6

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Leopard Hunter, Pale River Spirit, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
Forgotten zone count/list: 6 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Pale River Spirit
- Main 1: prepared Hunter’s Call

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to Leopard Hunter. | Leopard Hunter deals 4 to Iron Hyena Champion.
- Result: Leopard Hunter left battle, Iron Hyena Champion removed, Iron Hyena Den at 3/10

Attack 2:
- Attacker: Baobab Guardian
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 5.
- Result: Baobab Guardian survives, Iron Hyena Den at 0/10

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Root-Woven Guard, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 2/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Pale River Spirit, Pale River Spirit, Spear of First Dawn, Spear of First Dawn

## Turn 35 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Blood-Scent Hyena, Bone Spear, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 5 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Baobab Guardian.
- Result: Black-Tooth Smith left battle, Baobab Guardian survives

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 5 to 3.
- Damage: Baobab Guardian deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Baobab Guardian.
- Result: Blood-Scent Hyena left battle, Baobab Guardian removed

Main 2:
- Main 2: played Blood-Scent Hyena
- Main 2: played Iron Hyena Raider

End:
- retained card: Pack Harrier
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Iron Hyena Raider, Pack Harrier

## Turn 36 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 6

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Pale River Spirit, Pale River Spirit, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 3/10
Forgotten zone count/list: 7 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

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
- Main 2: played Deep River Spirit

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 4/10
- board at end: Deep River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter

# End of Phase 9 Summary

Shrine state: Red [Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 4/10]
Resources: Red 2/0 | Iron 1/7
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 7
Key events: Main 2: played Iron Hyena Raider | Iron Hyena Raider deals 3 to Pale River Spirit. | Pale River Spirit deals 2 to Iron Hyena Raider. | Main 1: played Young Hunter | Main 1: played River Hunter | Main 2: played Deep River Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 37 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 7

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Deep River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 4/10
Forgotten zone count/list: 7 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 4.
- Result: River Hunter survives, Rusted Moon Shrine at 6/10

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Young Hunter, River Hunter, Young Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 3/10
- board at end: Deep River Spirit, Leopard Hunter, Pale River Spirit, River Hunter, Spear of First Dawn

## Turn 38 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 4/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | Pack Harrier deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 4 to Pack Harrier. | Pack Harrier deals 1 to Leopard Hunter. | Shrine Moonlit Roots takes 1.
- Result: Pack Harrier left battle, Leopard Hunter survives, Moonlit Roots at 6/10

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Leopard Hunter.
- Result: Blood-Scent Hyena left battle, Leopard Hunter removed, Moonlit Roots at 6/10

Main 2:
- Main 2: played Pack Harrier
- Main 2: played Iron Hyena Raider

End:
- retained card: Pack Harrier
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 4/10
- board at end: Bone Spear, Iron Hyena Raider, Pack Harrier

## Turn 39 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 6

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Deep River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 4/10
Forgotten zone count/list: 7 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to Pale River Spirit

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 3.
- Result: River Hunter survives, Rusted Moon Shrine at 3/10

Attack 2:
- Attacker: Pale River Spirit
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Pale River Spirit. | Pale River Spirit deals 3 to Iron Hyena Raider.
- Result: Pale River Spirit left battle, Iron Hyena Raider removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Kuma Who Wounded the Sun, Baobab Guardian, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 6 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 5/10
- board at end: Deep River Spirit, River Hunter, Spear of First Dawn

## Turn 40 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Bone Spear, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 7/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 1.
- Result: Pack Harrier survives, Moonlit Roots at 4/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Iron Hyena Champion
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 7/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena, Bone Spear, Pack Harrier, Pack Harrier

# End of Phase 10 Summary

Shrine state: Red [Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 7/10] | Iron [Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 5/10]
Resources: Red 2/0 | Iron 6/6
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 7
Key events: Main 1: attached Spear of First Dawn to Pale River Spirit | Main 2: awakened First Hunter | Shrine Moonlit Roots takes 1. | Main 1: played Pack Harrier | Main 1: played Blood-Scent Hyena | Main 2: played Black-Tooth Smith
Tempo note: initiative reverses after every four player-turns.

## Turn 41 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Blood-Scent Hyena, Bone Spear, Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 7/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Moonlit Roots)

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 2.
- Result: Black-Tooth Smith survives, Moonlit Roots at 0/10

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Hyena Pack Call, Pack Harrier, Hyena Pack Call
- forgotten cards: None
- Wounded clears: Iron Hyena Champion
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 7/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena, Bone Spear, Iron Hyena Champion, Pack Harrier

## Turn 42 — Iron

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 6

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Deep River Spirit, River Hunter, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 7 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter
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
- retained card: Esprit du Léopard
- discarded cards: Pale River Spirit, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Leopard Hunter, River Hunter [Possession:Esprit du Léopard], Spear of First Dawn

## Turn 43 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Blood-Scent Hyena, Bone Spear, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 7/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives, Shrine of the Red Baobab at 9/10

Attack 2:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded. | Pack Harrier deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 3 to Pack Harrier. | Pack Harrier deals 1 to Leopard Hunter. | Shrine Shrine of the Red Baobab takes 1.
- Result: Pack Harrier left battle, Leopard Hunter survives, Shrine of the Red Baobab at 8/10

Attack 3:
- Attacker: Blood-Scent Hyena
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Leopard Hunter.
- Result: Blood-Scent Hyena left battle, Leopard Hunter removed, Shrine of the Red Baobab at 6/10

Main 2:
- Main 2: played Iron Hyena Raider
- Main 2: played Iron Hyena Raider

End:
- retained card: Blood-Scent Hyena
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 7/10
- board at end: Bone Spear, Iron Hyena Raider, Iron Hyena Raider

## Turn 44 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 8

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: River Hunter [Possession:Esprit du Léopard], Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
Forgotten zone count/list: 7 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Esprit du Léopard to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 6.
- Result: River Hunter survives, Rusted Moon Shrine at 0/10

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Esprit du Léopard
- discarded cards: Root-Woven Guard, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 6 Memory
- shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10
- board at end: Esprit du Léopard, River Hunter, River Hunter [Possession:Esprit du Léopard], Spear of First Dawn

# End of Phase 11 Summary

Shrine state: Red [Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 7/10] | Iron [Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 10/10]
Resources: Red 2/0 | Iron 4/6
Awakened Ancestors: Red None | Iron Grandmother Beneath the Roots
Forgotten cards: Red 4 | Iron 7
Key events: Main 2: played Iron Hyena Raider | Main 2: played Iron Hyena Raider | Shrine Rusted Moon Shrine takes 6. | Main 1: played River Hunter | Main 1: attached Esprit du Léopard to River Hunter | Main 2: awakened Grandmother Beneath the Roots
Tempo note: initiative reverses after every four player-turns.

## End-of-game summary

Winner: red-hunter-evolution
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Iron Hyena Den 12/10, Bone-Fang Shrine 10/10, Rusted Moon Shrine 13/10] | Iron [Shrine of the Red Baobab 4/10, Hunter’s Root-Stone 11/10, Moonlit Roots 10/10]
Final resources: Red 2/0 | Iron 4/6
Final Presence: Seat 1 2/5 | Seat 2 2/5

Turn count: 44
Phase count: 11

First Shrine damage: 3 (Seat 1/Red: 15, Seat 2/Iron: 3)
First Shrine broken: 9 (Seat 1/Red: 21, Seat 2/Iron: 9)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 16, Iron 17
First Ancestor awakened: 5
First L2: 13
First L3: 

Red L2 entries: 3 (hard-cast 2, evolved 1)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 6 (hard-cast 1, evolved 5)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 6, Iron 12
Legal L2 evolve actions: Red 6, Iron 12
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 2, Iron 10
Turns with legal L2 evolution: Red 2, Iron 10
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 4, Iron 12
Hard-cast chosen while legal evolve action existed: Red 0, Iron 1
Hard-cast chosen while evolution base existed: Red 2, Iron 8

Legal awaken actions generated: Red 0, Iron 45
Awaken actions chosen: Red 0, Iron 18
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red None, Iron red.ancestor.grandmother
Ancestor switches: Red 0, Iron 8
Turns with awakened ancestor: Red 0, Iron 19
Memory spent on ancestors: Red 0, Iron 18
Ancestor realized value: First Hunter +5 damage, Grandmother healed 7, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 2
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 4, Iron 7
Wounded events: Red 1, Iron 16
Wounded reduced damage: Red 1, Iron 12
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 2, Iron 7
Blocks chosen: Red 1, Iron 7
Blocks declined: Red 1, Iron 0
Assault slots spent: Seat 1 standard 6, pack 21 | Seat 2 standard 21, pack 0
Pack diagnostics: Seat 1 ready-at-combat 27, generated 27, available 27, skipped 6, turns-with-bonus 16, max-attacks 71, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 44, prevented-by-limit 0
Deck reshuffles: Red 3, Iron 5

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
