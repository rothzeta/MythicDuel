# Test Game #561

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

Seed: 561
Winner: iron-hyena-pack-pressure
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Baobab Guardian, Esprit du Léopard, Ritual of Red Moon, Young Hunter, Young Hunter
- Starting hands — Iron: Black-Tooth Smith, Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Pack Harrier
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Baobab Guardian, Esprit du Léopard, Ritual of Red Moon, Young Hunter, Young Hunter]

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
- discarded cards: Baobab Guardian, Ritual of Red Moon, Young Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith, Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Pack Harrier]

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
- retained card: Bone Spear
- discarded cards: Black-Tooth Smith, Pack Harrier, Black-Tooth Smith
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
- Main 1: played River Hunter

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
- retained card: Esprit du Léopard
- discarded cards: Esprit du Léopard, Spear of First Dawn, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: River Hunter

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

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
- retained card: Bone Spear
- discarded cards: Hyena Pack Call, Iron Hyena Champion, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Pack Harrier

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/1 | Iron 1/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 0
Key events: Main 1: played Young Hunter | Main 1: played Bone-Cracker Cub | Bone-Cracker Cub deals 2 to Young Hunter. | Young Hunter deals 2 to Bone-Cracker Cub. | Main 1: played River Hunter | Main 1: played Pack Harrier
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: attached Esprit du Léopard to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Pack Harrier
- Defender/blocker: Pack Harrier
- Prepared triggers: None
- Wounded/Pierce calculations: River Hunter becomes Wounded.
- Damage: Pack Harrier deals 1 to River Hunter. | River Hunter deals 5 to Pack Harrier.
- Result: River Hunter survives, Pack Harrier removed

Main 2:
- Main 2: resolved Offering of Milk and Ash (had no damaged shrine to restore)

End:
- retained card: Leopard Hunter
- discarded cards: Pale River Spirit, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, River Hunter [Wounded, Possession:Esprit du Léopard]

## Turn 6 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Iron Hyena Raider, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub

## Turn 7 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Esprit du Léopard, River Hunter [Wounded, Possession:Esprit du Léopard]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Offering of Milk and Ash]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Spear of First Dawn
- discarded cards: Pale River Spirit, Ritual of Red Moon, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, Leopard Hunter [Possession:Esprit du Léopard]

## Turn 8 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: attached Bone Spear to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Hunter’s Root-Stone
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 6 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Leopard Hunter.
- Result: Blood-Scent Hyena left battle, Leopard Hunter survives, Hunter’s Root-Stone at 10/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 6 to 4.
- Damage: Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed, Hunter’s Root-Stone at 9/10

Main 2:
- Main 2: played Blood-Scent Hyena

End:
- retained card: Blood-Scent Hyena
- discarded cards: Iron Hyena Champion, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/1 | Iron 1/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 0
Key events: Leopard Hunter deals 6 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Leopard Hunter. | Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Leopard Hunter. | Main 1: attached Bone Spear to Blood-Scent Hyena | Main 2: played Blood-Scent Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 3

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Offering of Milk and Ash]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Deep River Spirit

Combat:
- no attacks

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Spear of First Dawn
- discarded cards: Root-Woven Guard, Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Deep River Spirit, Young Hunter

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Blood-Scent Hyena
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 3.
- Result: Blood-Scent Hyena survives, Hunter’s Root-Stone at 5/10

Main 2:
- Main 2: played Blood-Scent Hyena

End:
- retained card: Fang Relic
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena, Hyena Token, Hyena Token

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Deep River Spirit, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Offering of Milk and Ash]

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
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Spear of First Dawn, Offering of Milk and Ash, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: Deep River Spirit, River Hunter

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Hyena Token, Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Pack Ambush, Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)

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
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Fang Relic
- discarded cards: Iron Hyena Raider, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Hyena Token, Hyena Token

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 4/1 | Iron 2/0
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Ancestor of the First Pack
Forgotten cards: Red 1 | Iron 4
Key events: Young Hunter deals 2 to Blood-Scent Hyena. | Main 1: played River Hunter | Shrine Hunter’s Root-Stone takes 3. | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone) | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone) | Main 2: awakened Ancestor of the First Pack
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Deep River Spirit, River Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Offering of Milk and Ash]

