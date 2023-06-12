namespace RawDeal;

public class AnyManeuver : ICondition
{
    private string subtype;
    private bool have7DCondition;

    public AnyManeuver(string subtype, bool have7DCondition)
    {
        this.subtype = subtype;
        this.have7DCondition = have7DCondition;
    }

    public bool Accomplished(bool playedFromHand, CardInfo cardToReverse, string playedAs)
    {
        if (have7DCondition && !CheckDamageToReverse(cardToReverse)) { return false; }
        bool playedAsManeuver = playedAs == "MANEUVER";
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