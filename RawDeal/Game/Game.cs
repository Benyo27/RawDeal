using RawDealView;
using RawDealView.Options;

namespace RawDeal;

public class Game
{
    private static Player currentPlayer;
    private static Player currentOponnent;
    private static View view;
    private static CardCollection cards;
    private static SuperStarCollection superStars;
    private static bool continuePlaying;
    private string deckFolder;

    public Game(View view, string deckFolder)
    {
        Game.view = view; this.deckFolder = deckFolder;
        SetupCardsAttribute();
        SetupSuperStarsAttribute();
        continuePlaying = true;
    }

    public static Player CurrentPlayer
    {
        get { return currentPlayer; }
        set { currentPlayer = value; }
    }

    public static Player CurrentOponnent
    {
        get { return currentOponnent; }
        set { currentOponnent = value; }
    }

    public static View View { get { return view; } }

    public static CardCollection Cards { get { return cards; } }

    public static SuperStarCollection SuperStars { get { return superStars; } }

    public static bool ContinuePlaying { set { continuePlaying = value; } }

    private void SetupCardsAttribute()
    {
        string json = File.ReadAllText(Path.Combine("data", "cards.json"));
        List<CardInfo> unencapsulatedCards = JsonController.Deserialize<List<CardInfo>>(json);
        cards = new CardCollection(unencapsulatedCards);
    }

    private void SetupSuperStarsAttribute()
    {
        List<SuperStar> unencapsulatedSuperStars = new List<SuperStar>();
        string json = File.ReadAllText(Path.Combine("data", "superstar2.json"));
        List<SuperStarInfo> superStarsInfo = JsonController.Deserialize<List<SuperStarInfo>>(json);
        foreach (SuperStarInfo superStarInfo in superStarsInfo)
        {
            unencapsulatedSuperStars.Add(SuperStarFactory.makeSuperStar(superStarInfo));
        }
        superStars = new SuperStarCollection(unencapsulatedSuperStars);
    }

    public void Play()
    {
        if (!GameSetup.SetupGame(deckFolder)) { return; }
        while (continuePlaying)
        {
            NextPlay playInput = currentPlayer.IsPossibleToUseAbility() ?
                view.AskUserWhatToDoWhenUsingHisAbilityIsPossible() :
                view.AskUserWhatToDoWhenHeCannotUseHisAbility();
            TakeAction(playInput);
            if (continuePlaying) { view.ShowGameInfo(currentPlayer, currentOponnent); }
        }
    }

    private void TakeAction(NextPlay playInput)
    {
        if (playInput == NextPlay.ShowCards) { ShowCards(); }
        else if (playInput == NextPlay.PlayCard) { PlayCardController.PlayCard(); }
        else if (playInput == NextPlay.UseAbility) { UseAbility(); }
        else if (playInput == NextPlay.EndTurn) { EndTurn(); }
        else if (playInput == NextPlay.GiveUp) { EndGame(); }
    }

    private void ShowCards()
    {
        CardSet cardsToSeeInput = view.AskUserWhatSetOfCardsHeWantsToSee();
        List<string> cardsToShow = CardFormatter.GetCardsToShowFormatted(cardsToSeeInput);
        view.ShowCards(cardsToShow);
    }

    private void UseAbility()
    {
        currentPlayer.SuperStar.UseAbility();
        currentPlayer.HasPlayedAbilityInThisTurn = true;
    }

    public static void EndTurn(bool isJockeyingFPEffectStillActive = false)
    {
        if (APlayerHasWon()) { EndGame(); return; }
        view.SayThatATurnBegins(currentOponnent._superstarName);
        UpdatePlayersRoles();
        currentPlayer.startTurn();
        UpdateJockeyingForPBonus(isJockeyingFPEffectStillActive);
    }

    private static bool APlayerHasWon() =>
        currentPlayer._numberOfCardsInArsenal == 0 ||
        currentOponnent._numberOfCardsInArsenal == 0;

    private static void EndGame()
    {
        string winnersName = currentOponnent._numberOfCardsInArsenal == 0 ?
            currentPlayer._superstarName :
            currentOponnent._superstarName;
        view.CongratulateWinner(winnersName);
        continuePlaying = false;
    }

    private static void UpdatePlayersRoles()
    {
        Player lastCurrentPlayer = currentPlayer;
        currentPlayer = currentOponnent;
        currentOponnent = lastCurrentPlayer;
    }
    private static void UpdateJockeyingForPBonus(bool isJockeyingFPEffectStillActive)
    {
        JockeyingForP.IsActive = isJockeyingFPEffectStillActive;
        JockeyingForP.AttackPlus4D = false;
    }

    public static bool APlayerHasWon(CardInfo cardDoingDamage) =>
        currentOponnent._numberOfCardsInArsenal == 0 ||
        (
            currentPlayer._numberOfCardsInArsenal == 0 &&
            cardDoingDamage.Types[0] == "Reversal"
        );
}