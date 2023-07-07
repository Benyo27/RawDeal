namespace RawDeal;

public interface IReverseCondition
{
    bool Accomplished(bool playedFromHand, CardInfo cardToReverse, string playedAs);
}