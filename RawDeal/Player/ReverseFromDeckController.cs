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
        if (currentDamage == totalDamage) { return "Reversed at last card"; }
        return "Reversed";
    }
}