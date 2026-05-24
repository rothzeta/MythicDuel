using System.Linq;
using MythicDuel.Engine.Game;
namespace MythicDuel.Engine.Rules;
public sealed class DrawSystem
{
    public void DrawForTurn(GameState state)
    {
        var player = state.Player1.Id == state.ActivePlayer ? state.Player1 : state.Player2;
        while (player.Hand.Count < 5)
        {
            if (player.Deck.Count == 0) ReshuffleDiscardIntoDeck(player);
            if (player.Deck.Count == 0) break;
            var cardId = player.Deck[0];
            player.Deck.RemoveAt(0);
            player.Hand.Add(cardId);
        }
    }
    private void ReshuffleDiscardIntoDeck(PlayerState player)
    {
        if (player.Discard.Count == 0) return;
        var returning = player.Discard.ToList();
        player.Deck.AddRange(returning);
        player.Discard.Clear();
    }
}
