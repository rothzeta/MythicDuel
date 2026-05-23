using System.Text;
using MythicDuel.Core.Cards;
using MythicDuel.Core.Models;

namespace MythicDuel.Core.Game;

public sealed class GameEngine
{
    private const int MaxTurns = 80;

    public SimulationResult Run(GameState state, IGameBot redBot, IGameBot ironBot)
    {
        StartGame(state);

        while (!state.IsGameOver && state.PlayerTurnCount < MaxTurns)
        {
            var player = state.GetPlayer(state.ActivePlayer);
            var activeBot = state.ActivePlayer == PlayerId.Red ? redBot : ironBot;
            var defendingBot = state.ActivePlayer == PlayerId.Red ? ironBot : redBot;
            ExecuteTurn(state, player, activeBot, defendingBot);

            if (state.IsGameOver)
            {
                break;
            }

            AdvanceTurnOrder(state);
        }

        if (!state.IsGameOver)
        {
            ResolveTimeout(state);
        }

        FinalizeMetrics(state);
        return new SimulationResult(state, state.Events, state.Metrics);
    }

    private void StartGame(GameState state)
    {
        for (var i = 0; i < 5; i++)
        {
            DrawOne(state, state.Red, "starting hand");
            DrawOne(state, state.Iron, "starting hand");
        }
    }

    public void ExecuteTurn(GameState state, PlayerState player, IGameBot bot, IGameBot opponentBot)
    {
        var opponent = state.GetOpponent(player.Id);
        player.TurnsTaken++;
        player.CurrentTurn.ResetForNewTurn();
        state.ActivePlayer = player.Id;
        var record = new TurnRecord
        {
            TurnNumber = state.TurnNumber,
            PhaseNumber = state.PhaseNumber,
            Player = player.Id,
            Start = CreateSnapshot(state, player),
        };
        state.Turns.Add(record);

        Log(state, player.Id, EventType.TurnStarted, $"Turn {state.TurnNumber} started for {player.Name}.");
        ReadyPhase(state, player);
        ResourcePhase(state, player);
        DrawPhase(state, player);
        InitializeCombatBudget(state, player, recordMetrics: false);

        var view = CreateViewFor(state, player.Id);
        var main1 = GetLegalMainActions(state, player, allowPrepared: true);
        RecordLegalEvolveMetrics(state, player.Id, main1);
        var attacks = GetLegalAttacks(state, player);
        var main2 = GetLegalMainActions(state, player, allowPrepared: true);
        RecordLegalEvolveMetrics(state, player.Id, main2);
        var awaken = GetLegalAwakenings(state, player);
        RecordLegalAwakenMetrics(state, player.Id, awaken);
        var decision = bot.ChooseTurn(view, player.Id, main1, attacks, main2, awaken);

        ExecuteActionList(state, player, bot, decision.Main1Actions, record.Main1Actions, "Main 1");
        ExecuteCombat(state, player, opponentBot, decision.Attacks, record);
        ExecuteActionList(state, player, bot, decision.Main2Actions, record.Main2Actions, "Main 2");
        ExecuteAwakenings(state, player, bot, record.Main2Actions);
        EndTurn(state, player, opponent, bot, record);

        record.End = CreateSnapshot(state, player);
        player.CurrentTurn.CloseTurn();
        CheckForWinner(state);
        Log(state, player.Id, EventType.TurnEnded, $"Turn {state.TurnNumber} ended for {player.Name}.");
    }

    private void ReadyPhase(GameState state, PlayerState player)
    {
        foreach (var cardId in player.Battlefield)
        {
            var card = state.Cards[cardId];
            if (card.HostId.HasValue)
            {
                continue;
            }

            card.IsExhausted = false;
        }
    }

    private void ResourcePhase(GameState state, PlayerState player)
    {
        player.MaxOfferings = Math.Min(8, player.TurnsTaken);
        player.CurrentOfferings = player.MaxOfferings;
    }

    private void DrawPhase(GameState state, PlayerState player)
    {
        while (player.Hand.Count < 5)
        {
            DrawOne(state, player, "draw phase");
            if (player.Deck.Count == 0 && player.Discard.Count == 0)
            {
                break;
            }
        }
    }

    private void ExecuteActionList(GameState state, PlayerState player, IGameBot bot, IReadOnlyList<PlayerAction> actions, List<string> logBucket, string phaseName)
    {
        var legalEvolutionActions = GetLegalEvolutionActions(state, player);
        var evolveAvailable = legalEvolutionActions.Count > 0;
        foreach (var action in actions)
        {
            if (state.IsGameOver)
            {
                return;
            }

            if (action is EvolveAction)
            {
                IncrementChosenEvolveMetric(state, player.Id);
            }
            else if (evolveAvailable && action is PlayUnitAction playUnit && (state.Cards[playUnit.CardId].HasTag("L2") || state.Cards[playUnit.CardId].HasTag("L3")))
            {
                IncrementHardCastChosenWhileLegalEvolveActionExistsMetric(state, player.Id);
            }
            else if (action is PlayUnitAction playEvolutionUnit && (state.Cards[playEvolutionUnit.CardId].HasTag("L2") || state.Cards[playEvolutionUnit.CardId].HasTag("L3")) && HasEvolutionBaseInPlay(state, player.Id, state.Cards[playEvolutionUnit.CardId]))
            {
                IncrementHardCastChosenWhileEvolutionBaseExistsMetric(state, player.Id);
            }

            var text = ExecuteAction(state, player, bot, action);
            if (!string.IsNullOrWhiteSpace(text))
            {
                logBucket.Add($"{phaseName}: {text}");
            }
        }
    }

    private void ExecuteAwakenings(GameState state, PlayerState player, IGameBot bot, List<string> logBucket)
    {
        var legalAwakenings = GetLegalAwakenings(state, player).OfType<AwakenAncestorAction>().ToList();
        RecordLegalAwakenMetrics(state, player.Id, legalAwakenings);
        if (legalAwakenings.Count == 0)
        {
            return;
        }

        var action = bot.ChooseAwakening(CreateViewFor(state, player.Id), player.Id, legalAwakenings);
        if (action is null || !legalAwakenings.Any(awaken => awaken.AncestorDefinitionId == action.AncestorDefinitionId))
        {
            IncrementSkippedAwakenMetric(state, player.Id);
            return;
        }

        IncrementChosenAwakenMetric(state, player.Id);
        var text = ExecuteAction(state, player, bot, action);
        if (!string.IsNullOrWhiteSpace(text))
        {
            logBucket.Add($"Main 2: {text}");
        }
    }

    private void ExecuteCombat(GameState state, PlayerState player, IGameBot defendingBot, IReadOnlyList<AttackDecision> attacks, TurnRecord record)
    {
        InitializeCombatBudget(state, player, recordMetrics: true);
        var legalAttacks = GetLegalAttacks(state, player).ToList();
        var requestedAttackCount = attacks.Count;
        foreach (var requestedAttack in attacks)
        {
            if (!HasAvailableAssaultSlot(player) || state.IsGameOver)
            {
                break;
            }

            var attack = legalAttacks.FirstOrDefault(x => x.AttackerId == requestedAttack.AttackerId && x.TargetType == requestedAttack.TargetType && x.TargetName == requestedAttack.TargetName && x.TargetUnitId == requestedAttack.TargetUnitId);
            if (attack is null)
            {
                continue;
            }

            ResolveAttack(state, player, defendingBot, attack, record);
            legalAttacks = GetLegalAttacks(state, player).ToList();
        }

        RecordSkippedPackSlots(state, player, legalAttacks, requestedAttackCount);
    }

    private void ResolveAttack(GameState state, PlayerState player, IGameBot defendingBot, AttackDecision attack, TurnRecord record)
    {
        var opponent = state.GetOpponent(player.Id);
        var attacker = state.Cards[attack.AttackerId];
        if (attacker.IsExhausted || attacker.Zone != Zone.Battlefield || attacker.HostId.HasValue)
        {
            return;
        }

        var attackRecord = new AttackRecord
        {
            Attacker = attacker.Name,
            Target = attack.TargetName,
        };
        record.Attacks.Add(attackRecord);
        attacker.IsExhausted = true;
        SpendAssaultSlot(state, player, attacker);
        Log(state, player.Id, EventType.AttackDeclared, $"{attacker.Name} attacks {attack.TargetName}.");
        IncrementAttacksMetric(state, player.Id, attack.TargetType == AttackTargetType.Shrine);

        CardInstance? defender = null;
        ShrineState? shrine = null;
        if (attack.TargetType == AttackTargetType.Shrine)
        {
            player.CurrentTurn.PlayerAttackedShrineThisTurn = true;
            player.CurrentTurn.PlayerSkippedShrineAttacksThisTurn = false;
            shrine = opponent.Shrines.First(x => x.Name == attack.TargetName);
            defender = ChooseBlocker(state, opponent, defendingBot, shrine, attacker);
            attackRecord.Defender = defender?.Name ?? "No blocker";

            if (player.AwakenedAncestorDefinitionId == CoreIds.Iron.AncestorIronHyena && !player.CurrentTurn.AncestorShrineBonusTriggeredThisTurn)
            {
                var otherShrine = opponent.Shrines.FirstOrDefault(x => x.Name != shrine.Name && !x.IsBroken) ?? shrine;
                ApplyShrineDamage(state, player, otherShrine, 1, $"Ancestor of the Iron Hyena deals 1 to {otherShrine.Name}.");
                state.Metrics.IronHyenaAncestorBonusDamage += 1;
                player.CurrentTurn.AncestorShrineBonusTriggeredThisTurn = true;
            }

            if (player.AwakenedAncestorDefinitionId == CoreIds.Iron.AncestorBoneSplitterMother && !player.CurrentTurn.BoneSplitterMotherBonusTriggeredThisTurn && attacker.IsWounded && attacker.HasKeyword(Keyword.Pack))
            {
                ApplyShrineDamage(state, player, shrine, 1, $"Bone-Splitter Mother deals 1 to {shrine.Name} on Wounded Pack Being attack.");
                player.CurrentTurn.BoneSplitterMotherBonusTriggeredThisTurn = true;
            }

            if (attacker.DefinitionId == CoreIds.Iron.BloodScentHyena && shrine.Damage > 0)
            {
                var otherShrine = opponent.Shrines.FirstOrDefault(x => x.Name != shrine.Name && !x.IsBroken) ?? shrine;
                ApplyShrineDamage(state, player, otherShrine, 1, $"Blood-Scent Hyena deals 1 to {otherShrine.Name} on attack.");
            }

            if (attacker.AttachedRelicId.HasValue && state.Cards.TryGetValue(attacker.AttachedRelicId.Value, out var relicCard) && relicCard.DefinitionId == CoreIds.Iron.FangRelic && shrine.Damage > 0)
            {
                var otherShrine = opponent.Shrines.FirstOrDefault(x => x.Name != shrine.Name && !x.IsBroken) ?? shrine;
                ApplyShrineDamage(state, player, otherShrine, 1, $"Fang Relic deals 1 to {otherShrine.Name} on attack.");
            }
        }
        else if (attack.TargetUnitId.HasValue && state.Cards.TryGetValue(attack.TargetUnitId.Value, out var directDefender))
        {
            defender = directDefender;
            attackRecord.Defender = defender.Name;
        }

        TriggerPreparedTacticsOnAttack(state, player, opponent, attacker, shrine, attackRecord);

        var attackerDamage = GetCombatAttack(state, attacker, attack.TargetType == AttackTargetType.Shrine, defender is not null, attackRecord);
        var defenderDamage = defender is null ? 0 : GetCombatAttack(state, defender, false, false, attackRecord);
        var attackerDamageOverflow = 0;

        if (defender is not null)
        {
            var defenderRemainingVitalityBeforeDamage = Math.Max(0, GetCurrentVitality(state, defender) - defender.Damage);
            ApplyUnitDamage(state, attacker, defenderDamage, defender.Name, attackRecord);
            ApplyUnitDamage(state, defender, attackerDamage, attacker.Name, attackRecord);
            var defenderDied = defender.Damage >= GetCurrentVitality(state, defender);
            var attackerDied = attacker.Damage >= GetCurrentVitality(state, attacker);
            attackerDamageOverflow = Math.Max(0, attackerDamage - defenderRemainingVitalityBeforeDamage);
            attackerDamage = 0;

            if (defenderDied)
            {
                DestroyUnit(state, defender, attacker.Controller, $"{defender.Name} died in combat.");
                player.CurrentTurn.UnitDestroyedEnemyThisTurn = true;
                player.CurrentTurn.UnitsThatDestroyedEnemyThisTurn.Add(attacker.Id);
                attacker.HasDestroyedEnemy = true;
                if (attacker.DefinitionId == CoreIds.Red.RiverHunter)
                {
                    GainMemory(state, player, 1, $"River Hunter destroyed an enemy.");
                }
            }

            if (!attackerDied)
            {
                player.CurrentTurn.UnitSurvivedCombatThisTurn = true;
                if (attacker.DefinitionId == CoreIds.Red.BaobabGuardian)
                {
                    RestoreShrine(state, player, ChooseMostDamagedShrine(player), 1, "Baobab Guardian survived combat.");
                }
            }
            else
            {
                DestroyUnit(state, attacker, defender.Controller, $"{attacker.Name} died in combat.");
            }
        }

        if (attack.TargetType == AttackTargetType.Shrine && shrine is not null)
        {
            var shrineDamage = defender is null ? attackerDamage : 0;

            if (defender is not null && shrineDamage == 0)
            {
                IncrementBlockedShrineMetric(state, player.Id);
            }

            if (defender is not null && attacker.DefinitionId == CoreIds.Iron.PackHarrier)
            {
                shrineDamage += 1;
                attackRecord.Calculations.Add("Pack Harrier deals 1 to blocked Shrine.");
            }

            if (defender is not null && player.AwakenedAncestorDefinitionId == CoreIds.Iron.AncestorFirstPack && !player.CurrentTurn.FirstPackAttackBlockedBonusTriggeredThisTurn && attacker.HasKeyword(Keyword.Pack))
            {
                shrineDamage += 1;
                player.CurrentTurn.FirstPackAttackBlockedBonusTriggeredThisTurn = true;
                attackRecord.Calculations.Add("Ancestor of the First Pack deals 1 to blocked Shrine.");
            }

            if (defender is not null && attackerDamageOverflow > 0 && HasPierce(state, attacker, true, attackRecord))
            {
                shrineDamage = attackerDamageOverflow;
                RecordPierceMetrics(state, player.Id, attackerDamageOverflow, attacker);
                attackRecord.Calculations.Add($"Pierce overflow deals {attackerDamageOverflow} to {shrine.Name}.");
            }

            if (shrineDamage > 0)
            {
                ApplyShrineDamage(
                    state,
                    player,
                    shrine,
                    shrineDamage,
                    $"{shrine.Name} takes {shrineDamage} damage.",
                    attackRecord,
                    attacker.Id,
                    creditUnitDamage: true,
                    countsAsShrineAttack: true);
            }
        }

        attackRecord.Result = BuildAttackResult(state, attacker, defender, shrine);
        CheckForWinner(state);
    }

