# Test Game #479

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

Seed: 479
Winner: red-hunter-evolution
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting Shrines — Iron: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting hands — Red: Blood-Scent Hyena, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Pack Harrier
- Starting hands — Iron: Esprit du Léopard, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Young Hunter
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang
- Starting Lineage — Iron: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Pack Harrier]

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
- retained card: Fang Relic
- discarded cards: Pack Harrier, Bone-Cracker Cub, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Esprit du Léopard, Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Young Hunter]

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
- discarded cards: Ritual of Red Moon, Hunter’s Call, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 4.
- Result: Bone-Cracker Cub survives, Hunter’s Root-Stone at 3/10

Main 2:
- pass

End:
- retained card: Pack Ambush
- discarded cards: Fang Relic, Iron Hyena Raider, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
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
- retained card: Leopard Hunter
- discarded cards: Esprit du Léopard, Deep River Spirit, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
- board at end: River Hunter

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10]
Resources: Red 0/0 | Iron 0/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 0
Key events: Main 1: played Young Hunter | Shrine Hunter’s Root-Stone takes 4. | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone) | Bone-Cracker Cub deals 2 to Young Hunter. | Young Hunter deals 2 to Bone-Cracker Cub. | Main 1: played River Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Pack Ambush]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone, broke it, gained 1 Memory)
- Main 1: resolved Pack Ambush (summoned Hyena Token)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token

## Turn 6 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Hyena Token
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: River Hunter becomes Wounded.
- Damage: Hyena Token deals 1 to River Hunter. | River Hunter deals 3 to Hyena Token.
- Result: River Hunter survives, Hyena Token removed

Main 2:
- Main 2: prepared Root-Woven Guard

End:
- retained card: Leopard Hunter
- discarded cards: Pale River Spirit, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
- board at end: River Hunter, River Hunter [Wounded]

## Turn 7 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Pack Harrier

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Black-Tooth Smith, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Pack Harrier

## Turn 8 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter, River Hunter [Wounded]
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter
- Main 1: played Young Hunter

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
- retained card: Esprit du Léopard
- discarded cards: Baobab Guardian, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, Young Hunter

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10]
Resources: Red 2/1 | Iron 0/1
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 3 | Iron 0
Key events: Main 1: played Pack Harrier | Bone-Cracker Cub deals 2 to River Hunter. | River Hunter deals 3 to Bone-Cracker Cub. | Main 1: evolved River Hunter into Leopard Hunter | Main 1: played Young Hunter | Main 2: awakened First Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Pack Harrier
- Main 1: attached Bone Spear to Pack Harrier

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: Root-Woven Guard
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | Pack Harrier deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 4 to Pack Harrier. | Pack Harrier deals 2 to Leopard Hunter. | Shrine Moonlit Roots takes 1.
- Result: Pack Harrier left battle, Leopard Hunter survives, Moonlit Roots at 9/10

Main 2:
- Main 2: played Blood-Scent Hyena

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Fang Relic

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Leopard Hunter [Wounded], Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 1/10
Forgotten zone count/list: 1 [Root-Woven Guard]

Main 1:
- Main 1: played Leopard Hunter

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
- discarded cards: Spear of First Dawn, Baobab Guardian, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 0 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 1/10
- board at end: Leopard Hunter, Leopard Hunter

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Fang Relic
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Hyena Pack Call
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Relic:Bone Spear], Bone Spear, Bone-Cracker Cub, Fang Relic, Pack Harrier

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 2

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Leopard Hunter, Leopard Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 1/10
Forgotten zone count/list: 1 [Root-Woven Guard]

Main 1:
- Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Bone-Fang Shrine)

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 5.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 0/10

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit, Spear of First Dawn, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 1/10
- board at end: Kuma Who Wounded the Sun, Leopard Hunter

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 1/10]
Resources: Red 1/1 | Iron 2/0
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 3 | Iron 1
Key events: Main 1: played Leopard Hunter | Main 1: played Pack Harrier | Main 1: played Bone-Cracker Cub | Main 2: played Black-Tooth Smith | Shrine Bone-Fang Shrine takes 5. | Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Bone-Fang Shrine)
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Relic:Bone Spear], Bone Spear, Bone-Cracker Cub, Fang Relic, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Moonlit Roots
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 6 to Black-Tooth Smith. | Black-Tooth Smith deals 3 to Kuma Who Wounded the Sun.
- Result: Black-Tooth Smith left battle, Kuma Who Wounded the Sun survives, Moonlit Roots at 9/10

