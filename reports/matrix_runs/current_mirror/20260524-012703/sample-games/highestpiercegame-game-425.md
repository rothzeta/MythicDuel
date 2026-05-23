# Test Game #425

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports\matrix_runs\current_mirror --bot-red iron --bot-iron iron --deck-red iron-hyena-pack-pressure --deck-iron iron-hyena-pack-pressure

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

Seed: 425
Winner: iron-hyena-pack-pressure
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Black-Tooth Smith, Black-Tooth Smith, Bone-Cracker Cub, Iron Hyena Raider, Pack Harrier
- Starting hands — Iron: Blood-Scent Hyena, Bone Spear, Fang Relic, Hyena Pack Call, Pack Harrier
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith, Black-Tooth Smith, Bone-Cracker Cub, Iron Hyena Raider, Pack Harrier]

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
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Raider, Black-Tooth Smith, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena, Bone Spear, Fang Relic, Hyena Pack Call, Pack Harrier]

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
- discarded cards: Hyena Pack Call, Blood-Scent Hyena, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Pack Harrier

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 2.
- Result: Bone-Cracker Cub survives, Bone-Fang Shrine at 8/10

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Black-Tooth Smith, Bone-Cracker Cub, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 2/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: attached Bone Spear to Pack Harrier

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Pack Harrier survives, Bone-Fang Shrine at 6/10

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Iron Hyena Raider, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 2/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Hyena Token, Pack Harrier [Relic:Bone Spear]

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 2/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 1
Key events: Main 1: played Pack Harrier | Shrine Bone-Fang Shrine takes 2. | Main 1: played Blood-Scent Hyena | Shrine Bone-Fang Shrine takes 3. | Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine) | Main 1: attached Bone Spear to Pack Harrier
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone Spear, Hyena Token, Pack Harrier [Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 2/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine)

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 2.
- Result: Hyena Token survives, Bone-Fang Shrine at 2/10

Main 2:
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Bite the Roots
- discarded cards: Bone-Cracker Cub, Pack Harrier, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 2/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Hyena Token, Iron Hyena Champion [Relic:Bone Spear]

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine)

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Blood-Scent Hyena survives, Bone-Fang Shrine at 3/10

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Blood-Scent Hyena, Hyena Pack Call, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Iron Hyena Champion

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: Bone Spear, Hyena Token, Iron Hyena Champion [Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: evolved Hyena Token into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine and broke it)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bite the Roots
- discarded cards: Hyena Pack Call, Black-Tooth Smith, Bite the Roots
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Hyena Champion, Iron Hyena Champion [Relic:Bone Spear]

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: attached Bone Spear to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Bone-Fang Shrine
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Hyena Champion becomes Wounded.
- Damage: Iron Hyena Champion deals 6 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Iron Hyena Champion.
- Result: Blood-Scent Hyena left battle, Iron Hyena Champion survives, Bone-Fang Shrine at 2/10

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Bone-Fang Shrine
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Iron Hyena Champion.
- Result: Iron Hyena Champion left battle, Iron Hyena Champion removed, Bone-Fang Shrine at 2/10

Main 2:
- Main 2: played Pack Harrier

End:
- retained card: Fang Relic
- discarded cards: Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token, Pack Harrier

# End of Phase 2 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 1/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/0 | Iron 1/0
Awakened Ancestors: Red None | Iron Ancestor of the First Pack
Forgotten cards: Red 1 | Iron 1
Key events: Blood-Scent Hyena deals 2 to Iron Hyena Champion. | Iron Hyena Champion deals 5 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Iron Hyena Champion. | Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine) | Main 1: attached Bone Spear to Iron Hyena Champion | Main 2: played Pack Harrier
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Hyena Token, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Hyena Token

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 1.
- Result: Pack Harrier survives, Bone-Fang Shrine at 1/10

Attack 2:
- Attacker: Hyena Token
- Target: Bone-Fang Shrine
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 6 to 4. | Iron Hyena Champion becomes Wounded.
- Damage: Iron Hyena Champion deals 4 to Hyena Token. | Hyena Token deals 2 to Iron Hyena Champion.
- Result: Hyena Token left battle, Iron Hyena Champion survives, Bone-Fang Shrine at 1/10

Main 2:
- Main 2: played Iron Hyena Raider
- Main 2: played Pack Harrier