    private static string BuildAttackResult(GameState state, CardInstance attacker, CardInstance? defender, ShrineState? shrine)
    {
        var builder = new StringBuilder();
        builder.Append(attacker.Zone == Zone.Battlefield ? $"{attacker.Name} survives" : $"{attacker.Name} left battle");
        if (defender is not null)
        {
            builder.Append(defender.Zone == Zone.Battlefield ? $", {defender.Name} survives" : $", {defender.Name} removed");
        }

        if (shrine is not null)
        {
            builder.Append($", {shrine.Name} at {Math.Max(0, shrine.Vitality - shrine.Damage)}/{shrine.Vitality}");
        }

        return builder.ToString();
    }

    private CardInstance? ChooseBlocker(GameState state, PlayerState defendingPlayer, IGameBot? defendingBot, ShrineState shrine, CardInstance attacker)
    {
        var activePlayer = state.GetPlayer(state.ActivePlayer);
        var blockers = defendingPlayer.Battlefield
            .Select(id => state.Cards[id])
            .Where(card => card.Zone == Zone.Battlefield && card.HostId is null && !card.IsExhausted && card.CardType is CardType.Being or CardType.Token)
            .ToList();

        if (state.Rules.Contains("single-block-per-combat", StringComparison.OrdinalIgnoreCase))
        {
            blockers = blockers.Where(card => !activePlayer.CurrentTurn.OpponentUnitsThatBlockedThisTurn.Contains(card.Id)).ToList();
        }

        if (blockers.Count == 0)
        {
            return null;
        }

        var attack = new AttackDecision(attacker.Id, AttackTargetType.Shrine, shrine.Name, ShrineName: shrine.Name);
        var legalBlocks = new List<BlockDecision> { new(null, shrine.Name, attacker.Id) };
        legalBlocks.AddRange(blockers
            .OrderByDescending(card => card.HasKeyword(Keyword.Guard))
            .ThenBy(card => card.Damage)
            .ThenBy(card => card.Name, StringComparer.Ordinal)
            .Select(card => new BlockDecision(card.Id, shrine.Name, attacker.Id)));
        IncrementLegalBlockOptionsMetric(state, defendingPlayer.Id, legalBlocks.Count - 1);

        var chosen = defendingBot?.ChooseBlock(CreateViewFor(state, defendingPlayer.Id), defendingPlayer.Id, attack, legalBlocks) ?? legalBlocks.First();
        if (chosen?.BlockerId is null)
        {
            IncrementDeclinedBlockMetric(state, defendingPlayer.Id);
            return null;
        }

        IncrementChosenBlockMetric(state, defendingPlayer.Id);

        var blocker = blockers.FirstOrDefault(card => card.Id == chosen.BlockerId.Value);
        if (blocker is not null)
        {
            activePlayer.CurrentTurn.OpponentUnitsThatBlockedThisTurn.Add(blocker.Id);
        }
        return blocker;
    }

    private int GetCombatAttack(GameState state, CardInstance unit, bool attackingShrine, bool blocked, AttackRecord attackRecord)
    {
        var value = unit.BaseAttack + GetAttackModifiers(state, unit, attackingShrine, blocked, attackRecord);
        if (unit.IsWounded)
        {
            var woundedValue = Math.Max(1, (int)Math.Floor(value * 0.75m));
            if (woundedValue < value)
            {
                var woundedMessage = $"Wounded reduces {unit.Name} from {value} to {woundedValue}.";
                if (!attackRecord.Calculations.Contains(woundedMessage, StringComparer.Ordinal))
                {
                    attackRecord.Calculations.Add(woundedMessage);
                }

                IncrementWoundedReductionMetric(state, unit.Controller);
            }

            value = woundedValue;
        }

        return Math.Max(1, value);
    }

    private int GetAttackModifiers(GameState state, CardInstance unit, bool attackingShrine, bool blocked, AttackRecord attackRecord)
    {
        var modifier = 0;
        var player = state.GetPlayer(unit.Controller);
        var opponent = state.GetOpponent(unit.Controller);

        if (unit.AttachedRelicId.HasValue && state.Cards.TryGetValue(unit.AttachedRelicId.Value, out var relic))
        {
            modifier += 1;
            if (relic.DefinitionId == CoreIds.Red.SpearOfFirstDawn && attackingShrine && unit.HasTag("Hunter"))
            {
                modifier += 2;
            }
        }

        if (unit.AttachedPossessionId.HasValue)
        {
            modifier += 2;
        }

        if (attackingShrine && unit.HasTag("Hunter") && player.Shrines.Any(x => x.DefinitionId == CoreIds.Red.ShrineRootStone && !x.IsBroken))
        {
            modifier += 1;
        }

        if (attackingShrine && player.AwakenedAncestorDefinitionId == CoreIds.Red.AncestorFirstHunter)
        {
            modifier += 1;
            state.Metrics.FirstHunterBonusDamage += 1;
        }

        if (attackingShrine && unit.DefinitionId == CoreIds.Iron.BoneCrackerCub && opponent.Shrines.Any(x => x.Damage > 0 && !x.IsBroken))
        {
            modifier += 1;
        }

        if (attackingShrine && player.Shrines.Any(x => x.DefinitionId == CoreIds.Iron.ShrineBoneFang && !x.IsBroken) && opponent.Shrines.Any(x => x.Damage > 0 && !x.IsBroken))
        {
            modifier += 1;
        }

        if (unit.IsWounded && player.AwakenedAncestorDefinitionId == CoreIds.Iron.AncestorToothMother)
        {
            modifier += 1;
            state.Metrics.ToothMotherBonusDamage += 1;
        }

        if (attackingShrine && unit.IsWounded && unit.HasKeyword(Keyword.Pack) && player.AwakenedAncestorDefinitionId == CoreIds.Iron.AncestorBoneSplitterMother)
        {
            modifier += 1;
        }

        var preparedHuntersCall = player.PreparedTacticIds
            .Select(id => state.Cards[id])
            .FirstOrDefault(card => card.DefinitionId == CoreIds.Red.HuntersCall);
        if (preparedHuntersCall is not null && unit.HasTag("Hunter") && player.CurrentTurn.HuntersThatAttackedThisTurn.Contains(unit.Id))
        {
            modifier += 1;
        }

        if (attackRecord.PreparedTriggers.Contains("Iron Snare"))
        {
            modifier -= 2;
        }

        return modifier;
    }

    private bool HasPierce(GameState state, CardInstance unit, bool attackingShrine, AttackRecord attackRecord)
    {
        var hasPierce = unit.HasKeyword(Keyword.Pierce);
        if (unit.DefinitionId == CoreIds.Red.LeopardHunter)
        {
            if (unit.AttachedRelicId.HasValue)
            {
                hasPierce = true;
                state.Metrics.WeaponmasterPierceEvents++;
                state.Metrics.LeopardHunterPierceEvents++;
                attackRecord.Calculations.Add("WeaponMaster grants Pierce.");
            }

            if (unit.AttachedPossessionId.HasValue)
            {
                hasPierce = true;
                state.Metrics.SoulslayerPierceEvents++;
                state.Metrics.LeopardHunterPierceEvents++;
                attackRecord.Calculations.Add("SoulSlayer grants Pierce.");
            }
        }

        if (unit.AttachedRelicId.HasValue && state.Cards.TryGetValue(unit.AttachedRelicId.Value, out var relic) && relic.DefinitionId == CoreIds.Iron.BoneSpear && attackingShrine)
        {
            var opponent = state.GetOpponent(unit.Controller);
            if (opponent.Shrines.Any(x => x.Damage > 0 && !x.IsBroken))
            {
                hasPierce = true;
                attackRecord.Calculations.Add("Bone Spear grants Pierce against damaged Shrine.");
            }
        }

        return hasPierce;
    }

    private void ApplyUnitDamage(GameState state, CardInstance target, int damage, string sourceName, AttackRecord attackRecord)
    {
        if (damage <= 0 || target.Zone != Zone.Battlefield)
        {
            return;
        }

        target.Damage += damage;
        attackRecord.DamageEvents.Add($"{sourceName} deals {damage} to {target.Name}.");
        Log(state, target.Controller, EventType.DamageDealt, $"{sourceName} deals {damage} to {target.Name}.");
        if (target.Damage < GetCurrentVitality(state, target))
        {
            target.IsWounded = true;
            var targetOwner = state.GetPlayer(target.Controller);
            targetOwner.CurrentTurn.UnitBecameWoundedThisTurn = true;
            target.WoundedClearsOnTurn = state.TurnNumber + (target.Controller == state.ActivePlayer ? 1 : 0);
            attackRecord.Calculations.Add($"{target.Name} becomes Wounded.");
            IncrementWoundedEventMetric(state, target.Controller);
        }
    }

    private bool ApplyShrineDamage(
        GameState state,
        PlayerState attackingPlayer,
        ShrineState shrine,
        int damage,
        string logMessage,
        AttackRecord? attackRecord = null,
        int? attackerId = null,
        bool creditUnitDamage = false,
        bool countsAsShrineAttack = false)
    {
        if (damage <= 0 || shrine.IsBroken)
        {
            return false;
        }

        var wasBroken = shrine.IsBroken;
        shrine.Damage += damage;
        attackRecord?.DamageEvents.Add($"Shrine {shrine.Name} takes {damage}.");
        Log(state, attackingPlayer.Id, EventType.ShrineDamaged, logMessage);
        if (creditUnitDamage && attackerId.HasValue)
        {
            attackingPlayer.CurrentTurn.UnitDamagedShrineThisTurn = true;
            attackingPlayer.CurrentTurn.UnitsThatDamagedShrineThisTurn.Add(attackerId.Value);
            if (state.Cards.TryGetValue(attackerId.Value, out var attacker))
            {
                attacker.HasDamagedShrine = true;
            }
        }

        state.Metrics.FirstShrineDamageTurn ??= state.TurnNumber;
        if (shrine.Owner == PlayerId.Red)
        {
            state.Metrics.FirstShrineDamageTurnRed ??= state.TurnNumber;
        }
        else
        {
            state.Metrics.FirstShrineDamageTurnIron ??= state.TurnNumber;
        }

        var strictAlternation = state.Rules.Contains("strict-alternation", StringComparison.OrdinalIgnoreCase);
        var phaseLength = 6; //state.Rules.Contains("phase-length-6", StringComparison.OrdinalIgnoreCase) ? 6 : 4;
        var isInDoubleTurn = !strictAlternation && 
            ((state.PlayerTurnCount % phaseLength == 0 && state.PlayerTurnCount > 0) || 
             (state.PlayerTurnCount % phaseLength == phaseLength - 1));
        if (isInDoubleTurn)
        {
            if (attackingPlayer.Id == PlayerId.Red)
            {
                state.Metrics.ShrineDamageDealtDuringDoubleTurnRed += damage;
            }
            else
            {
                state.Metrics.ShrineDamageDealtDuringDoubleTurnIron += damage;
            }
        }

        if (countsAsShrineAttack && attackingPlayer.Id == PlayerId.Iron && !attackingPlayer.CurrentTurn.FirstShrineAttackMemoryGrantedThisTurn && state.GetPlayer(PlayerId.Iron).Shrines.Any(x => x.DefinitionId == CoreIds.Iron.ShrineDen && !x.IsBroken))
        {
            GainMemory(state, attackingPlayer, 1, "Iron Hyena Den triggered.");
            attackingPlayer.CurrentTurn.FirstShrineAttackMemoryGrantedThisTurn = true;
        }


        if (!wasBroken && shrine.IsBroken)
        {
            if (creditUnitDamage && attackerId.HasValue)
            {
                attackingPlayer.CurrentTurn.UnitBrokeShrineThisTurn = true;
                attackingPlayer.CurrentTurn.UnitsThatBrokeShrineThisTurn.Add(attackerId.Value);
                if (state.Cards.TryGetValue(attackerId.Value, out var breakingAttacker))
                {
                    breakingAttacker.HasBrokenShrine = true;
                }
            }

            Log(state, attackingPlayer.Id, EventType.ShrineBroken, $"{shrine.Name} is broken.");
            state.Metrics.FirstShrineBreakTurn ??= state.TurnNumber;
            if (shrine.Owner == PlayerId.Red)
            {
                state.Metrics.FirstRedShrineBreakTurn ??= state.TurnNumber;
            }
            else
            {
                state.Metrics.FirstIronShrineBreakTurn ??= state.TurnNumber;
            }

            return true;
        }

        return false;
    }

