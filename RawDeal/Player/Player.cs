using RawDealView;
using RawDealView.Formatters;

namespace RawDeal;

// Parecido al cambio de IViewableCardInfo, Player hereda de PlayerInfo
// Por esto hago publicos los atributos de PlayerInfo (cambio en el codigo base)
public class Player : PlayerInfo
{
    private GetPlayableCardsController getPlayableCardsController;
    private CardCollection cardsInHand = new CardCollection(new List<CardInfo>());
    private CardCollection cardsInRingside = new CardCollection(new List<CardInfo>());
    private CardCollection cardsInRingArea = new CardCollection(new List<CardInfo>());
    private CardCollection cardsInArsenal = new CardCollection(new List<CardInfo>());
    private SuperStar superStar;
    private bool hasPlayedAbilityInThisTurn = false;

    public Player(
        string superstarName, int fortitudeRating,
        int numberOfCardsInHand, int numberOfCardsInArsenal)
    : base(superstarName, fortitudeRating, numberOfCardsInHand, numberOfCardsInArsenal)
    {
        SetupSuperStar();
    }

    public CardCollection CardsInHand { get { return cardsInHand; } }

    public CardCollection CardsInRingside { get { return cardsInRingside; } }

    public CardCollection CardsInRingArea { get { return cardsInRingArea; } }

    public CardCollection CardsInArsenal { get { return cardsInArsenal; } }

    public SuperStar SuperStar { get { return superStar; } }

    public bool HasPlayedAbilityInThisTurn { set { hasPlayedAbilityInThisTurn = value; } }

    public void SetupCards(CardCollection cardsInInitialArsenal)
    {
        cardsInArsenal = cardsInInitialArsenal;
        for (int i = 0; i < superStar.CardInfo.HandSize; i++)
        {
            cardsInHand.Add(cardsInArsenal[cardsInArsenal.Count - 1]);
            cardsInArsenal.RemoveAt(cardsInArsenal.Count - 1);
        }
        _numberOfCardsInArsenal -= superStar.CardInfo.HandSize;
        getPlayableCardsController = new GetPlayableCardsController(cardsInHand, _fortitudeRating);
    }

    private void SetupSuperStar() =>
        superStar = Game.SuperStars.Find(_superstarName);

    public void startTurn()
    {
        if (_superstarName == "KANE") { superStar.UseAbility(); }
        else if (_superstarName == "THE ROCK" && cardsInRingside.Count > 0)
        {
            bool playerWantToUseHisAbility = Game.View
                .DoesPlayerWantToUseHisAbility(_superstarName);
            if (playerWantToUseHisAbility) { superStar.UseAbility(); }
        }
        DrawCards(1, true);
        hasPlayedAbilityInThisTurn = false;
    }

    public (CardCollection, List<string>, IntList) GetPlayableNotReversalCards()
    {
        getPlayableCardsController.UpdatePlayerElements(cardsInHand, _fortitudeRating);
        return getPlayableCardsController.GetPlayableNotReversalCards();
    }

    public (CardCollection, List<string>, IntList) GetPlayableReversals(
        CardInfo cardToReverse, string playedAs)
    {
        getPlayableCardsController.UpdatePlayerElements(cardsInHand, _fortitudeRating);
        return getPlayableCardsController.GetPlayableReversals(cardToReverse, playedAs);
    }

    public string ReceiveDamageFromCard(int totalDamage, CardInfo cardDoingDamage, string playedAs)
    {
        for (int currentDamage = 1; currentDamage < totalDamage + 1; currentDamage++)
        {
            if (Game.APlayerHasWon(cardDoingDamage)) { return "Game Over"; }
            CardInfo cardToDiscard = ReceiveOneDamage(currentDamage, totalDamage);
            if (
                ReverseFromDeckController.DoesReverse(cardDoingDamage, cardToDiscard, playedAs) &&
                HaveFortitudeToUseReversal(cardToDiscard)
            )
            {
                return ReverseFromDeckController.Reverse(
                    cardToDiscard.Title, totalDamage, currentDamage
                );
            }
        }
        return "";
    }

    private bool HaveFortitudeToUseReversal(CardInfo card)
    {
        int transitoryFortitudeRating = Int32.Parse(card.Fortitude);
        if (JockeyingForP.ReversalPlus8F) { transitoryFortitudeRating += 8; }
        if (_fortitudeRating < transitoryFortitudeRating) { return false; }
        return true;
    }

