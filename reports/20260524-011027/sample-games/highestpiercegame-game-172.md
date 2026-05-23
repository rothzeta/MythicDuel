# Test Game #172

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

Seed: 172
Winner: iron-hyena-pack-pressure
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Black-Tooth Smith, Bone-Cracker Cub, False Opening, Hyena Pack Call, Iron Hyena Raider
- Starting hands — Iron: Bite the Roots, Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Pack Harrier
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: Ancestor of the Iron Hyena, Tooth-Mother of the Dry Earth, Smith of Black Teeth
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith, Bone-Cracker Cub, False Opening, Hyena Pack Call, Iron Hyena Raider]

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
- discarded cards: Hyena Pack Call, Iron Hyena Raider, False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Pack Harrier]

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
- discarded cards: Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub
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
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Champion, Iron Guard, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub [Relic:Fang Relic], Fang Relic

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
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
- retained card: Pack Ambush
- discarded cards: Iron Hyena Raider, Pack Harrier, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Pack Harrier

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 1
Key events: Main 1: played Bone-Cracker Cub | Main 1: played Pack Harrier | Shrine Bone-Fang Shrine takes 3. | Main 1: attached Fang Relic to Bone-Cracker Cub | Shrine Bone-Fang Shrine takes 2. | Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Pack Ambush]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 2.
- Result: Pack Harrier survives, Bone-Fang Shrine at 1/10

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Bone Spear
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Hyena Token, Hyena Token, Pack Harrier

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone-Cracker Cub [Relic:Fang Relic], Fang Relic
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Black-Tooth Smith, Bone-Cracker Cub, Rust Hyena Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Iron Hyena Champion [Relic:Fang Relic]

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Hyena Token, Hyena Token, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine and broke it)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bite the Roots
- discarded cards: Bone Spear, Bone-Cracker Cub, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Hyena Token, Hyena Token, Iron Hyena Champion

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Fang Relic, Iron Hyena Champion [Relic:Fang Relic]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Champion
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Bone-Fang Shrine
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Hyena Champion becomes Wounded. | Bone Spear grants Pierce against damaged Shrine. | Pierce overflow deals 5 to Bone-Fang Shrine.
- Damage: Hyena Token deals 1 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Hyena Token. | Shrine Bone-Fang Shrine takes 5.
- Result: Iron Hyena Champion survives, Hyena Token removed, Bone-Fang Shrine at 0/10

Main 2:
- Main 2: played Iron Hyena Raider

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Champion [Wounded, Relic:Bone Spear], Iron Hyena Raider

# End of Phase 2 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 1/0
Awakened Ancestors: Red None | Iron Ancestor of the First Pack
Forgotten cards: Red 0 | Iron 3
Key events: Hyena Token deals 1 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Hyena Token. | Shrine Bone-Fang Shrine takes 5. | Main 1: attached Bone Spear to Iron Hyena Champion | Main 1: played Bone-Cracker Cub | Main 2: played Iron Hyena Raider
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Champion [Wounded, Relic:Bone Spear], Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den)
- Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den)

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Iron Hyena Den
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 6 to 4. | Iron Hyena Champion becomes Wounded. | Bone Spear grants Pierce against damaged Shrine. | Pierce overflow deals 3 to Iron Hyena Den.
- Damage: Hyena Token deals 1 to Iron Hyena Champion. | Iron Hyena Champion deals 4 to Hyena Token. | Shrine Iron Hyena Den takes 3.
- Result: Iron Hyena Champion survives, Hyena Token removed, Iron Hyena Den at 1/10

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Iron Hyena Den
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Bone-Cracker Cub.
- Result: Iron Hyena Raider left battle, Bone-Cracker Cub removed, Iron Hyena Den at 1/10

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Iron Hyena Champion.
- Result: Bone-Cracker Cub left battle, Iron Hyena Champion removed, Iron Hyena Den at 1/10

Main 2:
- pass

End:
- retained card: Iron Hyena Underworld
- discarded cards: Fang Relic, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Fang Relic, Iron Hyena Champion [Wounded, Relic:Bone Spear]

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den)
- Main 1: played Blood-Scent Hyena

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Blood-Scent Hyena, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Bone Spear, Fang Relic, Iron Hyena Champion [Wounded, Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 3/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den, broke it, gained 1 Memory)
- Main 1: prepared Iron Snare

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Hyena Raider, False Opening
- forgotten cards: None
- Wounded clears: Iron Hyena Champion
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 3/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Fang Relic, Iron Hyena Champion [Relic:Bone Spear]

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Blood-Scent Hyena
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Blood-Scent Hyena
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 3.
- Result: Blood-Scent Hyena survives, Iron Hyena Den at 4/10

