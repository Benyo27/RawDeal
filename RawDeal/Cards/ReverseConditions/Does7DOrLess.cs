namespace RawDeal;

public class Does7DOrLess : ICondition
{
    private string subtype;

    public Does7DOrLess(string subtype) => this.subtype = subtype;

    public bool DoesReverse(bool reversalIsPlayedFromHand, CardInfo cardToReverse, string cardPlayedAs)
    {
        if (!CheckDamageToReverse(cardToReverse)) { return false; }
        bool playedAsManeuver = cardPlayedAs == "MANEUVER";
        bool isSubtype = subtype == "any" || cardToReverse.Subtypes.Contains(subtype);
        if (playedAsManeuver && isSubtype) { return true; }
        return false;
    }

    private static bool CheckDamageToReverse(CardInfo cardToReverse)
    {
        int transitoryDamage = Int32.Parse(cardToReverse.Damage);
        if (JockeyingForP.AttackPlus4D) { transitoryDamage += 4; }
        if (transitoryDamage > 7) { return false; }
        return true;
    }
}