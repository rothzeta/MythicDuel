using MythicDuel.Engine.Ids;
namespace MythicDuel.Engine.LegalActions;

public sealed record AttackAction(PlayerId PlayerId, CardInstanceId AttackerId, CardInstanceId TargetId, string Explanation) : LegalAction(PlayerId, Explanation);
