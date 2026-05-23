# Test Game #123

Command: dotnet run --project MythicDuel.Sim -- --mode single --games 1 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red red --bot-iron iron --deck-red red --deck-iron iron

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

Seed: 123
Winner: red
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Baobab Guardian, Deep River Spirit, Esprit du Léopard, Ritual of Red Moon, River Hunter
- Starting hands — Iron: Black-Tooth Smith, Iron Guard, Iron Hyena Raider, Iron Hyena Raider, Iron Hyena Underworld
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the Iron Hyena, Tooth-Mother of the Dry Earth, Smith of Black Teeth

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Baobab Guardian, Deep River Spirit, Esprit du Léopard, Ritual of Red Moon, River Hunter]

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
- discarded cards: Deep River Spirit, Baobab Guardian, Ritual of Red Moon, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: 

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith, Iron Guard, Iron Hyena Raider, Iron Hyena Raider, Iron Hyena Underworld]

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
- discarded cards: Black-Tooth Smith, Iron Hyena Underworld, Iron Guard, Iron Hyena Raider
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
- retained card: Esprit du Léopard
- discarded cards: River Hunter, Pale River Spirit, Root-Woven Guard
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
- retained card: Rust Hyena Spirit
- discarded cards: Bone-Cracker Cub, False Opening, Iron Guard
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

Hand before draw: [Rust Hyena Spirit]

Board before ready:
Beings/Spirits: Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Raider
- Main 1: played Rust Hyena Spirit

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 4.
- Result: Iron Hyena Raider survives, Hunter’s Root-Stone at 6/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Champion, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Iron Hyena Raider [Relic:Bone Spear], Rust Hyena Spirit

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Young Hunter
- Main 1: resolved Ritual of Red Moon (dealt 2 to Iron Hyena Raider, destroyed it, gained 1 Memory)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Hunter’s Call, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: River Hunter, Young Hunter

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Rust Hyena Spirit
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: prepared Iron Snare
- Main 1: attached Fang Relic to Rust Hyena Spirit

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: River Hunter
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: River Hunter deals 3 to Rust Hyena Spirit. | Rust Hyena Spirit deals 3 to River Hunter.
- Result: Rust Hyena Spirit left battle, River Hunter removed

Main 2:
- Main 2: awakened Smith of Black Teeth

End:
- retained card: Bone Spear
- discarded cards: Black-Tooth Smith, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 2

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: attached Esprit du Léopard to Young Hunter
- Main 1: played Pale River Spirit

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: Iron Snare
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 5.
- Result: Young Hunter survives, Bone-Fang Shrine at 5/10

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Leopard Hunter
- discarded cards: Hunter’s Call, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
- board at end: Pale River Spirit, Young Hunter [Possession:Esprit du Léopard]

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 1/0
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Smith of Black Teeth
Forgotten cards: Red 1 | Iron 0
Key events: Main 1: attached Fang Relic to Rust Hyena Spirit | Main 2: awakened Smith of Black Teeth | Shrine Bone-Fang Shrine takes 5. | Main 1: attached Esprit du Léopard to Young Hunter | Main 1: played Pale River Spirit | Main 2: awakened Grandmother Beneath the Roots
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Pale River Spirit, Young Hunter [Possession:Esprit du Léopard]
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 5.
- Result: Young Hunter survives, Bone-Fang Shrine at 0/10

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Ritual of Red Moon, Deep River Spirit, Leopard Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: Pale River Spirit, River Hunter, Young Hunter [Possession:Esprit du Léopard]

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Black-Tooth Smith, False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Pale River Spirit, River Hunter, Young Hunter [Possession:Esprit du Léopard]
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 4 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Leopard Hunter
- discarded cards: Offering of Milk and Ash, Spear of First Dawn
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
- board at end: Pale River Spirit, River Hunter, Young Hunter, Young Hunter

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Iron Snare]

Main 1:
- Main 1: prepared Iron Snare
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Rust Hyena Spirit, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

# End of Phase 3 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10]
Resources: Red 4/0 | Iron 4/0
Awakened Ancestors: Red First Hunter | Iron Smith of Black Teeth
Forgotten cards: Red 1 | Iron 2
Key events: Young Hunter deals 4 to Iron Hyena Raider. | Main 1: played Young Hunter | Main 1: played Young Hunter | Main 2: awakened First Hunter | Main 1: prepared Iron Snare | Main 1: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: Iron Snare
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone, broke it, gained 1 Memory)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Fang Relic, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Pale River Spirit, River Hunter, Young Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter
- Main 1: attached Spear of First Dawn to Pale River Spirit

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
- retained card: Kuma Who Wounded the Sun
- discarded cards: Root-Woven Guard, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, Pale River Spirit [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter, Young Hunter

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:
- no attacks

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Hyena Pack Call
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Relic:Bone Spear], Bone Spear, Hyena Token, Hyena Token, Iron Hyena Raider

