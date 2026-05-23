# Test Game #462

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red iron --bot-iron iron --deck-red iron-snarecraft-control --deck-iron iron-hyena-pack-pressure

Seat 1:
- iron-snarecraft-control [Iron] (IronHyenaBot)
Seat 2:
- iron-hyena-pack-pressure [Iron] (IronHyenaBot)

Rules variant:
- Draw model: retain up to 1, discard rest, draw to 5
- Phase model: reverse every 4 player-turns
- Combat model: 2 standard Assault slots, plus Pack expansion up to 5 total attacks, separate resolution
- Battlefield capacity: 5 Presence per seat
- Prepared model: max 1 active tactic per player
- Special mechanics: Fade, Forgotten, Wounded, Pierce, Disperse, Possession, Evolution, Recall, Unique, Pack

Seed: 462
Winner: iron-hyena-pack-pressure
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Bite the Roots, Black-Tooth Smith, Bone Spear, False Opening, Iron Hyena Raider
- Starting hands — Iron: Black-Tooth Smith, Blood-Scent Hyena, Fang Relic, Hyena Pack Call, Iron Hyena Raider
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: Ancestor of the Iron Hyena, Tooth-Mother of the Dry Earth, Smith of Black Teeth
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Black-Tooth Smith, Bone Spear, False Opening, Iron Hyena Raider]

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
- discarded cards: Bone Spear, Black-Tooth Smith, False Opening, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith, Blood-Scent Hyena, Fang Relic, Hyena Pack Call, Iron Hyena Raider]

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
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call, Iron Hyena Raider, Fang Relic, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Pack Call, Rust Hyena Spirit, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Blood-Scent Hyena

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Blood-Scent Hyena, Iron Hyena Raider, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 0
Key events: Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine) | Main 1: played Blood-Scent Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Blood-Scent Hyena
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)
- Main 1: attached Bone Spear to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 4.
- Result: Blood-Scent Hyena survives, Bone-Fang Shrine at 3/10

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Hyena Pack Call, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena [Relic:Bone Spear], Bone Spear

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Rust Hyena Spirit, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Blood-Scent Hyena [Relic:Bone Spear], Bone Spear
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: evolved Blood-Scent Hyena into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bite the Roots
- discarded cards: Fang Relic, Blood-Scent Hyena, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Hyena Champion [Relic:Bone Spear]

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)
- Main 1: prepared Iron Snare

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Bone-Fang Shrine
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 6 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to Iron Hyena Champion.
- Result: Bone-Cracker Cub left battle, Iron Hyena Champion removed, Bone-Fang Shrine at 1/10

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Bone Spear, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: 

# End of Phase 2 Summary

Shrine state: Red [Iron Hyena Den: 1/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 6/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/0 | Iron 1/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 3 | Iron 1
Key events: Main 1: played Bone-Cracker Cub | Main 1: evolved Blood-Scent Hyena into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine) | Iron Hyena Champion deals 6 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to Iron Hyena Champion. | Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine) | Main 1: prepared Iron Snare
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: 
Prepared Tactic: Iron Snare
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Bite the Roots]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Guard

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: False Opening
- discarded cards: Iron Guard, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Iron Guard

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine, broke it, gained 1 Memory)
- Main 1: resolved Pack Ambush (summoned Hyena Token)

Combat:
- no attacks

Main 2:
- Main 2: played Bone-Cracker Cub

End:
- retained card: Blood-Scent Hyena
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Hyena Token

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [False Opening]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Iron Guard
Prepared Tactic: Iron Snare
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Bite the Roots]

Main 1:
- Main 1: prepared Iron Snare
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Guard
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 2.
- Result: Iron Guard survives, Bone-Fang Shrine at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: False Opening, Iron Hyena Underworld
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Iron Guard, Iron Hyena Raider

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 2

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Iron Guard
- Defender/blocker: Iron Guard
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Guard becomes Wounded.
- Damage: Iron Guard deals 2 to Hyena Token. | Hyena Token deals 1 to Iron Guard.
- Result: Hyena Token left battle, Iron Guard survives

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Iron Guard
- Defender/blocker: Iron Guard
- Prepared triggers: Iron Snare, Iron Snare
- Wounded/Pierce calculations: Wounded reduces Iron Guard from 2 to 1.
- Damage: Iron Guard deals 1 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Iron Guard.
- Result: Bone-Cracker Cub left battle, Iron Guard removed

Main 2:
- Main 2: played Blood-Scent Hyena
- Main 2: played Pack Harrier
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Pack Harrier

