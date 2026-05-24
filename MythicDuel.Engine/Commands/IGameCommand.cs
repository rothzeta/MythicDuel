using MythicDuel.Engine.Ids;
namespace MythicDuel.Engine.Commands;
public interface IGameCommand
{
    PlayerId PlayerId { get; }
}
