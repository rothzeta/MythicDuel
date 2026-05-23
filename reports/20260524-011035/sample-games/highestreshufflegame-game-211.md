# Test Game #211

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

Seed: 211
Winner: iron-snarecraft-control
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Bite the Roots, Black-Tooth Smith, Black-Tooth Smith, Blood-Scent Hyena, Iron Hyena Champion
- Starting hands — Iron: False Opening, Iron Hyena Champion, Iron Hyena Raider, Iron Hyena Raider, Rust Hyena Spirit
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang
- Starting Lineage — Iron: Ancestor of the Iron Hyena, Tooth-Mother of the Dry Earth, Smith of Black Teeth

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Black-Tooth Smith, Black-Tooth Smith, Blood-Scent Hyena, Iron Hyena Champion]

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
- discarded cards: Black-Tooth Smith, Black-Tooth Smith, Blood-Scent Hyena, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [False Opening, Iron Hyena Champion, Iron Hyena Raider, Iron Hyena Raider, Rust Hyena Spirit]

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
- retained card: Iron Hyena Raider
- discarded cards: False Opening, Rust Hyena Spirit, Iron Hyena Champion, Iron Hyena Raider
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
- discarded cards: Iron Hyena Raider, Blood-Scent Hyena, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Raider]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Raider
- discarded cards: False Opening, Bone Spear, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: 

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 1
Key events: Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine) | Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Iron Hyena Raider]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: prepared Iron Snare
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Pack Call, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Blood-Scent Hyena

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Bone-Cracker Cub, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Iron Hyena Raider
Prepared Tactic: Iron Snare
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)
- Main 1: attached Fang Relic to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 5.
- Result: Iron Hyena Raider survives, Bone-Fang Shrine at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Bone-Cracker Cub, Rust Hyena Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Iron Hyena Raider [Relic:Fang Relic]

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: attached Fang Relic to Blood-Scent Hyena
- Main 1: attached Fang Relic to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Blood-Scent Hyena survives, Bone-Fang Shrine at 4/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Bone-Cracker Cub survives, Bone-Fang Shrine at 1/10

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Hyena Pack Call, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena [Relic:Fang Relic], Bone-Cracker Cub, Fang Relic, Fang Relic

# End of Phase 2 Summary

Shrine state: Red [Iron Hyena Den: 1/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 2
Key events: Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine) | Main 1: attached Fang Relic to Iron Hyena Raider | Shrine Bone-Fang Shrine takes 3. | Shrine Bone-Fang Shrine takes 3. | Main 1: attached Fang Relic to Blood-Scent Hyena | Main 1: attached Fang Relic to Blood-Scent Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Blood-Scent Hyena [Relic:Fang Relic], Bone-Cracker Cub, Fang Relic, Fang Relic
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: attached Bone Spear to Blood-Scent Hyena

Combat:
- no attacks

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: played Iron Hyena Raider

End:
- retained card: Bone Spear
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena [Relic:Bone Spear], Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Fang Relic, Hyena Token, Iron Hyena Raider

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Fang Relic, Iron Hyena Raider [Relic:Fang Relic]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 2/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: evolved Iron Hyena Raider into Iron Hyena Champion (dealt 2 to Iron Hyena Den)
- Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Raider, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 2/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Iron Hyena Champion [Relic:Fang Relic]

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Blood-Scent Hyena [Relic:Bone Spear], Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Fang Relic, Hyena Token, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den)
- Main 1: attached Bone Spear to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 3.
- Result: Blood-Scent Hyena survives, Iron Hyena Den at 2/10

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 6 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Iron Hyena Champion.
- Result: Iron Hyena Raider left battle, Iron Hyena Champion removed, Iron Hyena Den at 2/10

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 3.
- Result: Bone-Cracker Cub survives, Iron Hyena Den at 0/10

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Bone-Cracker Cub, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena [Relic:Bone Spear], Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Fang Relic, Hyena Token

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: prepared Iron Snare
- Main 1: played Black-Tooth Smith

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Guard
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
- board at end: Black-Tooth Smith [Relic:Bone Spear], Bone Spear

# End of Phase 3 Summary

Shrine state: Red [Iron Hyena Den: 6/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10]
Resources: Red 3/0 | Iron 2/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 3 | Iron 4
Key events: Iron Hyena Raider deals 4 to Iron Hyena Champion. | Shrine Iron Hyena Den takes 3. | Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den) | Main 1: attached Bone Spear to Iron Hyena Raider | Main 1: prepared Iron Snare | Main 1: played Black-Tooth Smith
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Iron Guard]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Relic:Bone Spear], Bone Spear
Prepared Tactic: Iron Snare
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 3.
- Result: Black-Tooth Smith survives, Iron Hyena Den at 1/10

