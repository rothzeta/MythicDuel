using MythicDuel.Engine.Commands;
using MythicDuel.Engine.Pipeline;
namespace MythicDuel.Engine.Game;
public sealed class GameEngine
{
    private readonly ResolutionPipeline _pipeline = new();

    public CommandResult Execute(GameState state, IGameCommand command)
    {
        var context = new ResolutionContext(state, command);
        return _pipeline.Resolve(context);
    }
}