    private void EndTurn(GameState state, PlayerState player, PlayerState opponent, IGameBot bot, TurnRecord record)
    {
        HandlePreparedExpiry(state, opponent, player);
        HandleMoonlitRoots(state, player);
        HandleGrandmother(state, player);
        ClearDamageAtEndOfTurn(state, player, opponent, record);
        HandleRetainDiscard(state, player, bot, record);
    }

    private void HandlePreparedExpiry(GameState state, PlayerState owner, PlayerState endingPlayer)
    {
        return;
    }

    private void HandleMoonlitRoots(GameState state, PlayerState player)
    {
        if (player.Id != PlayerId.Red)
        {
            return;
        }

        if (player.CurrentTurn.PlayerSkippedShrineAttacksThisTurn && player.Shrines.Any(x => x.DefinitionId == CoreIds.Red.ShrineMoonlitRoots && !x.IsBroken))
        {
            RestoreShrine(state, player, ChooseMostDamagedShrine(player), 1, "Moonlit Roots restored a Shrine.");
        }
    }

    private void HandleGrandmother(GameState state, PlayerState player)
    {
        if (player.AwakenedAncestorDefinitionId == CoreIds.Red.AncestorGrandmother)
        {
            var shrine = ChooseMostDamagedShrine(player);
            if (shrine is null)
            {
                return;
            }

            var damageBefore = shrine.Damage;
            RestoreShrine(state, player, shrine, 1, "Grandmother Beneath the Roots restored a Shrine.");
            state.Metrics.GrandmotherHealingDone += Math.Max(0, damageBefore - shrine.Damage);
        }
    }

    private void ClearDamageAtEndOfTurn(GameState state, PlayerState activePlayer, PlayerState opponent, TurnRecord record)
    {
        foreach (var unit in state.Cards.Values.Where(x => x.Zone == Zone.Battlefield && x.IsUnit))
        {
            unit.Damage = 0;
            if (unit.IsWounded && unit.WoundedClearsOnTurn.HasValue && activePlayer.Id == unit.Controller && unit.WoundedClearsOnTurn.Value <= state.TurnNumber)
            {
                unit.IsWounded = false;
                unit.WoundedClearsOnTurn = null;
                record.WoundedClears.Add(unit.Name);
            }
        }
    }

    private void HandleRetainDiscard(GameState state, PlayerState player, IGameBot bot, TurnRecord record)
    {
        if (player.Hand.Count == 0)
        {
            return;
        }

        var retained = bot.ChooseRetainedCard(CreateViewFor(state, player.Id), player.Id, player.Hand);
        int? retainCard = retained.HasValue && player.Hand.Contains(retained.Value) ? retained.Value : null;
        if (retainCard.HasValue)
        {
            record.RetainedCard = state.Cards[retainCard.Value].Name;
            Log(state, player.Id, EventType.CardRetained, $"{state.Cards[retainCard.Value].Name} retained.");
            IncrementRetainedMetric(state, player.Id);
        }

        var discards = player.Hand.Where(id => !retainCard.HasValue || id != retainCard.Value).ToList();
        foreach (var cardId in discards)
        {
            var card = state.Cards[cardId];
            player.Hand.Remove(cardId);
            player.Discard.Add(cardId);
            card.Zone = Zone.Discard;
            record.DiscardedCards.Add(card.Name);
            Log(state, player.Id, EventType.CardDiscarded, $"{card.Name} discarded at end step.");
            IncrementDiscardedMetric(state, player.Id);
        }

        player.Hand.Clear();
        if (retainCard.HasValue)
        {
            player.Hand.Add(retainCard.Value);
        }
    }

    private string ExecuteAction(GameState state, PlayerState player, IGameBot bot, PlayerAction action)
    {
        return action switch
        {
            PlayUnitAction playUnit => PlayUnit(state, player, playUnit.CardId),
            PlayPossessionAction playPossession => PlayPossession(state, player, playPossession.CardId, playPossession.HostId),
            PlayRelicAction playRelic => PlayRelic(state, player, playRelic.CardId, playRelic.HostId),
            PlayRiteAction playRite => PlayRite(state, player, playRite),
            PrepareTacticAction prepareTactic => PrepareTactic(state, player, bot, prepareTactic.CardId),
            EvolveAction evolve => Evolve(state, player, evolve.CardId, evolve.HostId, evolve.FromDiscard),
            AwakenAncestorAction awaken => AwakenAncestor(state, player, awaken.AncestorDefinitionId),
            _ => string.Empty,
        };
    }

    private string PlayUnit(GameState state, PlayerState player, int cardId)
    {
        if (!player.Hand.Contains(cardId))
        {
            return string.Empty;
        }

        var card = state.Cards[cardId];
        var definition = state.CardDefinitions[card.DefinitionId];
        if (!CanLegallyEnterBattlefieldByPlay(state, player, card))
        {
            return string.Empty;
        }

        if (!SpendResources(state, player, definition.OfferingCost, definition.MemoryCost, card.Name))
        {
            return string.Empty;
        }

        player.Hand.Remove(cardId);
        player.Battlefield.Add(cardId);
        card.Zone = Zone.Battlefield;
        card.EnteredBattlefieldOnTurn = state.TurnNumber;
        card.IsExhausted = !definition.CanAttackOnEnter;
        Log(state, player.Id, EventType.CardPlayed, $"{card.Name} entered the battlefield.");
        UpdateBattlefieldEntryMetrics(state, player.Id, card, enteredViaEvolution: false, recalledFromDiscard: false);

        if (card.DefinitionId == CoreIds.Iron.BlackToothSmith)
        {
            AutoAttachRelicFromHand(state, player, cardId);
        }

        return $"played {card.Name}";
    }

    private string PlayPossession(GameState state, PlayerState player, int cardId, int hostId)
    {
        if (!player.Hand.Contains(cardId) || !player.Battlefield.Contains(hostId))
        {
            return string.Empty;
        }

        var card = state.Cards[cardId];
        var host = state.Cards[hostId];
        var definition = state.CardDefinitions[card.DefinitionId];
        if (!SpendResources(state, player, definition.OfferingCost, definition.MemoryCost, card.Name))
        {
            return string.Empty;
        }

        if (host.AttachedPossessionId.HasValue && state.Cards.TryGetValue(host.AttachedPossessionId.Value, out var priorPossession))
        {
            DisperseSpirit(state, priorPossession, player.Id, "second Possession displaced it");
        }

        player.Hand.Remove(cardId);
        player.Battlefield.Add(cardId);
        card.Zone = Zone.Battlefield;
        card.HostId = hostId;
        card.IsExhausted = true;
        host.AttachedPossessionId = cardId;
        Log(state, player.Id, EventType.CardPlayed, $"{card.Name} possessed {host.Name}.");
        return $"attached {card.Name} to {host.Name}";
    }

    private string PlayRelic(GameState state, PlayerState player, int cardId, int hostId)
    {
        if (!player.Hand.Contains(cardId) || !player.Battlefield.Contains(hostId))
        {
            return string.Empty;
        }

        var card = state.Cards[cardId];
        var host = state.Cards[hostId];
        var definition = state.CardDefinitions[card.DefinitionId];
        var originalOfferingCost = definition.OfferingCost;
        var offeringCost = definition.OfferingCost;
        if (player.AwakenedAncestorDefinitionId == CoreIds.Iron.AncestorSmith)
        {
            offeringCost = Math.Max(0, offeringCost - 1);
            state.Metrics.SmithOfferingDiscountSaved += originalOfferingCost - offeringCost;
        }

        if (player.AwakenedAncestorDefinitionId == CoreIds.Iron.AncestorSmithPassedFang && !player.CurrentTurn.PlayedRelicThisTurn)
        {
            offeringCost = Math.Max(0, offeringCost - 1);
            state.Metrics.SmithOfferingDiscountSaved += originalOfferingCost - offeringCost;
        }

        if (!SpendResources(state, player, offeringCost, definition.MemoryCost, card.Name))
        {
            return string.Empty;
        }

        player.CurrentTurn.PlayedRelicThisTurn = true;
        player.Hand.Remove(cardId);
        player.Battlefield.Add(cardId);
        card.Zone = Zone.Attached;
        card.HostId = hostId;
        host.AttachedRelicId = cardId;
        Log(state, player.Id, EventType.CardPlayed, $"{card.Name} attached to {host.Name}.");
        return $"attached {card.Name} to {host.Name}";
    }

    private string PlayRite(GameState state, PlayerState player, PlayRiteAction action)
    {
        if (!player.Hand.Contains(action.CardId))
        {
            return string.Empty;
        }

        var card = state.Cards[action.CardId];
        var definition = state.CardDefinitions[card.DefinitionId];
        var extraMemory = card.DefinitionId == CoreIds.Red.OfferingOfMilkAndAsh && player.CurrentTurn.PlayerAttackedShrineThisTurn ? 1 : 0;
        if (!SpendResources(state, player, definition.OfferingCost, definition.MemoryCost + extraMemory, card.Name))
        {
            return string.Empty;
        }

        player.Hand.Remove(action.CardId);
        Log(state, player.Id, EventType.CardPlayed, $"{card.Name} resolved.");
        var resolutionSummary = ResolveRite(state, player, card, action);
        MoveResolvedCard(state, player, card, card.HasKeyword(Keyword.Fade), "rite resolved");
        return string.IsNullOrWhiteSpace(resolutionSummary)
            ? $"resolved {card.Name}"
            : $"resolved {card.Name} ({resolutionSummary})";
    }

    private string PrepareTactic(GameState state, PlayerState player, IGameBot bot, int cardId)
    {
        if (!player.Hand.Contains(cardId))
        {
            return string.Empty;
        }

        var card = state.Cards[cardId];
        var definition = state.CardDefinitions[card.DefinitionId];
        if (!SpendResources(state, player, definition.OfferingCost, definition.MemoryCost, card.Name))
        {
            return string.Empty;
        }

        string? replacementSummary = null;
        if (player.PreparedTacticIds.Count >= 2)
        {
            var replacementId = bot.ChoosePreparedReplacement(CreateViewFor(state, player.Id), player.Id, player.PreparedTacticIds.ToList(), cardId);
            if (!replacementId.HasValue || !player.PreparedTacticIds.Contains(replacementId.Value))
            {
                return string.Empty;
            }

            replacementSummary = ReplacePreparedTactic(state, player, replacementId.Value, card.Name);
        }

        player.Hand.Remove(cardId);
        player.PreparedTacticIds.Add(cardId);
        card.Zone = Zone.Prepared;
        card.PreparedOnTurn = player.TurnsTaken;
        card.PreparedExpiresAfterTurn = state.GetOpponent(player.Id).TurnsTaken + 1;
        Log(state, player.Id, EventType.TacticPrepared, $"{card.Name} was prepared.");
        IncrementPreparedPreparedMetric(state, player.Id);
        return string.IsNullOrWhiteSpace(replacementSummary)
            ? $"prepared {card.Name}"
            : $"prepared {card.Name} ({replacementSummary})";
    }

