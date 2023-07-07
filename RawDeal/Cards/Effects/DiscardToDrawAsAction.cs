namespace RawDeal;

public class DiscardToDrawAsAction : IEffect
{
    public void Apply()
    {
        if (CardBeingPlayed.PlayedAs == "ACTION")
        {
            Game.View.SayThatPlayerMustDiscardThisCard(
                Game.CurrentPlayer.SuperStar.CardInfo.Name, CardBeingPlayed.CardInfo.Title);
            Game.CurrentPlayer.DiscardCardFromHand(CardBeingPlayed.IndexInHand);
            Game.View.SayThatPlayerDrawCards(Game.CurrentPlayer.SuperStar.CardInfo.Name, 1);
            Game.CurrentPlayer.DrawCards(1, false);
            PlayCardController.CardWasDiscarded = true;
        }
    }
}