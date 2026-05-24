using System.Linq;
using MythicDuel.Engine.Commands;
using MythicDuel.Engine.Game;
using MythicDuel.Engine.Ids;

namespace MythicDuel.Engine.Rules;

public sealed class CombatSystem
{
    private readonly DamageSystem _damageSystem = new();

    public void ResolveAttack(GameState state, DeclareAttackCommand cmd)
    {
        if (!state.Cards.TryGetValue(cmd.AttackerId, out var attacker))
        {
            return;
        }

        var opponentState = cmd.PlayerId == PlayerId.Seat1 ? state.Player2 : state.Player1;

        var targetShrine = opponentState.Shrines.FirstOrDefault(s => s.Name == cmd.TargetName);
        if (targetShrine != null)
        {
            _damageSystem.ApplyShrineDamage(state, cmd.PlayerId, targetShrine, attacker.BaseAttack);
            return;
        }

        // Handle Unit targeting logic if needed in future iterations...
    }
}
