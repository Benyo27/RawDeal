namespace RawDeal;

public class AnyActionCondition : IReverseCondition
{
    public bool Accomplished(bool playedFromHand, CardInfo cardToReverse, string playedAs)
    {
        if (playedAs == "ACTION") { return true; }
        return false;
    }
}