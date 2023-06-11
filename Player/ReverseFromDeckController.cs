namespace RawDeal;

public static class ReverseFromDeckController
{
    private static ReverseConditionCatalog reverseConditionCatalog = new ReverseConditionCatalog();

    public static bool DoesReverse(
        CardInfo cardDoingDamage, CardInfo cardToDiscard, string playedAs
    ) =>
        cardDoingDamage.Types[0] != "Reversal" &&
        CheckReverseCatalog(cardToDiscard.Title, cardDoingDamage, playedAs);

    private static bool CheckReverseCatalog(string cardTitle, CardInfo cardDoingDamage, string playedAs)
    {
        foreach (ICondition condition in reverseConditionCatalog.GetConditions(cardTitle))
        {
            if (!condition.DoesReverse(false, cardDoingDamage, playedAs)) { return false; }
        }
        return true;
    }

    public static string Reverse(
        string cardTitle, int totalDamage, int currentDamage)
    {
        if (cardTitle == "Jockeying for Position") { JockeingJockeyingFPReverse(); }
        if (currentDamage == totalDamage) { return "Reversed at last card"; }
        return "Reversed";
    }

    private static void JockeingJockeyingFPReverse()
    {
        JockeyingForP.SelectedEffect = Game.View
            .AskUserToSelectAnEffectForJockeyForPosition(Game.CurrentPlayer._superstarName);
        JockeyingForP.IsActive = true;
    }
}