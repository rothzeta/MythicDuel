using MythicDuel.Core.Models;

namespace MythicDuel.Core.Game;

public sealed class TurnDecision
{
    public List<PlayerAction> Main1Actions { get; } = new();
    public List<AttackDecision> Attacks { get; } = new();
    public List<PlayerAction> Main2Actions { get; } = new();
    public string Notes { get; set; } = string.Empty;
}

public abstract record PlayerAction(ActionKind Kind, int CardId);

public enum ActionKind
{
    PlayUnit,
    PlayPossession,
    PlayRelic,
    PlayRite,
    PrepareTactic,
    Evolve,
    AwakenAncestor,
}

public sealed record PlayUnitAction(int CardId) : PlayerAction(ActionKind.PlayUnit, CardId);
public sealed record PlayPossessionAction(int CardId, int HostId) : PlayerAction(ActionKind.PlayPossession, CardId);
public sealed record PlayRelicAction(int CardId, int HostId) : PlayerAction(ActionKind.PlayRelic, CardId);
public sealed record PlayRiteAction(int CardId, string? ShrineName = null, int? UnitId = null) : PlayerAction(ActionKind.PlayRite, CardId);
public sealed record PrepareTacticAction(int CardId) : PlayerAction(ActionKind.PrepareTactic, CardId);
public sealed record EvolveAction(int CardId, int HostId, bool FromDiscard) : PlayerAction(ActionKind.Evolve, CardId);
public sealed record AwakenAncestorAction(string AncestorDefinitionId) : PlayerAction(ActionKind.AwakenAncestor, 0);

public sealed record AttackDecision(int AttackerId, AttackTargetType TargetType, string TargetName, int? TargetUnitId = null, string? ShrineName = null);

public sealed record BlockDecision(int? BlockerId, string TargetName, int AttackerId)
{
    public static readonly BlockDecision NoBlock = new(null, string.Empty, 0);
}

public enum AttackTargetType
{
    Unit,
    Shrine,
}