    private string Evolve(GameState state, PlayerState player, int cardId, int hostId, bool fromDiscard)
    {
        var source = fromDiscard ? player.Discard : player.Hand;
        if (!source.Contains(cardId) || !player.Battlefield.Contains(hostId))
        {
            return string.Empty;
        }

        var evolvedCard = state.Cards[cardId];
        var host = state.Cards[hostId];
        var definition = state.CardDefinitions[evolvedCard.DefinitionId];
        if (!CanLegallyEnterBattlefieldByEvolution(state, player, evolvedCard))
        {
            return string.Empty;
        }

        var memoryCost = definition.EvolveMemoryCost + (fromDiscard ? definition.RecallMemoryCost : 0);
        if (!SpendResources(state, player, definition.EvolveOfferingCost, memoryCost, evolvedCard.Name))
        {
            return string.Empty;
        }

        source.Remove(cardId);
        player.Battlefield.Remove(hostId);
        player.Battlefield.Add(cardId);
        evolvedCard.Zone = Zone.Battlefield;
        evolvedCard.Damage = host.Damage;
        evolvedCard.EnteredBattlefieldOnTurn = state.TurnNumber;
        evolvedCard.IsExhausted = false;
        evolvedCard.AttachedRelicId = host.AttachedRelicId;
        evolvedCard.AttachedPossessionId = host.AttachedPossessionId;
        evolvedCard.HasDestroyedEnemy = host.HasDestroyedEnemy;
        evolvedCard.HasDamagedShrine = host.HasDamagedShrine;
        evolvedCard.HasBrokenShrine = host.HasBrokenShrine;
        if (host.AttachedRelicId.HasValue)
        {
            state.Cards[host.AttachedRelicId.Value].HostId = cardId;
        }

        if (host.AttachedPossessionId.HasValue)
        {
            state.Cards[host.AttachedPossessionId.Value].HostId = cardId;
        }

        MoveConsumedEvolutionHost(state, player, host, evolvedCard.Name);
        Log(state, player.Id, EventType.UnitEvolved, $"{host.Name} evolved into {evolvedCard.Name}.");
        UpdateBattlefieldEntryMetrics(state, player.Id, evolvedCard, enteredViaEvolution: true, recalledFromDiscard: fromDiscard);
        TriggerPreparedTacticsOnEvolution(state, player, evolvedCard);
        var resolutionNotes = new List<string>();

        if (evolvedCard.DefinitionId == CoreIds.Red.KumaWhoWoundedTheSun)
        {
            var shrine = ChooseBestEnemyShrine(state.GetOpponent(player.Id));
            if (shrine is not null)
            {
                var brokeShrine = ApplyShrineDamage(state, player, shrine, 3, $"Kuma deals 3 damage to {shrine.Name} on evolve.");
                resolutionNotes.Add($"dealt 3 to {shrine.Name}{(brokeShrine ? " and broke it" : string.Empty)}");
            }
        }
        else if (evolvedCard.DefinitionId == CoreIds.Iron.IronHyenaChampion)
        {
            var shrine = ChooseBestEnemyShrine(state.GetOpponent(player.Id));
            if (shrine is not null)
            {
                var brokeShrine = ApplyShrineDamage(state, player, shrine, 2, $"Iron Hyena Champion deals 2 damage to {shrine.Name} on evolve.");
                resolutionNotes.Add($"dealt 2 to {shrine.Name}{(brokeShrine ? " and broke it" : string.Empty)}");
            }
        }
        else if (evolvedCard.DefinitionId == CoreIds.Iron.IronHyenaUnderworld)
        {
            foreach (var shrine in state.GetOpponent(player.Id).Shrines.Where(x => !x.IsBroken))
            {
                var brokeShrine = ApplyShrineDamage(state, player, shrine, 2, $"Iron Hyena Underworld deals 2 damage to {shrine.Name} on evolve.");
                resolutionNotes.Add($"dealt 2 to {shrine.Name}{(brokeShrine ? " and broke it" : string.Empty)}");
            }
        }

        return resolutionNotes.Count == 0
            ? $"evolved {host.Name} into {evolvedCard.Name}"
            : $"evolved {host.Name} into {evolvedCard.Name} ({string.Join("; ", resolutionNotes)})";
    }

    private string ReplacePreparedTactic(GameState state, PlayerState owner, int replacedPreparedId, string incomingTacticName)
    {
        if (!state.Cards.TryGetValue(replacedPreparedId, out var replaced) || !owner.PreparedTacticIds.Contains(replacedPreparedId))
        {
            return string.Empty;
        }

        owner.PreparedTacticIds.Remove(replacedPreparedId);
        owner.Forgotten.Add(replacedPreparedId);
        replaced.Zone = Zone.Forgotten;
        replaced.RevealedPreparedTactic = false;
        Log(state, owner.Id, EventType.CardForgotten, $"{replaced.Name} was replaced by {incomingTacticName} and moved to Forgotten.");
        IncrementForgottenMetric(state, owner.Id);
        return $"replaced {replaced.Name}";
    }

    private string AwakenAncestor(GameState state, PlayerState player, string ancestorDefinitionId)
    {
        if (player.AwakenedAncestorDefinitionId == ancestorDefinitionId || player.Memory < 2)
        {
            return string.Empty;
        }

        var ancestor = player.Lineage.FirstOrDefault(x => x.DefinitionId == ancestorDefinitionId);
        if (ancestor is null)
        {
            return string.Empty;
        }

        foreach (var lineage in player.Lineage)
        {
            lineage.IsAwakened = false;
        }

        RecordAncestorAwakened(state, player, ancestorDefinitionId);
        ancestor.IsAwakened = true;
        player.AwakenedAncestorDefinitionId = ancestorDefinitionId;
        SpendMemory(state, player, 2, $"Awakened {ancestor.Name}");
        Log(state, player.Id, EventType.AncestorAwakened, $"{ancestor.Name} awakened.");
        state.Metrics.FirstAncestorAwakenedTurn ??= state.TurnNumber;
        return $"awakened {ancestor.Name}";
    }

    private string ResolveRite(GameState state, PlayerState player, CardInstance card, PlayRiteAction action)
    {
        switch (card.DefinitionId)
        {
            case var id when id == CoreIds.Red.RitualOfRedMoon:
            {
                var target = ChooseEnemyUnitForDamage(state, player);
                if (target is not null)
                {
                    ApplyUnitDamage(state, target, 2, card.Name, new AttackRecord());
                    if (target.Damage >= GetCurrentVitality(state, target))
                    {
                        DestroyUnit(state, target, player.Id, $"{target.Name} died from Ritual of Red Moon.");
                        GainMemory(state, player, 1, "Ritual of Red Moon gained Memory.");
                        return $"dealt 2 to {target.Name}, destroyed it, gained 1 Memory";
                    }

                    return $"dealt 2 to {target.Name}";
                }

                return "had no legal target";
            }
            case var id when id == CoreIds.Red.OfferingOfMilkAndAsh:
            {
                var shrine = ChooseMostDamagedShrine(player);
                if (shrine is null)
                {
                    return "had no damaged shrine to restore";
                }

                var restored = Math.Min(3, shrine.Damage);
                RestoreShrine(state, player, shrine, 3, "Offering of Milk and Ash.");
                return $"restored {restored} to {shrine.Name}";
            }
            case var id when id == CoreIds.Iron.BiteTheRoots:
            {
                var shrine = ChooseBestEnemyShrine(state.GetOpponent(player.Id));
                if (shrine is not null)
                {
                    if (ApplyShrineDamage(state, player, shrine, 3, $"Bite the Roots deals 3 to {shrine.Name}."))
                    {
                        GainMemory(state, player, 1, "Bite the Roots broke a Shrine.");
                        return $"dealt 3 to {shrine.Name}, broke it, gained 1 Memory";
                    }

                    return $"dealt 3 to {shrine.Name}";
                }

                return "had no legal shrine target";
            }
            case var id when id == CoreIds.Iron.PackAmbush:
            {
                SummonToken(state, player, CoreIds.Iron.HyenaToken);
                var packCount = player.Battlefield
                    .Select(x => state.Cards[x])
                    .Count(c => c.HasKeyword(Keyword.Pack) && c.CardType is CardType.Being or CardType.Token);
                if (packCount >= 2)
                {
                    var opponent = state.GetOpponent(player.Id);
                    var targetShrine = ChooseBestEnemyShrine(opponent);
                    if (targetShrine is not null)
                    {
                        ApplyShrineDamage(state, player, targetShrine, 1, "Pack Ambush deals 1 to Shrine.", null, null);
                        return "summoned Hyena Token and dealt 1 to Shrine";
                    }
                }
                return "summoned Hyena Token";
            }
            case var id when id == CoreIds.Iron.HyenaPackCall:
            {
                for (var i = 0; i < 2; i++)
                {
                    SummonToken(state, player, CoreIds.Iron.HyenaToken);
                }
                return "summoned 2 Hyena Tokens";
            }
        }

        return string.Empty;
    }

    private void TriggerPreparedTacticsOnAttack(GameState state, PlayerState attackerPlayer, PlayerState defenderPlayer, CardInstance attacker, ShrineState? shrine, AttackRecord attackRecord)
    {
        attackerPlayer.CurrentTurn.HuntersThatAttackedThisTurn.Add(attacker.Id);

        foreach (var preparedId in attackerPlayer.PreparedTacticIds.ToList())
        {
            var tactic = state.Cards[preparedId];
            if (tactic.DefinitionId == CoreIds.Red.HuntersCall && attacker.HasTag("Hunter"))
            {
                RevealPrepared(state, attackerPlayer, tactic, $"{tactic.Name} triggered on Hunter attack.");
                attackRecord.PreparedTriggers.Add(tactic.Name);
            }
        }

        foreach (var preparedId in defenderPlayer.PreparedTacticIds.ToList())
        {
            var tactic = state.Cards[preparedId];
            if (tactic.DefinitionId == CoreIds.Red.RootWovenGuard && shrine is not null)
            {
                RevealPrepared(state, defenderPlayer, tactic, $"{tactic.Name} triggered to protect {shrine.Name}.");
                attackRecord.PreparedTriggers.Add(tactic.Name);
            }
            else if (tactic.DefinitionId == CoreIds.Iron.IronSnare && GetCombatAttack(state, attacker, shrine is not null, false, attackRecord) >= 3)
            {
                RevealPrepared(state, defenderPlayer, tactic, $"{tactic.Name} triggered on big attacker.");
                attackRecord.PreparedTriggers.Add(tactic.Name);
                if (attacker.AttachedPossessionId.HasValue && state.Cards.TryGetValue(attacker.AttachedPossessionId.Value, out var possession))
                {
                    DisperseSpirit(state, possession, defenderPlayer.Id, "Iron Snare dispersed the Possession");
                }
            }
        }
    }

    private void TriggerPreparedTacticsOnEvolution(GameState state, PlayerState evolvingPlayer, CardInstance evolvedCard)
    {
        var opponent = state.GetOpponent(evolvingPlayer.Id);
        foreach (var preparedId in opponent.PreparedTacticIds.ToList())
        {
            var tactic = state.Cards[preparedId];
            if (tactic.DefinitionId != CoreIds.Iron.FalseOpening)
            {
                continue;
            }

            RevealPrepared(state, opponent, tactic, $"False Opening triggered on {evolvedCard.Name}.");
            ApplyUnitDamage(state, evolvedCard, 3, tactic.Name, new AttackRecord());
            if (evolvedCard.Damage >= GetCurrentVitality(state, evolvedCard))
            {
                DestroyUnit(state, evolvedCard, opponent.Id, $"{evolvedCard.Name} died to False Opening.");
            }

            break;
        }
    }

    private void RevealPrepared(GameState state, PlayerState owner, CardInstance tactic, string message)
    {
        tactic.RevealedPreparedTactic = true;
        owner.PreparedTacticIds.Remove(tactic.Id);
        Log(state, owner.Id, EventType.PreparedTacticTriggered, message);
        IncrementPreparedTriggeredMetric(state, owner.Id);

        if (tactic.DefinitionId == CoreIds.Red.RootWovenGuard)
        {
            IncrementFadeTriggeredMetric(state, owner.Id);
        }

        MoveResolvedCard(state, owner, tactic, tactic.HasKeyword(Keyword.Fade), "prepared tactic triggered");
    }

    private void MoveResolvedCard(GameState state, PlayerState owner, CardInstance card, bool toForgotten, string reason)
    {
        owner.Hand.Remove(card.Id);
        owner.Battlefield.Remove(card.Id);
        owner.Discard.Remove(card.Id);
        owner.PreparedTacticIds.Remove(card.Id);

        if (toForgotten)
        {
            owner.Forgotten.Add(card.Id);
            card.Zone = Zone.Forgotten;
            Log(state, owner.Id, EventType.CardForgotten, $"{card.Name} moved to Forgotten ({reason}).");
            IncrementForgottenMetric(state, owner.Id);
            IncrementFadeResolvedMetric(state, owner.Id);
        }
        else
        {
            owner.Discard.Add(card.Id);
            card.Zone = Zone.Discard;
        }
    }

    private void MoveRemovedBattlefieldCard(GameState state, PlayerState owner, CardInstance card, string reason)
    {
        owner.Battlefield.Remove(card.Id);
        owner.Discard.Remove(card.Id);
        owner.Forgotten.Remove(card.Id);

        if (IsMythicL3(card))
        {
            owner.Forgotten.Add(card.Id);
            card.Zone = Zone.Forgotten;
            Log(state, owner.Id, EventType.CardForgotten, $"{card.Name} moved to Forgotten ({reason}).");
            IncrementForgottenMetric(state, owner.Id);
            return;
        }

        owner.Discard.Add(card.Id);
        card.Zone = Zone.Discard;
    }

    private void RestoreShrine(GameState state, PlayerState player, ShrineState? shrine, int amount, string reason)
    {
        if (shrine is null || amount <= 0)
        {
            return;
        }

        shrine.Damage = Math.Max(0, shrine.Damage - amount);
        player.CurrentTurn.ShrineRestoredThisTurn = true;
        Log(state, player.Id, EventType.ShrineRestored, $"{shrine.Name} restored by {amount} ({reason}).");
    }

    private void DestroyUnit(GameState state, CardInstance unit, PlayerId opposingController, string reason)
    {
        var owner = state.GetPlayer(unit.Controller);
        owner.Battlefield.Remove(unit.Id);

        if (unit.AttachedPossessionId.HasValue && state.Cards.TryGetValue(unit.AttachedPossessionId.Value, out var possession))
        {
            DisperseSpirit(state, possession, opposingController, "host died");
            unit.AttachedPossessionId = null;
        }

        if (unit.AttachedRelicId.HasValue && state.Cards.TryGetValue(unit.AttachedRelicId.Value, out var relic))
        {
            var moved = false;
            if (owner.AwakenedAncestorDefinitionId == CoreIds.Iron.AncestorSmithPassedFang && unit.HasKeyword(Keyword.Pack))
            {
                var candidate = owner.Battlefield
                    .Select(id => state.Cards[id])
                    .FirstOrDefault(card => card.Id != unit.Id && card.Zone == Zone.Battlefield && card.HostId is null && card.HasKeyword(Keyword.Pack) && !card.IsExhausted && card.AttachedRelicId is null && (card.CardType is CardType.Being or CardType.Token));
                
                if (candidate is not null)
                {
                    unit.AttachedRelicId = null;
                    relic.HostId = candidate.Id;
                    candidate.AttachedRelicId = relic.Id;
                    Log(state, owner.Id, EventType.CardPlayed, $"Relic {relic.Name} moved to {candidate.Name} because host {unit.Name} died.");
                    moved = true;
                }
            }

            if (!moved)
            {
                relic.HostId = null;
                owner.Battlefield.Remove(relic.Id);
                owner.Forgotten.Remove(relic.Id);
                owner.Discard.Add(relic.Id);
                relic.Zone = Zone.Discard;
                unit.AttachedRelicId = null;
            }
        }

        if (unit.CardType == CardType.Spirit && unit.HasKeyword(Keyword.Disperse))
        {
            DisperseSpirit(state, unit, opposingController, reason);
            return;
        }

        MoveRemovedBattlefieldCard(state, owner, unit, reason);
        Log(state, unit.Controller, EventType.UnitDied, reason);
        IncrementUnitKilledMetric(state, opposingController);

        if (unit.CardType == CardType.Being && !owner.CurrentTurn.FirstBeingDeathMemoryGrantedThisTurn && owner.Shrines.Any(x => x.DefinitionId == CoreIds.Red.ShrineRedBaobab && !x.IsBroken))
        {
            GainMemory(state, owner, 1, "Shrine of the Red Baobab triggered.");
            owner.CurrentTurn.FirstBeingDeathMemoryGrantedThisTurn = true;
        }
    }

