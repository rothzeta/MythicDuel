# Test Game #136

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 20 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports --bot-red red --bot-iron iron --deck-red red --deck-iron iron

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

Seed: 136
Winner: iron
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Baobab Guardian, Deep River Spirit, Esprit du Léopard, Hunter’s Call, River Hunter
- Starting hands — Iron: Bite the Roots, Bone-Cracker Cub, False Opening, Hyena Pack Call, Iron Hyena Raider
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the Iron Hyena, Tooth-Mother of the Dry Earth, Smith of Black Teeth

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Baobab Guardian, Deep River Spirit, Esprit du Léopard, Hunter’s Call, River Hunter]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: prepared Hunter’s Call

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: River Hunter
- discarded cards: Baobab Guardian, Deep River Spirit, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: 

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots, Bone-Cracker Cub, False Opening, Hyena Pack Call, Iron Hyena Raider]

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
- retained card: Bite the Roots
- discarded cards: Iron Hyena Raider, Hyena Pack Call, False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

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
Forgotten zone count/list: 1 [Hunter’s Call]

Main 1:
- Main 1: played River Hunter

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Baobab Guardian
- discarded cards: River Hunter, Young Hunter, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: River Hunter

## Turn 4 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bite the Roots]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)

Combat:

Attack 1:
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
- retained card: Bone-Cracker Cub
- discarded cards: Iron Snare, False Opening, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/0 | Iron 0/1
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 1 | Iron 1
Key events: Main 1: prepared Hunter’s Call | Main 1: played Bone-Cracker Cub | Main 1: played River Hunter | Shrine Hunter’s Root-Stone takes 4. | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 4.
- Result: Bone-Cracker Cub survives, Hunter’s Root-Stone at 0/10

Main 2:
- Main 2: awakened Ancestor of the Iron Hyena

End:
- retained card: Hyena Pack Call
- discarded cards: Iron Guard, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Bone-Cracker Cub, Iron Hyena Raider

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Baobab Guardian]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Hunter’s Call]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Spear of First Dawn to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Raider deals 3 to River Hunter. | River Hunter deals 4 to Iron Hyena Raider.
- Result: River Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Leopard Hunter
- discarded cards: Baobab Guardian, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Bone-Cracker Cub
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 1 [Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Moonlit Roots)
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 5.
- Result: Bone-Cracker Cub survives, Moonlit Roots at 2/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Moonlit Roots
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Moonlit Roots takes 4.
- Result: Bone-Cracker Cub survives, Moonlit Roots at 0/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Rust Hyena Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub [Relic:Bone Spear]

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 12/10
Forgotten zone count/list: 1 [Hunter’s Call]

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
- Damage: Bone-Cracker Cub deals 3 to Young Hunter. | Young Hunter deals 2 to Bone-Cracker Cub.
- Result: Young Hunter left battle, Bone-Cracker Cub removed

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Ritual of Red Moon, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 12/10
- board at end: River Hunter, Young Hunter

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 12/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/1 | Iron 1/1
Awakened Ancestors: Red First Hunter | Iron Ancestor of the Iron Hyena
Forgotten cards: Red 1 | Iron 2
Key events: Main 1: resolved Bite the Roots (dealt 3 to Moonlit Roots) | Main 1: attached Bone Spear to Bone-Cracker Cub | Bone-Cracker Cub deals 3 to Young Hunter. | Young Hunter deals 2 to Bone-Cracker Cub. | Main 1: played River Hunter | Main 1: played Young Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 12/10
Forgotten zone count/list: 1 [Hunter’s Call]

Main 1:
- Main 1: played Leopard Hunter

Combat:

Attack 1:
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
- discarded cards: Pale River Spirit, Ritual of Red Moon, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 12/10
- board at end: Leopard Hunter, Young Hunter

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Black-Tooth Smith

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Fang Relic
- discarded cards: Rust Hyena Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Relic:Fang Relic], Bone-Cracker Cub, Fang Relic

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 3

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: Leopard Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 12/10
Forgotten zone count/list: 1 [Hunter’s Call]

Main 1:
- Main 1: played Leopard Hunter

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
- Attacker: Young Hunter
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to Young Hunter. | Young Hunter deals 2 to Bone-Cracker Cub.
- Result: Young Hunter left battle, Bone-Cracker Cub removed

