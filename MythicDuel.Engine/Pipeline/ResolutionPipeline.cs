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
        return CommandResult.Success();
    }
}
