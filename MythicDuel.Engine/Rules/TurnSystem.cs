using System.Linq;
using MythicDuel.Engine.Game;
namespace MythicDuel.Engine.Rules;
public sealed class TurnSystem
{
    public void EndTurn(GameState state)
    {
        var player = state.Player1.Id == state.ActivePlayer ? state.Player1 : state.Player2;
        var opponent = state.Player1.Id == state.ActivePlayer ? state.Player2 : state.Player1;

        if (player.Hand.Count > 0)
        {
            var retainCard = player.Hand.FirstOrDefault();
            var discards = player.Hand.Where(id => id != retainCard).ToList();
            foreach (var cardId in discards)
            {
                player.Hand.Remove(cardId);
                player.Discard.Add(cardId);
            }
            player.Hand.Clear();
            player.Hand.Add(retainCard);
        }

        state.ActivePlayer = opponent.Id;
    }
}
