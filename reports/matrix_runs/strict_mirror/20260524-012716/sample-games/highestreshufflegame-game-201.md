# Test Game #201

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports\matrix_runs\strict_mirror --bot-red iron --bot-iron iron --deck-red iron-hyena-pack-pressure --deck-iron iron-hyena-pack-pressure --rules strict-alternation

Seat 1:
- iron-hyena-pack-pressure [Iron] (IronHyenaBot)
Seat 2:
- iron-hyena-pack-pressure [Iron] (IronHyenaBot)

Rules variant:
- Draw model: retain up to 1, discard rest, draw to 5
- Phase model: reverse every 4 player-turns
- Combat model: 2 standard Assault slots, plus Pack expansion up to 5 total attacks, separate resolution
- Battlefield capacity: 5 Presence per seat
- Prepared model: max 1 active tactic per player
- Special mechanics: Fade, Forgotten, Wounded, Pierce, Disperse, Possession, Evolution, Recall, Unique, Pack

Seed: 201
Winner: iron-hyena-pack-pressure
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Blood-Scent Hyena, Bone-Cracker Cub, Hyena Pack Call, Iron Hyena Raider, Pack Ambush
- Starting hands — Iron: Black-Tooth Smith, Black-Tooth Smith, Fang Relic, Hyena Pack Call, Pack Harrier
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena, Bone-Cracker Cub, Hyena Pack Call, Iron Hyena Raider, Pack Ambush]

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
- retained card: Blood-Scent Hyena
- discarded cards: Bone-Cracker Cub, Hyena Pack Call, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith, Black-Tooth Smith, Fang Relic, Hyena Pack Call, Pack Harrier]

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
- retained card: Fang Relic
- discarded cards: Black-Tooth Smith, Black-Tooth Smith, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Pack Harrier

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Hyena Token

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 2.
- Result: Hyena Token survives, Bone-Fang Shrine at 8/10

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Bone-Cracker Cub, Hyena Pack Call, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Hyena Token [Relic:Fang Relic]

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 2/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 2.
- Result: Pack Harrier survives, Bone-Fang Shrine at 5/10

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Fang Relic, Pack Harrier, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 2/10, Rusted Moon Shrine: 0/10
- board at end: Pack Harrier

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 2/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 1
Key events: Main 1: resolved Pack Ambush (summoned Hyena Token) | Main 1: played Pack Harrier | Shrine Bone-Fang Shrine takes 2. | Main 1: attached Fang Relic to Hyena Token | Shrine Bone-Fang Shrine takes 2. | Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Fang Relic, Hyena Token [Relic:Fang Relic]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: evolved Hyena Token into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Blood-Scent Hyena, Blood-Scent Hyena, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Iron Hyena Champion [Relic:Fang Relic]

## Turn 6 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Iron Hyena Raider, Blood-Scent Hyena, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Champion

## Turn 7 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Fang Relic, Iron Hyena Champion [Relic:Fang Relic]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Champion
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Bone-Fang Shrine
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to Iron Hyena Champion. | Iron Hyena Champion deals 7 to Iron Hyena Champion.
- Result: Iron Hyena Champion left battle, Iron Hyena Champion removed, Bone-Fang Shrine at 6/10

Main 2:
- Main 2: played Blood-Scent Hyena

End:
- retained card: Iron Hyena Champion
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Fang Relic, Pack Harrier

## Turn 8 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine, broke it, gained 1 Memory)
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Bone Spear, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/2
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 2
Key events: Iron Hyena Champion deals 7 to Iron Hyena Champion. | Main 1: attached Bone Spear to Iron Hyena Champion | Main 1: played Pack Harrier | Main 2: played Blood-Scent Hyena | Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine, broke it, gained 1 Memory) | Main 1: played Iron Hyena Raider
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Fang Relic, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 1.
- Result: Pack Harrier survives, Bone-Fang Shrine at 5/10

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Blood-Scent Hyena survives, Bone-Fang Shrine at 2/10

Main 2:
- Main 2: played Iron Hyena Raider