Main 2:
- Main 2: resolved Offering of Milk and Ash (restored 1 to Shrine of the Red Baobab)

End:
- retained card: Ritual of Red Moon
- discarded cards: Pale River Spirit, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 12/10
- board at end: Leopard Hunter, Leopard Hunter

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Relic:Fang Relic], Fang Relic
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Bite the Roots]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Shrine of the Red Baobab)
- Main 1: attached Fang Relic to Black-Tooth Smith

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 4 to Leopard Hunter.
- Result: Black-Tooth Smith left battle, Leopard Hunter removed, Shrine of the Red Baobab at 7/10

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Iron Hyena Underworld, Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic

# End of Phase 3 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 12/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/3 | Iron 2/1
Awakened Ancestors: Red First Hunter | Iron Ancestor of the Iron Hyena
Forgotten cards: Red 2 | Iron 3
Key events: Main 1: played Leopard Hunter | Main 2: resolved Offering of Milk and Ash (restored 1 to Shrine of the Red Baobab) | Leopard Hunter deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 4 to Leopard Hunter. | Main 1: resolved Bite the Roots (dealt 3 to Shrine of the Red Baobab) | Main 1: attached Fang Relic to Black-Tooth Smith
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Fang Relic
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 3 [Bite the Roots, Bite the Roots, Bite the Roots]

Main 1:
- Main 1: prepared Iron Snare
- Main 1: played Bone-Cracker Cub

Combat:
- no attacks

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Iron Guard
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Relic:Bone Spear], Bone Spear, Bone-Cracker Cub, Fang Relic

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 3

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Leopard Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 12/10
Forgotten zone count/list: 2 [Hunter’s Call, Offering of Milk and Ash]

Main 1:
- Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Bone-Fang Shrine)

Combat:
- no attacks

Main 2:
- Main 2: resolved Ritual of Red Moon (dealt 2 to Black-Tooth Smith)

End:
- retained card: Spear of First Dawn
- discarded cards: Hunter’s Call, Spear of First Dawn
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 12/10
- board at end: Kuma Who Wounded the Sun

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Iron Guard]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Wounded, Relic:Bone Spear], Bone Spear, Bone-Cracker Cub, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Shrine of the Red Baobab
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 4 to 3. | Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 6 to Black-Tooth Smith. | Black-Tooth Smith deals 3 to Kuma Who Wounded the Sun.
- Result: Black-Tooth Smith left battle, Kuma Who Wounded the Sun survives, Shrine of the Red Baobab at 7/10

Attack 2:
- Attacker: Bone-Cracker Cub
- Target: Shrine of the Red Baobab
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 6 to 4.
- Damage: Kuma Who Wounded the Sun deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to Kuma Who Wounded the Sun.
- Result: Bone-Cracker Cub left battle, Kuma Who Wounded the Sun removed, Shrine of the Red Baobab at 7/10

Main 2:
- Main 2: played Iron Guard

End:
- retained card: Iron Hyena Champion
- discarded cards: Rust Hyena Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Fang Relic, Iron Guard, Iron Hyena Raider

## Turn 16 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 2

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 12/10
Forgotten zone count/list: 4 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Leopard Hunter

Combat:
- no attacks

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Spear of First Dawn
- discarded cards: Ritual of Red Moon, Root-Woven Guard
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 12/10
- board at end: Leopard Hunter, River Hunter

# End of Phase 4 Summary

Shrine state: Red [Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 12/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/0 | Iron 3/1
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Ancestor of the Iron Hyena
Forgotten cards: Red 4 | Iron 4
Key events: Main 1: played Bone-Cracker Cub | Main 1: played Iron Hyena Raider | Main 2: played Iron Guard | Main 1: played River Hunter | Main 1: played Leopard Hunter | Main 2: awakened Grandmother Beneath the Roots
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: Leopard Hunter, River Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 12/10
Forgotten zone count/list: 4 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Spear of First Dawn to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Guard
- Defender/blocker: Iron Guard
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Guard deals 2 to River Hunter. | River Hunter deals 4 to Iron Guard.
- Result: River Hunter left battle, Iron Guard removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Deep River Spirit
- discarded cards: Root-Woven Guard, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 12/10
- board at end: Leopard Hunter, Young Hunter

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Fang Relic, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare]

