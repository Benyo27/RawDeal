namespace RawDeal;

public class JockeyingForPositionEffect : IEffect
{
    public void Apply()
    {
        if (CardBeingPlayed.PlayedAs == "ACTION")
        {
            JockeyingForPBonuses.SelectedEffect = Game.View
                .AskUserToSelectAnEffectForJockeyForPosition(Game.CurrentPlayer._superstarName);
            JockeyingForPBonuses.IsActive = true;
        }
    }
}