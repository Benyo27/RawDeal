using RawDealView.Formatters;
using RawDealView.Options;

namespace RawDeal;

public static class CardFormatter
{
    public static List<string> GetCardsToShowFormatted(CardSet cardsToSeeInput)
    {
        switch (cardsToSeeInput)
        {
            case CardSet.Hand:
                return GetCardsFormatted(Game.CurrentPlayer.CardsInHand);
            case CardSet.RingArea:
                return GetCardsFormatted(Game.CurrentPlayer.CardsInRingArea);
            case CardSet.RingsidePile:
                return GetCardsFormatted(Game.CurrentPlayer.CardsInRingside);
            case CardSet.OpponentsRingArea:
                return GetCardsFormatted(Game.CurrentOpponent.CardsInRingArea);
            case CardSet.OpponentsRingsidePile:
                return GetCardsFormatted(Game.CurrentOpponent.CardsInRingside);
            default:
                throw new Exception("Invalid card set");
        }
    }

    public static List<string> GetCardsFormatted(CardCollection cards)
    {
        List<string> cardsFormatted = new List<string>();
        foreach (CardInfo card in cards)
        {
            cardsFormatted.Add(Formatter.CardToString(card));
        }
        return cardsFormatted;
    }
}