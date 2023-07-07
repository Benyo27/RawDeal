namespace RawDeal;

public class IrishWhipEffect : IEffect
{
    public void Apply()
    {
        if (CardBeingPlayed.PlayedAs == "ACTION")
        {
            IrishWhipBonus.AttackPlus5D = true;
        }
    }
}