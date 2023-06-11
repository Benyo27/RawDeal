namespace RawDeal;

public class DiscardEffect : IEffect
{
    private int cardsToDiscard;

    public DiscardEffect(int cardsToDraw) => this.cardsToDiscard = cardsToDraw;

    public void Apply() => Game.CurrentPlayer.AskToDiscardCardsFromHand(cardsToDiscard);
}