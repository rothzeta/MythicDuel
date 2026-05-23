# Test Game #178

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

Seed: 178
Winner: iron-hyena-pack-pressure
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Black-Tooth Smith, Blood-Scent Hyena, Blood-Scent Hyena, Bone-Cracker Cub, Pack Harrier
- Starting hands — Iron: Bite the Roots, Blood-Scent Hyena, Bone-Cracker Cub, Iron Hyena Champion, Iron Hyena Raider
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith, Blood-Scent Hyena, Blood-Scent Hyena, Bone-Cracker Cub, Pack Harrier]

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
- retained card: Black-Tooth Smith
- discarded cards: Blood-Scent Hyena, Bone-Cracker Cub, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Pack Harrier

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Blood-Scent Hyena, Bone-Cracker Cub, Iron Hyena Champion, Iron Hyena Raider]

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
- discarded cards: Iron Hyena Champion, Iron Hyena Raider, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 1.
- Result: Pack Harrier survives, Bone-Fang Shrine at 9/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Pack Harrier, Pack Harrier

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 1/10, Rusted Moon Shrine: 0/10
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
- retained card: Bone Spear
- discarded cards: Pack Harrier, Iron Hyena Champion, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 1/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 1/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 1
Key events: Main 1: played Bone-Cracker Cub | Shrine Bone-Fang Shrine takes 1. | Main 1: played Pack Harrier | Main 1: played Bone-Cracker Cub | Shrine Bone-Fang Shrine takes 4. | Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub
- Main 1: attached Fang Relic to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 2.
- Result: Pack Harrier survives, Bone-Fang Shrine at 7/10

Attack 2:
- Attacker: Pack Harrier
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 2.
- Result: Pack Harrier survives, Bone-Fang Shrine at 5/10

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 5.
- Result: Bone-Cracker Cub survives, Bone-Fang Shrine at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Raider, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 7/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Pack Harrier, Pack Harrier

## Turn 6 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 4.
- Result: Bone-Cracker Cub survives, Bone-Fang Shrine at 0/10

Main 2:
- Main 2: played Pack Harrier
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Hyena Token, Pack Harrier

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Hyena Token, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: played Pack Harrier

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
- Attacker: Pack Harrier
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 1.
- Result: Pack Harrier survives, Iron Hyena Den at 4/10

Attack 3:
- Attacker: Hyena Token
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 1.
- Result: Hyena Token survives, Iron Hyena Den at 3/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Pack Harrier, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Hyena Token, Hyena Token, Pack Harrier, Pack Harrier

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den)
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 1.
- Result: Pack Harrier survives, Iron Hyena Den at 4/10

Attack 2:
- Attacker: Pack Harrier
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 1.
- Result: Pack Harrier survives, Iron Hyena Den at 3/10

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 4.
- Result: Bone-Cracker Cub survives, Iron Hyena Den at 0/10

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Black-Tooth Smith, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 7/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Hyena Token, Pack Harrier, Pack Harrier

# End of Phase 2 Summary

Shrine state: Red [Iron Hyena Den: 7/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 1/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/0 | Iron 2/1
Awakened Ancestors: Red None | Iron Ancestor of the First Pack
Forgotten cards: Red 2 | Iron 3
Key events: Main 1: played Pack Harrier | Shrine Iron Hyena Den takes 1. | Shrine Iron Hyena Den takes 1. | Shrine Iron Hyena Den takes 4. | Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den) | Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Hyena Token, Hyena Token, Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 4.
- Result: Bone-Cracker Cub survives, Iron Hyena Den at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Bone-Cracker Cub, Bone-Cracker Cub, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 1/10
- board at end: Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Hyena Token, Hyena Token, Pack Harrier, Pack Harrier

## Turn 10 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Hyena Token, Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Rusted Moon Shrine)

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 1.
- Result: Pack Harrier survives, Rusted Moon Shrine at 6/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 4.
- Result: Bone-Cracker Cub survives, Rusted Moon Shrine at 1/10

Attack 3:
- Attacker: Hyena Token
- Target: Rusted Moon Shrine
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Hyena Token deals 1 to Hyena Token. | Hyena Token deals 1 to Hyena Token.
- Result: Hyena Token left battle, Hyena Token removed, Rusted Moon Shrine at 1/10

Main 2:
- Main 2: resolved Bite the Roots (dealt 3 to Rusted Moon Shrine, broke it, gained 1 Memory)

End:
- retained card: Bone Spear
- discarded cards: Blood-Scent Hyena, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Iron Hyena Champion, Pack Harrier

## End-of-game summary

Winner: iron-hyena-pack-pressure
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Iron Hyena Den 11/10, Bone-Fang Shrine 12/10, Rusted Moon Shrine 0/10] | Iron [Iron Hyena Den 11/10, Bone-Fang Shrine 10/10, Rusted Moon Shrine 12/10]
Final resources: Red 0/1 | Iron 3/1
Final Presence: Seat 1 3/5 | Seat 2 4/5

Turn count: 10
Phase count: 2

First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine broken: 5 (Seat 1/Red: 6, Seat 2/Iron: 5)
Wins in odd phase: 0
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 0, Iron 12
First Ancestor awakened: 6
First L2: 10
First L3: 

Red L2 entries: 1 (hard-cast 0, evolved 1)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 0 (hard-cast 0, evolved 0)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 6, Iron 0
Legal L2 evolve actions: Red 6, Iron 0
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 2, Iron 0
Turns with legal L2 evolution: Red 2, Iron 0
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 3, Iron 0
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 0, Iron 0

Legal awaken actions generated: Red 0, Iron 2
Awaken actions chosen: Red 0, Iron 1
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red None, Iron iron.ancestor.firstpack
Ancestor switches: Red 0, Iron 0
Turns with awakened ancestor: Red 0, Iron 2
Memory spent on ancestors: Red 0, Iron 2
Ancestor realized value: First Hunter +0 damage, Grandmother healed 0, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 3, Iron 3
Wounded events: Red 0, Iron 0
Wounded reduced damage: Red 0, Iron 0
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 0, Iron 12
Blocks chosen: Red 0, Iron 1
Blocks declined: Red 0, Iron 2
Assault slots spent: Seat 1 standard 0, pack 10 | Seat 2 standard 1, pack 5
Pack diagnostics: Seat 1 ready-at-combat 10, generated 10, available 10, skipped 0, turns-with-bonus 4, max-attacks 20, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 7, generated 7, available 7, skipped 2, turns-with-bonus 4, max-attacks 17, prevented-by-limit 0
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