# End of Phase 3 Summary

Shrine state: Red [Iron Hyena Den: 1/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/0 | Iron 2/0
Awakened Ancestors: Red None | Iron Ancestor of the First Pack
Forgotten cards: Red 3 | Iron 3
Key events: Iron Guard deals 1 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Iron Guard. | Main 1: attached Bone Spear to Bone-Cracker Cub | Main 2: played Blood-Scent Hyena | Main 2: played Pack Harrier | Main 2: awakened Ancestor of the First Pack
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 2.
- Result: Blood-Scent Hyena survives, Iron Hyena Den at 6/10

Attack 2:
- Attacker: Pack Harrier
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 1.
- Result: Pack Harrier survives, Iron Hyena Den at 5/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Iron Hyena Champion
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena, Hyena Token, Iron Hyena Raider, Pack Harrier

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 5/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Raider
- Main 1: attached Fang Relic to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 4.
- Result: Iron Hyena Raider survives, Iron Hyena Den at 6/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 3.
- Result: Bone-Cracker Cub survives, Iron Hyena Den at 3/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Iron Hyena Champion
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 5/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 1/10
- board at end: Black-Tooth Smith, Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Hyena Raider [Relic:Fang Relic]

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Blood-Scent Hyena, Hyena Token, Iron Hyena Raider, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Blood-Scent Hyena into Iron Hyena Champion (dealt 2 to Iron Hyena Den)

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
- Attacker: Pack Harrier
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 1.
- Result: Pack Harrier survives, Iron Hyena Den at 0/10

Main 2:
- pass

End:
- retained card: Pack Harrier
- discarded cards: Bone-Cracker Cub, Pack Harrier, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Hyena Token, Iron Hyena Champion, Iron Hyena Raider, Pack Harrier

## Turn 16 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Hyena Raider [Relic:Fang Relic]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Iron Hyena Den)

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Iron Hyena Den
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Black-Tooth Smith becomes Wounded.
- Damage: Hyena Token deals 1 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Hyena Token.
- Result: Black-Tooth Smith survives, Hyena Token removed, Iron Hyena Den at 1/10

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Iron Hyena Raider.
- Result: Iron Hyena Raider left battle, Iron Hyena Raider removed, Iron Hyena Den at 1/10

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Bone-Cracker Cub, Iron Hyena Raider, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 1/10
- board at end: Black-Tooth Smith [Wounded], Fang Relic, Iron Hyena Champion

# End of Phase 4 Summary

Shrine state: Red [Iron Hyena Den: 10/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 1/10] | Iron [Iron Hyena Den: 7/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/0 | Iron 5/2
Awakened Ancestors: Red None | Iron Ancestor of the First Pack
Forgotten cards: Red 5 | Iron 4
Key events: Main 1: evolved Blood-Scent Hyena into Iron Hyena Champion (dealt 2 to Iron Hyena Den) | Hyena Token deals 1 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Hyena Token. | Iron Hyena Raider deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Iron Hyena Raider. | Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Iron Hyena Den)
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Wounded], Fang Relic, Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 2 to 1. | Iron Hyena Champion becomes Wounded.
- Damage: Iron Hyena Champion deals 5 to Black-Tooth Smith. | Black-Tooth Smith deals 1 to Iron Hyena Champion.
- Result: Black-Tooth Smith left battle, Iron Hyena Champion survives, Iron Hyena Den at 1/10

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 5 to 3.
- Damage: Iron Hyena Champion deals 3 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Iron Hyena Champion.
- Result: Iron Hyena Champion left battle, Iron Hyena Champion removed, Iron Hyena Den at 1/10

Main 2:
- Main 2: played Iron Hyena Raider
- Main 2: played Iron Guard

End:
- retained card: Iron Hyena Underworld
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 1/10
- board at end: Fang Relic, Iron Guard, Iron Hyena Raider

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 2

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Pack Harrier

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Iron Guard
- Defender/blocker: Iron Guard
- Prepared triggers: None
- Wounded/Pierce calculations: Black-Tooth Smith becomes Wounded. | Iron Guard becomes Wounded.
- Damage: Iron Guard deals 2 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Iron Guard.
- Result: Black-Tooth Smith survives, Iron Guard survives

Attack 2:
- Attacker: Pack Harrier
- Target: Iron Guard
- Defender/blocker: Iron Guard
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Guard from 2 to 1.
- Damage: Iron Guard deals 1 to Pack Harrier. | Pack Harrier deals 2 to Iron Guard.
- Result: Pack Harrier left battle, Iron Guard removed