Main 1:
- Main 1: prepared Iron Snare

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 4 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed, Shrine of the Red Baobab at 8/10

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 4.
- Result: Iron Hyena Raider survives, Shrine of the Red Baobab at 3/10

Main 2:
- pass

End:
- retained card: Iron Hyena Underworld
- discarded cards: Iron Hyena Champion, False Opening, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 7 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
- board at end: Fang Relic, Iron Hyena Raider

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 12/10
Forgotten zone count/list: 4 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon]

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
- retained card: Deep River Spirit
- discarded cards: River Hunter, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 12/10
- board at end: River Hunter, Young Hunter

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 7
Memory before resource: 2

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Fang Relic
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Iron Hyena Underworld
- discarded cards: Hyena Pack Call, Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Fang Relic, Iron Hyena Raider

# End of Phase 5 Summary

Shrine state: Red [Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 11/10, Moonlit Roots: 12/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/1 | Iron 5/2
Awakened Ancestors: Red First Hunter | Iron Ancestor of the Iron Hyena
Forgotten cards: Red 4 | Iron 5
Key events: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Raider. | Main 1: played Young Hunter | Main 1: played River Hunter | Main 1: played Bone-Cracker Cub | Main 1: played Iron Hyena Raider
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 2

Hand before draw: [Iron Hyena Underworld]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Fang Relic, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the Iron Hyena
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 5 [Bite the Roots, Bite the Roots, Bite the Roots, Iron Snare, Iron Snare]

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
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
- retained card: Black-Tooth Smith
- discarded cards: Iron Hyena Underworld, Rust Hyena Spirit, False Opening
- forgotten cards: None
- Wounded clears: None
- resources at end: 7 Offerings / 3 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 8/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub [Relic:Bone Spear], Fang Relic, Iron Hyena Raider

## End-of-game summary

Winner: iron
End reason: ShrineBreak
Outcome: IronWin

Final Shrine state: Red [Shrine of the Red Baobab 12/10, Hunter’s Root-Stone 11/10, Moonlit Roots 12/10] | Iron [Iron Hyena Den 0/10, Bone-Fang Shrine 8/10, Rusted Moon Shrine 0/10]
Final resources: Red 5/1 | Iron 7/3
Final Presence: Seat 1 2/5 | Seat 2 2/5

Turn count: 21
Phase count: 6

First Shrine damage: 4
First Shrine broken: 5
First Ancestor awakened: 5
First L2: 9
First L3: 14

Red L2 entries: 3 (hard-cast 3, evolved 0)
Red L3 entries: 1 (hard-cast 0, evolved 1, recalled 0)
Iron L2 entries: 0 (hard-cast 0, evolved 0)
Iron L3 entries: 0 (hard-cast 0, evolved 0, recalled 0)

Legal evolve actions generated: Red 2, Iron 0
Legal L2 evolve actions: Red 0, Iron 0
Legal L3 evolve actions: Red 2, Iron 0
Evolve windows: Red 2, Iron 0
Turns with legal L2 evolution: Red 0, Iron 0
Turns with legal L3 evolution: Red 2, Iron 0
Evolve actions chosen: Red 2, Iron 0
Hard-cast chosen while legal evolve action existed: Red 0, Iron 0
Hard-cast chosen while evolution base existed: Red 7, Iron 1

Legal awaken actions generated: Red 11, Iron 4
Awaken actions chosen: Red 5, Iron 3
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.firsthunter, Iron iron.ancestor.hyena
Ancestor switches: Red 2, Iron 0
Turns with awakened ancestor: Red 7, Iron 8
Memory spent on ancestors: Red 6, Iron 2
Ancestor realized value: First Hunter +1 damage, Grandmother healed 1, Child draw/discard 0, Iron Hyena +3 damage, Smith saved 0 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 0, Iron 0
Prepared Tactics expired: Red 1, Iron 2
Fade cards Forgotten: Red 4, Iron 5
Wounded events: Red 1, Iron 1
Wounded reduced damage: Red 1, Iron 1
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 4, Iron 0
Blocks chosen: Red 4, Iron 0
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 7, pack 0 | Seat 2 standard 10, pack 0
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 20, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 9, generated 9, available 9, skipped 9, turns-with-bonus 6, max-attacks 31, prevented-by-limit 0
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
