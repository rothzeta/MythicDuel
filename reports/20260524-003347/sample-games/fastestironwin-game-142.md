# Test Game #142

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 100 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red red --bot-iron iron --deck-red red-hunter-evolution --deck-iron iron-hyena-aggro --rules single-block-per-combat

Seat 1:
- red-hunter-evolution [Red] (RedBaobabBot)
Seat 2:
- iron-hyena-aggro [Iron] (IronHyenaBot)

Rules variant:
- Draw model: retain up to 1, discard rest, draw to 5
- Phase model: reverse every 4 player-turns
- Combat model: 2 standard Assault slots, plus Pack expansion up to 5 total attacks, separate resolution
- Battlefield capacity: 5 Presence per seat
- Prepared model: max 1 active tactic per player
- Special mechanics: Fade, Forgotten, Wounded, Pierce, Disperse, Possession, Evolution, Recall, Unique, Pack

Seed: 142
Winner: iron-hyena-aggro
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Pale River Spirit, River Hunter, Root-Woven Guard, Spear of First Dawn, Young Hunter
- Starting hands — Iron: Bite the Roots, Bone-Cracker Cub, Fang Relic, Iron Snare, Pack Harrier
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the Iron Hyena, Tooth-Mother of the Dry Earth, Smith of Black Teeth

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Pale River Spirit, River Hunter, Root-Woven Guard, Spear of First Dawn, Young Hunter]

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
- discarded cards: Root-Woven Guard, Pale River Spirit, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Bone-Cracker Cub, Fang Relic, Iron Snare, Pack Harrier]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: prepared Iron Snare

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bite the Roots
- discarded cards: Pack Harrier, Fang Relic, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

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
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 3.
- Result: Young Hunter survives, Bone-Fang Shrine at 7/10

Main 2:
- Main 2: prepared Hunter’s Call

End:
- retained card: Spear of First Dawn
- discarded cards: Root-Woven Guard, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter, Young Hunter

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Bone Spear, Iron Hyena Champion, Rust Hyena Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: 

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 2
Key events: Main 1: played Young Hunter | Main 1: prepared Iron Snare | Shrine Bone-Fang Shrine takes 3. | Main 1: played Young Hunter | Main 2: prepared Hunter’s Call | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Black-Tooth Smith, False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Iron Hyena Raider

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Young Hunter, Young Hunter
Prepared Tactic: Hunter’s Call
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: attached Spear of First Dawn to Young Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 3 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Kuma Who Wounded the Sun, Baobab Guardian, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Bone-Cracker Cub
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Young Hunter deals 2 to Bone-Cracker Cub. | Bone-Cracker Cub deals 5 to Young Hunter.
- Result: Bone-Cracker Cub left battle, Young Hunter removed, Hunter’s Root-Stone at 8/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Champion, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Hunter’s Call]

Main 1:
- Main 1: played River Hunter
- Main 1: played River Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Spear of First Dawn, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
- board at end: River Hunter, River Hunter

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/1 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 2
Key events: Young Hunter deals 2 to Bone-Cracker Cub. | Bone-Cracker Cub deals 5 to Young Hunter. | Main 1: attached Fang Relic to Bone-Cracker Cub | Main 1: played Iron Hyena Raider | Main 1: played River Hunter | Main 1: played River Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter, River Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Hunter’s Call]

Main 1:
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to River Hunter. | River Hunter deals 3 to Iron Hyena Raider.
- Result: River Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Ritual of Red Moon, Deep River Spirit, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, River Hunter

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Iron Snare]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Hyena Pack Call
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone-Cracker Cub, Pack Harrier

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Leopard Hunter, River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Hunter’s Call]

Main 1:
- Main 1: attached Esprit du Léopard to River Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 6.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 1/10

Attack 2:
- Attacker: River Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Black-Tooth Smith deals 2 to River Hunter. | River Hunter deals 5 to Black-Tooth Smith.
- Result: River Hunter left battle, Black-Tooth Smith removed

