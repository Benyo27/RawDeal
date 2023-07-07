namespace RawDeal;

public class IrishWhipCondition : IReverseCondition
{
    // private bool isIrishWhip;

    // public IrishWhipCondition(bool isIrishWhip) => this.isIrishWhip = isIrishWhip;

    public bool Accomplished(bool playedFromHand, CardInfo cardToReverse, string playedAs)
    {
        return cardToReverse.Title == "Irish Whip";
    }
}