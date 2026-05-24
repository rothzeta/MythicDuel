using System.Collections.Generic;
namespace MythicDuel.Engine.Pipeline;
public sealed class CommandResult
{
    public bool IsValid { get; set; }
    public List<string> Errors { get; set; } = new();
    public static CommandResult Invalid(List<string> errors) => new() { IsValid = false, Errors = errors };
    public static CommandResult Success() => new() { IsValid = true };
}
