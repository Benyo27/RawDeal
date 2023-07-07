namespace RawDeal;

public class NoReverse : IReverseCondition
{
    public bool Accomplished(bool playedFromHand, CardInfo cardToReverse, string playedAs)
    {
        return false;
    }
}