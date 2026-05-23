# Test Game #181

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

Seed: 181
Winner: red
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Deep River Spirit, Esprit du Léopard, Root-Woven Guard, Root-Woven Guard, Spear of First Dawn
- Starting hands — Iron: Black-Tooth Smith, Iron Hyena Champion, Iron Hyena Champion, Iron Hyena Raider, Iron Snare
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the Iron Hyena, Tooth-Mother of the Dry Earth, Smith of Black Teeth

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Deep River Spirit, Esprit du Léopard, Root-Woven Guard, Root-Woven Guard, Spear of First Dawn]

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
- retained card: Deep River Spirit
- discarded cards: Esprit du Léopard, Root-Woven Guard, Root-Woven Guard, Spear of First Dawn
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: 

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Black-Tooth Smith, Iron Hyena Champion, Iron Hyena Champion, Iron Hyena Raider, Iron Snare]

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
- discarded cards: Black-Tooth Smith, Iron Hyena Champion, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Deep River Spirit]

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
- retained card: Pale River Spirit
- discarded cards: Deep River Spirit, Baobab Guardian, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Iron Hyena Raider]

Board before ready:
Beings/Spirits: 
Prepared Tactic: Iron Snare
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
- retained card: Bone-Cracker Cub
- discarded cards: Iron Hyena Raider, Black-Tooth Smith, Iron Hyena Underworld
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: 

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/0 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 1
Key events: Main 1: prepared Iron Snare | Main 1: played Young Hunter | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: 
Prepared Tactic: Iron Snare
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: prepared Iron Snare
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Iron Guard, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Spear of First Dawn to Young Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: Iron Snare, Iron Snare
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to Young Hunter. | Young Hunter deals 3 to Bone-Cracker Cub.
- Result: Young Hunter left battle, Bone-Cracker Cub removed

Main 2:
- pass

End:
- retained card: Ritual of Red Moon
- discarded cards: Pale River Spirit, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Iron Guard
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Fang Relic, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Hyena Token, Hyena Token, Iron Guard

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: attached Esprit du Léopard to Young Hunter
- Main 1: resolved Ritual of Red Moon (dealt 2 to Iron Guard)

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Hyena Token
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Hyena Token deals 1 to Young Hunter. | Young Hunter deals 4 to Hyena Token.
- Result: Young Hunter left battle, Hyena Token removed

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Ritual of Red Moon
- discarded cards: Pale River Spirit, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
- board at end: 

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/0
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron None
Forgotten cards: Red 1 | Iron 3
Key events: Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens) | Hyena Token deals 1 to Young Hunter. | Young Hunter deals 4 to Hyena Token. | Main 1: attached Esprit du Léopard to Young Hunter | Main 1: resolved Ritual of Red Moon (dealt 2 to Iron Guard) | Main 2: awakened Grandmother Beneath the Roots
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter

Combat:
- no attacks

Main 2:
- Main 2: resolved Ritual of Red Moon (dealt 2 to Iron Guard)

End:
- retained card: Leopard Hunter
- discarded cards: Deep River Spirit, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: River Hunter

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Hyena Token, Iron Guard [Wounded]
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: attached Bone Spear to Iron Guard

Combat:

Attack 1:
- Attacker: Iron Guard
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Guard from 4 to 3.
- Damage: Shrine Hunter’s Root-Stone takes 3.
- Result: Iron Guard survives, Hunter’s Root-Stone at 4/10

Attack 2:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 2.
- Result: Hyena Token survives, Hunter’s Root-Stone at 2/10

Main 2:
- Main 2: played Iron Hyena Raider

End:
- retained card: Fang Relic
- discarded cards: False Opening
- forgotten cards: None
- Wounded clears: Iron Guard
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Hyena Token, Iron Guard [Relic:Bone Spear], Iron Hyena Raider

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 8/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Guard
- Defender/blocker: Iron Guard
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Guard deals 3 to River Hunter. | River Hunter deals 3 to Iron Guard.
- Result: River Hunter left battle, Iron Guard removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Leopard Hunter
- discarded cards: Ritual of Red Moon, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
- board at end: River Hunter, Young Hunter

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Hyena Token, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: prepared False Opening
- Main 1: attached Fang Relic to Hyena Token

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 3.
- Result: Hyena Token survives, Hunter’s Root-Stone at 0/10

