# Test Game #125

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 100 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red passive --bot-iron iron --deck-red passive --deck-iron iron-hyena-pack-pressure

Seat 1:
- passive [Red] (PassiveBot)
Seat 2:
- iron-hyena-pack-pressure [Iron] (IronHyenaBot)

Rules variant:
- Draw model: retain up to 1, discard rest, draw to 5
- Phase model: reverse every 4 player-turns
- Combat model: 2 standard Assault slots, plus Pack expansion up to 5 total attacks, separate resolution
- Battlefield capacity: 5 Presence per seat
- Prepared model: max 1 active tactic per player
- Special mechanics: Fade, Forgotten, Wounded, Pierce, Disperse, Possession, Evolution, Recall, Unique, Pack

Seed: 125
Winner: iron-hyena-pack-pressure
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Deep River Spirit, Deep River Spirit, Esprit du Léopard, Spear of First Dawn, Young Hunter
- Starting hands — Iron: Bite the Roots, Black-Tooth Smith, Blood-Scent Hyena, Bone-Cracker Cub, Hyena Pack Call
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Deep River Spirit, Deep River Spirit, Esprit du Léopard, Spear of First Dawn, Young Hunter]

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
- discarded cards: Deep River Spirit, Deep River Spirit, Spear of First Dawn
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Black-Tooth Smith, Blood-Scent Hyena, Bone-Cracker Cub, Hyena Pack Call]

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
- retained card: Bite the Roots
- discarded cards: Black-Tooth Smith, Hyena Pack Call, Blood-Scent Hyena
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
- Main 1: resolved Ritual of Red Moon (dealt 2 to Bone-Cracker Cub, destroyed it, gained 1 Memory)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Esprit du Léopard, Root-Woven Guard, Hunter’s Call
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
- retained card: Bite the Roots
- discarded cards: Bone-Cracker Cub, Iron Hyena Raider, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/1 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 1
Key events: Main 1: played Young Hunter | Main 1: played Bone-Cracker Cub | Main 1: resolved Ritual of Red Moon (dealt 2 to Bone-Cracker Cub, destroyed it, gained 1 Memory) | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
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
- Main 1: resolved Pack Ambush (summoned Hyena Token)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Champion, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Ritual of Red Moon, Root-Woven Guard, Young Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
- board at end: River Hunter, Young Hunter

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Hyena Token
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 3.
- Result: Hyena Token survives, Hunter’s Root-Stone at 2/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Hyena Token [Relic:Bone Spear], Pack Harrier

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 8/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played Baobab Guardian

Combat:
- no attacks

Main 2:
- Main 2: resolved Offering of Milk and Ash (restored 3 to Hunter’s Root-Stone)

End:
- retained card: Leopard Hunter
- discarded cards: Pale River Spirit, Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, River Hunter, Young Hunter

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/1 | Iron 2/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 2 | Iron 3
Key events: Main 1: played River Hunter | Shrine Hunter’s Root-Stone takes 3. | Main 1: attached Bone Spear to Hyena Token | Main 1: played Pack Harrier | Main 1: played Baobab Guardian | Main 2: resolved Offering of Milk and Ash (restored 3 to Hunter’s Root-Stone)
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Baobab Guardian, River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Hunter’s Call, Baobab Guardian, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Leopard Hunter, River Hunter, Young Hunter

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone Spear, Hyena Token [Relic:Bone Spear], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Hyena Token

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Hyena Token. | Hyena Token deals 2 to Leopard Hunter.
- Result: Hyena Token left battle, Leopard Hunter survives

Attack 2:
- Attacker: Pack Harrier
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 3 to Pack Harrier. | Pack Harrier deals 1 to Leopard Hunter.
- Result: Pack Harrier left battle, Leopard Hunter survives

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Baobab Guardian, Leopard Hunter [Wounded], River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Spear of First Dawn
- discarded cards: Offering of Milk and Ash, Ritual of Red Moon, River Hunter
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Leopard Hunter, Leopard Hunter, River Hunter, Young Hunter

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token)
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives

