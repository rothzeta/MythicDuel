# Test Game #516

Command: dotnet run --project MythicDuel.Sim -- --mode batch --games 500 --seed 123 --out C:\Users\cedri\source\repos\MythicDuelSim\reports\matrix_runs\current_red_vs_pack --bot-red red --bot-iron iron --deck-red red-hunter-evolution --deck-iron iron-hyena-pack-pressure

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

Seed: 516
Winner: red-hunter-evolution
Main question: Are current Shrine pressure and evolution rules stable?

## Starting setup
- Starting Shrines — Red: Shrine of the Red Baobab, Hunter’s Root-Stone, Moonlit Roots
- Starting Shrines — Iron: Iron Hyena Den, Bone-Fang Shrine, Rusted Moon Shrine
- Starting hands — Red: Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Young Hunter
- Starting hands — Iron: Blood-Scent Hyena, Bone Spear, Pack Harrier, Pack Harrier, Pack Harrier
- Starting resources: 0 Offerings / 0 Memory each before first turn resource step
- Starting battlefield: empty
- Starting Lineage — Red: First Hunter, Grandmother Beneath the Roots, Child Who Remembered the Dead
- Starting Lineage — Iron: Ancestor of the First Pack, Bone-Splitter Mother, Smith Who Passed the Fang

## Turn 1 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Hunter’s Call, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Young Hunter]

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
- retained card: Ritual of Red Moon
- discarded cards: Hunter’s Call, Root-Woven Guard, Ritual of Red Moon
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

## Turn 2 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena, Bone Spear, Pack Harrier, Pack Harrier, Pack Harrier]

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
- discarded cards: Blood-Scent Hyena, Pack Harrier, Pack Harrier
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Pack Harrier

## Turn 3 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Ritual of Red Moon]

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
- Target: Pack Harrier
- Defender/blocker: Pack Harrier
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Pack Harrier deals 1 to Young Hunter. | Young Hunter deals 2 to Pack Harrier.
- Result: Young Hunter left battle, Pack Harrier removed

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Ritual of Red Moon, Root-Woven Guard, Baobab Guardian
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Young Hunter

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
- Main 1: played Blood-Scent Hyena

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Hyena Pack Call, Bone-Cracker Cub, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena

# End of Phase 1 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/1 | Iron 0/0
Awakened Ancestors: Red None | Iron None
Forgotten cards: Red 0 | Iron 0
Key events: Main 1: played Young Hunter | Main 1: played Pack Harrier | Pack Harrier deals 1 to Young Hunter. | Young Hunter deals 2 to Pack Harrier. | Main 1: played Young Hunter | Main 1: played Blood-Scent Hyena
Tempo note: initiative reverses after every four player-turns.

## Turn 5 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Blood-Scent Hyena
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 3.
- Result: Blood-Scent Hyena survives, Hunter’s Root-Stone at 3/10

Main 2:
- pass

End:
- retained card: Bone Spear
- discarded cards: Iron Hyena Raider, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Hyena Token

## Turn 6 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 1

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Young Hunter
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 7/10, Moonlit Roots: 0/10
Forgotten zone count/list: 0 []

Main 1:
- Main 1: played River Hunter

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
- Main 2: resolved Offering of Milk and Ash (restored 3 to Hunter’s Root-Stone)
- Main 2: awakened First Hunter

End:
- retained card: Esprit du Léopard
- discarded cards: Spear of First Dawn, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: River Hunter

## Turn 7 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Bone Spear]

Board before ready:
Beings/Spirits: Hyena Token
Prepared Tactic: None
Awakened Ancestor: None
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Hyena Token
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Hyena Token
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 3.
- Result: Hyena Token survives, Hunter’s Root-Stone at 4/10

Main 2:
- Main 2: played Bone-Cracker Cub
- Main 2: awakened Smith Who Passed the Fang

End:
- retained card: Iron Hyena Champion
- discarded cards: Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Hyena Token [Relic:Bone Spear], Pack Harrier

## Turn 8 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 6/10, Moonlit Roots: 0/10
Forgotten zone count/list: 1 [Offering of Milk and Ash]

Main 1:
- Main 1: attached Spear of First Dawn to River Hunter
- Main 1: prepared Hunter’s Call

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: Hunter’s Call
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to River Hunter. | River Hunter deals 4 to Bone-Cracker Cub.
- Result: River Hunter left battle, Bone-Cracker Cub removed

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Esprit du Léopard
- discarded cards: Esprit du Léopard, Leopard Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
- board at end: 

# End of Phase 2 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/0 | Iron 1/0
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Smith Who Passed the Fang
Forgotten cards: Red 2 | Iron 2
Key events: Main 2: awakened Smith Who Passed the Fang | Bone-Cracker Cub deals 2 to River Hunter. | River Hunter deals 4 to Bone-Cracker Cub. | Main 1: attached Spear of First Dawn to River Hunter | Main 1: prepared Hunter’s Call | Main 2: awakened Grandmother Beneath the Roots
Tempo note: initiative reverses after every four player-turns.

## Turn 9 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
Forgotten zone count/list: 2 [Hunter’s Call, Offering of Milk and Ash]

Main 1:
- Main 1: resolved Ritual of Red Moon (dealt 2 to Hyena Token, destroyed it, gained 1 Memory)
- Main 1: played Baobab Guardian

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Deep River Spirit
- discarded cards: Esprit du Léopard, Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian

## Turn 10 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Smith Who Passed the Fang
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Pack Harrier
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 2 to Pack Harrier. | Pack Harrier deals 2 to Baobab Guardian.
- Result: Pack Harrier left battle, Baobab Guardian survives

Main 2:
- pass

End:
- retained card: Bone-Cracker Cub
- discarded cards: Iron Hyena Champion, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Iron Hyena Raider

## Turn 11 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Deep River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian [Wounded]
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1. | Baobab Guardian becomes Wounded. | Iron Hyena Raider becomes Wounded.
- Damage: Iron Hyena Raider deals 3 to Baobab Guardian. | Baobab Guardian deals 1 to Iron Hyena Raider.
- Result: Baobab Guardian survives, Iron Hyena Raider survives

