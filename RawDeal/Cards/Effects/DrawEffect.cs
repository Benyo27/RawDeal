namespace RawDeal;

public class DrawEffect : IEffect
{
    private int cardsToDraw;
    private string whoDiscards;
    private bool isMandatory;

    public DrawEffect(int cardsToDraw, string whoDiscards, bool isMandatory = false)
    {
        this.cardsToDraw = cardsToDraw;
        this.whoDiscards = whoDiscards;
        this.isMandatory = isMandatory;
    }

    public void Apply()
    {
        // Cuando viene de un reversal, si la carta indica "opponent",
        // corresponde a current player y viceversa
        Player playerThatDiscards = whoDiscards == "player" ?
            Game.CurrentPlayer : Game.CurrentOpponent;
        int transitoryCardsToDraw = cardsToDraw;
        if (!(whoDiscards == "opponent" || isMandatory))
        {
            transitoryCardsToDraw = Game.View.AskHowManyCardsToDrawBecauseOfACardEffect(
                playerThatDiscards._superstarName, cardsToDraw);
        }
        playerThatDiscards.DrawCards(transitoryCardsToDraw, false);
        Game.View.SayThatPlayerDrawCards(playerThatDiscards._superstarName, transitoryCardsToDraw);
    }
}