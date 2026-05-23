# Test Game #525

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

Seed: 525
Winner: red-hunter-evolution
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting Shrines — Iron: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting hands — Red: Bite the Roots, Blood-Scent Hyena, Bone-Cracker Cub, Iron Hyena Raider, Pack Harrier
- Starting hands — Iron: Hunter’s Call, Offering of Milk and Ash, Pale River Spirit, Ritual of Red Moon, River Hunter
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang
- Starting Lineage — Iron: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Blood-Scent Hyena, Bone-Cracker Cub, Iron Hyena Raider, Pack Harrier]

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
- discarded cards: Blood-Scent Hyena, Bone-Cracker Cub, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Pack Harrier

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Hunter’s Call, Offering of Milk and Ash, Pale River Spirit, Ritual of Red Moon, River Hunter]

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
- discarded cards: Pale River Spirit, Ritual of Red Moon, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: 

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)

Combat:

Attack 1:
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
- retained card: Bite the Roots
- discarded cards: Bone-Cracker Cub, Bone Spear, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Pack Harrier

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [River Hunter]

Board before ready:
Beings/Spirits: 
Prepared Tactic: Hunter’s Call
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played River Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Young Hunter, Offering of Milk and Ash, Spear of First Dawn
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
- board at end: River Hunter

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10]
Resources: Red 0/0 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 0
Key events: Main 1: played Pack Harrier | Main 1: prepared Hunter’s Call | Shrine Hunter’s Root-Stone takes 2. | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone) | Main 1: played River Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Hunter’s Root-Stone)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bite the Roots
- discarded cards: Pack Harrier, Iron Hyena Raider, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Champion

## Turn 6 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: Hunter’s Call
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to River Hunter. | River Hunter deals 3 to Iron Hyena Champion.
- Result: River Hunter left battle, Iron Hyena Champion removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Root-Woven Guard
- discarded cards: Esprit du Léopard, Baobab Guardian, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 7 — Red

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
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone, broke it, gained 1 Memory)
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider

## Turn 8 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Root-Woven Guard]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Hunter’s Call]

Main 1:
- Main 1: resolved Ritual of Red Moon (dealt 2 to Iron Hyena Raider, destroyed it, gained 1 Memory)
- Main 1: resolved Ritual of Red Moon (had no legal target)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Pale River Spirit
- discarded cards: Root-Woven Guard, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
- board at end: Young Hunter

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10]
Resources: Red 0/1 | Iron 0/1
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 2 | Iron 3
Key events: Main 1: played Young Hunter | Main 2: awakened First Hunter | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone, broke it, gained 1 Memory) | Main 1: played Iron Hyena Raider | Main 1: resolved Ritual of Red Moon (dealt 2 to Iron Hyena Raider, destroyed it, gained 1 Memory) | Main 1: resolved Ritual of Red Moon (had no legal target)
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token)
- Main 1: played Blood-Scent Hyena

Combat:
- no attacks

Main 2:
- Main 2: played Blood-Scent Hyena

End:
- retained card: Black-Tooth Smith
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena, Hyena Token

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

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

End:
- retained card: Leopard Hunter
- discarded cards: Root-Woven Guard, Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
- board at end: Pale River Spirit, River Hunter

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 1.
- Result: Hyena Token survives, Moonlit Roots at 9/10

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 4.
- Result: Blood-Scent Hyena survives, Moonlit Roots at 5/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Black-Tooth Smith
- discarded cards: Bone-Cracker Cub, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena [Relic:Fang Relic], Fang Relic, Hyena Token

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 2

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Pale River Spirit, River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 5/10
Forgotten zone count/list: 3 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

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
- Attacker: Pale River Spirit
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Blood-Scent Hyena deals 3 to Pale River Spirit. | Pale River Spirit deals 2 to Blood-Scent Hyena.
- Result: Pale River Spirit left battle, Blood-Scent Hyena removed

Main 2:
- Main 2: played Deep River Spirit

