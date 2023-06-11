namespace RawDeal;

public interface ICondition
{
    bool DoesReverse(bool reversalIsPlayedFromHand, CardInfo cardToReverse, string cardPlayedAs);
}