namespace RawDeal;

public class AnySubtypeManeuver : ICondition
{
    private string subtype;

    public AnySubtypeManeuver(string subtype) => this.subtype = subtype;

    public bool DoesReverse(bool reversalIsPlayedFromHand, CardInfo cardToReverse, string cardPlayedAs)
    {
        bool playedAsManeuver = cardPlayedAs == "MANEUVER";
        bool isSubtype = subtype == "any" || cardToReverse.Subtypes.Contains(subtype);
        if (playedAsManeuver && isSubtype) { return true; }
        return false;
    }
}