# Test Game #128

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

Seed: 128
Winner: red-hunter-evolution
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Deep River Spirit, Ritual of Red Moon, River Hunter, Root-Woven Guard, Young Hunter
- Starting hands — Iron: Blood-Scent Hyena, Bone-Cracker Cub, Bone-Cracker Cub, Hyena Pack Call, Hyena Pack Call
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Deep River Spirit, Ritual of Red Moon, River Hunter, Root-Woven Guard, Young Hunter]

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
- discarded cards: River Hunter, Deep River Spirit, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena, Bone-Cracker Cub, Bone-Cracker Cub, Hyena Pack Call, Hyena Pack Call]

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
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call, Hyena Pack Call, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

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
- Main 1: attached Spear of First Dawn to Young Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to Young Hunter. | Young Hunter deals 3 to Bone-Cracker Cub.
- Result: Young Hunter left battle, Bone-Cracker Cub removed

Main 2:
- pass

End:
- retained card: Ritual of Red Moon
- discarded cards: Ritual of Red Moon, Offering of Milk and Ash, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: 

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

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
- discarded cards: Blood-Scent Hyena, Iron Hyena Champion, Bone Spear
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
Key events: Main 1: played Young Hunter | Main 1: played Bone-Cracker Cub | Bone-Cracker Cub deals 2 to Young Hunter. | Young Hunter deals 3 to Bone-Cracker Cub. | Main 1: attached Spear of First Dawn to Young Hunter | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Ritual of Red Moon, Spear of First Dawn
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: River Hunter, Young Hunter

## Turn 6 — Iron

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
- Main 1: played Bone-Cracker Cub
- Main 1: played Blood-Scent Hyena

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Hyena Pack Call, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

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
- Result: Blood-Scent Hyena survives, Hunter’s Root-Stone at 2/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 4.
- Result: Bone-Cracker Cub survives, Hunter’s Root-Stone at 0/10

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Black-Tooth Smith, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena, Bone-Cracker Cub

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

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
- Main 2: awakened First Hunter

End:
- retained card: Leopard Hunter
- discarded cards: Pale River Spirit, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: River Hunter, Young Hunter

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/0 | Iron 0/1
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 0 | Iron 2
Key events: Main 1: played Blood-Scent Hyena | Blood-Scent Hyena deals 2 to Young Hunter. | Young Hunter deals 4 to Blood-Scent Hyena. | Main 1: played Young Hunter | Main 1: attached Esprit du Léopard to Young Hunter | Main 2: awakened First Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab)
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Shrine of the Red Baobab
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: River Hunter deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to River Hunter.
- Result: Blood-Scent Hyena left battle, River Hunter removed, Shrine of the Red Baobab at 6/10

Main 2:
- pass

End:
- retained card: Pack Harrier
- discarded cards: Iron Hyena Raider, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token, Iron Hyena Champion

## Turn 10 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
Forgotten zone count/list: 0 []

Main 1:
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
- retained card: Leopard Hunter
- discarded cards: Hunter’s Call, Kuma Who Wounded the Sun, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
- board at end: Leopard Hunter

## Turn 11 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Champion
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Leopard Hunter deals 4 to Iron Hyena Champion. | Iron Hyena Champion deals 7 to Leopard Hunter.
- Result: Iron Hyena Champion left battle, Leopard Hunter removed, Shrine of the Red Baobab at 7/10

Main 2:
- Main 2: played Pack Harrier

End:
- retained card: Black-Tooth Smith
- discarded cards: Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Pack Harrier, Pack Harrier

## Turn 12 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played River Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Pale River Spirit, Root-Woven Guard, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
- board at end: River Hunter

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 4/1 | Iron 3/1
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 0 | Iron 3
Key events: Leopard Hunter deals 4 to Iron Hyena Champion. | Iron Hyena Champion deals 7 to Leopard Hunter. | Main 1: attached Bone Spear to Iron Hyena Champion | Main 1: played Pack Harrier | Main 2: played Pack Harrier | Main 1: played River Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Leopard Hunter
- Main 1: resolved Ritual of Red Moon (dealt 2 to Pack Harrier, destroyed it, gained 1 Memory)

Combat:
- no attacks

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Deep River Spirit
- discarded cards: Baobab Guardian, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, River Hunter

## Turn 14 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Pack Harrier
- Main 1: attached Fang Relic to Pack Harrier

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Pack Harrier deals 1 to blocked Shrine.
- Damage: River Hunter deals 3 to Pack Harrier. | Pack Harrier deals 3 to River Hunter. | Shrine Shrine of the Red Baobab takes 1.
- Result: Pack Harrier left battle, River Hunter removed, Shrine of the Red Baobab at 8/10

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Blood-Scent Hyena
- discarded cards: Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Fang Relic

## Turn 15 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Leopard Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Spear of First Dawn to Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 7.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 3/10

Main 2:
- Main 2: played Deep River Spirit