Main 2:
- Main 2: played Bone-Cracker Cub

End:
- retained card: Pack Harrier
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub, Hyena Token

# End of Phase 3 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/1 | Iron 2/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 2 | Iron 4
Key events: Main 1: played Leopard Hunter | Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Leopard Hunter. | Main 1: resolved Pack Ambush (summoned Hyena Token) | Main 1: played Blood-Scent Hyena | Main 2: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub, Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 3 to Hyena Token. | Hyena Token deals 1 to Leopard Hunter.
- Result: Hyena Token left battle, Leopard Hunter survives

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Leopard Hunter.
- Result: Blood-Scent Hyena left battle, Leopard Hunter removed

Main 2:
- Main 2: played Pack Harrier
- Main 2: played Blood-Scent Hyena

End:
- retained card: Iron Hyena Champion
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub, Pack Harrier

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 2

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Baobab Guardian, Leopard Hunter, River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter

Combat:
- no attacks

Main 2:
- Main 2: attached Spear of First Dawn to Young Hunter
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Esprit du Léopard
- discarded cards: Young Hunter, Young Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Leopard Hunter, River Hunter, River Hunter, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn]

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Blood-Scent Hyena

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
- Attacker: Pack Harrier
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 3 to Pack Harrier. | Pack Harrier deals 1 to Leopard Hunter.
- Result: Pack Harrier left battle, Leopard Hunter survives

Attack 3:
- Attacker: Blood-Scent Hyena
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Leopard Hunter.
- Result: Blood-Scent Hyena left battle, Leopard Hunter removed

Main 2:
- Main 2: played Iron Hyena Champion
- Main 2: played Pack Harrier

End:
- retained card: Hyena Token
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Hyena Champion, Pack Harrier

## Turn 16 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian, River Hunter, River Hunter, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn]
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter

Combat:
- no attacks

Main 2:
- Main 2: attached Esprit du Léopard to Young Hunter

End:
- retained card: Spear of First Dawn
- discarded cards: Ritual of Red Moon, Pale River Spirit
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Esprit du Léopard, Leopard Hunter, River Hunter, River Hunter, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]

# End of Phase 4 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/0 | Iron 1/1
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron None
Forgotten cards: Red 2 | Iron 4
Key events: Blood-Scent Hyena deals 3 to Leopard Hunter. | Main 1: attached Bone Spear to Blood-Scent Hyena | Main 2: played Iron Hyena Champion | Main 2: played Pack Harrier | Main 1: played Leopard Hunter | Main 2: attached Esprit du Léopard to Young Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Baobab Guardian, Esprit du Léopard, Leopard Hunter, River Hunter, River Hunter, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to Young Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit, Baobab Guardian, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Esprit du Léopard, Leopard Hunter, River Hunter, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Hyena Token]

Board before ready:
Beings/Spirits: Bone Spear, Iron Hyena Champion, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Leopard Hunter deals 4 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Leopard Hunter.
- Result: Iron Hyena Champion left battle, Leopard Hunter removed

Main 2:
- Main 2: played Blood-Scent Hyena

End:
- retained card: Iron Hyena Champion
- discarded cards: Hyena Token, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Pack Harrier

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 1

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian, Esprit du Léopard, River Hunter, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter

Combat:
- no attacks

Main 2:
- Main 2: attached Esprit du Léopard to Young Hunter

End:
- retained card: Deep River Spirit
- discarded cards: Hunter’s Call, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Esprit du Léopard, River Hunter, River Hunter, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
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

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1. | Blood-Scent Hyena becomes Wounded. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 1 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Baobab Guardian.
- Result: Blood-Scent Hyena survives, Baobab Guardian survives

Main 2:
- Main 2: played Iron Hyena Champion

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena [Wounded], Bone Spear, Bone-Cracker Cub, Iron Hyena Champion