End:
- retained card: Iron Hyena Champion
- discarded cards: Black-Tooth Smith, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena [Relic:Fang Relic], Fang Relic, Fang Relic, Iron Hyena Raider, Pack Harrier

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 2

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 2/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Raider
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 4.
- Result: Iron Hyena Raider survives, Iron Hyena Den at 6/10

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 2/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub, Iron Hyena Raider [Relic:Bone Spear]

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Blood-Scent Hyena [Relic:Fang Relic], Fang Relic, Fang Relic, Iron Hyena Raider, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine and broke it)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Pack Ambush
- discarded cards: Black-Tooth Smith, Pack Harrier, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena [Relic:Fang Relic], Fang Relic, Fang Relic, Iron Hyena Champion, Iron Hyena Raider

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub, Iron Hyena Raider [Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 2/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: evolved Iron Hyena Raider into Iron Hyena Champion (dealt 2 to Iron Hyena Den)

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 2.
- Result: Blood-Scent Hyena survives, Iron Hyena Den at 2/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Iron Hyena Den
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: Ancestor of the First Pack deals 1 to blocked Shrine.
- Damage: Blood-Scent Hyena deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Blood-Scent Hyena. | Shrine Iron Hyena Den takes 1.
- Result: Bone-Cracker Cub left battle, Blood-Scent Hyena removed, Iron Hyena Den at 1/10

Main 2:
- Main 2: played Pack Harrier

End:
- retained card: Fang Relic
- discarded cards: Hyena Pack Call, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 2/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Iron Hyena Champion [Relic:Bone Spear], Pack Harrier

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 4/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 2/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/0 | Iron 2/2
Awakened Ancestors: Red None | Iron Ancestor of the First Pack
Forgotten cards: Red 1 | Iron 2
Key events: Shrine Iron Hyena Den takes 2. | Blood-Scent Hyena deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Blood-Scent Hyena. | Shrine Iron Hyena Den takes 1. | Main 1: evolved Iron Hyena Raider into Iron Hyena Champion (dealt 2 to Iron Hyena Den) | Main 2: played Pack Harrier
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Pack Ambush]

Board before ready:
Beings/Spirits: Fang Relic, Iron Hyena Champion, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den)
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 3.
- Result: Iron Hyena Raider survives, Iron Hyena Den at 1/10

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 6 to Iron Hyena Champion. | Iron Hyena Champion deals 5 to Iron Hyena Champion.
- Result: Iron Hyena Champion left battle, Iron Hyena Champion removed, Iron Hyena Den at 1/10

Main 2:
- Main 2: played Iron Hyena Raider

End:
- retained card: Bone Spear
- discarded cards: Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
- board at end: Fang Relic, Hyena Token, Iron Hyena Raider, Iron Hyena Raider

## Turn 14 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 2

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: attached Fang Relic to Blood-Scent Hyena

Combat:
- no attacks

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: played Bone-Cracker Cub
- Main 2: awakened Smith Who Passed the Fang

End:
- retained card: Blood-Scent Hyena
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena [Relic:Fang Relic], Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Hyena Token, Pack Harrier

## Turn 15 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Fang Relic, Hyena Token, Iron Hyena Raider, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den, broke it, gained 1 Memory)
- Main 1: attached Bone Spear to Iron Hyena Raider

Combat:
- no attacks

Main 2:
- Main 2: played Pack Harrier

End:
- retained card: Fang Relic
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
- board at end: Bone Spear, Fang Relic, Hyena Token, Iron Hyena Raider, Iron Hyena Raider [Relic:Bone Spear], Pack Harrier

## Turn 16 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Blood-Scent Hyena [Relic:Fang Relic], Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Hyena Token, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Smith Who Passed the Fang
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: attached Bone Spear to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 3.
- Result: Blood-Scent Hyena survives, Rusted Moon Shrine at 4/10

Attack 2:
- Attacker: Pack Harrier
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 1.
- Result: Pack Harrier survives, Rusted Moon Shrine at 3/10

Attack 3:
- Attacker: Hyena Token
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 1.
- Result: Hyena Token survives, Rusted Moon Shrine at 2/10

