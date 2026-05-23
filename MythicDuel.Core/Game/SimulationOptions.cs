namespace MythicDuel.Core.Game;

public sealed class SimulationOptions
{
    public int Seed { get; init; } = 123;
    public int Games { get; init; } = 1;
    public string BotRed { get; init; } = "red";
    public string BotIron { get; init; } = "iron";
    public string DeckRed { get; init; } = "red";
    public string DeckIron { get; init; } = "iron";
    public string Rules { get; init; } = string.Empty;
}
