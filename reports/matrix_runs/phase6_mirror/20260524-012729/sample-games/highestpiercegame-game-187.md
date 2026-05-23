# Test Game #187

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports\matrix_runs\phase6_mirror --bot-red iron --bot-iron iron --deck-red iron-hyena-pack-pressure --deck-iron iron-hyena-pack-pressure --rules phase-length-6

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

Seed: 187
Winner: iron-hyena-pack-pressure
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Bite the Roots, Blood-Scent Hyena, Blood-Scent Hyena, Hyena Pack Call, Pack Ambush
- Starting hands — Iron: Blood-Scent Hyena, Blood-Scent Hyena, Bone-Cracker Cub, Fang Relic, Pack Harrier
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Blood-Scent Hyena, Blood-Scent Hyena, Hyena Pack Call, Pack Ambush]

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
- discarded cards: Hyena Pack Call, Blood-Scent Hyena, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena, Blood-Scent Hyena, Bone-Cracker Cub, Fang Relic, Pack Harrier]

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
- discarded cards: Blood-Scent Hyena, Blood-Scent Hyena, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

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
- retained card: Blood-Scent Hyena
- discarded cards: Bone-Cracker Cub, Iron Hyena Champion, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: attached Fang Relic to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Bone-Cracker Cub survives, Bone-Fang Shrine at 7/10

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Bone-Cracker Cub, Iron Hyena Raider, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub [Relic:Fang Relic], Fang Relic

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 2 | Iron 0
Key events: Main 1: resolved Pack Ambush (summoned Hyena Token) | Main 1: played Bone-Cracker Cub | Shrine Bone-Fang Shrine takes 2. | Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine) | Shrine Bone-Fang Shrine takes 3. | Main 1: attached Fang Relic to Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Hyena Token

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
- Main 2: played Pack Harrier

End:
- retained card: Black-Tooth Smith
- discarded cards: Blood-Scent Hyena, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Hyena Token [Relic:Fang Relic], Pack Harrier

## Turn 6 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Bone-Cracker Cub [Relic:Fang Relic], Fang Relic
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: attached Fang Relic to Bone-Cracker Cub
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 5.
- Result: Bone-Cracker Cub survives, Bone-Fang Shrine at 2/10

Main 2:
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Blood-Scent Hyena
- discarded cards: Blood-Scent Hyena, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Fang Relic, Fang Relic

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Fang Relic, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine, broke it, gained 1 Memory)
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Blood-Scent Hyena, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Fang Relic, Fang Relic, Hyena Token

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Fang Relic, Hyena Token [Relic:Fang Relic], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine, broke it, gained 1 Memory)
- Main 1: attached Fang Relic to Hyena Token

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Pack Harrier, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Fang Relic, Hyena Token [Relic:Fang Relic], Pack Harrier

# End of Phase 2 Summary

Shrine state: Red [Iron Hyena Den: 1/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 1/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/1 | Iron 1/1
Awakened Ancestors: Red None | Iron Ancestor of the First Pack
Forgotten cards: Red 3 | Iron 2
Key events: Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine, broke it, gained 1 Memory) | Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine) | Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine, broke it, gained 1 Memory) | Main 1: attached Fang Relic to Hyena Token
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Fang Relic, Fang Relic, Hyena Token
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 4.
- Result: Bone-Cracker Cub survives, Iron Hyena Den at 5/10

Attack 2:
- Attacker: Hyena Token
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 1.
- Result: Hyena Token survives, Iron Hyena Den at 4/10

Main 2:
- Main 2: played Iron Hyena Raider
- Main 2: played Bone-Cracker Cub

End:
- retained card: Pack Harrier
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub [Relic:Bone Spear], Fang Relic, Fang Relic, Hyena Token, Iron Hyena Raider

## Turn 10 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Fang Relic, Fang Relic, Hyena Token [Relic:Fang Relic], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 2.
- Result: Hyena Token survives, Iron Hyena Den at 7/10

Attack 2:
- Attacker: Pack Harrier
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 1.
- Result: Pack Harrier survives, Iron Hyena Den at 6/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Bone-Cracker Cub, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub, Fang Relic, Fang Relic, Hyena Token [Relic:Fang Relic], Pack Harrier

## Turn 11 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 2

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Bone Spear, Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub [Relic:Bone Spear], Fang Relic, Fang Relic, Hyena Token, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Iron Hyena Den)

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 3.
- Result: Iron Hyena Raider survives, Iron Hyena Den at 0/10

Main 2:
- Main 2: resolved Bite the Roots (dealt 3 to Rusted Moon Shrine)

End:
- retained card: Pack Ambush
- discarded cards: Pack Harrier, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 3 Memory
- shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 1/10
- board at end: Bone Spear, Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic, Hyena Token, Iron Hyena Champion [Relic:Bone Spear], Iron Hyena Raider

## Turn 12 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone-Cracker Cub, Fang Relic, Fang Relic, Hyena Token [Relic:Fang Relic], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Blood-Scent Hyena
- Main 1: attached Bone Spear to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 2.
- Result: Hyena Token survives, Iron Hyena Den at 4/10

Attack 2:
- Attacker: Pack Harrier
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 1.
- Result: Pack Harrier survives, Iron Hyena Den at 3/10

Attack 3:
- Attacker: Blood-Scent Hyena
- Target: Iron Hyena Den
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Blood-Scent Hyena becomes Wounded. | Bone Spear grants Pierce against damaged Shrine. | Pierce overflow deals 2 to Iron Hyena Den.
- Damage: Hyena Token deals 1 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Hyena Token. | Shrine Iron Hyena Den takes 2.
- Result: Blood-Scent Hyena survives, Hyena Token removed, Iron Hyena Den at 1/10

