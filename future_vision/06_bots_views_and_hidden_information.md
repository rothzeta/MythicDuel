# 06 — Bots, Views, and Hidden Information

## Key rule

Bots should not receive full `GameState`.

Prepared Tactics are face-down. If bots inspect full state, hidden information is fake.

Use:

```text
GameState -> GameView -> LegalActions -> Bot decision
```

## GameView

A `GameView` is player-specific.

It contains:

```text
viewer player id
visible cards
hidden card placeholders
public board state
visible shrines
visible ancestors
resource counts
known events
legal actions
```

## Visibility rules

For self:

```text
hand: visible
deck: order maybe hidden unless game rules reveal it
prepared tactics: visible
battlefield: visible
discard: visible
forgotten: visible unless rules say otherwise
shrines: visible
ancestors: visible
```

For opponent:

```text
hand: count only
deck: count only
prepared tactics: unknown face-down cards
battlefield: visible
discard: visible
forgotten: visible if public
shrines: visible
ancestors: visible
```

## Bot interface

Recommended:

```csharp
public interface IGameBot
{
    PlayerAction ChooseAction(
        GameView view,
        IReadOnlyList<LegalAction> legalActions,
        BotContext context);
}
```

Optional specialized hooks:

```csharp
BlockDecision ChooseBlock(GameView view, AttackInfo attack, IReadOnlyList<LegalAction> legalBlocks);
RetainDecision ChooseRetain(GameView view, IReadOnlyList<LegalAction> legalRetains);
```

But prefer one generic action chooser if possible.

## Bot should choose, not validate

The engine generates legal actions.

The bot ranks/chooses from them.

Bad:

```text
Bot inspects GameState and invents maybe-legal commands.
```

Good:

```text
Engine gives legal actions.
Bot chooses one.
Engine validates anyway.
```

## Bot levels

Start with simple bots:

### RandomLegalBot

```text
choose a random legal action
weighted to avoid endless pass/end-turn bugs
```

### GreedyBot

```text
prioritize lethal shrine damage
play strongest Being
attack if favorable
evolve if legal
prepare tactic if no good play
```

### ScriptedTestBot

```text
used for scenario tests
plays a deterministic sequence if legal
```

### SimulationBot

```text
uses scoring function
can run shallow rollouts later
```

Do not build MCTS or complex AI before the new engine is playable.

## Bot view diagnostics

For debugging hidden information, emit diagnostics:

```text
bot_view_hidden_opponent_hand_count
bot_view_hidden_prepared_tactics_count
bot_selected_action
bot_action_score
```

This helps prove bots are not cheating.

## PvP readiness

If the engine can support bots through hidden views, it is already closer to PvP.

Future PvP flow:

```text
server owns full GameState
client receives GameView
client chooses LegalAction/Command
server validates
server resolves
server sends events/views
```

Do not let UI own hidden-information logic.
