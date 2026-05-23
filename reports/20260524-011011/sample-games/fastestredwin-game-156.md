# Test Game #156

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red iron --bot-iron red --deck-red iron-hyena-pack-pressure --deck-iron red-hunter-evolution

Seat 1:
- iron-hyena-pack-pressure [Iron] (IronHyenaBot)
Seat 2:
- red-hunter-evolution [Red] (RedBaobabBot)

Rules variant:
- Draw model: retain up to 1, discard rest, draw to 5
- Phase model: reverse every 4 player-turns
- Combat model: 2 standard Assault slots, plus Pack expansion up to 5 total attacks, separate resolution
- Battlefield capacity: 5 Presence per seat
- Prepared model: max 1 active tactic per player
- Special mechanics: Fade, Forgotten, Wounded, Pierce, Disperse, Possession, Evolution, Recall, Unique, Pack

Seed: 156
Winner: iron-hyena-pack-pressure
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting Shrines — Iron: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting hands — Red: Black-Tooth Smith, Blood-Scent Hyena, Blood-Scent Hyena, Bone-Cracker Cub, Iron Hyena Raider
- Starting hands — Iron: Baobab Guardian, Deep River Spirit, Leopard Hunter, Offering of Milk and Ash, Root-Woven Guard
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang
- Starting Lineage — Iron: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith, Blood-Scent Hyena, Blood-Scent Hyena, Bone-Cracker Cub, Iron Hyena Raider]

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
- discarded cards: Iron Hyena Raider, Blood-Scent Hyena, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Baobab Guardian, Deep River Spirit, Leopard Hunter, Offering of Milk and Ash, Root-Woven Guard]

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
- retained card: Deep River Spirit
- discarded cards: Root-Woven Guard, Leopard Hunter, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: 

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
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 4.
- Result: Bone-Cracker Cub survives, Hunter’s Root-Stone at 5/10

Main 2:
- Main 2: played Bone-Cracker Cub

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Raider, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Bone-Cracker Cub, Hyena Token

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Offering of Milk and Ash]

Main 1:
- Main 1: played River Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Ritual of Red Moon
- discarded cards: Deep River Spirit, Pale River Spirit, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
- board at end: River Hunter

# End of Phase 1 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10]
Resources: Red 0/0 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 1
Key events: Main 1: played Bone-Cracker Cub | Main 1: resolved Offering of Milk and Ash (had no damaged shrine to restore) | Shrine Hunter’s Root-Stone takes 4. | Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine) | Main 2: played Bone-Cracker Cub | Main 1: played River Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 5/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Offering of Milk and Ash]

Main 1:
- Main 1: attached Spear of First Dawn to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to River Hunter. | River Hunter deals 4 to Bone-Cracker Cub.
- Result: River Hunter left battle, Bone-Cracker Cub removed

Main 2:
- Main 2: resolved Offering of Milk and Ash (restored 3 to Hunter’s Root-Stone)
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Ritual of Red Moon
- discarded cards: Ritual of Red Moon, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
- board at end: 

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Hyena Token survives, Hunter’s Root-Stone at 7/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 4.
- Result: Bone-Cracker Cub survives, Hunter’s Root-Stone at 3/10

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Black-Tooth Smith, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Hyena Token, Pack Harrier, Pack Harrier

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Offering of Milk and Ash]

Main 1:
- Main 1: played River Hunter
- Main 1: resolved Ritual of Red Moon (dealt 2 to Bone-Cracker Cub, destroyed it, gained 1 Memory)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Kuma Who Wounded the Sun, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
- board at end: River Hunter

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Hyena Token, Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: evolved Hyena Token into Iron Hyena Champion (dealt 2 to Hunter’s Root-Stone)

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Pack Harrier survives, Hunter’s Root-Stone at 0/10

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Iron Hyena Raider, Bone-Cracker Cub, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Champion, Pack Harrier, Pack Harrier

# End of Phase 2 Summary

Shrine state: Red [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10] | Iron [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10]
Resources: Red 1/0 | Iron 0/1
Awakened Ancestors: Red None | Iron Grandmother Beneath the Roots
Forgotten cards: Red 1 | Iron 3
Key events: Main 1: played Pack Harrier | Main 1: played Pack Harrier | Main 1: played River Hunter | Main 1: resolved Ritual of Red Moon (dealt 2 to Bone-Cracker Cub, destroyed it, gained 1 Memory) | Shrine Hunter’s Root-Stone takes 2. | Main 1: evolved Hyena Token into Iron Hyena Champion (dealt 2 to Hunter’s Root-Stone)
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Iron Hyena Champion, Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: evolved Pack Harrier into Iron Hyena Champion (dealt 2 to Moonlit Roots)
- Main 1: attached Fang Relic to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 2.
- Result: Pack Harrier survives, Moonlit Roots at 6/10

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 7.
- Result: Iron Hyena Champion survives, Moonlit Roots at 0/10

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Hyena Pack Call, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Iron Hyena Champion, Iron Hyena Champion [Relic:Fang Relic], Pack Harrier

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 3 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 6 to River Hunter. | River Hunter deals 3 to Iron Hyena Champion.
- Result: River Hunter left battle, Iron Hyena Champion removed

Main 2:
- Main 2: played Pale River Spirit
- Main 2: awakened First Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Pale River Spirit, River Hunter, Young Hunter

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Iron Hyena Champion, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Pack Ambush]

Main 1:
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)
- Main 1: attached Bone Spear to Iron Hyena Champion

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
- Attacker: Iron Hyena Champion
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 7.
- Result: Iron Hyena Champion survives, Shrine of the Red Baobab at 0/10

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Black-Tooth Smith, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Hyena Token, Iron Hyena Champion [Relic:Bone Spear], Pack Harrier

## End-of-game summary

Winner: iron-hyena-pack-pressure
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Iron Hyena Den 0/10, Bone-Fang Shrine 0/10, Rusted Moon Shrine 0/10] | Iron [Shrine of the Red Baobab 11/10, Hunter’s Root-Stone 10/10, Moonlit Roots 11/10]
Final resources: Red 4/0 | Iron 0/1
Final Presence: Seat 1 3/5 | Seat 2 3/5

Turn count: 11
Phase count: 3

First Shrine damage: 3 (Seat 1/Red: , Seat 2/Iron: 3)
First Shrine broken: 8 (Seat 1/Red: , Seat 2/Iron: 8)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 16, Iron 0
First Ancestor awakened: 5
First L2: 8
First L3: 

Red L2 entries: 2 (hard-cast 0, evolved 2)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 0 (hard-cast 0, evolved 0)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 6, Iron 0
Legal L2 evolve actions: Red 6, Iron 0
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 4, Iron 0
Turns with legal L2 evolution: Red 4, Iron 0
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 6, Iron 0
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 1, Iron 0

Legal awaken actions generated: Red 0, Iron 4
Awaken actions chosen: Red 0, Iron 2
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red None, Iron red.ancestor.grandmother
Ancestor switches: Red 0, Iron 1
Turns with awakened ancestor: Red 0, Iron 2
Memory spent on ancestors: Red 0, Iron 4
Ancestor realized value: First Hunter +0 damage, Grandmother healed 2, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 2, Iron 3
Wounded events: Red 0, Iron 0
Wounded reduced damage: Red 0, Iron 0
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 0, Iron 0
Blocks chosen: Red 0, Iron 0
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 1, pack 7 | Seat 2 standard 2, pack 0
Pack diagnostics: Seat 1 ready-at-combat 10, generated 10, available 10, skipped 3, turns-with-bonus 5, max-attacks 22, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 10, prevented-by-limit 0
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
