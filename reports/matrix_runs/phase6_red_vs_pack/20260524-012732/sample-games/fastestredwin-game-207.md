# Test Game #207

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports\matrix_runs\phase6_red_vs_pack --bot-red red --bot-iron iron --deck-red red-hunter-evolution --deck-iron iron-hyena-pack-pressure --rules phase-length-6

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

Seed: 207
Winner: red-hunter-evolution
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Baobab Guardian, Kuma Who Wounded the Sun, Ritual of Red Moon, Spear of First Dawn, Young Hunter
- Starting hands — Iron: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub, Pack Harrier, Pack Harrier
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Baobab Guardian, Kuma Who Wounded the Sun, Ritual of Red Moon, Spear of First Dawn, Young Hunter]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Young Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Spear of First Dawn
- discarded cards: Baobab Guardian, Kuma Who Wounded the Sun, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub, Pack Harrier, Pack Harrier]

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
- retained card: Bone Spear
- discarded cards: Blood-Scent Hyena, Bone-Cracker Cub, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Pack Harrier

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Pack Harrier
- Defender/blocker: Pack Harrier
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Pack Harrier deals 1 to Young Hunter. | Young Hunter deals 2 to Pack Harrier.
- Result: Young Hunter left battle, Pack Harrier removed

Main 2:
- pass

End:
- retained card: Spear of First Dawn
- discarded cards: Pale River Spirit, Pale River Spirit, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: River Hunter

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Raider
- discarded cards: Bone Spear, Pack Ambush, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/1 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 1
Key events: Main 1: played Young Hunter | Main 1: played Pack Harrier | Pack Harrier deals 1 to Young Hunter. | Young Hunter deals 2 to Pack Harrier. | Main 1: played River Hunter | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 4.
- Result: River Hunter survives, Bone-Fang Shrine at 6/10

Main 2:
- Main 2: prepared Root-Woven Guard

End:
- retained card: Esprit du Léopard
- discarded cards: Spear of First Dawn, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: River Hunter, River Hunter

## Turn 6 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Iron Hyena Raider]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Iron Hyena Raider, Bone-Cracker Cub, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Raider
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: Root-Woven Guard
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 5.
- Result: Iron Hyena Raider survives, Hunter’s Root-Stone at 2/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Fang Relic, Iron Hyena Raider [Relic:Fang Relic]

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: River Hunter, River Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 8/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 4 to River Hunter. | River Hunter deals 3 to Iron Hyena Raider.
- Result: River Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: resolved Offering of Milk and Ash (restored 3 to Hunter’s Root-Stone)
- Main 2: awakened First Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
- board at end: River Hunter, Young Hunter, Young Hunter

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/0 | Iron 1/1
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 2 | Iron 1
Key events: Iron Hyena Raider deals 4 to River Hunter. | River Hunter deals 3 to Iron Hyena Raider. | Main 1: played Young Hunter | Main 1: played Young Hunter | Main 2: resolved Offering of Milk and Ash (restored 3 to Hunter’s Root-Stone) | Main 2: awakened First Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: River Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to River Hunter.
- Result: Bone-Cracker Cub left battle, River Hunter removed, Hunter’s Root-Stone at 6/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Blood-Scent Hyena

## Turn 10 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Young Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Root-Woven Guard]

Main 1:
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Blood-Scent Hyena deals 2 to Young Hunter. | Young Hunter deals 2 to Blood-Scent Hyena.
- Result: Young Hunter left battle, Blood-Scent Hyena removed

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Hunter’s Call, Spear of First Dawn, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, Young Hunter

## Turn 11 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Blood-Scent Hyena
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: attached Fang Relic to Blood-Scent Hyena
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Hunter’s Root-Stone
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Young Hunter deals 2 to Blood-Scent Hyena. | Blood-Scent Hyena deals 4 to Young Hunter.
- Result: Blood-Scent Hyena left battle, Young Hunter removed, Hunter’s Root-Stone at 7/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Iron Hyena Champion
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Pack Harrier

## Turn 12 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Leopard Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Root-Woven Guard]

Main 1:
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 6.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 0/10

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit, Ritual of Red Moon, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, Leopard Hunter

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 4/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/1 | Iron 0/1
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 2 | Iron 1
Key events: Blood-Scent Hyena deals 4 to Young Hunter. | Main 1: attached Fang Relic to Blood-Scent Hyena | Main 1: played Pack Harrier | Main 2: played Black-Tooth Smith | Shrine Bone-Fang Shrine takes 6. | Main 1: played Leopard Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Leopard Hunter, Leopard Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Root-Woven Guard]

Main 1:
- Main 1: attached Esprit du Léopard to Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 8.
- Result: Leopard Hunter survives, Iron Hyena Den at 2/10

Attack 2:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 6.
- Result: Leopard Hunter survives, Iron Hyena Den at 0/10

Main 2:
- pass

End:
- retained card: Ritual of Red Moon
- discarded cards: Deep River Spirit, Root-Woven Guard, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, Leopard Hunter, Leopard Hunter [Possession:Esprit du Léopard]

## Turn 14 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 14/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: attached Bone Spear to Pack Harrier

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Black-Tooth Smith survives, Hunter’s Root-Stone at 2/10

Attack 2:
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
- retained card: Hyena Pack Call
- discarded cards: Iron Hyena Champion, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 14/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Pack Harrier [Relic:Bone Spear]

## Turn 15 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Esprit du Léopard, Leopard Hunter, Leopard Hunter [Possession:Esprit du Léopard]
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Offering of Milk and Ash, Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 7.
- Result: Leopard Hunter survives, Rusted Moon Shrine at 3/10

Attack 2:
- Attacker: Leopard Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 5.
- Result: Leopard Hunter survives, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Ritual of Red Moon
- discarded cards: River Hunter, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, Leopard Hunter, Leopard Hunter [Possession:Esprit du Léopard], Young Hunter, Young Hunter

## End-of-game summary

Winner: red-hunter-evolution
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Shrine of the Red Baobab 3/10, Hunter’s Root-Stone 10/10, Moonlit Roots 0/10] | Iron [Iron Hyena Den 14/10, Bone-Fang Shrine 10/10, Rusted Moon Shrine 12/10]
Final resources: Red 6/0 | Iron 4/1
Final Presence: Seat 1 4/5 | Seat 2 2/5

Turn count: 15
Phase count: 3

First Shrine damage: 4 (Seat 1/Red: 4, Seat 2/Iron: 5)
First Shrine broken: 12 (Seat 1/Red: 14, Seat 2/Iron: 12)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 20, Iron 6
First Ancestor awakened: 8
First L2: 10
First L3: 

Red L2 entries: 2 (hard-cast 2, evolved 0)
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
Hard-cast chosen while legal evolve action existed: Red 0, Iron 1
Hard-cast chosen while evolution base existed: Red 2, Iron 1

Legal awaken actions generated: Red 2, Iron 0
Awaken actions chosen: Red 1, Iron 0
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.firsthunter, Iron None
Ancestor switches: Red 0, Iron 0
Turns with awakened ancestor: Red 4, Iron 0
Memory spent on ancestors: Red 2, Iron 0
Ancestor realized value: First Hunter +5 damage, Grandmother healed 0, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 1, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 2, Iron 2
Wounded events: Red 0, Iron 0
Wounded reduced damage: Red 0, Iron 0
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 3, Iron 0
Blocks chosen: Red 2, Iron 0
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 9, pack 0 | Seat 2 standard 1, pack 4
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 16, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 4, generated 4, available 4, skipped 0, turns-with-bonus 4, max-attacks 18, prevented-by-limit 0
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
