using RawDealView.Options;

namespace RawDeal;

public static class JockeyingForP
{
    public static bool IsActive = false;
    public static SelectedEffect SelectedEffect { get; set; }
    public static bool AttackPlus4D = false;
    public static bool ReversalPlus8F = false;

    public static void MakeFalse()
    {
        IsActive = false;
        AttackPlus4D = false;
        ReversalPlus8F = false;
    }
}