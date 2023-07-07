namespace RawDeal;

public class RecoverDamageEffect : IEffect
{
    private int cardsToRecover;

    public RecoverDamageEffect(int cardsToRecover)
    {
        this.cardsToRecover = cardsToRecover;
    }

    public void Apply()
    {
        for (int i = cardsToRecover; i > 0; i--)
        {
            List<string> cards = CardFormatter
                .GetCardsFormatted(Game.CurrentPlayer.CardsInRingside);
            int cardIndex = Game.View
                .AskPlayerToSelectCardsToRecover(Game.CurrentPlayer._superstarName, i, cards);
            Game.CurrentPlayer.PassCardFromRingsideToArsenalsBeginning(cardIndex);
        }
    }
}