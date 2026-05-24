using System.Collections.Generic;
using MythicDuel.Engine.Ids;
namespace MythicDuel.Engine.Game;
public sealed class GameState
{
    public PlayerState Player1 { get; set; } = new();
    public PlayerState Player2 { get; set; } = new();
    public Dictionary<CardInstanceId, CardInstance> Cards { get; set; } = new();
}
