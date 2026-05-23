# Mythic Duel — Bot Heuristics v0

Bots do not need to be smart in v0. They must be legal, deterministic under seed, and useful enough to expose rule failures.

## RandomLegalBot

- Chooses random legal actions.
- Used for smoke tests.

## RedBaobabBot

Priorities:
1. Generate Memory.
2. Play early Hunters and Spirits.
3. Use Possession on Hunters when it can win combat or push Shrine damage.
4. Awaken First Hunter when possible.
5. Hard-play Leopard Hunter if evolution is stalled.
6. Evolve into Leopard Hunter if legal.
7. Attach Relic/Possession to Leopard Hunter to activate WeaponMaster/SoulSlayer.
8. Evolve into Kuma if legal and useful.
9. Prepare Root-Woven Guard when Shrines are threatened.
10. Attack Shrines when it enables L3 or can break a Shrine.
11. Otherwise control board.

Retain priority:
1. Kuma if Leopard Hunter is in play or likely soon.
2. Leopard Hunter if Hunters are in play.
3. Root-Woven Guard if Shrines threatened.
4. Esprit du Léopard / Spear if Hunter or Leopard Hunter present.

## IronHyenaBot

Priorities:
1. Attack Shrines aggressively.
2. Prefer damaged Shrines.
3. Prefer breaking Hunter’s Root-Stone or Shrine of the Red Baobab.
4. Use Bite the Roots on damaged/important Shrines.
5. Prepare Iron Snare if Red has a big attacker or Possessed unit.
6. Prepare False Opening if Red is close to evolving.
7. Use Bone Spear / Pierce to force damage through blockers.
8. Block to prevent Leopard Hunter from damaging Shrines.
9. Awaken Ancestor of the Iron Hyena when possible.

Retain priority:
1. Bite the Roots.
2. Iron Snare if Red has a threat.
3. False Opening if Red near evolution.
4. Bone Spear if Shrine is damaged.
5. Iron Hyena Champion if Hyena can damage Shrine.