Main 2:
- pass

End:
- retained card: Ritual of Red Moon
- discarded cards: Deep River Spirit, Baobab Guardian, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Pack Harrier survives, Hunter’s Root-Stone at 4/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 4.
- Result: Bone-Cracker Cub survives, Hunter’s Root-Stone at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub, Pack Harrier

# End of Phase 3 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10]
Resources: Red 4/3 | Iron 2/1
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 1 | Iron 3
Key events: River Hunter deals 5 to Black-Tooth Smith. | Main 1: attached Esprit du Léopard to River Hunter | Shrine Hunter’s Root-Stone takes 2. | Shrine Hunter’s Root-Stone takes 4. | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone) | Main 1: played Blood-Scent Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone-Cracker Cub, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Moonlit Roots)
- Main 1: prepared Iron Snare

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 2.
- Result: Pack Harrier survives, Moonlit Roots at 5/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 4.
- Result: Bone-Cracker Cub survives, Moonlit Roots at 1/10

Attack 3:
- Attacker: Blood-Scent Hyena
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 3.
- Result: Blood-Scent Hyena survives, Moonlit Roots at 0/10

Main 2:
- Main 2: awakened Ancestor of the Iron Hyena

End:
- retained card: Black-Tooth Smith
- discarded cards: Blood-Scent Hyena, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 9/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub, Pack Harrier

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 3

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Leopard Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 12/10
Forgotten zone count/list: 1 [Hunter’s Call]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 5.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 0/10

Main 2:
- Main 2: awakened Child Who Remembered the Dead

End:
- retained card: Esprit du Léopard
- discarded cards: Ritual of Red Moon, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 12/10
- board at end: Leopard Hunter, Leopard Hunter, Young Hunter

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone-Cracker Cub, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | Pack Harrier deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 4 to Pack Harrier. | Pack Harrier deals 1 to Leopard Hunter. | Shrine Shrine of the Red Baobab takes 1.
- Result: Pack Harrier left battle, Leopard Hunter survives, Shrine of the Red Baobab at 7/10

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 3.
- Result: Blood-Scent Hyena survives, Shrine of the Red Baobab at 3/10

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 3.
- Result: Bone-Cracker Cub survives, Shrine of the Red Baobab at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Blood-Scent Hyena, Black-Tooth Smith, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 7 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena [Relic:Bone Spear], Bone Spear, Bone-Cracker Cub

## End-of-game summary

Winner: iron-hyena-aggro
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Shrine of the Red Baobab 10/10, Hunter’s Root-Stone 10/10, Moonlit Roots 12/10] | Iron [Iron Hyena Den 0/10, Bone-Fang Shrine 14/10, Rusted Moon Shrine 0/10]
Final resources: Red 1/1 | Iron 7/1
Final Presence: Seat 1 3/5 | Seat 2 2/5

Turn count: 15
Phase count: 4

First Shrine damage: 3
First Shrine broken: 12
First Ancestor awakened: 9
First L2: 9
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
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 4, Iron 0

Legal awaken actions generated: Red 6, Iron 1
Awaken actions chosen: Red 3, Iron 1
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.firsthunter, Iron iron.ancestor.hyena
Ancestor switches: Red 1, Iron 0
Turns with awakened ancestor: Red 2, Iron 1
Memory spent on ancestors: Red 4, Iron 2
Ancestor realized value: First Hunter +3 damage, Grandmother healed 0, Child draw/discard 0, Iron Hyena +1 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 1, Iron 2
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 1, Iron 5
Wounded events: Red 1, Iron 0
Wounded reduced damage: Red 0, Iron 0
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 2, Iron 0
Blocks chosen: Red 2, Iron 0
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 6, pack 0 | Seat 2 standard 0, pack 9
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 14, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 9, generated 9, available 9, skipped 0, turns-with-bonus 4, max-attacks 25, prevented-by-limit 0
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