Attack 4:
- Attacker: Bone-Cracker Cub
- Target: Iron Hyena Den
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Bone-Cracker Cub.
- Result: Bone-Cracker Cub left battle, Bone-Cracker Cub removed, Iron Hyena Den at 1/10

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: played Bone-Cracker Cub

End:
- retained card: Pack Harrier
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena [Wounded, Relic:Bone Spear], Bone Spear, Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic, Hyena Token [Relic:Fang Relic], Pack Harrier

# End of Phase 2 Summary

Shrine state: Red [Iron Hyena Den: 11/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10] | Iron [Iron Hyena Den: 4/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 1/10]
Resources: Red 0/1 | Iron 1/3
Awakened Ancestors: Red None | Iron Ancestor of the First Pack
Forgotten cards: Red 3 | Iron 3
Key events: Bone-Cracker Cub deals 2 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Bone-Cracker Cub. | Main 1: attached Bone Spear to Blood-Scent Hyena | Main 1: attached Bone Spear to Blood-Scent Hyena | Main 2: played Black-Tooth Smith | Main 2: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Blood-Scent Hyena [Wounded, Relic:Bone Spear], Bone Spear, Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic, Hyena Token [Relic:Fang Relic], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Pack Harrier, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: Blood-Scent Hyena
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena [Relic:Bone Spear], Bone Spear, Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic, Hyena Token [Relic:Fang Relic], Pack Harrier

## Turn 14 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 3

Hand before draw: [Pack Ambush]

Board before ready:
Beings/Spirits: Bone Spear, Bone Spear, Fang Relic, Fang Relic, Iron Hyena Champion [Relic:Bone Spear], Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Rusted Moon Shrine
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Hyena Champion becomes Wounded. | Ancestor of the First Pack deals 1 to blocked Shrine. | Bone Spear grants Pierce against damaged Shrine. | Pierce overflow deals 5 to Rusted Moon Shrine.
- Damage: Hyena Token deals 2 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Hyena Token. | Shrine Rusted Moon Shrine takes 5.
- Result: Iron Hyena Champion survives, Hyena Token removed, Rusted Moon Shrine at 1/10

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Rusted Moon Shrine
- Defender/blocker: Pack Harrier
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Hyena Raider becomes Wounded.
- Damage: Pack Harrier deals 1 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Pack Harrier.
- Result: Iron Hyena Raider survives, Pack Harrier removed, Rusted Moon Shrine at 1/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Pack Harrier
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 3 Memory
- shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10
- board at end: Black-Tooth Smith, Bone Spear, Bone Spear, Fang Relic, Fang Relic, Hyena Token, Iron Hyena Champion [Wounded, Relic:Bone Spear], Iron Hyena Raider, Iron Hyena Raider [Wounded]

## Turn 15 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Blood-Scent Hyena [Relic:Bone Spear], Bone Spear, Bone Spear, Bone-Cracker Cub, Fang Relic
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 9/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Pack Harrier

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
- Attacker: Blood-Scent Hyena
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 3.
- Result: Blood-Scent Hyena survives, Rusted Moon Shrine at 1/10

Attack 3:
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
- discarded cards: Iron Hyena Raider, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 9/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena [Relic:Bone Spear], Bone Spear, Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider, Pack Harrier

## End-of-game summary

Winner: iron-hyena-pack-pressure
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Iron Hyena Den 11/10, Bone-Fang Shrine 11/10, Rusted Moon Shrine 9/10] | Iron [Iron Hyena Den 10/10, Bone-Fang Shrine 11/10, Rusted Moon Shrine 12/10]
Final resources: Red 5/1 | Iron 1/3
Final Presence: Seat 1 5/5 | Seat 2 5/5

Turn count: 15
Phase count: 3

First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine broken: 7 (Seat 1/Red: 7, Seat 2/Iron: 8)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 8, Iron 9
First Ancestor awakened: 6
First L2: 11
First L3: 

Red L2 entries: 0 (hard-cast 0, evolved 0)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 1 (hard-cast 0, evolved 1)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 0, Iron 4
Legal L2 evolve actions: Red 0, Iron 4
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 0, Iron 2
Turns with legal L2 evolution: Red 0, Iron 2
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 0, Iron 3
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 0, Iron 0

Legal awaken actions generated: Red 0, Iron 7
Awaken actions chosen: Red 0, Iron 4
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red None, Iron iron.ancestor.firstpack
Ancestor switches: Red 0, Iron 0
Turns with awakened ancestor: Red 0, Iron 4
Memory spent on ancestors: Red 0, Iron 2
Ancestor realized value: First Hunter +0 damage, Grandmother healed 0, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 4, Iron 4
Wounded events: Red 1, Iron 2
Wounded reduced damage: Red 0, Iron 0
Pierce overflow events: Red 1, Iron 1
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 13, Iron 11
Blocks chosen: Red 2, Iron 2
Blocks declined: Red 2, Iron 2
Assault slots spent: Seat 1 standard 5, pack 6 | Seat 2 standard 1, pack 6
Pack diagnostics: Seat 1 ready-at-combat 10, generated 10, available 10, skipped 4, turns-with-bonus 5, max-attacks 26, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 9, generated 9, available 9, skipped 3, turns-with-bonus 6, max-attacks 23, prevented-by-limit 0
Deck reshuffles: Red 1, Iron 0

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
