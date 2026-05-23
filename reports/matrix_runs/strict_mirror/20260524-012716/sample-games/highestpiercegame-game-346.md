# Test Game #346

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

Seed: 346
Winner: iron-hyena-pack-pressure
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Hyena Pack Call, Iron Hyena Champion, Iron Hyena Raider, Pack Ambush, Pack Harrier
- Starting hands — Iron: Bite the Roots, Fang Relic, Iron Hyena Champion, Iron Hyena Raider, Pack Ambush
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Hyena Pack Call, Iron Hyena Champion, Iron Hyena Raider, Pack Ambush, Pack Harrier]

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
- retained card: Pack Harrier
- discarded cards: Hyena Pack Call, Iron Hyena Raider, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Fang Relic, Iron Hyena Champion, Iron Hyena Raider, Pack Ambush]

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
- discarded cards: Iron Hyena Raider, Fang Relic, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Pack Harrier]

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
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Hyena Token survives, Bone-Fang Shrine at 6/10

Main 2:
- pass

End:
- retained card: Pack Harrier
- discarded cards: Hyena Pack Call, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Hyena Token, Hyena Token [Relic:Bone Spear]

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 2.
- Result: Hyena Token survives, Bone-Fang Shrine at 5/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Pack Harrier, Iron Hyena Champion, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 2 | Iron 2
Key events: Main 1: resolved Pack Ambush (summoned Hyena Token) | Shrine Bone-Fang Shrine takes 3. | Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine) | Main 1: attached Bone Spear to Hyena Token | Shrine Bone-Fang Shrine takes 2. | Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Bone Spear, Hyena Token, Hyena Token [Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Hyena Token

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Hyena Token survives, Bone-Fang Shrine at 3/10

Attack 2:
- Attacker: Hyena Token
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 2.
- Result: Hyena Token survives, Bone-Fang Shrine at 1/10

Main 2:
- Main 2: played Pack Harrier
- Main 2: played Pack Harrier

End:
- retained card: Pack Harrier
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Hyena Token, Hyena Token [Relic:Bone Spear], Pack Harrier, Pack Harrier

## Turn 6 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Hyena Token
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Hyena Token survives, Bone-Fang Shrine at 2/10

Main 2:
- Main 2: awakened Smith Who Passed the Fang

End:
- retained card: Black-Tooth Smith
- discarded cards: Blood-Scent Hyena, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Hyena Token [Relic:Bone Spear]

## Turn 7 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Bone Spear, Bone Spear, Hyena Token, Hyena Token [Relic:Bone Spear], Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Hyena Token into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine and broke it)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Pack Harrier, Bone-Cracker Cub, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Hyena Token, Iron Hyena Champion [Relic:Bone Spear], Pack Harrier, Pack Harrier

## Turn 8 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Hyena Token [Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: Smith Who Passed the Fang
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Bone-Fang Shrine
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Hyena Token deals 1 to Hyena Token. | Hyena Token deals 2 to Hyena Token.
- Result: Hyena Token left battle, Hyena Token removed, Bone-Fang Shrine at 2/10

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Bone-Fang Shrine
- Defender/blocker: Pack Harrier
- Prepared triggers: None
- Wounded/Pierce calculations: Blood-Scent Hyena becomes Wounded. | Bone Spear grants Pierce against damaged Shrine. | Pierce overflow deals 2 to Bone-Fang Shrine.
- Damage: Pack Harrier deals 1 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Pack Harrier. | Shrine Bone-Fang Shrine takes 2.
- Result: Blood-Scent Hyena survives, Pack Harrier removed, Bone-Fang Shrine at 0/10

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: played Pack Harrier

End:
- retained card: Pack Harrier
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena [Wounded, Relic:Bone Spear], Bone Spear, Pack Harrier

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/0 | Iron 0/1
Awakened Ancestors: Red None | Iron Smith Who Passed the Fang
Forgotten cards: Red 2 | Iron 2
Key events: Pack Harrier deals 1 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Pack Harrier. | Shrine Bone-Fang Shrine takes 2. | Main 1: attached Bone Spear to Blood-Scent Hyena | Main 2: played Black-Tooth Smith | Main 2: played Pack Harrier
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone Spear, Bone Spear, Iron Hyena Champion [Relic:Bone Spear], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 6.
- Result: Iron Hyena Champion survives, Iron Hyena Den at 4/10

Attack 2:
- Attacker: Pack Harrier
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 1.
- Result: Pack Harrier survives, Iron Hyena Den at 3/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Black-Tooth Smith
- discarded cards: Blood-Scent Hyena, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone Spear, Fang Relic, Iron Hyena Champion [Relic:Fang Relic], Pack Harrier

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Blood-Scent Hyena [Wounded, Relic:Bone Spear], Bone Spear, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Smith Who Passed the Fang
Shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 2.
- Result: Black-Tooth Smith survives, Iron Hyena Den at 7/10

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Blood-Scent Hyena from 3 to 2.
- Damage: Shrine Iron Hyena Den takes 2.
- Result: Blood-Scent Hyena survives, Iron Hyena Den at 5/10

Attack 3:
- Attacker: Pack Harrier
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 1.
- Result: Pack Harrier survives, Iron Hyena Den at 4/10

Main 2:
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: Blood-Scent Hyena
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena [Relic:Bone Spear], Bone Spear, Bone-Cracker Cub, Pack Harrier, Pack Harrier

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Bone Spear, Fang Relic, Iron Hyena Champion [Relic:Fang Relic], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 2 [Pack Ambush, Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den, broke it, gained 1 Memory)
- Main 1: resolved Bite the Roots (dealt 3 to Rusted Moon Shrine)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Black-Tooth Smith, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
- board at end: Black-Tooth Smith, Bone Spear, Bone Spear, Fang Relic, Iron Hyena Champion [Relic:Fang Relic], Pack Harrier

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Blood-Scent Hyena [Relic:Bone Spear], Bone Spear, Bone-Cracker Cub, Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 2.
- Result: Black-Tooth Smith survives, Iron Hyena Den at 1/10

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Iron Hyena Den
- Defender/blocker: Pack Harrier
- Prepared triggers: None
- Wounded/Pierce calculations: Blood-Scent Hyena becomes Wounded. | Ancestor of the First Pack deals 1 to blocked Shrine. | Bone Spear grants Pierce against damaged Shrine. | Pierce overflow deals 2 to Iron Hyena Den.
- Damage: Pack Harrier deals 1 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Pack Harrier. | Shrine Iron Hyena Den takes 2.
- Result: Blood-Scent Hyena survives, Pack Harrier removed, Iron Hyena Den at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Blood-Scent Hyena, Bone-Cracker Cub, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena [Wounded, Relic:Bone Spear], Bone Spear, Bone-Cracker Cub, Pack Harrier, Pack Harrier

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 6/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10] | Iron [Iron Hyena Den: 10/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10]
Resources: Red 2/1 | Iron 5/0
Awakened Ancestors: Red None | Iron Ancestor of the First Pack
Forgotten cards: Red 4 | Iron 3
Key events: Main 1: resolved Bite the Roots (dealt 3 to Rusted Moon Shrine) | Shrine Iron Hyena Den takes 2. | Pack Harrier deals 1 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Pack Harrier. | Shrine Iron Hyena Den takes 2. | Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Bone Spear, Fang Relic, Iron Hyena Champion [Relic:Fang Relic]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 2/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 2.
- Result: Black-Tooth Smith survives, Rusted Moon Shrine at 5/10

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Rusted Moon Shrine
- Defender/blocker: Pack Harrier
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Hyena Champion becomes Wounded.
- Damage: Pack Harrier deals 1 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Pack Harrier.
- Result: Iron Hyena Champion survives, Pack Harrier removed, Rusted Moon Shrine at 4/10

