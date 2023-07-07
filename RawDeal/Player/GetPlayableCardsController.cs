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

    public GetPlayableCardsController(Player player) => this.player = player;

    public (CardCollection, List<string>, IntList) GetPlayableNotReversalCards()
    {
        EmptyPlayableCardsRelatedLists();
        for (int i = 0; i < player.CardsInHand.Count; i++)
        {
            ProcessNotReversalPlayableCard(i);
        }
        return (playableCards, playableCardsFormatted, playableCardsIndexInHand);
    }

    private void ProcessNotReversalPlayableCard(int index)
    {
        for (int j = 0; j < player.CardsInHand[index].Types.Count; j++)
        {
            if (CardIsPlayable(index, j))
            {
                PlayInfo playInfo = new PlayInfo(player.CardsInHand[index],
                    player.CardsInHand[index].Types[j].ToUpper());
                AddElementsToPlayableCardsRelatedLists(index, playInfo);
            }
        }
    }

    private bool CardIsPlayable(int cardIndex, int typeIndex) =>
        PlayerHaveEnoughFortitudeToPlayCard(cardIndex, typeIndex) &&
        CurrentTypeIsNotReversal(cardIndex, typeIndex) &&
        !IsSpitAtOpponentCase(cardIndex) &&
        !IsLionsaultCase(cardIndex) && !IsAustinElbowSmashCase(cardIndex);

    private bool PlayerHaveEnoughFortitudeToPlayCard(int cardIndex, int typeIndex) =>
        player._fortitudeRating >= Int32.Parse(player.CardsInHand[cardIndex].Fortitude) ||
        IsUndertakersTombstoneCase(cardIndex, typeIndex);

    private bool IsUndertakersTombstoneCase(int cardIndex, int typeIndex) =>
        player.CardsInHand[cardIndex].Title == "Undertaker's Tombstone Piledriver" &&
        player.CardsInHand[cardIndex].Types[typeIndex] == "Action";

    private bool CurrentTypeIsNotReversal(int cardIndex, int typeIndex) =>
        player.CardsInHand[cardIndex].Types[typeIndex] != "Reversal";

    private bool IsSpitAtOpponentCase(int index) =>
        player.CardsInHand[index].Title == "Spit At Opponent" && player.CardsInHand.Count < 2;

    private bool IsLionsaultCase(int index) =>
        player.CardsInHand[index].Title == "Lionsault" && !ConditionsToPlayCards.LionSaultPlayable;

    private bool IsAustinElbowSmashCase(int index) =>
        player.CardsInHand[index].Title == "Austin Elbow Smash" &&
        !ConditionsToPlayCards.AustinElbowSmashPlayable;

    public (CardCollection, List<string>, IntList) GetPlayableReversals(
        CardInfo cardToReverse, string playedAs)
    {
        EmptyPlayableCardsRelatedLists();
        for (int i = 0; i < player.CardsInHand.Count; i++)
        {
            if (ReversalIsPlayable(i, cardToReverse, playedAs))
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

    private bool ReversalIsPlayable(int index, CardInfo cardToReverse, string playedAs) =>
        player.HaveFortitudeToUseReversal(player.CardsInHand[index]) &&
        reverseConditionCatalog.DoesReverse(player.CardsInHand[index].Title,
            true, cardToReverse, playedAs) &&
        cardToReverse.Title != "Tree of Woe" && cardToReverse.Title != "Austin Elbow Smash";

    private void AddElementsToPlayableCardsRelatedLists(int index, PlayInfo playInfo)
    {
        playableCards.Add(player.CardsInHand[index]);
        playableCardsFormatted.Add(Formatter.PlayToString(playInfo));
        playableCardsIndexInHand.Add(index);
    }
}