# Test Game #133

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

Seed: 133
Winner: iron-hyena-pack-pressure
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider, Iron Hyena Raider
- Starting hands — Iron: Bite the Roots, Bone Spear, Hyena Pack Call, Iron Hyena Champion, Iron Hyena Raider
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider, Iron Hyena Raider]

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
- discarded cards: Iron Hyena Raider, Iron Hyena Raider, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Bone Spear, Hyena Pack Call, Iron Hyena Champion, Iron Hyena Raider]

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
- discarded cards: Bone Spear, Iron Hyena Raider, Hyena Pack Call, Iron Hyena Champion
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
- retained card: Pack Harrier
- discarded cards: Iron Hyena Raider, Hyena Pack Call, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub [Relic:Fang Relic], Fang Relic

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Bite the Roots]

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
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call, Hyena Pack Call, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: 

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 1
Key events: Main 1: played Bone-Cracker Cub | Shrine Bone-Fang Shrine takes 3. | Main 1: attached Fang Relic to Bone-Cracker Cub | Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Bone-Cracker Cub [Relic:Fang Relic], Fang Relic
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)
- Main 1: played Pack Harrier

Combat:

Attack 1:
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
- discarded cards: Pack Harrier, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Pack Harrier

## Turn 6 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Pack Harrier, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub

## Turn 7 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Iron Hyena Den)
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 5.
- Result: Bone-Cracker Cub survives, Iron Hyena Den at 1/10

Attack 2:
- Attacker: Pack Harrier
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 2.
- Result: Pack Harrier survives, Iron Hyena Den at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Pack Harrier

## Turn 8 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 1/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine)
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 2.
- Result: Blood-Scent Hyena survives, Bone-Fang Shrine at 1/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Bone-Cracker Cub survives, Bone-Fang Shrine at 0/10

Main 2:
- Main 2: played Bone-Cracker Cub

End:
- retained card: Fang Relic
- discarded cards: Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 11/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 1/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub, Bone-Cracker Cub, Hyena Token

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10] | Iron [Iron Hyena Den: 11/10, Bone-Fang Shrine: 11/10, Rusted Moon Shrine: 1/10]
Resources: Red 0/0 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 2 | Iron 3
Key events: Main 1: played Blood-Scent Hyena | Shrine Bone-Fang Shrine takes 2. | Shrine Bone-Fang Shrine takes 3. | Main 1: resolved Bite the Roots (dealt 3 to Bone-Fang Shrine) | Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine) | Main 2: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: attached Fang Relic to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 4.
- Result: Bone-Cracker Cub survives, Rusted Moon Shrine at 3/10

Attack 2:
- Attacker: Pack Harrier
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 1.
- Result: Pack Harrier survives, Rusted Moon Shrine at 2/10

Attack 3:
- Attacker: Blood-Scent Hyena
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: None
- Result: Blood-Scent Hyena survives, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Bone-Cracker Cub, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 1/10, Bone-Fang Shrine: 12/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena [Relic:Fang Relic], Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Fang Relic, Hyena Token, Pack Harrier

## End-of-game summary

Winner: iron-hyena-pack-pressure
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Iron Hyena Den 1/10, Bone-Fang Shrine 12/10, Rusted Moon Shrine 0/10] | Iron [Iron Hyena Den 11/10, Bone-Fang Shrine 11/10, Rusted Moon Shrine 10/10]
Final resources: Red 2/0 | Iron 0/0
Final Presence: Seat 1 4/5 | Seat 2 4/5

Turn count: 9
Phase count: 1

First Shrine damage: 3 (Seat 1/Red: 4, Seat 2/Iron: 3)
First Shrine broken: 5 (Seat 1/Red: 8, Seat 2/Iron: 5)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 0, Iron 0
First Ancestor awakened: 
First L2: 
First L3: 

Red L2 entries: 0 (hard-cast 0, evolved 0)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 0 (hard-cast 0, evolved 0)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 0, Iron 0
Legal L2 evolve actions: Red 0, Iron 0
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 0, Iron 0
Turns with legal L2 evolution: Red 0, Iron 0
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 0, Iron 0
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
Fade cards Forgotten: Red 3, Iron 3
Wounded events: Red 0, Iron 0
Wounded reduced damage: Red 0, Iron 0
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 0, Iron 0
Blocks chosen: Red 0, Iron 0
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 0, pack 7 | Seat 2 standard 0, pack 2
Pack diagnostics: Seat 1 ready-at-combat 7, generated 7, available 7, skipped 0, turns-with-bonus 4, max-attacks 17, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 2, generated 2, available 2, skipped 0, turns-with-bonus 1, max-attacks 10, prevented-by-limit 0
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