Attack 4:
- Attacker: Bone-Cracker Cub
- Target: Rusted Moon Shrine
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Hyena Token deals 1 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Hyena Token.
- Result: Bone-Cracker Cub left battle, Hyena Token removed, Rusted Moon Shrine at 2/10

Attack 5:
- Attacker: Bone-Cracker Cub
- Target: Rusted Moon Shrine
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Iron Hyena Raider.
- Result: Bone-Cracker Cub left battle, Iron Hyena Raider removed, Rusted Moon Shrine at 2/10

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Pack Harrier, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 7 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena [Relic:Bone Spear], Bone Spear, Fang Relic, Hyena Token, Pack Harrier

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 10/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10] | Iron [Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10]
Resources: Red 4/1 | Iron 7/0
Awakened Ancestors: Red None | Iron Smith Who Passed the Fang
Forgotten cards: Red 4 | Iron 4
Key events: Hyena Token deals 1 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Hyena Token. | Iron Hyena Raider deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Iron Hyena Raider. | Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine) | Main 1: attached Bone Spear to Blood-Scent Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Fang Relic, Iron Hyena Raider, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 8/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 4.
- Result: Iron Hyena Raider survives, Rusted Moon Shrine at 6/10

Attack 2:
- Attacker: Pack Harrier
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 1.
- Result: Pack Harrier survives, Rusted Moon Shrine at 5/10

Main 2:
- Main 2: played Iron Hyena Champion

End:
- retained card: Iron Hyena Champion
- discarded cards: Blood-Scent Hyena, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 8/10
- board at end: Fang Relic, Fang Relic, Iron Hyena Champion, Iron Hyena Raider [Relic:Fang Relic], Pack Harrier

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 7
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Blood-Scent Hyena [Relic:Bone Spear], Bone Spear, Fang Relic, Hyena Token, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Smith Who Passed the Fang
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 5/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 3.
- Result: Blood-Scent Hyena survives, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Bone-Cracker Cub, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 5/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena [Relic:Bone Spear], Bone Spear, Fang Relic, Hyena Token, Iron Hyena Raider [Relic:Bone Spear], Pack Harrier

## End-of-game summary

Winner: iron-hyena-pack-pressure
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Iron Hyena Den 10/10, Bone-Fang Shrine 10/10, Rusted Moon Shrine 12/10] | Iron [Iron Hyena Den 12/10, Bone-Fang Shrine 10/10, Rusted Moon Shrine 5/10]
Final resources: Red 1/1 | Iron 4/0
Final Presence: Seat 1 3/5 | Seat 2 5/5

Turn count: 18
Phase count: 1

First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine broken: 8 (Seat 1/Red: 8, Seat 2/Iron: 11)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 0, Iron 0
First Ancestor awakened: 10
First L2: 5
First L3: 

Red L2 entries: 3 (hard-cast 1, evolved 2)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 2 (hard-cast 0, evolved 2)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 6, Iron 4
Legal L2 evolve actions: Red 6, Iron 4
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 4, Iron 4
Turns with legal L2 evolution: Red 4, Iron 4
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 6, Iron 4
Hard-cast chosen while legal evolve action existed: Red 2, Iron 0
Hard-cast chosen while evolution base existed: Red 0, Iron 0

Legal awaken actions generated: Red 0, Iron 4
Awaken actions chosen: Red 0, Iron 3
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red None, Iron iron.ancestor.firstpack
Ancestor switches: Red 0, Iron 1
Turns with awakened ancestor: Red 0, Iron 4
Memory spent on ancestors: Red 0, Iron 4
Ancestor realized value: First Hunter +0 damage, Grandmother healed 0, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 1 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 4, Iron 4
Wounded events: Red 0, Iron 0
Wounded reduced damage: Red 0, Iron 0
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 20, Iron 3
Blocks chosen: Red 3, Iron 2
Blocks declined: Red 4, Iron 1
Assault slots spent: Seat 1 standard 1, pack 7 | Seat 2 standard 2, pack 8
Pack diagnostics: Seat 1 ready-at-combat 13, generated 13, available 13, skipped 6, turns-with-bonus 7, max-attacks 31, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 14, generated 13, available 13, skipped 5, turns-with-bonus 7, max-attacks 31, prevented-by-limit 0
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
