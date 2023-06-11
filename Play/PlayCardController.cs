namespace RawDeal;

public static class PlayCardController
{
    public static void PlayCard()
    {
        if (!DefineCardToPlay()) { return; }
        if (ReverseFromHandController.DoesReverse()) { return; }
        Game.View.SayThatPlayerSuccessfullyPlayedACard();
        if (CardBeingPlayed.PlayedAs == "ACTION") { PlayCardAsAction(); return; }
        else { PlayCardAsManeuver(); }
        JockeyingForP.MakeFalse();
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

    private static void PlayCardAsAction()
    {
        if (CardBeingPlayed.CardInfo.Title == "Jockeying for Position")
        {
            PlayJockeyingFPAsAction(); return;
        }
        Game.View.SayThatPlayerMustDiscardThisCard(
            Game.CurrentPlayer.SuperStar.CardInfo.Name, CardBeingPlayed.CardInfo.Title
        );
        Game.CurrentPlayer.DiscardCardFromHand(CardBeingPlayed.IndexInHand);
        Game.View.SayThatPlayerDrawCards(Game.CurrentPlayer.SuperStar.CardInfo.Name, 1);
        Game.CurrentPlayer.DrawCards(1, false);
    }

    private static void PlayJockeyingFPAsAction()
    {
        JockeyingForP.SelectedEffect = Game.View.AskUserToSelectAnEffectForJockeyForPosition(
            Game.CurrentPlayer._superstarName
        );
        JockeyingForP.IsActive = true;
        Game.CurrentPlayer.PlayCard(CardBeingPlayed.IndexInHand);
    }

    private static void PlayCardAsManeuver()
    {
        Game.CurrentPlayer.PlayCard(CardBeingPlayed.IndexInHand);
        string response = DamageOponnentController.Damage(CardBeingPlayed.CardInfo, 0);
        DamageOponnentController.SolveDamageResponse(response);
    }
}