namespace RawDeal;

public class NoCondition : ICondition
{
    public bool DoesReverse(bool reversalIsPlayedFromHand, CardInfo cardToReverse, string cardPlayedAs)
    {
        return false;
    }
}