End:
- retained card: Leopard Hunter
- discarded cards: Hunter’s Call, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 6/10
- board at end: Deep River Spirit, River Hunter

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 6/10]
Resources: Red 1/1 | Iron 0/5
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 3 | Iron 3
Key events: Black-Tooth Smith deals 2 to River Hunter. | River Hunter deals 3 to Black-Tooth Smith. | Blood-Scent Hyena deals 3 to Pale River Spirit. | Pale River Spirit deals 2 to Blood-Scent Hyena. | Main 1: played River Hunter | Main 2: played Deep River Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: evolved Hyena Token into Iron Hyena Champion (dealt 2 to Moonlit Roots)

Combat:
- no attacks

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Pack Harrier
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Relic:Bone Spear], Bone Spear, Iron Hyena Champion

## Turn 14 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 5

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Deep River Spirit, River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 8/10
Forgotten zone count/list: 3 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to River Hunter. | River Hunter deals 3 to Iron Hyena Champion.
- Result: River Hunter left battle, Iron Hyena Champion removed

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Spear of First Dawn, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 8/10
- board at end: Deep River Spirit, Leopard Hunter, Young Hunter

## Turn 15 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Relic:Bone Spear], Bone Spear
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token)
- Main 1: attached Fang Relic to Black-Tooth Smith

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 4 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter removed, Moonlit Roots at 2/10

Main 2:
- Main 2: played Pack Harrier
- Main 2: played Pack Harrier

End:
- retained card: Hyena Token
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Hyena Token, Pack Harrier, Pack Harrier

## Turn 16 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 7

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Deep River Spirit, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 8/10
Forgotten zone count/list: 3 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Leopard Hunter

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
- retained card: Ritual of Red Moon
- discarded cards: Pale River Spirit, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 8 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 8/10
- board at end: Deep River Spirit, Leopard Hunter, River Hunter

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 8/10]
Resources: Red 3/1 | Iron 1/8
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 3
Key events: Main 2: played Pack Harrier | Main 2: played Pack Harrier | Hyena Token deals 1 to Young Hunter. | Young Hunter deals 2 to Hyena Token. | Main 1: played River Hunter | Main 1: played Leopard Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Hyena Token]

Board before ready:
Beings/Spirits: Bone Spear, Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Black-Tooth Smith

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | Pack Harrier deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 4 to Pack Harrier. | Pack Harrier deals 2 to Leopard Hunter. | Shrine Moonlit Roots takes 1.
- Result: Pack Harrier left battle, Leopard Hunter survives, Moonlit Roots at 1/10

Attack 2:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Pack Harrier deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 3 to Pack Harrier. | Pack Harrier deals 2 to Leopard Hunter. | Shrine Moonlit Roots takes 1.
- Result: Pack Harrier left battle, Leopard Hunter removed, Moonlit Roots at 0/10

Main 2:
- pass

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Token, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena, Bone Spear

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 8

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Deep River Spirit, River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 3 [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: resolved Ritual of Red Moon (dealt 2 to Black-Tooth Smith)
- Main 1: prepared Hunter’s Call

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 2 to 1. | River Hunter becomes Wounded.
- Damage: Black-Tooth Smith deals 1 to River Hunter. | River Hunter deals 3 to Black-Tooth Smith.
- Result: River Hunter survives, Black-Tooth Smith removed

Main 2:
- pass

End:
- retained card: Baobab Guardian
- discarded cards: Offering of Milk and Ash, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 9 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: Deep River Spirit, River Hunter [Wounded]

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 3.
- Result: Blood-Scent Hyena survives, Shrine of the Red Baobab at 3/10

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Pack Call, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Iron Hyena Raider, Pack Harrier

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 9

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: Deep River Spirit, River Hunter [Wounded]
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 5 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Young Hunter

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
- Main 2: played Baobab Guardian

End:
- retained card: Esprit du Léopard
- discarded cards: Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 11 Memory
- shrine state: Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Deep River Spirit, Young Hunter, Young Hunter

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10]
Resources: Red 5/1 | Iron 3/11
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 5
Key events: Main 1: played Pack Harrier | Iron Hyena Raider deals 3 to River Hunter. | River Hunter deals 2 to Iron Hyena Raider. | Main 1: played Young Hunter | Main 1: played Young Hunter | Main 2: played Baobab Guardian
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 1

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

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
- Attacker: Pack Harrier
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2. | Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 2 to Pack Harrier. | Pack Harrier deals 1 to Deep River Spirit.
- Result: Pack Harrier left battle, Deep River Spirit survives

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: played Iron Hyena Raider

