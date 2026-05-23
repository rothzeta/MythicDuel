# Test Game #176

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 100 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red red --bot-iron iron --deck-red red --deck-iron iron

Seat 1:
- red [Red] (RedBaobabBot)
Seat 2:
- iron [Iron] (IronHyenaBot)

Rules variant:
- Draw model: retain up to 1, discard rest, draw to 5
- Phase model: reverse every 4 player-turns
- Combat model: 2 standard Assault slots, plus Pack expansion up to 5 total attacks, separate resolution
- Battlefield capacity: 5 Presence per seat
- Prepared model: max 1 active tactic per player
- Special mechanics: Fade, Forgotten, Wounded, Pierce, Disperse, Possession, Evolution, Recall, Unique, Pack

Seed: 176
Winner: red
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Baobab Guardian, Baobab Guardian, Esprit du Léopard, Kuma Who Wounded the Sun, River Hunter
- Starting hands — Iron: Black-Tooth Smith, Bone Spear, Hyena Pack Call, Iron Guard, Iron Hyena Raider
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the Iron Hyena, Tooth-Mother of the Dry Earth, Smith of Black Teeth

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Baobab Guardian, Baobab Guardian, Esprit du Léopard, Kuma Who Wounded the Sun, River Hunter]

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
- discarded cards: Baobab Guardian, Baobab Guardian, Kuma Who Wounded the Sun, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: 

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith, Bone Spear, Hyena Pack Call, Iron Guard, Iron Hyena Raider]

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
- retained card: Iron Hyena Raider
- discarded cards: Hyena Pack Call, Black-Tooth Smith, Bone Spear, Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

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
- retained card: Spear of First Dawn
- discarded cards: Hunter’s Call, Hunter’s Call, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: River Hunter

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Raider]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: False Opening, Hyena Pack Call, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 0
Key events: Main 1: played River Hunter | Main 1: played Iron Hyena Raider
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 4.
- Result: Iron Hyena Raider survives, Hunter’s Root-Stone at 3/10

Main 2:
- pass

End:
- retained card: Bite the Roots
- discarded cards: Bone-Cracker Cub, False Opening, Rust Hyena Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played River Hunter
- Main 1: played Young Hunter

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
- retained card: Leopard Hunter
- discarded cards: Spear of First Dawn, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
- board at end: River Hunter, Young Hunter

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: prepared Iron Snare

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Rust Hyena Spirit
- discarded cards: Iron Hyena Underworld, Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 9/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Young Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 5.
- Result: River Hunter survives, Bone-Fang Shrine at 5/10

Attack 2:
- Attacker: Young Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 4.
- Result: Young Hunter survives, Bone-Fang Shrine at 1/10

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Pale River Spirit, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 9/10, Moonlit Roots: 0/10
- board at end: River Hunter, Young Hunter, Young Hunter, Young Hunter

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 9/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 2/0 | Iron 1/1
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 0 | Iron 2
Key events: Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone) | Main 1: prepared Iron Snare | Shrine Bone-Fang Shrine takes 5. | Shrine Bone-Fang Shrine takes 4. | Main 1: played Young Hunter | Main 1: played Young Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter, Young Hunter, Young Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 9/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 5.
- Result: River Hunter survives, Bone-Fang Shrine at 0/10

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Offering of Milk and Ash, Root-Woven Guard, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 9/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, River Hunter, Young Hunter, Young Hunter, Young Hunter

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Rust Hyena Spirit]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone, broke it, gained 1 Memory)
- Main 1: prepared Iron Snare

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Raider
- discarded cards: Rust Hyena Spirit, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Leopard Hunter, River Hunter, Young Hunter, Young Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Ritual of Red Moon (had no legal target)

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 5.
- Result: Leopard Hunter survives, Iron Hyena Den at 5/10

Attack 2:
- Attacker: River Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 4.
- Result: River Hunter survives, Iron Hyena Den at 1/10

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Root-Woven Guard, Pale River Spirit, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, River Hunter, Young Hunter, Young Hunter, Young Hunter

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 2

Hand before draw: [Iron Hyena Raider]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Black-Tooth Smith
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone-Cracker Cub, Iron Hyena Raider

