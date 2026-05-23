# Appendix — Minimal C# Skeleton

This is illustrative, not final production code.

## IDs

```csharp
public readonly record struct PlayerId(string Value);
public readonly record struct CardInstanceId(int Value);
public readonly record struct CardDefinitionId(string Value);
public readonly record struct DeckId(string Value);
public readonly record struct FactionId(string Value);
```

## Commands

```csharp
public interface IGameCommand
{
    PlayerId PlayerId { get; }
}

public sealed record PlayCardCommand(
    PlayerId PlayerId,
    CardInstanceId CardId
) : IGameCommand;

public sealed record DeclareAttackCommand(
    PlayerId PlayerId,
    CardInstanceId AttackerId,
    TargetId Target
) : IGameCommand;

public sealed record EndTurnCommand(
    PlayerId PlayerId
) : IGameCommand;
```

## Legal actions

```csharp
public abstract record LegalAction(PlayerId PlayerId, string Explanation);

public sealed record PlayCardAction(
    PlayerId PlayerId,
    CardInstanceId CardId,
    string Explanation
) : LegalAction(PlayerId, Explanation);

public sealed record DeclareAttackAction(
    PlayerId PlayerId,
    CardInstanceId AttackerId,
    TargetId Target,
    string Explanation
) : LegalAction(PlayerId, Explanation);

public sealed record EndTurnAction(
    PlayerId PlayerId,
    string Explanation
) : LegalAction(PlayerId, Explanation);
```

## GameEngine

```csharp
public sealed class GameEngine
{
    private readonly LegalActionGenerator _legalActions;
    private readonly CommandValidator _validator;
    private readonly ResolutionPipeline _pipeline;
    private readonly RuleIndexBuilder _ruleIndexBuilder;

    public CommandResult Execute(GameState state, IGameCommand command)
    {
        var ruleIndex = _ruleIndexBuilder.Build(state);

        var validation = _validator.Validate(state, command, ruleIndex);
        if (!validation.IsValid)
            return CommandResult.Invalid(validation.Errors);

        var context = new ResolutionContext(state, command, ruleIndex);

        var result = _pipeline.Resolve(context);

        return result;
    }

    public IReadOnlyList<LegalAction> GetLegalActions(GameState state, PlayerId playerId)
    {
        var ruleIndex = _ruleIndexBuilder.Build(state);
        var view = GameViewBuilder.Build(state, playerId);
        return _legalActions.Generate(state, view, playerId, ruleIndex);
    }
}
```

## Rule modules

```csharp
public interface IKeywordModule
{
    KeywordId Id { get; }

    IEnumerable<IModifier> GetModifiers(
        GameState state,
        CardInstanceId source,
        RuleContext context);

    IEnumerable<IReplacementEffect> GetReplacementEffects(
        GameState state,
        CardInstanceId source,
        RuleContext context);

    IEnumerable<ITrigger> GetTriggers(
        GameState state,
        CardInstanceId source,
        RuleContext context);
}
```

## Fade

```csharp
public sealed class FadeKeyword : IKeywordModule
{
    public KeywordId Id => KeywordIds.Fade;

    public IEnumerable<IModifier> GetModifiers(
        GameState state,
        CardInstanceId source,
        RuleContext context)
    {
        yield break;
    }

    public IEnumerable<IReplacementEffect> GetReplacementEffects(
        GameState state,
        CardInstanceId source,
        RuleContext context)
    {
        yield return new FadeReplacementEffect(source);
    }

    public IEnumerable<ITrigger> GetTriggers(
        GameState state,
        CardInstanceId source,
        RuleContext context)
    {
        yield break;
    }
}

public sealed class FadeReplacementEffect : IReplacementEffect
{
    private readonly CardInstanceId _source;

    public FadeReplacementEffect(CardInstanceId source)
    {
        _source = source;
    }

    public bool AppliesTo(PendingEvent pending, GameState state)
    {
        return pending is PendingMoveCard move
            && move.CardId == _source
            && move.To == Zone.Discard
            && move.Reason == MoveReason.AfterResolution;
    }

    public PendingEvent Replace(PendingEvent pending, GameState state)
    {
        var move = (PendingMoveCard)pending;

        return move with
        {
            To = Zone.Forgotten,
            Reason = MoveReason.Fade
        };
    }
}
```

## WeaponMaster

```csharp
public sealed class WeaponMasterKeyword : IKeywordModule
{
    public KeywordId Id => KeywordIds.WeaponMaster;

    public IEnumerable<IModifier> GetModifiers(
        GameState state,
        CardInstanceId source,
        RuleContext context)
    {
        if (state.Attachments.IsWieldingWeapon(source))
            yield return new GrantKeywordModifier(source, KeywordIds.Pierce);
    }

    public IEnumerable<IReplacementEffect> GetReplacementEffects(
        GameState state,
        CardInstanceId source,
        RuleContext context)
    {
        yield break;
    }

    public IEnumerable<ITrigger> GetTriggers(
        GameState state,
        CardInstanceId source,
        RuleContext context)
    {
        yield break;
    }
}
```

## RuleIndex

```csharp
public sealed class RuleIndex
{
    public IReadOnlyList<IModifier> ActiveModifiers { get; init; } = [];
    public IReadOnlyList<IReplacementEffect> ActiveReplacementEffects { get; init; } = [];
    public IReadOnlyList<ITrigger> ActiveTriggers { get; init; } = [];
}

public sealed class RuleIndexBuilder
{
    private readonly CardCatalog _catalog;

    public RuleIndex Build(GameState state)
    {
        var modifiers = new List<IModifier>();
        var replacements = new List<IReplacementEffect>();
        var triggers = new List<ITrigger>();

        foreach (var card in state.Cards.Values)
        {
            if (!IsActiveRuleSource(card))
                continue;

            var definition = _catalog.Get(card.DefinitionId);

            foreach (var keyword in definition.Keywords)
            {
                modifiers.AddRange(keyword.GetModifiers(state, card.Id, RuleContext.Default));
                replacements.AddRange(keyword.GetReplacementEffects(state, card.Id, RuleContext.Default));
                triggers.AddRange(keyword.GetTriggers(state, card.Id, RuleContext.Default));
            }
        }

        return new RuleIndex
        {
            ActiveModifiers = modifiers,
            ActiveReplacementEffects = replacements,
            ActiveTriggers = triggers
        };
    }

    private static bool IsActiveRuleSource(CardInstance card)
    {
        return card.Zone is Zone.Battlefield or Zone.Prepared;
    }
}
```

## GameView

```csharp
public sealed record GameView(
    PlayerId Viewer,
    PlayerView Self,
    PlayerView Opponent,
    IReadOnlyList<GameEventView> VisibleEvents
);

public sealed record CardView(
    CardInstanceId? InstanceId,
    CardDefinitionId? DefinitionId,
    bool IsHidden,
    string DisplayName
);
```

## Bot

```csharp
public interface IGameBot
{
    LegalAction ChooseAction(
        GameView view,
        IReadOnlyList<LegalAction> legalActions,
        BotContext context);
}

public sealed class RandomLegalBot : IGameBot
{
    public LegalAction ChooseAction(
        GameView view,
        IReadOnlyList<LegalAction> legalActions,
        BotContext context)
    {
        if (legalActions.Count == 0)
            throw new InvalidOperationException("No legal actions available.");

        var index = context.Random.NextInt(0, legalActions.Count);
        return legalActions[index];
    }
}
```