Main 2:
- pass

End:
- retained card: Leopard Hunter
- discarded cards: Deep River Spirit, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Wounded], River Hunter, Young Hunter

## Turn 12 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Iron Hyena Raider [Wounded]
Prepared Tactic: None
Awakened Ancestor: Smith Who Passed the Fang
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 2 [Bite the Roots, Pack Ambush]

Main 1:
- Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone)
- Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine)

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Raider from 3 to 2. | Wounded reduces Baobab Guardian from 2 to 1. | Iron Hyena Raider becomes Wounded. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 1 to Iron Hyena Raider. | Iron Hyena Raider deals 2 to Baobab Guardian.
- Result: Iron Hyena Raider survives, Baobab Guardian survives

Main 2:
- Main 2: played Bone-Cracker Cub

End:
- retained card: Fang Relic
- discarded cards: Black-Tooth Smith
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone-Cracker Cub, Hyena Token, Iron Hyena Raider [Wounded]

# End of Phase 3 Summary

Shrine state: Red [Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 0/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/1 | Iron 2/0
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Smith Who Passed the Fang
Forgotten cards: Red 3 | Iron 4
Key events: Main 1: played River Hunter | Baobab Guardian deals 1 to Iron Hyena Raider. | Iron Hyena Raider deals 2 to Baobab Guardian. | Main 1: resolved Bite the Roots (dealt 3 to Hunter’s Root-Stone) | Main 1: resolved Pack Ambush (summoned Hyena Token and dealt 1 to Shrine) | Main 2: played Bone-Cracker Cub
Tempo note: initiative reverses after every four player-turns.

## Turn 13 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Hyena Token, Iron Hyena Raider [Wounded]
Prepared Tactic: None
Awakened Ancestor: Smith Who Passed the Fang
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Raider
- Main 1: attached Fang Relic to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Raider from 4 to 3. | Wounded reduces Baobab Guardian from 2 to 1. | Iron Hyena Raider becomes Wounded. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 1 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Baobab Guardian.
- Result: Iron Hyena Raider survives, Baobab Guardian survives

Attack 2:
- Attacker: Hyena Token
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1.
- Damage: Baobab Guardian deals 1 to Hyena Token. | Hyena Token deals 1 to Baobab Guardian.
- Result: Hyena Token left battle, Baobab Guardian removed

Main 2:
- Main 2: played Blood-Scent Hyena

End:
- retained card: Black-Tooth Smith
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Hyena Raider [Wounded, Relic:Fang Relic]

## Turn 14 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 2

Hand before draw: [Leopard Hunter]

Board before ready:
Beings/Spirits: River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Leopard Hunter

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Iron Hyena Raider
- Defender/blocker: Iron Hyena Raider
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Raider from 4 to 3.
- Damage: Iron Hyena Raider deals 3 to Young Hunter. | Young Hunter deals 2 to Iron Hyena Raider.
- Result: Young Hunter left battle, Iron Hyena Raider removed

Main 2:
- Main 2: awakened First Hunter

End:
- retained card: Pale River Spirit
- discarded cards: Deep River Spirit, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Shrine of the Red Baobab: 0/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, River Hunter, River Hunter

## Turn 15 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone-Cracker Cub [Relic:Fang Relic], Fang Relic, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Smith Who Passed the Fang
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Hunter’s Root-Stone
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: River Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 5 to River Hunter.
- Result: Bone-Cracker Cub left battle, River Hunter removed, Hunter’s Root-Stone at 7/10

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Hunter’s Root-Stone
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Leopard Hunter deals 4 to Blood-Scent Hyena. | Blood-Scent Hyena deals 4 to Leopard Hunter.
- Result: Blood-Scent Hyena left battle, Leopard Hunter removed, Hunter’s Root-Stone at 7/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Black-Tooth Smith
- discarded cards: Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider

## Turn 16 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: River Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 3/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Spear of First Dawn to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Black-Tooth Smith deals 2 to River Hunter. | River Hunter deals 4 to Black-Tooth Smith.
- Result: River Hunter left battle, Black-Tooth Smith removed

Main 2:
- Main 2: played Pale River Spirit
- Main 2: prepared Root-Woven Guard

End:
- retained card: Root-Woven Guard
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: Pale River Spirit, River Hunter

# End of Phase 4 Summary

Shrine state: Red [Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 1/2 | Iron 2/0
Awakened Ancestors: Red First Hunter | Iron Smith Who Passed the Fang
Forgotten cards: Red 3 | Iron 4
Key events: Black-Tooth Smith deals 2 to River Hunter. | River Hunter deals 4 to Black-Tooth Smith. | Main 1: played River Hunter | Main 1: attached Spear of First Dawn to River Hunter | Main 2: played Pale River Spirit | Main 2: prepared Root-Woven Guard
Tempo note: initiative reverses after every four player-turns.

## Turn 17 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 2

Hand before draw: [Root-Woven Guard]

Board before ready:
Beings/Spirits: Pale River Spirit, River Hunter
Prepared Tactic: Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
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
- Main 2: prepared Root-Woven Guard
- Main 2: played Baobab Guardian

End:
- retained card: Ritual of Red Moon
- discarded cards: Kuma Who Wounded the Sun
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 3 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Pale River Spirit

## Turn 18 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 0

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Bone-Cracker Cub, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Smith Who Passed the Fang
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub
- Main 1: attached Bone Spear to Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 2 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Baobab Guardian.
- Result: Bone-Cracker Cub left battle, Baobab Guardian survives

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: played Pack Harrier

End:
- retained card: Hyena Pack Call
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Fang Relic, Pack Harrier

## Turn 19 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 3

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Baobab Guardian [Wounded], Pale River Spirit
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 3 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Esprit du Léopard to Baobab Guardian

Combat:

Attack 1:
- Attacker: Pale River Spirit
- Target: Pack Harrier
- Defender/blocker: Pack Harrier
- Prepared triggers: None
- Wounded/Pierce calculations: Pale River Spirit becomes Wounded.
- Damage: Pack Harrier deals 1 to Pale River Spirit. | Pale River Spirit deals 2 to Pack Harrier.
- Result: Pale River Spirit survives, Pack Harrier removed

Main 2:
- Main 2: resolved Ritual of Red Moon (dealt 2 to Black-Tooth Smith)
- Main 2: played Baobab Guardian

End:
- retained card: Offering of Milk and Ash
- discarded cards: None
- forgotten cards: None
- Wounded clears: Baobab Guardian, Baobab Guardian
- resources at end: 0 Offerings / 2 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit [Wounded], Young Hunter

## Turn 20 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Black-Tooth Smith [Wounded], Bone Spear, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Smith Who Passed the Fang
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Iron Hyena Raider
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:

Attack 1:
- Attacker: Black-Tooth Smith
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 2 to 1. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 1 to Baobab Guardian.
- Result: Black-Tooth Smith left battle, Baobab Guardian survives

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Hyena Token, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Fang Relic, Hyena Token, Hyena Token, Iron Hyena Raider

# End of Phase 5 Summary

Shrine state: Red [Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/2 | Iron 4/0
Awakened Ancestors: Red First Hunter | Iron Smith Who Passed the Fang
Forgotten cards: Red 4 | Iron 4
Key events: Main 2: resolved Ritual of Red Moon (dealt 2 to Black-Tooth Smith) | Main 2: played Baobab Guardian | Baobab Guardian deals 4 to Black-Tooth Smith. | Black-Tooth Smith deals 1 to Baobab Guardian. | Main 1: played Iron Hyena Raider | Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)
Tempo note: initiative reverses after every four player-turns.

## Turn 21 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 0

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone Spear, Fang Relic, Hyena Token, Hyena Token, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Smith Who Passed the Fang
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 4 to 3. | Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Baobab Guardian.
- Result: Iron Hyena Raider left battle, Baobab Guardian survives

Attack 2:
- Attacker: Hyena Token
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 4 to 3.
- Damage: Baobab Guardian deals 3 to Hyena Token. | Hyena Token deals 1 to Baobab Guardian.
- Result: Hyena Token left battle, Baobab Guardian removed

Main 2:
- Main 2: played Iron Hyena Champion

End:
- retained card: Blood-Scent Hyena
- discarded cards: Bone-Cracker Cub
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Fang Relic, Hyena Token, Iron Hyena Champion, Pack Harrier, Pack Harrier

## Turn 22 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 4

Hand before draw: [Offering of Milk and Ash]

Board before ready:
Beings/Spirits: Baobab Guardian, Pale River Spirit [Wounded], Young Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
Forgotten zone count/list: 4 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Pale River Spirit
- Target: Hyena Token
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Pale River Spirit from 2 to 1. | Pale River Spirit becomes Wounded.
- Damage: Hyena Token deals 1 to Pale River Spirit. | Pale River Spirit deals 1 to Hyena Token.
- Result: Pale River Spirit survives, Hyena Token removed

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Offering of Milk and Ash, Pale River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 4 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Leopard Hunter, Pale River Spirit [Wounded], Young Hunter

## Turn 23 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone Spear, Fang Relic, Iron Hyena Champion, Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Smith Who Passed the Fang
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Pack Harrier. | Pack Harrier deals 1 to Leopard Hunter.
- Result: Pack Harrier left battle, Leopard Hunter survives

Attack 2:
- Attacker: Pack Harrier
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3. | Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 3 to Pack Harrier. | Pack Harrier deals 1 to Leopard Hunter.
- Result: Pack Harrier left battle, Leopard Hunter survives

Attack 3:
- Attacker: Iron Hyena Champion
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Iron Hyena Champion. | Iron Hyena Champion deals 5 to Leopard Hunter.
- Result: Iron Hyena Champion left battle, Leopard Hunter removed

Main 2:
- Main 2: played Iron Hyena Champion

End:
- retained card: Hyena Token
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Champion

## Turn 24 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 5

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian, Pale River Spirit [Wounded], Young Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
Forgotten zone count/list: 4 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: attached Esprit du Léopard to Baobab Guardian

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
- retained card: Ritual of Red Moon
- discarded cards: Hunter’s Call, Deep River Spirit, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: Pale River Spirit
- resources at end: 6 Offerings / 5 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit

# End of Phase 6 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 6/5 | Iron 0/0
Awakened Ancestors: Red First Hunter | Iron Smith Who Passed the Fang
Forgotten cards: Red 4 | Iron 4
Key events: Main 1: played Blood-Scent Hyena | Main 1: played Bone-Cracker Cub | Main 2: played Iron Hyena Champion | Blood-Scent Hyena deals 2 to Young Hunter. | Young Hunter deals 2 to Blood-Scent Hyena. | Main 1: attached Esprit du Léopard to Baobab Guardian
Tempo note: initiative reverses after every four player-turns.

## Turn 25 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 5

Hand before draw: [Ritual of Red Moon]

Board before ready:
Beings/Spirits: Baobab Guardian [Possession:Esprit du Léopard], Esprit du Léopard, Pale River Spirit
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
Forgotten zone count/list: 4 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: played River Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Baobab Guardian
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 5 to Baobab Guardian. | Baobab Guardian deals 4 to Iron Hyena Champion.
- Result: Baobab Guardian left battle, Iron Hyena Champion removed

Attack 2:
- Attacker: Pale River Spirit
- Target: Bone-Cracker Cub
- Defender/blocker: Bone-Cracker Cub
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Bone-Cracker Cub deals 2 to Pale River Spirit. | Pale River Spirit deals 2 to Bone-Cracker Cub.
- Result: Pale River Spirit left battle, Bone-Cracker Cub removed

Main 2:
- Main 2: resolved Ritual of Red Moon (had no legal target)

End:
- retained card: Spear of First Dawn
- discarded cards: River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 9 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: River Hunter, Young Hunter

## Turn 26 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 0

Hand before draw: [Hyena Token]

Board before ready:
Beings/Spirits: Bone Spear, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Smith Who Passed the Fang
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Blood-Scent Hyena

Combat:
- no attacks

Main 2:
- pass

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Token, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Fang Relic, Pack Harrier

## Turn 27 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 9

Hand before draw: [Spear of First Dawn]

Board before ready:
Beings/Spirits: River Hunter, Young Hunter
Prepared Tactic: Root-Woven Guard, Root-Woven Guard
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
Forgotten zone count/list: 5 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon]

Main 1:
- Main 1: evolved River Hunter into Leopard Hunter

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
- retained card: Kuma Who Wounded the Sun
- discarded cards: Spear of First Dawn, Baobab Guardian, River Hunter
- forgotten cards: None
- Wounded clears: None
- resources at end: 5 Offerings / 10 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter

## Turn 28 — Iron

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone Spear, Fang Relic, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Smith Who Passed the Fang
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Hunter’s Root-Stone
- Defender/blocker: Leopard Hunter
- Prepared triggers: Root-Woven Guard, Root-Woven Guard
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | Pack Harrier deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 4 to Pack Harrier. | Pack Harrier deals 2 to Leopard Hunter. | Shrine Hunter’s Root-Stone takes 1.
- Result: Pack Harrier left battle, Leopard Hunter survives, Hunter’s Root-Stone at 8/10

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Pack Call, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Fang Relic, Iron Hyena Raider

# End of Phase 7 Summary

Shrine state: Red [Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 1/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 5/10 | Iron 4/1
Awakened Ancestors: Red First Hunter | Iron Smith Who Passed the Fang
Forgotten cards: Red 5 | Iron 4
Key events: Main 1: evolved River Hunter into Leopard Hunter | Leopard Hunter deals 4 to Pack Harrier. | Pack Harrier deals 2 to Leopard Hunter. | Shrine Hunter’s Root-Stone takes 1. | Main 1: played Blood-Scent Hyena | Main 1: played Iron Hyena Raider
Tempo note: initiative reverses after every four player-turns.

## Turn 29 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Fang Relic, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Smith Who Passed the Fang
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: evolved Blood-Scent Hyena into Iron Hyena Champion (dealt 2 to Hunter’s Root-Stone)
- Main 1: played Blood-Scent Hyena

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Hunter’s Root-Stone
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Leopard Hunter deals 3 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Leopard Hunter.
- Result: Iron Hyena Raider left battle, Leopard Hunter removed, Hunter’s Root-Stone at 6/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Pack Harrier, Hyena Pack Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Fang Relic, Iron Hyena Champion

## Turn 30 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 10

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: 
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 4/10, Moonlit Roots: 0/10
Forgotten zone count/list: 7 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: played Pale River Spirit
- Main 1: played Deep River Spirit

Combat:
- no attacks

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Spear of First Dawn, Esprit du Léopard
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 7 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 2/10, Moonlit Roots: 0/10
- board at end: Deep River Spirit, Pale River Spirit

## Turn 31 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 1

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Fang Relic, Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: Smith Who Passed the Fang
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Champion

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 3.
- Result: Blood-Scent Hyena survives, Hunter’s Root-Stone at 5/10

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Hunter’s Root-Stone
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Hunter’s Root-Stone takes 7.
- Result: Iron Hyena Champion survives, Hunter’s Root-Stone at 0/10

Main 2:
- Main 2: played Black-Tooth Smith
- Main 2: played Bone-Cracker Cub
- Main 2: awakened Ancestor of the First Pack

End:
- retained card: Bone-Cracker Cub
- discarded cards: Iron Hyena Raider
- forgotten cards: None
- Wounded clears: Black-Tooth Smith
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Blood-Scent Hyena, Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic, Iron Hyena Champion [Relic:Fang Relic]

## Turn 32 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 7

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Deep River Spirit, Pale River Spirit
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 7 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter
- Main 1: played River Hunter

Combat:

Attack 1:
- Attacker: Deep River Spirit
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Iron Hyena Champion deals 6 to Deep River Spirit. | Deep River Spirit deals 3 to Iron Hyena Champion.
- Result: Deep River Spirit left battle, Iron Hyena Champion removed

Attack 2:
- Attacker: Pale River Spirit
- Target: Blood-Scent Hyena
- Defender/blocker: Blood-Scent Hyena
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Blood-Scent Hyena deals 2 to Pale River Spirit. | Pale River Spirit deals 2 to Blood-Scent Hyena.
- Result: Pale River Spirit left battle, Blood-Scent Hyena removed

Main 2:
- Main 2: played Leopard Hunter
- Main 2: awakened First Hunter

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 0 Offerings / 8 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter, River Hunter, Young Hunter

# End of Phase 8 Summary

Shrine state: Red [Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 0/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/8 | Iron 3/0
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 7 | Iron 4
Key events: Blood-Scent Hyena deals 2 to Pale River Spirit. | Pale River Spirit deals 2 to Blood-Scent Hyena. | Main 1: played Young Hunter | Main 1: played River Hunter | Main 2: played Leopard Hunter | Main 2: awakened First Hunter
Tempo note: initiative reverses after every four player-turns.

## Turn 33 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 8

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Leopard Hunter, River Hunter, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 7 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: played River Hunter
- Main 1: attached Spear of First Dawn to Young Hunter

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
- Attacker: River Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Black-Tooth Smith deals 2 to River Hunter. | River Hunter deals 3 to Black-Tooth Smith.
- Result: River Hunter left battle, Black-Tooth Smith removed

Main 2:
- Main 2: played Baobab Guardian

End:
- retained card: Kuma Who Wounded the Sun
- discarded cards: Hunter’s Call
- forgotten cards: None
- Wounded clears: Baobab Guardian
- resources at end: 1 Offerings / 10 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Leopard Hunter, River Hunter, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn]

## Turn 34 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Bone-Cracker Cub]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Bone Spear to Bone-Cracker Cub
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Leopard Hunter
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter survives

Main 2:
- Main 2: played Iron Hyena Champion

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 1 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 5/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Champion

## Turn 35 — Red

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 10

Hand before draw: [Kuma Who Wounded the Sun]

Board before ready:
Beings/Spirits: Baobab Guardian, Leopard Hunter [Wounded], River Hunter, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn]
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 7 [Hunter’s Call, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: evolved Leopard Hunter into Kuma Who Wounded the Sun (dealt 3 to Bone-Fang Shrine)

Combat:

Attack 1:
- Attacker: Young Hunter
- Target: Bone-Fang Shrine
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Bone-Fang Shrine takes 6.
- Result: Young Hunter survives, Bone-Fang Shrine at 0/10

Main 2:
- Main 2: attached Spear of First Dawn to Young Hunter

End:
- retained card: Pale River Spirit
- discarded cards: Young Hunter, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 8 Memory
- shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Kuma Who Wounded the Sun, River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn]

## Turn 36 — Iron

Pre-resource snapshot:
Offerings before resource: 1
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Champion
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Kuma Who Wounded the Sun
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Kuma Who Wounded the Sun becomes Wounded.
- Damage: Kuma Who Wounded the Sun deals 6 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Kuma Who Wounded the Sun.
- Result: Bone-Cracker Cub left battle, Kuma Who Wounded the Sun survives

Attack 2:
- Attacker: Iron Hyena Champion
- Target: Kuma Who Wounded the Sun
- Defender/blocker: Kuma Who Wounded the Sun
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Kuma Who Wounded the Sun from 6 to 4.
- Damage: Kuma Who Wounded the Sun deals 4 to Iron Hyena Champion. | Iron Hyena Champion deals 5 to Kuma Who Wounded the Sun.
- Result: Iron Hyena Champion left battle, Kuma Who Wounded the Sun removed

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic

# End of Phase 9 Summary

Shrine state: Red [Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10]
Resources: Red 2/8 | Iron 3/0
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 7 | Iron 4
Key events: Bone-Cracker Cub deals 2 to Kuma Who Wounded the Sun. | Kuma Who Wounded the Sun deals 4 to Iron Hyena Champion. | Iron Hyena Champion deals 5 to Kuma Who Wounded the Sun. | Main 1: played Bone-Cracker Cub | Main 1: played Bone-Cracker Cub | Main 2: played Black-Tooth Smith
Tempo note: initiative reverses after every four player-turns.

## Turn 37 — Iron

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Black-Tooth Smith, Bone Spear, Bone-Cracker Cub, Bone-Cracker Cub, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Pack Harrier

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
- Attacker: Bone-Cracker Cub
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1.
- Damage: Baobab Guardian deals 1 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Baobab Guardian.
- Result: Bone-Cracker Cub left battle, Baobab Guardian removed

Main 2:
- pass

End:
- retained card: Hyena Pack Call
- discarded cards: Hyena Token, Iron Hyena Raider
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 0 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith [Wounded], Bone Spear, Bone-Cracker Cub, Fang Relic, Pack Harrier, Pack Harrier

## Turn 38 — Red

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 9

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: River Hunter, Spear of First Dawn, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn]
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 2/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 8 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Black-Tooth Smith
- Defender/blocker: Black-Tooth Smith
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Black-Tooth Smith from 2 to 1. | River Hunter becomes Wounded.
- Damage: Black-Tooth Smith deals 1 to River Hunter. | River Hunter deals 3 to Black-Tooth Smith.
- Result: River Hunter survives, Black-Tooth Smith removed

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Pale River Spirit, Esprit du Léopard, Young Hunter
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 5 Offerings / 10 Memory
- shrine state: Shrine of the Red Baobab: 1/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Leopard Hunter [Relic:Spear of First Dawn], River Hunter [Wounded], Spear of First Dawn, Spear of First Dawn

