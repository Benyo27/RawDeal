namespace RawDeal;

public class AnyAction : ICondition
{
    public bool DoesReverse(bool reversalIsPlayedFromHand, CardInfo cardToReverse, string cardPlayedAs)
    {
        if (cardPlayedAs == "ACTION") { return true; }
        return false;
    }
}