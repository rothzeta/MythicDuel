# Mythic Duel — Report Format v0

The detailed markdown report should allow a designer to reconstruct the game state and understand why the game ended.

## Header

```text
Test Game #[id]

Deck A:
Deck B:

Rules variant:
- Draw model:
- Phase model:
- Combat model:
- Prepared model:
- Special mechanics:

Seed:
Winner:
Main question:
```

## Starting setup

List:
- Starting Shrines — Red
- Starting Shrines — Iron
- Starting hands
- Starting resources before the first turn resource step
- Starting battlefield
- Starting Lineage

## Turn format

Each turn should include:

```text
## Turn X — Player

Pre-resource snapshot:
Offerings before resource:
Memory before resource:

Hand before draw:
[...]

Board before ready:
Beings/Spirits:
Prepared Tactic:
Awakened Ancestor:
Shrine state:
Forgotten zone count/list:

Main 1:
- action

Combat:

Attack 1:
- Attacker:
- Target:
- Defender/blocker:
- Prepared triggers:
- Wounded/Pierce calculations:
- Damage:
- Result:

Attack 2:
- Attacker:
- Target:
- Defender/blocker:
- Prepared triggers:
- Wounded/Pierce calculations:
- Damage:
- Result:

Main 2:
- action
- evolution, if any
- ancestor awakening, if any

End:
- retained card:
- discarded cards:
- forgotten cards:
- Wounded clears:
- resources at end:
- shrine state:
- board at end:
```

## End-of-phase summary

After every 4 player-turns:

Use the latest completed turn snapshot for each player in that phase, not the final game state.

```text
# End of Phase N Summary

Shrine state:
Resources:
Awakened Ancestors:
Forgotten cards:
Key events:
Tempo note:
```

## End-of-game summary

```text
Winner:

Final Shrine state:

Final resources:

Turn count:
Phase count:

First Shrine damage:
First Shrine break:
First Ancestor awakened:
First L2:
First L3:

Prepared Tactics triggered:
Prepared Tactics expired:
Fade cards Forgotten:
Wounded events:
Wounded reduced damage:
Pierce overflow events:
WeaponMaster Pierce events:
SoulSlayer Pierce events:
Deck reshuffles:

Analysis:
- What felt good
- What felt bad / slow
- Combat findings
- Shrine pressure findings
- Memory findings
- Evolution findings
- Phase / initiative findings
- Card balance notes
- Rule changes to test next
```