End:
- retained card: Deep River Spirit
- discarded cards: Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
- board at end: Deep River Spirit, Leopard Hunter [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter

## Turn 16 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token)
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 3.
- Result: Black-Tooth Smith survives, Moonlit Roots at 6/10

Main 2:
- Main 2: played Pack Harrier

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena, Fang Relic, Hyena Token, Pack Harrier

# End of Phase 3 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/0 | Iron 4/1
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Ancestor of the First Pack
Forgotten cards: Red 1 | Iron 4
Key events: Main 1: attached Spear of First Dawn to Leopard Hunter | Main 2: played Deep River Spirit | Shrine Moonlit Roots takes 3. | Main 1: resolved Pack Ambush (summoned Hyena Token) | Main 1: played Blood-Scent Hyena | Main 2: played Pack Harrier
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Deep River Spirit, Leopard Hunter [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 4/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 7.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 0/10

Attack 2:
- Attacker: Young Hunter
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Blood-Scent Hyena deals 2 to Young Hunter. | Young Hunter deals 2 to Blood-Scent Hyena.
- Result: Young Hunter left battle, Blood-Scent Hyena removed

Main 2:
- Main 2: attached Spear of First Dawn to Leopard Hunter

End:
- retained card: Deep River Spirit
- discarded cards: Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 3/10
- board at end: Deep River Spirit, Leopard Hunter [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Fang Relic, Hyena Token, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Moonlit Roots)
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 2.
- Result: Black-Tooth Smith survives, Moonlit Roots at 3/10

Attack 2:
- Attacker: Hyena Token
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 1.
- Result: Hyena Token survives, Moonlit Roots at 2/10

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Bone-Cracker Cub, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena, Fang Relic, Hyena Token, Iron Hyena Champion

## Turn 19 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 2

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Blood-Scent Hyena, Fang Relic, Hyena Token, Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Champion

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
- Main 2: played Blood-Scent Hyena
- Main 2: awakened Smith Who Passed the Fang

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear, Fang Relic, Hyena Token, Iron Hyena Champion [Relic:Bone Spear]

## Turn 20 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Deep River Spirit, Leopard Hunter [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | WeaponMaster grants Pierce. | Pierce overflow deals 6 to Iron Hyena Den.
- Damage: Hyena Token deals 1 to Leopard Hunter. | Leopard Hunter deals 7 to Hyena Token. | Shrine Iron Hyena Den takes 6.
- Result: Leopard Hunter survives, Hyena Token removed, Iron Hyena Den at 4/10

Attack 2:
- Attacker: River Hunter
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 6 to River Hunter. | River Hunter deals 3 to Iron Hyena Champion.
- Result: River Hunter left battle, Iron Hyena Champion removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit, Baobab Guardian, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Deep River Spirit, Leopard Hunter, Leopard Hunter [Wounded, Relic:Spear of First Dawn], Spear of First Dawn, Spear of First Dawn

# End of Phase 4 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/1 | Iron 5/1
Awakened Ancestors: Red First Hunter | Iron Smith Who Passed the Fang
Forgotten cards: Red 1 | Iron 4
Key events: Leopard Hunter deals 7 to Hyena Token. | Shrine Iron Hyena Den takes 6. | Iron Hyena Champion deals 6 to River Hunter. | River Hunter deals 3 to Iron Hyena Champion. | Main 1: evolved Young Hunter into Leopard Hunter | Main 2: awakened First Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Blood-Scent Hyena, Blood-Scent Hyena [Relic:Bone Spear], Bone Spear, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Smith Who Passed the Fang
Shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Bone-Cracker Cub

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
- Attacker: Blood-Scent Hyena
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Leopard Hunter.
- Result: Blood-Scent Hyena left battle, Leopard Hunter removed, Shrine of the Red Baobab at 8/10

Attack 3:
- Attacker: Blood-Scent Hyena
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 3.
- Result: Blood-Scent Hyena survives, Shrine of the Red Baobab at 4/10

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Iron Hyena Champion
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena [Relic:Bone Spear], Bone Spear, Bone-Cracker Cub, Fang Relic, Pack Harrier

## Turn 22 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 1

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Deep River Spirit, Leopard Hunter [Wounded, Relic:Spear of First Dawn], Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Esprit du Léopard to Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 10 to 7.
- Damage: Shrine Iron Hyena Den takes 7.
- Result: Leopard Hunter survives, Iron Hyena Den at 0/10

Attack 2:
- Attacker: Deep River Spirit
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Black-Tooth Smith deals 2 to Deep River Spirit. | Deep River Spirit deals 3 to Black-Tooth Smith.
- Result: Deep River Spirit survives, Black-Tooth Smith removed

Main 2:
- Main 2: resolved Ritual of Red Moon (dealt 2 to Blood-Scent Hyena, destroyed it, gained 1 Memory)

End:
- retained card: Pale River Spirit
- discarded cards: Root-Woven Guard
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 2 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Deep River Spirit [Wounded], Esprit du Léopard, Leopard Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], River Hunter, Spear of First Dawn, Spear of First Dawn

## Turn 23 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Fang Relic, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab)
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 1.
- Result: Pack Harrier survives, Shrine of the Red Baobab at 1/10

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Pack Call, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Iron Hyena Champion, Pack Harrier, Pack Harrier

## Turn 24 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Deep River Spirit [Wounded], Esprit du Léopard, Leopard Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], River Hunter, Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 9/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 2 [Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: resolved Ritual of Red Moon (dealt 2 to Iron Hyena Champion)

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 5 to 3. | Leopard Hunter becomes Wounded. | WeaponMaster grants Pierce. | SoulSlayer grants Pierce. | Pierce overflow deals 9 to Rusted Moon Shrine.
- Damage: Iron Hyena Champion deals 3 to Leopard Hunter. | Leopard Hunter deals 10 to Iron Hyena Champion. | Shrine Rusted Moon Shrine takes 9.
- Result: Leopard Hunter survives, Iron Hyena Champion removed, Rusted Moon Shrine at 1/10

Main 2:
- Main 2: resolved Offering of Milk and Ash (restored 3 to Shrine of the Red Baobab)

End:
- retained card: Pale River Spirit
- discarded cards: Root-Woven Guard
- forgotten cards: None
- Wounded clears: Deep River Spirit
- resources at end: 4 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Deep River Spirit, Esprit du Léopard, Leopard Hunter [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter

# End of Phase 4 Summary

Shrine state: Red [Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10] | Iron [Iron Hyena Den: 13/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10]
Resources: Red 4/0 | Iron 4/0
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 4 | Iron 4
Key events: Iron Hyena Champion deals 3 to Leopard Hunter. | Leopard Hunter deals 10 to Iron Hyena Champion. | Shrine Rusted Moon Shrine takes 9. | Main 1: played Young Hunter | Main 1: resolved Ritual of Red Moon (dealt 2 to Iron Hyena Champion) | Main 2: resolved Offering of Milk and Ash (restored 3 to Shrine of the Red Baobab)
Tempo note: initiative reverses after every four player-turns.

## Turn 25 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 0

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Deep River Spirit, Esprit du Léopard, Leopard Hunter [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
Forgotten zone count/list: 4 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 10 to 7.
- Damage: Shrine Rusted Moon Shrine takes 7.
- Result: Leopard Hunter survives, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Pale River Spirit, Esprit du Léopard, Hunter’s Call
- forgotten cards: None
- Wounded clears: Leopard Hunter, Leopard Hunter
- resources at end: 5 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 6/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 10/10
- board at end: Deep River Spirit, Esprit du Léopard, Leopard Hunter, Leopard Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], River Hunter, Spear of First Dawn, Spear of First Dawn

## End-of-game summary

Winner: red-hunter-evolution
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Shrine of the Red Baobab 6/10, Hunter’s Root-Stone 12/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 13/10, Bone-Fang Shrine 14/10, Rusted Moon Shrine 16/10]
Final resources: Red 5/0 | Iron 4/0
Final Presence: Seat 1 4/5 | Seat 2 2/5

Turn count: 25
Phase count: 5

First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 15)
First Shrine broken: 7 (Seat 1/Red: 7, Seat 2/Iron: 17)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 16, Iron 18
First Ancestor awakened: 8
First L2: 9
First L3: 

