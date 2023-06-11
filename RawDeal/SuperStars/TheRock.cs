namespace RawDeal;

public class TheRock : SuperStar
{
    public TheRock(SuperStarInfo cardInfo) : base(cardInfo) { }
    public override void UseAbility() =>
        Game.CurrentPlayer.PassCardFromRingsideToArsenalsBeginning(
            Game.View.AskPlayerToSelectCardsToRecover(
                CardInfo.Name, 1, 
                CardFormatter.GetCardsFormatted(Game.CurrentPlayer.CardsInRingside)
            )
        );
}