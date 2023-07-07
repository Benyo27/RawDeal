namespace RawDeal;

public class ReceiveDamageEffect : IEffect
{
    public void Apply()
    {
        Game.View.SayThatPlayerDamagedHimself(Game.CurrentPlayer._superstarName, 1);
        Game.View.SayThatSuperstarWillTakeSomeDamage(Game.CurrentPlayer._superstarName, 1);
        if (Game.CurrentPlayer._numberOfCardsInArsenal == 0)
        {
            Game.View.SayThatPlayerLostDueToSelfDamage(Game.CurrentPlayer._superstarName);
            Game.EndGame();
            return;
        }
        Game.CurrentPlayer.ReceiveOneDamage(1, 1);
    }
}