# Test Game #128

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 100 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red iron --bot-iron iron --deck-red iron-hyena-pack-pressure --deck-iron iron-hyena-pack-pressure

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

Seed: 128
Winner: iron-hyena-pack-pressure
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic
- Starting hands — Iron: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub, Hyena Pack Call, Hyena Pack Call
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic]

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
- retained card: Bone Spear
- discarded cards: Fang Relic, Bone-Cracker Cub, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub, Hyena Pack Call, Hyena Pack Call]

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
- retained card: Bone Spear
- discarded cards: Hyena Pack Call, Blood-Scent Hyena, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub
- Main 1: played Pack Harrier

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
- retained card: Iron Hyena Champion
- discarded cards: Iron Hyena Raider, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Pack Harrier

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub

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
- Main 2: played Bone-Cracker Cub

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub [Relic:Bone Spear]

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 0
Key events: Shrine Bone-Fang Shrine takes 3. | Main 1: attached Bone Spear to Bone-Cracker Cub | Main 1: played Pack Harrier | Shrine Bone-Fang Shrine takes 3. | Main 1: attached Bone Spear to Bone-Cracker Cub | Main 2: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub [Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine)

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 4.
- Result: Bone-Cracker Cub survives, Bone-Fang Shrine at 1/10

Main 2:
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Bite the Roots
- discarded cards: Blood-Scent Hyena, Black-Tooth Smith, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Iron Hyena Champion [Relic:Bone Spear]

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine)

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 2.
- Result: Pack Harrier survives, Bone-Fang Shrine at 3/10

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Iron Hyena Raider, Hyena Pack Call, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Hyena Champion [Relic:Bone Spear], Pack Harrier

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Iron Hyena Champion [Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine, broke it, gained 1 Memory)
- Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Black-Tooth Smith, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Iron Hyena Champion [Relic:Bone Spear]

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone Spear, Iron Hyena Champion [Relic:Bone Spear], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 3/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine)

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Bone-Fang Shrine
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Hyena Champion becomes Wounded. | Bone Spear grants Pierce against damaged Shrine. | Pierce overflow deals 5 to Bone-Fang Shrine.
- Damage: Bone-Cracker Cub deals 2 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Bone-Cracker Cub. | Shrine Bone-Fang Shrine takes 5.
- Result: Iron Hyena Champion survives, Bone-Cracker Cub removed, Bone-Fang Shrine at 0/10

Main 2:
- pass

End:
- retained card: Bite the Roots
- discarded cards: Blood-Scent Hyena, Iron Hyena Raider, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 3/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Hyena Champion, Iron Hyena Champion [Wounded, Relic:Bone Spear]

# End of Phase 2 Summary

Shrine state: Red [Iron Hyena Den: 3/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/0 | Iron 0/1
Awakened Ancestors: Red None | Iron Ancestor of the First Pack
Forgotten cards: Red 0 | Iron 2
Key events: Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine, broke it, gained 1 Memory) | Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den) | Bone-Cracker Cub deals 2 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Bone-Cracker Cub. | Shrine Bone-Fang Shrine takes 5. | Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Bone-Fang Shrine)
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: Bone Spear, Iron Hyena Champion, Iron Hyena Champion [Wounded, Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 3/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den)
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 6 to 4.
- Damage: Shrine Iron Hyena Den takes 4.
- Result: Iron Hyena Champion survives, Iron Hyena Den at 3/10

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Iron Hyena Den
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 6 to Iron Hyena Champion. | Iron Hyena Champion deals 5 to Iron Hyena Champion.
- Result: Iron Hyena Champion left battle, Iron Hyena Champion removed, Iron Hyena Den at 3/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Blood-Scent Hyena, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: Iron Hyena Champion
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 3/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Hyena Champion [Relic:Bone Spear], Pack Harrier

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token)
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Fang Relic, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token, Iron Hyena Raider

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone Spear, Iron Hyena Champion [Relic:Bone Spear], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 3/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 6.
- Result: Iron Hyena Champion survives, Iron Hyena Den at 0/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Hyena Pack Call
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 3/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Relic:Fang Relic], Bone Spear, Fang Relic, Hyena Token, Hyena Token, Iron Hyena Champion [Relic:Bone Spear], Pack Harrier

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Hyena Token, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 15/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 4.
- Result: Iron Hyena Raider survives, Iron Hyena Den at 3/10

