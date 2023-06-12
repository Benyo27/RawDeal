namespace RawDeal;

public class ReverseConditionCatalog
{
    private static ReverseConditionCatalog instance = new ReverseConditionCatalog();
    private ConditionDictionary conditions;

    public static ReverseConditionCatalog Instance { get { return instance; } }

    public bool DoesReverse(
        string cardTitle, bool playedFromHand, CardInfo cardDoingDamage, string playedAs)
    {
        foreach (ICondition condition in instance.GetConditions(cardTitle))
        {
            if (!condition.Accomplished(playedFromHand, cardDoingDamage, playedAs))
            {
                return false;
            }
        }
        return true;
    }

    public ConditionCollection GetConditions(string cardTitle)
    {
        if (!conditions.ContainsKey(cardTitle))
        {
            return new ConditionCollection { new NoReverse() };
        }
        return conditions[cardTitle];
    }

    private ReverseConditionCatalog()
    {
        conditions = new ConditionDictionary();
        // TODO : As an action, you may discard this card to draw 1 card. Doing this will not cause any damage to opponent. 
        conditions["Chop"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, discard 1 card of your choice from your hand. 
        conditions["Head Butt"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, all Strike maneuvers are +1D for the rest of this turn. 
        conditions["Haymaker"] = new ConditionCollection { new NoReverse() };
        // TODO : The card titled Irish Whip must be played before playing this card. When successfully played, you may either draw 2 cards, or force opponent to discard 2 cards. 
        conditions["Back Body Drop"] = new ConditionCollection { new NoReverse() };
        // TODO : May only reverse a maneuver played after the card titled Irish Whip. 
        conditions["Shoulder Block"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, you must take the top card of your Arsenal and put it into your Ringside pile. 
        conditions["Kick"] = new ConditionCollection { new NoReverse() };
        // TODO : The card titled Irish Whip must be played before playing this card. May only reverse a maneuver played after the card titled Irish Whip. 
        conditions["Cross Body Block"] = new ConditionCollection { new NoReverse() };
        // TODO : May only reverse the maneuver titled Kick. 
        conditions["Ensugiri"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, you must take the top card of your Arsenal and put it into your Ringside pile. 
        conditions["Running Elbow Smash"] = new ConditionCollection { new NoReverse() };
        // TODO : May only reverse the maneuver titled Drop Kick. 
        conditions["Drop Kick"] = new ConditionCollection { new NoReverse() };
        // TODO : Reversals to this maneuver are +2D. 
        conditions["Discus Punch"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, +5D if played after a 5D or greater maneuver. 
        conditions["Superkick"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, opponent must discard 1 card. 
        conditions["Spinning Heel Kick"] = new ConditionCollection { new NoReverse() };
        // TODO : May only reverse a maneuver played after the card titled Irish Whip. 
        conditions["Spear"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, if your next card played this turn is a maneuver it is +2D. 
        conditions["Clothesline"] = new ConditionCollection { new NoReverse() };
        // TODO : As an action, you may discard this card to draw 1 card. Doing this will not cause any damage to opponent. 
        conditions["Arm Bar Takedown"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, discard 1 card of your choice from your hand. 
        conditions["Arm Drag"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, if your next card played this turn is a Strike maneuver it is +2D. 
        conditions["Snap Mare"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, you may draw 1 card. 
        conditions["Double Leg Takedown"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, you may look at your opponent's hand. 
        conditions["Fireman's Carry"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, opponent must draw 1 card. 
        conditions["Headlock Takedown"] = new ConditionCollection { new NoReverse() };
        // TODO : May only reverse the maneuver titled Belly to Belly Suplex. 
        conditions["Belly to Belly Suplex"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, if your next card played this turn is a maneuver it is +2D. 
        conditions["Atomic Drop"] = new ConditionCollection { new NoReverse() };
        // TODO : May only reverse the maneuver titled Vertical Suplex. 
        conditions["Vertical Suplex"] = new ConditionCollection { new NoReverse() };
        // TODO : May only reverse the maneuver titled Belly to Back Suplex. 
        conditions["Belly to Back Suplex"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, opponent must discard 2 cards. 
        conditions["Pump Handle Slam"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, you may draw 1 card. 
        conditions["Reverse DDT"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, opponent must discard 1 card. 
        conditions["Samoan Drop"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, discard 1 card of your choice from your hand. Look at opponent's hand, then choose and discard 1 card from his hand. 
        conditions["Bulldog"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, you must take the top card of your Arsenal and put it into your Ringside pile. You may draw 1 card. 
        conditions["Fisherman's Suplex"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, you must take the top card of your Arsenal and put it into your Ringside pile. Opponent must discard 2 cards. 
        conditions["DDT"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, opponent must discard 1 card. 
        conditions["Power Slam"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, you may draw 1 card. Add +1D for every maneuver with the word "slam" in its title in your Ring area. 
        conditions["Powerbomb"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, you must take the top card of your Arsenal and put it into your Ringside pile. Opponent must discard 2 cards. 
        conditions["Press Slam"] = new ConditionCollection { new NoReverse() };
        // TODO : As an action, you may discard this card to draw 1 card. Doing this will not cause any damage to opponent. 
        conditions["Collar & Elbow Lockup"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, discard 1 card of your choice from your hand. 
        conditions["Arm Bar"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, opponent must discard 1 card. 
        conditions["Bear Hug"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, look through your Arsenal for the card titled Maintain Hold and place that card in your hand, then shuffle your Arsenal. 
        conditions["Full Nelson"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, opponent must discard 1 card. 
        conditions["Choke Hold"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, opponent must discard 1 card. 
        conditions["Ankle Lock"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, opponent must draw 1 card. 
        conditions["Standing Side Headlock"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, look through your Arsenal for the card titled Maintain Hold and place that card in your hand, then shuffle your Arsenal. 
        conditions["Cobra Clutch"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, shuffle 2 cards from your Ringside pile into your Arsenal. 
        conditions["Chicken Wing"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, look through your Arsenal for the card titled Maintain Hold and place that card in your hand, then shuffle your Arsenal. 
        conditions["Sleeper"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, look through your Arsenal for the card titled Maintain Hold and place that card in your hand, then shuffle your Arsenal. 
        conditions["Camel Clutch"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, opponent must discard 1 card. 
        conditions["Boston Crab"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, opponent must discard 1 card and you may draw 1 card. 
        conditions["Guillotine Stretch"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, you may discard 3 cards, search through your Arsenal and put 1 card into your hand, then shuffle your Arsenal. 
        conditions["Abdominal Stretch"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, opponent must discard 1 card. 
        conditions["Torture Rack"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, opponent must discard 1 card. 
        conditions["Figure Four Leg Lock"] = new ConditionCollection { new NoReverse() };
        // Reverse any Strike maneuver and end your opponent's turn. 
        conditions["Step Aside"] = new ConditionCollection { new AnyManeuver("Strike", false) };
        // Reverse any Grapple maneuver and end your opponent's turn. 
        conditions["Escape Move"] = new ConditionCollection { new AnyManeuver("Grapple", false) };
        // Reverse any Submission maneuver and end your opponent's turn. 
        conditions["Break the Hold"] = new ConditionCollection { new AnyManeuver("Submission", false) };
        // Can only reverse a Grapple that does 7D or less. End your opponent's turn. # = D of maneuver card being reversed. Read as 0 when in your Ring area. 
        conditions["Rolling Takedown"] = new ConditionCollection { new AnyManeuver("Grapple", true) };
        // Can only reverse a Strike that does 7D or less. End your opponent's turn. # = D of maneuver card being reversed. Read as 0 when in your Ring area. 
        conditions["Knee to the Gut"] = new ConditionCollection { new AnyManeuver("Strike", true) };
        // May reverse any maneuver that does 7D or less. End your opponent's turn. 
        conditions["Elbow to the Face"] = new ConditionCollection { new AnyManeuver("any", true) };
        // If played from your hand, may reverse the card titled Jockeying for Position. Opponent must discard 4 cards. End your opponent's turn. Draw 1 card. 
        conditions["Clean Break"] = new ConditionCollection { new JockeyingForPosition(false) };
        // Reverse any maneuver and end your opponent's turn. If played from your hand draw 1 card. 
        conditions["Manager Interferes"] = new ConditionCollection { new AnyManeuver("any", false) };
        // TODO : Reverse any HEEL maneuver or reversal card if that opponent has 5 or more HEEL cards in his Ring area. Opponent is Disqualified and you win the game. This effect happens even if the card titled Disqualification is placed into your Ringside pile while applying damage from a HEEL maneuver or reversal card. 
        conditions["Disqualification!"] = new ConditionCollection { new NoReverse() };
        // Reverse any ACTION card being played by your opponent from his hand. It is unsuccessful, goes to his Ringside pile, has no effect and ends his turn. 
        conditions["No Chance in Hell"] = new ConditionCollection { new AnyAction() };
        // TODO : Look at the top 5 cards of your Arsenal. You may either arrange them in any order or shuffle your Arsenal. 
        conditions["Hmmm"] = new ConditionCollection { new NoReverse() };
        // TODO : Look at the top 5 cards of an opponent's Arsenal. You may either arrange them in any order or make him shuffle his Arsenal. 
        conditions["Don't Think Too Hard"] = new ConditionCollection { new NoReverse() };
        // TODO : Look at opponent's hand. 
        conditions["Whaddya Got?"] = new ConditionCollection { new NoReverse() };
        // TODO : Take a card in your hand, shuffle it into your Arsenal, then draw 2 cards. 
        conditions["Not Yet"] = new ConditionCollection { new NoReverse() };
        // As an action, if your next card played is a Grapple maneuver, declare whether it will be +4D or your opponent's reversal to it will be +8F. As a reversal, may only reverse the card titled Jockeying for Position. If so, you end opponent's turn; and if your next card played on your turn is a Grapple maneuver, declare whether it will be +4D or your opponent's reversal to it will be +8F. 
        conditions["Jockeying for Position"] = new ConditionCollection { new JockeyingForPosition(true) };
        // TODO : As an action, if your next card played is a Strike maneuver it is +5D. As a reversal, may only reverse the card titled Irish Whip. If so, you end opponent's turn; and if your next card played on your turn is a Strike maneuver it is +5D. 
        conditions["Irish Whip"] = new ConditionCollection { new NoReverse() };
        // TODO : Draw 1 card. Look at opponent's hand, and then make him discard all HEEL cards. 
        conditions["Flash in the Pan"] = new ConditionCollection { new NoReverse() };
        // TODO : Draw 1 card. Look at opponent's hand, and then make him discard all FACE cards. 
        conditions["View of Villainy"] = new ConditionCollection { new NoReverse() };
        // TODO : Playable only if your Fortitude Rating is less than your opponent's Fortitude Rating. Remove any 1 card in opponent's Ring area with a D value less than or equal to your total Fortitude Rating and place it into his Ringside pile. 
        conditions["Shake It Off"] = new ConditionCollection { new NoReverse() };
        // TODO : Draw up to 3 cards, then discard 1 card. 
        conditions["Offer Handshake"] = new ConditionCollection { new NoReverse() };
        // TODO : Discard up to 2 cards from your hand to your Ringside pile. Return an equal number of cards of your choice to your hand from your Ringside pile. 
        conditions["Roll Out of the Ring"] = new ConditionCollection { new NoReverse() };
        // TODO : Draw 1 card. Look at opponent's hand. If he has any cards titled Disqualification! he must discard them. 
        conditions["Distract the Ref"] = new ConditionCollection { new NoReverse() };
        // TODO : Shuffle any 2 cards from your Ringside pile back into your Arsenal. Then draw 1 card. 
        conditions["Recovery"] = new ConditionCollection { new NoReverse() };
        // TODO : Can only be played when you have 2 or more cards in your hand. Discard 1 card and then your opponent discards 4 cards. 
        conditions["Spit At Opponent"] = new ConditionCollection { new NoReverse() };
        // TODO : Draw 1 card. Your next maneuver this turn is +4D and opponent's reversals are +12F. 
        conditions["Get Crowd Support"] = new ConditionCollection { new NoReverse() };
        // TODO : Discard 3 cards of your choice from your hand. All players compare their current Fortitude Rating. The player(s) with a higher Fortitude Rating must remove maneuver and/or reversal cards from their Ring area, putting them into his Ringside pile, until that player's Fortitude Rating is less than or equal to the others. 
        conditions["Comeback!"] = new ConditionCollection { new NoReverse() };
        // TODO : Your next card played is -5F. If opponent forces you to discard a card from your hand, you may choose to discard this card from your hand and then draw up to 2 cards. 
        conditions["Ego Boost"] = new ConditionCollection { new NoReverse() };
        // TODO : Draw 4 cards. At end of turn, discard your hand. 
        conditions["Deluding Yourself"] = new ConditionCollection { new NoReverse() };
        // TODO : Play after a successfully played maneuver. If your next card played this turn is a maneuver of 7D or less your opponent can not reverse it. 
        conditions["Stagger"] = new ConditionCollection { new NoReverse() };
        // TODO : Your next maneuver may not be reversed. 
        conditions["Diversion"] = new ConditionCollection { new NoReverse() };
        // TODO : Choose one: Look through your Arsenal and put 1 card in your hand, shuffle it and end your turn; or go through opponent's Arsenal and put any 3 cards into his Ringside pile, then shuffle his Arsenal. 
        conditions["Marking Out"] = new ConditionCollection { new NoReverse() };
        // TODO : Shuffle up to 5 cards from your Ringside pile into your Arsenal. Then draw 2 cards. 
        conditions["Puppies! Puppies!"] = new ConditionCollection { new NoReverse() };
        // TODO : While this card is in your Ring area, at the start of your turn, before your draw segment, opponent must take the top card from his Arsenal and place it into his Ringside pile. 
        conditions["Shane O'Mac"] = new ConditionCollection { new NoReverse() };
        // TODO : Play after a successful Submission maneuver not reversed and end your turn. You and your opponent may not play maneuvers or actions until your opponent reverses the maintained Submission. On your turn, during the main segment, the Submission does its damage, along with any other abilities on the card. If a reversal is played by your opponent or is revealed while applying damage, both Maintain Hold and the Submission maneuver remain in your Ring area, but you may no longer use the ability of this Maintain Hold card. 
        conditions["Maintain Hold"] = new ConditionCollection { new NoReverse() };
        // TODO : Opponent skips his next turn. 
        conditions["Pat & Gerry"] = new ConditionCollection { new NoReverse() };
        // TODO : May not be reversed. Can only be played after a maneuver that does 5D or greater. 
        conditions["Austin Elbow Smash"] = new ConditionCollection { new NoReverse() };
        // TODO : If played from your hand, may reverse a maneuver played after the card titled Irish Whip. End your opponent's turn. You may draw 1 card. 
        conditions["Lou Thesz Press"] = new ConditionCollection { new NoReverse() };
        // TODO : Reverse any Strike, Grapple or Submission maneuver. End your opponent's turn. If played from your hand, opponent must discard 2 cards, then take the top 2 cards from his Arsenal and put them into his Ringside pile. 
        conditions["Double Digits"] = new ConditionCollection { new NoReverse() };
        // TODO : -6F on this card if played after the maneuver titled Kick. 
        conditions["Stone Cold Stunner"] = new ConditionCollection { new NoReverse() };
        // TODO : Your next maneuver this turn is +6D, and your opponent's reversal to it is +20F. Draw a card. 
        conditions["Open Up a Can of Whoop-A%$"] = new ConditionCollection { new NoReverse() };
        // TODO : Can only be played after a 5D or greater maneuver. Reversals to this maneuver are +6D. 
        conditions["Undertaker's Flying Clothesline"] = new ConditionCollection { new NoReverse() };
        // TODO : Reverse any maneuver and end your opponent's turn. If played from your hand, take the top 4 cards from your Arsenal and put them in your Ringside pile. Opponent must discard 1 card; next turn, all your maneuvers are +2D, and all opponent's reversals are +25F. 
        conditions["Undertaker Sits Up!"] = new ConditionCollection { new NoReverse() };
        // TODO : As an action, this card is -30F and -25D, discard this card and draw 1 card. 
        conditions["Undertaker's Tombstone Piledriver"] = new ConditionCollection { new NoReverse() };
        // TODO : +5D to all your maneuvers and +20F to all of opponent's reversals for the rest of this turn. 
        conditions["Power of Darkness"] = new ConditionCollection { new NoReverse() };
        // TODO : Reverse any Strike, Grapple or Submission maneuver. End your opponent's turn. If played from your hand, opponent discards all cards in his hand. 
        conditions["Have a Nice Day!"] = new ConditionCollection { new NoReverse() };
        // TODO : May only reverse the maneuver titled Back Body Drop. 
        conditions["Double Arm DDT"] = new ConditionCollection { new NoReverse() };
        // TODO : May not be reversed. When successfully played, opponent must discard 2 cards. 
        conditions["Tree of Woe"] = new ConditionCollection { new NoReverse() };
        // TODO : -6F on this card if Mr. Socko card is in your Ring area. You may play the card titled Maintain Hold after this card as if it were a Submission maneuver. 
        conditions["Mandible Claw"] = new ConditionCollection { new NoReverse() };
        // TODO : Take 1 card from either your Arsenal or Ringside pile and place it into your hand, then shuffle your Arsenal. While Mr. Socko is in your Ring area, all your maneuvers are +1D. 
        conditions["Mr. Socko"] = new ConditionCollection { new NoReverse() };
        // TODO : May not be reversed. You must play the card titled Irish Whip before playing this card. When successfully played, opponent discards 1 card. 
        conditions["Leaping Knee to the Face"] = new ConditionCollection { new NoReverse() };
        // TODO : If played from your hand, may reverse a maneuver played after the card titled Irish Whip. End your opponent's turn. You may draw 2 cards. 
        conditions["Facebuster"] = new ConditionCollection { new NoReverse() };
        // TODO : All your maneuvers are +3D for the rest of this turn. Draw 2 cards, or force opponent to discard 2 cards. 
        conditions["I Am the Game"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, +2D if played after a Strike maneuver. May only reverse the maneuver titled Back Body Drop. 
        conditions["Pedigree"] = new ConditionCollection { new NoReverse() };
        // Reverses any maneuver and ends your opponent's turn. If played from your hand, draw 2 cards. 
        conditions["Chyna Interferes"] = new ConditionCollection { new AnyManeuver("any", false) };
        // TODO : Draw 1 card. Look at your opponent's hand. Your next maneuver this turn is +6D. 
        conditions["Smackdown Hotel"] = new ConditionCollection { new NoReverse() };
        // TODO : Reverse any Strike, Grapple or Submission maneuver. End your opponent's turn. If played from your hand, shuffle up to 5 cards from your Ringside pile into your Arsenal. 
        conditions["Take That Move, Shine It Up Real Nice, Turn That Sumb*tch Sideways, and Stick It Straight Up Your Roody Poo Candy A%$!"] = new ConditionCollection { new NoReverse() };
        // TODO : When successfully played, look through your Ringside pile and Arsenal for the card titled The People's Elbow and place that card in your hand, then shuffle your Arsenal. May only reverse a Grapple maneuver, but you must first discard 1 card. 
        conditions["Rock Bottom"] = new ConditionCollection { new NoReverse() };
        // TODO : Take any 2 cards from your Ringside pile and put them into your hand. Then take any 2 cards from your Ringside pile and shuffle them back into your Arsenal. 
        conditions["The People's Eyebrow"] = new ConditionCollection { new NoReverse() };
        // TODO : As a maneuver, this card can only be played if the card titled Rock Bottom is in your Ring area. As an action, place this card back in your Arsenal, shuffle, then draw 2 cards. Doing this will not cause any damage to opponent. 
        conditions["The People's Elbow"] = new ConditionCollection { new NoReverse() };
        // TODO : Can only be played after a 4D or greater maneuver. Reversals to this maneuver are +6D. 
        conditions["Kane's Flying Clothesline"] = new ConditionCollection { new NoReverse() };
        // TODO : Reverse any maneuver and end your opponent's turn. If played from your hand, take the top 4 cards from your Arsenal and put them in your Ringside pile; next turn, all your maneuvers are +2D, and all opponents reversals are +15F. 
        conditions["Kane's Return!"] = new ConditionCollection { new NoReverse() };
        // TODO : -6F on this card if played after the card titled Kane's Choke Slam. 
        conditions["Kane's Tombstone Piledriver"] = new ConditionCollection { new NoReverse() };
        // TODO : All players discard all cards from their hands. Your opponent places the top 5 cards of his Arsenal into his Ringside pile. 
        conditions["Hellfire & Brimstone"] = new ConditionCollection { new NoReverse() };
        // TODO : Can only be played after a 4D or greater maneuver. When successfully played, opponent must discard 1 card. 
        conditions["Lionsault"] = new ConditionCollection { new NoReverse() };
        // TODO : Draw up to 5 Cards or force opponent to discard up to 5 cards. 
        conditions["Y2J"] = new ConditionCollection { new NoReverse() };
        // TODO : Reverse any Strike, Grapple or Submission maneuver. End your opponent's turn. If played from your hand, opponent must discard 2 cards and all your maneuvers next turn are +2D. 
        conditions["Don't You Never... EVER!"] = new ConditionCollection { new NoReverse() };
        // TODO : You may play the card titled Maintain Hold after this card as if it were a Submission maneuver. 
        conditions["Walls of Jericho"] = new ConditionCollection { new NoReverse() };
        // TODO : Look at your opponent's hand. For the rest of this turn, your opponent's reversals revealed from his Arsenal while applying damage may not reverse your maneuvers. 
        conditions["Ayatollah of Rock 'n' Roll-a"] = new ConditionCollection { new NoReverse() };
    }
}