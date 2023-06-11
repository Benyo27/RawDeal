namespace RawDeal;

public class StoneCold : SuperStar
{
    public StoneCold(SuperStarInfo cardInfo) : base(cardInfo) { }
    public override void UseAbility()
    {
        Game.View.SayThatPlayerIsGoingToUseHisAbility(CardInfo.Name, CardInfo.SuperstarAbility);
        Game.View.SayThatPlayerDrawCards(CardInfo.Name, 1);
        Game.CurrentPlayer.DrawCards(1, true);
        Game.CurrentPlayer.PassCardFromHandToArsenalsBeginning(
            Game.View.AskPlayerToReturnOneCardFromHisHandToHisArsenal(
                CardInfo.Name, CardFormatter.GetCardsFormatted(Game.CurrentPlayer.CardsInHand)
            )
        );
    }
}