    private void DisperseSpirit(GameState state, CardInstance spirit, PlayerId sourcePlayer, string reason)
    {
        var owner = state.GetPlayer(spirit.Controller);
        MoveRemovedBattlefieldCard(state, owner, spirit, reason);
        spirit.HostId = null;
        owner.CurrentTurn.SpiritDispersedThisTurn = true;
        GainMemory(state, owner, 1, $"{spirit.Name} dispersed.");
        Log(state, owner.Id, EventType.SpiritDispersed, $"{spirit.Name} dispersed because {reason}.");
        IncrementSpiritDispersedMetric(state, owner.Id);
        IncrementUnitKilledMetric(state, sourcePlayer);

        if (spirit.DefinitionId == CoreIds.Red.PaleRiverSpirit)
        {
            GainMemory(state, owner, 1, "Pale River Spirit granted extra Memory.");
        }
        else if (spirit.DefinitionId == CoreIds.Red.DeepRiverSpirit)
        {
            RestoreShrine(state, owner, ChooseMostDamagedShrine(owner), 2, "Deep River Spirit dispersed.");
        }
        else if (spirit.DefinitionId == CoreIds.Iron.RustHyenaSpirit)
        {
            var shrine = ChooseBestEnemyShrine(state.GetOpponent(owner.Id));
            if (shrine is not null)
            {
                ApplyShrineDamage(state, owner, shrine, 1, $"Rust Hyena Spirit deals 1 to {shrine.Name} on disperse.");
            }
        }

        var enemy = state.GetOpponent(owner.Id);
        if (enemy.Shrines.Any(x => x.DefinitionId == CoreIds.Iron.ShrineRustedMoon && !x.IsBroken))
        {
            var shrine = ChooseBestEnemyShrine(owner);
            if (shrine is not null)
            {
                ApplyShrineDamage(state, enemy, shrine, 1, $"Rusted Moon Shrine deals 1 to {shrine.Name} after enemy Spirit dispersed.");
            }
        }
    }

    private bool SummonToken(GameState state, PlayerState player, string definitionId)
    {
        var definition = state.CardDefinitions[definitionId];
        if (WouldExceedPresenceLimit(state, player, definition.PresenceCost))
        {
            return false;
        }

        var id = state.NextCardInstanceId++;
        var token = new CardInstance
        {
            Id = id,
            DefinitionId = definition.Id,
            Name = definition.Name,
            Owner = player.Id,
            Controller = player.Id,
            CardType = definition.CardType,
            Zone = Zone.Battlefield,
            Tags = definition.Tags,
            BaseKeywords = definition.Keywords,
            BaseAttack = definition.Attack,
            BaseVitality = definition.Vitality,
            EnteredBattlefieldOnTurn = state.TurnNumber,
            IsToken = true,
            IsExhausted = true,
        };
        state.Cards[id] = token;
        player.Battlefield.Add(id);
        return true;
    }

    private void AutoAttachRelicFromHand(GameState state, PlayerState player, int smithId)
    {
        var relicId = player.Hand
            .Select(id => state.Cards[id])
            .Where(card => card.CardType == CardType.Relic)
            .OrderBy(card => card.Name, StringComparer.Ordinal)
            .Select(card => card.Id)
            .FirstOrDefault();

        if (relicId == 0)
        {
            return;
        }

        var hostId = player.Battlefield
            .Select(id => state.Cards[id])
            .Where(card => card.IsUnit && card.HostId is null)
            .OrderByDescending(card => card.Id == smithId)
            .ThenBy(card => card.Name, StringComparer.Ordinal)
            .Select(card => card.Id)
            .First();

        var relic = state.Cards[relicId];
        var offeringCost = Math.Max(0, state.CardDefinitions[relic.DefinitionId].OfferingCost - 1);
        if (!SpendResources(state, player, offeringCost, 0, relic.Name))
        {
            return;
        }

        player.Hand.Remove(relicId);
        player.Battlefield.Add(relicId);
        relic.Zone = Zone.Attached;
        relic.HostId = hostId;
        state.Cards[hostId].AttachedRelicId = relicId;
        Log(state, player.Id, EventType.CardPlayed, $"{relic.Name} attached by Black-Tooth Smith.");
    }

    private IReadOnlyList<PlayerAction> GetLegalMainActions(GameState state, PlayerState player, bool allowPrepared)
    {
        var actions = new List<PlayerAction>();
        foreach (var cardId in player.Hand)
        {
            var card = state.Cards[cardId];
            switch (card.CardType)
            {
                case CardType.Being:
                case CardType.Spirit when !card.HasKeyword(Keyword.Possession):
                    if (CanAfford(state, player, cardId) && !ShouldForbidHardCastEvolutionCard(state, card) && CanLegallyEnterBattlefieldByPlay(state, player, card))
                    {
                        actions.Add(new PlayUnitAction(cardId));
                    }
                    break;
                case CardType.Spirit when card.HasKeyword(Keyword.Possession):
                    foreach (var hostId in player.Battlefield.Where(id => state.Cards[id].CardType is CardType.Being or CardType.Token && state.Cards[id].HostId is null))
                    {
                        if (CanAfford(state, player, cardId))
                        {
                            actions.Add(new PlayPossessionAction(cardId, hostId));
                        }
                    }
                    break;
                case CardType.Relic:
                    foreach (var hostId in player.Battlefield.Where(id => state.Cards[id].IsUnit && state.Cards[id].HostId is null))
                    {
                        if (CanAfford(state, player, cardId))
                        {
                            actions.Add(new PlayRelicAction(cardId, hostId));
                        }
                    }
                    break;
                case CardType.Rite:
                    if (CanAfford(state, player, cardId))
                    {
                        actions.Add(new PlayRiteAction(cardId));
                    }
                    break;
                case CardType.Tactic:
                    if (allowPrepared && CanAfford(state, player, cardId))
                    {
                        actions.Add(new PrepareTacticAction(cardId));
                    }
                    break;
            }
        }

        actions.AddRange(GetLegalEvolutionActions(state, player));
        return actions;
    }

    private static bool ShouldForbidHardCastEvolutionCard(GameState state, CardInstance card)
    {
        return state.Rules.Contains("forbid-hardcast-evolution-cards", StringComparison.OrdinalIgnoreCase)
            && (card.HasTag("L2") || card.HasTag("L3"));
    }

    private IReadOnlyList<PlayerAction> GetLegalEvolutionActions(GameState state, PlayerState player)
    {
        var actions = new List<PlayerAction>();
        foreach (var source in new[] { (cards: player.Hand, fromDiscard: false), (cards: player.Discard, fromDiscard: true) })
        {
            foreach (var cardId in source.cards)
            {
                var card = state.Cards[cardId];
                var definition = state.CardDefinitions[card.DefinitionId];
                if (!definition.IsEvolution)
                {
                    continue;
                }

                if (source.fromDiscard && !card.HasKeyword(Keyword.Recall))
                {
                    continue;
                }

                foreach (var hostId in player.Battlefield)
                {
                    var host = state.Cards[hostId];
                    if (host.HostId.HasValue || !HostMatchesEvolution(host, definition) || !MeetsEvolutionCondition(host, definition.EvolveCondition))
                    {
                        continue;
                    }

                    if (!CanLegallyEnterBattlefieldByEvolution(state, player, card) || WouldExceedPresenceLimit(state, player, definition.PresenceCost, host))
                    {
                        continue;
                    }

                    var totalMemory = definition.EvolveMemoryCost + (source.fromDiscard ? definition.RecallMemoryCost : 0);
                    if (player.CurrentOfferings >= definition.EvolveOfferingCost && player.Memory >= totalMemory)
                    {
                        actions.Add(new EvolveAction(cardId, hostId, source.fromDiscard));
                    }
                }
            }
        }

        return actions;
    }

    private void RecordLegalAwakenMetrics(GameState state, PlayerId playerId, IReadOnlyList<PlayerAction> legalActions)
    {
        var awakenCount = legalActions.OfType<AwakenAncestorAction>().Count();
        if (awakenCount == 0)
        {
            return;
        }

        if (playerId == PlayerId.Red)
        {
            state.Metrics.LegalAwakenActionsGeneratedRed += awakenCount;
        }
        else
        {
            state.Metrics.LegalAwakenActionsGeneratedIron += awakenCount;
        }
    }

    private IReadOnlyList<PlayerAction> GetLegalAwakenings(GameState state, PlayerState player)
    {
        var actions = new List<PlayerAction>();
        foreach (var ancestor in player.Lineage)
        {
            var definition = state.AncestorDefinitions[ancestor.DefinitionId];
            if (player.Memory >= definition.AwakenMemoryCost && MeetsAncestorCondition(player.CurrentTurn, definition.AwakenCondition))
            {
                actions.Add(new AwakenAncestorAction(ancestor.DefinitionId));
            }
        }

        return actions;
    }

    private IReadOnlyList<AttackDecision> GetLegalAttacks(GameState state, PlayerState player)
    {
        var opponent = state.GetOpponent(player.Id);
        var attacks = new List<AttackDecision>();
        var guards = opponent.Battlefield
            .Select(id => state.Cards[id])
            .Where(card => card.Zone == Zone.Battlefield && card.HostId is null && card.HasKeyword(Keyword.Guard))
            .ToList();
        foreach (var unit in player.Battlefield.Select(id => state.Cards[id]).Where(card => card.IsUnit && card.Zone == Zone.Battlefield && card.HostId is null && !card.IsExhausted))
        {
            var enteredThisTurn = unit.EnteredBattlefieldOnTurn == state.TurnNumber;
            var canAttackUnits = !enteredThisTurn || unit.HasKeyword(Keyword.Ambush);
            var canAttackShrines = !enteredThisTurn;

            if (canAttackUnits)
            {
                foreach (var target in opponent.Battlefield.Select(id => state.Cards[id]).Where(card => card.Zone == Zone.Battlefield && card.HostId is null && card.IsUnit))
                {
                    if (player.CurrentTurn.StandardAssaultSlotsAvailable <= 0 && !unit.HasKeyword(Keyword.Pack))
                    {
                        continue;
                    }

                    attacks.Add(new AttackDecision(unit.Id, AttackTargetType.Unit, target.Name, target.Id));
                }
            }

            if (canAttackShrines && unit.CardType != CardType.Spirit)
            {
                if (player.CurrentTurn.StandardAssaultSlotsAvailable <= 0 && !unit.HasKeyword(Keyword.Pack))
                {
                    continue;
                }

                if (guards.Count > 0)
                {
                    continue;
                }

                foreach (var shrine in opponent.Shrines.Where(x => !x.IsBroken))
                {
                    attacks.Add(new AttackDecision(unit.Id, AttackTargetType.Shrine, shrine.Name, ShrineName: shrine.Name));
                }
            }
        }

        return attacks;
    }

    private void DrawOne(GameState state, PlayerState player, string source)
    {
        if (player.Deck.Count == 0)
        {
            ReshuffleDiscardIntoDeck(state, player);
        }

        if (player.Deck.Count == 0)
        {
            return;
        }

        var cardId = player.Deck[0];
        player.Deck.RemoveAt(0);
        player.Hand.Add(cardId);
        state.Cards[cardId].Zone = Zone.Hand;
        Log(state, player.Id, EventType.CardDrawn, $"{state.Cards[cardId].Name} drawn from {source}.");
        IncrementDrawMetric(state, player.Id);
    }

    private void ReshuffleDiscardIntoDeck(GameState state, PlayerState player)
    {
        if (player.Discard.Count == 0)
        {
            return;
        }

        var returning = player.Discard.Where(id => state.Cards[id].Zone == Zone.Discard).ToList();
        foreach (var cardId in returning)
        {
            player.Deck.Add(cardId);
            state.Cards[cardId].Zone = Zone.Deck;
        }

        player.Discard.Clear();
        state.Random.Shuffle(player.Deck);
        Log(state, player.Id, EventType.DeckReshuffled, $"{player.Name} reshuffled discard into deck.");
        IncrementReshuffleMetric(state, player.Id, player.Forgotten.Count);
    }

