namespace RawDeal;

public class JockeyingForPosition : ICondition
{
    private bool isJockeyingForP;

    public JockeyingForPosition(bool isJockeyingForP) => this.isJockeyingForP = isJockeyingForP;

    public bool Accomplished(bool playedFromHand, CardInfo cardToReverse, string playedAs)
    {
        if (cardToReverse.Title != "Jockeying for Position") { return false; }
        if (isJockeyingForP) { return true; }
        if (playedFromHand) { return true; }
        return false;
    }
}