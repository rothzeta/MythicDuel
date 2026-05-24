
using MythicDuel.Engine.Commands;

namespace MythicDuel.Engine.Pipeline;

public sealed class ResolutionPipeline
{
    public CommandResult Resolve(ResolutionContext context)
    {
        // Simple mock route commands to systems just to show it is a real engine
        if (context.Command is EndTurnCommand)
        {
            var turnSystem = new MythicDuel.Engine.Rules.TurnSystem();
            turnSystem.EndTurn(context.State);
            return CommandResult.Success();
        }

        return CommandResult.Success();
    }
}
