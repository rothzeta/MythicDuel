using MythicDuel.Core.Cards;
using MythicDuel.Core.Game;
using MythicDuel.Core.Models;

namespace MythicDuel.Core.Bots;

internal static class BotHelpers
{
    public static IEnumerable<PlayerAction> Prioritize(IEnumerable<PlayerAction> actions, params Func<PlayerAction, bool>[] predicates)
    {
        var list = actions.ToList();
        var yielded = new HashSet<PlayerAction>();
        foreach (var predicate in predicates)
        {
            foreach (var action in list.Where(predicate))
            {
                if (yielded.Add(action))
                {
                    yield return action;
                }
            }
        }

        foreach (var action in list)
        {
            if (yielded.Add(action))
            {
                yield return action;
            }
        }
    }

    public static int ScoreAttack(GameView view, PlayerId playerId, AttackDecision attack)
    {
        if (attack.TargetType == AttackTargetType.Shrine)
        {
            var shrine = view.Opponent.Shrines.First(x => x.Name == attack.TargetName);
            return 20 + shrine.Damage;
        }

        var target = view.GetCard(attack.TargetUnitId!.Value);
        return 10 + target.BaseAttack + target.BaseVitality - target.Damage;
    }

    public static IReadOnlyList<AttackDecision> ChooseAssaultsWithPack(GameView view, IReadOnlyList<AttackDecision> legalAttacks, Func<AttackDecision, int> scoreAttack)
    {
        var bestAttackPerAttacker = legalAttacks
            .GroupBy(attack => attack.AttackerId)
            .Select(group => group
                .OrderByDescending(scoreAttack)
                .ThenBy(attack => attack.TargetName, StringComparer.Ordinal)
                .First())
            .OrderByDescending(scoreAttack)
            .ThenBy(attack => attack.TargetName, StringComparer.Ordinal)
            .ToList();

        var normalAttacks = bestAttackPerAttacker
            .Where(attack => !view.GetCard(attack.AttackerId).HasKeyword(Keyword.Pack))
            .ToList();

        var packAttacks = bestAttackPerAttacker
            .Where(attack => view.GetCard(attack.AttackerId).HasKeyword(Keyword.Pack))
            .ToList();

        var selected = new List<AttackDecision>();
        var usedAttackers = new HashSet<int>();
        var standardAttackSlots = Math.Max(0, view.StandardAssaultSlotsPerCombat);

        foreach (var attack in normalAttacks)
        {
            if (selected.Count >= standardAttackSlots)
            {
                break;
            }

            selected.Add(attack);
            usedAttackers.Add(attack.AttackerId);
        }

        foreach (var attack in packAttacks)
        {
            if (selected.Count >= standardAttackSlots)
            {
                break;
            }

            if (usedAttackers.Contains(attack.AttackerId))
            {
                continue;
            }

            selected.Add(attack);
            usedAttackers.Add(attack.AttackerId);
        }

        var maxTotalAttacks = Math.Clamp(view.MaxPackAttacksPerCombat, standardAttackSlots, 5);

        foreach (var attack in packAttacks)
        {
            if (selected.Count >= maxTotalAttacks)
            {
                break;
            }

            if (usedAttackers.Contains(attack.AttackerId))
            {
                continue;
            }

            selected.Add(attack);
            usedAttackers.Add(attack.AttackerId);
        }

        return selected;
    }

    public static int? PickRetainForRed(GameView view, PlayerId playerId, IReadOnlyList<int> handCardIds)
    {
        if (handCardIds.Count == 0)
        {
            return null;
        }

        return handCardIds
            .Select(id => view.GetCard(id))
            .OrderByDescending(card => ScoreRetainForRed(view, playerId, card))
            .ThenBy(card => card.Name, StringComparer.Ordinal)
            .Select(card => card.Id)
            .FirstOrDefault();
    }

    public static int? PickRetainForIron(GameView view, PlayerId playerId, IReadOnlyList<int> handCardIds)
    {
        if (handCardIds.Count == 0)
        {
            return null;
        }

        return handCardIds
            .Select(id => view.GetCard(id))
            .OrderByDescending(card => ScoreRetainForIron(view, playerId, card))
            .ThenBy(card => card.Name, StringComparer.Ordinal)
            .Select(card => card.Id)
            .FirstOrDefault();
    }

    public static bool HasThreatenedShrine(GameView view, PlayerId playerId)
    {
        return view.Self.Shrines.Any(shrine => !shrine.IsBroken && shrine.Damage >= 7);
    }

    public static bool HasUnitInPlay(GameView view, PlayerId playerId, params string[] definitionIds)
    {
        var battlefield = playerId == view.Self.Id ? view.Self.Battlefield : view.Opponent.Battlefield;
        return battlefield
            .Select(id => view.GetCard(id))
            .Any(card => card.Zone == Zone.Battlefield && definitionIds.Contains(card.DefinitionId, StringComparer.Ordinal));
    }

    public static bool HasTagInPlay(GameView view, PlayerId playerId, string tag)
    {
        var battlefield = playerId == view.Self.Id ? view.Self.Battlefield : view.Opponent.Battlefield;
        return battlefield
            .Select(id => view.GetCard(id))
            .Any(card => card.Zone == Zone.Battlefield && card.HostId is null && card.HasTag(tag));
    }

