using MythicDuel.Engine.Game;
using MythicDuel.Engine.Ids;

namespace MythicDuel.Engine.Rules;

public sealed class DamageSystem
{
    public void ApplyDamage(GameState state) {}

    public void ApplyUnitDamage(GameState state, CardInstance target, int damage)
    {
        if (damage <= 0 || target.Zone != Zone.Battlefield)
        {
            return;
        }

        target.Damage += damage;

        // Target becomes Wounded if they took damage but didn't die.
        // Note: For now we'll just check if their current damage is less than their vitality,
        // as per the reference engine's logic.
        if (target.Damage < target.BaseVitality)
        {
            target.IsWounded = true;
        }
    }

    public void ApplyShrineDamage(GameState state, PlayerId attackingPlayer, ShrineState shrine, int damage)
    {
        if (damage <= 0 || shrine.IsBroken)
        {
            return;
        }

        shrine.Damage += damage;
    }
}
