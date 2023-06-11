namespace RawDeal;

public class ReverseConditionCatalog
{
    private Dictionary<string, List<ICondition>> conditions;

    public List<ICondition> GetConditions(string cardTitle)
    {
        if (!conditions.ContainsKey(cardTitle)) { return new List<ICondition> { new NoCondition() }; }
        return conditions[cardTitle];
    }

    public ReverseConditionCatalog()
    {
        conditions = new Dictionary<string, List<ICondition>>();
        // TODO : As an action, you may discard this card to draw 1 card. Doing this will not cause any damage to opponent. 
        conditions["Chop"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, discard 1 card of your choice from your hand. 
        conditions["Head Butt"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, all Strike maneuvers are +1D for the rest of this turn. 
        conditions["Haymaker"] = new List<ICondition> { new NoCondition() };
        // TODO : The card titled Irish Whip must be played before playing this card. When successfully played, you may either draw 2 cards, or force opponent to discard 2 cards. 
        conditions["Back Body Drop"] = new List<ICondition> { new NoCondition() };
        // TODO : May only reverse a maneuver played after the card titled Irish Whip. 
        conditions["Shoulder Block"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, you must take the top card of your Arsenal and put it into your Ringside pile. 
        conditions["Kick"] = new List<ICondition> { new NoCondition() };
        // TODO : The card titled Irish Whip must be played before playing this card. May only reverse a maneuver played after the card titled Irish Whip. 
        conditions["Cross Body Block"] = new List<ICondition> { new NoCondition() };
        // TODO : May only reverse the maneuver titled Kick. 
        conditions["Ensugiri"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, you must take the top card of your Arsenal and put it into your Ringside pile. 
        conditions["Running Elbow Smash"] = new List<ICondition> { new NoCondition() };
        // TODO : May only reverse the maneuver titled Drop Kick. 
        conditions["Drop Kick"] = new List<ICondition> { new NoCondition() };
        // TODO : Reversals to this maneuver are +2D. 
        conditions["Discus Punch"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, +5D if played after a 5D or greater maneuver. 
        conditions["Superkick"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, opponent must discard 1 card. 
        conditions["Spinning Heel Kick"] = new List<ICondition> { new NoCondition() };
        // TODO : May only reverse a maneuver played after the card titled Irish Whip. 
        conditions["Spear"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, if your next card played this turn is a maneuver it is +2D. 
        conditions["Clothesline"] = new List<ICondition> { new NoCondition() };
        // TODO : As an action, you may discard this card to draw 1 card. Doing this will not cause any damage to opponent. 
        conditions["Arm Bar Takedown"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, discard 1 card of your choice from your hand. 
        conditions["Arm Drag"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, if your next card played this turn is a Strike maneuver it is +2D. 
        conditions["Snap Mare"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, you may draw 1 card. 
        conditions["Double Leg Takedown"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, you may look at your opponent's hand. 
        conditions["Fireman's Carry"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, opponent must draw 1 card. 
        conditions["Headlock Takedown"] = new List<ICondition> { new NoCondition() };
        // TODO : May only reverse the maneuver titled Belly to Belly Suplex. 
        conditions["Belly to Belly Suplex"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, if your next card played this turn is a maneuver it is +2D. 
        conditions["Atomic Drop"] = new List<ICondition> { new NoCondition() };
        // TODO : May only reverse the maneuver titled Vertical Suplex. 
        conditions["Vertical Suplex"] = new List<ICondition> { new NoCondition() };
        // TODO : May only reverse the maneuver titled Belly to Back Suplex. 
        conditions["Belly to Back Suplex"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, opponent must discard 2 cards. 
        conditions["Pump Handle Slam"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, you may draw 1 card. 
        conditions["Reverse DDT"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, opponent must discard 1 card. 
        conditions["Samoan Drop"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, discard 1 card of your choice from your hand. Look at opponent's hand, then choose and discard 1 card from his hand. 
        conditions["Bulldog"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, you must take the top card of your Arsenal and put it into your Ringside pile. You may draw 1 card. 
        conditions["Fisherman's Suplex"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, you must take the top card of your Arsenal and put it into your Ringside pile. Opponent must discard 2 cards. 
        conditions["DDT"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, opponent must discard 1 card. 
        conditions["Power Slam"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, you may draw 1 card. Add +1D for every maneuver with the word "slam" in its title in your Ring area. 
        conditions["Powerbomb"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, you must take the top card of your Arsenal and put it into your Ringside pile. Opponent must discard 2 cards. 
        conditions["Press Slam"] = new List<ICondition> { new NoCondition() };
        // TODO : As an action, you may discard this card to draw 1 card. Doing this will not cause any damage to opponent. 
        conditions["Collar & Elbow Lockup"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, discard 1 card of your choice from your hand. 
        conditions["Arm Bar"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, opponent must discard 1 card. 
        conditions["Bear Hug"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, look through your Arsenal for the card titled Maintain Hold and place that card in your hand, then shuffle your Arsenal. 
        conditions["Full Nelson"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, opponent must discard 1 card. 
        conditions["Choke Hold"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, opponent must discard 1 card. 
        conditions["Ankle Lock"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, opponent must draw 1 card. 
        conditions["Standing Side Headlock"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, look through your Arsenal for the card titled Maintain Hold and place that card in your hand, then shuffle your Arsenal. 
        conditions["Cobra Clutch"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, shuffle 2 cards from your Ringside pile into your Arsenal. 
        conditions["Chicken Wing"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, look through your Arsenal for the card titled Maintain Hold and place that card in your hand, then shuffle your Arsenal. 
        conditions["Sleeper"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, look through your Arsenal for the card titled Maintain Hold and place that card in your hand, then shuffle your Arsenal. 
        conditions["Camel Clutch"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, opponent must discard 1 card. 
        conditions["Boston Crab"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, opponent must discard 1 card and you may draw 1 card. 
        conditions["Guillotine Stretch"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, you may discard 3 cards, search through your Arsenal and put 1 card into your hand, then shuffle your Arsenal. 
        conditions["Abdominal Stretch"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, opponent must discard 1 card. 
        conditions["Torture Rack"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, opponent must discard 1 card. 
        conditions["Figure Four Leg Lock"] = new List<ICondition> { new NoCondition() };
        // Reverse any Strike maneuver and end your opponent's turn. 
        conditions["Step Aside"] = new List<ICondition> { new AnySubtypeManeuver("Strike") };
        // Reverse any Grapple maneuver and end your opponent's turn. 
        conditions["Escape Move"] = new List<ICondition> { new AnySubtypeManeuver("Grapple") };
        // Reverse any Submission maneuver and end your opponent's turn. 
        conditions["Break the Hold"] = new List<ICondition> { new AnySubtypeManeuver("Submission") };
        // Can only reverse a Grapple that does 7D or less. End your opponent's turn. # = D of maneuver card being reversed. Read as 0 when in your Ring area. 
        conditions["Rolling Takedown"] = new List<ICondition> { new Does7DOrLess("Grapple") };
        // Can only reverse a Strike that does 7D or less. End your opponent's turn. # = D of maneuver card being reversed. Read as 0 when in your Ring area. 
        conditions["Knee to the Gut"] = new List<ICondition> { new Does7DOrLess("Strike") };
        // May reverse any maneuver that does 7D or less. End your opponent's turn. 
        conditions["Elbow to the Face"] = new List<ICondition> { new Does7DOrLess("any") };
        // If played from your hand, may reverse the card titled Jockeying for Position. Opponent must discard 4 cards. End your opponent's turn. Draw 1 card. 
        conditions["Clean Break"] = new List<ICondition> { new JockeyingForPosition(false) };
        // Reverse any maneuver and end your opponent's turn. If played from your hand draw 1 card. 
        conditions["Manager Interferes"] = new List<ICondition> { new AnySubtypeManeuver("any") };
        // TODO : Reverse any HEEL maneuver or reversal card if that opponent has 5 or more HEEL cards in his Ring area. Opponent is Disqualified and you win the game. This effect happens even if the card titled Disqualification is placed into your Ringside pile while applying damage from a HEEL maneuver or reversal card. 
        conditions["Disqualification!"] = new List<ICondition> { new NoCondition() };
        // Reverse any ACTION card being played by your opponent from his hand. It is unsuccessful, goes to his Ringside pile, has no effect and ends his turn. 
        conditions["No Chance in Hell"] = new List<ICondition> { new AnyAction() };
        // TODO : Look at the top 5 cards of your Arsenal. You may either arrange them in any order or shuffle your Arsenal. 
        conditions["Hmmm"] = new List<ICondition> { new NoCondition() };
        // TODO : Look at the top 5 cards of an opponent's Arsenal. You may either arrange them in any order or make him shuffle his Arsenal. 
        conditions["Don't Think Too Hard"] = new List<ICondition> { new NoCondition() };
        // TODO : Look at opponent's hand. 
        conditions["Whaddya Got?"] = new List<ICondition> { new NoCondition() };
        // TODO : Take a card in your hand, shuffle it into your Arsenal, then draw 2 cards. 
        conditions["Not Yet"] = new List<ICondition> { new NoCondition() };
        // As an action, if your next card played is a Grapple maneuver, declare whether it will be +4D or your opponent's reversal to it will be +8F. As a reversal, may only reverse the card titled Jockeying for Position. If so, you end opponent's turn; and if your next card played on your turn is a Grapple maneuver, declare whether it will be +4D or your opponent's reversal to it will be +8F. 
        conditions["Jockeying for Position"] = new List<ICondition> { new JockeyingForPosition(true) };
        // TODO : As an action, if your next card played is a Strike maneuver it is +5D. As a reversal, may only reverse the card titled Irish Whip. If so, you end opponent's turn; and if your next card played on your turn is a Strike maneuver it is +5D. 
        conditions["Irish Whip"] = new List<ICondition> { new NoCondition() };
        // TODO : Draw 1 card. Look at opponent's hand, and then make him discard all HEEL cards. 
        conditions["Flash in the Pan"] = new List<ICondition> { new NoCondition() };
        // TODO : Draw 1 card. Look at opponent's hand, and then make him discard all FACE cards. 
        conditions["View of Villainy"] = new List<ICondition> { new NoCondition() };
        // TODO : Playable only if your Fortitude Rating is less than your opponent's Fortitude Rating. Remove any 1 card in opponent's Ring area with a D value less than or equal to your total Fortitude Rating and place it into his Ringside pile. 
        conditions["Shake It Off"] = new List<ICondition> { new NoCondition() };
        // TODO : Draw up to 3 cards, then discard 1 card. 
        conditions["Offer Handshake"] = new List<ICondition> { new NoCondition() };
        // TODO : Discard up to 2 cards from your hand to your Ringside pile. Return an equal number of cards of your choice to your hand from your Ringside pile. 
        conditions["Roll Out of the Ring"] = new List<ICondition> { new NoCondition() };
        // TODO : Draw 1 card. Look at opponent's hand. If he has any cards titled Disqualification! he must discard them. 
        conditions["Distract the Ref"] = new List<ICondition> { new NoCondition() };
        // TODO : Shuffle any 2 cards from your Ringside pile back into your Arsenal. Then draw 1 card. 
        conditions["Recovery"] = new List<ICondition> { new NoCondition() };
        // TODO : Can only be played when you have 2 or more cards in your hand. Discard 1 card and then your opponent discards 4 cards. 
        conditions["Spit At Opponent"] = new List<ICondition> { new NoCondition() };
        // TODO : Draw 1 card. Your next maneuver this turn is +4D and opponent's reversals are +12F. 
        conditions["Get Crowd Support"] = new List<ICondition> { new NoCondition() };
        // TODO : Discard 3 cards of your choice from your hand. All players compare their current Fortitude Rating. The player(s) with a higher Fortitude Rating must remove maneuver and/or reversal cards from their Ring area, putting them into his Ringside pile, until that player's Fortitude Rating is less than or equal to the others. 
        conditions["Comeback!"] = new List<ICondition> { new NoCondition() };
        // TODO : Your next card played is -5F. If opponent forces you to discard a card from your hand, you may choose to discard this card from your hand and then draw up to 2 cards. 
        conditions["Ego Boost"] = new List<ICondition> { new NoCondition() };
        // TODO : Draw 4 cards. At end of turn, discard your hand. 
        conditions["Deluding Yourself"] = new List<ICondition> { new NoCondition() };
        // TODO : Play after a successfully played maneuver. If your next card played this turn is a maneuver of 7D or less your opponent can not reverse it. 
        conditions["Stagger"] = new List<ICondition> { new NoCondition() };
        // TODO : Your next maneuver may not be reversed. 
        conditions["Diversion"] = new List<ICondition> { new NoCondition() };
        // TODO : Choose one: Look through your Arsenal and put 1 card in your hand, shuffle it and end your turn; or go through opponent's Arsenal and put any 3 cards into his Ringside pile, then shuffle his Arsenal. 
        conditions["Marking Out"] = new List<ICondition> { new NoCondition() };
        // TODO : Shuffle up to 5 cards from your Ringside pile into your Arsenal. Then draw 2 cards. 
        conditions["Puppies! Puppies!"] = new List<ICondition> { new NoCondition() };
        // TODO : While this card is in your Ring area, at the start of your turn, before your draw segment, opponent must take the top card from his Arsenal and place it into his Ringside pile. 
        conditions["Shane O'Mac"] = new List<ICondition> { new NoCondition() };
        // TODO : Play after a successful Submission maneuver not reversed and end your turn. You and your opponent may not play maneuvers or actions until your opponent reverses the maintained Submission. On your turn, during the main segment, the Submission does its damage, along with any other abilities on the card. If a reversal is played by your opponent or is revealed while applying damage, both Maintain Hold and the Submission maneuver remain in your Ring area, but you may no longer use the ability of this Maintain Hold card. 
        conditions["Maintain Hold"] = new List<ICondition> { new NoCondition() };
        // TODO : Opponent skips his next turn. 
        conditions["Pat & Gerry"] = new List<ICondition> { new NoCondition() };
        // TODO : May not be reversed. Can only be played after a maneuver that does 5D or greater. 
        conditions["Austin Elbow Smash"] = new List<ICondition> { new NoCondition() };
        // TODO : If played from your hand, may reverse a maneuver played after the card titled Irish Whip. End your opponent's turn. You may draw 1 card. 
        conditions["Lou Thesz Press"] = new List<ICondition> { new NoCondition() };
        // TODO : Reverse any Strike, Grapple or Submission maneuver. End your opponent's turn. If played from your hand, opponent must discard 2 cards, then take the top 2 cards from his Arsenal and put them into his Ringside pile. 
        conditions["Double Digits"] = new List<ICondition> { new NoCondition() };
        // TODO : -6F on this card if played after the maneuver titled Kick. 
        conditions["Stone Cold Stunner"] = new List<ICondition> { new NoCondition() };
        // TODO : Your next maneuver this turn is +6D, and your opponent's reversal to it is +20F. Draw a card. 
        conditions["Open Up a Can of Whoop-A%$"] = new List<ICondition> { new NoCondition() };
        // TODO : Can only be played after a 5D or greater maneuver. Reversals to this maneuver are +6D. 
        conditions["Undertaker's Flying Clothesline"] = new List<ICondition> { new NoCondition() };
        // TODO : Reverse any maneuver and end your opponent's turn. If played from your hand, take the top 4 cards from your Arsenal and put them in your Ringside pile. Opponent must discard 1 card; next turn, all your maneuvers are +2D, and all opponent's reversals are +25F. 
        conditions["Undertaker Sits Up!"] = new List<ICondition> { new NoCondition() };
        // TODO : As an action, this card is -30F and -25D, discard this card and draw 1 card. 
        conditions["Undertaker's Tombstone Piledriver"] = new List<ICondition> { new NoCondition() };
        // TODO : +5D to all your maneuvers and +20F to all of opponent's reversals for the rest of this turn. 
        conditions["Power of Darkness"] = new List<ICondition> { new NoCondition() };
        // TODO : Reverse any Strike, Grapple or Submission maneuver. End your opponent's turn. If played from your hand, opponent discards all cards in his hand. 
        conditions["Have a Nice Day!"] = new List<ICondition> { new NoCondition() };
        // TODO : May only reverse the maneuver titled Back Body Drop. 
        conditions["Double Arm DDT"] = new List<ICondition> { new NoCondition() };
        // TODO : May not be reversed. When successfully played, opponent must discard 2 cards. 
        conditions["Tree of Woe"] = new List<ICondition> { new NoCondition() };
        // TODO : -6F on this card if Mr. Socko card is in your Ring area. You may play the card titled Maintain Hold after this card as if it were a Submission maneuver. 
        conditions["Mandible Claw"] = new List<ICondition> { new NoCondition() };
        // TODO : Take 1 card from either your Arsenal or Ringside pile and place it into your hand, then shuffle your Arsenal. While Mr. Socko is in your Ring area, all your maneuvers are +1D. 
        conditions["Mr. Socko"] = new List<ICondition> { new NoCondition() };
        // TODO : May not be reversed. You must play the card titled Irish Whip before playing this card. When successfully played, opponent discards 1 card. 
        conditions["Leaping Knee to the Face"] = new List<ICondition> { new NoCondition() };
        // TODO : If played from your hand, may reverse a maneuver played after the card titled Irish Whip. End your opponent's turn. You may draw 2 cards. 
        conditions["Facebuster"] = new List<ICondition> { new NoCondition() };
        // TODO : All your maneuvers are +3D for the rest of this turn. Draw 2 cards, or force opponent to discard 2 cards. 
        conditions["I Am the Game"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, +2D if played after a Strike maneuver. May only reverse the maneuver titled Back Body Drop. 
        conditions["Pedigree"] = new List<ICondition> { new NoCondition() };
        // Reverses any maneuver and ends your opponent's turn. If played from your hand, draw 2 cards. 
        conditions["Chyna Interferes"] = new List<ICondition> { new AnySubtypeManeuver("any") };
        // TODO : Draw 1 card. Look at your opponent's hand. Your next maneuver this turn is +6D. 
        conditions["Smackdown Hotel"] = new List<ICondition> { new NoCondition() };
        // TODO : Reverse any Strike, Grapple or Submission maneuver. End your opponent's turn. If played from your hand, shuffle up to 5 cards from your Ringside pile into your Arsenal. 
        conditions["Take That Move, Shine It Up Real Nice, Turn That Sumb*tch Sideways, and Stick It Straight Up Your Roody Poo Candy A%$!"] = new List<ICondition> { new NoCondition() };
        // TODO : When successfully played, look through your Ringside pile and Arsenal for the card titled The People's Elbow and place that card in your hand, then shuffle your Arsenal. May only reverse a Grapple maneuver, but you must first discard 1 card. 
        conditions["Rock Bottom"] = new List<ICondition> { new NoCondition() };
        // TODO : Take any 2 cards from your Ringside pile and put them into your hand. Then take any 2 cards from your Ringside pile and shuffle them back into your Arsenal. 
        conditions["The People's Eyebrow"] = new List<ICondition> { new NoCondition() };
        // TODO : As a maneuver, this card can only be played if the card titled Rock Bottom is in your Ring area. As an action, place this card back in your Arsenal, shuffle, then draw 2 cards. Doing this will not cause any damage to opponent. 
        conditions["The People's Elbow"] = new List<ICondition> { new NoCondition() };
        // TODO : Can only be played after a 4D or greater maneuver. Reversals to this maneuver are +6D. 
        conditions["Kane's Flying Clothesline"] = new List<ICondition> { new NoCondition() };
        // TODO : Reverse any maneuver and end your opponent's turn. If played from your hand, take the top 4 cards from your Arsenal and put them in your Ringside pile; next turn, all your maneuvers are +2D, and all opponents reversals are +15F. 
        conditions["Kane's Return!"] = new List<ICondition> { new NoCondition() };
        // TODO : -6F on this card if played after the card titled Kane's Choke Slam. 
        conditions["Kane's Tombstone Piledriver"] = new List<ICondition> { new NoCondition() };
        // TODO : All players discard all cards from their hands. Your opponent places the top 5 cards of his Arsenal into his Ringside pile. 
        conditions["Hellfire & Brimstone"] = new List<ICondition> { new NoCondition() };
        // TODO : Can only be played after a 4D or greater maneuver. When successfully played, opponent must discard 1 card. 
        conditions["Lionsault"] = new List<ICondition> { new NoCondition() };
        // TODO : Draw up to 5 Cards or force opponent to discard up to 5 cards. 
        conditions["Y2J"] = new List<ICondition> { new NoCondition() };
        // TODO : Reverse any Strike, Grapple or Submission maneuver. End your opponent's turn. If played from your hand, opponent must discard 2 cards and all your maneuvers next turn are +2D. 
        conditions["Don't You Never... EVER!"] = new List<ICondition> { new NoCondition() };
        // TODO : You may play the card titled Maintain Hold after this card as if it were a Submission maneuver. 
        conditions["Walls of Jericho"] = new List<ICondition> { new NoCondition() };
        // TODO : Look at your opponent's hand. For the rest of this turn, your opponent's reversals revealed from his Arsenal while applying damage may not reverse your maneuvers. 
        conditions["Ayatollah of Rock 'n' Roll-a"] = new List<ICondition> { new NoCondition() };
    }
}