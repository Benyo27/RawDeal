namespace RawDeal;

public class TheUndertaker : SuperStar
{
    public TheUndertaker(SuperStarInfo cardInfo) : base(cardInfo) { }
    public override void UseAbility()
    {
        Game.View.SayThatPlayerIsGoingToUseHisAbility(CardInfo.Name, CardInfo.SuperstarAbility);
        Game.CurrentPlayer.AskToDiscardCardsFromHand(2);
        Game.CurrentPlayer.PassCardFromRingsideToHand(
            Game.View.AskPlayerToSelectCardsToPutInHisHand(
                CardInfo.Name, 1, 
                CardFormatter.GetCardsFormatted(Game.CurrentPlayer.CardsInRingside)
            )
        );
    }
}