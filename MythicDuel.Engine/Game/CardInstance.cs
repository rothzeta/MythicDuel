using MythicDuel.Engine.Ids;
namespace MythicDuel.Engine.Game;
public sealed class CardInstance
{
    public CardInstanceId Id { get; set; }
    public CardDefinitionId DefinitionId { get; set; }
}