Main 2:
- Main 2: played Rust Hyena Spirit

End:
- retained card: Rust Hyena Spirit
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Hyena Token [Relic:Fang Relic], Iron Hyena Raider, Rust Hyena Spirit

# End of Phase 3 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/0 | Iron 1/1
Awakened Ancestors: Red First Hunter | Iron None
Forgotten cards: Red 2 | Iron 4
Key events: Main 1: played River Hunter | Main 2: awakened First Hunter | Shrine Hunter’s Root-Stone takes 3. | Main 1: prepared False Opening | Main 1: attached Fang Relic to Hyena Token | Main 2: played Rust Hyena Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Rust Hyena Spirit]

Board before ready:
Beings/Spirits: Fang Relic, Hyena Token [Relic:Fang Relic], Iron Hyena Raider, Rust Hyena Spirit
Prepared Tactic: False Opening
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Moonlit Roots)
- Main 1: attached Bone Spear to Hyena Token

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: River Hunter
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: River Hunter deals 3 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to River Hunter.
- Result: Rust Hyena Spirit left battle, River Hunter removed

Attack 2:
- Attacker: Hyena Token
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 3.
- Result: Hyena Token survives, Moonlit Roots at 3/10

Attack 3:
- Attacker: Iron Hyena Raider
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 4.
- Result: Iron Hyena Raider survives, Moonlit Roots at 0/10

Main 2:
- Main 2: played Rust Hyena Spirit
- Main 2: awakened Ancestor of the Iron Hyena

End:
- retained card: Bone-Cracker Cub
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Fang Relic, Hyena Token [Relic:Bone Spear], Iron Hyena Raider, Rust Hyena Spirit

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 2 [Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter

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
- discarded cards: Kuma Who Wounded the Sun, Baobab Guardian, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Leopard Hunter

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Bone Spear, Fang Relic, Hyena Token [Relic:Bone Spear], Rust Hyena Spirit
Prepared Tactic: False Opening
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: evolved Hyena Token into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab)

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Leopard Hunter.
- Result: Rust Hyena Spirit left battle, Leopard Hunter survives

Main 2:
- Main 2: played Bone-Cracker Cub

End:
- retained card: Fang Relic
- discarded cards: Hyena Pack Call, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Champion [Relic:Bone Spear]

