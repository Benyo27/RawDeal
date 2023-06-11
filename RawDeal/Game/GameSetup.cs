namespace RawDeal;

static class GameSetup
{
    private const int AmountOfPlayers = 2;
    private static StringList selectedDeckPaths = new StringList();
    private static StringArrayList selectedDeckLines = new StringArrayList();
    private static StringList selectedSuperStarNames = new StringList();
    private static SuperStarCollection selectedSuperStars =
        new SuperStarCollection(new List<SuperStar>());
    private static List<Player> players = new List<Player>();

    public static bool SetupGame(string deckFolder)
    {
        if (!AskToSelectAndAreDecksValid(deckFolder)) { return false; }
        GetPlayersSelections();
        SetupPlayers();
        SetupPlayersCards();
        SetupGameStart();
        return true;
    }

    private static bool AskToSelectAndAreDecksValid(string deckFolder)
    {
        for (int i = 0; i < AmountOfPlayers; i++)
        {
            string selectedDeckPath = Game.View.AskUserToSelectDeck(deckFolder);
            bool selectedDeckIsValid = DeckValidator.IsDeckValid(selectedDeckPath);
            if (!selectedDeckIsValid) { Game.View.SayThatDeckIsInvalid(); return false; }
            selectedDeckPaths.Insert(i, selectedDeckPath);
        }
        return true;
    }

    private static void GetPlayersSelections()
    {
        for (int i = 0; i < AmountOfPlayers; i++)
        {
            string[] selectedDeckLine = File.ReadAllLines(selectedDeckPaths[i]);
            selectedDeckLines.Insert(i, selectedDeckLine);
            string selectedSuperStarName = selectedDeckLine[0].Split("(")[0].Trim();
            selectedSuperStarNames.Insert(i, selectedSuperStarName);
            SuperStar selectedSuperStar = Game.SuperStars.Find(selectedSuperStarName);
            selectedSuperStars.Insert(i, selectedSuperStar);
        }
    }

    private static void SetupPlayers()
    {
        int initialFortitudeRating = 0;
        int initialNumberOfCardsInArsenal = DeckValidator.ValidDeckLength - 1;
        for (int i = 0; i < AmountOfPlayers; i++)
        {
            players.Insert(
                i,
                new Player(
                    selectedSuperStarNames[i], initialFortitudeRating,
                    selectedSuperStars[i].CardInfo.HandSize,
                    initialNumberOfCardsInArsenal
                )
            );
        }
    }

    private static void SetupPlayersCards()
    {
        for (int i = 0; i < AmountOfPlayers; i++)
        {
            CardCollection initialCardsInArsenal = GetInitialCardsInArsenal(selectedDeckLines[i]);
            players[i].SetupCards(initialCardsInArsenal);
        }
    }

    private static CardCollection GetInitialCardsInArsenal(string[] selectedDeckLines)
    {
        CardCollection initialCardsInArsenal = new CardCollection(new List<CardInfo>());
        foreach (string cardTitle in selectedDeckLines.Skip(1))
        {
            CardInfo card = Game.Cards.Find(cardTitle);
            initialCardsInArsenal.Add(card);
        }
        return initialCardsInArsenal;
    }

    private static void SetupGameStart()
    {
        Game.CurrentPlayer = players[0].SuperStar.CardInfo.SuperstarValue
            >= players[1].SuperStar.CardInfo.SuperstarValue ?
            players[0] : players[1];
        Game.CurrentOponnent = Object.ReferenceEquals(Game.CurrentPlayer, players[0]) ?
            players[1] : players[0];
        Game.View.SayThatATurnBegins(Game.CurrentPlayer._superstarName);
        Game.CurrentPlayer.startTurn();
        Game.View.ShowGameInfo(Game.CurrentPlayer, Game.CurrentOponnent);
    }
}