End:
- retained card: Blood-Scent Hyena
- discarded cards: Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Iron Hyena Raider

## Turn 22 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 11

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian, Deep River Spirit [Wounded], Young Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 5 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

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
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit, Pale River Spirit
- forgotten cards: None
- Wounded clears: Deep River Spirit
- resources at end: 4 Offerings / 12 Memory
- shrine state: Shrine of the Red Baobab: 8/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Deep River Spirit, River Hunter, Young Hunter

## Turn 23 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Deep River Spirit.
- Result: Bone-Cracker Cub left battle, Deep River Spirit survives

Main 2:
- Main 2: played Iron Hyena Raider

End:
- retained card: Iron Hyena Champion
- discarded cards: Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Iron Hyena Raider

## Turn 24 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 12

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian, Deep River Spirit [Wounded], River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 8/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 5 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter

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
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Spear of First Dawn, Offering of Milk and Ash, Deep River Spirit
- forgotten cards: None
- Wounded clears: Deep River Spirit
- resources at end: 5 Offerings / 13 Memory
- shrine state: Shrine of the Red Baobab: 8/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Deep River Spirit, Leopard Hunter

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 8/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10]
Resources: Red 3/1 | Iron 5/13
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 5
Key events: Main 1: attached Bone Spear to Bone-Cracker Cub | Main 1: played Blood-Scent Hyena | Main 2: played Iron Hyena Raider | Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Raider. | Main 1: evolved River Hunter into Leopard Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 25 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Bone-Cracker Cub

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
- Main 2: played Iron Hyena Champion

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Iron Hyena Champion

## Turn 26 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 13

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian, Deep River Spirit [Wounded], Leopard Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 8/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 5 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to Deep River Spirit

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 5.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 5/10

Attack 2:
- Attacker: Deep River Spirit
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 4 to 3. | Deep River Spirit becomes Wounded.
- Damage: Bone-Cracker Cub deals 2 to Deep River Spirit. | Deep River Spirit deals 3 to Bone-Cracker Cub.
- Result: Deep River Spirit survives, Bone-Cracker Cub removed

Main 2:
- Main 2: resolved Offering of Milk and Ash (restored 3 to Shrine of the Red Baobab)
- Main 2: prepared Root-Woven Guard

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 11 Memory
- shrine state: Shrine of the Red Baobab: 5/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Deep River Spirit [Wounded, Relic:Spear of First Dawn], Leopard Hunter, Spear of First Dawn

## Turn 27 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 4 to 3. | Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Deep River Spirit.
- Result: Bone-Cracker Cub left battle, Deep River Spirit survives

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 4 to 3.
- Damage: Deep River Spirit deals 3 to Iron Hyena Champion. | Iron Hyena Champion deals 5 to Deep River Spirit.
- Result: Iron Hyena Champion left battle, Deep River Spirit removed

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Pack Harrier, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub

## Turn 28 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 12

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Baobab Guardian, Leopard Hunter
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 6 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Bone-Fang Shrine)
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Blood-Scent Hyena deals 2 to Baobab Guardian. | Baobab Guardian deals 2 to Blood-Scent Hyena.
- Result: Baobab Guardian survives, Blood-Scent Hyena removed

Main 2:
- Main 2: played Pale River Spirit

