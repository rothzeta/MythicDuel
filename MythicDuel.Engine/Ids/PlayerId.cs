namespace MythicDuel.Engine.Ids;
public readonly record struct PlayerId(string Value)
{
    public static readonly PlayerId Seat1 = new("Seat1");
    public static readonly PlayerId Seat2 = new("Seat2");
}
