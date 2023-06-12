namespace RawDeal;

public interface ICondition
{
    bool Accomplished(bool playedFromHand, CardInfo cardToReverse, string playedAs);
}