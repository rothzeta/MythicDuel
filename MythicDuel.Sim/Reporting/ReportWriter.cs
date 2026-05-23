using System.Globalization;
using System.Text;
using System.Text.Json;
using MythicDuel.Core.Game;
using MythicDuel.Core.Models;

namespace MythicDuel.Sim.Reporting;

public sealed class ReportWriter
{
    private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };

    public SingleReportBundle CreateSingleReport(SimulationResult result, string redBot, string ironBot, string command)
    {
        return new SingleReportBundle(CreateMarkdown(result, redBot, ironBot, command), JsonSerializer.Serialize(CreateStateJson(result, redBot, ironBot, command), JsonOptions));
    }

    private static object CreateStateJson(SimulationResult result, string redBot, string ironBot, string command)
    {
        var state = result.State;
        return new
        {
            state.GameId,
            state.Seed,
            Command = command,
            Bots = new
            {
                Red = redBot,
                Iron = ironBot,
            },
            Seats = new
            {
                Seat1 = new { state.Red.Seat, state.Red.Name, state.Red.Faction, state.Red.DeckName },
                Seat2 = new { state.Iron.Seat, state.Iron.Name, state.Iron.Faction, state.Iron.DeckName },
            },
            Winner = state.Winner?.ToString(),
            state.EndReason,
            state.Outcome,
            AdjudicatedWinner = result.Metrics.AdjudicatedWinner,
            Metrics = result.Metrics,
            Events = state.Events,
            Turns = state.Turns,
            Red = new
            {
                state.Red.Name,
                Shrines = state.Red.Shrines,
                Forgotten = state.Red.Forgotten.Select(id => state.Cards[id].Name).ToList(),
                Battlefield = state.Red.Battlefield.Select(id => state.Cards[id].Name).ToList(),
            },
            Iron = new
            {
                state.Iron.Name,
                Shrines = state.Iron.Shrines,
                Forgotten = state.Iron.Forgotten.Select(id => state.Cards[id].Name).ToList(),
                Battlefield = state.Iron.Battlefield.Select(id => state.Cards[id].Name).ToList(),
            }
        };
    }

    public BatchReportBundle CreateBatchReport(IReadOnlyList<SimulationResult> results, string redBot, string ironBot, string command)
    {
        var warnings = CreateBatchWarnings(results);
        var sampleDigests = SelectSampleDigests(results, command);
        var summary = new BatchSummary(
            results.Count,
            results.Min(x => x.Metrics.Seed),
            results.Max(x => x.Metrics.Seed),
            command,
            redBot,
            ironBot,
            results.Count(x => x.State.Winner == PlayerId.Red),
            results.Count(x => x.State.Winner == PlayerId.Iron),
            results.Count(x => x.Metrics.Timeout),
            results.Count == 0 ? 0 : results.Average(x => x.Metrics.TurnCount),
            sampleDigests.Select(x => x.Result.State.GameId).ToList(),
            warnings);

        var sampleGames = sampleDigests
            .ToDictionary(
                x => $"{Slugify(GetHeadlineLabel(x.Labels))}-game-{GetDisplayGameId(x.Result)}",
                x => CreateSingleReport(x.Result, redBot, ironBot, command),
                StringComparer.OrdinalIgnoreCase);

        return new BatchReportBundle(
            CreateBatchSummaryMarkdown(summary, sampleDigests, command),
            JsonSerializer.Serialize(new
            {
                summary,
                digests = sampleDigests.Select(x => new
                {
                    Headline = GetHeadlineLabel(x.Labels),
                    Labels = x.Labels,
                    GameId = x.Result.State.GameId,
                    x.Result.Metrics.Seed,
                }),
                metrics = results.Select(x => x.Metrics)
            }, JsonOptions),
            CreateCsv(results),
            sampleGames);
    }

    private string CreateMarkdown(SimulationResult result, string redBot, string ironBot, string command)
    {
        var state = result.State;
        var builder = new StringBuilder();
        builder.AppendLine($"# Test Game #{state.GameId}");
        builder.AppendLine();
        builder.AppendLine($"Command: {command}");
        builder.AppendLine();
        builder.AppendLine("Seat 1:");
        builder.AppendLine($"- {state.Red.Name} [{state.Red.Faction}] ({redBot})");
        builder.AppendLine("Seat 2:");
        builder.AppendLine($"- {state.Iron.Name} [{state.Iron.Faction}] ({ironBot})");
        builder.AppendLine();
        builder.AppendLine("Rules variant:");
        builder.AppendLine("- Draw model: retain up to 1, discard rest, draw to 5");
        builder.AppendLine("- Phase model: reverse every 4 player-turns");
        builder.AppendLine("- Combat model: 2 standard Assault slots, plus Pack expansion up to 5 total attacks, separate resolution");
        builder.AppendLine("- Battlefield capacity: 5 Presence per seat");
        builder.AppendLine("- Prepared model: max 1 active tactic per player");
        builder.AppendLine("- Special mechanics: Fade, Forgotten, Wounded, Pierce, Disperse, Possession, Evolution, Recall, Unique, Pack");
        builder.AppendLine();
        builder.AppendLine($"Seed: {state.Seed}");
        builder.AppendLine($"Winner: {DescribeWinner(result)}");
        builder.AppendLine("Main question: Are current Shrine pressure and evolution rules stable?");
        builder.AppendLine();
        builder.AppendLine("## Starting setup");
        builder.AppendLine($"- Starting Shrines — Red: {string.Join(", ", state.Red.Shrines.Select(x => x.Name))}");
        builder.AppendLine($"- Starting Shrines — Iron: {string.Join(", ", state.Iron.Shrines.Select(x => x.Name))}");
        builder.AppendLine($"- Starting hands — Red: {string.Join(", ", state.Turns.FirstOrDefault()?.Start.Hand ?? [])}");
        builder.AppendLine($"- Starting hands — Iron: {string.Join(", ", state.Turns.Skip(1).FirstOrDefault()?.Start.Hand ?? [])}");
        builder.AppendLine("- Starting resources: 0 Offerings / 0 Memory each before first turn resource step");
        builder.AppendLine("- Starting battlefield: empty");
        builder.AppendLine($"- Starting Lineage — Red: {string.Join(", ", state.Red.Lineage.Select(x => x.Name))}");
        builder.AppendLine($"- Starting Lineage — Iron: {string.Join(", ", state.Iron.Lineage.Select(x => x.Name))}");
        builder.AppendLine();

        for (var i = 0; i < state.Turns.Count; i++)
        {
            var turn = state.Turns[i];
            builder.AppendLine($"## Turn {turn.TurnNumber} — {turn.Player}");
            builder.AppendLine();
            builder.AppendLine("Pre-resource snapshot:");
            builder.AppendLine($"Offerings before resource: {turn.Start.Offerings}");
            builder.AppendLine($"Memory before resource: {turn.Start.Memory}");
            builder.AppendLine();
            builder.AppendLine($"Hand before draw: [{string.Join(", ", turn.Start.Hand)}]");
            builder.AppendLine();
            builder.AppendLine("Board before ready:");
            builder.AppendLine($"Beings/Spirits: {string.Join(", ", turn.Start.Battlefield)}");
            builder.AppendLine($"Prepared Tactic: {turn.Start.PreparedTactic ?? "None"}");
            builder.AppendLine($"Awakened Ancestor: {turn.Start.AwakenedAncestor ?? "None"}");
            builder.AppendLine($"Shrine state: {FormatSnapshotShrineStates(turn.Start)}");
            builder.AppendLine($"Forgotten zone count/list: {turn.Start.Forgotten.Count} [{string.Join(", ", turn.Start.Forgotten)}]");
            builder.AppendLine();
            builder.AppendLine("Main 1:");
            if (turn.Main1Actions.Count == 0) builder.AppendLine("- pass");
            foreach (var action in turn.Main1Actions) builder.AppendLine($"- {action}");
            builder.AppendLine();
            builder.AppendLine("Combat:");
            if (turn.Attacks.Count == 0)
            {
                builder.AppendLine("- no attacks");
            }

            for (var attackIndex = 0; attackIndex < turn.Attacks.Count; attackIndex++)
            {
                var attack = turn.Attacks[attackIndex];
                builder.AppendLine();
                builder.AppendLine($"Attack {attackIndex + 1}:");
                builder.AppendLine($"- Attacker: {attack.Attacker}");
                builder.AppendLine($"- Target: {attack.Target}");
                builder.AppendLine($"- Defender/blocker: {attack.Defender}");
                builder.AppendLine($"- Prepared triggers: {(attack.PreparedTriggers.Count == 0 ? "None" : string.Join(", ", attack.PreparedTriggers))}");
                builder.AppendLine($"- Wounded/Pierce calculations: {(attack.Calculations.Count == 0 ? "None" : string.Join(" | ", attack.Calculations))}");
                builder.AppendLine($"- Damage: {(attack.DamageEvents.Count == 0 ? "None" : string.Join(" | ", attack.DamageEvents))}");
                builder.AppendLine($"- Result: {attack.Result}");
            }

            builder.AppendLine();
            builder.AppendLine("Main 2:");
            if (turn.Main2Actions.Count == 0) builder.AppendLine("- pass");
            foreach (var action in turn.Main2Actions) builder.AppendLine($"- {action}");
            builder.AppendLine();
            builder.AppendLine("End:");
            builder.AppendLine($"- retained card: {turn.RetainedCard ?? "None"}");
            builder.AppendLine($"- discarded cards: {(turn.DiscardedCards.Count == 0 ? "None" : string.Join(", ", turn.DiscardedCards))}");
            builder.AppendLine($"- forgotten cards: {(turn.ForgottenCards.Count == 0 ? "None" : string.Join(", ", turn.ForgottenCards))}");
            builder.AppendLine($"- Wounded clears: {(turn.WoundedClears.Count == 0 ? "None" : string.Join(", ", turn.WoundedClears))}");
            if (turn.End is not null)
            {
                builder.AppendLine($"- resources at end: {turn.End.Offerings} Offerings / {turn.End.Memory} Memory");
                builder.AppendLine($"- shrine state: {FormatSnapshotShrineStates(turn.End)}");
                builder.AppendLine($"- board at end: {string.Join(", ", turn.End.Battlefield)}");
            }

            builder.AppendLine();
            if (turn.TurnNumber % 4 == 0)
            {
                AppendPhaseSummary(builder, state.Turns.Take(i + 1).ToList(), turn.PhaseNumber);
            }
        }

        AppendGameSummary(builder, state);
        return builder.ToString();
    }

    private static void AppendPhaseSummary(StringBuilder builder, IReadOnlyList<TurnRecord> turnsThroughPhase, int phaseNumber)
    {
        var redSnapshot = GetLatestSnapshot(turnsThroughPhase, PlayerId.Red);
        var ironSnapshot = GetLatestSnapshot(turnsThroughPhase, PlayerId.Iron);
        builder.AppendLine($"# End of Phase {phaseNumber} Summary");
        builder.AppendLine();
        builder.AppendLine($"Shrine state: Red [{FormatSnapshotShrineStates(redSnapshot)}] | Iron [{FormatSnapshotShrineStates(ironSnapshot)}]");
        builder.AppendLine($"Resources: Red {FormatSnapshotResources(redSnapshot)} | Iron {FormatSnapshotResources(ironSnapshot)}");
        builder.AppendLine($"Awakened Ancestors: Red {redSnapshot?.AwakenedAncestor ?? "None"} | Iron {ironSnapshot?.AwakenedAncestor ?? "None"}");
        builder.AppendLine($"Forgotten cards: Red {redSnapshot?.Forgotten.Count ?? 0} | Iron {ironSnapshot?.Forgotten.Count ?? 0}");
        builder.AppendLine($"Key events: {string.Join(" | ", turnsThroughPhase.Where(x => x.PhaseNumber == phaseNumber).SelectMany(x => x.Attacks.SelectMany(attack => attack.DamageEvents).Concat(x.Main1Actions).Concat(x.Main2Actions)).TakeLast(6))}");
        builder.AppendLine("Tempo note: initiative reverses after every four player-turns.");
        builder.AppendLine();
    }

    private static void AppendGameSummary(StringBuilder builder, GameState state)
    {
        var metrics = state.Metrics;
        builder.AppendLine("## End-of-game summary");
        builder.AppendLine();
        builder.AppendLine($"Winner: {DescribeWinner(new SimulationResult(state, state.Events, metrics))}");
        builder.AppendLine($"End reason: {DescribeEndReason(metrics)}");
        builder.AppendLine($"Outcome: {DescribeOutcome(metrics)}");
        builder.AppendLine();
        builder.AppendLine($"Final Shrine state: Red [{FormatShrineStates(state.Red.Shrines)}] | Iron [{FormatShrineStates(state.Iron.Shrines)}]");
        builder.AppendLine($"Final resources: Red {state.Red.CurrentOfferings}/{state.Red.Memory} | Iron {state.Iron.CurrentOfferings}/{state.Iron.Memory}");
        builder.AppendLine($"Final Presence: Seat 1 {metrics.PresenceUsedRed}/{metrics.PresenceLimitRed} | Seat 2 {metrics.PresenceUsedIron}/{metrics.PresenceLimitIron}");
        builder.AppendLine();
        builder.AppendLine($"Turn count: {metrics.TurnCount}");
        builder.AppendLine($"Phase count: {metrics.PhaseCount}");
        builder.AppendLine();
        builder.AppendLine($"First Shrine damage: {metrics.FirstShrineDamageTurn} (Seat 1/Red: {metrics.FirstShrineDamageTurnRed}, Seat 2/Iron: {metrics.FirstShrineDamageTurnIron})");
        builder.AppendLine($"First Shrine broken: {metrics.FirstShrineBreakTurn} (Seat 1/Red: {metrics.FirstRedShrineBreakTurn}, Seat 2/Iron: {metrics.FirstIronShrineBreakTurn})");
        builder.AppendLine($"Wins in odd phase: {metrics.WinsInOddPhase}");
        builder.AppendLine($"Winner was first player in final phase: {metrics.WinnerWasFirstPlayerInFinalPhase}");
        builder.AppendLine($"Shrine damage dealt during double-turn: Red {metrics.ShrineDamageDealtDuringDoubleTurnRed}, Iron {metrics.ShrineDamageDealtDuringDoubleTurnIron}");
        builder.AppendLine($"First Ancestor awakened: {metrics.FirstAncestorAwakenedTurn}");
        builder.AppendLine($"First L2: {metrics.FirstL2Turn}");
        builder.AppendLine($"First L3: {metrics.FirstL3Turn}");
        builder.AppendLine();
        builder.AppendLine($"Red L2 entries: {metrics.RedL2EnteredBattlefield} (hard-cast {metrics.RedL2HardCast}, evolved {metrics.RedL2Evolved})");
        builder.AppendLine($"Red L3 entries: {metrics.RedL3EnteredBattlefield} (hard-cast {metrics.RedL3HardCast}, evolved {metrics.RedL3Evolved})");
        builder.AppendLine($"Iron L2 entries: {metrics.IronL2EnteredBattlefield} (hard-cast {metrics.IronL2HardCast}, evolved {metrics.IronL2Evolved})");
        builder.AppendLine($"Iron L3 entries: {metrics.IronL3EnteredBattlefield} (hard-cast {metrics.IronL3HardCast}, evolved {metrics.IronL3Evolved})");
        builder.AppendLine();
        builder.AppendLine($"Legal evolve actions generated: Red {metrics.LegalEvolveActionsGeneratedRed}, Iron {metrics.LegalEvolveActionsGeneratedIron}");
        builder.AppendLine($"Legal L2 evolve actions: Red {metrics.LegalL2EvolveActionsGeneratedRed}, Iron {metrics.LegalL2EvolveActionsGeneratedIron}");
        builder.AppendLine($"Legal L3 evolve actions: Red {metrics.LegalL3EvolveActionsGeneratedRed}, Iron {metrics.LegalL3EvolveActionsGeneratedIron}");
        builder.AppendLine($"Evolve windows: Red {metrics.EvolveWindowsRed}, Iron {metrics.EvolveWindowsIron}");
        builder.AppendLine($"Turns with legal L2 evolution: Red {metrics.TurnsWithLegalL2EvolutionRed}, Iron {metrics.TurnsWithLegalL2EvolutionIron}");
        builder.AppendLine($"Turns with legal L3 evolution: Red {metrics.TurnsWithLegalL3EvolutionRed}, Iron {metrics.TurnsWithLegalL3EvolutionIron}");
        builder.AppendLine($"Evolve actions chosen: Red {metrics.EvolveActionsChosenRed}, Iron {metrics.EvolveActionsChosenIron}");
        builder.AppendLine($"Hard-cast chosen while legal evolve action existed: Red {metrics.HardCastChosenWhileLegalEvolveActionExistsRed}, Iron {metrics.HardCastChosenWhileLegalEvolveActionExistsIron}");
        builder.AppendLine($"Hard-cast chosen while evolution base existed: Red {metrics.HardCastChosenWhileEvolutionBaseExistsRed}, Iron {metrics.HardCastChosenWhileEvolutionBaseExistsIron}");
        builder.AppendLine();
        builder.AppendLine($"Legal awaken actions generated: Red {metrics.LegalAwakenActionsGeneratedRed}, Iron {metrics.LegalAwakenActionsGeneratedIron}");
        builder.AppendLine($"Awaken actions chosen: Red {metrics.AwakenActionsChosenRed}, Iron {metrics.AwakenActionsChosenIron}");
        builder.AppendLine($"Awaken actions skipped while legal: Red {metrics.AwakenActionsSkippedWhileLegalRed}, Iron {metrics.AwakenActionsSkippedWhileLegalIron}");
        builder.AppendLine($"First awakened ancestor: Red {FormatAncestor(metrics.FirstAwakenedAncestorRed)}, Iron {FormatAncestor(metrics.FirstAwakenedAncestorIron)}");
        builder.AppendLine($"Ancestor switches: Red {metrics.AncestorSwitchesRed}, Iron {metrics.AncestorSwitchesIron}");
        builder.AppendLine($"Turns with awakened ancestor: Red {metrics.TurnsWithAwakenedAncestorRed}, Iron {metrics.TurnsWithAwakenedAncestorIron}");
        builder.AppendLine($"Memory spent on ancestors: Red {metrics.MemorySpentOnAncestorsRed}, Iron {metrics.MemorySpentOnAncestorsIron}");
        builder.AppendLine($"Ancestor realized value: First Hunter +{metrics.FirstHunterBonusDamage} damage, Grandmother healed {metrics.GrandmotherHealingDone}, Child draw/discard {metrics.ChildDrawDiscardTriggers}, Iron Hyena +{metrics.IronHyenaAncestorBonusDamage} damage, Smith saved {metrics.SmithOfferingDiscountSaved} Offerings, Tooth-Mother +{metrics.ToothMotherBonusDamage} damage");
        builder.AppendLine();
        builder.AppendLine($"Prepared Tactics triggered: Red {metrics.PreparedTacticsTriggeredRed}, Iron {metrics.PreparedTacticsTriggeredIron}");
        builder.AppendLine($"Prepared Tactics expired: Red {metrics.PreparedTacticsExpiredRed}, Iron {metrics.PreparedTacticsExpiredIron}");
        builder.AppendLine($"Fade cards Forgotten: Red {metrics.ForgottenCardsRed}, Iron {metrics.ForgottenCardsIron}");
        builder.AppendLine($"Wounded events: Red {metrics.WoundedEventsRed}, Iron {metrics.WoundedEventsIron}");
        builder.AppendLine($"Wounded reduced damage: Red {metrics.WoundedDamageReductionEventsRed}, Iron {metrics.WoundedDamageReductionEventsIron}");
        builder.AppendLine($"Pierce overflow events: Red {metrics.PierceOverflowEventsRed}, Iron {metrics.PierceOverflowEventsIron}");
        builder.AppendLine($"WeaponMaster Pierce events: {metrics.WeaponmasterPierceEvents}");
        builder.AppendLine($"SoulSlayer Pierce events: {metrics.SoulslayerPierceEvents}");
        builder.AppendLine($"Legal block options: Red {metrics.LegalBlockOptionsRed}, Iron {metrics.LegalBlockOptionsIron}");
        builder.AppendLine($"Blocks chosen: Red {metrics.BlocksChosenRed}, Iron {metrics.BlocksChosenIron}");
        builder.AppendLine($"Blocks declined: Red {metrics.BlocksDeclinedRed}, Iron {metrics.BlocksDeclinedIron}");
        builder.AppendLine($"Assault slots spent: Seat 1 standard {metrics.StandardAssaultSlotsSpentRed}, pack {metrics.PackAssaultSlotsSpentRed} | Seat 2 standard {metrics.StandardAssaultSlotsSpentIron}, pack {metrics.PackAssaultSlotsSpentIron}");
        builder.AppendLine($"Pack diagnostics: Seat 1 ready-at-combat {metrics.PackUnitsReadyAtCombatStartRed}, generated {metrics.PackAssaultSlotsGeneratedRed}, available {metrics.PackAssaultSlotsAvailableRed}, skipped {metrics.PackAssaultSlotsSkippedRed}, turns-with-bonus {metrics.TurnsWithPackBonusRed}, max-attacks {metrics.MaxAttacksAvailableThisCombatRed}, prevented-by-limit {metrics.AttacksPreventedByAssaultLimitRed}");
        builder.AppendLine($"Pack diagnostics: Seat 2 ready-at-combat {metrics.PackUnitsReadyAtCombatStartIron}, generated {metrics.PackAssaultSlotsGeneratedIron}, available {metrics.PackAssaultSlotsAvailableIron}, skipped {metrics.PackAssaultSlotsSkippedIron}, turns-with-bonus {metrics.TurnsWithPackBonusIron}, max-attacks {metrics.MaxAttacksAvailableThisCombatIron}, prevented-by-limit {metrics.AttacksPreventedByAssaultLimitIron}");
        builder.AppendLine($"Deck reshuffles: Red {metrics.DeckReshufflesRed}, Iron {metrics.DeckReshufflesIron}");
        builder.AppendLine();
        builder.AppendLine("Analysis:");
        builder.AppendLine("- What felt good: deterministic event log and reproducible combat flow.");
        builder.AppendLine("- What felt bad / slow: simple bots can overcommit and miss better sequencing.");
        builder.AppendLine("- Combat findings: Wounded and Pierce materially change blocked Shrine races.");
        builder.AppendLine("- Shrine pressure findings: Iron pushes damage faster while Red stabilizes with restoration.");
        builder.AppendLine("- Memory findings: Spirit dispersal and shrine triggers strongly influence evolution windows.");
        builder.AppendLine("- Evolution findings: L2/L3 timings are highly deed-dependent.");
        builder.AppendLine("- Phase / initiative findings: the reversal rule changes who gets the momentum swing.");
        builder.AppendLine("- Card balance notes: generated from current deterministic bots only.");
        builder.AppendLine("- Rule changes to test next: tweak shrine damage pacing, Memory generation, and Prepared timing.");
    }

    private static IReadOnlyList<string> CreateBatchWarnings(IReadOnlyList<SimulationResult> results)
    {
        var warnings = new List<string>();
        if (results.Count == 0)
        {
            return warnings;
        }

        var redL2Played = results.Sum(x => x.Metrics.RedL2Played);
        var redL2Entered = results.Sum(x => x.Metrics.RedL2EnteredBattlefield);
        var redL3Played = results.Sum(x => x.Metrics.RedL3Played);
        var redL3Entered = results.Sum(x => x.Metrics.RedL3EnteredBattlefield);
        var ironL2Played = results.Sum(x => x.Metrics.IronL2Played);
        var ironL2Entered = results.Sum(x => x.Metrics.IronL2EnteredBattlefield);
        var ironL3Played = results.Sum(x => x.Metrics.IronL3Played);
        var ironL3Entered = results.Sum(x => x.Metrics.IronL3EnteredBattlefield);
        var evolveActionsChosenRed = results.Sum(x => x.Metrics.EvolveActionsChosenRed);
        var evolveActionsChosenIron = results.Sum(x => x.Metrics.EvolveActionsChosenIron);
        var hardCastWhileLegalEvolveExistsRed = results.Sum(x => x.Metrics.HardCastChosenWhileLegalEvolveActionExistsRed);
        var hardCastWhileLegalEvolveExistsIron = results.Sum(x => x.Metrics.HardCastChosenWhileLegalEvolveActionExistsIron);
        var hardCastWhileEvolutionBaseExistsRed = results.Sum(x => x.Metrics.HardCastChosenWhileEvolutionBaseExistsRed);
        var hardCastWhileEvolutionBaseExistsIron = results.Sum(x => x.Metrics.HardCastChosenWhileEvolutionBaseExistsIron);
        var legalBlockOptionsRed = results.Sum(x => x.Metrics.LegalBlockOptionsRed);
        var legalBlockOptionsIron = results.Sum(x => x.Metrics.LegalBlockOptionsIron);
        var blocksChosenRed = results.Sum(x => x.Metrics.BlocksChosenRed);
        var blocksChosenIron = results.Sum(x => x.Metrics.BlocksChosenIron);
        var pierceOverflowEvents = results.Sum(x => x.Metrics.PierceOverflowEventsRed + x.Metrics.PierceOverflowEventsIron);
        var weaponMasterEvents = results.Sum(x => x.Metrics.WeaponmasterPierceEvents);
        var leopardHunterPierceEvents = results.Sum(x => x.Metrics.LeopardHunterPierceEvents);
        var soulSlayerEvents = results.Sum(x => x.Metrics.SoulslayerPierceEvents);
        var blockedShrineAttacks = results.Sum(x => x.Metrics.BlockedShrineAttacksRed + x.Metrics.BlockedShrineAttacksIron);
        var shrineAttacks = results.Sum(x => x.Metrics.ShrineAttacksRed + x.Metrics.ShrineAttacksIron);
        var reshuffles = results.Max(x => Math.Max(x.Metrics.DeckReshufflesRed, x.Metrics.DeckReshufflesIron));
        var maxTurns = results.Max(x => x.Metrics.TurnCount);
        var memoryEnd = results.Max(x => Math.Max(x.Metrics.MemoryEndRed, x.Metrics.MemoryEndIron));
        var lowShrinePressureByTurn40 = results.Any(x => x.Metrics.TurnCount >= 40 && x.Metrics.ShrineAttacksRed < 10 && x.Metrics.ShrineAttacksIron < 10);
        var battlefieldContradiction = results.Any(x =>
            x.State.Red.Battlefield.Select(id => x.State.Cards[id]).Any(card => card.HasTag("L2") || card.HasTag("L3")) &&
            x.Metrics.RedL2EnteredBattlefield + x.Metrics.RedL3EnteredBattlefield == 0 ||
            x.State.Iron.Battlefield.Select(id => x.State.Cards[id]).Any(card => card.HasTag("L2") || card.HasTag("L3")) &&
            x.Metrics.IronL2EnteredBattlefield + x.Metrics.IronL3EnteredBattlefield == 0);

        if (results.All(x => !x.Metrics.FirstL2Turn.HasValue))
        {
            warnings.Add("WARNING: Evolution layer was never exercised.");
            warnings.Add($"- RedL2Played = {redL2Played} (entered battlefield {redL2Entered})");
            warnings.Add($"- RedL3Played = {redL3Played} (entered battlefield {redL3Entered})");
            warnings.Add($"- IronL2Played = {ironL2Played} (entered battlefield {ironL2Entered})");
            warnings.Add($"- IronL3Played = {ironL3Played} (entered battlefield {ironL3Entered})");
            warnings.Add("This batch cannot validate evolution balance.");
        }

        if (leopardHunterPierceEvents > 0 && redL2Entered == 0)
        {
            warnings.Add("WARNING: LeopardHunterPierceEvents > 0 but RedL2Played = 0.");
            warnings.Add("Metrics are inconsistent.");
        }

        if (battlefieldContradiction)
        {
            warnings.Add("WARNING: L2/L3 card appears in final battlefield but L2/L3 metrics are zero.");
        }

        if (hardCastWhileLegalEvolveExistsRed > 0 || hardCastWhileLegalEvolveExistsIron > 0)
        {
            warnings.Add("WARNING: Hard-cast evolution cards were chosen while a legal evolve action existed.");
            warnings.Add($"- HardCastChosenWhileLegalEvolveActionExistsRed = {hardCastWhileLegalEvolveExistsRed}");
            warnings.Add($"- HardCastChosenWhileLegalEvolveActionExistsIron = {hardCastWhileLegalEvolveExistsIron}");
        }

        if (hardCastWhileEvolutionBaseExistsRed > 0 || hardCastWhileEvolutionBaseExistsIron > 0)
        {
            warnings.Add("WARNING: Hard-cast evolution cards were chosen while an evolution base existed.");
            warnings.Add($"- HardCastChosenWhileEvolutionBaseExistsRed = {hardCastWhileEvolutionBaseExistsRed}");
            warnings.Add($"- HardCastChosenWhileEvolutionBaseExistsIron = {hardCastWhileEvolutionBaseExistsIron}");
        }

        if (legalBlockOptionsRed > 0 && blocksChosenRed == 0 || legalBlockOptionsIron > 0 && blocksChosenIron == 0)
        {
            warnings.Add("WARNING: One bot never blocked Shrine attacks across the whole batch.");
            warnings.Add($"- LegalBlockOptionsRed = {legalBlockOptionsRed}, BlocksChosenRed = {blocksChosenRed}");
            warnings.Add($"- LegalBlockOptionsIron = {legalBlockOptionsIron}, BlocksChosenIron = {blocksChosenIron}");
        }

        if (pierceOverflowEvents == 0)
        {
            warnings.Add("WARNING: Pierce overflow was never exercised.");
            warnings.Add($"- PierceOverflowEvents = {pierceOverflowEvents}");
        }

        if (weaponMasterEvents == 0)
        {
            warnings.Add("WARNING: WeaponMaster Pierce was never exercised.");
            warnings.Add($"- WeaponMasterPierceEvents = {weaponMasterEvents}");
        }

        if (soulSlayerEvents == 0)
        {
            warnings.Add("WARNING: SoulSlayer Pierce was never exercised.");
            warnings.Add($"- SoulSlayerPierceEvents = {soulSlayerEvents}");
        }

        if (shrineAttacks > 0 && blockedShrineAttacks <= Math.Max(1, shrineAttacks / 20))
        {
            warnings.Add("WARNING: Blocked Shrine attacks were very low.");
            warnings.Add($"- BlockedShrineAttacks = {blockedShrineAttacks}");
            warnings.Add($"- ShrineAttacks = {shrineAttacks}");
        }

        if (reshuffles > 5)
        {
            warnings.Add("WARNING: More than 5 reshuffles occurred.");
        }

        if (maxTurns > 40)
        {
            warnings.Add("WARNING: Game exceeded 40 turns.");
        }

        if (memoryEnd > 20)
        {
            warnings.Add("WARNING: MemoryEnd > 20.");
        }

        if (lowShrinePressureByTurn40)
        {
            warnings.Add("WARNING: Both players made fewer than 10 Shrine attacks by turn 40.");
        }

        return warnings;
    }

    private static string CreateBatchSummaryMarkdown(BatchSummary summary, IReadOnlyList<SampleDigest> sampleDigests, string command)
    {
        var builder = new StringBuilder();
        builder.AppendLine("# Batch Summary");
        builder.AppendLine();
        builder.AppendLine($"Games: {summary.Games}");
        builder.AppendLine($"Seeds: {summary.SeedsStart}-{summary.SeedsEnd}");
        builder.AppendLine($"Command: {summary.Command}");
        builder.AppendLine($"Bots: Red={summary.RedBot}, Iron={summary.IronBot}");
        builder.AppendLine($"Wins: Red={summary.RedWins}, Iron={summary.IronWins}");
        builder.AppendLine($"Timeouts: {summary.Timeouts}");
        builder.AppendLine($"Average turns: {summary.AverageTurns.ToString("0.##", CultureInfo.InvariantCulture)}");
        builder.AppendLine($"Sample games: {(summary.SampleGameIds.Count == 0 ? "None" : string.Join(", ", summary.SampleGameIds))}");
        builder.AppendLine();

        if (summary.Warnings.Count > 0)
        {
            foreach (var warning in summary.Warnings)
            {
                builder.AppendLine(warning);
            }
        }
        else
        {
            builder.AppendLine("No warnings.");
        }

        if (sampleDigests.Count > 0)
        {
            builder.AppendLine();
            builder.AppendLine("## Sample-game digest");

            foreach (var digest in sampleDigests)
            {
                builder.AppendLine();
                builder.Append(CreateSampleDigestMarkdown(digest, command));
            }
        }

        return builder.ToString();
    }

    private static IReadOnlyList<SampleDigest> SelectSampleDigests(IReadOnlyList<SimulationResult> results, string command)
    {
        if (results.Count == 0)
        {
            return [];
        }

        var selections = new List<(string Label, SimulationResult Result)>();
        AddSelection(selections, "fastest Red win", results.Where(x => x.State.Winner == PlayerId.Red).OrderBy(x => x.Metrics.TurnCount).ThenBy(x => x.Metrics.Seed).FirstOrDefault());
        AddSelection(selections, "fastest Iron win", results.Where(x => x.State.Winner == PlayerId.Iron).OrderBy(x => x.Metrics.TurnCount).ThenBy(x => x.Metrics.Seed).FirstOrDefault());
        AddSelection(selections, "longest game", results.OrderByDescending(x => x.Metrics.TurnCount).ThenBy(x => x.Metrics.Seed).First());
        AddSelection(selections, "closest game", results.OrderBy(x => Math.Abs(x.Metrics.FinalRedShrinesBroken - x.Metrics.FinalIronShrinesBroken)).ThenByDescending(x => x.Metrics.TurnCount).ThenBy(x => x.Metrics.Seed).First());
        AddSelection(selections, "first L3 game", results.Where(x => x.Metrics.FirstL3Turn.HasValue).OrderBy(x => x.Metrics.FirstL3Turn).ThenBy(x => x.Metrics.TurnCount).ThenBy(x => x.Metrics.Seed).FirstOrDefault());
        AddSelection(selections, "highest reshuffle game", results.OrderByDescending(GetReshuffleScore).ThenByDescending(x => x.Metrics.TurnCount).ThenBy(x => x.Metrics.Seed).First());
        AddSelection(selections, "highest Pierce game", results.OrderByDescending(GetPierceScore).ThenByDescending(x => x.Metrics.TurnCount).ThenBy(x => x.Metrics.Seed).First());

        if (command.Contains("forbid-hardcast-evolution-cards", StringComparison.OrdinalIgnoreCase))
        {
            AddSelection(
                selections,
                "no-hardcast failure sample",
                results.Where(IsNoHardcastFailure)
                    .OrderByDescending(x => x.Metrics.Timeout)
                    .ThenByDescending(x => x.Metrics.TurnCount)
                    .ThenByDescending(GetReshuffleScore)
                    .ThenBy(x => x.Metrics.Seed)
                    .FirstOrDefault());
        }

        var order = new List<string>();
        var grouped = new Dictionary<string, (SimulationResult Result, List<string> Labels)>(StringComparer.OrdinalIgnoreCase);
        foreach (var (label, result) in selections)
        {
            var gameId = result.State.GameId;
            if (!grouped.TryGetValue(gameId, out var entry))
            {
                entry = (result, []);
                grouped[gameId] = entry;
                order.Add(gameId);
            }

            if (!entry.Labels.Contains(label, StringComparer.OrdinalIgnoreCase))
            {
                entry.Labels.Add(label);
            }
        }

        return order.Select(gameId =>
        {
            var entry = grouped[gameId];
            return new SampleDigest(entry.Result, entry.Labels);
        }).ToList();
    }

    private static void AddSelection(List<(string Label, SimulationResult Result)> selections, string label, SimulationResult? result)
    {
        if (result is not null)
        {
            selections.Add((label, result));
        }
    }

    private static string CreateSampleDigestMarkdown(SampleDigest digest, string command)
    {
        var result = digest.Result;
        var metrics = result.Metrics;
        var state = result.State;
        var headline = GetHeadlineLabel(digest.Labels);
        var builder = new StringBuilder();
        builder.AppendLine($"### Game {GetDisplayGameId(result)} — {headline}");
        builder.AppendLine($"Tags: {string.Join("; ", digest.Labels)}");
        builder.AppendLine($"Winner: {DescribeWinner(result)} by {DescribeWinType(result)}");
        builder.AppendLine($"Turns: {metrics.TurnCount}");
        builder.AppendLine($"Seed: {metrics.Seed}");
        builder.AppendLine($"Timeout: {(metrics.Timeout ? "yes" : "no")}");
        builder.AppendLine($"Shrines broken: Red {metrics.FinalRedShrinesBroken}, Iron {metrics.FinalIronShrinesBroken}");
        builder.AppendLine($"First Shrine damage: {DescribeNullable(metrics.FirstShrineDamageTurn)} (Seat 1/Red: {DescribeNullable(metrics.FirstShrineDamageTurnRed)}, Seat 2/Iron: {DescribeNullable(metrics.FirstShrineDamageTurnIron)})");
        builder.AppendLine($"First Shrine break: {DescribeNullable(metrics.FirstShrineBreakTurn)} (Seat 1/Red: {DescribeNullable(metrics.FirstRedShrineBreakTurn)}, Seat 2/Iron: {DescribeNullable(metrics.FirstIronShrineBreakTurn)})");
        builder.AppendLine($"Wins in odd phase: {metrics.WinsInOddPhase}");
        builder.AppendLine($"Winner was first player in final phase: {metrics.WinnerWasFirstPlayerInFinalPhase}");
        builder.AppendLine($"Shrine damage dealt during double-turn: Red {metrics.ShrineDamageDealtDuringDoubleTurnRed}, Iron {metrics.ShrineDamageDealtDuringDoubleTurnIron}");
        builder.AppendLine($"First L2: {DescribeNullable(metrics.FirstL2Turn)}");
        builder.AppendLine($"First L3: {DescribeNullable(metrics.FirstL3Turn)}");
        builder.AppendLine($"Layer entries: Red L2 {metrics.RedL2EnteredBattlefield} (hard-cast {metrics.RedL2HardCast}, evolved {metrics.RedL2Evolved}), Red L3 {metrics.RedL3EnteredBattlefield} (hard-cast {metrics.RedL3HardCast}, evolved {metrics.RedL3Evolved}); Iron L2 {metrics.IronL2EnteredBattlefield} (hard-cast {metrics.IronL2HardCast}, evolved {metrics.IronL2Evolved}), Iron L3 {metrics.IronL3EnteredBattlefield} (hard-cast {metrics.IronL3HardCast}, evolved {metrics.IronL3Evolved})");
        builder.AppendLine($"Legal evolve actions: Red {metrics.LegalEvolveActionsGeneratedRed}, Iron {metrics.LegalEvolveActionsGeneratedIron}");
        builder.AppendLine($"Evolve actions chosen: Red {metrics.EvolveActionsChosenRed}, Iron {metrics.EvolveActionsChosenIron}");
        builder.AppendLine($"Hard-cast bypass: legal-window Red {metrics.HardCastChosenWhileLegalEvolveActionExistsRed} / Iron {metrics.HardCastChosenWhileLegalEvolveActionExistsIron}; base-exists Red {metrics.HardCastChosenWhileEvolutionBaseExistsRed} / Iron {metrics.HardCastChosenWhileEvolutionBaseExistsIron}");
        builder.AppendLine($"Awakening flow: legal Red {metrics.LegalAwakenActionsGeneratedRed}, Iron {metrics.LegalAwakenActionsGeneratedIron}; chosen Red {metrics.AwakenActionsChosenRed}, Iron {metrics.AwakenActionsChosenIron}; skipped Red {metrics.AwakenActionsSkippedWhileLegalRed}, Iron {metrics.AwakenActionsSkippedWhileLegalIron}");
        builder.AppendLine($"Awakened ancestors: Red {FormatAncestor(metrics.FirstAwakenedAncestorRed)} / {metrics.TurnsWithAwakenedAncestorRed} turns, Iron {FormatAncestor(metrics.FirstAwakenedAncestorIron)} / {metrics.TurnsWithAwakenedAncestorIron} turns");
        builder.AppendLine($"Ancestor value: First Hunter +{metrics.FirstHunterBonusDamage}, Grandmother healed {metrics.GrandmotherHealingDone}, Child triggers {metrics.ChildDrawDiscardTriggers}, Iron Hyena +{metrics.IronHyenaAncestorBonusDamage}, Smith saved {metrics.SmithOfferingDiscountSaved}, Tooth-Mother +{metrics.ToothMotherBonusDamage}");
        builder.AppendLine($"Shrine attacks: Red {metrics.ShrineAttacksRed}, Iron {metrics.ShrineAttacksIron}");
        builder.AppendLine($"Blocks: Red {metrics.BlocksChosenRed}/{metrics.LegalBlockOptionsRed} chosen, Iron {metrics.BlocksChosenIron}/{metrics.LegalBlockOptionsIron} chosen");
        builder.AppendLine($"Pack pressure: ready units Red {metrics.PackUnitsReadyAtCombatStartRed}, Iron {metrics.PackUnitsReadyAtCombatStartIron}; generated slots Red {metrics.PackAssaultSlotsGeneratedRed}, Iron {metrics.PackAssaultSlotsGeneratedIron}; skipped slots Red {metrics.PackAssaultSlotsSkippedRed}, Iron {metrics.PackAssaultSlotsSkippedIron}; prevented by limit Red {metrics.AttacksPreventedByAssaultLimitRed}, Iron {metrics.AttacksPreventedByAssaultLimitIron}");
        builder.AppendLine($"Pierce signal: overflow Red {metrics.PierceOverflowEventsRed}, Iron {metrics.PierceOverflowEventsIron}; WeaponMaster {metrics.WeaponmasterPierceEvents}; SoulSlayer {metrics.SoulslayerPierceEvents}; LeopardHunter {metrics.LeopardHunterPierceEvents}");
        builder.AppendLine($"Reshuffles: Red {metrics.DeckReshufflesRed}, Iron {metrics.DeckReshufflesIron}");
        builder.AppendLine($"Memory end: Red {metrics.MemoryEndRed}, Iron {metrics.MemoryEndIron}");
        builder.AppendLine($"Final battlefield: Red [{DescribeBattlefield(state, state.Red.Battlefield)}] | Iron [{DescribeBattlefield(state, state.Iron.Battlefield)}]");
        builder.AppendLine($"Key issue: {DescribeKeyIssue(result, digest.Labels, command)}");
        builder.AppendLine($"Observed loop: {DescribeObservedLoop(result, digest.Labels, command)}");
        builder.AppendLine($"Design meaning: {DescribeDesignMeaning(result, digest.Labels, command)}");
        builder.AppendLine($"Next action: {DescribeNextAction(result, digest.Labels, command)}");
        return builder.ToString();
    }

    private static string DescribeWinType(SimulationResult result)
    {
        if (result.Metrics.Timeout)
        {
            return result.Metrics.Outcome switch
            {
                nameof(GameOutcome.AdjudicatedRed) or nameof(GameOutcome.AdjudicatedIron) => "timeout adjudication",
                nameof(GameOutcome.Draw) => "timeout draw",
                _ => "timeout",
            };
        }

        return result.State.Winner == PlayerId.Red
            ? result.Metrics.FinalIronShrinesBroken >= 3 ? "shrine break" : "decision"
            : result.Metrics.FinalRedShrinesBroken >= 3 ? "shrine break" : "decision";
    }

    private static string DescribeKeyIssue(SimulationResult result, IReadOnlyList<string> labels, string command)
    {
        if (labels.Contains("no-hardcast failure sample", StringComparer.OrdinalIgnoreCase))
        {
            return "no L2/L3, no legal evolve actions";
        }

        if (labels.Contains("highest Pierce game", StringComparer.OrdinalIgnoreCase))
        {
            return "Pierce damage produced the strongest blocked-attack spillover in the batch";
        }

        if (labels.Contains("highest reshuffle game", StringComparer.OrdinalIgnoreCase))
        {
            return "deck cycling outran closure and created the batch's heaviest reshuffle load";
        }

        if (labels.Contains("first L3 game", StringComparer.OrdinalIgnoreCase))
        {
            return "the batch reached L3 here earlier than anywhere else";
        }

        if (labels.Contains("longest game", StringComparer.OrdinalIgnoreCase))
        {
            return result.Metrics.Timeout ? "the game stalled into timeout" : "the game stretched unusually long before closing";
        }

        if (labels.Contains("fastest Iron win", StringComparer.OrdinalIgnoreCase))
        {
            return "Iron closed shrine pressure before Red could stabilize";
        }

        if (labels.Contains("fastest Red win", StringComparer.OrdinalIgnoreCase))
        {
            return "Red converted shrine pressure before Iron could race back";
        }

        return "the shrine race stayed narrow deep into the game";
    }

    private static string DescribeObservedLoop(SimulationResult result, IReadOnlyList<string> labels, string command)
    {
        if (labels.Contains("no-hardcast failure sample", StringComparer.OrdinalIgnoreCase))
        {
            return "units trade, Memory and reshuffles accumulate, but no transform window ever materializes";
        }

        if (labels.Contains("highest reshuffle game", StringComparer.OrdinalIgnoreCase))
        {
            return "both decks keep recycling through retain-1 turns while shrine damage advances slowly";
        }

        if (labels.Contains("highest Pierce game", StringComparer.OrdinalIgnoreCase))
        {
            return "blocked Shrine attacks still leak damage through Pierce and accelerate the finish";
        }

        if (labels.Contains("first L3 game", StringComparer.OrdinalIgnoreCase))
        {
            return "an L2 path opened, then converted into the earliest L3 spike in the batch";
        }

        if (labels.Contains("longest game", StringComparer.OrdinalIgnoreCase))
        {
            return "combat, blocking, and resource generation keep repeating without enough shrine closure";
        }

        if (labels.Contains("closest game", StringComparer.OrdinalIgnoreCase))
        {
            return "both players stayed in the shrine race until the final momentum swing";
        }

        return result.State.Winner == PlayerId.Red
            ? "Red found the cleaner pressure line and ended the game quickly"
            : "Iron found the cleaner pressure line and ended the game quickly";
    }

    private static string DescribeDesignMeaning(SimulationResult result, IReadOnlyList<string> labels, string command)
    {
        if (labels.Contains("no-hardcast failure sample", StringComparer.OrdinalIgnoreCase))
        {
            return "this batch still points at broken deed tracking or evolve generation under no-hardcast rules";
        }

        if (labels.Contains("highest Pierce game", StringComparer.OrdinalIgnoreCase))
        {
            return "Pierce is materially shaping blocked Shrine races instead of being cosmetic";
        }

        if (labels.Contains("highest reshuffle game", StringComparer.OrdinalIgnoreCase) || labels.Contains("longest game", StringComparer.OrdinalIgnoreCase))
        {
            return "the retain-1 loop can still create long deterministic grinds when shrine pressure is low";
        }

        if (labels.Contains("first L3 game", StringComparer.OrdinalIgnoreCase))
        {
            return "the full evolution ladder is reachable and worth surfacing in batch diagnostics";
        }

        if (labels.Contains("closest game", StringComparer.OrdinalIgnoreCase))
        {
            return "the current bots can produce a genuinely contested shrine race instead of a one-sided roll";
        }

        return "this sample is a good representative tempo check for the current bot matchup";
    }

    private static string DescribeNextAction(SimulationResult result, IReadOnlyList<string> labels, string command)
    {
        if (labels.Contains("no-hardcast failure sample", StringComparer.OrdinalIgnoreCase))
        {
            return "inspect deed persistence, legal evolve generation, and bot evolve priorities in the attached sample file";
        }

        if (labels.Contains("highest reshuffle game", StringComparer.OrdinalIgnoreCase) || labels.Contains("longest game", StringComparer.OrdinalIgnoreCase))
        {
            return "check whether shrine pressure heuristics or loop warnings need to be tightened";
        }

        if (labels.Contains("highest Pierce game", StringComparer.OrdinalIgnoreCase))
        {
            return "review whether Pierce pressure is landing in the intended range for blocked Shrine attacks";
        }

        if (labels.Contains("first L3 game", StringComparer.OrdinalIgnoreCase))
        {
            return "use this sample to verify that L2-to-L3 sequencing matches the intended deed model";
        }

        return "use this sample as a quick replay anchor before diving into the full game log";
    }

    private static string DescribeBattlefield(GameState state, IReadOnlyList<int> battlefield)
    {
        return battlefield.Count == 0
            ? "None"
            : string.Join(", ", battlefield.Select(id => state.Cards[id].Name));
    }

    private static string FormatShrineStates(IEnumerable<ShrineState> shrines)
    {
        return string.Join(", ", shrines.Select(x => $"{x.Name} {x.Damage}/{x.Vitality}"));
    }

    private static string FormatSnapshotShrineStates(TurnSnapshot? snapshot)
    {
        return snapshot is null || snapshot.ShrineDamage.Count == 0
            ? "None"
            : string.Join(", ", snapshot.ShrineDamage);
    }

    private static string FormatSnapshotResources(TurnSnapshot? snapshot)
    {
        return snapshot is null
            ? "None"
            : $"{snapshot.Offerings}/{snapshot.Memory}";
    }

    private static TurnSnapshot? GetLatestSnapshot(IReadOnlyList<TurnRecord> turns, PlayerId player)
    {
        return turns.LastOrDefault(turn => turn.Player == player)?.End
            ?? turns.LastOrDefault(turn => turn.Player == player)?.Start;
    }

    private static string GetDisplayGameId(SimulationResult result)
    {
        return result.State.GameId.StartsWith("game-", StringComparison.OrdinalIgnoreCase)
            ? result.State.GameId[5..]
            : result.State.GameId;
    }

    private static string GetHeadlineLabel(IReadOnlyList<string> labels)
    {
        var priority = new[]
        {
            "no-hardcast failure sample",
            "highest Pierce game",
            "highest reshuffle game",
            "first L3 game",
            "longest game",
            "fastest Red win",
            "fastest Iron win",
            "closest game",
        };

        return priority.FirstOrDefault(label => labels.Contains(label, StringComparer.OrdinalIgnoreCase)) ?? labels[0];
    }

    private static int GetReshuffleScore(SimulationResult result)
    {
        return Math.Max(result.Metrics.DeckReshufflesRed, result.Metrics.DeckReshufflesIron);
    }

    private static int GetPierceScore(SimulationResult result)
    {
        return result.Metrics.PierceOverflowEventsRed
            + result.Metrics.PierceOverflowEventsIron
            + result.Metrics.WeaponmasterPierceEvents
            + result.Metrics.SoulslayerPierceEvents
            + result.Metrics.LeopardHunterPierceEvents;
    }

    private static bool IsNoHardcastFailure(SimulationResult result)
    {
        var noL2OrL3 = result.Metrics.RedL2EnteredBattlefield
            + result.Metrics.RedL3EnteredBattlefield
            + result.Metrics.IronL2EnteredBattlefield
            + result.Metrics.IronL3EnteredBattlefield == 0;
        var noLegalEvolveActions = result.Metrics.LegalEvolveActionsGeneratedRed + result.Metrics.LegalEvolveActionsGeneratedIron == 0;
        return noL2OrL3 && noLegalEvolveActions;
    }

    private static string DescribeNullable(int? value)
    {
        return value?.ToString(CultureInfo.InvariantCulture) ?? "None";
    }

    private static string DescribeWinner(SimulationResult result)
    {
        return result.Metrics.Outcome switch
        {
            nameof(GameOutcome.Draw) => "Draw",
            nameof(GameOutcome.AdjudicatedRed) or nameof(GameOutcome.AdjudicatedIron) when !string.IsNullOrWhiteSpace(result.Metrics.AdjudicatedWinner)
                => $"{result.Metrics.AdjudicatedWinner} (adjudicated)",
            _ when !string.IsNullOrWhiteSpace(result.Metrics.Winner) => result.Metrics.Winner,
            _ => result.State.Winner == PlayerId.Red ? result.State.Red.Name : result.State.Iron.Name,
        };
    }

    private static string DescribeEndReason(GameMetrics metrics)
    {
        return string.IsNullOrWhiteSpace(metrics.EndReason) ? nameof(GameEndReason.None) : metrics.EndReason;
    }

    private static string DescribeOutcome(GameMetrics metrics)
    {
        return string.IsNullOrWhiteSpace(metrics.Outcome) ? nameof(GameOutcome.None) : metrics.Outcome;
    }

    private static string FormatAncestor(string ancestorDefinitionId)
    {
        return string.IsNullOrWhiteSpace(ancestorDefinitionId) ? "None" : ancestorDefinitionId;
    }

    private static string Slugify(string value)
    {
        var chars = value
            .ToLowerInvariant()
            .Select(ch => char.IsLetterOrDigit(ch) ? ch : '-')
            .ToArray();
        return string.Join(string.Empty, new string(chars).Split('-', StringSplitOptions.RemoveEmptyEntries));
    }

    private sealed record SampleDigest(SimulationResult Result, IReadOnlyList<string> Labels);

    private static string CreateCsv(IReadOnlyList<SimulationResult> results)
    {
        var builder = new StringBuilder();
        builder.AppendLine("game_id,seed,winner,loser,timeout,turn_count,phase_count,final_red_shrines_broken,final_iron_shrines_broken,first_shrine_damage_turn,first_shrine_break_turn,first_ancestor_awakened_turn,first_l2_turn,first_l3_turn,red_l2_entered_battlefield,red_l2_hard_cast,red_l2_evolved,red_l3_entered_battlefield,red_l3_hard_cast,red_l3_evolved,iron_l2_entered_battlefield,iron_l2_hard_cast,iron_l2_evolved,iron_l3_entered_battlefield,iron_l3_hard_cast,iron_l3_evolved,legal_evolve_actions_generated_red,legal_evolve_actions_generated_iron,evolve_actions_chosen_red,evolve_actions_chosen_iron,hard_cast_chosen_while_legal_evolve_action_exists_red,hard_cast_chosen_while_legal_evolve_action_exists_iron,hard_cast_chosen_while_evolution_base_exists_red,hard_cast_chosen_while_evolution_base_exists_iron,legal_awaken_actions_generated_red,legal_awaken_actions_generated_iron,awaken_actions_chosen_red,awaken_actions_chosen_iron,awaken_actions_skipped_while_legal_red,awaken_actions_skipped_while_legal_iron,first_awakened_ancestor_red,first_awakened_ancestor_iron,ancestor_switches_red,ancestor_switches_iron,memory_spent_on_ancestors_red,memory_spent_on_ancestors_iron,turns_with_awakened_ancestor_red,turns_with_awakened_ancestor_iron,first_hunter_bonus_damage,grandmother_healing_done,child_draw_discard_triggers,iron_hyena_ancestor_bonus_damage,smith_offering_discount_saved,tooth_mother_bonus_damage,legal_block_options_red,legal_block_options_iron,blocks_chosen_red,blocks_chosen_iron,blocks_declined_red,blocks_declined_iron,pack_units_ready_at_combat_start_red,pack_units_ready_at_combat_start_iron,pack_assault_slots_generated_red,pack_assault_slots_generated_iron,pack_assault_slots_available_red,pack_assault_slots_available_iron,pack_assault_slots_skipped_red,pack_assault_slots_skipped_iron,turns_with_pack_bonus_red,turns_with_pack_bonus_iron,max_attacks_available_this_combat_red,max_attacks_available_this_combat_iron,attacks_prevented_by_assault_limit_red,attacks_prevented_by_assault_limit_iron,prepared_tactics_triggered_red,prepared_tactics_triggered_iron,wounded_events_red,wounded_events_iron,pierce_overflow_events_red,pierce_overflow_events_iron,deck_reshuffles_red,deck_reshuffles_iron,first_shrine_damage_turn_red,first_shrine_damage_turn_iron,wins_in_odd_phase,winner_was_first_player_in_final_phase,shrine_damage_dealt_during_double_turn_red,shrine_damage_dealt_during_double_turn_iron");
        foreach (var result in results)
        {
            var m = result.Metrics;
            builder.AppendLine(string.Join(',',
                m.GameId,
                m.Seed.ToString(CultureInfo.InvariantCulture),
                Csv(m.Winner),
                Csv(m.Loser),
                m.Timeout.ToString(),
                m.TurnCount.ToString(CultureInfo.InvariantCulture),
                m.PhaseCount.ToString(CultureInfo.InvariantCulture),
                m.FinalRedShrinesBroken.ToString(CultureInfo.InvariantCulture),
                m.FinalIronShrinesBroken.ToString(CultureInfo.InvariantCulture),
                Nullable(m.FirstShrineDamageTurn),
                Nullable(m.FirstShrineBreakTurn),
                Nullable(m.FirstAncestorAwakenedTurn),
                Nullable(m.FirstL2Turn),
                Nullable(m.FirstL3Turn),
                m.RedL2EnteredBattlefield.ToString(CultureInfo.InvariantCulture),
                m.RedL2HardCast.ToString(CultureInfo.InvariantCulture),
                m.RedL2Evolved.ToString(CultureInfo.InvariantCulture),
                m.RedL3EnteredBattlefield.ToString(CultureInfo.InvariantCulture),
                m.RedL3HardCast.ToString(CultureInfo.InvariantCulture),
                m.RedL3Evolved.ToString(CultureInfo.InvariantCulture),
                m.IronL2EnteredBattlefield.ToString(CultureInfo.InvariantCulture),
                m.IronL2HardCast.ToString(CultureInfo.InvariantCulture),
                m.IronL2Evolved.ToString(CultureInfo.InvariantCulture),
                m.IronL3EnteredBattlefield.ToString(CultureInfo.InvariantCulture),
                m.IronL3HardCast.ToString(CultureInfo.InvariantCulture),
                m.IronL3Evolved.ToString(CultureInfo.InvariantCulture),
                m.LegalEvolveActionsGeneratedRed.ToString(CultureInfo.InvariantCulture),
                m.LegalEvolveActionsGeneratedIron.ToString(CultureInfo.InvariantCulture),
                m.EvolveActionsChosenRed.ToString(CultureInfo.InvariantCulture),
                m.EvolveActionsChosenIron.ToString(CultureInfo.InvariantCulture),
                m.HardCastChosenWhileLegalEvolveActionExistsRed.ToString(CultureInfo.InvariantCulture),
                m.HardCastChosenWhileLegalEvolveActionExistsIron.ToString(CultureInfo.InvariantCulture),
                m.HardCastChosenWhileEvolutionBaseExistsRed.ToString(CultureInfo.InvariantCulture),
                m.HardCastChosenWhileEvolutionBaseExistsIron.ToString(CultureInfo.InvariantCulture),
                m.LegalAwakenActionsGeneratedRed.ToString(CultureInfo.InvariantCulture),
                m.LegalAwakenActionsGeneratedIron.ToString(CultureInfo.InvariantCulture),
                m.AwakenActionsChosenRed.ToString(CultureInfo.InvariantCulture),
                m.AwakenActionsChosenIron.ToString(CultureInfo.InvariantCulture),
                m.AwakenActionsSkippedWhileLegalRed.ToString(CultureInfo.InvariantCulture),
                m.AwakenActionsSkippedWhileLegalIron.ToString(CultureInfo.InvariantCulture),
                Csv(m.FirstAwakenedAncestorRed),
                Csv(m.FirstAwakenedAncestorIron),
                m.AncestorSwitchesRed.ToString(CultureInfo.InvariantCulture),
                m.AncestorSwitchesIron.ToString(CultureInfo.InvariantCulture),
                m.MemorySpentOnAncestorsRed.ToString(CultureInfo.InvariantCulture),
                m.MemorySpentOnAncestorsIron.ToString(CultureInfo.InvariantCulture),
                m.TurnsWithAwakenedAncestorRed.ToString(CultureInfo.InvariantCulture),
                m.TurnsWithAwakenedAncestorIron.ToString(CultureInfo.InvariantCulture),
                m.FirstHunterBonusDamage.ToString(CultureInfo.InvariantCulture),
                m.GrandmotherHealingDone.ToString(CultureInfo.InvariantCulture),
                m.ChildDrawDiscardTriggers.ToString(CultureInfo.InvariantCulture),
                m.IronHyenaAncestorBonusDamage.ToString(CultureInfo.InvariantCulture),
                m.SmithOfferingDiscountSaved.ToString(CultureInfo.InvariantCulture),
                m.ToothMotherBonusDamage.ToString(CultureInfo.InvariantCulture),
                m.LegalBlockOptionsRed.ToString(CultureInfo.InvariantCulture),
                m.LegalBlockOptionsIron.ToString(CultureInfo.InvariantCulture),
                m.BlocksChosenRed.ToString(CultureInfo.InvariantCulture),
                m.BlocksChosenIron.ToString(CultureInfo.InvariantCulture),
                m.BlocksDeclinedRed.ToString(CultureInfo.InvariantCulture),
                m.BlocksDeclinedIron.ToString(CultureInfo.InvariantCulture),
                m.PackUnitsReadyAtCombatStartRed.ToString(CultureInfo.InvariantCulture),
                m.PackUnitsReadyAtCombatStartIron.ToString(CultureInfo.InvariantCulture),
                m.PackAssaultSlotsGeneratedRed.ToString(CultureInfo.InvariantCulture),
                m.PackAssaultSlotsGeneratedIron.ToString(CultureInfo.InvariantCulture),
                m.PackAssaultSlotsAvailableRed.ToString(CultureInfo.InvariantCulture),
                m.PackAssaultSlotsAvailableIron.ToString(CultureInfo.InvariantCulture),
                m.PackAssaultSlotsSkippedRed.ToString(CultureInfo.InvariantCulture),
                m.PackAssaultSlotsSkippedIron.ToString(CultureInfo.InvariantCulture),
                m.TurnsWithPackBonusRed.ToString(CultureInfo.InvariantCulture),
                m.TurnsWithPackBonusIron.ToString(CultureInfo.InvariantCulture),
                m.MaxAttacksAvailableThisCombatRed.ToString(CultureInfo.InvariantCulture),
                m.MaxAttacksAvailableThisCombatIron.ToString(CultureInfo.InvariantCulture),
                m.AttacksPreventedByAssaultLimitRed.ToString(CultureInfo.InvariantCulture),
                m.AttacksPreventedByAssaultLimitIron.ToString(CultureInfo.InvariantCulture),
                m.PreparedTacticsTriggeredRed.ToString(CultureInfo.InvariantCulture),
                m.PreparedTacticsTriggeredIron.ToString(CultureInfo.InvariantCulture),
                m.WoundedEventsRed.ToString(CultureInfo.InvariantCulture),
                m.WoundedEventsIron.ToString(CultureInfo.InvariantCulture),
                m.PierceOverflowEventsRed.ToString(CultureInfo.InvariantCulture),
                m.PierceOverflowEventsIron.ToString(CultureInfo.InvariantCulture),
                m.DeckReshufflesRed.ToString(CultureInfo.InvariantCulture),
                m.DeckReshufflesIron.ToString(CultureInfo.InvariantCulture),
                Nullable(m.FirstShrineDamageTurnRed),
                Nullable(m.FirstShrineDamageTurnIron),
                m.WinsInOddPhase.ToString(CultureInfo.InvariantCulture),
                m.WinnerWasFirstPlayerInFinalPhase.ToString(CultureInfo.InvariantCulture),
                m.ShrineDamageDealtDuringDoubleTurnRed.ToString(CultureInfo.InvariantCulture),
                m.ShrineDamageDealtDuringDoubleTurnIron.ToString(CultureInfo.InvariantCulture)));
        }

        return builder.ToString();
    }

    private static string Csv(string value)
    {
        return $"\"{value.Replace("\"", "\"\"")}\"";
    }

    private static string Nullable(int? value)
    {
        return value?.ToString(CultureInfo.InvariantCulture) ?? string.Empty;
    }
}
