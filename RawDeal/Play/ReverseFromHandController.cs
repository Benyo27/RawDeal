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
        UpdateJockeyingForPBonus();
        (playableReversals, playableReversalsFormatted, reversalIndexInHand) = Game.CurrentOponnent
            .GetPlayableReversals(CardBeingPlayed.CardInfo, CardBeingPlayed.PlayedAs);
        reversalIndexInput = Game.View.AskUserToSelectAReversal(
            Game.CurrentOponnent._superstarName, playableReversalsFormatted
        );
        if (!playableReversals.Any() || reversalIndexInput == -1) { return false; }
        reversal = playableReversals[reversalIndexInput];
        Reverse(); return true;
    }

    public static void UpdateJockeyingForPBonus()
    {
        if (JockeyingFPEffectGetsActivated())
        {
            JockeyingForP.AttackPlus4D = JockeyingForP.SelectedEffect == SelectedEffect
                .NextGrappleIsPlus4D;
            JockeyingForP.ReversalPlus8F = JockeyingForP.SelectedEffect == SelectedEffect
                .NextGrapplesReversalIsPlus8F;
        }
    }

    private static bool JockeyingFPEffectGetsActivated() =>
        JockeyingForP.IsActive && CardBeingPlayed.PlayedAs == "MANEUVER" &&
        CardBeingPlayed.CardInfo.Subtypes.Contains("Grapple");

    private static void Reverse()
    {
        Game.View.SayThatPlayerReversedTheCard(
            Game.CurrentOponnent._superstarName, playableReversalsFormatted[reversalIndexInput]
        );
        Game.CurrentPlayer.DiscardCardFromHand(CardBeingPlayed.IndexInHand);
        effectCatalog.ApplyEffects(reversal.Title);
        PlayReversal();
    }

    private static void PlayReversal()
    {
        Game.CurrentOponnent.PlayCard(reversalIndexInHand[reversalIndexInput]);
        SolveJockeyingForP();
        DamageOponnentController.Damage(reversal, Int32.Parse(CardBeingPlayed.CardInfo.Damage));
        Game.EndTurn(reversal.Title == "Jockeying for Position");
    }

    private static void SolveJockeyingForP()
    {
        if (reversal.Title == "Jockeying for Position")
        {
            JockeyingForP.SelectedEffect = Game.View
                .AskUserToSelectAnEffectForJockeyForPosition(Game.CurrentOponnent._superstarName);
            JockeyingForP.IsActive = true;
        }
        else if (!(JockeyingForP.AttackPlus4D && reversal.CardEffect.Contains("does 7D")))
        {
            JockeyingForP.MakeFalse();
        }
    }
}