# Test Game #191

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red iron --bot-iron iron --deck-red iron-hyena-pack-pressure --deck-iron iron-snarecraft-control

Seat 1:
- iron-hyena-pack-pressure [Iron] (IronHyenaBot)
Seat 2:
- iron-snarecraft-control [Iron] (IronHyenaBot)

Rules variant:
- Draw model: retain up to 1, discard rest, draw to 5
- Phase model: reverse every 4 player-turns
- Combat model: 2 standard Assault slots, plus Pack expansion up to 5 total attacks, separate resolution
- Battlefield capacity: 5 Presence per seat
- Prepared model: max 1 active tactic per player
- Special mechanics: Fade, Forgotten, Wounded, Pierce, Disperse, Possession, Evolution, Recall, Unique, Pack

Seed: 191
Winner: iron-hyena-pack-pressure
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Black-Tooth Smith, Blood-Scent Hyena, Bone-Cracker Cub, Fang Relic, Hyena Pack Call
- Starting hands — Iron: Bite the Roots, Black-Tooth Smith, False Opening, Iron Guard, Iron Hyena Champion
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang
- Starting Lineage — Iron: Ancestor of the Iron Hyena, Tooth-Mother of the Dry Earth, Smith of Black Teeth

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith, Blood-Scent Hyena, Bone-Cracker Cub, Fang Relic, Hyena Pack Call]

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
- discarded cards: Hyena Pack Call, Black-Tooth Smith, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Black-Tooth Smith, False Opening, Iron Guard, Iron Hyena Champion]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- pass

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bite the Roots
- discarded cards: False Opening, Iron Guard, Black-Tooth Smith, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

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
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 4.
- Result: Bone-Cracker Cub survives, Bone-Fang Shrine at 3/10

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Fang Relic, Iron Hyena Raider, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bite the Roots
- discarded cards: Bone Spear, Bone-Cracker Cub, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
- board at end: 

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 1
Key events: Main 1: played Bone-Cracker Cub | Shrine Bone-Fang Shrine takes 4. | Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine) | Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)
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
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)
- Main 1: prepared Iron Snare

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Raider
- discarded cards: Iron Hyena Underworld, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Pack Ambush
- discarded cards: Fang Relic, Bone-Cracker Cub, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Champion

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Iron Hyena Raider]

Board before ready:
Beings/Spirits: 
Prepared Tactic: Iron Snare
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Hyena Pack Call, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider, Iron Hyena Raider

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Pack Ambush]

Board before ready:
Beings/Spirits: Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- Main 2: played Pack Harrier

End:
- retained card: Iron Hyena Champion
- discarded cards: Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Hyena Token, Iron Hyena Champion, Pack Harrier

# End of Phase 2 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/0 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 2 | Iron 2
Key events: Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine) | Main 1: played Iron Hyena Raider | Main 1: played Iron Hyena Raider | Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine) | Main 1: played Bone-Cracker Cub | Main 2: played Pack Harrier
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Hyena Token, Iron Hyena Champion, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den)
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 2.
- Result: Pack Harrier survives, Iron Hyena Den at 5/10

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 6.
- Result: Iron Hyena Champion survives, Iron Hyena Den at 0/10

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Hyena Pack Call, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Bone-Cracker Cub, Hyena Token, Iron Hyena Champion, Pack Harrier

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Iron Hyena Raider, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)
- Main 1: attached Bone Spear to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Bone-Fang Shrine
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Hyena Raider becomes Wounded. | Bone Spear grants Pierce against damaged Shrine. | Pierce overflow deals 3 to Bone-Fang Shrine.
- Damage: Hyena Token deals 1 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Hyena Token. | Shrine Bone-Fang Shrine takes 3.
- Result: Iron Hyena Raider survives, Hyena Token removed, Bone-Fang Shrine at 0/10

Main 2:
- Main 2: played Iron Guard