Main 2:
- Main 2: played Blood-Scent Hyena

End:
- retained card: Pack Harrier
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena [Relic:Fang Relic], Fang Relic, Iron Hyena Raider

# End of Phase 3 Summary

Shrine state: Red [Iron Hyena Den: 3/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/1 | Iron 0/0
Awakened Ancestors: Red None | Iron Ancestor of the First Pack
Forgotten cards: Red 3 | Iron 4
Key events: Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den, broke it, gained 1 Memory) | Main 1: prepared Iron Snare | Shrine Iron Hyena Den takes 3. | Main 1: attached Fang Relic to Blood-Scent Hyena | Main 1: played Iron Hyena Raider | Main 2: played Blood-Scent Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Blood-Scent Hyena [Relic:Fang Relic], Fang Relic, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Blood-Scent Hyena into Iron Hyena Champion (dealt 2 to Iron Hyena Den)
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Ancestor of the First Pack deals 1 to blocked Shrine.
- Damage: Iron Hyena Champion deals 6 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Iron Hyena Champion. | Shrine Iron Hyena Den takes 1.
- Result: Iron Hyena Raider left battle, Iron Hyena Champion removed, Iron Hyena Den at 1/10

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 2.
- Result: Blood-Scent Hyena survives, Iron Hyena Den at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Pack Harrier, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Fang Relic, Iron Hyena Champion [Relic:Fang Relic], Pack Harrier

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Fang Relic
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: prepared Iron Snare
- Main 1: played Black-Tooth Smith

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Underworld, Rust Hyena Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 3/10
- board at end: Black-Tooth Smith, Fang Relic

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Fang Relic, Iron Hyena Champion [Relic:Fang Relic], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Black-Tooth Smith

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 2.
- Result: Blood-Scent Hyena survives, Rusted Moon Shrine at 4/10

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 6.
- Result: Iron Hyena Champion survives, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 12/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena, Blood-Scent Hyena, Fang Relic, Iron Hyena Champion [Relic:Fang Relic], Pack Harrier

## End-of-game summary

Winner: iron-hyena-pack-pressure
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Iron Hyena Den 11/10, Bone-Fang Shrine 11/10, Rusted Moon Shrine 13/10] | Iron [Iron Hyena Den 12/10, Bone-Fang Shrine 10/10, Rusted Moon Shrine 0/10]
Final resources: Red 3/1 | Iron 3/0
Final Presence: Seat 1 1/5 | Seat 2 5/5

Turn count: 15
Phase count: 4

First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine broken: 7 (Seat 1/Red: 7, Seat 2/Iron: 8)
Wins in odd phase: 0
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 14, Iron 20
First Ancestor awakened: 5
First L2: 6
First L3: 

Red L2 entries: 1 (hard-cast 0, evolved 1)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 2 (hard-cast 0, evolved 2)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 2, Iron 4
Legal L2 evolve actions: Red 2, Iron 4
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 2, Iron 4
Turns with legal L2 evolution: Red 2, Iron 4
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 2, Iron 4
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 0, Iron 0

Legal awaken actions generated: Red 0, Iron 1
Awaken actions chosen: Red 0, Iron 1
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red None, Iron iron.ancestor.firstpack
Ancestor switches: Red 0, Iron 0
Turns with awakened ancestor: Red 0, Iron 5
Memory spent on ancestors: Red 0, Iron 2
Ancestor realized value: First Hunter +0 damage, Grandmother healed 0, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 2, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 5, Iron 4
Wounded events: Red 2, Iron 0
Wounded reduced damage: Red 1, Iron 0
Pierce overflow events: Red 2, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 2, Iron 10
Blocks chosen: Red 1, Iron 4
Blocks declined: Red 1, Iron 0
Assault slots spent: Seat 1 standard 0, pack 5 | Seat 2 standard 0, pack 7
Pack diagnostics: Seat 1 ready-at-combat 7, generated 7, available 7, skipped 2, turns-with-bonus 5, max-attacks 21, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 11, generated 11, available 11, skipped 4, turns-with-bonus 6, max-attacks 27, prevented-by-limit 0
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