# End of Phase 5 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 4/1 | Iron 0/1
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron None
Forgotten cards: Red 2 | Iron 4
Key events: Pack Harrier deals 1 to Baobab Guardian. | Baobab Guardian deals 1 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Baobab Guardian. | Main 1: played Bone-Cracker Cub | Main 1: played Blood-Scent Hyena | Main 2: played Iron Hyena Champion
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Blood-Scent Hyena [Wounded], Bone Spear, Bone-Cracker Cub, Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Blood-Scent Hyena from 2 to 1. | Wounded reduces Baobab Guardian from 2 to 1. | Blood-Scent Hyena becomes Wounded. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 1 to Blood-Scent Hyena. | Blood-Scent Hyena deals 1 to Baobab Guardian.
- Result: Blood-Scent Hyena survives, Baobab Guardian survives

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 1 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Baobab Guardian.
- Result: Bone-Cracker Cub left battle, Baobab Guardian survives

Attack 3:
- Attacker: Blood-Scent Hyena
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1. | Blood-Scent Hyena becomes Wounded.
- Damage: Baobab Guardian deals 1 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Baobab Guardian.
- Result: Blood-Scent Hyena survives, Baobab Guardian removed

Main 2:
- Main 2: played Bone-Cracker Cub

End:
- retained card: Black-Tooth Smith
- discarded cards: Pack Harrier, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena [Wounded], Blood-Scent Hyena [Wounded], Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Iron Hyena Champion

## Turn 22 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 2

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Esprit du Léopard, River Hunter, River Hunter, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played Deep River Spirit

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Hunter’s Call, Root-Woven Guard, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Deep River Spirit, Esprit du Léopard, River Hunter, River Hunter, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]

## Turn 23 — Iron

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Blood-Scent Hyena [Wounded], Blood-Scent Hyena [Wounded], Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Blood-Scent Hyena from 2 to 1.
- Damage: Shrine Hunter’s Root-Stone takes 1.
- Result: Blood-Scent Hyena survives, Hunter’s Root-Stone at 9/10

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Blood-Scent Hyena from 3 to 2.
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Blood-Scent Hyena survives, Hunter’s Root-Stone at 7/10

Attack 3:
- Attacker: Iron Hyena Champion
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 6.
- Result: Iron Hyena Champion survives, Hunter’s Root-Stone at 1/10

Attack 4:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: River Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to River Hunter.
- Result: Bone-Cracker Cub left battle, River Hunter removed, Hunter’s Root-Stone at 1/10

Attack 5:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: River Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to River Hunter.
- Result: Bone-Cracker Cub left battle, River Hunter removed, Hunter’s Root-Stone at 1/10

Main 2:
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Raider, Hyena Token, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: Blood-Scent Hyena, Blood-Scent Hyena
- resources at end: 6 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear, Iron Hyena Champion

## Turn 24 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 2

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Deep River Spirit, Esprit du Léopard, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 9/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played Baobab Guardian

Combat:
- no attacks

Main 2:
- Main 2: resolved Ritual of Red Moon (dealt 2 to Iron Hyena Champion)

End:
- retained card: Ritual of Red Moon
- discarded cards: Kuma Who Wounded the Sun, Baobab Guardian
- forgotten cards: None
- Wounded clears: Baobab Guardian
- resources at end: 3 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Deep River Spirit, Esprit du Léopard, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]

# End of Phase 6 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/2 | Iron 6/0
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Ancestor of the First Pack
Forgotten cards: Red 3 | Iron 4
Key events: River Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to River Hunter. | Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens) | Main 2: awakened Ancestor of the First Pack | Main 1: played Baobab Guardian | Main 2: resolved Ritual of Red Moon (dealt 2 to Iron Hyena Champion)
Tempo note: initiative reverses after every four player-turns.

## Turn 25 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 2

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Baobab Guardian, Deep River Spirit, Esprit du Léopard, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: prepared Hunter’s Call

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Ritual of Red Moon, River Hunter, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 7 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Deep River Spirit, Esprit du Léopard, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]

