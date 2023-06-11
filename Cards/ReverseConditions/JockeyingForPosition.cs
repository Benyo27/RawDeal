namespace RawDeal;

public class JockeyingForPosition : ICondition
{
    private bool isJockeyingForP;

    public JockeyingForPosition(bool isJockeyingForP) => this.isJockeyingForP = isJockeyingForP;

    public bool DoesReverse(bool reversalIsPlayedFromHand, CardInfo cardToReverse, string cardPlayedAs)
    {
        if (cardToReverse.Title != "Jockeying for Position") { return false; }
        if (isJockeyingForP) { return true; }
        if (reversalIsPlayedFromHand) { return true; }
        return false;
    }
}