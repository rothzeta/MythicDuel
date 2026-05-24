using MythicDuel.Engine.Ids;
namespace MythicDuel.Engine.Commands;
public sealed record PlayCardCommand(PlayerId PlayerId, CardInstanceId CardId) : IGameCommand;