    private bool SpendResources(GameState state, PlayerState player, int offerings, int memory, string source)
    {
        if (player.CurrentOfferings < offerings || player.Memory < memory)
        {
            return false;
        }

        player.CurrentOfferings -= offerings;
        player.Memory -= memory;
        if (offerings > 0)
        {
            Log(state, player.Id, EventType.OfferingSpent, $"Spent {offerings} Offerings on {source}.");
            IncrementOfferingsMetric(state, player.Id, offerings);
        }

        if (memory > 0)
        {
            Log(state, player.Id, EventType.MemorySpent, $"Spent {memory} Memory on {source}.");
            IncrementMemorySpentMetric(state, player.Id, memory);
        }

        return true;
    }

    private void SpendMemory(GameState state, PlayerState player, int amount, string source)
    {
        if (amount <= 0)
        {
            return;
        }

        player.Memory -= amount;
        Log(state, player.Id, EventType.MemorySpent, $"Spent {amount} Memory on {source}.");
        IncrementMemorySpentMetric(state, player.Id, amount);
        if (source.StartsWith("Awakened ", StringComparison.Ordinal))
        {
            IncrementAncestorMemorySpentMetric(state, player.Id, amount);
        }
    }

    private void GainMemory(GameState state, PlayerState player, int amount, string reason)
    {
        if (amount <= 0)
        {
            return;
        }

        player.Memory += amount;
        player.CurrentTurn.GainedMemoryThisTurn = true;
        Log(state, player.Id, EventType.MemoryGained, $"Gained {amount} Memory ({reason}).");
        IncrementMemoryGeneratedMetric(state, player.Id, amount);

        if (player.AwakenedAncestorDefinitionId == CoreIds.Red.AncestorChild && !player.CurrentTurn.FirstMemoryGainTriggeredDrawThisTurn)
        {
            player.CurrentTurn.FirstMemoryGainTriggeredDrawThisTurn = true;
            state.Metrics.ChildDrawDiscardTriggers++;
            DrawOne(state, player, "Child Who Remembered the Dead");
            if (player.Hand.Count > 0)
            {
                var discardId = player.Hand.OrderBy(id => state.Cards[id].Name, StringComparer.Ordinal).Last();
                player.Hand.Remove(discardId);
                player.Discard.Add(discardId);
                state.Cards[discardId].Zone = Zone.Discard;
                Log(state, player.Id, EventType.CardDiscarded, $"{state.Cards[discardId].Name} discarded from Child Who Remembered the Dead.");
                IncrementDiscardedMetric(state, player.Id);
            }
        }
    }

    private TurnSnapshot CreateSnapshot(GameState state, PlayerState player)
    {
        return new TurnSnapshot(
            player.CurrentOfferings,
            player.Memory,
            player.Hand.Select(id => state.Cards[id].Name).OrderBy(x => x, StringComparer.Ordinal).ToList(),
            player.Battlefield.Select(id => DescribeBoardCard(state.Cards[id], state)).OrderBy(x => x, StringComparer.Ordinal).ToList(),
            player.PreparedTacticIds.Count == 0 ? null : string.Join(", ", player.PreparedTacticIds.Select(id => state.Cards[id].Name).OrderBy(x => x, StringComparer.Ordinal)),
            player.AwakenedAncestorDefinitionId is null ? null : state.AncestorDefinitions[player.AwakenedAncestorDefinitionId].Name,
            player.Shrines.Select(x => $"{x.Name}: {x.Damage}/{x.Vitality}").ToList(),
            player.Forgotten.Select(id => state.Cards[id].Name).OrderBy(x => x, StringComparer.Ordinal).ToList());
    }

    private static string DescribeBoardCard(CardInstance card, GameState state)
    {
        var extras = new List<string>();
        if (card.IsWounded)
        {
            extras.Add("Wounded");
        }

        if (card.AttachedRelicId.HasValue)
        {
            extras.Add($"Relic:{state.Cards[card.AttachedRelicId.Value].Name}");
        }

        if (card.AttachedPossessionId.HasValue)
        {
            extras.Add($"Possession:{state.Cards[card.AttachedPossessionId.Value].Name}");
        }

        return extras.Count == 0 ? card.Name : $"{card.Name} [{string.Join(", ", extras)}]";
    }

    private void AdvanceTurnOrder(GameState state)
    {
        var strictAlternation = state.Rules.Contains("strict-alternation", StringComparison.OrdinalIgnoreCase);
        var phaseLength = state.Rules.Contains("phase-length-6", StringComparison.OrdinalIgnoreCase) ? 6 : 4;

        state.PlayerTurnCount++;
        var previousActive = state.ActivePlayer;
        if (!strictAlternation && state.PlayerTurnCount > 0 && state.PlayerTurnCount % phaseLength == 0)
        {
            state.PhaseNumber++;
        }

        state.ActivePlayer = GetNextPlayer(state);
        if (previousActive == state.ActivePlayer)
        {
            if (state.ActivePlayer == PlayerId.Red)
            {
                state.Metrics.PhaseBoundaryDoubleTurnsRed++;
            }
            else
            {
                state.Metrics.PhaseBoundaryDoubleTurnsIron++;
            }
        }

        state.TurnNumber++;
    }

    private PlayerId GetNextPlayer(GameState state)
    {
        if (state.Rules.Contains("strict-alternation", StringComparison.OrdinalIgnoreCase))
        {
            return state.PlayerTurnCount % 2 == 0 ? PlayerId.Red : PlayerId.Iron;
        }

        var phaseLength = state.Rules.Contains("phase-length-6", StringComparison.OrdinalIgnoreCase) ? 6 : 4;
        var phaseIndex = (state.PlayerTurnCount / phaseLength) % 2;
        var positionInPhase = state.PlayerTurnCount % phaseLength;

        if (phaseLength == 6)
        {
            return phaseIndex == 0
                ? positionInPhase switch
                {
                    0 => PlayerId.Red,
                    1 => PlayerId.Iron,
                    2 => PlayerId.Red,
                    3 => PlayerId.Iron,
                    4 => PlayerId.Red,
                    _ => PlayerId.Iron,
                }
                : positionInPhase switch
                {
                    0 => PlayerId.Iron,
                    1 => PlayerId.Red,
                    2 => PlayerId.Iron,
                    3 => PlayerId.Red,
                    4 => PlayerId.Iron,
                    _ => PlayerId.Red,
                };
        }

        return phaseIndex == 0
            ? positionInPhase switch
            {
                0 => PlayerId.Red,
                1 => PlayerId.Iron,
                2 => PlayerId.Red,
                _ => PlayerId.Iron,
            }
            : positionInPhase switch
            {
                0 => PlayerId.Iron,
                1 => PlayerId.Red,
                2 => PlayerId.Iron,
                _ => PlayerId.Red,
            };
    }

    private void CheckForWinner(GameState state)
    {
        if (CountBrokenShrines(state.Red) == 3)
        {
            EndGame(state, PlayerId.Iron, GameEndReason.ShrineBreak, GameOutcome.IronWin);
        }
        else if (CountBrokenShrines(state.Iron) == 3)
        {
            EndGame(state, PlayerId.Red, GameEndReason.ShrineBreak, GameOutcome.RedWin);
        }
    }

    private void FinalizeMetrics(GameState state)
    {
        state.Metrics.TurnCount = state.TurnNumber;
        state.Metrics.PhaseCount = state.PhaseNumber;
        state.Metrics.Timeout = state.EndReason == GameEndReason.Timeout;
        state.Metrics.EndReason = state.EndReason.ToString();
        state.Metrics.Outcome = state.Outcome.ToString();
        state.Metrics.Winner = state.Winner switch
        {
            PlayerId.Red => state.Red.Name,
            PlayerId.Iron => state.Iron.Name,
            _ => state.Outcome == GameOutcome.Draw ? "Draw" : string.Empty,
        };
        state.Metrics.Loser = state.Winner switch
        {
            PlayerId.Red => state.Iron.Name,
            PlayerId.Iron => state.Red.Name,
            _ => string.Empty,
        };
        state.Metrics.AdjudicatedWinner = state.Outcome switch
        {
            GameOutcome.AdjudicatedRed => state.Red.Name,
            GameOutcome.AdjudicatedIron => state.Iron.Name,
            _ => string.Empty,
        };

        if (state.EndReason == GameEndReason.Timeout)
        {
            switch (state.Outcome)
            {
                case GameOutcome.Draw:
                    state.Metrics.TimeoutDraws++;
                    break;
                case GameOutcome.AdjudicatedRed:
                    state.Metrics.TimeoutAdjudicatedRed++;
                    break;
                case GameOutcome.AdjudicatedIron:
                    state.Metrics.TimeoutAdjudicatedIron++;
                    break;
            }
        }

        state.Metrics.FinalRedShrinesBroken = CountBrokenShrines(state.Red);
        state.Metrics.FinalIronShrinesBroken = CountBrokenShrines(state.Iron);
        state.Metrics.MemoryEndRed = state.Red.Memory;
        state.Metrics.MemoryEndIron = state.Iron.Memory;
        state.Metrics.PresenceLimitRed = state.Red.PresenceLimit;
        state.Metrics.PresenceLimitIron = state.Iron.PresenceLimit;
        state.Metrics.PresenceUsedRed = GetBattlefieldPresenceUsed(state, state.Red);
        state.Metrics.PresenceUsedIron = GetBattlefieldPresenceUsed(state, state.Iron);
        state.Metrics.TurnsWithAwakenedAncestorRed = state.Turns.Count(turn => turn.Player == PlayerId.Red && !string.IsNullOrWhiteSpace(turn.Start.AwakenedAncestor));
        state.Metrics.TurnsWithAwakenedAncestorIron = state.Turns.Count(turn => turn.Player == PlayerId.Iron && !string.IsNullOrWhiteSpace(turn.Start.AwakenedAncestor));
        if (state.Winner == PlayerId.Red && state.Metrics.RedL3Played > 0)
        {
            state.Metrics.RedL3PlayerWon++;
        }
        else if (state.Winner == PlayerId.Iron && state.Metrics.IronL3Played > 0)
        {
            state.Metrics.IronL3PlayerWon++;
        }

        if (state.Winner == PlayerId.Red || state.Winner == PlayerId.Iron)
        {
            state.Metrics.WinsInOddPhase = (state.PhaseNumber % 2 != 0) ? 1 : 0;
            var phaseFirstPlayer = (state.PhaseNumber % 2 != 0) ? PlayerId.Red : PlayerId.Iron;
            state.Metrics.WinnerWasFirstPlayerInFinalPhase = (state.Winner == phaseFirstPlayer) ? 1 : 0;
        }
    }

    private void ResolveTimeout(GameState state)
    {
        var redBroken = CountBrokenShrines(state.Red);
        var ironBroken = CountBrokenShrines(state.Iron);

        if (redBroken < ironBroken)
        {
            EndGame(state, PlayerId.Red, GameEndReason.Timeout, GameOutcome.AdjudicatedRed);
            return;
        }

        if (ironBroken < redBroken)
        {
            EndGame(state, PlayerId.Iron, GameEndReason.Timeout, GameOutcome.AdjudicatedIron);
            return;
        }

        EndGame(state, PlayerId.Red, GameEndReason.Timeout, GameOutcome.AdjudicatedRed);
    }

    private static void EndGame(GameState state, PlayerId winner, GameEndReason endReason, GameOutcome outcome)
    {
        state.IsGameOver = true;
        state.Winner = winner;
        state.EndReason = endReason;
        state.Outcome = outcome;
    }

    private static int CountBrokenShrines(PlayerState player)
    {
        return player.Shrines.Count(x => x.IsBroken);
    }

    private ShrineState? ChooseMostDamagedShrine(PlayerState player)
    {
        return player.Shrines.Where(x => x.Damage > 0 && !x.IsBroken).OrderByDescending(x => x.Damage).ThenBy(x => x.Name, StringComparer.Ordinal).FirstOrDefault();
    }

    private static ShrineState? ChooseBestEnemyShrine(PlayerState player)
    {
        return player.Shrines.Where(x => !x.IsBroken).OrderByDescending(x => x.Damage).ThenBy(x => x.Name, StringComparer.Ordinal).FirstOrDefault();
    }

    private CardInstance? ChooseEnemyUnitForDamage(GameState state, PlayerState player)
    {
        return state.GetOpponent(player.Id).Battlefield.Select(id => state.Cards[id]).Where(card => card.IsUnit && card.HostId is null).OrderByDescending(card => GetCurrentVitality(state, card) - card.Damage).ThenBy(card => card.Name, StringComparer.Ordinal).FirstOrDefault();
    }

    private bool CanAfford(GameState state, PlayerState player, int cardId)
    {
        var definition = state.CardDefinitions[state.Cards[cardId].DefinitionId];
        return player.CurrentOfferings >= definition.OfferingCost && player.Memory >= definition.MemoryCost;
    }

    private void InitializeCombatBudget(GameState state, PlayerState player, bool recordMetrics)
    {
        player.CurrentTurn.StandardAssaultSlotsAvailable = state.StandardAssaultSlotsPerCombat;
        var readyPackUnits = player.Battlefield
            .Select(id => state.Cards[id])
            .Count(card => card.Zone == Zone.Battlefield && card.HostId is null && !card.IsExhausted && card.CardType == CardType.Being && card.HasKeyword(Keyword.Pack));
        var totalAttacks = Math.Min(state.MaxPackAttacksPerCombat, state.StandardAssaultSlotsPerCombat + readyPackUnits);
        player.CurrentTurn.PackAssaultSlotsAvailable = Math.Max(0, totalAttacks - state.StandardAssaultSlotsPerCombat);
        if (recordMetrics)
        {
            RecordPackBudgetMetrics(state, player, readyPackUnits, totalAttacks);
        }
    }