## Turn 39 — Iron

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 0

Hand before draw: [Hyena Pack Call]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Fang Relic, Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)
- Main 1: resolved Hyena Pack Call (summoned 2 Hyena Tokens)

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | Pack Harrier deals 1 to blocked Shrine. | Ancestor of the First Pack deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 5 to Pack Harrier. | Pack Harrier deals 1 to Leopard Hunter. | Shrine Shrine of the Red Baobab takes 2.
- Result: Pack Harrier left battle, Leopard Hunter survives, Shrine of the Red Baobab at 7/10

Attack 2:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 5 to 3. | Leopard Hunter becomes Wounded. | Pack Harrier deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 3 to Pack Harrier. | Pack Harrier deals 1 to Leopard Hunter. | Shrine Shrine of the Red Baobab takes 1.
- Result: Pack Harrier left battle, Leopard Hunter survives, Shrine of the Red Baobab at 6/10

Attack 3:
- Attacker: Bone-Cracker Cub
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 5 to 3.
- Damage: Leopard Hunter deals 3 to Bone-Cracker Cub. | Bone-Cracker Cub deals 3 to Leopard Hunter.
- Result: Bone-Cracker Cub left battle, Leopard Hunter removed, Shrine of the Red Baobab at 6/10

Main 2:
- pass

