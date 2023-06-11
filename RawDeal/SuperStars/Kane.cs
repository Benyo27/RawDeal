namespace RawDeal;

public class Kane : SuperStar
{
    public Kane(SuperStarInfo cardInfo) : base(cardInfo) { }
    public override void UseAbility()
    {
        Game.View.SayThatPlayerIsGoingToUseHisAbility(CardInfo.Name, CardInfo.SuperstarAbility);
        Game.View.SayThatSuperstarWillTakeSomeDamage(Game.CurrentOponnent._superstarName, 1);
        Game.CurrentOponnent.ReceiveOneDamage(1, 1);
    }
}