    public CardInfo ReceiveOneDamage(int currentDamage, int totalDamage)
    {
        CardInfo cardToDiscard = cardsInArsenal[cardsInArsenal.Count - 1];
        SolvePassingCards(false, cardsInArsenal.Count - 1, cardsInArsenal, cardsInRingside);
        Game.View.ShowCardOverturnByTakingDamage(
            Formatter.CardToString(cardToDiscard), currentDamage, totalDamage
        );
        return cardToDiscard;
    }

    public void PlayCard(int cardIndex)
    {
        CardInfo cardToPlay = cardsInHand[cardIndex];
        SolvePassingCards(false, cardIndex, cardsInHand, cardsInRingArea);
        if (cardToPlay.Damage != "#") { _fortitudeRating += Int32.Parse(cardToPlay.Damage); }
    }

    public void DrawCards(int numberOfCardsToDraw, bool isFirstTimeCallingFunction = true)
    {
        for (int i = 0; i < numberOfCardsToDraw; i++)
        {
            SolvePassingCards(false, cardsInArsenal.Count - 1, cardsInArsenal, cardsInHand);
            if (IsMankindDrawSpecialCase(isFirstTimeCallingFunction)) { DrawCards(1, false); }
        }
    }

    private bool IsMankindDrawSpecialCase(bool isFirstTimeCallingFunction) =>
        _superstarName == "MANKIND" && isFirstTimeCallingFunction && _numberOfCardsInArsenal > 0;

    public void AskToDiscardCardsFromHand(int numberOfCardsToDiscard)
    {
        int currentNumberOfCardsToDiscard = numberOfCardsToDiscard;
        for (int i = 0; i < numberOfCardsToDiscard; i++)
        {
            List<string> cardsInHandFormatted = CardFormatter.GetCardsFormatted(cardsInHand);
            int cardToDiscardIndex = Game.View.AskPlayerToSelectACardToDiscard(
                cardsInHandFormatted, _superstarName, _superstarName, currentNumberOfCardsToDiscard
            );
            DiscardCardFromHand(cardToDiscardIndex); currentNumberOfCardsToDiscard--;
        }
    }

    public void DiscardCardFromHand(int cardIndex) =>
        SolvePassingCards(false, cardIndex, cardsInHand, cardsInRingside);

    public void PassCardFromRingsideToHand(int cardIndex) =>
        SolvePassingCards(false, cardIndex, cardsInRingside, cardsInHand);

    public void PassCardFromHandToArsenalsBeginning(int cardIndex) =>
        SolvePassingCards(true, cardIndex, cardsInHand, cardsInArsenal);

    public void PassCardFromRingsideToArsenalsBeginning(int cardIndex) =>
        SolvePassingCards(true, cardIndex, cardsInRingside, cardsInArsenal);

    public void SolvePassingCards(
        bool toBeginning, int cardIndex, CardCollection sourceList, CardCollection destinationList)
    {
        CardInfo cardToPass = sourceList[cardIndex];
        sourceList.RemoveAt(cardIndex);
        if (toBeginning) { destinationList.Insert(0, cardToPass); }
        else { destinationList.Add(cardToPass); }
        if (destinationList == cardsInArsenal) { _numberOfCardsInArsenal++; }
        else if (destinationList == cardsInHand) { _numberOfCardsInHand++; }
        if (sourceList == cardsInArsenal) { _numberOfCardsInArsenal--; }
        else if (sourceList == cardsInHand) { _numberOfCardsInHand--; }
    }

    public bool IsPossibleToUseAbility()
    {
        if (IsPossibleToUseAbilityAsChrisJericho()) { return true; }
        else if (IsPossibleToUseAbilityAsStoneCold()) { return true; }
        else if (IsPossibleToUseAbilityAsTheUndertaker()) { return true; }
        return false;
    }

    private bool IsPossibleToUseAbilityAsChrisJericho() =>
        _superstarName == "CHRIS JERICHO" &&
        !hasPlayedAbilityInThisTurn && _numberOfCardsInHand > 0;

    private bool IsPossibleToUseAbilityAsStoneCold() =>
        _superstarName == "STONE COLD STEVE AUSTIN" &&
        !hasPlayedAbilityInThisTurn && _numberOfCardsInArsenal > 0;

    private bool IsPossibleToUseAbilityAsTheUndertaker() =>
        _superstarName == "THE UNDERTAKER" &&
        !hasPlayedAbilityInThisTurn && _numberOfCardsInHand >= 2;
}