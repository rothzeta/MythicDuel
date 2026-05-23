# Test Game #489

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports\matrix_runs\current_pack_vs_red --bot-red iron --bot-iron red --deck-red iron-hyena-pack-pressure --deck-iron red-hunter-evolution

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

Seed: 489
Winner: iron-hyena-pack-pressure
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting Shrines — Iron: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting hands — Red: Bite the Roots, Bone-Cracker Cub, Hyena Pack Call, Iron Hyena Champion, Pack Ambush
- Starting hands — Iron: Deep River Spirit, Offering of Milk and Ash, River Hunter, River Hunter, Young Hunter
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang
- Starting Lineage — Iron: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Bone-Cracker Cub, Hyena Pack Call, Iron Hyena Champion, Pack Ambush]

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
- discarded cards: Hyena Pack Call, Iron Hyena Champion, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Deep River Spirit, Offering of Milk and Ash, River Hunter, River Hunter, Young Hunter]

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
- discarded cards: River Hunter, River Hunter, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Hyena Token survives, Hunter’s Root-Stone at 5/10

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Bone-Cracker Cub, Iron Hyena Raider, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
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
- retained card: Leopard Hunter
- discarded cards: Deep River Spirit, Kuma Who Wounded the Sun, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
- board at end: Young Hunter

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10]
Resources: Red 0/0 | Iron 1/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 2 | Iron 0
Key events: Main 1: played Young Hunter | Shrine Hunter’s Root-Stone takes 2. | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone) | Hyena Token deals 1 to Young Hunter. | Young Hunter deals 2 to Hyena Token. | Main 1: played Young Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Ritual of Red Moon (had no legal target)
- Main 1: resolved Offering of Milk and Ash (restored 3 to Hunter’s Root-Stone)

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Young Hunter survives, Bone-Fang Shrine at 7/10

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Baobab Guardian, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Fang Relic, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Pack Harrier

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: attached Esprit du Léopard to Young Hunter
- Main 1: resolved Ritual of Red Moon (dealt 2 to Bone-Cracker Cub, destroyed it, gained 1 Memory)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Hunter’s Call, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, Young Hunter [Possession:Esprit du Léopard]

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: attached Bone Spear to Pack Harrier

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Hunter’s Root-Stone
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Pack Harrier deals 1 to blocked Shrine.
- Damage: Young Hunter deals 4 to Pack Harrier. | Pack Harrier deals 3 to Young Hunter. | Shrine Hunter’s Root-Stone takes 1.
- Result: Pack Harrier left battle, Young Hunter removed, Hunter’s Root-Stone at 5/10

Main 2:
- Main 2: played Pack Harrier

End:
- retained card: Iron Hyena Champion
- discarded cards: Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token, Pack Harrier

# End of Phase 2 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10]
Resources: Red 1/0 | Iron 0/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 3 | Iron 3
Key events: Young Hunter deals 4 to Pack Harrier. | Pack Harrier deals 3 to Young Hunter. | Shrine Hunter’s Root-Stone takes 1. | Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine) | Main 1: attached Bone Spear to Pack Harrier | Main 2: played Pack Harrier
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Hyena Token, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Pack Harrier survives, Hunter’s Root-Stone at 3/10

Attack 2:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Hyena Token survives, Hunter’s Root-Stone at 1/10

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Blood-Scent Hyena, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token, Iron Hyena Raider, Pack Harrier, Pack Harrier

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 3

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 9/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter

Combat:
- no attacks

Main 2:
- Main 2: played Deep River Spirit
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Leopard Hunter
- discarded cards: Spear of First Dawn, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 8/10, Moonlit Roots: 0/10
- board at end: Deep River Spirit, Young Hunter

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Hyena Token, Iron Hyena Raider, Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Hyena Token into Iron Hyena Champion (dealt 2 to Hunter’s Root-Stone and broke it)

Combat:
- no attacks

Main 2:
- Main 2: resolved Bite the Roots (dealt 3 to Moonlit Roots)

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Champion, Iron Hyena Raider, Pack Harrier, Pack Harrier

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Deep River Spirit, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 3/10
Forgotten zone count/list: 3 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter

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
- Attacker: Deep River Spirit
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to Deep River Spirit. | Deep River Spirit deals 3 to Iron Hyena Champion.
- Result: Deep River Spirit left battle, Iron Hyena Champion removed