    private static bool HasAvailableAssaultSlot(PlayerState player)
    {
        return player.CurrentTurn.StandardAssaultSlotsAvailable > 0 || player.CurrentTurn.PackAssaultSlotsAvailable > 0;
    }

    private void SpendAssaultSlot(GameState state, PlayerState player, CardInstance attacker)
    {
        if (attacker.HasKeyword(Keyword.Pack) && player.CurrentTurn.PackAssaultSlotsAvailable > 0)
        {
            player.CurrentTurn.PackAssaultSlotsAvailable--;
            player.CurrentTurn.PackAssaultSlotsSpent++;
            IncrementPackAssaultMetric(state, player.Id);
            return;
        }

        if (player.CurrentTurn.StandardAssaultSlotsAvailable > 0)
        {
            player.CurrentTurn.StandardAssaultSlotsAvailable--;
            player.CurrentTurn.StandardAssaultSlotsSpent++;
            IncrementStandardAssaultMetric(state, player.Id);
            return;
        }
    }

    private static int GetPresenceCost(GameState state, CardInstance card)
    {
        return state.CardDefinitions[card.DefinitionId].PresenceCost;
    }

    private static int GetBattlefieldPresenceUsed(GameState state, PlayerState player)
    {
        return player.Battlefield
            .Select(id => state.Cards[id])
            .Where(card => card.Zone == Zone.Battlefield && card.HostId is null && card.IsUnit)
            .Sum(card => GetPresenceCost(state, card));
    }

    private static bool WouldExceedPresenceLimit(GameState state, PlayerState player, int addedPresence, CardInstance? replacedHost = null)
    {
        var used = GetBattlefieldPresenceUsed(state, player);
        if (replacedHost is not null)
        {
            used -= GetPresenceCost(state, replacedHost);
        }

        return used + addedPresence > player.PresenceLimit;
    }

    private static bool CanLegallyEnterBattlefieldByPlay(GameState state, PlayerState player, CardInstance card)
    {
        return !RequiresEvolutionOnlyEntry(card)
            && !ViolatesUniqueBattlefieldRule(state, player, card)
            && !WouldExceedPresenceLimit(state, player, GetPresenceCost(state, card));
    }

    private static bool CanLegallyEnterBattlefieldByEvolution(GameState state, PlayerState player, CardInstance card)
    {
        return !ViolatesUniqueBattlefieldRule(state, player, card);
    }

    private static bool ViolatesUniqueBattlefieldRule(GameState state, PlayerState player, CardInstance card)
    {
        return IsUniqueCard(card)
            && player.Battlefield
                .Select(id => state.Cards[id])
                .Any(existing => existing.Zone == Zone.Battlefield && existing.HostId is null && existing.DefinitionId == card.DefinitionId);
    }

    private static bool IsUniqueCard(CardInstance card)
    {
        return card.HasKeyword(Keyword.Unique);
    }

    private static bool IsMythicL3(CardInstance card)
    {
        return card.HasKeyword(Keyword.Mythic);
    }

    private static bool RequiresEvolutionOnlyEntry(CardInstance card)
    {
        return card.IsUnit && card.HasKeyword(Keyword.Mythic);
    }

    private bool HostMatchesEvolution(CardInstance host, CardDefinition definition)
    {
        if (host.Zone != Zone.Battlefield || host.HostId.HasValue)
        {
            return false;
        }

        if (definition.Level == CardLevel.L2)
        {
            if (host.HasTag("L2") || host.HasTag("L3") || host.HasKeyword(Keyword.Mythic) || GetCardLevel(host) != CardLevel.L1)
            {
                return false;
            }
        }
        else if (definition.Level == CardLevel.L3)
        {
            if (GetCardLevel(host) != CardLevel.L2 || host.HasTag("L3") || host.HasKeyword(Keyword.Mythic))
            {
                return false;
            }
        }

        return definition.EvolveFromTag switch
        {
            "Hunter" => host.HasTag("Hunter"),
            "Hyena" => host.HasTag("Hyena"),
            "L2" => GetCardLevel(host) == CardLevel.L2,
            _ => false,
        };
    }

    private bool MeetsEvolutionCondition(CardInstance host, EvolveConditionKind condition)
    {
        return condition switch
        {
            EvolveConditionKind.DestroyedEnemyThisTurn => host.HasDestroyedEnemy,
            EvolveConditionKind.DamagedShrineThisTurn => host.HasDamagedShrine,
            EvolveConditionKind.BrokeShrineThisTurn => host.HasBrokenShrine,
            _ => true,
        };
    }

    private bool HasEvolutionBaseInPlay(GameState state, PlayerId playerId, CardInstance evolutionCard)
    {
        var definition = state.CardDefinitions[evolutionCard.DefinitionId];
        return state.GetPlayer(playerId).Battlefield
            .Select(id => state.Cards[id])
            .Any(host => host.Zone == Zone.Battlefield && host.HostId is null && HostMatchesEvolutionStatic(host, definition));
    }

    private static bool HostMatchesEvolutionStatic(CardInstance host, CardDefinition definition)
    {
        var hostLevel = GetCardLevel(host);
        var evolutionLevel = definition.Level;
        if (evolutionLevel == CardLevel.L2)
        {
            return hostLevel == CardLevel.L1
                && definition.EvolveFromTag switch
                {
                    "Hunter" => host.HasTag("Hunter"),
                    "Hyena" => host.HasTag("Hyena"),
                    _ => false,
                };
        }

        if (evolutionLevel == CardLevel.L3)
        {
            return hostLevel == CardLevel.L2
                && !host.HasTag("L3")
                && !host.HasKeyword(Keyword.Mythic)
                && definition.EvolveFromTag switch
                {
                    "L2" => hostLevel == CardLevel.L2,
                    _ => false,
                };
        }

        return false;
    }

    private static CardLevel GetCardLevel(CardInstance card)
    {
        if (card.HasTag("L3") || card.HasKeyword(Keyword.Mythic))
        {
            return CardLevel.L3;
        }

        if (card.HasTag("L2"))
        {
            return CardLevel.L2;
        }

        return card.IsUnit ? CardLevel.L1 : CardLevel.None;
    }

    private GameView CreateViewFor(GameState state, PlayerId perspective)
    {
        var self = state.GetPlayer(perspective);
        var opponent = state.GetOpponent(perspective);
        var visibleCardIds = new HashSet<int>(self.Hand);
        foreach (var cardId in self.Battlefield.Concat(opponent.Battlefield).Concat(self.Discard).Concat(opponent.Discard).Concat(self.Forgotten).Concat(opponent.Forgotten))
        {
            visibleCardIds.Add(cardId);
        }

        foreach (var preparedId in self.PreparedTacticIds)
        {
            visibleCardIds.Add(preparedId);
        }

        var cards = visibleCardIds
            .Where(state.Cards.ContainsKey)
            .ToDictionary(
                id => id,
                id =>
                {
                    var card = state.Cards[id];
                    var definition = state.CardDefinitions[card.DefinitionId];
                    return new CardPublicView(
                        Id: card.Id,
                        DefinitionId: card.DefinitionId,
                        Name: card.Name,
                        Owner: card.Owner,
                        Controller: card.Controller,
                        CardType: card.CardType,
                        Zone: card.Zone,
                        Tags: card.Tags.ToList(),
                        Keywords: card.BaseKeywords,
                        Level: definition.Level,
                        PresenceCost: definition.PresenceCost,
                        BaseAttack: card.BaseAttack,
                        BaseVitality: card.BaseVitality,
                        Damage: card.Damage,
                        IsExhausted: card.IsExhausted,
                        IsWounded: card.IsWounded,
                        HostId: card.HostId,
                        AttachedRelicId: card.AttachedRelicId,
                        AttachedPossessionId: card.AttachedPossessionId);
                });

        return new GameView(
            Perspective: perspective,
            Seed: state.Seed,
            TurnNumber: state.TurnNumber,
            PhaseNumber: state.PhaseNumber,
            StandardAssaultSlotsPerCombat: state.StandardAssaultSlotsPerCombat,
            MaxPackAttacksPerCombat: state.MaxPackAttacksPerCombat,
            Cards: cards,
            Self: CreatePlayerView(self, revealPreparedTactic: true, cards, state),
            Opponent: CreatePlayerView(opponent, revealPreparedTactic: false, cards, state),
            PublicEvents: state.Events.ToList());
    }

    private static PlayerPublicView CreatePlayerView(PlayerState player, bool revealPreparedTactic, IReadOnlyDictionary<int, CardPublicView> cards, GameState state)
    {
        var forgotten = player.Forgotten.Where(cards.ContainsKey).Select(id => cards[id].Name).ToList();
        return new PlayerPublicView(
            Id: player.Id,
            Seat: player.Seat,
            Name: player.Name,
            Faction: player.Faction,
            DeckName: player.DeckName,
            CurrentOfferings: player.CurrentOfferings,
            Memory: player.Memory,
            MaxOfferings: player.MaxOfferings,
            PresenceLimit: player.PresenceLimit,
            PresenceUsed: GetBattlefieldPresenceUsed(state, player),
            Hand: player.Hand.Where(cards.ContainsKey).ToList(),
            Battlefield: player.Battlefield.Where(cards.ContainsKey).ToList(),
            Forgotten: forgotten,
            Shrines: player.Shrines.Select(shrine => new ShrinePublicView(shrine.DefinitionId, shrine.Name, shrine.Owner, shrine.Vitality, shrine.Damage)).ToList(),
            AwakenedAncestorDefinitionId: player.AwakenedAncestorDefinitionId,
            PreparedTacticCardIds: revealPreparedTactic ? player.PreparedTacticIds.Where(cards.ContainsKey).ToList() : [],
            HasPreparedTactic: player.PreparedTacticIds.Count > 0);
    }

    private void MoveConsumedEvolutionHost(GameState state, PlayerState player, CardInstance host, string evolvedIntoName)
    {
        var toForgotten = host.HasKeyword(Keyword.Ascend);
        if (toForgotten)
        {
            player.Battlefield.Remove(host.Id);
            player.Forgotten.Add(host.Id);
            host.Zone = Zone.Forgotten;
            Log(state, player.Id, EventType.CardForgotten, $"{host.Name} ascended into {evolvedIntoName} and moved to Forgotten.");
            IncrementForgottenMetric(state, player.Id);
            IncrementFadeResolvedMetric(state, player.Id);
            return;
        }

        host.Zone = Zone.Discard;
        player.Discard.Add(host.Id);
        player.Battlefield.Remove(host.Id);
    }

    private bool MeetsAncestorCondition(DeedTracker tracker, AncestorConditionKind condition)
    {
        return condition switch
        {
            AncestorConditionKind.DestroyedEnemyThisTurn => tracker.UnitDestroyedEnemyThisTurn,
            AncestorConditionKind.RestoredShrineThisTurnOrSkippedShrineAttacksLastTurn => tracker.ShrineRestoredThisTurn || tracker.PlayerSkippedShrineAttacksLastTurn,
            AncestorConditionKind.SpiritDispersedSinceLastTurn => tracker.SpiritDispersedSinceLastTurn,
            AncestorConditionKind.DamagedEnemyShrineThisTurn => tracker.UnitDamagedShrineThisTurn,
            AncestorConditionKind.SurvivedCombatThisTurn => tracker.UnitSurvivedCombatThisTurn,
            AncestorConditionKind.PlayedRelicThisTurn => tracker.PlayedRelicThisTurn,
            AncestorConditionKind.DeclaredPackAttackThisTurn => tracker.PackAssaultSlotsSpent > 0,
            AncestorConditionKind.WoundedOrSurvivedCombatThisTurn => tracker.UnitBecameWoundedThisTurn || tracker.UnitSurvivedCombatThisTurn,
            _ => false,
        };
    }

    private static bool IsFatalDamage(GameState state, CardInstance unit, int damage)
    {
        return unit.Damage >= GetCurrentVitality(state, unit);
    }

    private static int GetCurrentVitality(GameState state, CardInstance unit)
    {
        return unit.BaseVitality;
    }

    private static void Log(GameState state, PlayerId? playerId, EventType type, string message)
    {
        state.Events.Add(new GameEvent(state.TurnNumber, state.PhaseNumber, playerId, type, message));
    }

    private void IncrementAttacksMetric(GameState state, PlayerId playerId, bool shrineAttack)
    {
        if (playerId == PlayerId.Red)
        {
            state.Metrics.AttacksDeclaredRed++;
            if (shrineAttack) state.Metrics.ShrineAttacksRed++;
            state.Metrics.PresenceUsedRed = GetBattlefieldPresenceUsed(state, player: state.Red);
        }
        else
        {
            state.Metrics.AttacksDeclaredIron++;
            if (shrineAttack) state.Metrics.ShrineAttacksIron++;
            state.Metrics.PresenceUsedIron = GetBattlefieldPresenceUsed(state, player: state.Iron);
        }
    }

