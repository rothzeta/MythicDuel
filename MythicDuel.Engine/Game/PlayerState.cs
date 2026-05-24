using MythicDuel.Engine.Ids;
using System.Collections.Generic;
namespace MythicDuel.Engine.Game;
public sealed class PlayerState
{
    public PlayerId Id { get; set; }
    public List<CardInstanceId> Deck { get; set; } = new();
    public List<CardInstanceId> Hand { get; set; } = new();
    public List<CardInstanceId> Discard { get; set; } = new();
}