Main 2:
- Main 2: prepared Hunter’s Call
- Main 2: awakened First Hunter

End:
- retained card: Leopard Hunter
- discarded cards: Pale River Spirit, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 2/10
- board at end: River Hunter

# End of Phase 3 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 2/10]
Resources: Red 1/0 | Iron 3/0
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 3
Key events: Young Hunter deals 2 to Iron Hyena Raider. | Iron Hyena Champion deals 5 to Deep River Spirit. | Deep River Spirit deals 3 to Iron Hyena Champion. | Main 1: played River Hunter | Main 2: prepared Hunter’s Call | Main 2: awakened First Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: Hunter’s Call
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 2/10
Forgotten zone count/list: 3 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Pack Harrier
- Defender/blocker: Pack Harrier
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: River Hunter becomes Wounded.
- Damage: Pack Harrier deals 1 to River Hunter. | River Hunter deals 3 to Pack Harrier.
- Result: River Hunter survives, Pack Harrier removed

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Baobab Guardian, Spear of First Dawn, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 2/10
- board at end: Leopard Hunter, River Hunter [Wounded]

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Pack Harrier
- Main 1: attached Bone Spear to Pack Harrier

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
- Main 2: played Blood-Scent Hyena
- Main 2: played Blood-Scent Hyena

End:
- retained card: Hyena Pack Call
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena, Fang Relic

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Leopard Hunter [Wounded], River Hunter [Wounded]
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 3/10
Forgotten zone count/list: 4 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 5 to 3.
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 4/10

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Esprit du Léopard, Deep River Spirit
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 3 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 3/10
- board at end: Leopard Hunter, Leopard Hunter, River Hunter

## Turn 16 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Blood-Scent Hyena, Fang Relic
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Leopard Hunter deals 4 to Blood-Scent Hyena. | Blood-Scent Hyena deals 4 to Leopard Hunter.
- Result: Blood-Scent Hyena left battle, Leopard Hunter removed, Moonlit Roots at 7/10

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 3.
- Result: Blood-Scent Hyena survives, Moonlit Roots at 4/10

Main 2:
- Main 2: played Pack Harrier
- Main 2: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Fang Relic, Hyena Token, Hyena Token, Pack Harrier

# End of Phase 4 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 3/10]
Resources: Red 4/0 | Iron 3/1
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 4
Key events: Leopard Hunter deals 4 to Blood-Scent Hyena. | Blood-Scent Hyena deals 4 to Leopard Hunter. | Shrine Moonlit Roots takes 3. | Main 1: attached Bone Spear to Blood-Scent Hyena | Main 2: played Pack Harrier | Main 2: resolved Hyena Pack Call (summoned 2 Hyena Tokens)
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Fang Relic, Hyena Token, Hyena Token, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 3.
- Result: Blood-Scent Hyena survives, Moonlit Roots at 1/10

Attack 2:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 2.
- Result: Pack Harrier survives, Moonlit Roots at 0/10

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call, Bone-Cracker Cub, Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Fang Relic, Hyena Token, Hyena Token, Iron Hyena Raider, Pack Harrier

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 2

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Leopard Hunter, River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 4 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Spear of First Dawn to Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | WeaponMaster grants Pierce. | Pierce overflow deals 7 to Bone-Fang Shrine.
- Damage: Hyena Token deals 1 to Leopard Hunter. | Leopard Hunter deals 8 to Hyena Token. | Shrine Bone-Fang Shrine takes 7.
- Result: Leopard Hunter survives, Hyena Token removed, Bone-Fang Shrine at 0/10

Attack 2:
- Attacker: River Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to River Hunter. | River Hunter deals 3 to Iron Hyena Raider.
- Result: River Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: attached Esprit du Léopard to Leopard Hunter