Attack 2:
- Attacker: Hyena Token
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 1.
- Result: Hyena Token survives, Iron Hyena Den at 2/10

Main 2:
- Main 2: played Iron Hyena Raider
- Main 2: played Bone-Cracker Cub

End:
- retained card: Blood-Scent Hyena
- discarded cards: Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 15/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Hyena Token, Iron Hyena Raider, Iron Hyena Raider [Relic:Bone Spear]

# End of Phase 3 Summary

Shrine state: Red [Iron Hyena Den: 3/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 15/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 2/1
Awakened Ancestors: Red None | Iron Ancestor of the First Pack
Forgotten cards: Red 3 | Iron 3
Key events: Main 2: played Black-Tooth Smith | Shrine Iron Hyena Den takes 4. | Shrine Iron Hyena Den takes 1. | Main 1: attached Bone Spear to Iron Hyena Raider | Main 2: played Iron Hyena Raider | Main 2: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Hyena Token, Iron Hyena Raider, Iron Hyena Raider [Relic:Bone Spear]
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 15/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Pack Ambush]

Main 1:
- Main 1: evolved Hyena Token into Iron Hyena Champion (dealt 2 to Iron Hyena Den and broke it)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Pack Ambush
- discarded cards: Blood-Scent Hyena, Pack Harrier, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 15/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Iron Hyena Champion, Iron Hyena Raider, Iron Hyena Raider [Relic:Bone Spear]

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Relic:Fang Relic], Bone Spear, Fang Relic, Hyena Token, Hyena Token, Iron Hyena Champion [Relic:Bone Spear], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Rusted Moon Shrine)
- Main 1: attached Bone Spear to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 3.
- Result: Black-Tooth Smith survives, Rusted Moon Shrine at 3/10

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Rusted Moon Shrine
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: Iron Hyena Champion becomes Wounded. | Bone Spear grants Pierce against damaged Shrine. | Pierce overflow deals 5 to Rusted Moon Shrine.
- Damage: Bone-Cracker Cub deals 2 to Iron Hyena Champion. | Iron Hyena Champion deals 6 to Bone-Cracker Cub. | Shrine Rusted Moon Shrine takes 5.
- Result: Iron Hyena Champion survives, Bone-Cracker Cub removed, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 10/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Relic:Fang Relic], Bone Spear, Bone Spear, Fang Relic, Hyena Token, Hyena Token, Iron Hyena Champion [Wounded, Relic:Bone Spear], Pack Harrier

## End-of-game summary

Winner: iron-hyena-pack-pressure
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Iron Hyena Den 10/10, Bone-Fang Shrine 12/10, Rusted Moon Shrine 0/10] | Iron [Iron Hyena Den 15/10, Bone-Fang Shrine 14/10, Rusted Moon Shrine 12/10]
Final resources: Red 4/0 | Iron 4/1
Final Presence: Seat 1 5/5 | Seat 2 3/5

Turn count: 14
Phase count: 4

First Shrine damage: 3
First Shrine broken: 7
First Ancestor awakened: 5
First L2: 5
First L3: 

Red L2 entries: 2 (hard-cast 0, evolved 2)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 2 (hard-cast 0, evolved 2)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 4, Iron 6
Legal L2 evolve actions: Red 4, Iron 6
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 4, Iron 4
Turns with legal L2 evolution: Red 4, Iron 4
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 4, Iron 6
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 0, Iron 0

Legal awaken actions generated: Red 0, Iron 1
Awaken actions chosen: Red 0, Iron 1
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red None, Iron iron.ancestor.firstpack
Ancestor switches: Red 0, Iron 0
Turns with awakened ancestor: Red 0, Iron 4
Memory spent on ancestors: Red 0, Iron 2
Ancestor realized value: First Hunter +0 damage, Grandmother healed 0, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 4, Iron 3
Wounded events: Red 2, Iron 0
Wounded reduced damage: Red 1, Iron 0
Pierce overflow events: Red 2, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 2, Iron 13
Blocks chosen: Red 0, Iron 3
Blocks declined: Red 2, Iron 3
Assault slots spent: Seat 1 standard 1, pack 7 | Seat 2 standard 1, pack 3
Pack diagnostics: Seat 1 ready-at-combat 11, generated 11, available 11, skipped 4, turns-with-bonus 6, max-attacks 25, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 10, generated 9, available 9, skipped 6, turns-with-bonus 5, max-attacks 23, prevented-by-limit 0
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
