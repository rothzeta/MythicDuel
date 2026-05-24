using MythicDuel.Engine.Ids;
namespace MythicDuel.Engine.Commands;
public sealed record EndTurnCommand(PlayerId PlayerId) : IGameCommand;