Main 2:
- Main 2: played Blood-Scent Hyena
- Main 2: played Blood-Scent Hyena

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 2/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear, Bone Spear, Fang Relic, Fang Relic, Iron Hyena Champion [Wounded, Relic:Fang Relic]

## Turn 14 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Blood-Scent Hyena [Wounded, Relic:Bone Spear], Bone Spear, Bone-Cracker Cub, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 6/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 2.
- Result: Black-Tooth Smith survives, Rusted Moon Shrine at 6/10

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Blood-Scent Hyena from 3 to 2.
- Damage: Shrine Rusted Moon Shrine takes 2.
- Result: Blood-Scent Hyena survives, Rusted Moon Shrine at 2/10

Attack 3:
- Attacker: Pack Harrier
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 1.
- Result: Pack Harrier survives, Rusted Moon Shrine at 1/10

Attack 4:
- Attacker: Bone-Cracker Cub
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 3.
- Result: Bone-Cracker Cub survives, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Blood-Scent Hyena, Hyena Pack Call
- forgotten cards: None
- Wounded clears: Blood-Scent Hyena
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 6/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena [Relic:Fang Relic], Bone Spear, Bone-Cracker Cub, Fang Relic, Pack Harrier

## End-of-game summary

Winner: iron-hyena-pack-pressure
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Iron Hyena Den 11/10, Bone-Fang Shrine 10/10, Rusted Moon Shrine 12/10] | Iron [Iron Hyena Den 10/10, Bone-Fang Shrine 11/10, Rusted Moon Shrine 6/10]
Final resources: Red 1/1 | Iron 5/0
Final Presence: Seat 1 4/5 | Seat 2 4/5

Turn count: 14
Phase count: 1

First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine broken: 7 (Seat 1/Red: 8, Seat 2/Iron: 7)
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 0, Iron 0
First Ancestor awakened: 6
First L2: 7
First L3: 

Red L2 entries: 1 (hard-cast 0, evolved 1)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 0 (hard-cast 0, evolved 0)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 4, Iron 0
Legal L2 evolve actions: Red 4, Iron 0
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 2, Iron 0
Turns with legal L2 evolution: Red 2, Iron 0
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 4, Iron 0
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 0, Iron 0

Legal awaken actions generated: Red 0, Iron 2
Awaken actions chosen: Red 0, Iron 2
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red None, Iron iron.ancestor.smithpassedfang
Ancestor switches: Red 0, Iron 1
Turns with awakened ancestor: Red 0, Iron 4
Memory spent on ancestors: Red 0, Iron 4
Ancestor realized value: First Hunter +0 damage, Grandmother healed 0, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 1 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 4, Iron 3
Wounded events: Red 1, Iron 2
Wounded reduced damage: Red 0, Iron 2
Pierce overflow events: Red 0, Iron 2
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 13, Iron 6
Blocks chosen: Red 3, Iron 1
Blocks declined: Red 1, Iron 1
Assault slots spent: Seat 1 standard 4, pack 3 | Seat 2 standard 6, pack 7
Pack diagnostics: Seat 1 ready-at-combat 8, generated 8, available 8, skipped 5, turns-with-bonus 4, max-attacks 22, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 10, generated 9, available 9, skipped 2, turns-with-bonus 4, max-attacks 23, prevented-by-limit 0
Deck reshuffles: Red 0, Iron 0

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
