namespace RawDeal;

public static class ReverseFromDeckController
{
    private static ReverseConditionCatalog reverseConditionCatalog =
        ReverseConditionCatalog.Instance;

    public static bool DoesReverse(
        CardInfo cardDoingDamage, CardInfo cardToDiscard, string playedAs
    ) =>
        cardDoingDamage.Types[0] != "Reversal" &&
        reverseConditionCatalog.DoesReverse(cardToDiscard.Title, false, cardDoingDamage, playedAs);

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