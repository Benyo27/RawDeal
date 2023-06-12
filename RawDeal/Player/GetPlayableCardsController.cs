using RawDealView.Formatters;

namespace RawDeal;

public class GetPlayableCardsController
{
    private CardCollection playableCards = new CardCollection(new List<CardInfo>());
    private List<string> playableCardsFormatted;
    private IntList playableCardsIndexInHand;
    private Player player;
    private static ReverseConditionCatalog reverseConditionCatalog =
        ReverseConditionCatalog.Instance;

    public GetPlayableCardsController(Player player)
    {
        this.player = player;
    }

    public (CardCollection, List<string>, IntList) GetPlayableNotReversalCards()
    {
        EmptyPlayableCardsRelatedLists();
        for (int i = 0; i < player.CardsInHand.Count; i++)
        {
            if (player._fortitudeRating >= Int32.Parse(player.CardsInHand[i].Fortitude))
            {
                ProcessNotReversalPlayableCard(i);
            }
        }
        return (playableCards, playableCardsFormatted, playableCardsIndexInHand);
    }

    private void ProcessNotReversalPlayableCard(int index)
    {
        for (int j = 0; j < player.CardsInHand[index].Types.Count; j++)
        {
            if (player.CardsInHand[index].Types[j] != "Reversal")
            {
                AddElementsToPlayableCardsRelatedLists(index, 
                    new PlayInfo(player.CardsInHand[index], 
                        player.CardsInHand[index].Types[j].ToUpper()));
            }
        }
    }

    public (CardCollection, List<string>, IntList) GetPlayableReversals(
        CardInfo cardToReverse, string playedAs)
    {
        EmptyPlayableCardsRelatedLists();
        for (int i = 0; i < player.CardsInHand.Count; i++)
        {
            if (player.HaveFortitudeToUseReversal(player.CardsInHand[i]) &&
                reverseConditionCatalog.DoesReverse(player.CardsInHand[i].Title,
                    true, cardToReverse, playedAs))
            {
                PlayInfo playInfo = new PlayInfo(player.CardsInHand[i], "REVERSAL");
                AddElementsToPlayableCardsRelatedLists(i, playInfo);
            }
        }
        return (playableCards, playableCardsFormatted, playableCardsIndexInHand);
    }

    private void EmptyPlayableCardsRelatedLists()
    {
        playableCards = new CardCollection(new List<CardInfo>());
        playableCardsFormatted = new List<string>();
        playableCardsIndexInHand = new IntList();
    }

    private void AddElementsToPlayableCardsRelatedLists(int index, PlayInfo playInfo)
    {
        playableCards.Add(player.CardsInHand[index]);
        playableCardsFormatted.Add(Formatter.PlayToString(playInfo));
        playableCardsIndexInHand.Add(index);
    }
}