Main 2:
- Main 2: played Pack Harrier
- Main 2: played Blood-Scent Hyena

End:
- retained card: Pack Harrier
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 1/10
- board at end: Black-Tooth Smith [Wounded], Blood-Scent Hyena, Pack Harrier

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Fang Relic, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)
- Main 1: played Rust Hyena Spirit

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
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Iron Hyena Underworld, False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 1/10
- board at end: Fang Relic, Hyena Token, Hyena Token, Iron Hyena Raider, Rust Hyena Spirit

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 2

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Wounded], Blood-Scent Hyena, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 2 to 1.
- Damage: Shrine Rusted Moon Shrine takes 1.
- Result: Black-Tooth Smith survives, Rusted Moon Shrine at 8/10

Attack 2:
- Attacker: Pack Harrier
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 1.
- Result: Pack Harrier survives, Rusted Moon Shrine at 7/10

Attack 3:
- Attacker: Blood-Scent Hyena
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 2.
- Result: Blood-Scent Hyena survives, Rusted Moon Shrine at 4/10

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Iron Hyena Raider, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: Black-Tooth Smith
- resources at end: 6 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 1/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena, Bone-Cracker Cub, Pack Harrier, Pack Harrier

# End of Phase 5 Summary

Shrine state: Red [Iron Hyena Den: 10/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 1/10] | Iron [Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 1/10]
Resources: Red 4/0 | Iron 6/2
Awakened Ancestors: Red None | Iron Ancestor of the First Pack
Forgotten cards: Red 5 | Iron 4
Key events: Main 1: played Rust Hyena Spirit | Shrine Rusted Moon Shrine takes 1. | Shrine Rusted Moon Shrine takes 1. | Shrine Rusted Moon Shrine takes 2. | Main 1: played Pack Harrier | Main 1: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Iron

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 2

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Blood-Scent Hyena, Bone-Cracker Cub, Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Rusted Moon Shrine)

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 2.
- Result: Black-Tooth Smith survives, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Blood-Scent Hyena, Hyena Token, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 1/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena, Bone-Cracker Cub, Iron Hyena Champion, Pack Harrier

## End-of-game summary

Winner: iron-hyena-pack-pressure
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Iron Hyena Den 10/10, Bone-Fang Shrine 12/10, Rusted Moon Shrine 10/10] | Iron [Iron Hyena Den 12/10, Bone-Fang Shrine 11/10, Rusted Moon Shrine 1/10]
Final resources: Red 4/0 | Iron 5/2
Final Presence: Seat 1 4/5 | Seat 2 5/5

Turn count: 21
Phase count: 6

First Shrine damage: 3 (Seat 1/Red: 5, Seat 2/Iron: 3)
First Shrine broken: 10 (Seat 1/Red: 10, Seat 2/Iron: 11)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 6, Iron 22
First Ancestor awakened: 12
First L2: 7
First L3: 

Red L2 entries: 1 (hard-cast 0, evolved 1)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 3 (hard-cast 0, evolved 3)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 4, Iron 10
Legal L2 evolve actions: Red 4, Iron 10
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 2, Iron 6
Turns with legal L2 evolution: Red 2, Iron 6
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 4, Iron 8
Hard-cast chosen while legal evolve action existed: Red 1, Iron 0
Hard-cast chosen while evolution base existed: Red 0, Iron 0

Legal awaken actions generated: Red 0, Iron 7
Awaken actions chosen: Red 0, Iron 4
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red None, Iron iron.ancestor.firstpack
Ancestor switches: Red 0, Iron 0
Turns with awakened ancestor: Red 0, Iron 5
Memory spent on ancestors: Red 0, Iron 2
Ancestor realized value: First Hunter +0 damage, Grandmother healed 0, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 2, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 5, Iron 4
Wounded events: Red 3, Iron 2
Wounded reduced damage: Red 3, Iron 2
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 2, Iron 8
Blocks chosen: Red 0, Iron 5
Blocks declined: Red 2, Iron 0
Assault slots spent: Seat 1 standard 3, pack 6 | Seat 2 standard 5, pack 8
Pack diagnostics: Seat 1 ready-at-combat 8, generated 8, available 8, skipped 2, turns-with-bonus 6, max-attacks 28, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 15, generated 14, available 14, skipped 6, turns-with-bonus 8, max-attacks 36, prevented-by-limit 0
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