Red L2 entries: 4 (hard-cast 2, evolved 2)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 3 (hard-cast 0, evolved 3)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 4, Iron 6
Legal L2 evolve actions: Red 4, Iron 6
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 4, Iron 6
Turns with legal L2 evolution: Red 4, Iron 6
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 3, Iron 6
Hard-cast chosen while legal evolve action existed: Red 2, Iron 0
Hard-cast chosen while evolution base existed: Red 6, Iron 2

Legal awaken actions generated: Red 4, Iron 5
Awaken actions chosen: Red 3, Iron 4
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.firsthunter, Iron iron.ancestor.firstpack
Ancestor switches: Red 2, Iron 2
Turns with awakened ancestor: Red 9, Iron 5
Memory spent on ancestors: Red 6, Iron 6
Ancestor realized value: First Hunter +3 damage, Grandmother healed 3, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 4, Iron 4
Wounded events: Red 4, Iron 1
Wounded reduced damage: Red 3, Iron 1
Pierce overflow events: Red 2, Iron 0
WeaponMaster Pierce events: 2
SoulSlayer Pierce events: 1
Legal block options: Red 6, Iron 4
Blocks chosen: Red 5, Iron 2
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 12, pack 0 | Seat 2 standard 4, pack 9
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 26, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 13, generated 13, available 13, skipped 4, turns-with-bonus 8, max-attacks 37, prevented-by-limit 0
Deck reshuffles: Red 2, Iron 1

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
