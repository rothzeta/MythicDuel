using MythicDuel.Engine.Ids;
namespace MythicDuel.Engine.Game;
public sealed class CardInstance
{
    public CardInstanceId Id { get; set; }
    public CardDefinitionId DefinitionId { get; set; }

    public int BaseAttack { get; set; }
    public int BaseVitality { get; set; }
    public int Damage { get; set; }
    public bool IsWounded { get; set; }
    public PlayerId Controller { get; set; }
    public Zone Zone { get; set; }
    public bool IsExhausted { get; set; }
    public int? HostId { get; set; }

    // Adding CardType because we check it in CombatSystem logic
    public CardType CardType { get; set; }
}
