# Test Game #215

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 100 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red red --bot-iron iron --deck-red red-hunter-evolution --deck-iron iron-hyena-aggro

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

Seed: 215
Winner: red-hunter-evolution
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Baobab Guardian, Esprit du Léopard, Pale River Spirit, Spear of First Dawn, Young Hunter
- Starting hands — Iron: Fang Relic, Hyena Pack Call, Iron Hyena Champion, Iron Hyena Raider, Iron Snare
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the Iron Hyena, Tooth-Mother of the Dry Earth, Smith of Black Teeth

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Baobab Guardian, Esprit du Léopard, Pale River Spirit, Spear of First Dawn, Young Hunter]

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
- retained card: Esprit du Léopard
- discarded cards: Pale River Spirit, Spear of First Dawn, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Fang Relic, Hyena Pack Call, Iron Hyena Champion, Iron Hyena Raider, Iron Snare]

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
- retained card: Iron Hyena Raider
- discarded cards: Hyena Pack Call, Iron Hyena Champion, Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Ritual of Red Moon (had no legal target)

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
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Esprit du Léopard, Pale River Spirit, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Iron Hyena Raider]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Rust Hyena Spirit
- discarded cards: False Opening, Iron Guard, Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 1
Key events: Main 1: played Young Hunter | Main 1: prepared Iron Snare | Shrine Bone-Fang Shrine takes 3. | Main 1: resolved Ritual of Red Moon (had no legal target) | Main 1: played Iron Hyena Raider
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Rust Hyena Spirit]

Board before ready:
Beings/Spirits: Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Iron Snare]

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
- retained card: Rust Hyena Spirit
- discarded cards: Rust Hyena Spirit, Iron Hyena Raider, False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Ritual of Red Moon, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
- board at end: River Hunter, Young Hunter

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Rust Hyena Spirit]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Iron Snare]

Main 1:
- Main 1: played Rust Hyena Spirit

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Black-Tooth Smith, Fang Relic, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10
- board at end: Rust Hyena Spirit

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Spear of First Dawn to Young Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Rust Hyena Spirit
- Defender/blocker: Rust Hyena Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Rust Hyena Spirit deals 2 to Young Hunter. | Young Hunter deals 3 to Rust Hyena Spirit.
- Result: Young Hunter left battle, Rust Hyena Spirit removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Leopard Hunter
- discarded cards: Ritual of Red Moon, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
- board at end: River Hunter, River Hunter

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 3/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 2/1
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 1 | Iron 2
Key events: Main 1: played Rust Hyena Spirit | Rust Hyena Spirit deals 2 to Young Hunter. | Young Hunter deals 3 to Rust Hyena Spirit. | Main 1: played River Hunter | Main 1: attached Spear of First Dawn to Young Hunter | Main 2: awakened First Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter, River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

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
- Result: River Hunter survives, Bone-Fang Shrine at 2/10

Attack 2:
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
- discarded cards: Esprit du Léopard, Hunter’s Call, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, River Hunter, River Hunter

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 2

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Bone Spear, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Bone-Cracker Cub

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Leopard Hunter, River Hunter, River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 6.
- Result: Leopard Hunter survives, Iron Hyena Den at 4/10

Attack 2:
- Attacker: River Hunter
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to River Hunter. | River Hunter deals 3 to Bone-Cracker Cub.
- Result: River Hunter left battle, Bone-Cracker Cub removed

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Deep River Spirit, Baobab Guardian, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, River Hunter, River Hunter

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 2

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: prepared Iron Snare

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: River Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to River Hunter.
- Result: Bone-Cracker Cub left battle, River Hunter removed, Hunter’s Root-Stone at 1/10

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Bone Spear, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
- board at end: 

