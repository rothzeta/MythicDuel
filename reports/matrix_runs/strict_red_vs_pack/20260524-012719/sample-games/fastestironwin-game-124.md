# Test Game #124

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports\matrix_runs\strict_red_vs_pack --bot-red red --bot-iron iron --deck-red red-hunter-evolution --deck-iron iron-hyena-pack-pressure --rules strict-alternation

Seat 1:
- red-hunter-evolution [Red] (RedBaobabBot)
Seat 2:
- iron-hyena-pack-pressure [Iron] (IronHyenaBot)

Rules variant:
- Draw model: retain up to 1, discard rest, draw to 5
- Phase model: reverse every 4 player-turns
- Combat model: 2 standard Assault slots, plus Pack expansion up to 5 total attacks, separate resolution
- Battlefield capacity: 5 Presence per seat
- Prepared model: max 1 active tactic per player
- Special mechanics: Fade, Forgotten, Wounded, Pierce, Disperse, Possession, Evolution, Recall, Unique, Pack

Seed: 124
Winner: iron-hyena-pack-pressure
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Baobab Guardian, Esprit du Léopard, Ritual of Red Moon, River Hunter, Spear of First Dawn
- Starting hands — Iron: Black-Tooth Smith, Blood-Scent Hyena, Bone-Cracker Cub, Iron Hyena Raider, Pack Harrier
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Baobab Guardian, Esprit du Léopard, Ritual of Red Moon, River Hunter, Spear of First Dawn]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- pass

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: River Hunter
- discarded cards: Baobab Guardian, Ritual of Red Moon, Spear of First Dawn, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: 

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith, Blood-Scent Hyena, Bone-Cracker Cub, Iron Hyena Raider, Pack Harrier]

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
- discarded cards: Blood-Scent Hyena, Iron Hyena Raider, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [River Hunter]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played River Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Young Hunter, Pale River Spirit, Young Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: River Hunter

## Turn 4 — Iron

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
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Bone-Cracker Cub survives, Hunter’s Root-Stone at 8/10

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Black-Tooth Smith, Black-Tooth Smith, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 0
Key events: Main 1: played Bone-Cracker Cub | Main 1: played River Hunter | Shrine Hunter’s Root-Stone takes 2. | Main 1: played Blood-Scent Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: attached Spear of First Dawn to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Blood-Scent Hyena deals 2 to River Hunter. | River Hunter deals 4 to Blood-Scent Hyena.
- Result: River Hunter left battle, Blood-Scent Hyena removed

Main 2:
- Main 2: resolved Offering of Milk and Ash (restored 2 to Hunter’s Root-Stone)
- Main 2: awakened First Hunter

End:
- retained card: Pale River Spirit
- discarded cards: Leopard Hunter, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: 

## Turn 6 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: evolved Bone-Cracker Cub into Iron Hyena Champion (dealt 2 to Hunter’s Root-Stone)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bite the Roots
- discarded cards: Iron Hyena Raider, Pack Harrier, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Champion

## Turn 7 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Offering of Milk and Ash]

Main 1:
- Main 1: resolved Ritual of Red Moon (dealt 2 to Iron Hyena Champion)
- Main 1: played Pale River Spirit

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Hunter’s Call, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
- board at end: Pale River Spirit

## Turn 8 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: Iron Hyena Champion [Wounded]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 6 to 4.
- Damage: Shrine Hunter’s Root-Stone takes 4.
- Result: Iron Hyena Champion survives, Hunter’s Root-Stone at 1/10

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Bone Spear
- discarded cards: Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: Iron Hyena Champion
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Hyena Token, Iron Hyena Champion

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/0
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 2 | Iron 2
Key events: Main 1: played Pale River Spirit | Shrine Hunter’s Root-Stone takes 4. | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone) | Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine) | Main 2: played Bone-Cracker Cub | Main 2: awakened Ancestor of the First Pack
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Pale River Spirit
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 9/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: Pale River Spirit
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to Pale River Spirit. | Pale River Spirit deals 2 to Bone-Cracker Cub.
- Result: Pale River Spirit left battle, Bone-Cracker Cub removed

Main 2:
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Offering of Milk and Ash, Baobab Guardian, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Hyena Token, Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: attached Bone Spear to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Ancestor of the First Pack deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 4 to Iron Hyena Champion. | Iron Hyena Champion deals 7 to Leopard Hunter. | Shrine Moonlit Roots takes 1.
- Result: Iron Hyena Champion left battle, Leopard Hunter removed, Moonlit Roots at 8/10

Attack 2:
- Attacker: Hyena Token
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 2.
- Result: Hyena Token survives, Moonlit Roots at 6/10

