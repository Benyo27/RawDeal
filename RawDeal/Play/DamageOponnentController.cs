namespace RawDeal;

public static class DamageOponnentController
{
    private static Player playerToDamage;
    private static Player playerDoingDamage;
    private static CardInfo cardDoingDamage;
    private static int cardReversingsDamage;
    private static int damage;

    public static string Damage(CardInfo cardDoingDamage, int cardReversingsDamage)
    {
        DefineClassAttributes(cardDoingDamage, cardReversingsDamage);
        if (DamageIs0()) { return ""; }
        Game.View.SayThatSuperstarWillTakeSomeDamage(playerToDamage._superstarName, damage);
        return playerToDamage.ReceiveDamageFromCard(
            damage, cardDoingDamage, CardBeingPlayed.PlayedAs
        );
    }

    private static void DefineClassAttributes(CardInfo cardDoingDamage, int cardReversingsDamage)
    {
        DefineCardsAttributes(cardDoingDamage, cardReversingsDamage);
        DefinePlayersRoles(); 
        DefineDamage();
    }

    private static void DefineCardsAttributes(CardInfo cardDoingDamage, int cardReversingsDamage)
    {
        DamageOponnentController.cardDoingDamage = cardDoingDamage;
        DamageOponnentController.cardReversingsDamage = cardReversingsDamage;
    }

    private static void DefinePlayersRoles()
    {
        playerToDamage = cardReversingsDamage == 0 ?
            Game.CurrentOponnent : Game.CurrentPlayer;
        playerDoingDamage = Object.ReferenceEquals(playerToDamage, Game.CurrentPlayer) ?
            Game.CurrentOponnent : Game.CurrentPlayer;
    }

    private static void DefineDamage()
    {
        damage = cardDoingDamage.Damage == "#" ? 
            cardReversingsDamage : Int32.Parse(cardDoingDamage.Damage);
        if (JockeyingForP.AttackPlus4D) { damage += 4; }     
        if (MankindAbilityApplies()) { damage--; }
    }

    private static bool MankindAbilityApplies() =>
        playerDoingDamage._superstarName == "MANKIND" && cardDoingDamage.Damage == "#";

    private static bool DamageIs0() => 
        damage == 0 || (playerToDamage._superstarName == "MANKIND" && --damage == 0);

    public static void SolveDamageResponse(string response)
    {
        if (response == "Game Over") { SolveDamageGameOver(); }
        else if (response != "") { SolveDamageReversed(response); }
    }

    private static void SolveDamageGameOver()
    {
        Game.View.CongratulateWinner(Game.CurrentPlayer._superstarName);
        Game.ContinuePlaying = false;
    }

    private static void SolveDamageReversed(string response)
    {
        Game.View.SayThatCardWasReversedByDeck(Game.CurrentOponnent._superstarName);
        if (StunValueApplies(response)) { SolveStunValue(); }
        Game.EndTurn();
    }

    private static bool StunValueApplies(string response) =>
        Int32.Parse(CardBeingPlayed.CardInfo.StunValue) > 0 && response == "Reversed";

    private static void SolveStunValue()
    {
        int cardsToDraw = Game.View.AskHowManyCardsToDrawBecauseOfStunValue(
            Game.CurrentPlayer._superstarName, Int32.Parse(CardBeingPlayed.CardInfo.StunValue)
        );
        if (cardsToDraw > 0)
        {
            Game.CurrentPlayer.DrawCards(cardsToDraw, false);
            Game.View.SayThatPlayerDrawCards(Game.CurrentPlayer._superstarName, cardsToDraw);
        }
    }
}