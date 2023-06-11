namespace RawDeal;

public class ChrisJericho : SuperStar
{
    public ChrisJericho(SuperStarInfo cardInfo) : base(cardInfo) { }
    public override void UseAbility()
    {
        Game.View.SayThatPlayerIsGoingToUseHisAbility(CardInfo.Name, CardInfo.SuperstarAbility);
        Game.CurrentPlayer.AskToDiscardCardsFromHand(1);
        Game.CurrentOponnent.AskToDiscardCardsFromHand(1);
    }
}