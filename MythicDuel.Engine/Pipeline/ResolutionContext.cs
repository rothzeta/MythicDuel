using MythicDuel.Engine.Game;
using MythicDuel.Engine.Commands;
namespace MythicDuel.Engine.Pipeline;
public sealed class ResolutionContext
{
    public GameState State { get; }
    public IGameCommand Command { get; }
    public ResolutionContext(GameState state, IGameCommand command)
    {
        State = state;
        Command = command;
    }
}