End:
- retained card: Bone-Cracker Cub
- discarded cards: False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Guard, Iron Hyena Raider, Iron Hyena Raider [Wounded, Relic:Bone Spear]

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Bone-Cracker Cub, Iron Hyena Champion, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Rusted Moon Shrine)
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Iron Guard
- Defender/blocker: Iron Guard
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Hyena Champion becomes Wounded.
- Damage: Iron Guard deals 2 to Iron Hyena Champion. | Iron Hyena Champion deals 5 to Iron Guard.
- Result: Iron Hyena Champion survives, Iron Guard removed

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Iron Hyena Raider, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Bone-Cracker Cub, Hyena Token, Iron Hyena Champion, Iron Hyena Champion [Wounded]

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Bone Spear, Iron Hyena Raider, Iron Hyena Raider [Wounded, Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Raider from 4 to 3.
- Damage: Shrine Iron Hyena Den takes 3.
- Result: Iron Hyena Raider survives, Iron Hyena Den at 7/10

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 3.
- Result: Iron Hyena Raider survives, Iron Hyena Den at 4/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: Iron Hyena Raider
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10
- board at end: Bone Spear, Bone-Cracker Cub, Iron Hyena Raider, Iron Hyena Raider, Iron Hyena Raider [Relic:Bone Spear]

# End of Phase 3 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10]
Resources: Red 2/0 | Iron 3/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 4 | Iron 4
Key events: Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Rusted Moon Shrine) | Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine) | Shrine Iron Hyena Den takes 3. | Shrine Iron Hyena Den takes 3. | Main 1: played Bone-Cracker Cub | Main 1: played Iron Hyena Raider
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Iron Hyena Raider, Iron Hyena Raider, Iron Hyena Raider [Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: prepared Iron Snare
- Main 1: attached Fang Relic to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Iron Hyena Den
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Bone-Cracker Cub.
- Result: Iron Hyena Raider left battle, Bone-Cracker Cub removed, Iron Hyena Den at 4/10

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 3.
- Result: Iron Hyena Raider survives, Iron Hyena Den at 1/10

Attack 3:
- Attacker: Iron Hyena Raider
- Target: Iron Hyena Den
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Bone-Cracker Cub.
- Result: Iron Hyena Raider left battle, Bone-Cracker Cub removed, Iron Hyena Den at 1/10

Attack 4:
- Attacker: Bone-Cracker Cub
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Iron Hyena Champion.
- Result: Bone-Cracker Cub left battle, Iron Hyena Champion removed, Iron Hyena Den at 1/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Rust Hyena Spirit
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10
- board at end: Black-Tooth Smith, Bone Spear, Iron Hyena Raider

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Hyena Token, Iron Hyena Champion [Wounded]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Champion
- Main 1: attached Bone Spear to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 6 to 4.
- Damage: Shrine Rusted Moon Shrine takes 4.
- Result: Iron Hyena Champion survives, Rusted Moon Shrine at 3/10

Attack 2:
- Attacker: Hyena Token
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 1.
- Result: Hyena Token survives, Rusted Moon Shrine at 2/10

Main 2:
- Main 2: played Blood-Scent Hyena
- Main 2: played Blood-Scent Hyena

End:
- retained card: Pack Harrier
- discarded cards: None
- forgotten cards: None
- Wounded clears: Iron Hyena Champion
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 1/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear, Bone Spear, Hyena Token, Iron Hyena Champion [Relic:Bone Spear]

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Rust Hyena Spirit]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 8/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: evolved Iron Hyena Raider into Iron Hyena Champion (dealt 2 to Iron Hyena Den and broke it)
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- Main 2: played Rust Hyena Spirit

End:
- retained card: Rust Hyena Spirit
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 8/10
- board at end: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Iron Hyena Champion, Rust Hyena Spirit

## Turn 16 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear, Bone Spear, Hyena Token, Iron Hyena Champion [Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Rusted Moon Shrine
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Hyena Champion becomes Wounded. | Bone Spear grants Pierce against damaged Shrine. | Pierce overflow deals 3 to Rusted Moon Shrine.
- Damage: Black-Tooth Smith deals 2 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Black-Tooth Smith. | Shrine Rusted Moon Shrine takes 3.
- Result: Iron Hyena Champion survives, Black-Tooth Smith removed, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Bone-Cracker Cub, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 7 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 1/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear, Bone Spear, Hyena Token, Iron Hyena Champion [Wounded, Relic:Bone Spear], Pack Harrier

# End of Phase 4 Summary

Shrine state: Red [Iron Hyena Den: 11/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 1/10] | Iron [Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 8/10]
Resources: Red 7/0 | Iron 2/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 4 | Iron 5
Key events: Main 1: played Bone-Cracker Cub | Main 2: played Rust Hyena Spirit | Black-Tooth Smith deals 2 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Black-Tooth Smith. | Shrine Rusted Moon Shrine takes 3. | Main 1: played Pack Harrier
Tempo note: initiative reverses after every four player-turns.

## End-of-game summary

Winner: iron-hyena-pack-pressure
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Iron Hyena Den 11/10, Bone-Fang Shrine 12/10, Rusted Moon Shrine 1/10] | Iron [Iron Hyena Den 11/10, Bone-Fang Shrine 10/10, Rusted Moon Shrine 11/10]
Final resources: Red 7/0 | Iron 2/0
Final Presence: Seat 1 5/5 | Seat 2 3/5

Turn count: 16
Phase count: 4

First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine broken: 8 (Seat 1/Red: 10, Seat 2/Iron: 8)
Wins in odd phase: 0
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 15, Iron 16
First Ancestor awakened: 
First L2: 6
First L3: 

Red L2 entries: 2 (hard-cast 0, evolved 2)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 1 (hard-cast 0, evolved 1)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 4, Iron 2
Legal L2 evolve actions: Red 4, Iron 2
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 4, Iron 2
Turns with legal L2 evolution: Red 4, Iron 2
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 4, Iron 2
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 2, Iron 0

Legal awaken actions generated: Red 0, Iron 0
Awaken actions chosen: Red 0, Iron 0
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red None, Iron None
Ancestor switches: Red 0, Iron 0
Turns with awakened ancestor: Red 0, Iron 0
Memory spent on ancestors: Red 0, Iron 0
Ancestor realized value: First Hunter +0 damage, Grandmother healed 0, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 2
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 4, Iron 5
Wounded events: Red 2, Iron 1
Wounded reduced damage: Red 2, Iron 1
Pierce overflow events: Red 1, Iron 1
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 16, Iron 2
Blocks chosen: Red 4, Iron 1
Blocks declined: Red 3, Iron 0
Assault slots spent: Seat 1 standard 1, pack 6 | Seat 2 standard 1, pack 6
Pack diagnostics: Seat 1 ready-at-combat 14, generated 13, available 13, skipped 7, turns-with-bonus 7, max-attacks 29, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 9, generated 8, available 8, skipped 2, turns-with-bonus 4, max-attacks 24, prevented-by-limit 0
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
