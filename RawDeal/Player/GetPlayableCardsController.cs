using RawDealView.Formatters;

namespace RawDeal;

public class GetPlayableCardsController
{
    private CardCollection playableCards = new CardCollection(new List<CardInfo>());
    private List<string> playableCardsFormatted;
    private IntList playableCardsIndexInHand;
    private CardCollection cardsInHand = new CardCollection(new List<CardInfo>());
    private int fortitudeRating;
    private static ReverseConditionCatalog reverseConditionCatalog = new ReverseConditionCatalog();

    public GetPlayableCardsController(CardCollection cardsInHand, int fortitudeRating)
    {
        this.cardsInHand = cardsInHand;
        this.fortitudeRating = fortitudeRating;
    }

    public void UpdatePlayerElements(CardCollection currentCardsInHand, int currentFortitudeRating)
    {
        cardsInHand = currentCardsInHand;
        fortitudeRating = currentFortitudeRating;
    }

    public (CardCollection, List<string>, IntList) GetPlayableNotReversalCards()
    {
        EmptyPlayableCardsRelatedLists();
        for (int i = 0; i < cardsInHand.Count; i++)
        {
            if (fortitudeRating >= Int32.Parse(cardsInHand[i].Fortitude))
            {
                ProcessNotReversalPlayableCard(i);
            }
        }
        return (playableCards, playableCardsFormatted, playableCardsIndexInHand);
    }

    private void ProcessNotReversalPlayableCard(int index)
    {
        for (int j = 0; j < cardsInHand[index].Types.Count; j++)
        {
            if (cardsInHand[index].Types[j] != "Reversal")
            {
                AddElementsToPlayableCardsRelatedLists(
                    index,
                    new PlayInfo(cardsInHand[index], cardsInHand[index].Types[j].ToUpper())
                );
            }
        }
    }

    public (CardCollection, List<string>, IntList) GetPlayableReversals(
        CardInfo cardToReverse, string playedAs)
    {
        EmptyPlayableCardsRelatedLists();
        for (int i = 0; i < cardsInHand.Count; i++)
        {
            if (HaveFortitudeToUseReversal(cardsInHand[i]) &&
                CheckReverseCatalog(cardsInHand[i].Title, cardToReverse, playedAs))
            {
                PlayInfo playInfo = new PlayInfo(cardsInHand[i], "REVERSAL");
                AddElementsToPlayableCardsRelatedLists(i, playInfo);
            }
        }
        return (playableCards, playableCardsFormatted, playableCardsIndexInHand);
    }

    private static bool CheckReverseCatalog(string cardTitle, CardInfo cardDoingDamage, string playedAs)
    {
        foreach (ICondition condition in reverseConditionCatalog.GetConditions(cardTitle))
        {
            if (!condition.DoesReverse(true, cardDoingDamage, playedAs)) { return false; }
        }
        return true;
    }

    private bool HaveFortitudeToUseReversal(CardInfo card)
    {
        int transitoryFortitudeRating = Int32.Parse(card.Fortitude);
        if (JockeyingForP.ReversalPlus8F) { transitoryFortitudeRating += 8; }
        if (fortitudeRating < transitoryFortitudeRating) { return false; }
        return true;
    }

    private void EmptyPlayableCardsRelatedLists()
    {
        playableCards = new CardCollection(new List<CardInfo>());
        playableCardsFormatted = new List<string>();
        playableCardsIndexInHand = new IntList();
    }

    private void AddElementsToPlayableCardsRelatedLists(int index, PlayInfo playInfo)
    {
        playableCards.Add(cardsInHand[index]);
        playableCardsFormatted.Add(Formatter.PlayToString(playInfo));
        playableCardsIndexInHand.Add(index);
    }
}