using RawDealView.Options;

namespace RawDeal;

public static class ReverseFromHandController
{
    private static CardCollection playableReversals;
    private static List<string> playableReversalsFormatted;
    private static IntList reversalIndexInHand;
    private static int reversalIndexInput;
    private static EffectCatalog effectCatalog = EffectCatalog.Instance;
    private static CardInfo reversal;

    public static bool DoesReverse()
    {
        UpdateBonuses();
        (playableReversals, playableReversalsFormatted, reversalIndexInHand) = Game.CurrentOpponent
            .GetPlayableReversals(CardBeingPlayed.CardInfo, CardBeingPlayed.PlayedAs);
        reversalIndexInput = Game.View.AskUserToSelectAReversal(
            Game.CurrentOpponent._superstarName, playableReversalsFormatted);
        if (!playableReversals.Any() || reversalIndexInput == -1) { return false; }
        reversal = playableReversals[reversalIndexInput];
        Reverse(); return true;
    }

    private static void UpdateBonuses()
    {
        UpdateJockeyingForPBonus();
        UpdateIrishWhipBonus();
    }

    private static void UpdateJockeyingForPBonus()
    {
        if (JockeyingFPEffectGetsActivated())
        {
            JockeyingForPBonuses.AttackPlus4D =
                JockeyingForPBonuses.SelectedEffect == SelectedEffect.NextGrappleIsPlus4D;
            JockeyingForPBonuses.ReversalPlus8F =
                JockeyingForPBonuses.SelectedEffect == SelectedEffect.NextGrapplesReversalIsPlus8F;
        }
    }

    private static bool JockeyingFPEffectGetsActivated() =>
        JockeyingForPBonuses.IsActive && CardBeingPlayed.PlayedAs == "MANEUVER" &&
        CardBeingPlayed.CardInfo.Subtypes.Contains("Grapple");

    private static void UpdateIrishWhipBonus() =>
        IrishWhipBonus.AttackPlus5D = IrishWhipBonus.AttackPlus5D && 
        CardBeingPlayed.PlayedAs == "MANEUVER" &&
        CardBeingPlayed.CardInfo.Subtypes.Contains("Grapple");

    private static void Reverse()
    {
        Game.View.SayThatPlayerReversedTheCard(
            Game.CurrentOpponent._superstarName, playableReversalsFormatted[reversalIndexInput]);
        Game.CurrentPlayer.DiscardCardFromHand(CardBeingPlayed.IndexInHand);
        CardBeingPlayed.PlayedAs = "REVERSAL";
        effectCatalog.ApplyEffects(reversal.Title);
        PlayReversal();
    }

    private static void PlayReversal()
    {
        Game.CurrentOpponent.PlayCard(reversalIndexInHand[reversalIndexInput]);
        SolveBonusCards();
        DamageOpponentController.MakeDamage(reversal, Int32.Parse(CardBeingPlayed.CardInfo.Damage));
        Game.EndTurn(reversal.Title == "Jockeying for Position");
    }

    private static void SolveBonusCards()
    {
        SolveJockeyingForP();
        SolveIrishWhip();
    }

    private static void SolveJockeyingForP()
    {
        if (reversal.Title == "Jockeying for Position")
        {
            JockeyingForPBonuses.SelectedEffect = Game.View
                .AskUserToSelectAnEffectForJockeyForPosition(Game.CurrentOpponent._superstarName);
            JockeyingForPBonuses.IsActive = true;
        }
        else if (!(JockeyingForPBonuses.AttackPlus4D && reversal.CardEffect.Contains("does 7D")))
        {
            JockeyingForPBonuses.MakeFalse();
        }
    }

    private static void SolveIrishWhip()
    {
        if (reversal.Title == "Irish Whip")
        {
            IrishWhipBonus.AttackPlus5D = true;
        }
        else if (!(IrishWhipBonus.AttackPlus5D && reversal.CardEffect.Contains("does 7D")))
        {
            IrishWhipBonus.AttackPlus5D = false;
        }
    }
}