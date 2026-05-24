using MythicDuel.Engine.Commands;
namespace MythicDuel.Engine.Pipeline;
public sealed class ResolutionPipeline
{
    public CommandResult Resolve(ResolutionContext context)
    {
        if (context.Command is EndTurnCommand)
        {
            var turn = new MythicDuel.Engine.Rules.TurnSystem();
            turn.EndTurn(context.State);
        }
        else if (context.Command is DeclareAttackCommand attackCmd)
        {
            var combat = new MythicDuel.Engine.Rules.CombatSystem();
            combat.ResolveAttack(context.State, attackCmd);
        }

        return CommandResult.Success();
    }
}
