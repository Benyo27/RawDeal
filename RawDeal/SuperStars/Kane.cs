namespace RawDeal;

public class Kane : SuperStar
{
    public Kane(SuperStarInfo cardInfo) : base(cardInfo) { }
    public override void UseAbility()
    {
        Game.View.SayThatPlayerIsGoingToUseHisAbility(CardInfo.Name, CardInfo.SuperstarAbility);
        Game.View.SayThatSuperstarWillTakeSomeDamage(Game.CurrentOpponent._superstarName, 1);
        Game.CurrentOpponent.ReceiveOneDamage(1, 1);
    }
}