End:
- retained card: Pale River Spirit
- discarded cards: Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Esprit du Léopard, Leopard Hunter [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn, Young Hunter

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Fang Relic, Hyena Token, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Blood-Scent Hyena into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab)

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 1.
- Result: Pack Harrier survives, Shrine of the Red Baobab at 4/10

Attack 2:
- Attacker: Hyena Token
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 1.
- Result: Hyena Token survives, Shrine of the Red Baobab at 3/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Blood-Scent Hyena, Pack Harrier, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Hyena Token, Iron Hyena Champion, Pack Harrier

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 3

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Esprit du Léopard, Leopard Hunter [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 4 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: resolved Ritual of Red Moon (dealt 2 to Iron Hyena Champion)

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 10 to 7. | Wounded reduces Iron Hyena Champion from 5 to 3. | Leopard Hunter becomes Wounded. | WeaponMaster grants Pierce. | SoulSlayer grants Pierce. | Pierce overflow deals 6 to Iron Hyena Den.
- Damage: Iron Hyena Champion deals 3 to Leopard Hunter. | Leopard Hunter deals 7 to Iron Hyena Champion. | Shrine Iron Hyena Den takes 6.
- Result: Leopard Hunter survives, Iron Hyena Champion removed, Iron Hyena Den at 4/10

Attack 2:
- Attacker: Young Hunter
- Target: Hyena Token
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Hyena Token deals 1 to Young Hunter. | Young Hunter deals 2 to Hyena Token.
- Result: Young Hunter left battle, Hyena Token removed

Main 2:
- Main 2: resolved Offering of Milk and Ash (restored 3 to Shrine of the Red Baobab)
- Main 2: played Pale River Spirit

End:
- retained card: Hunter’s Call
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Esprit du Léopard, Leopard Hunter [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Pale River Spirit, River Hunter, Spear of First Dawn

# End of Phase 5 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10]
Resources: Red 5/0 | Iron 1/3
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 6
Key events: Hyena Token deals 1 to Young Hunter. | Young Hunter deals 2 to Hyena Token. | Main 1: played River Hunter | Main 1: resolved Ritual of Red Moon (dealt 2 to Iron Hyena Champion) | Main 2: resolved Offering of Milk and Ash (restored 3 to Shrine of the Red Baobab) | Main 2: played Pale River Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 3

Hand before draw: [Hunter’s Call]

Board before ready:
Beings/Spirits: Esprit du Léopard, Leopard Hunter [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Pale River Spirit, River Hunter, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 6 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Iron Hyena Den)
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 4.
- Result: River Hunter survives, Iron Hyena Den at 0/10

Main 2:
- Main 2: prepared Hunter’s Call

End:
- retained card: Deep River Spirit
- discarded cards: Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Esprit du Léopard, Kuma Who Wounded the Sun [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter

## Turn 22 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Fang Relic, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Pack Harrier
- Main 1: attached Bone Spear to Pack Harrier

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Kuma Who Wounded the Sun becomes Wounded. | Pack Harrier deals 1 to blocked Shrine.
- Damage: Kuma Who Wounded the Sun deals 9 to Pack Harrier. | Pack Harrier deals 2 to Kuma Who Wounded the Sun. | Shrine Shrine of the Red Baobab takes 1.
- Result: Pack Harrier left battle, Kuma Who Wounded the Sun survives, Shrine of the Red Baobab at 5/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Black-Tooth Smith
- discarded cards: Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Fang Relic, Fang Relic

## Turn 23 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Esprit du Léopard, Kuma Who Wounded the Sun [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: Hunter’s Call
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 5/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 6 [Hunter’s Call, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: attached Esprit du Léopard to River Hunter

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 12 to 9.
- Damage: Shrine Rusted Moon Shrine takes 9.
- Result: Kuma Who Wounded the Sun survives, Rusted Moon Shrine at 1/10

Attack 2:
- Attacker: River Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Black-Tooth Smith deals 2 to River Hunter. | River Hunter deals 5 to Black-Tooth Smith.
- Result: River Hunter left battle, Black-Tooth Smith removed

Main 2:
- Main 2: prepared Root-Woven Guard

End:
- retained card: Deep River Spirit
- discarded cards: Young Hunter, Baobab Guardian
- forgotten cards: None
- Wounded clears: Kuma Who Wounded the Sun
- resources at end: 5 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Esprit du Léopard, Kuma Who Wounded the Sun [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Pale River Spirit, Spear of First Dawn, Young Hunter

## Turn 24 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Fang Relic, Fang Relic
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 9/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Blood-Scent Hyena

Combat:
- no attacks

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Bone-Cracker Cub
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 9/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena, Fang Relic, Fang Relic, Pack Harrier

# End of Phase 6 Summary

Shrine state: Red [Iron Hyena Den: 13/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 9/10] | Iron [Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10]
Resources: Red 2/0 | Iron 5/2
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 7
Key events: River Hunter deals 5 to Black-Tooth Smith. | Main 1: attached Esprit du Léopard to River Hunter | Main 2: prepared Root-Woven Guard | Main 1: played Pack Harrier | Main 1: played Blood-Scent Hyena | Main 2: played Black-Tooth Smith
Tempo note: initiative reverses after every four player-turns.

## Turn 25 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Blood-Scent Hyena, Fang Relic, Fang Relic, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 9/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab)
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Shrine of the Red Baobab
- Defender/blocker: Young Hunter
- Prepared triggers: Root-Woven Guard
- Wounded/Pierce calculations: Black-Tooth Smith becomes Wounded.
- Damage: Young Hunter deals 2 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Young Hunter.
- Result: Black-Tooth Smith survives, Young Hunter removed, Shrine of the Red Baobab at 2/10

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 2.
- Result: Blood-Scent Hyena survives, Shrine of the Red Baobab at 0/10

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Pack Call, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 9/10
- board at end: Black-Tooth Smith [Wounded], Blood-Scent Hyena, Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Hyena Champion

## End-of-game summary

Winner: iron-hyena-pack-pressure
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Iron Hyena Den 13/10, Bone-Fang Shrine 13/10, Rusted Moon Shrine 9/10] | Iron [Shrine of the Red Baobab 11/10, Hunter’s Root-Stone 10/10, Moonlit Roots 11/10]
Final resources: Red 4/0 | Iron 5/2
Final Presence: Seat 1 4/5 | Seat 2 3/5

Turn count: 25
Phase count: 7

First Shrine damage: 3 (Seat 1/Red: 5, Seat 2/Iron: 3)
First Shrine broken: 11 (Seat 1/Red: 18, Seat 2/Iron: 11)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 24, Iron 16
First Ancestor awakened: 10
First L2: 11
First L3: 21

Red L2 entries: 3 (hard-cast 0, evolved 3)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 2 (hard-cast 1, evolved 1)
Iron L3 entries: 1 (hard-cast 0, evolved 1)

Legal evolve actions generated: Red 10, Iron 4
Legal L2 evolve actions: Red 10, Iron 2
Legal L3 evolve actions: Red 0, Iron 2
Evolve windows: Red 6, Iron 4
Turns with legal L2 evolution: Red 6, Iron 2
Turns with legal L3 evolution: Red 0, Iron 2
Evolve actions chosen: Red 8, Iron 4
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 1, Iron 9

Legal awaken actions generated: Red 0, Iron 8
Awaken actions chosen: Red 0, Iron 5
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red None, Iron red.ancestor.grandmother
Ancestor switches: Red 0, Iron 1
Turns with awakened ancestor: Red 0, Iron 7
Memory spent on ancestors: Red 0, Iron 4
Ancestor realized value: First Hunter +5 damage, Grandmother healed 1, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 3
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 4, Iron 8
Wounded events: Red 2, Iron 5
Wounded reduced damage: Red 1, Iron 3
Pierce overflow events: Red 0, Iron 2
WeaponMaster Pierce events: 2
SoulSlayer Pierce events: 1
Legal block options: Red 3, Iron 5
Blocks chosen: Red 2, Iron 5
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 3, pack 11 | Seat 2 standard 13, pack 0
Pack diagnostics: Seat 1 ready-at-combat 16, generated 15, available 15, skipped 4, turns-with-bonus 9, max-attacks 41, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 24, prevented-by-limit 0
Deck reshuffles: Red 1, Iron 2

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