Main 2:
- Main 2: played Iron Guard
- Main 2: played Black-Tooth Smith

End:
- retained card: Iron Hyena Underworld
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
- board at end: Black-Tooth Smith, Black-Tooth Smith [Relic:Bone Spear], Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Iron Guard

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Blood-Scent Hyena [Relic:Bone Spear], Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Fang Relic, Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Rusted Moon Shrine)

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: None
- Damage: Black-Tooth Smith deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Black-Tooth Smith.
- Result: Blood-Scent Hyena left battle, Black-Tooth Smith removed

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Iron Hyena Raider, Hyena Pack Call, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Fang Relic, Fang Relic, Hyena Token, Iron Hyena Champion

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone-Cracker Cub, Bone-Cracker Cub, Iron Guard
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Iron Guard
- Target: Iron Hyena Den
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Guard becomes Wounded.
- Damage: Hyena Token deals 1 to Iron Guard. | Iron Guard deals 2 to Hyena Token.
- Result: Iron Guard survives, Hyena Token removed, Iron Hyena Den at 1/10

Attack 2:
- Attacker: Black-Tooth Smith
- Target: Iron Hyena Den
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: Black-Tooth Smith becomes Wounded.
- Damage: Bone-Cracker Cub deals 2 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Bone-Cracker Cub.
- Result: Black-Tooth Smith survives, Bone-Cracker Cub removed, Iron Hyena Den at 1/10

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Iron Hyena Champion.
- Result: Bone-Cracker Cub left battle, Iron Hyena Champion removed, Iron Hyena Den at 1/10

Attack 4:
- Attacker: Bone-Cracker Cub
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 3.
- Result: Bone-Cracker Cub survives, Iron Hyena Den at 0/10

Main 2:
- Main 2: played Iron Guard

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Hyena Raider, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10
- board at end: Black-Tooth Smith [Wounded], Bone-Cracker Cub, Bone-Cracker Cub, Iron Guard, Iron Guard [Wounded]

## Turn 16 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Fang Relic, Fang Relic
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token)
- Main 1: played Blood-Scent Hyena

Combat:
- no attacks

Main 2:
- Main 2: played Pack Harrier

End:
- retained card: Blood-Scent Hyena
- discarded cards: Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Fang Relic, Fang Relic, Hyena Token, Pack Harrier

# End of Phase 4 Summary

Shrine state: Red [Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10]
Resources: Red 4/0 | Iron 5/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 4 | Iron 5
Key events: Shrine Iron Hyena Den takes 3. | Main 1: played Bone-Cracker Cub | Main 2: played Iron Guard | Main 1: resolved Pack Ambush (summoned Hyena Token) | Main 1: played Blood-Scent Hyena | Main 2: played Pack Harrier
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Fang Relic, Fang Relic, Hyena Token, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 2 to 1. | Black-Tooth Smith becomes Wounded.
- Damage: Black-Tooth Smith deals 1 to Hyena Token. | Hyena Token deals 1 to Black-Tooth Smith.
- Result: Hyena Token left battle, Black-Tooth Smith survives

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 2 to 1. | Blood-Scent Hyena becomes Wounded.
- Damage: Black-Tooth Smith deals 1 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Black-Tooth Smith.
- Result: Blood-Scent Hyena survives, Black-Tooth Smith removed

Main 2:
- Main 2: played Iron Hyena Champion

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena [Wounded], Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Hyena Champion, Pack Harrier

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 1

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Bone-Cracker Cub, Iron Guard, Iron Guard [Wounded]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Rusted Moon Shrine)

Combat:

Attack 1:
- Attacker: Iron Guard
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Guard from 2 to 1.
- Damage: Shrine Rusted Moon Shrine takes 1.
- Result: Iron Guard survives, Rusted Moon Shrine at 7/10

Attack 2:
- Attacker: Iron Guard
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 2.
- Result: Iron Guard survives, Rusted Moon Shrine at 5/10

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 3.
- Result: Bone-Cracker Cub survives, Rusted Moon Shrine at 2/10

Main 2:
- Main 2: played Rust Hyena Spirit

End:
- retained card: Iron Hyena Underworld
- discarded cards: Bone Spear, Fang Relic
- forgotten cards: None
- Wounded clears: Iron Guard
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10
- board at end: Bone-Cracker Cub, Iron Guard, Iron Guard, Iron Hyena Champion, Rust Hyena Spirit

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Blood-Scent Hyena [Wounded], Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Hyena Champion, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 8/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Blood-Scent Hyena from 2 to 1. | Iron Hyena Champion becomes Wounded.
- Damage: Iron Hyena Champion deals 5 to Blood-Scent Hyena. | Blood-Scent Hyena deals 1 to Iron Hyena Champion.
- Result: Blood-Scent Hyena left battle, Iron Hyena Champion survives

