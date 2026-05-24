using MythicDuel.Engine.Ids;
namespace MythicDuel.Engine.Commands;
public sealed record DeclareAttackCommand(PlayerId PlayerId, CardInstanceId AttackerId, CardInstanceId TargetId) : IGameCommand;
