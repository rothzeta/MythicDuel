# Test Game #560

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

Seed: 560
Winner: iron-snarecraft-control
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Bite the Roots, Bone Spear, Iron Hyena Raider, Pack Harrier, Pack Harrier
- Starting hands — Iron: Bite the Roots, Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang
- Starting Lineage — Iron: Ancestor of the Iron Hyena, Tooth-Mother of the Dry Earth, Smith of Black Teeth

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Bone Spear, Iron Hyena Raider, Pack Harrier, Pack Harrier]

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
- retained card: Bite the Roots
- discarded cards: Bone Spear, Iron Hyena Raider, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Pack Harrier

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider]

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
- retained card: Bite the Roots
- discarded cards: Bone Spear, Iron Hyena Raider, Fang Relic
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
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
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
- retained card: Blood-Scent Hyena
- discarded cards: Iron Hyena Champion, Pack Harrier, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Pack Harrier

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
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
- retained card: Bite the Roots
- discarded cards: Bone-Cracker Cub, Iron Snare, False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 1
Key events: Main 1: played Pack Harrier | Main 1: played Bone-Cracker Cub | Shrine Bone-Fang Shrine takes 2. | Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine) | Shrine Bone-Fang Shrine takes 4. | Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bite the Roots
- discarded cards: Hyena Pack Call, Black-Tooth Smith, Bite the Roots
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Champion

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: attached Bone Spear to Pack Harrier
- Main 1: attached Fang Relic to Pack Harrier

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Pack Harrier survives, Bone-Fang Shrine at 2/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Blood-Scent Hyena, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Fang Relic, Pack Harrier [Relic:Fang Relic]

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine, broke it, gained 1 Memory)
- Main 1: played Rust Hyena Spirit

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Hyena Champion, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Champion, Rust Hyena Spirit

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone Spear, Fang Relic, Pack Harrier [Relic:Fang Relic]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Bone-Fang Shrine
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Hyena Champion becomes Wounded. | Pack Harrier deals 1 to blocked Shrine.
- Damage: Iron Hyena Champion deals 5 to Pack Harrier. | Pack Harrier deals 2 to Iron Hyena Champion. | Shrine Bone-Fang Shrine takes 1.
- Result: Pack Harrier left battle, Iron Hyena Champion survives, Bone-Fang Shrine at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Hyena Token

# End of Phase 2 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 1/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/0 | Iron 0/2
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 2 | Iron 2
Key events: Main 1: played Rust Hyena Spirit | Iron Hyena Champion deals 5 to Pack Harrier. | Pack Harrier deals 2 to Iron Hyena Champion. | Shrine Bone-Fang Shrine takes 1. | Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine) | Main 1: played Blood-Scent Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
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
- Attacker: Hyena Token
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 1.
- Result: Hyena Token survives, Iron Hyena Den at 5/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear, Hyena Token, Iron Hyena Raider

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 2

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Iron Hyena Champion [Wounded], Rust Hyena Spirit
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 5/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: evolved Iron Hyena Champion into Iron Hyena Underworld (dealt 2 to Iron Hyena Den; dealt 2 to Rusted Moon Shrine)

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Iron Hyena Raider.
- Result: Rust Hyena Spirit left battle, Iron Hyena Raider removed

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Iron Snare, Black-Tooth Smith, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
- board at end: Iron Hyena Underworld

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear, Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 3/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 2/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den)
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:
- no attacks

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Fang Relic
- discarded cards: Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 3/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 2/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena, Blood-Scent Hyena, Bone Spear, Hyena Token, Hyena Token

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Iron Hyena Underworld
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: prepared False Opening
- Main 1: attached Bone Spear to Iron Hyena Underworld

Combat:

Attack 1:
- Attacker: Iron Hyena Underworld
- Target: Iron Hyena Den
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Hyena Underworld becomes Wounded. | Bone Spear grants Pierce against damaged Shrine. | Pierce overflow deals 7 to Iron Hyena Den.
- Damage: Hyena Token deals 1 to Iron Hyena Underworld. | Iron Hyena Underworld deals 8 to Hyena Token. | Shrine Iron Hyena Den takes 7.
- Result: Iron Hyena Underworld survives, Hyena Token removed, Iron Hyena Den at 0/10

Main 2:
- Main 2: played Iron Guard

End:
- retained card: Fang Relic
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
- board at end: Bone Spear, Iron Guard, Iron Hyena Underworld [Wounded, Relic:Bone Spear]

# End of Phase 3 Summary

Shrine state: Red [Iron Hyena Den: 3/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 2/10] | Iron [Iron Hyena Den: 10/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10]
Resources: Red 0/0 | Iron 2/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 4 | Iron 2
Key events: Hyena Token deals 1 to Iron Hyena Underworld. | Iron Hyena Underworld deals 8 to Hyena Token. | Shrine Iron Hyena Den takes 7. | Main 1: prepared False Opening | Main 1: attached Bone Spear to Iron Hyena Underworld | Main 2: played Iron Guard
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Bone Spear, Iron Guard, Iron Hyena Underworld [Wounded, Relic:Bone Spear]
Prepared Tactic: False Opening
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Underworld