Main 1:
- Main 1: played Leopard Hunter
- Main 1: prepared Root-Woven Guard

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
- retained card: Deep River Spirit
- discarded cards: Hunter’s Call, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Deep River Spirit, Leopard Hunter

## Turn 14 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Hyena Token, Hyena Token
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Hyena Token

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: Root-Woven Guard
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | Ancestor of the First Pack deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 4 to Hyena Token. | Hyena Token deals 3 to Leopard Hunter. | Shrine Shrine of the Red Baobab takes 1.
- Result: Hyena Token left battle, Leopard Hunter survives, Shrine of the Red Baobab at 8/10

Attack 2:
- Attacker: Hyena Token
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Hyena Token. | Hyena Token deals 2 to Leopard Hunter.
- Result: Hyena Token left battle, Leopard Hunter removed, Shrine of the Red Baobab at 8/10

Main 2:
- Main 2: played Pack Harrier
- Main 2: played Pack Harrier

End:
- retained card: Bone Spear
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Pack Harrier, Pack Harrier

## Turn 15 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Deep River Spirit
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter
- Main 1: resolved Ritual of Red Moon (dealt 2 to Pack Harrier, destroyed it, gained 1 Memory)

Combat:
- no attacks

Main 2:
- Main 2: played Pale River Spirit

End:
- retained card: Deep River Spirit
- discarded cards: Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
- board at end: Deep River Spirit, Pale River Spirit, Young Hunter

## Turn 16 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Pack Harrier
- Main 1: attached Bone Spear to Pack Harrier

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 3.
- Result: Pack Harrier survives, Moonlit Roots at 6/10

Main 2:
- Main 2: played Blood-Scent Hyena
- Main 2: played Blood-Scent Hyena