## Turn 26 — Iron

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear, Iron Hyena Champion [Wounded]
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Deep River Spirit.
- Result: Blood-Scent Hyena left battle, Deep River Spirit survives

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2. | Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 2 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Deep River Spirit.
- Result: Blood-Scent Hyena left battle, Deep River Spirit survives

Attack 3:
- Attacker: Iron Hyena Champion
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 6 to 4. | Wounded reduces Deep River Spirit from 3 to 2. | Iron Hyena Champion becomes Wounded.
- Damage: Deep River Spirit deals 2 to Iron Hyena Champion. | Iron Hyena Champion deals 4 to Deep River Spirit.
- Result: Iron Hyena Champion survives, Deep River Spirit removed

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: played Iron Hyena Raider

End:
- retained card: Black-Tooth Smith
- discarded cards: Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Fang Relic, Iron Hyena Champion [Wounded, Relic:Fang Relic], Iron Hyena Raider

## Turn 27 — Red

Pre-resource snapshot:
Offerings before resource: 7
Memory before resource: 3

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Baobab Guardian, Esprit du Léopard, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]
Prepared Tactic: Hunter’s Call
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Young Hunter, Young Hunter, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Esprit du Léopard, Leopard Hunter, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]

## Turn 28 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Fang Relic, Iron Hyena Champion [Wounded, Relic:Fang Relic], Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 6 to 4. | Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Iron Hyena Champion. | Iron Hyena Champion deals 4 to Leopard Hunter.
- Result: Iron Hyena Champion left battle, Leopard Hunter removed

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: played Bone-Cracker Cub

End:
- retained card: Pack Harrier
- discarded cards: Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider

# End of Phase 7 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/3 | Iron 2/0
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Ancestor of the First Pack
Forgotten cards: Red 3 | Iron 4
Key events: Black-Tooth Smith deals 2 to Leopard Hunter. | Leopard Hunter deals 3 to Iron Hyena Champion. | Iron Hyena Champion deals 4 to Leopard Hunter. | Main 1: attached Fang Relic to Iron Hyena Champion | Main 2: played Black-Tooth Smith | Main 2: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 29 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Raider

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
- Attacker: Iron Hyena Raider
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1. | Iron Hyena Raider becomes Wounded.
- Damage: Baobab Guardian deals 1 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Baobab Guardian.
- Result: Iron Hyena Raider survives, Baobab Guardian removed

Main 2:
- Main 2: played Pack Harrier
- Main 2: played Iron Hyena Raider

End:
- retained card: Hyena Token
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Wounded], Bone Spear, Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider, Iron Hyena Raider [Wounded, Relic:Bone Spear], Pack Harrier

## Turn 30 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 4

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Esprit du Léopard, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]
Prepared Tactic: Hunter’s Call
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Pale River Spirit
- discarded cards: Hunter’s Call, Root-Woven Guard, Root-Woven Guard
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 3 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, Leopard Hunter, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]

## Turn 31 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 0

Hand before draw: [Hyena Token]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Wounded], Bone Spear, Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider, Iron Hyena Raider [Wounded, Relic:Bone Spear], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 3 to 2.
- Damage: Shrine Shrine of the Red Baobab takes 2.
- Result: Black-Tooth Smith survives, Shrine of the Red Baobab at 7/10

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Raider from 5 to 3.
- Damage: Shrine Shrine of the Red Baobab takes 3.
- Result: Iron Hyena Raider survives, Shrine of the Red Baobab at 4/10

Attack 3:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 2.
- Result: Pack Harrier survives, Shrine of the Red Baobab at 2/10

Attack 4:
- Attacker: Iron Hyena Raider
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Ancestor of the First Pack deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 4 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Leopard Hunter. | Shrine Shrine of the Red Baobab takes 1.
- Result: Iron Hyena Raider left battle, Leopard Hunter removed, Shrine of the Red Baobab at 1/10