# End of Phase 3 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 9/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10]
Resources: Red 4/0 | Iron 0/2
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 1 | Iron 5
Key events: Shrine Iron Hyena Den takes 5. | Shrine Iron Hyena Den takes 4. | Main 1: resolved Ritual of Red Moon (had no legal target) | Main 1: played Iron Hyena Raider | Main 1: played Bone-Cracker Cub | Main 2: played Black-Tooth Smith
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 2

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone-Cracker Cub, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Moonlit Roots
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Black-Tooth Smith becomes Wounded.
- Damage: Young Hunter deals 2 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Young Hunter.
- Result: Black-Tooth Smith survives, Young Hunter removed, Moonlit Roots at 10/10

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Moonlit Roots
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Young Hunter deals 2 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Young Hunter.
- Result: Iron Hyena Raider left battle, Young Hunter removed, Moonlit Roots at 10/10

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Young Hunter deals 2 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Young Hunter.
- Result: Bone-Cracker Cub left battle, Young Hunter removed, Moonlit Roots at 10/10

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: awakened Tooth-Mother of the Dry Earth

End:
- retained card: Iron Hyena Champion
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Relic:Bone Spear], Black-Tooth Smith [Wounded], Bone Spear

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Leopard Hunter, River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 5.
- Result: Leopard Hunter survives, Iron Hyena Den at 0/10

Attack 2:
- Attacker: River Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 3 to 2.
- Damage: Black-Tooth Smith deals 2 to River Hunter. | River Hunter deals 3 to Black-Tooth Smith.
- Result: River Hunter left battle, Black-Tooth Smith removed

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Spear of First Dawn, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, Leopard Hunter, River Hunter

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Relic:Bone Spear], Bone Spear
Prepared Tactic: None
Awakened Ancestor: Tooth-Mother of the Dry Earth
Shrine state: Iron Hyena Den: 14/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Black-Tooth Smith
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 3 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives, Moonlit Roots at 10/10

Main 2:
- Main 2: played Iron Hyena Champion

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 14/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Iron Hyena Champion

## Turn 16 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 3

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Leopard Hunter, Leopard Hunter [Wounded], River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Esprit du Léopard to Leopard Hunter

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
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 5 to 3.
- Damage: Shrine Rusted Moon Shrine takes 3.
- Result: Leopard Hunter survives, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Ritual of Red Moon
- discarded cards: Hunter’s Call, Deep River Spirit
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 5 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Esprit du Léopard, Leopard Hunter, Leopard Hunter [Possession:Esprit du Léopard], River Hunter, Young Hunter

# End of Phase 4 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 14/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/2 | Iron 0/0
Awakened Ancestors: Red First Hunter | Iron Tooth-Mother of the Dry Earth
Forgotten cards: Red 1 | Iron 5
Key events: Main 1: played Bone-Cracker Cub | Main 2: played Iron Hyena Champion | Shrine Rusted Moon Shrine takes 7. | Shrine Rusted Moon Shrine takes 3. | Main 1: played Young Hunter | Main 1: attached Esprit du Léopard to Leopard Hunter
Tempo note: initiative reverses after every four player-turns.

## End-of-game summary

Winner: red
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Shrine of the Red Baobab 0/10, Hunter’s Root-Stone 12/10, Moonlit Roots 0/10] | Iron [Iron Hyena Den 14/10, Bone-Fang Shrine 14/10, Rusted Moon Shrine 10/10]
Final resources: Red 5/2 | Iron 0/0
Final Presence: Seat 1 4/5 | Seat 2 2/5

Turn count: 16
Phase count: 4

First Shrine damage: 5
First Shrine broken: 9
First Ancestor awakened: 6
First L2: 9
First L3: 

Red L2 entries: 2 (hard-cast 2, evolved 0)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 1 (hard-cast 1, evolved 0)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 0, Iron 0
Legal L2 evolve actions: Red 0, Iron 0
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 0, Iron 0
Turns with legal L2 evolution: Red 0, Iron 0
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 0, Iron 0
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 6, Iron 1

Legal awaken actions generated: Red 3, Iron 2
Awaken actions chosen: Red 2, Iron 1
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.firsthunter, Iron iron.ancestor.toothmother
Ancestor switches: Red 0, Iron 0
Turns with awakened ancestor: Red 5, Iron 1
Memory spent on ancestors: Red 2, Iron 2
Ancestor realized value: First Hunter +10 damage, Grandmother healed 0, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +1 damage

Prepared Tactics triggered: Red 0, Iron 2
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 1, Iron 5
Wounded events: Red 1, Iron 1
Wounded reduced damage: Red 1, Iron 1
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 7, Iron 0
Blocks chosen: Red 4, Iron 0
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 10, pack 0 | Seat 2 standard 2, pack 3
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 16, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 3, generated 3, available 3, skipped 0, turns-with-bonus 2, max-attacks 19, prevented-by-limit 0
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