    private void IncrementStandardAssaultMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.StandardAssaultSlotsSpentRed++;
        else state.Metrics.StandardAssaultSlotsSpentIron++;
    }

    private void IncrementPackAssaultMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.PackAssaultSlotsSpentRed++;
        else state.Metrics.PackAssaultSlotsSpentIron++;
    }

    private void RecordPackBudgetMetrics(GameState state, PlayerState player, int readyPackUnits, int totalAttacks)
    {
        var generatedPackSlots = Math.Max(0, totalAttacks - state.StandardAssaultSlotsPerCombat);
        if (player.Id == PlayerId.Red)
        {
            state.Metrics.PackUnitsReadyAtCombatStartRed += readyPackUnits;
            state.Metrics.PackAssaultSlotsGeneratedRed += generatedPackSlots;
            state.Metrics.PackAssaultSlotsAvailableRed += generatedPackSlots;
            state.Metrics.MaxAttacksAvailableThisCombatRed += totalAttacks;
            if (generatedPackSlots > 0)
            {
                state.Metrics.TurnsWithPackBonusRed++;
            }
        }
        else
        {
            state.Metrics.PackUnitsReadyAtCombatStartIron += readyPackUnits;
            state.Metrics.PackAssaultSlotsGeneratedIron += generatedPackSlots;
            state.Metrics.PackAssaultSlotsAvailableIron += generatedPackSlots;
            state.Metrics.MaxAttacksAvailableThisCombatIron += totalAttacks;
            if (generatedPackSlots > 0)
            {
                state.Metrics.TurnsWithPackBonusIron++;
            }
        }
    }

    private void RecordSkippedPackSlots(GameState state, PlayerState player, IReadOnlyList<AttackDecision> remainingLegalAttacks, int requestedAttackCount)
    {
        var skippedPackSlots = player.CurrentTurn.PackAssaultSlotsAvailable;
        if (skippedPackSlots > 0)
        {
            if (player.Id == PlayerId.Red) state.Metrics.PackAssaultSlotsSkippedRed += skippedPackSlots;
            else state.Metrics.PackAssaultSlotsSkippedIron += skippedPackSlots;
        }

        var preventedByLimit = 0;
        if (remainingLegalAttacks.Count > 0 && !HasAvailableAssaultSlot(player))
        {
            preventedByLimit = remainingLegalAttacks
                .Select(attack => attack.AttackerId)
                .Distinct()
                .Count();
        }
        else if (remainingLegalAttacks.Count > 0 && requestedAttackCount < player.CurrentTurn.StandardAssaultSlotsSpent + player.CurrentTurn.PackAssaultSlotsSpent + remainingLegalAttacks.Count)
        {
            preventedByLimit = 0;
        }

        if (preventedByLimit > 0)
        {
            if (player.Id == PlayerId.Red) state.Metrics.AttacksPreventedByAssaultLimitRed += preventedByLimit;
            else state.Metrics.AttacksPreventedByAssaultLimitIron += preventedByLimit;
        }
    }

    private void IncrementBlockedShrineMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.BlockedShrineAttacksRed++;
        else state.Metrics.BlockedShrineAttacksIron++;
    }

    private void RecordLegalEvolveMetrics(GameState state, PlayerId playerId, IReadOnlyList<PlayerAction> legalActions)
    {
        var evolveActions = legalActions.OfType<EvolveAction>().ToList();
        if (evolveActions.Count == 0)
        {
            return;
        }

        var hasL2 = evolveActions.Any(action => state.Cards[action.CardId].HasTag("L2"));
        var hasL3 = evolveActions.Any(action => state.Cards[action.CardId].HasTag("L3"));
        if (playerId == PlayerId.Red)
        {
            state.Metrics.LegalEvolveActionsGeneratedRed += evolveActions.Count;
            state.Metrics.EvolveWindowsRed++;
            if (hasL2) state.Metrics.TurnsWithLegalL2EvolutionRed++;
            if (hasL3) state.Metrics.TurnsWithLegalL3EvolutionRed++;
            state.Metrics.LegalL2EvolveActionsGeneratedRed += evolveActions.Count(action => state.Cards[action.CardId].HasTag("L2"));
            state.Metrics.LegalL3EvolveActionsGeneratedRed += evolveActions.Count(action => state.Cards[action.CardId].HasTag("L3"));
        }
        else
        {
            state.Metrics.LegalEvolveActionsGeneratedIron += evolveActions.Count;
            state.Metrics.EvolveWindowsIron++;
            if (hasL2) state.Metrics.TurnsWithLegalL2EvolutionIron++;
            if (hasL3) state.Metrics.TurnsWithLegalL3EvolutionIron++;
            state.Metrics.LegalL2EvolveActionsGeneratedIron += evolveActions.Count(action => state.Cards[action.CardId].HasTag("L2"));
            state.Metrics.LegalL3EvolveActionsGeneratedIron += evolveActions.Count(action => state.Cards[action.CardId].HasTag("L3"));
        }
    }

    private void IncrementChosenEvolveMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.EvolveActionsChosenRed++;
        else state.Metrics.EvolveActionsChosenIron++;
    }

    private void IncrementChosenAwakenMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.AwakenActionsChosenRed++;
        else state.Metrics.AwakenActionsChosenIron++;
    }

    private void IncrementSkippedAwakenMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.AwakenActionsSkippedWhileLegalRed++;
        else state.Metrics.AwakenActionsSkippedWhileLegalIron++;
    }

    private void IncrementAncestorMemorySpentMetric(GameState state, PlayerId playerId, int spent)
    {
        if (playerId == PlayerId.Red) state.Metrics.MemorySpentOnAncestorsRed += spent;
        else state.Metrics.MemorySpentOnAncestorsIron += spent;
    }

    private void RecordAncestorAwakened(GameState state, PlayerState player, string ancestorDefinitionId)
    {
        if (player.Id == PlayerId.Red)
        {
            state.Metrics.FirstAwakenedAncestorRed = string.IsNullOrWhiteSpace(state.Metrics.FirstAwakenedAncestorRed) ? ancestorDefinitionId : state.Metrics.FirstAwakenedAncestorRed;
            if (!string.IsNullOrWhiteSpace(player.AwakenedAncestorDefinitionId) && !string.Equals(player.AwakenedAncestorDefinitionId, ancestorDefinitionId, StringComparison.Ordinal))
            {
                state.Metrics.AncestorSwitchesRed++;
            }
        }
        else
        {
            state.Metrics.FirstAwakenedAncestorIron = string.IsNullOrWhiteSpace(state.Metrics.FirstAwakenedAncestorIron) ? ancestorDefinitionId : state.Metrics.FirstAwakenedAncestorIron;
            if (!string.IsNullOrWhiteSpace(player.AwakenedAncestorDefinitionId) && !string.Equals(player.AwakenedAncestorDefinitionId, ancestorDefinitionId, StringComparison.Ordinal))
            {
                state.Metrics.AncestorSwitchesIron++;
            }
        }
    }

    private void IncrementHardCastChosenWhileLegalEvolveActionExistsMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.HardCastChosenWhileLegalEvolveActionExistsRed++;
        else state.Metrics.HardCastChosenWhileLegalEvolveActionExistsIron++;
    }

    private void IncrementHardCastChosenWhileEvolutionBaseExistsMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.HardCastChosenWhileEvolutionBaseExistsRed++;
        else state.Metrics.HardCastChosenWhileEvolutionBaseExistsIron++;
    }

    private void IncrementLegalBlockOptionsMetric(GameState state, PlayerId playerId, int options)
    {
        if (playerId == PlayerId.Red) state.Metrics.LegalBlockOptionsRed += options;
        else state.Metrics.LegalBlockOptionsIron += options;
    }

    private void IncrementChosenBlockMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.BlocksChosenRed++;
        else state.Metrics.BlocksChosenIron++;
    }

    private void IncrementDeclinedBlockMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.BlocksDeclinedRed++;
        else state.Metrics.BlocksDeclinedIron++;
    }

    private void IncrementUnitKilledMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.UnitsKilledRed++;
        else state.Metrics.UnitsKilledIron++;
    }

    private void IncrementSpiritDispersedMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.SpiritsDispersedRed++;
        else state.Metrics.SpiritsDispersedIron++;
    }

    private void IncrementWoundedEventMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.WoundedEventsRed++;
        else state.Metrics.WoundedEventsIron++;
    }

    private void IncrementWoundedReductionMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.WoundedDamageReductionEventsRed++;
        else state.Metrics.WoundedDamageReductionEventsIron++;
    }

    private void RecordPierceMetrics(GameState state, PlayerId playerId, int damage, CardInstance attacker)
    {
        if (playerId == PlayerId.Red)
        {
            state.Metrics.PierceOverflowEventsRed++;
            state.Metrics.PierceOverflowDamageRed += damage;
        }
        else
        {
            state.Metrics.PierceOverflowEventsIron++;
            state.Metrics.PierceOverflowDamageIron += damage;
        }
    }

    private void IncrementPreparedPreparedMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.PreparedTacticsPreparedRed++;
        else state.Metrics.PreparedTacticsPreparedIron++;
    }

    private void IncrementPreparedTriggeredMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.PreparedTacticsTriggeredRed++;
        else state.Metrics.PreparedTacticsTriggeredIron++;
    }

    private void IncrementPreparedExpiredMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.PreparedTacticsExpiredRed++;
        else state.Metrics.PreparedTacticsExpiredIron++;
    }

    private void IncrementForgottenMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.ForgottenCardsRed++;
        else state.Metrics.ForgottenCardsIron++;
    }

    private void IncrementFadeResolvedMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.FadeCardsResolvedRed++;
        else state.Metrics.FadeCardsResolvedIron++;
    }

    private void IncrementFadeTriggeredMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.FadeTacticsTriggeredRed++;
        else state.Metrics.FadeTacticsTriggeredIron++;
    }

    private void IncrementDrawMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.CardsDrawnRed++;
        else state.Metrics.CardsDrawnIron++;
    }

    private void IncrementRetainedMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.CardsRetainedRed++;
        else state.Metrics.CardsRetainedIron++;
    }

    private void IncrementDiscardedMetric(GameState state, PlayerId playerId)
    {
        if (playerId == PlayerId.Red) state.Metrics.CardsDiscardedRed++;
        else state.Metrics.CardsDiscardedIron++;
    }

    private void IncrementReshuffleMetric(GameState state, PlayerId playerId, int forgottenExcluded)
    {
        if (playerId == PlayerId.Red)
        {
            state.Metrics.DeckReshufflesRed++;
            state.Metrics.ForgottenCardsExcludedFromReshuffleRed += forgottenExcluded;
        }
        else
        {
            state.Metrics.DeckReshufflesIron++;
            state.Metrics.ForgottenCardsExcludedFromReshuffleIron += forgottenExcluded;
        }
    }

    private void IncrementOfferingsMetric(GameState state, PlayerId playerId, int spent)
    {
        if (playerId == PlayerId.Red) state.Metrics.OfferingsSpentRed += spent;
        else state.Metrics.OfferingsSpentIron += spent;
    }

    private void IncrementMemorySpentMetric(GameState state, PlayerId playerId, int spent)
    {
        if (playerId == PlayerId.Red) state.Metrics.MemorySpentRed += spent;
        else state.Metrics.MemorySpentIron += spent;
    }

    private void IncrementMemoryGeneratedMetric(GameState state, PlayerId playerId, int gained)
    {
        if (playerId == PlayerId.Red) state.Metrics.MemoryGeneratedRed += gained;
        else state.Metrics.MemoryGeneratedIron += gained;
    }

    private void UpdateBattlefieldEntryMetrics(GameState state, PlayerId playerId, CardInstance enteredCard, bool enteredViaEvolution, bool recalledFromDiscard)
    {
        var strictAlternation = state.Rules.Contains("strict-alternation", StringComparison.OrdinalIgnoreCase);
        var phaseLength = state.Rules.Contains("phase-length-6", StringComparison.OrdinalIgnoreCase) ? 6 : 4;
        var boundaryTurn = !strictAlternation && state.PlayerTurnCount > 0 && state.PlayerTurnCount % phaseLength == 0;
        var isL2 = enteredCard.HasTag("L2");
        var isL3 = enteredCard.HasTag("L3");
        if (!isL2 && !isL3)
        {
            return;
        }

        if (playerId == PlayerId.Red)
        {
            if (isL2)
            {
                state.Metrics.RedL2EnteredBattlefield++;
                state.Metrics.RedL2Played++;
                if (enteredViaEvolution) state.Metrics.RedL2Evolved++;
                else state.Metrics.RedL2HardCast++;
                state.Metrics.FirstL2Turn ??= state.TurnNumber;
            }
            else if (isL3)
            {
                state.Metrics.RedL3EnteredBattlefield++;
                state.Metrics.RedL3Played++;
                if (enteredViaEvolution) state.Metrics.RedL3Evolved++;
                else state.Metrics.RedL3HardCast++;
                if (recalledFromDiscard) state.Metrics.RedL3Recalled++;
                state.Metrics.FirstL3Turn ??= state.TurnNumber;
            }

            if (enteredViaEvolution && boundaryTurn) state.Metrics.EvolutionsOnPhaseBoundaryRed++;
        }
        else
        {
            if (isL2)
            {
                state.Metrics.IronL2EnteredBattlefield++;
                state.Metrics.IronL2Played++;
                if (enteredViaEvolution) state.Metrics.IronL2Evolved++;
                else state.Metrics.IronL2HardCast++;
                state.Metrics.FirstL2Turn ??= state.TurnNumber;
            }
            else if (isL3)
            {
                state.Metrics.IronL3EnteredBattlefield++;
                state.Metrics.IronL3Played++;
                if (enteredViaEvolution) state.Metrics.IronL3Evolved++;
                else state.Metrics.IronL3HardCast++;
                if (recalledFromDiscard) state.Metrics.IronL3Recalled++;
                state.Metrics.FirstL3Turn ??= state.TurnNumber;
            }

            if (enteredViaEvolution && boundaryTurn) state.Metrics.EvolutionsOnPhaseBoundaryIron++;
        }
    }
}