Attack 5:
- Attacker: Bone-Cracker Cub
- Target: Shrine of the Red Baobab
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: River Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to River Hunter.
- Result: Bone-Cracker Cub left battle, River Hunter removed, Shrine of the Red Baobab at 1/10

Main 2:
- pass

End:
- retained card: Pack Harrier
- discarded cards: Hyena Token, Bone-Cracker Cub, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: Iron Hyena Raider, Black-Tooth Smith
- resources at end: 6 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone Spear, Fang Relic, Iron Hyena Raider [Relic:Bone Spear], Pack Harrier

## Turn 32 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 5

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Esprit du Léopard, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]
Prepared Tactic: Hunter’s Call
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 9/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter

Combat:
- no attacks

Main 2:
- Main 2: played Pale River Spirit

End:
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, Leopard Hunter, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]

# End of Phase 8 Summary

Shrine state: Red [Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/5 | Iron 6/1
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Ancestor of the First Pack
Forgotten cards: Red 3 | Iron 4
Key events: Shrine Shrine of the Red Baobab takes 1. | River Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to River Hunter. | Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens) | Main 1: played Leopard Hunter | Main 2: played Pale River Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 33 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 5

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Esprit du Léopard, Leopard Hunter, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]
Prepared Tactic: Hunter’s Call
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: prepared Root-Woven Guard

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: River Hunter, River Hunter, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 7 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 5/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, Leopard Hunter, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]

## Turn 34 — Iron

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 1

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Bone Spear, Fang Relic, Iron Hyena Raider [Relic:Bone Spear], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Iron Hyena Raider into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab)

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: Root-Woven Guard
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 3.
- Result: Black-Tooth Smith survives, Shrine of the Red Baobab at 0/10

Main 2:
- pass

End:
- retained card: Pack Harrier
- discarded cards: Hyena Token, Hyena Pack Call, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone Spear, Fang Relic, Iron Hyena Champion [Relic:Bone Spear], Pack Harrier

## Turn 35 — Red

Pre-resource snapshot:
Offerings before resource: 7
Memory before resource: 4

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Esprit du Léopard, Leopard Hunter, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]
Prepared Tactic: Hunter’s Call
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 10/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 4 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: played Baobab Guardian

Combat:
- no attacks

Main 2:
- Main 2: attached Esprit du Léopard to Young Hunter

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Hunter’s Call, Deep River Spirit
- forgotten cards: None
- Wounded clears: Baobab Guardian
- resources at end: 3 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 10/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Esprit du Léopard, Leopard Hunter, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]

## Turn 36 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 2

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Bone Spear, Fang Relic, Iron Hyena Champion [Relic:Bone Spear], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives

Attack 2:
- Attacker: Pack Harrier
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 3 to Pack Harrier. | Pack Harrier deals 1 to Leopard Hunter.
- Result: Pack Harrier left battle, Leopard Hunter survives

Attack 3:
- Attacker: Iron Hyena Champion
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Leopard Hunter.
- Result: Iron Hyena Champion left battle, Leopard Hunter removed

Main 2:
- pass

End:
- retained card: Pack Harrier
- discarded cards: Hyena Pack Call, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Fang Relic, Pack Harrier

# End of Phase 9 Summary

Shrine state: Red [Shrine of the Red Baobab: 10/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/4 | Iron 5/2
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Ancestor of the First Pack
Forgotten cards: Red 4 | Iron 4
Key events: Leopard Hunter deals 3 to Pack Harrier. | Pack Harrier deals 1 to Leopard Hunter. | Leopard Hunter deals 3 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Leopard Hunter. | Main 1: played Pack Harrier | Main 1: played Blood-Scent Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 37 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 2

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Fang Relic, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 2 to Pack Harrier. | Pack Harrier deals 1 to Baobab Guardian.
- Result: Pack Harrier left battle, Baobab Guardian survives

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1. | Blood-Scent Hyena becomes Wounded. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 1 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Baobab Guardian.
- Result: Blood-Scent Hyena survives, Baobab Guardian survives

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Token, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena [Wounded], Bone Spear, Fang Relic, Iron Hyena Raider [Relic:Bone Spear], Pack Harrier

## Turn 38 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 4

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Baobab Guardian [Wounded], Esprit du Léopard, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]
Prepared Tactic: Hunter’s Call
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 10/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 4 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Young Hunter, River Hunter, Baobab Guardian
- forgotten cards: None
- Wounded clears: Baobab Guardian
- resources at end: 7 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 10/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Esprit du Léopard, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]

