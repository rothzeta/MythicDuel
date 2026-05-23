# Test Game #126

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 100 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red passive --bot-iron iron --deck-red passive --deck-iron iron-hyena-pack-pressure

Seat 1:
- passive [Red] (PassiveBot)
Seat 2:
- iron-hyena-pack-pressure [Iron] (IronHyenaBot)

Rules variant:
- Draw model: retain up to 1, discard rest, draw to 5
- Phase model: reverse every 4 player-turns
- Combat model: 2 standard Assault slots, plus Pack expansion up to 5 total attacks, separate resolution
- Battlefield capacity: 5 Presence per seat
- Prepared model: max 1 active tactic per player
- Special mechanics: Fade, Forgotten, Wounded, Pierce, Disperse, Possession, Evolution, Recall, Unique, Pack

Seed: 126
Winner: iron-hyena-pack-pressure
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Baobab Guardian, Leopard Hunter, Offering of Milk and Ash, Pale River Spirit, River Hunter
- Starting hands — Iron: Bone-Cracker Cub, Iron Hyena Champion, Iron Hyena Raider, Pack Ambush, Pack Harrier
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Baobab Guardian, Leopard Hunter, Offering of Milk and Ash, Pale River Spirit, River Hunter]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Offering of Milk and Ash (had no damaged shrine to restore)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: River Hunter
- discarded cards: Baobab Guardian, Leopard Hunter, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: 

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub, Iron Hyena Champion, Iron Hyena Raider, Pack Ambush, Pack Harrier]

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
- retained card: Pack Harrier
- discarded cards: Bone-Cracker Cub, Iron Hyena Champion, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [River Hunter]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Offering of Milk and Ash]

Main 1:
- Main 1: played River Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Spear of First Dawn
- discarded cards: Deep River Spirit, River Hunter, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: River Hunter

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Hyena Token survives, Hunter’s Root-Stone at 7/10

Main 2:
- Main 2: played Pack Harrier

End:
- retained card: Fang Relic
- discarded cards: Bone-Cracker Cub, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token, Hyena Token, Pack Harrier

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 2
Key events: Main 1: resolved Offering of Milk and Ash (had no damaged shrine to restore) | Main 1: resolved Pack Ambush (summoned Hyena Token) | Main 1: played River Hunter | Shrine Hunter’s Root-Stone takes 2. | Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine) | Main 2: played Pack Harrier
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Hyena Token, Hyena Token, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Hyena Token

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Pack Harrier survives, Hunter’s Root-Stone at 5/10

Attack 2:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 3.
- Result: Hyena Token survives, Hunter’s Root-Stone at 2/10

Attack 3:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Hyena Token survives, Hunter’s Root-Stone at 0/10

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Fang Relic
- discarded cards: Iron Hyena Raider, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Fang Relic, Hyena Token, Hyena Token [Relic:Fang Relic], Pack Harrier

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Offering of Milk and Ash]

Main 1:
- Main 1: played Young Hunter

Combat:
- no attacks

Main 2:
- Main 2: attached Spear of First Dawn to River Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Ritual of Red Moon, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
- board at end: River Hunter [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Fang Relic, Hyena Token, Hyena Token [Relic:Fang Relic], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Pack Ambush, Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Moonlit Roots)
- Main 1: attached Fang Relic to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 3.
- Result: Hyena Token survives, Moonlit Roots at 4/10

Attack 2:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 2.
- Result: Pack Harrier survives, Moonlit Roots at 2/10

Attack 3:
- Attacker: Hyena Token
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 2.
- Result: Hyena Token survives, Moonlit Roots at 0/10

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Pack Harrier, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Fang Relic, Hyena Token, Hyena Token [Relic:Fang Relic], Pack Harrier

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: River Hunter [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 1 [Offering of Milk and Ash]

Main 1:
- Main 1: played Young Hunter

Combat:
- no attacks

Main 2:
- Main 2: resolved Offering of Milk and Ash (restored 1 to Shrine of the Red Baobab)

End:
- retained card: Esprit du Léopard
- discarded cards: River Hunter, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: River Hunter [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter, Young Hunter

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 2/0 | Iron 0/1
Awakened Ancestors: Red None | Iron Ancestor of the First Pack
Forgotten cards: Red 2 | Iron 3
Key events: Shrine Moonlit Roots takes 2. | Shrine Moonlit Roots takes 2. | Main 1: resolved Bite the Roots (dealt 3 to Moonlit Roots) | Main 1: attached Fang Relic to Bone-Cracker Cub | Main 1: played Young Hunter | Main 2: resolved Offering of Milk and Ash (restored 1 to Shrine of the Red Baobab)
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: River Hunter [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Offering of Milk and Ash]

Main 1:
- Main 1: attached Spear of First Dawn to River Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Root-Woven Guard, Root-Woven Guard, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: River Hunter [Relic:Spear of First Dawn], Spear of First Dawn, Spear of First Dawn, Young Hunter, Young Hunter

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Fang Relic, Hyena Token, Hyena Token [Relic:Fang Relic], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Hyena Token into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab)

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 2.
- Result: Pack Harrier survives, Shrine of the Red Baobab at 6/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 5.
- Result: Bone-Cracker Cub survives, Shrine of the Red Baobab at 0/10

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Blood-Scent Hyena, Hyena Pack Call, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Fang Relic, Hyena Token, Iron Hyena Champion [Relic:Fang Relic], Pack Harrier

## End-of-game summary

Winner: iron-hyena-pack-pressure
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Shrine of the Red Baobab 10/10, Hunter’s Root-Stone 10/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 0/10, Bone-Fang Shrine 0/10, Rusted Moon Shrine 0/10]
Final resources: Red 3/0 | Iron 2/2
Final Presence: Seat 1 3/5 | Seat 2 4/5

Turn count: 10
Phase count: 3

First Shrine damage: 4
First Shrine broken: 5
First Ancestor awakened: 5
First L2: 10
First L3: 

Red L2 entries: 0 (hard-cast 0, evolved 0)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 1 (hard-cast 0, evolved 1)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 0, Iron 6
Legal L2 evolve actions: Red 0, Iron 6
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 0, Iron 2
Turns with legal L2 evolution: Red 0, Iron 2
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 0, Iron 2
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 0, Iron 0

Legal awaken actions generated: Red 0, Iron 3
Awaken actions chosen: Red 0, Iron 2
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red None, Iron iron.ancestor.firstpack
Ancestor switches: Red 0, Iron 0
Turns with awakened ancestor: Red 0, Iron 2
Memory spent on ancestors: Red 0, Iron 2
Ancestor realized value: First Hunter +0 damage, Grandmother healed 0, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 2, Iron 3
Wounded events: Red 0, Iron 0
Wounded reduced damage: Red 0, Iron 0
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 9, Iron 0
Blocks chosen: Red 0, Iron 0
Blocks declined: Red 5, Iron 0
Assault slots spent: Seat 1 standard 0, pack 0 | Seat 2 standard 4, pack 5
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 10, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 6, generated 6, available 6, skipped 1, turns-with-bonus 3, max-attacks 16, prevented-by-limit 0
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
