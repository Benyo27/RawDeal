namespace RawDeal;

public class NoReverse : ICondition
{
    public bool Accomplished(bool playedFromHand, CardInfo cardToReverse, string playedAs)
    {
        return false;
    }
}