Attack 2:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 6 to 4. | Kuma Who Wounded the Sun becomes Wounded. | Pack Harrier deals 1 to blocked Shrine.
- Damage: Kuma Who Wounded the Sun deals 4 to Pack Harrier. | Pack Harrier deals 1 to Kuma Who Wounded the Sun. | Shrine Moonlit Roots takes 1.
- Result: Pack Harrier left battle, Kuma Who Wounded the Sun survives, Moonlit Roots at 8/10

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 6 to 4.
- Damage: Kuma Who Wounded the Sun deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Kuma Who Wounded the Sun.
- Result: Bone-Cracker Cub left battle, Kuma Who Wounded the Sun removed, Moonlit Roots at 8/10

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Hyena Pack Call, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Fang Relic, Iron Hyena Raider

## Turn 14 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Leopard Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 2/10
Forgotten zone count/list: 2 [Kuma Who Wounded the Sun, Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 5.
- Result: Leopard Hunter survives, Iron Hyena Den at 5/10

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Ritual of Red Moon, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 2/10
- board at end: Leopard Hunter, Leopard Hunter, Young Hunter

## Turn 15 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Fang Relic, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 5/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: attached Bone Spear to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Leopard Hunter deals 4 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Leopard Hunter.
- Result: Iron Hyena Raider left battle, Leopard Hunter removed, Moonlit Roots at 7/10

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 2.
- Result: Blood-Scent Hyena survives, Moonlit Roots at 5/10

Main 2:
- Main 2: played Iron Hyena Champion
- Main 2: played Bone-Cracker Cub

End:
- retained card: Bone-Cracker Cub
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 5/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub, Fang Relic, Hyena Token, Iron Hyena Champion

## Turn 16 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 2

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Leopard Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 5/10
Forgotten zone count/list: 2 [Kuma Who Wounded the Sun, Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Spear of First Dawn to Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 8.
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

End:
- retained card: Pale River Spirit
- discarded cards: Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 5/10
- board at end: Esprit du Léopard, Leopard Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn, Young Hunter

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 5/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 5/10]
Resources: Red 0/1 | Iron 3/2
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 2
Key events: Shrine Iron Hyena Den takes 8. | Blood-Scent Hyena deals 2 to Young Hunter. | Young Hunter deals 2 to Blood-Scent Hyena. | Main 1: played Young Hunter | Main 1: attached Spear of First Dawn to Leopard Hunter | Main 2: attached Esprit du Léopard to Leopard Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Fang Relic, Hyena Token, Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 1.
- Result: Hyena Token survives, Moonlit Roots at 4/10

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 6.
- Result: Iron Hyena Champion survives, Moonlit Roots at 0/10

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: played Pack Harrier

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Fang Relic, Hyena Token, Iron Hyena Champion [Relic:Fang Relic], Pack Harrier

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 2

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Esprit du Léopard, Leopard Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 12/10
Forgotten zone count/list: 2 [Kuma Who Wounded the Sun, Root-Woven Guard]

Main 1:
- Main 1: played River Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | WeaponMaster grants Pierce. | SoulSlayer grants Pierce. | Pierce overflow deals 9 to Rusted Moon Shrine.
- Damage: Bone-Cracker Cub deals 2 to Leopard Hunter. | Leopard Hunter deals 10 to Bone-Cracker Cub. | Shrine Rusted Moon Shrine takes 9.
- Result: Leopard Hunter survives, Bone-Cracker Cub removed, Rusted Moon Shrine at 1/10

Main 2:
- Main 2: played Pale River Spirit
- Main 2: prepared Hunter’s Call

End:
- retained card: Deep River Spirit
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 12/10
- board at end: Esprit du Léopard, Leopard Hunter [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Pale River Spirit, River Hunter, River Hunter, Spear of First Dawn, Young Hunter

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Fang Relic, Fang Relic, Hyena Token, Iron Hyena Champion [Relic:Fang Relic], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 9/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Shrine of the Red Baobab
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Hyena Champion becomes Wounded.
- Damage: Young Hunter deals 2 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Young Hunter.
- Result: Iron Hyena Champion survives, Young Hunter removed, Shrine of the Red Baobab at 7/10

Attack 2:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 1.
- Result: Pack Harrier survives, Shrine of the Red Baobab at 6/10

Attack 3:
- Attacker: Hyena Token
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 1.
- Result: Hyena Token survives, Shrine of the Red Baobab at 5/10

Attack 4:
- Attacker: Bone-Cracker Cub
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 3.
- Result: Bone-Cracker Cub survives, Shrine of the Red Baobab at 2/10

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call, Bone-Cracker Cub, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 7 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 9/10
- board at end: Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Fang Relic, Hyena Token, Iron Hyena Champion [Wounded, Relic:Fang Relic], Pack Harrier

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 3

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Esprit du Léopard, Leopard Hunter [Wounded, Relic:Spear of First Dawn, Possession:Esprit du Léopard], Pale River Spirit, River Hunter, River Hunter, Spear of First Dawn
Prepared Tactic: Hunter’s Call
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 8/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 12/10
Forgotten zone count/list: 2 [Kuma Who Wounded the Sun, Root-Woven Guard]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Spear of First Dawn to Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 10 to 7.
- Damage: Shrine Rusted Moon Shrine takes 7.
- Result: Leopard Hunter survives, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Offering of Milk and Ash
- discarded cards: Deep River Spirit, Baobab Guardian
- forgotten cards: None
- Wounded clears: River Hunter, Leopard Hunter
- resources at end: 4 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 8/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 12/10
- board at end: Esprit du Léopard, Leopard Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Pale River Spirit, River Hunter, River Hunter, River Hunter, Spear of First Dawn, Spear of First Dawn

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 13/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 9/10] | Iron [Shrine of the Red Baobab: 8/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 12/10]
Resources: Red 7/1 | Iron 4/3
Awakened Ancestors: Red None | Iron First Hunter
Forgotten cards: Red 4 | Iron 3
Key events: Shrine Shrine of the Red Baobab takes 1. | Shrine Shrine of the Red Baobab takes 3. | Main 1: played Bone-Cracker Cub | Shrine Rusted Moon Shrine takes 7. | Main 1: played River Hunter | Main 1: attached Spear of First Dawn to Leopard Hunter
Tempo note: initiative reverses after every four player-turns.

## End-of-game summary

Winner: red-hunter-evolution
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Iron Hyena Den 13/10, Bone-Fang Shrine 11/10, Rusted Moon Shrine 16/10] | Iron [Shrine of the Red Baobab 8/10, Hunter’s Root-Stone 10/10, Moonlit Roots 12/10]
Final resources: Red 7/1 | Iron 4/3
Final Presence: Seat 1 5/5 | Seat 2 5/5