End:
- retained card: Iron Hyena Champion
- discarded cards: Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider, Pack Harrier, Pack Harrier

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: Bone Spear, Iron Hyena Champion [Wounded, Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 3/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den)
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 7 to 5.
- Damage: Shrine Iron Hyena Den takes 5.
- Result: Iron Hyena Champion survives, Iron Hyena Den at 1/10

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Black-Tooth Smith, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: Iron Hyena Champion
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 3/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Hyena Token, Iron Hyena Champion [Relic:Bone Spear]

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Iron Hyena Raider, Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine and broke it)
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Iron Hyena Raider, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token, Iron Hyena Champion, Iron Hyena Raider, Pack Harrier

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Bone Spear, Hyena Token, Iron Hyena Champion [Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Champion
- Main 1: attached Bone Spear to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Iron Hyena Den
- Defender/blocker: Pack Harrier
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Hyena Champion becomes Wounded. | Ancestor of the First Pack deals 1 to blocked Shrine. | Bone Spear grants Pierce against damaged Shrine. | Pierce overflow deals 5 to Iron Hyena Den.
- Damage: Pack Harrier deals 1 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Pack Harrier. | Shrine Iron Hyena Den takes 5.
- Result: Iron Hyena Champion survives, Pack Harrier removed, Iron Hyena Den at 0/10

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: played Pack Harrier

End:
- retained card: Bone-Cracker Cub
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Bone-Cracker Cub, Fang Relic, Hyena Token, Iron Hyena Champion [Wounded, Relic:Bone Spear], Pack Harrier

# End of Phase 3 Summary

Shrine state: Red [Iron Hyena Den: 9/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 4/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10]
Resources: Red 2/0 | Iron 1/2
Awakened Ancestors: Red None | Iron Ancestor of the First Pack
Forgotten cards: Red 2 | Iron 3
Key events: Iron Hyena Champion deals 6 to Pack Harrier. | Shrine Iron Hyena Den takes 5. | Main 1: attached Fang Relic to Iron Hyena Champion | Main 1: attached Bone Spear to Iron Hyena Champion | Main 2: played Bone-Cracker Cub | Main 2: played Pack Harrier
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 2

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Bone Spear, Bone Spear, Bone-Cracker Cub, Fang Relic, Hyena Token, Iron Hyena Champion [Wounded, Relic:Bone Spear], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 6 to 4.
- Damage: Shrine Rusted Moon Shrine takes 4.
- Result: Iron Hyena Champion survives, Rusted Moon Shrine at 6/10

Attack 2:
- Attacker: Pack Harrier
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 1.
- Result: Pack Harrier survives, Rusted Moon Shrine at 5/10

Attack 3:
- Attacker: Hyena Token
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 1.
- Result: Hyena Token survives, Rusted Moon Shrine at 4/10

Attack 4:
- Attacker: Bone-Cracker Cub
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 3.
- Result: Bone-Cracker Cub survives, Rusted Moon Shrine at 1/10

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call, Pack Harrier, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: Iron Hyena Champion
- resources at end: 6 Offerings / 3 Memory
- shrine state: Iron Hyena Den: 4/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Hyena Token, Iron Hyena Champion [Relic:Bone Spear], Pack Harrier

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Hyena Token, Iron Hyena Champion, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 14/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 9/10
Forgotten zone count/list: 2 [Pack Ambush, Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den)
- Main 1: attached Bone Spear to Iron Hyena Champion

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
- Main 2: played Bone-Cracker Cub

End:
- retained card: Pack Harrier
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 14/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 9/10
- board at end: Bone Spear, Bone-Cracker Cub, Hyena Token, Iron Hyena Champion [Relic:Bone Spear], Iron Hyena Raider

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 3

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone Spear, Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Hyena Token, Iron Hyena Champion [Relic:Bone Spear], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- pass

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Rusted Moon Shrine
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Hyena Champion becomes Wounded. | Ancestor of the First Pack deals 1 to blocked Shrine. | Bone Spear grants Pierce against damaged Shrine. | Pierce overflow deals 5 to Rusted Moon Shrine.
- Damage: Hyena Token deals 1 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Hyena Token. | Shrine Rusted Moon Shrine takes 5.
- Result: Iron Hyena Champion survives, Hyena Token removed, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Blood-Scent Hyena, Blood-Scent Hyena, Iron Hyena Raider, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 8 Offerings / 3 Memory
- shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Hyena Token, Iron Hyena Champion [Wounded, Relic:Bone Spear], Pack Harrier

## End-of-game summary

Winner: iron-hyena-pack-pressure
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Iron Hyena Den 14/10, Bone-Fang Shrine 10/10, Rusted Moon Shrine 14/10] | Iron [Iron Hyena Den 10/10, Bone-Fang Shrine 11/10, Rusted Moon Shrine 0/10]
Final resources: Red 3/0 | Iron 8/3
Final Presence: Seat 1 3/5 | Seat 2 5/5

Turn count: 15
Phase count: 4

First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine broken: 7 (Seat 1/Red: 7, Seat 2/Iron: 11)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 4, Iron 22
First Ancestor awakened: 5
First L2: 5
First L3: 

Red L2 entries: 2 (hard-cast 0, evolved 2)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 2 (hard-cast 0, evolved 2)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 4, Iron 4
Legal L2 evolve actions: Red 4, Iron 4
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 4, Iron 4
Turns with legal L2 evolution: Red 4, Iron 4
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 4, Iron 3
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 1, Iron 0

Legal awaken actions generated: Red 0, Iron 7
Awaken actions chosen: Red 0, Iron 4
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red None, Iron iron.ancestor.firstpack
Ancestor switches: Red 0, Iron 0
Turns with awakened ancestor: Red 0, Iron 5
Memory spent on ancestors: Red 0, Iron 2
Ancestor realized value: First Hunter +0 damage, Grandmother healed 0, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 3, Iron 3
Wounded events: Red 0, Iron 4
Wounded reduced damage: Red 0, Iron 3
Pierce overflow events: Red 0, Iron 2
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 13, Iron 7
Blocks chosen: Red 2, Iron 3
Blocks declined: Red 4, Iron 2
Assault slots spent: Seat 1 standard 1, pack 6 | Seat 2 standard 1, pack 8
Pack diagnostics: Seat 1 ready-at-combat 11, generated 11, available 11, skipped 5, turns-with-bonus 6, max-attacks 25, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 13, generated 12, available 12, skipped 4, turns-with-bonus 7, max-attacks 28, prevented-by-limit 0
Deck reshuffles: Red 0, Iron 1

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