End:
- retained card: Fang Relic
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear, Bone Spear, Pack Harrier [Relic:Bone Spear]

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/1 | Iron 2/2
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 3 | Iron 4
Key events: Main 2: played Pale River Spirit | Shrine Moonlit Roots takes 3. | Main 1: attached Bone Spear to Pack Harrier | Main 1: attached Bone Spear to Pack Harrier | Main 2: played Blood-Scent Hyena | Main 2: played Blood-Scent Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Deep River Spirit, Pale River Spirit, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 4/10
Forgotten zone count/list: 3 [Offering of Milk and Ash, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Deep River Spirit
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Blood-Scent Hyena deals 2 to Deep River Spirit. | Deep River Spirit deals 3 to Blood-Scent Hyena.
- Result: Deep River Spirit survives, Blood-Scent Hyena removed

Main 2:
- pass

End:
- retained card: Pale River Spirit
- discarded cards: Deep River Spirit, Hunter’s Call
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 3 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 3/10
- board at end: Deep River Spirit [Wounded], Leopard Hunter, Pale River Spirit, River Hunter

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 2

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Bone Spear, Pack Harrier [Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | Pack Harrier deals 1 to blocked Shrine. | Ancestor of the First Pack deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 4 to Pack Harrier. | Pack Harrier deals 3 to Leopard Hunter. | Shrine Moonlit Roots takes 2.
- Result: Pack Harrier left battle, Leopard Hunter survives, Moonlit Roots at 5/10

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 4 to Leopard Hunter.
- Result: Blood-Scent Hyena left battle, Leopard Hunter removed, Moonlit Roots at 5/10

Main 2:
- Main 2: played Pack Harrier
- Main 2: played Bone-Cracker Cub

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 3 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Pack Harrier

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 2

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Deep River Spirit [Wounded], Pale River Spirit, River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 5/10
Forgotten zone count/list: 3 [Offering of Milk and Ash, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: attached Spear of First Dawn to Deep River Spirit

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
- Main 2: played Pale River Spirit
- Main 2: resolved Offering of Milk and Ash (restored 3 to Moonlit Roots)
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Baobab Guardian
- discarded cards: Esprit du Léopard
- forgotten cards: None
- Wounded clears: Deep River Spirit
- resources at end: 3 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
- board at end: Deep River Spirit [Relic:Spear of First Dawn], Pale River Spirit, Pale River Spirit, Spear of First Dawn

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 3

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Bone Spear, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 2.
- Result: Pack Harrier survives, Shrine of the Red Baobab at 6/10

Main 2:
- pass

End:
- retained card: Hyena Pack Call
- discarded cards: Iron Hyena Raider, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 4 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub, Pack Harrier

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/2 | Iron 5/4
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Ancestor of the First Pack
Forgotten cards: Red 4 | Iron 4
Key events: Main 2: played Pale River Spirit | Main 2: resolved Offering of Milk and Ash (restored 3 to Moonlit Roots) | Main 2: awakened Grandmother Beneath the Roots | Shrine Shrine of the Red Baobab takes 2. | Main 1: played Bone-Cracker Cub | Main 1: played Blood-Scent Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 2

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: Deep River Spirit [Relic:Spear of First Dawn], Pale River Spirit, Pale River Spirit, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
Forgotten zone count/list: 4 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Spear of First Dawn to Deep River Spirit

Combat:

Attack 1:
- Attacker: Deep River Spirit
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Blood-Scent Hyena deals 2 to Deep River Spirit. | Deep River Spirit deals 4 to Blood-Scent Hyena.
- Result: Deep River Spirit survives, Blood-Scent Hyena removed

Main 2:
- Main 2: played Baobab Guardian
- Main 2: awakened First Hunter

End:
- retained card: Ritual of Red Moon
- discarded cards: Root-Woven Guard
- forgotten cards: None
- Wounded clears: River Hunter
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
- board at end: Baobab Guardian, Deep River Spirit [Wounded, Relic:Spear of First Dawn], Pale River Spirit, Pale River Spirit, River Hunter [Possession:Esprit du Léopard], Spear of First Dawn, Spear of First Dawn

## Turn 22 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 4

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab)
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 4 to 3. | Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Deep River Spirit.
- Result: Bone-Cracker Cub left battle, Deep River Spirit survives

Main 2:
- pass

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Token, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 4 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Hyena Champion, Iron Hyena Raider

## Turn 23 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Baobab Guardian, Deep River Spirit [Wounded, Relic:Spear of First Dawn], Pale River Spirit, Pale River Spirit, River Hunter [Possession:Esprit du Léopard], Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 5/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
Forgotten zone count/list: 4 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: resolved Ritual of Red Moon (dealt 2 to Iron Hyena Champion)
- Main 1: resolved Ritual of Red Moon (dealt 2 to Iron Hyena Raider, destroyed it, gained 1 Memory)

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 5 to 3.
- Damage: Iron Hyena Champion deals 3 to River Hunter. | River Hunter deals 5 to Iron Hyena Champion.
- Result: River Hunter left battle, Iron Hyena Champion removed

Main 2:
- pass

End:
- retained card: Young Hunter
- discarded cards: Young Hunter, Esprit du Léopard
- forgotten cards: None
- Wounded clears: Deep River Spirit
- resources at end: 4 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 5/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
- board at end: Baobab Guardian, Deep River Spirit [Relic:Spear of First Dawn], Pale River Spirit, Pale River Spirit, Spear of First Dawn, Spear of First Dawn

## Turn 24 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 4

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone Spear
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Black-Tooth Smith, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 4 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Hyena Token, Hyena Token

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 5/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 4/4 | Iron 4/4
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 6 | Iron 4
Key events: Iron Hyena Champion deals 3 to River Hunter. | River Hunter deals 5 to Iron Hyena Champion. | Main 1: resolved Ritual of Red Moon (dealt 2 to Iron Hyena Champion) | Main 1: resolved Ritual of Red Moon (dealt 2 to Iron Hyena Raider, destroyed it, gained 1 Memory) | Main 1: played Blood-Scent Hyena | Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)
Tempo note: initiative reverses after every four player-turns.

## Turn 25 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 4

Hand before draw: [Young Hunter]

Board before ready:
Beings/Spirits: Baobab Guardian, Deep River Spirit [Relic:Spear of First Dawn], Pale River Spirit, Pale River Spirit, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 5/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
Forgotten zone count/list: 6 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Deep River Spirit
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Blood-Scent Hyena deals 2 to Deep River Spirit. | Deep River Spirit deals 4 to Blood-Scent Hyena.
- Result: Deep River Spirit survives, Blood-Scent Hyena removed

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: River Hunter, River Hunter, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 7 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
- board at end: Baobab Guardian, Deep River Spirit [Wounded, Relic:Spear of First Dawn], Pale River Spirit, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter

## Turn 26 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 4

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone Spear, Hyena Token, Hyena Token
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 4 to 3. | Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Hyena Token. | Hyena Token deals 1 to Deep River Spirit.
- Result: Hyena Token left battle, Deep River Spirit survives

Attack 2:
- Attacker: Hyena Token
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 4 to 3. | Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Hyena Token. | Hyena Token deals 1 to Deep River Spirit.
- Result: Hyena Token left battle, Deep River Spirit survives

Main 2:
- Main 2: played Iron Hyena Champion

End:
- retained card: Black-Tooth Smith
- discarded cards: Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 4 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Iron Hyena Champion

## Turn 27 — Red

Pre-resource snapshot:
Offerings before resource: 7
Memory before resource: 4

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian, Deep River Spirit [Wounded, Relic:Spear of First Dawn], Pale River Spirit, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
Forgotten zone count/list: 6 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: attached Esprit du Léopard to Baobab Guardian

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
- Attacker: Deep River Spirit
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 4 to 3.
- Damage: Iron Hyena Champion deals 5 to Deep River Spirit. | Deep River Spirit deals 3 to Iron Hyena Champion.
- Result: Deep River Spirit left battle, Iron Hyena Champion removed

Main 2:
- pass

End:
- retained card: Young Hunter
- discarded cards: Baobab Guardian, Esprit du Léopard, Leopard Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
- board at end: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Pale River Spirit, Spear of First Dawn

## Turn 28 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 4

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Bone-Cracker Cub
- Main 1: played Pack Harrier

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
- Main 2: played Black-Tooth Smith

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 4 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Pack Harrier

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 6/5 | Iron 2/4
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 6 | Iron 4
Key events: Main 1: attached Esprit du Léopard to Baobab Guardian | Baobab Guardian deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Baobab Guardian. | Main 1: attached Fang Relic to Bone-Cracker Cub | Main 1: played Pack Harrier | Main 2: played Black-Tooth Smith
Tempo note: initiative reverses after every four player-turns.

## Turn 29 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 5

Hand before draw: [Young Hunter]

Board before ready:
Beings/Spirits: Baobab Guardian [Wounded, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Pale River Spirit, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
Forgotten zone count/list: 6 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 4 to 3. | Baobab Guardian becomes Wounded.
- Damage: Black-Tooth Smith deals 2 to Baobab Guardian. | Baobab Guardian deals 3 to Black-Tooth Smith.
- Result: Baobab Guardian survives, Black-Tooth Smith removed

Attack 2:
- Attacker: Pale River Spirit
- Target: Pack Harrier
- Defender/blocker: Pack Harrier
- Prepared triggers: None
- Wounded/Pierce calculations: Pale River Spirit becomes Wounded.
- Damage: Pack Harrier deals 1 to Pale River Spirit. | Pale River Spirit deals 2 to Pack Harrier.
- Result: Pale River Spirit survives, Pack Harrier removed

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Root-Woven Guard, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Wounded, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Pale River Spirit [Wounded], River Hunter, Spear of First Dawn, Young Hunter

## Turn 30 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 4

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone Spear
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Hyena Pack Call, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 4 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub

## Turn 31 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 5

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Baobab Guardian [Wounded, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Pale River Spirit [Wounded], River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 6 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter

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
- retained card: Kuma Who Wounded the Sun
- discarded cards: Esprit du Léopard, Deep River Spirit, Young Hunter
- forgotten cards: None
- Wounded clears: Baobab Guardian, Pale River Spirit, Leopard Hunter
- resources at end: 5 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Leopard Hunter, Pale River Spirit, Pale River Spirit, Spear of First Dawn

## Turn 32 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 4

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Bone-Cracker Cub
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter survives

Main 2:
- Main 2: played Iron Hyena Raider

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 4 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Iron Hyena Raider

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/7 | Iron 2/4
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 6 | Iron 4
Key events: Main 1: evolved Young Hunter into Leopard Hunter | Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Leopard Hunter. | Main 1: attached Fang Relic to Bone-Cracker Cub | Main 1: played Blood-Scent Hyena | Main 2: played Iron Hyena Raider
Tempo note: initiative reverses after every four player-turns.

## Turn 33 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 7

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Leopard Hunter [Wounded], Pale River Spirit, Pale River Spirit, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 6 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
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
- Attacker: Baobab Guardian
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 5.
- Result: Baobab Guardian survives, Bone-Fang Shrine at 2/10

Main 2:
- Main 2: attached Spear of First Dawn to Pale River Spirit
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: River Hunter, Young Hunter
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 4 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Leopard Hunter, Pale River Spirit, Pale River Spirit [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Spear of First Dawn

## Turn 34 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 4

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Raider

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
- Attacker: Iron Hyena Raider
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Leopard Hunter.
- Result: Iron Hyena Raider left battle, Leopard Hunter removed

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: played Iron Hyena Champion

End:
- retained card: Pack Harrier
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 4 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Iron Hyena Champion

## Turn 35 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 6

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Pale River Spirit [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 6 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Esprit du Léopard to Baobab Guardian

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
- pass

End:
- retained card: Deep River Spirit
- discarded cards: Kuma Who Wounded the Sun, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 6 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Pale River Spirit [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter

## Turn 36 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 4

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Baobab Guardian.
- Result: Bone-Cracker Cub left battle, Baobab Guardian survives

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 4 to 3.
- Damage: Baobab Guardian deals 3 to Iron Hyena Champion. | Iron Hyena Champion deals 5 to Baobab Guardian.
- Result: Iron Hyena Champion left battle, Baobab Guardian removed

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Hyena Token
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 4 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Pack Harrier, Pack Harrier

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/6 | Iron 3/4
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Ancestor of the First Pack
Forgotten cards: Red 6 | Iron 4
Key events: Bone-Cracker Cub deals 2 to Baobab Guardian. | Baobab Guardian deals 3 to Iron Hyena Champion. | Iron Hyena Champion deals 5 to Baobab Guardian. | Main 1: played Pack Harrier | Main 1: played Pack Harrier | Main 2: played Black-Tooth Smith
Tempo note: initiative reverses after every four player-turns.

## Turn 37 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 8

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Pale River Spirit, Pale River Spirit [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
Forgotten zone count/list: 6 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
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

Attack 2:
- Attacker: Young Hunter
- Target: Pack Harrier
- Defender/blocker: Pack Harrier
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Pack Harrier deals 1 to Young Hunter. | Young Hunter deals 2 to Pack Harrier.
- Result: Young Hunter left battle, Pack Harrier removed

Main 2:
- Main 2: played Deep River Spirit
- Main 2: prepared Hunter’s Call
- Main 2: awakened First Hunter

End:
- retained card: Hunter’s Call
- discarded cards: Root-Woven Guard
- forgotten cards: None
- Wounded clears: Deep River Spirit
- resources at end: 1 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Deep River Spirit, Pale River Spirit, Pale River Spirit [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Spear of First Dawn

## Turn 38 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 4

Hand before draw: [Hyena Token]

Board before ready:
Beings/Spirits: Bone Spear, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 1.
- Result: Pack Harrier survives, Moonlit Roots at 9/10

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Token, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 5 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Pack Harrier, Pack Harrier

## Turn 39 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 7

Hand before draw: [Hunter’s Call]

Board before ready:
Beings/Spirits: Deep River Spirit, Pale River Spirit, Pale River Spirit [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: Hunter’s Call
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
Forgotten zone count/list: 6 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter
- Main 1: played Young Hunter

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
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Hunter’s Call, Deep River Spirit
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 4 Offerings / 9 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
- board at end: Deep River Spirit, Leopard Hunter, Pale River Spirit, Spear of First Dawn, Young Hunter

## Turn 40 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 5

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone Spear, Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Moonlit Roots)

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | Pack Harrier deals 1 to blocked Shrine. | Ancestor of the First Pack deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 4 to Pack Harrier. | Pack Harrier deals 1 to Leopard Hunter. | Shrine Moonlit Roots takes 2.
- Result: Pack Harrier left battle, Leopard Hunter survives, Moonlit Roots at 5/10

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Token, Iron Hyena Raider, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: Iron Hyena Champion
- resources at end: 5 Offerings / 6 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Hyena Champion

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 4/9 | Iron 5/6
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 6 | Iron 4
Key events: Main 1: evolved River Hunter into Leopard Hunter | Main 1: played Young Hunter | Leopard Hunter deals 4 to Pack Harrier. | Pack Harrier deals 1 to Leopard Hunter. | Shrine Moonlit Roots takes 2. | Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Moonlit Roots)
Tempo note: initiative reverses after every four player-turns.

## Turn 41 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 9

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Deep River Spirit, Leopard Hunter [Wounded], Pale River Spirit, Spear of First Dawn, Young Hunter
Prepared Tactic: Hunter’s Call
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 5/10
Forgotten zone count/list: 6 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 5 to 3.
- Damage: Iron Hyena Champion deals 5 to Leopard Hunter. | Leopard Hunter deals 3 to Iron Hyena Champion.
- Result: Leopard Hunter left battle, Iron Hyena Champion removed, Iron Hyena Den at 10/10

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Root-Woven Guard, Baobab Guardian
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 4 Offerings / 10 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 5/10
- board at end: Deep River Spirit, Leopard Hunter, Pale River Spirit, Spear of First Dawn, Young Hunter

## Turn 42 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 6

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone Spear
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Token, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 6 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Iron Hyena Raider

## Turn 43 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 10

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Deep River Spirit, Leopard Hunter, Pale River Spirit, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 5/10
Forgotten zone count/list: 7 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
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
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: attached Esprit du Léopard to Leopard Hunter

End:
- retained card: Deep River Spirit
- discarded cards: Hunter’s Call, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 10 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 5/10
- board at end: Deep River Spirit, Esprit du Léopard, Leopard Hunter [Possession:Esprit du Léopard], Pale River Spirit, Spear of First Dawn, Young Hunter

## Turn 44 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 6

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 5/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 2.
- Result: Blood-Scent Hyena survives, Moonlit Roots at 3/10

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 7 Memory
- shrine state: Iron Hyena Den: 5/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 5/10] | Iron [Iron Hyena Den: 5/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/10 | Iron 5/7
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 7 | Iron 4
Key events: Young Hunter deals 2 to Iron Hyena Raider. | Main 1: played Young Hunter | Main 2: attached Esprit du Léopard to Leopard Hunter | Shrine Moonlit Roots takes 2. | Main 1: played Bone-Cracker Cub | Main 1: played Blood-Scent Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 45 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 10

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Deep River Spirit, Esprit du Léopard, Leopard Hunter [Possession:Esprit du Léopard], Pale River Spirit, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 7/10
Forgotten zone count/list: 7 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Iron Hyena Den)

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
- Main 2: played Deep River Spirit

End:
- retained card: Esprit du Léopard
- discarded cards: River Hunter, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 8 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 6/10
- board at end: Deep River Spirit, Deep River Spirit, Esprit du Léopard, Kuma Who Wounded the Sun [Possession:Esprit du Léopard], Pale River Spirit, Spear of First Dawn

## Turn 46 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 7

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 8/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Moonlit Roots
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Kuma Who Wounded the Sun becomes Wounded. | Ancestor of the First Pack deals 1 to blocked Shrine.
- Damage: Kuma Who Wounded the Sun deals 8 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Kuma Who Wounded the Sun. | Shrine Moonlit Roots takes 1.
- Result: Blood-Scent Hyena left battle, Kuma Who Wounded the Sun survives, Moonlit Roots at 3/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 8 to 6. | Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 6 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Kuma Who Wounded the Sun.
- Result: Bone-Cracker Cub left battle, Kuma Who Wounded the Sun survives, Moonlit Roots at 3/10

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Token, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 8 Memory
- shrine state: Iron Hyena Den: 8/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear

## Turn 47 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 8

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Deep River Spirit, Deep River Spirit, Esprit du Léopard, Kuma Who Wounded the Sun [Wounded, Possession:Esprit du Léopard], Pale River Spirit, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 7/10
Forgotten zone count/list: 7 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard]

Main 1:
- Main 1: attached Spear of First Dawn to Pale River Spirit

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 9 to 6.
- Damage: Shrine Iron Hyena Den takes 6.
- Result: Kuma Who Wounded the Sun survives, Iron Hyena Den at 0/10

Attack 2:
- Attacker: Pale River Spirit
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Blood-Scent Hyena deals 2 to Pale River Spirit. | Pale River Spirit deals 3 to Blood-Scent Hyena.
- Result: Pale River Spirit left battle, Blood-Scent Hyena removed

Main 2:
- Main 2: prepared Root-Woven Guard
- Main 2: attached Esprit du Léopard to Kuma Who Wounded the Sun

End:
- retained card: Pale River Spirit
- discarded cards: Baobab Guardian
- forgotten cards: None
- Wounded clears: Kuma Who Wounded the Sun
- resources at end: 3 Offerings / 9 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 9/10
- board at end: Deep River Spirit, Deep River Spirit, Esprit du Léopard, Kuma Who Wounded the Sun [Possession:Esprit du Léopard], Spear of First Dawn

## Turn 48 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 8

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 14/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Blood-Scent Hyena
- Main 1: attached Fang Relic to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: Root-Woven Guard
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 3.
- Result: Blood-Scent Hyena survives, Moonlit Roots at 0/10

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: played Black-Tooth Smith

End:
- retained card: None
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 8 Memory
- shrine state: Iron Hyena Den: 14/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Relic:Bone Spear], Blood-Scent Hyena [Relic:Fang Relic], Bone Spear, Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 9/10] | Iron [Iron Hyena Den: 14/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/9 | Iron 0/8
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 7 | Iron 4
Key events: Main 2: attached Esprit du Léopard to Kuma Who Wounded the Sun | Shrine Moonlit Roots takes 3. | Main 1: attached Fang Relic to Blood-Scent Hyena | Main 1: attached Fang Relic to Blood-Scent Hyena | Main 2: played Bone-Cracker Cub | Main 2: played Black-Tooth Smith
Tempo note: initiative reverses after every four player-turns.

## Turn 49 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 9

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Deep River Spirit, Deep River Spirit, Esprit du Léopard, Kuma Who Wounded the Sun [Possession:Esprit du Léopard], Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 12/10
Forgotten zone count/list: 8 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 9.
- Result: Kuma Who Wounded the Sun survives, Rusted Moon Shrine at 1/10

Attack 2:
- Attacker: Deep River Spirit
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Black-Tooth Smith deals 3 to Deep River Spirit. | Deep River Spirit deals 3 to Black-Tooth Smith.
- Result: Deep River Spirit survives, Black-Tooth Smith removed

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Pale River Spirit, Hunter’s Call, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 7 Offerings / 9 Memory
- shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 12/10
- board at end: Deep River Spirit, Deep River Spirit [Wounded], Esprit du Léopard, Kuma Who Wounded the Sun [Possession:Esprit du Léopard], Spear of First Dawn, Young Hunter

## Turn 50 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 8

Hand before draw: []

Board before ready:
Beings/Spirits: Blood-Scent Hyena [Relic:Fang Relic], Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 14/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 9/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Blood-Scent Hyena into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab)
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 3.
- Result: Bone-Cracker Cub survives, Shrine of the Red Baobab at 1/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Token, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 8 Memory
- shrine state: Iron Hyena Den: 14/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 9/10
- board at end: Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Hyena Champion [Relic:Fang Relic], Pack Harrier

## Turn 51 — Red

Pre-resource snapshot:
Offerings before resource: 7
Memory before resource: 9

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Deep River Spirit, Deep River Spirit [Wounded], Esprit du Léopard, Kuma Who Wounded the Sun [Possession:Esprit du Léopard], Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 9/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 12/10
Forgotten zone count/list: 8 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Rusted Moon Shrine
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Pierce overflow deals 6 to Rusted Moon Shrine.
- Damage: Iron Hyena Champion deals 6 to Kuma Who Wounded the Sun. | Kuma Who Wounded the Sun deals 9 to Iron Hyena Champion. | Shrine Rusted Moon Shrine takes 6.
- Result: Kuma Who Wounded the Sun left battle, Iron Hyena Champion removed, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Baobab Guardian
- discarded cards: Young Hunter, Young Hunter, River Hunter
- forgotten cards: None
- Wounded clears: Deep River Spirit, Leopard Hunter
- resources at end: 5 Offerings / 10 Memory
- shrine state: Shrine of the Red Baobab: 10/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 12/10
- board at end: Deep River Spirit, Deep River Spirit, Leopard Hunter, Spear of First Dawn

## End-of-game summary

Winner: iron-hyena-pack-pressure
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Shrine of the Red Baobab 10/10, Hunter’s Root-Stone 12/10, Moonlit Roots 12/10] | Iron [Iron Hyena Den 14/10, Bone-Fang Shrine 12/10, Rusted Moon Shrine 15/10]
Final resources: Red 5/10 | Iron 4/8
Final Presence: Seat 1 3/5 | Seat 2 2/5

Turn count: 51
Phase count: 1

First Shrine damage: 8 (Seat 1/Red: 8, Seat 2/Iron: 33)
First Shrine broken: 12 (Seat 1/Red: 12, Seat 2/Iron: 35)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 0, Iron 0
First Ancestor awakened: 9
First L2: 7
First L3: 45

Red L2 entries: 7 (hard-cast 1, evolved 6)
Red L3 entries: 1 (hard-cast 0, evolved 1)
Iron L2 entries: 5 (hard-cast 2, evolved 3)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 16, Iron 8
Legal L2 evolve actions: Red 14, Iron 8
Legal L3 evolve actions: Red 2, Iron 0
Evolve windows: Red 14, Iron 6
Turns with legal L2 evolution: Red 12, Iron 6
Turns with legal L3 evolution: Red 2, Iron 0
Evolve actions chosen: Red 15, Iron 8
Hard-cast chosen while legal evolve action existed: Red 2, Iron 0
Hard-cast chosen while evolution base existed: Red 6, Iron 4

Legal awaken actions generated: Red 50, Iron 21
Awaken actions chosen: Red 18, Iron 15
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.grandmother, Iron iron.ancestor.firstpack
Ancestor switches: Red 5, Iron 0
Turns with awakened ancestor: Red 21, Iron 19
Memory spent on ancestors: Red 12, Iron 2
Ancestor realized value: First Hunter +7 damage, Grandmother healed 3, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 3, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 9, Iron 4
Wounded events: Red 20, Iron 1
Wounded reduced damage: Red 14, Iron 1
Pierce overflow events: Red 1, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 9, Iron 2
Blocks chosen: Red 9, Iron 2
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 29, pack 0 | Seat 2 standard 4, pack 22
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 52, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 25, generated 25, available 25, skipped 3, turns-with-bonus 17, max-attacks 75, prevented-by-limit 0
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
