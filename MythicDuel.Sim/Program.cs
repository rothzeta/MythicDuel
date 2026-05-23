using MythicDuel.Core.Game;
using MythicDuel.Sim.Reporting;

var parsed = ParseArgs(args);
var runner = new SimulationRunner();
var writer = new ReportWriter();
var catalogWriter = new CatalogWriter();
var invokedCommand = BuildReportCommand(parsed);

if (parsed.Mode == "catalog")
{
    Directory.CreateDirectory(parsed.OutputPath);
    await File.WriteAllTextAsync(Path.Combine(parsed.OutputPath, parsed.CatalogFileName), catalogWriter.CreateCatalogJson(runner, invokedCommand));
    Console.WriteLine($"Catalog written to {Path.Combine(parsed.OutputPath, parsed.CatalogFileName)}");
    return;
}

parsed.OutputPath = ReportOutputPaths.CreateTimestampedOutputPath(parsed.OutputPath);
var redBotImplementation = runner.CreateBot(parsed.BotRed).GetType().Name;
var ironBotImplementation = runner.CreateBot(parsed.BotIron).GetType().Name;
Directory.CreateDirectory(parsed.OutputPath);

if (parsed.Mode == "batch")
{
    var results = runner.RunBatch(new SimulationOptions
    {
        Seed = parsed.Seed,
        Games = parsed.Games,
        BotRed = parsed.BotRed,
        BotIron = parsed.BotIron,
        DeckRed = parsed.DeckRed,
        DeckIron = parsed.DeckIron,
        Rules = parsed.Rules,
    });

    var batch = writer.CreateBatchReport(results, redBotImplementation, ironBotImplementation, invokedCommand);
    await File.WriteAllTextAsync(Path.Combine(parsed.OutputPath, "batch-summary.md"), batch.SummaryMarkdown);
    await File.WriteAllTextAsync(Path.Combine(parsed.OutputPath, "batch-summary.json"), batch.SummaryJson);
    await File.WriteAllTextAsync(Path.Combine(parsed.OutputPath, "batch-summary.csv"), batch.SummaryCsv);

    var sampleDir = Path.Combine(parsed.OutputPath, "sample-games");
    Directory.CreateDirectory(sampleDir);
    foreach (var sample in batch.SampleGames)
    {
        await File.WriteAllTextAsync(Path.Combine(sampleDir, $"{sample.Key}.md"), sample.Value.Markdown);
        await File.WriteAllTextAsync(Path.Combine(sampleDir, $"{sample.Key}.json"), sample.Value.Json);
    }

    Console.WriteLine($"Batch complete: {results.Count} games written to {parsed.OutputPath}");
}
else
{
    var result = runner.RunSingle(new SimulationOptions
    {
        Seed = parsed.Seed,
        Games = 1,
        BotRed = parsed.BotRed,
        BotIron = parsed.BotIron,
        DeckRed = parsed.DeckRed,
        DeckIron = parsed.DeckIron,
        Rules = parsed.Rules,
    });

    var report = writer.CreateSingleReport(result, redBotImplementation, ironBotImplementation, invokedCommand);
    await File.WriteAllTextAsync(Path.Combine(parsed.OutputPath, $"game-{parsed.Seed}.md"), report.Markdown);
    await File.WriteAllTextAsync(Path.Combine(parsed.OutputPath, $"game-{parsed.Seed}.json"), report.Json);
    Console.WriteLine($"Single game complete: winner={result.Metrics.Winner} turns={result.Metrics.TurnCount}");
}

static string BuildReportCommand(ParsedArgs parsed)
{
    var args = new List<string>
    {
        "--mode", parsed.Mode,
        "--games", parsed.Games.ToString(),
        "--seed", parsed.Seed.ToString(),
        "--out", parsed.OutputPath,
        "--bot-red", parsed.BotRed,
        "--bot-iron", parsed.BotIron,
        "--deck-red", parsed.DeckRed,
        "--deck-iron", parsed.DeckIron,
    };

    if (!string.IsNullOrWhiteSpace(parsed.Rules))
    {
        args.Add("--rules");
        args.Add(parsed.Rules);
    }

    if (parsed.Mode == "catalog")
    {
        args.Add("--catalog-file");
        args.Add(parsed.CatalogFileName);
    }

    var escapedArgs = args.Select(EscapeArgument);
    return $"dotnet run --project MythicDuel.Sim -- {string.Join(" ", escapedArgs)}";
}

static string EscapeArgument(string value)
{
    if (string.IsNullOrEmpty(value))
    {
        return "\"\"";
    }

    return value.Any(ch => char.IsWhiteSpace(ch) || ch == '"')
        ? $"\"{value.Replace("\\", "\\\\").Replace("\"", "\\\"")}\""
        : value;
}

static ParsedArgs ParseArgs(string[] args)
{
    var parsed = new ParsedArgs();
    for (var i = 0; i < args.Length; i++)
    {
        switch (args[i])
        {
            case "--mode":
                parsed.Mode = args[++i];
                break;
            case "--games":
                parsed.Games = int.Parse(args[++i]);
                break;
            case "--seed":
                parsed.Seed = int.Parse(args[++i]);
                break;
            case "--out":
                parsed.OutputPath = Path.GetFullPath(args[++i]);
                break;
            case "--bot-red":
                parsed.BotRed = args[++i];
                break;
            case "--bot-iron":
                parsed.BotIron = args[++i];
                break;
            case "--deck-red":
                parsed.DeckRed = args[++i];
                break;
            case "--deck-iron":
                parsed.DeckIron = args[++i];
                break;
            case "--rules":
                parsed.Rules = args[++i];
                break;
            case "--catalog-file":
                parsed.CatalogFileName = args[++i];
                break;
        }
    }

    return parsed;
}

file sealed class ParsedArgs
{
    public string Mode { get; set; } = "single";
    public int Games { get; set; } = 1;
    public int Seed { get; set; } = 123;
    public string OutputPath { get; set; } = Path.GetFullPath("./reports");
    public string BotRed { get; set; } = "red";
    public string BotIron { get; set; } = "iron";
    public string DeckRed { get; set; } = "red";
    public string DeckIron { get; set; } = "iron";
    public string Rules { get; set; } = string.Empty;
    public string CatalogFileName { get; set; } = "catalog.json";
}

public static class ReportOutputPaths
{
    public static string CreateTimestampedOutputPath(string outputRoot)
    {
        var root = Path.GetFullPath(outputRoot);
        Directory.CreateDirectory(root);

        var timestamp = DateTimeOffset.Now.ToString("yyyyMMdd-HHmmss");
        var candidate = Path.Combine(root, timestamp);
        var suffix = 1;
        while (Directory.Exists(candidate))
        {
            candidate = Path.Combine(root, $"{timestamp}-{suffix:00}");
            suffix++;
        }

        return candidate;
    }
}