End:
- retained card: Iron Hyena Champion
- discarded cards: Hyena Token, Iron Hyena Champion
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Fang Relic, Hyena Token, Hyena Token

## Turn 40 — Red

Pre-resource snapshot:
Offerings before resource: 5
Memory before resource: 11

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: River Hunter [Wounded], Spear of First Dawn
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 8 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: played River Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Hyena Token
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces River Hunter from 3 to 2. | River Hunter becomes Wounded.
- Damage: Hyena Token deals 1 to River Hunter. | River Hunter deals 2 to Hyena Token.
- Result: River Hunter survives, Hyena Token removed

Main 2:
- Main 2: attached Esprit du Léopard to River Hunter
- Main 2: played Baobab Guardian

End:
- retained card: Esprit du Léopard
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 11 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Esprit du Léopard, River Hunter, River Hunter [Wounded, Possession:Esprit du Léopard], Spear of First Dawn, Young Hunter

# End of Phase 10 Summary

Shrine state: Red [Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10]
Resources: Red 0/11 | Iron 4/1
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 8 | Iron 4
Key events: Hyena Token deals 1 to River Hunter. | River Hunter deals 2 to Hyena Token. | Main 1: played River Hunter | Main 1: played Young Hunter | Main 2: attached Esprit du Léopard to River Hunter | Main 2: played Baobab Guardian
Tempo note: initiative reverses after every four player-turns.