    private static int ScoreRetainForRed(GameView view, PlayerId playerId, CardPublicView card)
    {
        var hasHunterInPlay = HasTagInPlay(view, playerId, "Hunter");
        var hasLeopardInPlay = HasUnitInPlay(view, playerId, CoreIds.Red.LeopardHunter);
        var redShrineThreatened = HasThreatenedShrine(view, playerId);

        return card.DefinitionId switch
        {
            CoreIds.Red.YoungHunter when !hasHunterInPlay => 120,
            CoreIds.Red.RiverHunter when !hasHunterInPlay => 115,
            CoreIds.Red.LeopardHunter when hasHunterInPlay => 110,
            CoreIds.Red.KumaWhoWoundedTheSun when hasLeopardInPlay => 105,
            CoreIds.Red.RootWovenGuard when redShrineThreatened => 100,
            CoreIds.Red.SpearOfFirstDawn when hasHunterInPlay => 95,
            CoreIds.Red.EspritDuLeopard when hasHunterInPlay => 95,
            CoreIds.Red.OfferingOfMilkAndAsh when redShrineThreatened => 90,
            CoreIds.Red.RitualOfRedMoon => 80,
            CoreIds.Red.PaleRiverSpirit => 60,
            CoreIds.Red.DeepRiverSpirit => 40,
            CoreIds.Red.KumaWhoWoundedTheSun => 20,
            _ => 10,
        };
    }

    private static int ScoreRetainForIron(GameView view, PlayerId playerId, CardPublicView card)
    {
        var player = view.Self;
        var opponent = view.Opponent;
        var hasAttacker = player.Battlefield.Select(id => view.GetCard(id)).Any(card => card.Zone == Zone.Battlefield && card.HostId is null && card.IsUnit);
        var hasChampionInPlay = HasUnitInPlay(view, playerId, CoreIds.Iron.IronHyenaChampion);
        var hasHyenaPressure = player.Battlefield.Select(id => view.GetCard(id)).Count(card => card.Zone == Zone.Battlefield && card.HostId is null && card.HasTag("Hyena")) >= 2;
        var enemyBigUnit = opponent.Battlefield.Select(id => view.GetCard(id)).Any(card => card.Zone == Zone.Battlefield && card.HostId is null && card.BaseAttack >= 4);
        var enemyLeopard = HasUnitInPlay(view, opponent.Id, CoreIds.Red.LeopardHunter);
        var damagedShrineExists = opponent.Shrines.Any(shrine => !shrine.IsBroken && shrine.Damage > 0);

        return card.DefinitionId switch
        {
            CoreIds.Iron.BiteTheRoots => 120,
            CoreIds.Iron.BoneCrackerCub when !hasAttacker => 110,
            CoreIds.Iron.PackAmbush => 100,
            CoreIds.Iron.IronHyenaRaider when !hasAttacker => 105,
            CoreIds.Iron.BoneSpear when damagedShrineExists || hasAttacker => 95,
            CoreIds.Iron.IronSnare when enemyBigUnit => 90,
            CoreIds.Iron.FalseOpening when enemyLeopard => 90,
            CoreIds.Iron.IronHyenaChampion when hasHyenaPressure => 85,
            CoreIds.Iron.IronHyenaUnderworld when hasChampionInPlay => 105,
            CoreIds.Iron.PackHarrier when !hasAttacker => 110,
            CoreIds.Iron.BloodScentHyena when !hasAttacker => 105,
            CoreIds.Iron.BloodScentHyena => 55,
            CoreIds.Iron.PackHarrier => 50,
            CoreIds.Iron.FangRelic when hasAttacker => 70,
            CoreIds.Iron.BlackToothSmith => 60,
            CoreIds.Iron.RustHyenaSpirit => 40,
            CoreIds.Iron.IronHyenaUnderworld => 20,
            _ => 10,
        };
    }

    public static bool IsRedEvolution(PlayerAction action, GameView view)
    {
        return action is EvolveAction evolve && view.GetCard(evolve.CardId).Owner == PlayerId.Red;
    }

    public static bool IsIronEvolution(PlayerAction action, GameView view)
    {
        return action is EvolveAction evolve && view.GetCard(evolve.CardId).Owner == PlayerId.Iron;
    }

    public static bool IsPreparedThreat(PlayerAction action, GameView view)
    {
        return action is PrepareTacticAction prepare && view.GetCard(prepare.CardId).DefinitionId is CoreIds.Red.RootWovenGuard or CoreIds.Iron.IronSnare or CoreIds.Iron.FalseOpening;
    }

    public static int? ChoosePreparedReplacementByPriority(GameView view, IReadOnlyList<int> preparedTacticCardIds, int incomingPreparedCardId, Func<CardPublicView, int> priority)
    {
        if (preparedTacticCardIds.Count == 0)
        {
            return null;
        }

        return preparedTacticCardIds
            .Select(id => view.GetCard(id))
            .OrderByDescending(priority)
            .ThenBy(card => card.Name, StringComparer.Ordinal)
            .Select(card => card.Id)
            .FirstOrDefault();
    }
}