Main 2:
- Main 2: played Pack Harrier
- Main 2: played Blood-Scent Hyena

End:
- retained card: Hyena Pack Call
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Hyena Token, Hyena Token, Pack Harrier

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 3

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 4/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Young Hunter

Combat:
- no attacks

Main 2:
- Main 2: prepared Hunter’s Call
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Deep River Spirit
- discarded cards: Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 2/10
- board at end: River Hunter, Young Hunter

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Hyena Token, Hyena Token, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Hyena Token into Iron Hyena Champion (dealt 2 to Moonlit Roots)
- Main 1: attached Bone Spear to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 2.
- Result: Pack Harrier survives, Moonlit Roots at 4/10

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 4.
- Result: Blood-Scent Hyena survives, Moonlit Roots at 0/10

Main 2:
- pass

End:
- retained card: Pack Harrier
- discarded cards: Hyena Pack Call, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena [Relic:Bone Spear], Bone Spear, Hyena Token, Iron Hyena Champion, Pack Harrier

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 2/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 2/1 | Iron 2/2
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Ancestor of the First Pack
Forgotten cards: Red 2 | Iron 3
Key events: Main 2: prepared Hunter’s Call | Main 2: awakened Grandmother Beneath the Roots | Shrine Moonlit Roots takes 2. | Shrine Moonlit Roots takes 4. | Main 1: evolved Hyena Token into Iron Hyena Champion (dealt 2 to Moonlit Roots) | Main 1: attached Bone Spear to Blood-Scent Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: River Hunter, Young Hunter
Prepared Tactic: Hunter’s Call
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Esprit du Léopard to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to River Hunter. | River Hunter deals 5 to Iron Hyena Champion.
- Result: River Hunter left battle, Iron Hyena Champion removed

Attack 2:
- Attacker: Young Hunter
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Blood-Scent Hyena deals 3 to Young Hunter. | Young Hunter deals 2 to Blood-Scent Hyena.
- Result: Young Hunter left battle, Blood-Scent Hyena removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Ritual of Red Moon
- discarded cards: Deep River Spirit, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 10/10
- board at end: River Hunter

## Turn 14 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 2

Hand before draw: [Pack Harrier]

Board before ready:
Beings/Spirits: Hyena Token, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Shrine of the Red Baobab)
- Main 1: attached Fang Relic to Hyena Token

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 2.
- Result: Pack Harrier survives, Shrine of the Red Baobab at 3/10

Attack 2:
- Attacker: Hyena Token
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 3.
- Result: Hyena Token survives, Shrine of the Red Baobab at 0/10

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Pack Harrier, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 3 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Hyena Token [Relic:Fang Relic], Pack Harrier

## End-of-game summary

Winner: iron-hyena-pack-pressure
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Shrine of the Red Baobab 11/10, Hunter’s Root-Stone 10/10, Moonlit Roots 10/10] | Iron [Iron Hyena Den 0/10, Bone-Fang Shrine 0/10, Rusted Moon Shrine 0/10]
Final resources: Red 3/1 | Iron 3/3
Final Presence: Seat 1 1/5 | Seat 2 2/5

Turn count: 14
Phase count: 1

First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: )
First Shrine broken: 9 (Seat 1/Red: 9, Seat 2/Iron: )
Wins in odd phase: 1
Winner was first player in final phase: 0
Shrine damage dealt during double-turn: Red 0, Iron 0
First Ancestor awakened: 5
First L2: 6
First L3: 

Red L2 entries: 1 (hard-cast 1, evolved 0)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 2 (hard-cast 0, evolved 2)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 0, Iron 4
Legal L2 evolve actions: Red 0, Iron 4
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 0, Iron 4
Turns with legal L2 evolution: Red 0, Iron 4
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 0, Iron 4
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 0, Iron 1

Legal awaken actions generated: Red 10, Iron 5
Awaken actions chosen: Red 4, Iron 3
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.firsthunter, Iron iron.ancestor.firstpack
Ancestor switches: Red 2, Iron 0
Turns with awakened ancestor: Red 4, Iron 3
Memory spent on ancestors: Red 6, Iron 2
Ancestor realized value: First Hunter +0 damage, Grandmother healed 1, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 1, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 3, Iron 4
Wounded events: Red 0, Iron 1
Wounded reduced damage: Red 0, Iron 1
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 1, Iron 0
Blocks chosen: Red 1, Iron 0
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 4, pack 0 | Seat 2 standard 2, pack 6
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 14, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 8, generated 8, available 8, skipped 2, turns-with-bonus 6, max-attacks 22, prevented-by-limit 0
Deck reshuffles: Red 1, Iron 0

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