## Turn 41 — Red

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 11

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Baobab Guardian, Esprit du Léopard, River Hunter, River Hunter [Wounded, Possession:Esprit du Léopard], Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 8 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: attached Esprit du Léopard to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Hyena Token
- Defender/blocker: Hyena Token
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces River Hunter from 5 to 3. | River Hunter becomes Wounded.
- Damage: Hyena Token deals 1 to River Hunter. | River Hunter deals 3 to Hyena Token.
- Result: River Hunter survives, Hyena Token removed

Main 2:
- pass

End:
- retained card: Pale River Spirit
- discarded cards: Deep River Spirit, Baobab Guardian, Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 12 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Esprit du Léopard, River Hunter, River Hunter [Wounded, Possession:Esprit du Léopard], Spear of First Dawn, Young Hunter

## Turn 42 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 1

Hand before draw: [Iron Hyena Champion]

Board before ready:
Beings/Spirits: Bone Spear, Fang Relic
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Bone-Cracker Cub
- Main 1: played Iron Hyena Raider

Combat:
- no attacks

Main 2:
- Main 2: played Iron Hyena Champion

End:
- retained card: Fang Relic
- discarded cards: Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: None
- resources at end: 0 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Champion, Iron Hyena Raider

## Turn 43 — Red

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 12

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Baobab Guardian, Esprit du Léopard, River Hunter, River Hunter [Wounded, Possession:Esprit du Léopard], Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
Forgotten zone count/list: 8 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: played Young Hunter
- Main 1: attached Spear of First Dawn to River Hunter