Turn count: 20
Phase count: 1

First Shrine damage: 3 (Seat 1/Red: 10, Seat 2/Iron: 3)
First Shrine broken: 5 (Seat 1/Red: 12, Seat 2/Iron: 5)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 0, Iron 0
First Ancestor awakened: 8
First L2: 8
First L3: 12

Red L2 entries: 1 (hard-cast 1, evolved 0)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 3 (hard-cast 2, evolved 1)
Iron L3 entries: 1 (hard-cast 0, evolved 1)

Legal evolve actions generated: Red 0, Iron 4
Legal L2 evolve actions: Red 0, Iron 2
Legal L3 evolve actions: Red 0, Iron 2
Evolve windows: Red 0, Iron 4
Turns with legal L2 evolution: Red 0, Iron 2
Turns with legal L3 evolution: Red 0, Iron 2
Evolve actions chosen: Red 0, Iron 4
Hard-cast chosen while legal evolve action existed: Red 1, Iron 0
Hard-cast chosen while evolution base existed: Red 1, Iron 3

Legal awaken actions generated: Red 0, Iron 6
Awaken actions chosen: Red 0, Iron 4
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red None, Iron red.ancestor.firsthunter
Ancestor switches: Red 0, Iron 0
Turns with awakened ancestor: Red 0, Iron 6
Memory spent on ancestors: Red 0, Iron 2
Ancestor realized value: First Hunter +6 damage, Grandmother healed 0, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 2
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 4, Iron 3
Wounded events: Red 1, Iron 5
Wounded reduced damage: Red 0, Iron 4
Pierce overflow events: Red 0, Iron 1
WeaponMaster Pierce events: 1
SoulSlayer Pierce events: 1
Legal block options: Red 1, Iron 6
Blocks chosen: Red 1, Iron 6
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 2, pack 11 | Seat 2 standard 11, pack 0
Pack diagnostics: Seat 1 ready-at-combat 11, generated 11, available 11, skipped 0, turns-with-bonus 6, max-attacks 31, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 20, prevented-by-limit 0
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
