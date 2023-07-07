namespace RawDeal;

public static class PlayCardController
{
    private static EffectCatalog effectCatalog = EffectCatalog.Instance;
    private static bool cardWasDiscarded = false;

    public static bool CardWasDiscarded { set => cardWasDiscarded = value; }

    public static void PlayCard()
    {
        if (!DefineCardToPlay() || ReverseFromHandController.DoesReverse()) { return; }
        Game.View.SayThatPlayerSuccessfullyPlayedACard();
        if (!ContinueAfterApplyingEffects()) { return; }
        Game.CurrentPlayer.PlayCard(CardBeingPlayed.IndexInHand);
        if (CardBeingPlayed.PlayedAs == "MANEUVER")
        {
            DamageOpponent();
            MakeBonusesFalse();
        }
    }

    private static bool DefineCardToPlay()
    {
        (CardCollection playableCards,
         List<string> playableCardsFormatted,
         IntList cardsIndexInHand) = Game.CurrentPlayer.GetPlayableNotReversalCards();
        int playInput = Game.View.AskUserToSelectAPlay(playableCardsFormatted);
        if (!playableCards.Any() || playInput == -1) { return false; }
        CardBeingPlayed.CardInfo = playableCards[playInput];
        CardBeingPlayed.PlayedAs = GetPlayedAs(playableCardsFormatted[playInput]);
        CardBeingPlayed.IndexInHand = cardsIndexInHand[playInput];
        Game.View.SayThatPlayerIsTryingToPlayThisCard(
            Game.CurrentPlayer._superstarName, playableCardsFormatted[playInput]
        );
        return true;
    }

    private static string GetPlayedAs(string cardFormatted)
    {
        string pattern = @"\[(.*?)\]";
        return RegexController.Match(cardFormatted, pattern);
    }

    private static bool ContinueAfterApplyingEffects()
    {
        effectCatalog.ApplyEffects(CardBeingPlayed.CardInfo.Title);
        if (!Game.ContinuePlaying) { return false; }
        if (cardWasDiscarded) { cardWasDiscarded = false; return false; }
        return true;
    }

    private static void DamageOpponent()
    {
        string response = DamageOpponentController.MakeDamage(CardBeingPlayed.CardInfo, 0);
        DamageOpponentController.SolveDamageResponse(response);
    }

    private static void MakeBonusesFalse()
    {
        JockeyingForPBonuses.MakeFalse();
        IrishWhipBonus.AttackPlus5D = false;
    }
}