Attack 2:
- Attacker: Pack Harrier
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 5 to 3. | Iron Hyena Champion becomes Wounded.
- Damage: Iron Hyena Champion deals 3 to Pack Harrier. | Pack Harrier deals 1 to Iron Hyena Champion.
- Result: Pack Harrier left battle, Iron Hyena Champion survives

Attack 3:
- Attacker: Blood-Scent Hyena
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 5 to 3.
- Damage: Iron Hyena Champion deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Iron Hyena Champion.
- Result: Blood-Scent Hyena left battle, Iron Hyena Champion removed

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Bone-Cracker Cub, Bone-Cracker Cub, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 8/10
- board at end: Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Hyena Champion

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Iron Guard, Iron Guard, Rust Hyena Spirit
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Bone-Cracker Cub
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Iron Guard
- Target: Rusted Moon Shrine
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Guard becomes Wounded.
- Damage: Bone-Cracker Cub deals 2 to Iron Guard. | Iron Guard deals 2 to Bone-Cracker Cub.
- Result: Iron Guard survives, Bone-Cracker Cub removed, Rusted Moon Shrine at 2/10

Attack 2:
- Attacker: Iron Guard
- Target: Rusted Moon Shrine
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Hyena Champion becomes Wounded.
- Damage: Iron Hyena Champion deals 5 to Iron Guard. | Iron Guard deals 2 to Iron Hyena Champion.
- Result: Iron Guard left battle, Iron Hyena Champion survives, Rusted Moon Shrine at 2/10

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Rusted Moon Shrine
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 5 to 3.
- Damage: Iron Hyena Champion deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to Iron Hyena Champion.
- Result: Bone-Cracker Cub left battle, Iron Hyena Champion removed, Rusted Moon Shrine at 2/10

Main 2:
- Main 2: played Iron Hyena Raider
- Main 2: played Black-Tooth Smith

End:
- retained card: Iron Hyena Underworld
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10
- board at end: Black-Tooth Smith, Fang Relic, Iron Guard [Wounded], Iron Hyena Raider [Relic:Fang Relic], Rust Hyena Spirit

# End of Phase 5 Summary

Shrine state: Red [Iron Hyena Den: 12/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 8/10] | Iron [Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10]
Resources: Red 6/0 | Iron 0/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 4 | Iron 5
Key events: Iron Hyena Champion deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to Iron Hyena Champion. | Main 1: attached Fang Relic to Bone-Cracker Cub | Main 1: attached Bone Spear to Bone-Cracker Cub | Main 2: played Iron Hyena Raider | Main 2: played Black-Tooth Smith
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Fang Relic, Iron Guard [Wounded], Iron Hyena Raider [Relic:Fang Relic], Rust Hyena Spirit
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: evolved Iron Hyena Raider into Iron Hyena Champion (dealt 2 to Rusted Moon Shrine and broke it)
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Underworld
- discarded cards: Hyena Pack Call, Hyena Pack Call
- forgotten cards: None
- Wounded clears: Iron Guard
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10
- board at end: Black-Tooth Smith, Fang Relic, Iron Guard, Iron Hyena Champion [Relic:Fang Relic], Iron Hyena Raider, Rust Hyena Spirit

## End-of-game summary

Winner: iron-snarecraft-control
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Iron Hyena Den 12/10, Bone-Fang Shrine 11/10, Rusted Moon Shrine 10/10] | Iron [Iron Hyena Den 11/10, Bone-Fang Shrine 10/10, Rusted Moon Shrine 3/10]
Final resources: Red 6/0 | Iron 3/1
Final Presence: Seat 1 0/5 | Seat 2 5/5

Turn count: 21
Phase count: 6

First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine broken: 7 (Seat 1/Red: 7, Seat 2/Iron: 9)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 9, Iron 8
First Ancestor awakened: 
First L2: 10
First L3: 

Red L2 entries: 2 (hard-cast 1, evolved 1)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 3 (hard-cast 0, evolved 3)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 4, Iron 6
Legal L2 evolve actions: Red 4, Iron 6
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 2, Iron 6
Turns with legal L2 evolution: Red 2, Iron 6
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 4, Iron 6
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 1, Iron 0

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
Wounded events: Red 2, Iron 6
Wounded reduced damage: Red 2, Iron 5
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 15, Iron 2
Blocks chosen: Red 6, Iron 1
Blocks declined: Red 4, Iron 1
Assault slots spent: Seat 1 standard 0, pack 11 | Seat 2 standard 7, pack 5
Pack diagnostics: Seat 1 ready-at-combat 18, generated 15, available 15, skipped 4, turns-with-bonus 6, max-attacks 35, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 8, generated 8, available 8, skipped 3, turns-with-bonus 6, max-attacks 30, prevented-by-limit 0
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
