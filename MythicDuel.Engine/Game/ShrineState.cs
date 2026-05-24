using MythicDuel.Engine.Ids;
namespace MythicDuel.Engine.Game;

public sealed class ShrineState
{
    public string DefinitionId { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public PlayerId Owner { get; init; }
    public int Damage { get; set; }
    public int Vitality { get; init; } = 10;
    public bool IsBroken => Damage >= Vitality;
}