Combat:

Attack 1:
- Attacker: River Hunter
- Target: Iron Hyena Champion
- Defender/blocker: Iron Hyena Champion
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces River Hunter from 6 to 4.
- Damage: Iron Hyena Champion deals 5 to River Hunter. | River Hunter deals 4 to Iron Hyena Champion.
- Result: River Hunter left battle, Iron Hyena Champion removed

Main 2:
- Main 2: played Pale River Spirit

End:
- retained card: Pale River Spirit
- discarded cards: Hunter’s Call
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 15 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10
- board at end: Baobab Guardian, Pale River Spirit, River Hunter, Spear of First Dawn, Young Hunter, Young Hunter [Relic:Spear of First Dawn]

## Turn 44 — Iron

Pre-resource snapshot:
Offerings before resource: 0
Memory before resource: 1

Hand before draw: [Fang Relic]

Board before ready:
Beings/Spirits: Bone Spear, Bone-Cracker Cub, Fang Relic, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: attached Fang Relic to Iron Hyena Raider
- Main 1: attached Bone Spear to Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Bone-Cracker Cub
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Baobab Guardian becomes Wounded.
- Damage: Baobab Guardian deals 2 to Bone-Cracker Cub. | Bone-Cracker Cub deals 2 to Baobab Guardian.
- Result: Bone-Cracker Cub left battle, Baobab Guardian survives

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Baobab Guardian
- Defender/blocker: Baobab Guardian
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Baobab Guardian from 2 to 1. | Iron Hyena Raider becomes Wounded.
- Damage: Baobab Guardian deals 1 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Baobab Guardian.
- Result: Iron Hyena Raider survives, Baobab Guardian removed

Main 2:
- Main 2: played Blood-Scent Hyena
- Main 2: played Pack Harrier

End:
- retained card: Hyena Token
- discarded cards: None
- forgotten cards: None
- Wounded clears: None
- resources at end: 2 Offerings / 1 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Bone Spear, Fang Relic, Fang Relic, Iron Hyena Raider [Wounded, Relic:Bone Spear], Pack Harrier

# End of Phase 11 Summary

Shrine state: Red [Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 0/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10]
Resources: Red 3/15 | Iron 2/1
Awakened Ancestors: Red First Hunter | Iron Ancestor of the First Pack
Forgotten cards: Red 8 | Iron 4
Key events: Baobab Guardian deals 1 to Iron Hyena Raider. | Iron Hyena Raider deals 4 to Baobab Guardian. | Main 1: attached Fang Relic to Iron Hyena Raider | Main 1: attached Bone Spear to Iron Hyena Raider | Main 2: played Blood-Scent Hyena | Main 2: played Pack Harrier
Tempo note: initiative reverses after every four player-turns.

## Turn 45 — Iron

Pre-resource snapshot:
Offerings before resource: 2
Memory before resource: 1

Hand before draw: [Hyena Token]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Bone Spear, Fang Relic, Fang Relic, Iron Hyena Raider [Wounded, Relic:Bone Spear], Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Bone-Cracker Cub

Combat:

Attack 1:
- Attacker: Iron Hyena Raider
- Target: Shrine of the Red Baobab
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Iron Hyena Raider from 4 to 3. | Ancestor of the First Pack deals 1 to blocked Shrine.
- Damage: Young Hunter deals 2 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Young Hunter. | Shrine Shrine of the Red Baobab takes 1.
- Result: Iron Hyena Raider left battle, Young Hunter removed, Shrine of the Red Baobab at 6/10

Attack 2:
- Attacker: Blood-Scent Hyena
- Target: Shrine of the Red Baobab
- Defender/blocker: River Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: River Hunter deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to River Hunter.
- Result: Blood-Scent Hyena left battle, River Hunter removed, Shrine of the Red Baobab at 6/10

Attack 3:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Shrine of the Red Baobab takes 1.
- Result: Pack Harrier survives, Shrine of the Red Baobab at 5/10

Main 2:
- pass

End:
- retained card: Blood-Scent Hyena
- discarded cards: Hyena Token, Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 6 Offerings / 2 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Bone Spear, Bone-Cracker Cub, Fang Relic, Fang Relic, Pack Harrier, Pack Harrier

