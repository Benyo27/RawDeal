namespace RawDeal;

public abstract class SuperStar
{
    public SuperStarInfo CardInfo { get; }
    public SuperStar(SuperStarInfo cardInfo) { this.CardInfo = cardInfo; }
    public abstract void UseAbility();
}