## Turn 16 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Leopard Hunter [Wounded]
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 2 [Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Leopard Hunter
- Main 1: played Pale River Spirit

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 5 to 3.
- Damage: Iron Hyena Champion deals 6 to Leopard Hunter. | Leopard Hunter deals 3 to Iron Hyena Champion.
- Result: Leopard Hunter left battle, Iron Hyena Champion removed, Bone-Fang Shrine at 10/10

Main 2:
- pass

End:
- retained card: Deep River Spirit
- discarded cards: Hunter’s Call, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Leopard Hunter, Pale River Spirit

# End of Phase 4 Summary

Shrine state: Red [Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/2 | Iron 4/2
Awakened Ancestors: Red First Hunter | Iron Ancestor of the Iron Hyena
Forgotten cards: Red 2 | Iron 5
Key events: Main 1: evolved Hyena Token into Iron Hyena Champion (dealt 2 to Shrine of the Red Baobab) | Main 2: played Bone-Cracker Cub | Iron Hyena Champion deals 6 to Leopard Hunter. | Leopard Hunter deals 3 to Iron Hyena Champion. | Main 1: played Leopard Hunter | Main 1: played Pale River Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 2

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Leopard Hunter, Pale River Spirit
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 2 [Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 5.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 5/10

Attack 2:
- Attacker: Pale River Spirit
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to Pale River Spirit. | Pale River Spirit deals 2 to Bone-Cracker Cub.
- Result: Pale River Spirit left battle, Bone-Cracker Cub removed

Main 2:
- Main 2: played Deep River Spirit
- Main 2: prepared Root-Woven Guard

End:
- retained card: Ritual of Red Moon
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Deep River Spirit, Leopard Hunter, Young Hunter, Young Hunter

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 2

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Fang Relic
Prepared Tactic: False Opening
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Iron Hyena Champion

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Fang Relic, Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Iron Hyena Champion, Iron Hyena Raider

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 2

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Deep River Spirit, Leopard Hunter, Young Hunter, Young Hunter
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 2 [Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: resolved Ritual of Red Moon (dealt 2 to Iron Hyena Champion)

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 5.
- Result: Leopard Hunter survives, Bone-Fang Shrine at 0/10

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
- discarded cards: Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Baobab Guardian, Deep River Spirit, Leopard Hunter, River Hunter, Young Hunter

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 2

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Fang Relic, Iron Hyena Champion [Wounded]
Prepared Tactic: False Opening
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Iron Hyena Champion
- Main 1: prepared False Opening

Combat:

Attack 1:
- Attacker: Iron Hyena Champion
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 6 to 4. | Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Iron Hyena Champion. | Iron Hyena Champion deals 4 to Deep River Spirit.
- Result: Iron Hyena Champion left battle, Deep River Spirit survives

Main 2:
- Main 2: played Iron Guard

End:
- retained card: Hyena Pack Call
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Iron Guard

# End of Phase 5 Summary

Shrine state: Red [Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/3 | Iron 4/1
Awakened Ancestors: Red First Hunter | Iron Ancestor of the Iron Hyena
Forgotten cards: Red 3 | Iron 5
Key events: Main 2: played Baobab Guardian | Deep River Spirit deals 3 to Iron Hyena Champion. | Iron Hyena Champion deals 4 to Deep River Spirit. | Main 1: attached Bone Spear to Iron Hyena Champion | Main 1: prepared False Opening | Main 2: played Iron Guard
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Fang Relic, Iron Guard
Prepared Tactic: False Opening, False Opening
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Guard
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2. | Iron Guard becomes Wounded. | Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 2 to Iron Guard. | Iron Guard deals 2 to Deep River Spirit.
- Result: Iron Guard survives, Deep River Spirit survives

Main 2:
- Main 2: played Rust Hyena Spirit

End:
- retained card: Iron Hyena Underworld
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Fang Relic, Iron Guard [Wounded], Iron Hyena Raider, Rust Hyena Spirit

## Turn 22 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 3

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian, Deep River Spirit [Wounded], Leopard Hunter, River Hunter, Young Hunter
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 3 [Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Guard
- Defender/blocker: Iron Guard
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Guard from 2 to 1. | Leopard Hunter becomes Wounded.
- Damage: Iron Guard deals 1 to Leopard Hunter. | Leopard Hunter deals 5 to Iron Guard.
- Result: Leopard Hunter survives, Iron Guard removed

Main 2:
- Main 2: resolved Offering of Milk and Ash (restored 3 to Shrine of the Red Baobab)
- Main 2: prepared Root-Woven Guard

End:
- retained card: Pale River Spirit
- discarded cards: River Hunter
- forgotten cards: None
- Wounded clears: Deep River Spirit
- resources at end: 4 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Baobab Guardian, Deep River Spirit, Leopard Hunter [Wounded, Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Young Hunter

## Turn 23 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Fang Relic, Iron Hyena Raider, Rust Hyena Spirit
Prepared Tactic: False Opening, False Opening
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Black-Tooth Smith

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Deep River Spirit.
- Result: Rust Hyena Spirit left battle, Deep River Spirit survives

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2. | Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 2 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Deep River Spirit.
- Result: Bone-Cracker Cub left battle, Deep River Spirit survives

Attack 3:
- Attacker: Iron Hyena Raider
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2.
- Damage: Deep River Spirit deals 2 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Deep River Spirit.
- Result: Iron Hyena Raider left battle, Deep River Spirit removed

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Black-Tooth Smith, Bone-Cracker Cub, Fang Relic

## Turn 24 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 3

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian, Leopard Hunter [Wounded, Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 4 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Spear of First Dawn to Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 8 to 6.
- Damage: Shrine Iron Hyena Den takes 6.
- Result: Leopard Hunter survives, Iron Hyena Den at 4/10

Attack 2:
- Attacker: River Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Black-Tooth Smith deals 2 to River Hunter. | River Hunter deals 3 to Black-Tooth Smith.
- Result: River Hunter left battle, Black-Tooth Smith removed

Main 2:
- Main 2: played Pale River Spirit

End:
- retained card: Esprit du Léopard
- discarded cards: Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 2 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Baobab Guardian, Leopard Hunter [Relic:Spear of First Dawn], Pale River Spirit, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter

# End of Phase 6 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10]
Resources: Red 2/5 | Iron 1/2
Awakened Ancestors: Red First Hunter | Iron Ancestor of the Iron Hyena
Forgotten cards: Red 4 | Iron 5
Key events: Shrine Iron Hyena Den takes 6. | Black-Tooth Smith deals 2 to River Hunter. | River Hunter deals 3 to Black-Tooth Smith. | Main 1: played River Hunter | Main 1: attached Spear of First Dawn to Leopard Hunter | Main 2: played Pale River Spirit
Tempo note: initiative reverses after every four player-turns.

## Turn 25 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 5

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian, Leopard Hunter [Relic:Spear of First Dawn], Pale River Spirit, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 4 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: attached Esprit du Léopard to Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 10.
- Result: Leopard Hunter survives, Iron Hyena Den at 0/10

Main 2:
- pass

End:
- retained card: Deep River Spirit
- discarded cards: Baobab Guardian, Deep River Spirit, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Baobab Guardian, Esprit du Léopard, Leopard Hunter [Relic:Spear of First Dawn, Possession:Esprit du Léopard], Pale River Spirit, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter

## Turn 26 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 2

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone-Cracker Cub, Fang Relic
Prepared Tactic: False Opening, False Opening
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Black-Tooth Smith

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 7 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter survives

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 7 to 5.
- Damage: Leopard Hunter deals 5 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed

Main 2:
- pass

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Hyena Champion, Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Fang Relic, Iron Hyena Raider

## Turn 27 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 6

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 4 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Black-Tooth Smith deals 2 to River Hunter. | River Hunter deals 3 to Black-Tooth Smith.
- Result: River Hunter left battle, Black-Tooth Smith removed

Attack 2:
- Attacker: Young Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: played Deep River Spirit

End:
- retained card: Pale River Spirit
- discarded cards: Hunter’s Call, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Baobab Guardian, Deep River Spirit, Pale River Spirit, Spear of First Dawn, Young Hunter

## Turn 28 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 2

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Fang Relic
Prepared Tactic: False Opening, False Opening
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- Main 2: played Iron Guard
- Main 2: played Iron Guard

End:
- retained card: Iron Hyena Underworld
- discarded cards: None
- forgotten cards: None
- Wounded clears: Iron Guard
- resources at end: 2 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Iron Guard, Iron Guard

# End of Phase 7 Summary

Shrine state: Red [Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10] | Iron [Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/7 | Iron 2/2
Awakened Ancestors: Red First Hunter | Iron Ancestor of the Iron Hyena
Forgotten cards: Red 4 | Iron 5
Key events: Main 1: played Young Hunter | Main 2: played Deep River Spirit | Main 1: played Bone-Cracker Cub | Main 1: played Bone-Cracker Cub | Main 2: played Iron Guard | Main 2: played Iron Guard
Tempo note: initiative reverses after every four player-turns.

## Turn 29 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 2

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Iron Guard, Iron Guard
Prepared Tactic: False Opening, False Opening
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Iron Guard
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 3 to Iron Guard. | Iron Guard deals 2 to Deep River Spirit.
- Result: Iron Guard left battle, Deep River Spirit survives

Attack 2:
- Attacker: Iron Guard
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2. | Iron Guard becomes Wounded. | Deep River Spirit becomes Wounded.
- Damage: Deep River Spirit deals 2 to Iron Guard. | Iron Guard deals 2 to Deep River Spirit.
- Result: Iron Guard survives, Deep River Spirit survives

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Deep River Spirit
- Defender/blocker: Deep River Spirit
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Deep River Spirit from 3 to 2.
- Damage: Deep River Spirit deals 2 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Deep River Spirit.
- Result: Bone-Cracker Cub left battle, Deep River Spirit removed

Main 2:
- Main 2: played Iron Hyena Champion
- Main 2: played Bone-Cracker Cub
- Main 2: awakened Tooth-Mother of the Dry Earth

End:
- retained card: Iron Hyena Underworld
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: Iron Hyena Champion
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Iron Guard [Wounded], Iron Hyena Champion

## Turn 30 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 8

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian, Pale River Spirit, Spear of First Dawn, Young Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 4 [Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to Young Hunter. | Young Hunter deals 2 to Bone-Cracker Cub.
- Result: Young Hunter left battle, Bone-Cracker Cub removed

Main 2:
- Main 2: played Pale River Spirit
- Main 2: resolved Offering of Milk and Ash (restored 1 to Shrine of the Red Baobab)

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 9 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Baobab Guardian, Pale River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter

## Turn 31 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Fang Relic, Iron Guard [Wounded], Iron Hyena Champion
Prepared Tactic: False Opening, False Opening
Awakened Ancestor: Tooth-Mother of the Dry Earth
Shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Iron Guard

Combat:

Attack 1:
- Attacker: Iron Guard
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Guard from 4 to 3. | Iron Guard becomes Wounded. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 2 to Iron Guard. | Iron Guard deals 3 to Baobab Guardian.
- Result: Iron Guard survives, Baobab Guardian survives

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1. | Iron Hyena Champion becomes Wounded.
- Damage: Baobab Guardian deals 1 to Iron Hyena Champion. | Iron Hyena Champion deals 5 to Baobab Guardian.
- Result: Iron Hyena Champion survives, Baobab Guardian removed

Main 2:
- Main 2: played Rust Hyena Spirit
- Main 2: played Iron Hyena Raider

End:
- retained card: Iron Hyena Underworld
- discarded cards: Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Guard [Wounded, Relic:Fang Relic], Iron Hyena Champion [Wounded], Iron Hyena Raider, Rust Hyena Spirit

## Turn 32 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 9

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Pale River Spirit, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 5 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Champion from 6 to 4.
- Damage: Iron Hyena Champion deals 4 to River Hunter. | River Hunter deals 3 to Iron Hyena Champion.
- Result: River Hunter left battle, Iron Hyena Champion removed

Main 2:
- pass

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Esprit du Léopard, Deep River Spirit, Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 11 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Leopard Hunter [Wounded], Pale River Spirit, Pale River Spirit, Spear of First Dawn

# End of Phase 8 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10] | Iron [Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/11 | Iron 2/0
Awakened Ancestors: Red First Hunter | Iron Tooth-Mother of the Dry Earth
Forgotten cards: Red 5 | Iron 5
Key events: Main 1: attached Fang Relic to Iron Guard | Main 2: played Rust Hyena Spirit | Main 2: played Iron Hyena Raider | Iron Hyena Champion deals 4 to River Hunter. | River Hunter deals 3 to Iron Hyena Champion. | Main 1: evolved Young Hunter into Leopard Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 33 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 11

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Leopard Hunter [Wounded], Pale River Spirit, Pale River Spirit, Spear of First Dawn
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 5 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Spear of First Dawn to Pale River Spirit

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Guard
- Defender/blocker: Iron Guard
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Wounded reduces Iron Guard from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Iron Guard deals 3 to Leopard Hunter. | Leopard Hunter deals 3 to Iron Guard.
- Result: Leopard Hunter survives, Iron Guard removed

Attack 2:
- Attacker: Pale River Spirit
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to Pale River Spirit. | Pale River Spirit deals 3 to Iron Hyena Raider.
- Result: Pale River Spirit left battle, Iron Hyena Raider removed

Main 2:
- Main 2: played Baobab Guardian

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Hunter’s Call
- forgotten cards: None
- Wounded clears: Baobab Guardian
- resources at end: 1 Offerings / 13 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Baobab Guardian, Leopard Hunter [Wounded], Pale River Spirit, River Hunter, Spear of First Dawn

## Turn 34 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Fang Relic, Rust Hyena Spirit
Prepared Tactic: False Opening
Awakened Ancestor: Tooth-Mother of the Dry Earth
Shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 6 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 3 to Rust Hyena Spirit. | Rust Hyena Spirit deals 2 to Leopard Hunter.
- Result: Rust Hyena Spirit left battle, Leopard Hunter survives

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed

Main 2:
- Main 2: played Rust Hyena Spirit
- Main 2: played Iron Hyena Raider

End:
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Underworld
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Iron Hyena Raider, Rust Hyena Spirit

## Turn 35 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 14

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Baobab Guardian, Pale River Spirit, River Hunter, Spear of First Dawn
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 5 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 3.
- Result: Baobab Guardian survives, Rusted Moon Shrine at 7/10

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Deep River Spirit, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 12 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Baobab Guardian, Leopard Hunter [Wounded], Pale River Spirit, Spear of First Dawn, Young Hunter

## Turn 36 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Fang Relic, Iron Hyena Raider, Rust Hyena Spirit
Prepared Tactic: None
Awakened Ancestor: Tooth-Mother of the Dry Earth
Shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Fang Relic to Rust Hyena Spirit

Combat:

Attack 1:
- Attacker: Rust Hyena Spirit
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 3 to Rust Hyena Spirit. | Rust Hyena Spirit deals 3 to Leopard Hunter.
- Result: Rust Hyena Spirit left battle, Leopard Hunter survives

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Leopard Hunter.
- Result: Iron Hyena Raider left battle, Leopard Hunter removed

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: resolved Hyena Pack Call (summoned 2 Hyena Tokens)
- Main 2: awakened Smith of Black Teeth

End:
- retained card: Iron Hyena Underworld
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10
- board at end: Black-Tooth Smith, Fang Relic, Hyena Token, Hyena Token

# End of Phase 9 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10] | Iron [Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10]
Resources: Red 4/12 | Iron 1/0
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Smith of Black Teeth
Forgotten cards: Red 5 | Iron 7
Key events: Leopard Hunter deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Leopard Hunter. | Main 1: attached Fang Relic to Rust Hyena Spirit | Main 2: played Black-Tooth Smith | Main 2: resolved Hyena Pack Call (summoned 2 Hyena Tokens) | Main 2: awakened Smith of Black Teeth
Tempo note: initiative reverses after every four player-turns.

## Turn 37 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Fang Relic, Hyena Token, Hyena Token
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Black-Tooth Smith becomes Wounded. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 2 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Baobab Guardian.
- Result: Black-Tooth Smith survives, Baobab Guardian survives

Attack 2:
- Attacker: Hyena Token
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 1 to Hyena Token. | Hyena Token deals 1 to Baobab Guardian.
- Result: Hyena Token left battle, Baobab Guardian survives

Main 2:
- pass

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Hyena Champion, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: Iron Hyena Champion
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 3/10
- board at end: Black-Tooth Smith [Wounded], Fang Relic, Hyena Token, Iron Hyena Champion, Iron Hyena Raider

## Turn 38 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 13

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Baobab Guardian [Wounded], Pale River Spirit, Spear of First Dawn, Young Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 5 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1.
- Damage: Shrine Rusted Moon Shrine takes 1.
- Result: Baobab Guardian survives, Rusted Moon Shrine at 6/10

Attack 2:
- Attacker: Young Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Rusted Moon Shrine takes 2.
- Result: Young Hunter survives, Rusted Moon Shrine at 4/10

Main 2:
- Main 2: attached Esprit du Léopard to Baobab Guardian

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: River Hunter
- forgotten cards: None
- Wounded clears: Baobab Guardian
- resources at end: 3 Offerings / 12 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter, Young Hunter

## Turn 39 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Wounded], Fang Relic, Hyena Token, Iron Hyena Champion, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 6/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Black-Tooth Smith

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 3 to 2. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 2 to Baobab Guardian.
- Result: Black-Tooth Smith left battle, Baobab Guardian survives

Attack 2:
- Attacker: Hyena Token
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 4 to 3. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 3 to Hyena Token. | Hyena Token deals 1 to Baobab Guardian.
- Result: Hyena Token left battle, Baobab Guardian survives

Attack 3:
- Attacker: Iron Hyena Raider
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 4 to 3.
- Damage: Baobab Guardian deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Baobab Guardian.
- Result: Iron Hyena Raider left battle, Baobab Guardian removed

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: played Iron Guard

End:
- retained card: Iron Hyena Underworld
- discarded cards: Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 6/10
- board at end: Bone-Cracker Cub, Fang Relic, Iron Guard, Iron Hyena Champion

## Turn 40 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 14

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter, Young Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 5 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: attached Spear of First Dawn to Pale River Spirit

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to River Hunter. | River Hunter deals 3 to Iron Hyena Champion.
- Result: River Hunter left battle, Iron Hyena Champion removed

Attack 2:
- Attacker: Young Hunter
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to Young Hunter. | Young Hunter deals 2 to Bone-Cracker Cub.
- Result: Young Hunter left battle, Bone-Cracker Cub removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Kuma Who Wounded the Sun, Hunter’s Call, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 14 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Pale River Spirit [Relic:Spear of First Dawn], Spear of First Dawn, Spear of First Dawn, Young Hunter

# End of Phase 10 Summary

Shrine state: Red [Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10] | Iron [Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 6/10]
Resources: Red 6/14 | Iron 5/0
Awakened Ancestors: Red First Hunter | Iron Smith of Black Teeth
Forgotten cards: Red 5 | Iron 7
Key events: Iron Hyena Champion deals 5 to River Hunter. | River Hunter deals 3 to Iron Hyena Champion. | Bone-Cracker Cub deals 2 to Young Hunter. | Young Hunter deals 2 to Bone-Cracker Cub. | Main 1: attached Spear of First Dawn to Pale River Spirit | Main 2: awakened First Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 41 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 14

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Pale River Spirit [Relic:Spear of First Dawn], Spear of First Dawn, Spear of First Dawn, Young Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 5 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Pale River Spirit
- Target: Iron Guard
- Defender/blocker: Iron Guard
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Guard deals 2 to Pale River Spirit. | Pale River Spirit deals 3 to Iron Guard.
- Result: Pale River Spirit left battle, Iron Guard removed

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Hunter’s Call, Pale River Spirit
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 4 Offerings / 16 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Leopard Hunter, Spear of First Dawn, Young Hunter

## Turn 42 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Fang Relic
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 6/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Guard

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Iron Hyena Underworld, Rust Hyena Spirit
- forgotten cards: None
- Wounded clears: Iron Guard
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 6/10
- board at end: Bone-Cracker Cub, Fang Relic, Iron Guard

## Turn 43 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 16

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Leopard Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 5 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Guard
- Defender/blocker: Iron Guard
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Iron Guard deals 2 to Leopard Hunter. | Leopard Hunter deals 4 to Iron Guard.
- Result: Leopard Hunter survives, Iron Guard removed

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Baobab Guardian, Deep River Spirit
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 3 Offerings / 16 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Leopard Hunter, Leopard Hunter [Wounded], River Hunter, Spear of First Dawn

## Turn 44 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 6/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: Root-Woven Guard, Root-Woven Guard
- Wounded/Pierce calculations: None
- Damage: Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed, Shrine of the Red Baobab at 7/10

Main 2:
- Main 2: played Bone-Cracker Cub

End:
- retained card: Hyena Pack Call
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 6/10
- board at end: Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic

# End of Phase 11 Summary

Shrine state: Red [Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10] | Iron [Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 6/10]
Resources: Red 3/16 | Iron 6/0
Awakened Ancestors: Red First Hunter | Iron Smith of Black Teeth
Forgotten cards: Red 5 | Iron 7
Key events: Main 1: played River Hunter | Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to Leopard Hunter. | Main 1: attached Bone Spear to Bone-Cracker Cub | Main 1: played Bone-Cracker Cub | Main 2: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 45 — Iron

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Smith of Black Teeth
Shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 6/10
Forgotten zone count/list: 7 [Bite the Roots, Bite the Roots, Bite the Roots, False Opening, False Opening, Iron Snare, Iron Snare]

Main 1:
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)
- Main 1: played Black-Tooth Smith

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 3.
- Result: Bone-Cracker Cub survives, Shrine of the Red Baobab at 4/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 3.
- Result: Bone-Cracker Cub survives, Shrine of the Red Baobab at 1/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Token, Hyena Token
- forgotten cards: None
- Wounded clears: Black-Tooth Smith
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 16/10, Bone-Fang Shrine: 10/10, Rusted Moon Shrine: 6/10
- board at end: Black-Tooth Smith, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic, Hyena Token, Hyena Token

## Turn 46 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 17

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Leopard Hunter [Wounded], River Hunter, Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 9/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
Forgotten zone count/list: 7 [Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Esprit du Léopard to Leopard Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Rusted Moon Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 7 to 5.
- Damage: Shrine Rusted Moon Shrine takes 5.
- Result: Leopard Hunter survives, Rusted Moon Shrine at 0/10

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Esprit du Léopard
- discarded cards: Hunter’s Call, Hunter’s Call
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 4 Offerings / 14 Memory
- shrine state: Shrine of the Red Baobab: 8/10, Hunter’s Root-Stone: 10/10, Moonlit Roots: 11/10
- board at end: Esprit du Léopard, Leopard Hunter [Possession:Esprit du Léopard], River Hunter, River Hunter, Spear of First Dawn

## End-of-game summary

Winner: red
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Shrine of the Red Baobab 8/10, Hunter’s Root-Stone 10/10, Moonlit Roots 11/10] | Iron [Iron Hyena Den 16/10, Bone-Fang Shrine 10/10, Rusted Moon Shrine 11/10]
Final resources: Red 4/14 | Iron 3/0
Final Presence: Seat 1 3/5 | Seat 2 5/5

Turn count: 46
Phase count: 12

First Shrine damage: 4
First Shrine broken: 12
First Ancestor awakened: 8
First L2: 14
First L3: 

Red L2 entries: 6 (hard-cast 2, evolved 4)
Red L3 entries: 0 (hard-cast 0, evolved 0)
Iron L2 entries: 4 (hard-cast 3, evolved 1)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 8, Iron 2
Legal L2 evolve actions: Red 8, Iron 2
Legal L3 evolve actions: Red 0, Iron 0
Evolve windows: Red 8, Iron 2
Turns with legal L2 evolution: Red 8, Iron 2
Turns with legal L3 evolution: Red 0, Iron 0
Evolve actions chosen: Red 8, Iron 2
Hard-cast chosen while legal evolve action existed: Red 1, Iron 0
Hard-cast chosen while evolution base existed: Red 8, Iron 5

Legal awaken actions generated: Red 40, Iron 5
Awaken actions chosen: Red 16, Iron 3
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.grandmother, Iron iron.ancestor.hyena
Ancestor switches: Red 4, Iron 2
Turns with awakened ancestor: Red 19, Iron 16
Memory spent on ancestors: Red 10, Iron 6
Ancestor realized value: First Hunter +7 damage, Grandmother healed 4, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 2 Offerings, Tooth-Mother +3 damage

Prepared Tactics triggered: Red 2, Iron 4
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 7, Iron 7
Wounded events: Red 20, Iron 8
Wounded reduced damage: Red 19, Iron 7
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 1, Iron 3
Blocks chosen: Red 1, Iron 1
Blocks declined: Red 0, Iron 2
Assault slots spent: Seat 1 standard 27, pack 0 | Seat 2 standard 16, pack 15
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 46, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 18, generated 18, available 18, skipped 3, turns-with-bonus 13, max-attacks 64, prevented-by-limit 1
Deck reshuffles: Red 5, Iron 4

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
