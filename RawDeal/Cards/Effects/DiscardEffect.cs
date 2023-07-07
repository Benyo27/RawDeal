namespace RawDeal;

public class DiscardEffect : IEffect
{
    private int cardsToDiscard;
    private string whoDiscards;
    private bool fromReversal;
    private bool opponentChoose;

    public DiscardEffect(int cardsToDraw, string whoDiscards,
        bool fromReversal = false, bool opponentChoose = false)
    {
        this.cardsToDiscard = cardsToDraw;
        this.whoDiscards = whoDiscards;
        this.fromReversal = fromReversal;
        this.opponentChoose = opponentChoose;
    }

    public void Apply()
    {
        // Cuando viene de un reversal, si la carta indica "opponent",
        // corresponde a current player y viceversa
        Player playerThatDiscards = whoDiscards == "player" ?
            Game.CurrentPlayer : Game.CurrentOpponent;
        if (whoDiscards == "player" && !fromReversal)
        {
            playerThatDiscards.AskToDiscardCardsFromHand(cardsToDiscard, true);
            return;
        }
        if (opponentChoose)
        {
            playerThatDiscards.AskToDiscardCardsFromHand(cardsToDiscard, false, true);
            return;
        }
        playerThatDiscards.AskToDiscardCardsFromHand(cardsToDiscard);
    }
}