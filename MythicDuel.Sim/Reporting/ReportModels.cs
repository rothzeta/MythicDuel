using MythicDuel.Core.Game;
using MythicDuel.Core.Models;

namespace MythicDuel.Sim.Reporting;

public sealed record BatchSummary(
    int Games,
    int SeedsStart,
    int SeedsEnd,
    string Command,
    string RedBot,
    string IronBot,
    int RedWins,
    int IronWins,
    int Timeouts,
    double AverageTurns,
    IReadOnlyList<string> SampleGameIds,
    IReadOnlyList<string> Warnings);

public sealed record SingleReportBundle(
    string Markdown,
    string Json);

public sealed record BatchReportBundle(
    string SummaryMarkdown,
    string SummaryJson,
    string SummaryCsv,
    IReadOnlyDictionary<string, SingleReportBundle> SampleGames);