End:
- retained card: Young Hunter
- discarded cards: Young Hunter
- forgotten cards: None
- Wounded clears: River Hunter
- resources at end: 0 Offerings / 10 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian [Wounded], Kuma Who Wounded the Sun, Pale River Spirit, River Hunter

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10]
Resources: Red 5/1 | Iron 0/10
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 6
Key events: Main 1: played Bone-Cracker Cub | Blood-Scent Hyena deals 2 to Baobab Guardian. | Baobab Guardian deals 2 to Blood-Scent Hyena. | Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Bone-Fang Shrine) | Main 1: played River Hunter | Main 2: played Pale River Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 29 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Kuma Who Wounded the Sun
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 6 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Kuma Who Wounded the Sun.
- Result: Bone-Cracker Cub left battle, Kuma Who Wounded the Sun survives

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena, Bone Spear, Iron Hyena Raider

## Turn 30 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 10

Hand before draw: [Young Hunter]

Board before ready:
Beings/Spirits: Baobab Guardian [Wounded], Kuma Who Wounded the Sun [Wounded], Pale River Spirit, River Hunter
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 6 [Hunter’s Call, Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: prepared Root-Woven Guard

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 7 to 5.
- Damage: Shrine Bone-Fang Shrine takes 5.
- Result: Kuma Who Wounded the Sun survives, Bone-Fang Shrine at 0/10

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Pale River Spirit
- discarded cards: Young Hunter, River Hunter, Baobab Guardian
- forgotten cards: None
- Wounded clears: Baobab Guardian, Kuma Who Wounded the Sun
- resources at end: 7 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Kuma Who Wounded the Sun, Pale River Spirit, River Hunter

## Turn 31 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Blood-Scent Hyena, Bone Spear, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Pack Harrier

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
- Attacker: Iron Hyena Raider
- Target: Kuma Who Wounded the Sun
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 6 to 4. | Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 4 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Kuma Who Wounded the Sun.
- Result: Iron Hyena Raider left battle, Kuma Who Wounded the Sun survives

Attack 3:
- Attacker: Blood-Scent Hyena
- Target: Kuma Who Wounded the Sun
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 6 to 4.
- Damage: Kuma Who Wounded the Sun deals 4 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Kuma Who Wounded the Sun.
- Result: Blood-Scent Hyena left battle, Kuma Who Wounded the Sun removed

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Iron Hyena Raider, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Pack Harrier

## Turn 32 — Iron

Pre-resource snapshot:
Offerings before resource: 7
Memory before resource: 8

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian, Pale River Spirit, River Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 7 [Hunter’s Call, Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 2.
- Result: Baobab Guardian survives, Iron Hyena Den at 8/10

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Pale River Spirit, Deep River Spirit
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 4 Offerings / 8 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian, Leopard Hunter, Pale River Spirit, Young Hunter

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10]
Resources: Red 6/1 | Iron 4/8
Awakened Ancestors: Red None | Iron Grandmother Beneath the Roots
Forgotten cards: Red 4 | Iron 7
Key events: Blood-Scent Hyena deals 2 to Kuma Who Wounded the Sun. | Main 1: played Bone-Cracker Cub | Main 1: played Pack Harrier | Shrine Iron Hyena Den takes 2. | Main 1: evolved River Hunter into Leopard Hunter | Main 1: played Young Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 33 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 1

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 2/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab)
- Main 1: attached Fang Relic to Bone-Cracker Cub

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
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Pack Harrier, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 2/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Hyena Champion

## Turn 34 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 8

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian, Leopard Hunter [Wounded], Pale River Spirit, Young Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 7 [Hunter’s Call, Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Iron Hyena Champion deals 5 to Leopard Hunter. | Leopard Hunter deals 3 to Iron Hyena Champion.
- Result: Leopard Hunter left battle, Iron Hyena Champion removed, Iron Hyena Den at 8/10

Attack 2:
- Attacker: Baobab Guardian
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 2.
- Result: Baobab Guardian survives, Iron Hyena Den at 6/10

Main 2:
- Main 2: attached Esprit du Léopard to Baobab Guardian
- Main 2: awakened First Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Baobab Guardian, Young Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 6 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, River Hunter, Young Hunter

## Turn 35 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone Spear
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Black-Tooth Smith

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: Black-Tooth Smith
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Relic:Fang Relic], Bone Spear, Fang Relic, Pack Harrier

