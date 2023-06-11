namespace RawDeal;

public class DrawEffect : IEffect
{
    private int cardsToDraw;

    public DrawEffect(int cardsToDraw) => this.cardsToDraw = cardsToDraw;

    public void Apply()
    {
        Game.CurrentOponnent.DrawCards(cardsToDraw, false);
        Game.View.SayThatPlayerDrawCards(Game.CurrentOponnent._superstarName, cardsToDraw);
    }
}