## Turn 39 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 2

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Blood-Scent Hyena [Wounded], Bone Spear, Fang Relic, Iron Hyena Raider [Relic:Bone Spear], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Blood-Scent Hyena from 2 to 1. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 2 to Blood-Scent Hyena. | Blood-Scent Hyena deals 1 to Baobab Guardian.
- Result: Blood-Scent Hyena left battle, Baobab Guardian survives

Attack 2:
- Attacker: Pack Harrier
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 1 to Pack Harrier. | Pack Harrier deals 1 to Baobab Guardian.
- Result: Pack Harrier left battle, Baobab Guardian survives

Attack 3:
- Attacker: Iron Hyena Raider
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1. | Iron Hyena Raider becomes Wounded.
- Damage: Baobab Guardian deals 1 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Baobab Guardian.
- Result: Iron Hyena Raider survives, Baobab Guardian removed

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: played Black-Tooth Smith

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Hyena Raider [Wounded, Relic:Fang Relic]

## Turn 40 — Red

Pre-resource snapshot:
Offerings before resource: 7
Memory before resource: 4

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Esprit du Léopard, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]
Prepared Tactic: Hunter’s Call
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 10/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 4 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: played Leopard Hunter

Combat:
- no attacks

Main 2:
- Main 2: played Pale River Spirit

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Root-Woven Guard, River Hunter
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 1 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 10/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, Leopard Hunter, Pale River Spirit, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]

# End of Phase 10 Summary

Shrine state: Red [Shrine of the Red Baobab: 10/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/4 | Iron 2/2
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Ancestor of the First Pack
Forgotten cards: Red 4 | Iron 4
Key events: Iron Hyena Raider deals 4 to Baobab Guardian. | Main 1: attached Fang Relic to Iron Hyena Raider | Main 2: played Bone-Cracker Cub | Main 2: played Black-Tooth Smith | Main 1: played Leopard Hunter | Main 2: played Pale River Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 41 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 4

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Esprit du Léopard, Leopard Hunter, Pale River Spirit, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]
Prepared Tactic: Hunter’s Call
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 10/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 4 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: attached Esprit du Léopard to Young Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Ritual of Red Moon, Baobab Guardian, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 10/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, Leopard Hunter, Pale River Spirit, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]

## Turn 42 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 2

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Hyena Raider [Wounded, Relic:Fang Relic]
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Pack Harrier

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
- Attacker: Iron Hyena Raider
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Raider from 5 to 3.
- Damage: Shrine Hunter’s Root-Stone takes 3.
- Result: Iron Hyena Raider survives, Hunter’s Root-Stone at 5/10

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 4.
- Result: Bone-Cracker Cub survives, Hunter’s Root-Stone at 1/10

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Iron Hyena Raider, Hyena Pack Call
- forgotten cards: None
- Wounded clears: Iron Hyena Raider
- resources at end: 6 Offerings / 3 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Hyena Raider [Relic:Fang Relic], Pack Harrier

## Turn 43 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 4

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Esprit du Léopard, Leopard Hunter, Pale River Spirit, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]
Prepared Tactic: Hunter’s Call
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 10/10, Hunter’s Root-Stone: 9/10, Moonlit Roots: 1/10
Forgotten zone count/list: 4 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- pass

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Kuma Who Wounded the Sun, Deep River Spirit, Baobab Guardian, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 8 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 10/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 1/10
- board at end: Esprit du Léopard, Leopard Hunter, Pale River Spirit, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter, Young Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard]