## Turn 16 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 2

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Leopard Hunter, Pale River Spirit [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Spear of First Dawn to Pale River Spirit

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 5.
- Result: Leopard Hunter survives, Iron Hyena Den at 5/10

Attack 2:
- Attacker: Young Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: prepared Hunter’s Call

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, Pale River Spirit [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter

# End of Phase 4 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/3 | Iron 1/1
Awakened Ancestors: Red First Hunter | Iron Smith of Black Teeth
Forgotten cards: Red 1 | Iron 6
Key events: Shrine Iron Hyena Den takes 5. | Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Raider. | Main 1: played River Hunter | Main 1: attached Spear of First Dawn to Pale River Spirit | Main 2: prepared Hunter’s Call
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 3

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Leopard Hunter, Pale River Spirit [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: Hunter’s Call
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Iron Hyena Den)

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: None
- Damage: Black-Tooth Smith deals 3 to River Hunter. | River Hunter deals 3 to Black-Tooth Smith.
- Result: River Hunter left battle, Black-Tooth Smith removed

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Ritual of Red Moon, River Hunter, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Kuma Who Wounded the Sun, Pale River Spirit [Relic:Spear of First Dawn], Spear of First Dawn, Spear of First Dawn, Young Hunter

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Hyena Token, Hyena Token
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 8/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, Hyena Pack Call, Iron Snare, Iron Snare]

Main 1:
- Main 1: prepared False Opening
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Moonlit Roots
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Young Hunter deals 2 to Hyena Token. | Hyena Token deals 1 to Young Hunter.
- Result: Hyena Token left battle, Young Hunter removed, Moonlit Roots at 10/10

Attack 2:
- Attacker: Hyena Token
- Target: Moonlit Roots
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 6 to Hyena Token. | Hyena Token deals 1 to Kuma Who Wounded the Sun.
- Result: Hyena Token left battle, Kuma Who Wounded the Sun survives, Moonlit Roots at 10/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 8/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Hyena Token, Hyena Token

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 3

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Kuma Who Wounded the Sun [Wounded], Pale River Spirit [Relic:Spear of First Dawn], Spear of First Dawn, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Hunter’s Call, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 7 to 5.
- Damage: Shrine Iron Hyena Den takes 5.
- Result: Kuma Who Wounded the Sun survives, Iron Hyena Den at 0/10

Attack 2:
- Attacker: Pale River Spirit
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Black-Tooth Smith deals 2 to Pale River Spirit. | Pale River Spirit deals 3 to Black-Tooth Smith.
- Result: Pale River Spirit left battle, Black-Tooth Smith removed

Main 2:
- Main 2: prepared Hunter’s Call

End:
- retained card: Baobab Guardian
- discarded cards: Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: Kuma Who Wounded the Sun
- resources at end: 1 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
- board at end: Kuma Who Wounded the Sun, Leopard Hunter, Spear of First Dawn, Young Hunter

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Hyena Token, Hyena Token
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 8 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Hyena Pack Call, Hyena Pack Call, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Hyena Token

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Hyena Token. | Hyena Token deals 2 to Leopard Hunter.
- Result: Hyena Token left battle, Leopard Hunter survives, Moonlit Roots at 9/10

Attack 2:
- Attacker: Hyena Token
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 3 to Hyena Token. | Hyena Token deals 1 to Leopard Hunter.
- Result: Hyena Token left battle, Leopard Hunter survives, Moonlit Roots at 9/10

Main 2:
- Main 2: played Iron Hyena Champion
- Main 2: played Iron Hyena Raider

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Champion, Iron Hyena Raider

# End of Phase 5 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10] | Iron [Iron Hyena Den: 13/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/5 | Iron 1/0
Awakened Ancestors: Red First Hunter | Iron Smith of Black Teeth
Forgotten cards: Red 2 | Iron 8
Key events: Hyena Token deals 2 to Leopard Hunter. | Leopard Hunter deals 3 to Hyena Token. | Hyena Token deals 1 to Leopard Hunter. | Main 1: attached Bone Spear to Hyena Token | Main 2: played Iron Hyena Champion | Main 2: played Iron Hyena Raider
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Iron Hyena Champion, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 8 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Hyena Pack Call, Hyena Pack Call, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Moonlit Roots
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Iron Hyena Champion. | Iron Hyena Champion deals 5 to Leopard Hunter.
- Result: Iron Hyena Champion left battle, Leopard Hunter removed, Moonlit Roots at 9/10

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 3.
- Result: Iron Hyena Raider survives, Moonlit Roots at 6/10

Main 2:
- Main 2: played Rust Hyena Spirit

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Bone-Cracker Cub, Iron Hyena Raider, Rust Hyena Spirit

## Turn 22 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 6

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: Kuma Who Wounded the Sun, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 4/10
Forgotten zone count/list: 3 [Hunter’s Call, Hunter’s Call, Ritual of Red Moon]

Main 1:
- Main 1: attached Esprit du Léopard to Kuma Who Wounded the Sun

Combat:

Attack 1:
- Attacker: Kuma Who Wounded the Sun
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 9.
- Result: Kuma Who Wounded the Sun survives, Rusted Moon Shrine at 1/10

Attack 2:
- Attacker: Young Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: played Baobab Guardian

End:
- retained card: Pale River Spirit
- discarded cards: Baobab Guardian, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 6 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 4/10
- board at end: Baobab Guardian, Esprit du Léopard, Kuma Who Wounded the Sun [Possession:Esprit du Léopard], Spear of First Dawn

## Turn 23 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 0

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Bone-Cracker Cub, Rust Hyena Spirit
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 9/10
Forgotten zone count/list: 8 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Hyena Pack Call, Hyena Pack Call, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: Kuma Who Wounded the Sun
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 8 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Kuma Who Wounded the Sun.
- Result: Rust Hyena Spirit left battle, Kuma Who Wounded the Sun survives

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Kuma Who Wounded the Sun
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 8 to 6. | Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 6 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Kuma Who Wounded the Sun.
- Result: Bone-Cracker Cub left battle, Kuma Who Wounded the Sun survives

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Kuma Who Wounded the Sun
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 8 to 6.
- Damage: Kuma Who Wounded the Sun deals 6 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Kuma Who Wounded the Sun.
- Result: Bone-Cracker Cub left battle, Kuma Who Wounded the Sun removed

Main 2:
- Main 2: played Rust Hyena Spirit

End:
- retained card: Iron Hyena Champion
- discarded cards: Iron Hyena Underworld
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 9/10
- board at end: Bone-Cracker Cub, Bone-Cracker Cub, Rust Hyena Spirit

## Turn 24 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 7

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 6/10
Forgotten zone count/list: 4 [Hunter’s Call, Hunter’s Call, Kuma Who Wounded the Sun, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter
- Main 1: resolved Ritual of Red Moon (dealt 2 to Rust Hyena Spirit, destroyed it, gained 1 Memory)

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 3.
- Result: Baobab Guardian survives, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Offering of Milk and Ash
- discarded cards: Pale River Spirit, Deep River Spirit
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 1 Offerings / 8 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 7/10
- board at end: Baobab Guardian, Leopard Hunter, Spear of First Dawn

# End of Phase 6 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 7/10] | Iron [Iron Hyena Den: 13/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 9/10]
Resources: Red 1/8 | Iron 4/1
Awakened Ancestors: Red First Hunter | Iron Smith of Black Teeth
Forgotten cards: Red 5 | Iron 8
Key events: Main 1: played Bone-Cracker Cub | Main 1: played Bone-Cracker Cub | Main 2: played Rust Hyena Spirit | Shrine Rusted Moon Shrine takes 3. | Main 1: played Leopard Hunter | Main 1: resolved Ritual of Red Moon (dealt 2 to Rust Hyena Spirit, destroyed it, gained 1 Memory)
Tempo note: initiative reverses after every four player-turns.

## End-of-game summary

Winner: red
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Shrine of the Red Baobab 0/10, Hunter’s Root-Stone 12/10, Moonlit Roots 7/10] | Iron [Iron Hyena Den 13/10, Bone-Fang Shrine 10/10, Rusted Moon Shrine 12/10]
Final resources: Red 1/8 | Iron 4/2
Final Presence: Seat 1 2/5 | Seat 2 2/5

Turn count: 24
Phase count: 6

First Shrine damage: 5
First Shrine broken: 9
First Ancestor awakened: 7
First L2: 14
First L3: 17

Red L2 entries: 3 (hard-cast 3, evolved 0)
Red L3 entries: 1 (hard-cast 0, evolved 1, recalled 0)
Iron L2 entries: 1 (hard-cast 1, evolved 0)
Iron L3 entries: 0 (hard-cast 0, evolved 0, recalled 0)

Legal evolve actions generated: Red 2, Iron 0
Legal L2 evolve actions: Red 0, Iron 0
Legal L3 evolve actions: Red 2, Iron 0
Evolve windows: Red 2, Iron 0
Turns with legal L2 evolution: Red 0, Iron 0
Turns with legal L3 evolution: Red 2, Iron 0
Evolve actions chosen: Red 2, Iron 0
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 9, Iron 1

Legal awaken actions generated: Red 16, Iron 1
Awaken actions chosen: Red 7, Iron 1
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.grandmother, Iron iron.ancestor.smith
Ancestor switches: Red 1, Iron 0
Turns with awakened ancestor: Red 8, Iron 8
Memory spent on ancestors: Red 4, Iron 2
Ancestor realized value: First Hunter +4 damage, Grandmother healed 2, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 1 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 1, Iron 2
Prepared Tactics expired: Red 1, Iron 1
Fade cards Forgotten: Red 5, Iron 8
Wounded events: Red 5, Iron 0
Wounded reduced damage: Red 5, Iron 0
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 6, Iron 0
Blocks chosen: Red 5, Iron 0
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 12, pack 0 | Seat 2 standard 10, pack 1
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 24, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 6, generated 6, available 6, skipped 5, turns-with-bonus 4, max-attacks 30, prevented-by-limit 0
Deck reshuffles: Red 2, Iron 1

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