Combat:

Attack 1:
- Attacker: Iron Hyena Underworld
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Underworld from 8 to 6.
- Damage: Shrine Rusted Moon Shrine takes 6.
- Result: Iron Hyena Underworld survives, Rusted Moon Shrine at 1/10

Attack 2:
- Attacker: Iron Guard
- Target: Rusted Moon Shrine
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Guard becomes Wounded.
- Damage: Blood-Scent Hyena deals 2 to Iron Guard. | Iron Guard deals 2 to Blood-Scent Hyena.
- Result: Iron Guard survives, Blood-Scent Hyena removed, Rusted Moon Shrine at 1/10

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: played Rust Hyena Spirit

End:
- retained card: Hyena Pack Call
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: Iron Hyena Underworld
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
- board at end: Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Guard [Wounded], Iron Hyena Underworld [Relic:Fang Relic], Rust Hyena Spirit

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Blood-Scent Hyena, Bone Spear, Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 9/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Iron Hyena Underworld
- Defender/blocker: Iron Hyena Underworld
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Hyena Underworld becomes Wounded.
- Damage: Iron Hyena Underworld deals 8 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Iron Hyena Underworld.
- Result: Black-Tooth Smith left battle, Iron Hyena Underworld survives

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Iron Hyena Underworld
- Defender/blocker: Iron Hyena Underworld
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Underworld from 8 to 6.
- Damage: Iron Hyena Underworld deals 6 to Blood-Scent Hyena. | Blood-Scent Hyena deals 3 to Iron Hyena Underworld.
- Result: Blood-Scent Hyena left battle, Iron Hyena Underworld removed

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: played Bone-Cracker Cub

End:
- retained card: Pack Harrier
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 9/10
- board at end: Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Hyena Token

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Iron Guard [Wounded], Rust Hyena Spirit
Prepared Tactic: False Opening
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Iron Hyena Underworld]

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Iron Guard
- Target: Rusted Moon Shrine
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Guard from 2 to 1. | Iron Guard becomes Wounded.
- Damage: Hyena Token deals 1 to Iron Guard. | Iron Guard deals 1 to Hyena Token.
- Result: Iron Guard survives, Hyena Token removed, Rusted Moon Shrine at 1/10

Attack 2:
- Attacker: Rust Hyena Spirit
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Bone-Cracker Cub.
- Result: Rust Hyena Spirit left battle, Bone-Cracker Cub removed

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Hyena Pack Call, Hyena Pack Call, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 7 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
- board at end: Bone Spear, Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Iron Guard [Wounded]

## End-of-game summary

Winner: iron-snarecraft-control
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Iron Hyena Den 10/10, Bone-Fang Shrine 12/10, Rusted Moon Shrine 10/10] | Iron [Iron Hyena Den 10/10, Bone-Fang Shrine 10/10, Rusted Moon Shrine 1/10]
Final resources: Red 3/0 | Iron 7/1
Final Presence: Seat 1 1/5 | Seat 2 2/5

Turn count: 15
Phase count: 4

First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine broken: 7 (Seat 1/Red: 7, Seat 2/Iron: 8)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 7, Iron 23
First Ancestor awakened: 
First L2: 5
First L3: 10

Red L2 entries: 0 (hard-cast 0, evolved 0)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 1 (hard-cast 0, evolved 1)
Iron L3 entries: 1 (hard-cast 0, evolved 1)

Legal evolve actions generated: Red 0, Iron 4
Legal L2 evolve actions: Red 0, Iron 2
Legal L3 evolve actions: Red 0, Iron 2
Evolve windows: Red 0, Iron 4
Turns with legal L2 evolution: Red 0, Iron 2
Turns with legal L3 evolution: Red 0, Iron 2
Evolve actions chosen: Red 0, Iron 3
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 0, Iron 0

Legal awaken actions generated: Red 0, Iron 0
Awaken actions chosen: Red 0, Iron 0
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red None, Iron None
Ancestor switches: Red 0, Iron 0
Turns with awakened ancestor: Red 0, Iron 0
Memory spent on ancestors: Red 0, Iron 0
Ancestor realized value: First Hunter +0 damage, Grandmother healed 0, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 4, Iron 3
Wounded events: Red 0, Iron 5
Wounded reduced damage: Red 0, Iron 3
Pierce overflow events: Red 0, Iron 1
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 8, Iron 4
Blocks chosen: Red 3, Iron 1
Blocks declined: Red 1, Iron 3
Assault slots spent: Seat 1 standard 2, pack 5 | Seat 2 standard 6, pack 1
Pack diagnostics: Seat 1 ready-at-combat 7, generated 7, available 7, skipped 2, turns-with-bonus 6, max-attacks 21, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 4, generated 4, available 4, skipped 3, turns-with-bonus 4, max-attacks 20, prevented-by-limit 0
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