# End of Phase 3 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 6/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10]
Resources: Red 4/2 | Iron 3/2
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 1 | Iron 3
Key events: River Hunter deals 3 to Bone-Cracker Cub. | Main 1: played River Hunter | River Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to River Hunter. | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone) | Main 1: prepared Iron Snare
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 2

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: 
Prepared Tactic: Iron Snare
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone, broke it, gained 1 Memory)
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Underworld
- discarded cards: Bone-Cracker Cub, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 3 Memory
- shrine state: Iron Hyena Den: 6/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 2

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Leopard Hunter, River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Iron Hyena Den)
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to River Hunter. | River Hunter deals 3 to Bone-Cracker Cub.
- Result: River Hunter left battle, Bone-Cracker Cub removed

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Root-Woven Guard, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Kuma Who Wounded the Sun, Young Hunter

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 3

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: prepared False Opening
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- Main 2: played Iron Hyena Champion

End:
- retained card: Iron Hyena Underworld
- discarded cards: Fang Relic
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 9/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Champion, Iron Hyena Raider

## Turn 16 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 2

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Kuma Who Wounded the Sun, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 7.
- Result: Kuma Who Wounded the Sun survives, Iron Hyena Den at 0/10

Attack 2:
- Attacker: Young Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: played Leopard Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Spear of First Dawn
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Kuma Who Wounded the Sun, Leopard Hunter, River Hunter, Young Hunter

# End of Phase 4 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 9/10, Bone-Fang Shrine: 13/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/3 | Iron 0/2
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 1 | Iron 5
Key events: Shrine Iron Hyena Den takes 7. | Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Raider. | Main 1: played River Hunter | Main 1: played Young Hunter | Main 2: played Leopard Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 3

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Kuma Who Wounded the Sun, Leopard Hunter, River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to Kuma Who Wounded the Sun

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 5.
- Result: Leopard Hunter survives, Rusted Moon Shrine at 5/10

Attack 2:
- Attacker: Kuma Who Wounded the Sun
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 10.
- Result: Kuma Who Wounded the Sun survives, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Baobab Guardian, Esprit du Léopard, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Kuma Who Wounded the Sun [Relic:Spear of First Dawn], Leopard Hunter, River Hunter, Spear of First Dawn, Young Hunter

## End-of-game summary

Winner: red-hunter-evolution
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Shrine of the Red Baobab 0/10, Hunter’s Root-Stone 12/10, Moonlit Roots 0/10] | Iron [Iron Hyena Den 16/10, Bone-Fang Shrine 13/10, Rusted Moon Shrine 15/10]
Final resources: Red 6/3 | Iron 0/2
Final Presence: Seat 1 5/5 | Seat 2 1/5

Turn count: 17
Phase count: 5

First Shrine damage: 3
First Shrine broken: 9
First Ancestor awakened: 8
First L2: 9
First L3: 14

Red L2 entries: 2 (hard-cast 2, evolved 0)
Red L3 entries: 1 (hard-cast 0, evolved 1)
Iron L2 entries: 1 (hard-cast 1, evolved 0)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 2, Iron 0
Legal L2 evolve actions: Red 0, Iron 0
Legal L3 evolve actions: Red 2, Iron 0
Evolve windows: Red 2, Iron 0
Turns with legal L2 evolution: Red 0, Iron 0
Turns with legal L3 evolution: Red 2, Iron 0
Evolve actions chosen: Red 2, Iron 0
Hard-cast chosen while legal evolve action existed: Red 1, Iron 1
Hard-cast chosen while evolution base existed: Red 7, Iron 0

Legal awaken actions generated: Red 7, Iron 0
Awaken actions chosen: Red 4, Iron 0
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.firsthunter, Iron None
Ancestor switches: Red 0, Iron 0
Turns with awakened ancestor: Red 5, Iron 0
Memory spent on ancestors: Red 2, Iron 0
Ancestor realized value: First Hunter +6 damage, Grandmother healed 0, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 2
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 1, Iron 5
Wounded events: Red 0, Iron 0
Wounded reduced damage: Red 0, Iron 0
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 1, Iron 0
Blocks chosen: Red 1, Iron 0
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 12, pack 0 | Seat 2 standard 0, pack 2
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 18, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 2, generated 2, available 2, skipped 0, turns-with-bonus 2, max-attacks 18, prevented-by-limit 0
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
