using MythicDuel.Engine.Ids;
namespace MythicDuel.Engine.LegalActions;

public sealed record PlayCardAction(PlayerId PlayerId, CardInstanceId CardId, string Explanation) : LegalAction(PlayerId, Explanation);