## Turn 46 — Red

Pre-resource snapshot:
Offerings before resource: 3
Memory before resource: 15

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Pale River Spirit, Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn]
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 5/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
Forgotten zone count/list: 8 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter
- Main 1: played Young Hunter

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
- retained card: Pale River Spirit
- discarded cards: River Hunter, Offering of Milk and Ash
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 4 Offerings / 17 Memory
- shrine state: Shrine of the Red Baobab: 5/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
- board at end: Leopard Hunter [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter

## Turn 47 — Iron

Pre-resource snapshot:
Offerings before resource: 6
Memory before resource: 2

Hand before draw: [Blood-Scent Hyena]

Board before ready:
Beings/Spirits: Bone Spear, Fang Relic, Fang Relic, Pack Harrier, Pack Harrier
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Blood-Scent Hyena
- Main 1: played Iron Hyena Raider

Combat:

Attack 1:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded. | Pack Harrier deals 1 to blocked Shrine. | Ancestor of the First Pack deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 5 to Pack Harrier. | Pack Harrier deals 1 to Leopard Hunter. | Shrine Shrine of the Red Baobab takes 2.
- Result: Pack Harrier left battle, Leopard Hunter survives, Shrine of the Red Baobab at 3/10

Attack 2:
- Attacker: Pack Harrier
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 5 to 3. | Leopard Hunter becomes Wounded. | Pack Harrier deals 1 to blocked Shrine.
- Damage: Leopard Hunter deals 3 to Pack Harrier. | Pack Harrier deals 1 to Leopard Hunter. | Shrine Shrine of the Red Baobab takes 1.
- Result: Pack Harrier left battle, Leopard Hunter survives, Shrine of the Red Baobab at 2/10

Main 2:
- pass

End:
- retained card: Black-Tooth Smith
- discarded cards: Hyena Pack Call, Blood-Scent Hyena
- forgotten cards: None
- Wounded clears: Iron Hyena Raider
- resources at end: 4 Offerings / 3 Memory
- shrine state: Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Blood-Scent Hyena, Bone Spear, Fang Relic, Fang Relic, Iron Hyena Raider

## Turn 48 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 17

Hand before draw: [Pale River Spirit]

Board before ready:
Beings/Spirits: Leopard Hunter [Wounded, Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: First Hunter
Shrine state: Shrine of the Red Baobab: 8/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
Forgotten zone count/list: 8 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: evolved Young Hunter into Leopard Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 8 to 6.
- Damage: Shrine Iron Hyena Den takes 6.
- Result: Leopard Hunter survives, Iron Hyena Den at 4/10

Main 2:
- Main 2: awakened Grandmother Beneath the Roots

End:
- retained card: Offering of Milk and Ash
- discarded cards: Pale River Spirit, Pale River Spirit
- forgotten cards: None
- Wounded clears: Leopard Hunter, Leopard Hunter
- resources at end: 4 Offerings / 15 Memory
- shrine state: Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
- board at end: Leopard Hunter, Leopard Hunter [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn]

# End of Phase 12 Summary

Shrine state: Red [Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10] | Iron [Iron Hyena Den: 0/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10]
Resources: Red 4/15 | Iron 4/3
Awakened Ancestors: Red Grandmother Beneath the Roots | Iron Ancestor of the First Pack
Forgotten cards: Red 8 | Iron 4
Key events: Main 1: played Blood-Scent Hyena | Main 1: played Iron Hyena Raider | Shrine Iron Hyena Den takes 6. | Main 1: evolved Young Hunter into Leopard Hunter | Main 1: played Young Hunter | Main 2: awakened Grandmother Beneath the Roots
Tempo note: initiative reverses after every four player-turns.

## Turn 49 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 15

Hand before draw: [Offering of Milk and Ash]

Board before ready:
Beings/Spirits: Leopard Hunter, Leopard Hunter [Relic:Spear of First Dawn], Spear of First Dawn, Young Hunter [Relic:Spear of First Dawn]
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 7/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
Forgotten zone count/list: 8 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: played River Hunter
- Main 1: played Young Hunter

Combat:

Attack 1:
- Attacker: Leopard Hunter
- Target: Iron Hyena Den
- Defender/blocker: No blocker
- Prepared triggers: None
- Wounded/Pierce calculations: None
- Damage: Shrine Iron Hyena Den takes 7.
- Result: Leopard Hunter survives, Iron Hyena Den at 0/10

Main 2:
- Main 2: resolved Offering of Milk and Ash (restored 3 to Shrine of the Red Baobab)

End:
- retained card: Esprit du Léopard
- discarded cards: Deep River Spirit
- forgotten cards: None
- Wounded clears: None
- resources at end: 4 Offerings / 14 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 1/10
- board at end: Leopard Hunter, Leopard Hunter [Relic:Spear of First Dawn], River Hunter, Spear of First Dawn, Young Hunter, Young Hunter [Relic:Spear of First Dawn]

## Turn 50 — Iron

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 3

Hand before draw: [Black-Tooth Smith]

Board before ready:
Beings/Spirits: Blood-Scent Hyena, Bone Spear, Fang Relic, Fang Relic, Iron Hyena Raider
Prepared Tactic: None
Awakened Ancestor: Ancestor of the First Pack
Shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
Forgotten zone count/list: 4 [Bite the Roots, Bite the Roots, Pack Ambush, Pack Ambush]

Main 1:
- Main 1: played Pack Harrier
- Main 1: played Pack Harrier

Combat:

Attack 1:
- Attacker: Blood-Scent Hyena
- Target: Shrine of the Red Baobab
- Defender/blocker: Young Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Ancestor of the First Pack deals 1 to blocked Shrine.
- Damage: Young Hunter deals 3 to Blood-Scent Hyena. | Blood-Scent Hyena deals 2 to Young Hunter. | Shrine Shrine of the Red Baobab takes 1.
- Result: Blood-Scent Hyena left battle, Young Hunter removed, Shrine of the Red Baobab at 6/10

Attack 2:
- Attacker: Iron Hyena Raider
- Target: Shrine of the Red Baobab
- Defender/blocker: Leopard Hunter
- Prepared triggers: None
- Wounded/Pierce calculations: Leopard Hunter becomes Wounded.
- Damage: Leopard Hunter deals 4 to Iron Hyena Raider. | Iron Hyena Raider deals 3 to Leopard Hunter.
- Result: Iron Hyena Raider left battle, Leopard Hunter survives, Shrine of the Red Baobab at 6/10

Main 2:
- Main 2: played Black-Tooth Smith

End:
- retained card: Iron Hyena Champion
- discarded cards: Hyena Token
- forgotten cards: None
- Wounded clears: None
- resources at end: 3 Offerings / 3 Memory
- shrine state: Iron Hyena Den: 13/10, Bone-Fang Shrine: 14/10, Rusted Moon Shrine: 0/10
- board at end: Black-Tooth Smith, Bone Spear, Fang Relic, Fang Relic, Pack Harrier, Pack Harrier

## Turn 51 — Red

Pre-resource snapshot:
Offerings before resource: 4
Memory before resource: 15

Hand before draw: [Esprit du Léopard]

Board before ready:
Beings/Spirits: Leopard Hunter [Relic:Spear of First Dawn], Leopard Hunter [Wounded], River Hunter, Spear of First Dawn, Young Hunter
Prepared Tactic: None
Awakened Ancestor: Grandmother Beneath the Roots
Shrine state: Shrine of the Red Baobab: 4/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 2/10
Forgotten zone count/list: 9 [Hunter’s Call, Kuma Who Wounded the Sun, Offering of Milk and Ash, Offering of Milk and Ash, Ritual of Red Moon, Ritual of Red Moon, Ritual of Red Moon, Root-Woven Guard, Root-Woven Guard]

Main 1:
- Main 1: played River Hunter

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
- Wounded/Pierce calculations: Wounded reduces Leopard Hunter from 4 to 3.
- Damage: Shrine Rusted Moon Shrine takes 3.
- Result: Leopard Hunter survives, Rusted Moon Shrine at 0/10

Main 2:
- pass

End:
- retained card: Esprit du Léopard
- discarded cards: Esprit du Léopard, Deep River Spirit, River Hunter
- forgotten cards: None
- Wounded clears: Leopard Hunter
- resources at end: 6 Offerings / 15 Memory
- shrine state: Shrine of the Red Baobab: 3/10, Hunter’s Root-Stone: 12/10, Moonlit Roots: 2/10
- board at end: Leopard Hunter, Leopard Hunter [Relic:Spear of First Dawn], River Hunter, River Hunter, Spear of First Dawn, Young Hunter

## End-of-game summary

Winner: red-hunter-evolution
End reason: ShrineBreak
Outcome: RedWin

Final Shrine state: Red [Shrine of the Red Baobab 3/10, Hunter’s Root-Stone 12/10, Moonlit Roots 2/10] | Iron [Iron Hyena Den 13/10, Bone-Fang Shrine 14/10, Rusted Moon Shrine 10/10]
Final resources: Red 6/15 | Iron 3/3
Final Presence: Seat 1 5/5 | Seat 2 3/5

Turn count: 51
Phase count: 13

First Shrine damage: 5 (Seat 1/Red: 5, Seat 2/Iron: 33)
First Shrine broken: 31 (Seat 1/Red: 31, Seat 2/Iron: 35)
Wins in odd phase: 1
Winner was first player in final phase: 1
Shrine damage dealt during double-turn: Red 18, Iron 24
First Ancestor awakened: 6
First L2: 14
First L3: 35

Red L2 entries: 7 (hard-cast 2, evolved 5)
Red L3 entries: 1 (hard-cast 0, evolved 1)
Iron L2 entries: 5 (hard-cast 4, evolved 1)
Iron L3 entries: 0 (hard-cast 0, evolved 0)

Legal evolve actions generated: Red 16, Iron 2
Legal L2 evolve actions: Red 14, Iron 2
Legal L3 evolve actions: Red 2, Iron 0
Evolve windows: Red 12, Iron 2
Turns with legal L2 evolution: Red 10, Iron 2
Turns with legal L3 evolution: Red 2, Iron 0
Evolve actions chosen: Red 16, Iron 2
Hard-cast chosen while legal evolve action existed: Red 1, Iron 0
Hard-cast chosen while evolution base existed: Red 6, Iron 8

Legal awaken actions generated: Red 61, Iron 6
Awaken actions chosen: Red 20, Iron 5
Awaken actions skipped while legal: Red 0, Iron 0
First awakened ancestor: Red red.ancestor.firsthunter, Iron iron.ancestor.smithpassedfang
Ancestor switches: Red 5, Iron 1
Turns with awakened ancestor: Red 23, Iron 21
Memory spent on ancestors: Red 12, Iron 4
Ancestor realized value: First Hunter +3 damage, Grandmother healed 7, Child draw/discard 0, Iron Hyena +0 damage, Smith saved 4 Offerings, Tooth-Mother +0 damage

Prepared Tactics triggered: Red 3, Iron 0
Prepared Tactics expired: Red 0, Iron 0
Fade cards Forgotten: Red 9, Iron 4
Wounded events: Red 24, Iron 6
Wounded reduced damage: Red 21, Iron 6
Pierce overflow events: Red 0, Iron 0
WeaponMaster Pierce events: 0
SoulSlayer Pierce events: 0
Legal block options: Red 16, Iron 0
Blocks chosen: Red 13, Iron 0
Blocks declined: Red 0, Iron 0
Assault slots spent: Seat 1 standard 27, pack 0 | Seat 2 standard 4, pack 32
Pack diagnostics: Seat 1 ready-at-combat 0, generated 0, available 0, skipped 0, turns-with-bonus 0, max-attacks 52, prevented-by-limit 0
Pack diagnostics: Seat 2 ready-at-combat 34, generated 34, available 34, skipped 2, turns-with-bonus 19, max-attacks 84, prevented-by-limit 0
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