## Turn 36 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 6

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, River Hunter, Young Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 7 [Hunter’s Call, Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Spear of First Dawn to Baobab Guardian

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Black-Tooth Smith deals 3 to River Hunter. | River Hunter deals 3 to Black-Tooth Smith.
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
- Main 2: attached Esprit du Léopard to Baobab Guardian

End:
- retained card: Deep River Spirit
- discarded cards: Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 8 Memory
- shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, River Hunter, Spear of First Dawn

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 4/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10]
Resources: Red 3/1 | Iron 2/8
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 7
Key events: River Hunter deals 3 to Black-Tooth Smith. | Pack Harrier deals 1 to Young Hunter. | Young Hunter deals 2 to Pack Harrier. | Main 1: played River Hunter | Main 1: attached Spear of First Dawn to Baobab Guardian | Main 2: attached Esprit du Léopard to Baobab Guardian
Tempo note: initiative reverses after every four player-turns.

## Turn 37 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone Spear
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Hyena Pack Call, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Hyena Token, Hyena Token

## Turn 38 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 8

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, River Hunter, Spear of First Dawn
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 7 [Hunter’s Call, Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 6.
- Result: Baobab Guardian survives, Iron Hyena Den at 0/10

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Spear of First Dawn
- discarded cards: Deep River Spirit, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 6 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Leopard Hunter, Pale River Spirit, Spear of First Dawn, Young Hunter

## Turn 39 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Hyena Token, Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Leopard Hunter.
- Result: Blood-Scent Hyena left battle, Leopard Hunter survives

Attack 2:
- Attacker: Hyena Token
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Hyena Token. | Hyena Token deals 1 to Leopard Hunter.
- Result: Hyena Token left battle, Leopard Hunter removed

Main 2:
- Main 2: played Pack Harrier
- Main 2: played Black-Tooth Smith

End:
- retained card: Pack Harrier
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Hyena Token, Pack Harrier

## Turn 40 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 7

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Spear of First Dawn, Young Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 7 [Hunter’s Call, Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Young Hunter

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
- Main 2: attached Spear of First Dawn to Baobab Guardian

End:
- retained card: Esprit du Léopard
- discarded cards: Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: Baobab Guardian [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, Spear of First Dawn, Spear of First Dawn, Young Hunter, Young Hunter, Young Hunter

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 10/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10]
Resources: Red 3/1 | Iron 4/7
Awakened Ancestors: Red None | Iron Grandmother Beneath the Roots
Forgotten cards: Red 4 | Iron 7
Key events: Main 2: played Black-Tooth Smith | Shrine Rusted Moon Shrine takes 5. | Shrine Rusted Moon Shrine takes 2. | Main 1: played Young Hunter | Main 1: played Young Hunter | Main 2: attached Spear of First Dawn to Baobab Guardian
Tempo note: initiative reverses after every four player-turns.

## Turn 41 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Hyena Token, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 7/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Hyena Token

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
- Attacker: Hyena Token
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 5 to 3.
- Damage: Baobab Guardian deals 3 to Hyena Token. | Hyena Token deals 2 to Baobab Guardian.
- Result: Hyena Token left battle, Baobab Guardian removed

Main 2:
- Main 2: played Pack Harrier
- Main 2: played Bone-Cracker Cub

End:
- retained card: Hyena Pack Call
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 7/10
- board at end: Bone Spear, Bone-Cracker Cub, Pack Harrier, Pack Harrier

## Turn 42 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 9

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Pale River Spirit, Spear of First Dawn, Young Hunter, Young Hunter, Young Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 7 [Hunter’s Call, Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter

Combat:

Attack 1:
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
- discarded cards: River Hunter, Baobab Guardian, Deep River Spirit
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 5 Offerings / 9 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: Leopard Hunter, Pale River Spirit, Spear of First Dawn, Young Hunter, Young Hunter

## Turn 43 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 9/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: Young Hunter
- Prepared triggers: Root-Woven Guard, Root-Woven Guard
- Wounded/Pierce calculations: Pack Harrier deals 1 to blocked Shrine.
- Damage: Young Hunter deals 2 to Pack Harrier. | Pack Harrier deals 1 to Young Hunter. | Shrine Shrine of the Red Baobab takes 1.
- Result: Pack Harrier left battle, Young Hunter removed, Shrine of the Red Baobab at 7/10

Attack 2:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | Pack Harrier deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 4 to Pack Harrier. | Pack Harrier deals 1 to Leopard Hunter. | Shrine Shrine of the Red Baobab takes 1.
- Result: Pack Harrier left battle, Leopard Hunter survives, Shrine of the Red Baobab at 6/10

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed, Shrine of the Red Baobab at 6/10

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Pack Call, Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 9/10
- board at end: Blood-Scent Hyena, Bone Spear, Iron Hyena Raider

## Turn 44 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 10

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Pale River Spirit, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 9 [Hunter’s Call, Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: played River Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 2.
- Result: Young Hunter survives, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 10 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: Pale River Spirit, River Hunter, River Hunter, Spear of First Dawn, Young Hunter

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 10/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 9/10] | Iron [Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10]
Resources: Red 4/1 | Iron 4/10
Awakened Ancestors: Red None | Iron Grandmother Beneath the Roots
Forgotten cards: Red 4 | Iron 9
Key events: Bone-Cracker Cub deals 3 to Leopard Hunter. | Main 1: played Blood-Scent Hyena | Main 1: played Iron Hyena Raider | Shrine Rusted Moon Shrine takes 2. | Main 1: played River Hunter | Main 1: played River Hunter
Tempo note: initiative reverses after every four player-turns.

## End-of-game summary

Winner: red-hunter-evolution
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Iron Hyena Den 10/10, Bone-Fang Shrine 13/10, Rusted Moon Shrine 11/10] | Iron [Shrine of the Red Baobab 3/10, Hunter’s Root-Stone 10/10, Moonlit Roots 10/10]
Final resources: Red 4/1 | Iron 4/10
Final Presence: Seat 1 2/5 | Seat 2 4/5

Turn count: 44
Phase count: 1

First Shrine damage: 3 (Seat 1/Red: 26, Seat 2/Iron: 3)
First Shrine broken: 7 (Seat 1/Red: 30, Seat 2/Iron: 7)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 0, Iron 0
First Ancestor awakened: 6
First L2: 5
First L3: 28

Red L2 entries: 4 (hard-cast 1, evolved 3)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 6 (hard-cast 2, evolved 4)
Iron L3 entries: 1 (hard-cast 0, evolved 1)

Legal evolve actions generated: Red 6, Iron 14
Legal L2 evolve actions: Red 6, Iron 12
Legal L3 evolve actions: Red 0, Iron 2
Evolve windows: Red 6, Iron 10
Turns with legal L2 evolution: Red 6, Iron 8
Turns with legal L3 evolution: Red 0, Iron 2
Evolve actions chosen: Red 6, Iron 12
Hard-cast chosen while legal evolve action existed: Red 0, Iron 1
Hard-cast chosen while evolution base existed: Red 2, Iron 11

Legal awaken actions generated: Red 0, Iron 42
Awaken actions chosen: Red 0, Iron 15
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red None, Iron red.ancestor.firsthunter
Ancestor switches: Red 0, Iron 3
Turns with awakened ancestor: Red 0, Iron 19
Memory spent on ancestors: Red 0, Iron 8
Ancestor realized value: First Hunter +3 damage, Grandmother healed 6, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 4
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 4, Iron 9
Wounded events: Red 1, Iron 16
Wounded reduced damage: Red 1, Iron 13
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 4, Iron 7
Blocks chosen: Red 1, Iron 6
Blocks declined: Red 3, Iron 0
Assault slots spent: Seat 1 standard 5, pack 20 | Seat 2 standard 24, pack 0
Pack diagnostics: Seat 1 ready-at-combat 23, generated 23, available 23, skipped 3, turns-with-bonus 16, max-attacks 67, prevented-by-limit 0
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
