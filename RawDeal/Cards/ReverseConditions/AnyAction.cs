namespace RawDeal;

public class AnyAction : ICondition
{
    public bool Accomplished(bool playedFromHand, CardInfo cardToReverse, string playedAs)
    {
        if (playedAs == "ACTION") { return true; }
        return false;
    }
}