## Turn 44 — Iron

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 3

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Hyena Raider [Relic:Fang Relic], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Iron Hyena Raider into Iron Hyena Champion (dealt 2 to Hunter’s Root-Stone)

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Hunter’s Root-Stone
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 3 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives, Hunter’s Root-Stone at 1/10

Attack 2:
- Attacker: Pack Harrier
- Target: Hunter’s Root-Stone
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Pack Harrier deals 1 to blocked Shrine. | Ancestor of the First Pack deals 1 to blocked Shrine.
- Damage: Young Hunter deals 5 to Pack Harrier. | Pack Harrier deals 2 to Young Hunter.
- Result: Pack Harrier left battle, Young Hunter removed, Hunter’s Root-Stone at 0/10

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Token, Blood-Scent Hyena, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: Iron Hyena Champion
- resources at end: 5 Offerings / 3 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Hyena Champion [Relic:Fang Relic]

# End of Phase 11 Summary

Shrine state: Red [Shrine of the Red Baobab: 10/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 1/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 8/4 | Iron 5/3
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Ancestor of the First Pack
Forgotten cards: Red 4 | Iron 4
Key events: Main 1: played Pack Harrier | Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 3 to Leopard Hunter. | Young Hunter deals 5 to Pack Harrier. | Pack Harrier deals 2 to Young Hunter. | Main 1: evolved Iron Hyena Raider into Iron Hyena Champion (dealt 2 to Hunter’s Root-Stone)
Tempo note: initiative reverses after every four player-turns.

## Turn 45 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 3

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Hyena Champion [Relic:Fang Relic]
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 7.
- Result: Iron Hyena Champion survives, Moonlit Roots at 1/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Ancestor of the First Pack deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to Leopard Hunter. | Shrine Moonlit Roots takes 1.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed, Moonlit Roots at 0/10

Main 2:
- pass

End:
- retained card: Pack Harrier
- discarded cards: Iron Hyena Raider, Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 4 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Hyena Champion [Relic:Fang Relic]

## End-of-game summary

Winner: iron-hyena-pack-pressure
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Shrine of the Red Baobab 10/10, Hunter’s Root-Stone 10/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 0/10, Bone-Fang Shrine 0/10, Rusted Moon Shrine 0/10]
Final resources: Red 8/5 | Iron 4/4
Final Presence: Seat 1 3/5 | Seat 2 4/5

Turn count: 45
Phase count: 12

First Shrine damage: 4
First Shrine broken: 34
First Ancestor awakened: 14
First L2: 9
First L3: 

Red L2 entries: 7 (hard-cast 7, evolved 0)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 4 (hard-cast 2, evolved 2)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 0, Iron 8
Legal L2 evolve actions: Red 0, Iron 8
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 0, Iron 4
Turns with legal L2 evolution: Red 0, Iron 4
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 0, Iron 8
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 11, Iron 2

Legal awaken actions generated: Red 30, Iron 10
Awaken actions chosen: Red 12, Iron 7
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.grandmother, Iron iron.ancestor.firstpack
Ancestor switches: Red 0, Iron 0
Turns with awakened ancestor: Red 15, Iron 11
Memory spent on ancestors: Red 2, Iron 2
Ancestor realized value: First Hunter +0 damage, Grandmother healed 8, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 1, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 4, Iron 4
Wounded events: Red 21, Iron 9
Wounded reduced damage: Red 19, Iron 9
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 55, Iron 0
Blocks chosen: Red 7, Iron 0
Blocks declined: Red 12, Iron 0
Assault slots spent: Seat 1 standard 0, pack 0 | Seat 2 standard 13, pack 35
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 44, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 48, generated 43, available 43, skipped 8, turns-with-bonus 18, max-attacks 89, prevented-by-limit 0
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
