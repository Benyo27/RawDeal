namespace RawDeal;

public class EffectCatalog
{
    private Dictionary<string, List<IEffect>> effects;

    public List<IEffect> GetEffects(string cardTitle)
    {
        return effects[cardTitle];
    }

    public EffectCatalog()
    {
        effects = new Dictionary<string, List<IEffect>>();
        // TODO : As an action, you may discard this card to draw 1 card. Doing this will not cause any damage to opponent. 
        effects["Chop"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, discard 1 card of your choice from your hand. 
        effects["Head Butt"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, all Strike maneuvers are +1D for the rest of this turn. 
        effects["Haymaker"] = new List<IEffect> { new NoEffect() };
        // TODO : The card titled Irish Whip must be played before playing this card. When successfully played, you may either draw 2 cards, or force opponent to discard 2 cards. 
        effects["Back Body Drop"] = new List<IEffect> { new NoEffect() };
        // TODO : May only reverse a maneuver played after the card titled Irish Whip. 
        effects["Shoulder Block"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, you must take the top card of your Arsenal and put it into your Ringside pile. 
        effects["Kick"] = new List<IEffect> { new NoEffect() };
        // TODO : The card titled Irish Whip must be played before playing this card. May only reverse a maneuver played after the card titled Irish Whip. 
        effects["Cross Body Block"] = new List<IEffect> { new NoEffect() };
        // TODO : May only reverse the maneuver titled Kick. 
        effects["Ensugiri"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, you must take the top card of your Arsenal and put it into your Ringside pile. 
        effects["Running Elbow Smash"] = new List<IEffect> { new NoEffect() };
        // TODO : May only reverse the maneuver titled Drop Kick. 
        effects["Drop Kick"] = new List<IEffect> { new NoEffect() };
        // TODO : Reversals to this maneuver are +2D. 
        effects["Discus Punch"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, +5D if played after a 5D or greater maneuver. 
        effects["Superkick"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, opponent must discard 1 card. 
        effects["Spinning Heel Kick"] = new List<IEffect> { new NoEffect() };
        // TODO : May only reverse a maneuver played after the card titled Irish Whip. 
        effects["Spear"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, if your next card played this turn is a maneuver it is +2D. 
        effects["Clothesline"] = new List<IEffect> { new NoEffect() };
        // TODO : As an action, you may discard this card to draw 1 card. Doing this will not cause any damage to opponent. 
        effects["Arm Bar Takedown"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, discard 1 card of your choice from your hand. 
        effects["Arm Drag"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, if your next card played this turn is a Strike maneuver it is +2D. 
        effects["Snap Mare"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, you may draw 1 card. 
        effects["Double Leg Takedown"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, you may look at your opponent's hand. 
        effects["Fireman's Carry"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, opponent must draw 1 card. 
        effects["Headlock Takedown"] = new List<IEffect> { new NoEffect() };
        // TODO : May only reverse the maneuver titled Belly to Belly Suplex. 
        effects["Belly to Belly Suplex"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, if your next card played this turn is a maneuver it is +2D. 
        effects["Atomic Drop"] = new List<IEffect> { new NoEffect() };
        // TODO : May only reverse the maneuver titled Vertical Suplex. 
        effects["Vertical Suplex"] = new List<IEffect> { new NoEffect() };
        // TODO : May only reverse the maneuver titled Belly to Back Suplex. 
        effects["Belly to Back Suplex"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, opponent must discard 2 cards. 
        effects["Pump Handle Slam"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, you may draw 1 card. 
        effects["Reverse DDT"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, opponent must discard 1 card. 
        effects["Samoan Drop"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, discard 1 card of your choice from your hand. Look at opponent's hand, then choose and discard 1 card from his hand. 
        effects["Bulldog"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, you must take the top card of your Arsenal and put it into your Ringside pile. You may draw 1 card. 
        effects["Fisherman's Suplex"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, you must take the top card of your Arsenal and put it into your Ringside pile. Opponent must discard 2 cards. 
        effects["DDT"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, opponent must discard 1 card. 
        effects["Power Slam"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, you may draw 1 card. Add +1D for every maneuver with the word "slam" in its title in your Ring area. 
        effects["Powerbomb"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, you must take the top card of your Arsenal and put it into your Ringside pile. Opponent must discard 2 cards. 
        effects["Press Slam"] = new List<IEffect> { new NoEffect() };
        // TODO : As an action, you may discard this card to draw 1 card. Doing this will not cause any damage to opponent. 
        effects["Collar & Elbow Lockup"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, discard 1 card of your choice from your hand. 
        effects["Arm Bar"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, opponent must discard 1 card. 
        effects["Bear Hug"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, look through your Arsenal for the card titled Maintain Hold and place that card in your hand, then shuffle your Arsenal. 
        effects["Full Nelson"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, opponent must discard 1 card. 
        effects["Choke Hold"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, opponent must discard 1 card. 
        effects["Ankle Lock"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, opponent must draw 1 card. 
        effects["Standing Side Headlock"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, look through your Arsenal for the card titled Maintain Hold and place that card in your hand, then shuffle your Arsenal. 
        effects["Cobra Clutch"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, shuffle 2 cards from your Ringside pile into your Arsenal. 
        effects["Chicken Wing"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, look through your Arsenal for the card titled Maintain Hold and place that card in your hand, then shuffle your Arsenal. 
        effects["Sleeper"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, look through your Arsenal for the card titled Maintain Hold and place that card in your hand, then shuffle your Arsenal. 
        effects["Camel Clutch"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, opponent must discard 1 card. 
        effects["Boston Crab"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, opponent must discard 1 card and you may draw 1 card. 
        effects["Guillotine Stretch"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, you may discard 3 cards, search through your Arsenal and put 1 card into your hand, then shuffle your Arsenal. 
        effects["Abdominal Stretch"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, opponent must discard 1 card. 
        effects["Torture Rack"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, opponent must discard 1 card. 
        effects["Figure Four Leg Lock"] = new List<IEffect> { new NoEffect() };
        // TODO : Reverse any Strike maneuver and end your opponent's turn. 
        effects["Step Aside"] = new List<IEffect> { new NoEffect() };
        // TODO : Reverse any Grapple maneuver and end your opponent's turn. 
        effects["Escape Move"] = new List<IEffect> { new NoEffect() };
        // TODO : Reverse any Submission maneuver and end your opponent's turn. 
        effects["Break the Hold"] = new List<IEffect> { new NoEffect() };
        // TODO : Can only reverse a Grapple that does 7D or less. End your opponent's turn. # = D of maneuver card being reversed. Read as 0 when in your Ring area. 
        effects["Rolling Takedown"] = new List<IEffect> { new NoEffect() };
        // TODO : Can only reverse a Strike that does 7D or less. End your opponent's turn. # = D of maneuver card being reversed. Read as 0 when in your Ring area. 
        effects["Knee to the Gut"] = new List<IEffect> { new NoEffect() };
        // TODO : May reverse any maneuver that does 7D or less. End your opponent's turn. 
        effects["Elbow to the Face"] = new List<IEffect> { new NoEffect() };
        // If played from your hand, may reverse the card titled Jockeying for Position. Opponent must discard 4 cards. End your opponent's turn. Draw 1 card. 
        effects["Clean Break"] = new List<IEffect> { new DiscardEffect(4), new DrawEffect(1) };
        // Reverse any maneuver and end your opponent's turn. If played from your hand draw 1 card. 
        effects["Manager Interferes"] = new List<IEffect> { new DrawEffect(1) };
        // TODO : Reverse any HEEL maneuver or reversal card if that opponent has 5 or more HEEL cards in his Ring area. Opponent is Disqualified and you win the game. This effect happens even if the card titled Disqualification is placed into your Ringside pile while applying damage from a HEEL maneuver or reversal card. 
        effects["Disqualification!"] = new List<IEffect> { new NoEffect() };
        // TODO : Reverse any ACTION card being played by your opponent from his hand. It is unsuccessful, goes to his Ringside pile, has no effect and ends his turn. 
        effects["No Chance in Hell"] = new List<IEffect> { new NoEffect() };
        // TODO : Look at the top 5 cards of your Arsenal. You may either arrange them in any order or shuffle your Arsenal. 
        effects["Hmmm"] = new List<IEffect> { new NoEffect() };
        // TODO : Look at the top 5 cards of an opponent's Arsenal. You may either arrange them in any order or make him shuffle his Arsenal. 
        effects["Don't Think Too Hard"] = new List<IEffect> { new NoEffect() };
        // TODO : Look at opponent's hand. 
        effects["Whaddya Got?"] = new List<IEffect> { new NoEffect() };
        // TODO : Take a card in your hand, shuffle it into your Arsenal, then draw 2 cards. 
        effects["Not Yet"] = new List<IEffect> { new NoEffect() };
        // TODO : As an action, if your next card played is a Grapple maneuver, declare whether it will be +4D or your opponent's reversal to it will be +8F. As a reversal, may only reverse the card titled Jockeying for Position. If so, you end opponent's turn; and if your next card played on your turn is a Grapple maneuver, declare whether it will be +4D or your opponent's reversal to it will be +8F. 
        effects["Jockeying for Position"] = new List<IEffect> { new NoEffect() };
        // TODO : As an action, if your next card played is a Strike maneuver it is +5D. As a reversal, may only reverse the card titled Irish Whip. If so, you end opponent's turn; and if your next card played on your turn is a Strike maneuver it is +5D. 
        effects["Irish Whip"] = new List<IEffect> { new NoEffect() };
        // TODO : Draw 1 card. Look at opponent's hand, and then make him discard all HEEL cards. 
        effects["Flash in the Pan"] = new List<IEffect> { new NoEffect() };
        // TODO : Draw 1 card. Look at opponent's hand, and then make him discard all FACE cards. 
        effects["View of Villainy"] = new List<IEffect> { new NoEffect() };
        // TODO : Playable only if your Fortitude Rating is less than your opponent's Fortitude Rating. Remove any 1 card in opponent's Ring area with a D value less than or equal to your total Fortitude Rating and place it into his Ringside pile. 
        effects["Shake It Off"] = new List<IEffect> { new NoEffect() };
        // TODO : Draw up to 3 cards, then discard 1 card. 
        effects["Offer Handshake"] = new List<IEffect> { new NoEffect() };
        // TODO : Discard up to 2 cards from your hand to your Ringside pile. Return an equal number of cards of your choice to your hand from your Ringside pile. 
        effects["Roll Out of the Ring"] = new List<IEffect> { new NoEffect() };
        // TODO : Draw 1 card. Look at opponent's hand. If he has any cards titled Disqualification! he must discard them. 
        effects["Distract the Ref"] = new List<IEffect> { new NoEffect() };
        // TODO : Shuffle any 2 cards from your Ringside pile back into your Arsenal. Then draw 1 card. 
        effects["Recovery"] = new List<IEffect> { new NoEffect() };
        // TODO : Can only be played when you have 2 or more cards in your hand. Discard 1 card and then your opponent discards 4 cards. 
        effects["Spit At Opponent"] = new List<IEffect> { new NoEffect() };
        // TODO : Draw 1 card. Your next maneuver this turn is +4D and opponent's reversals are +12F. 
        effects["Get Crowd Support"] = new List<IEffect> { new NoEffect() };
        // TODO : Discard 3 cards of your choice from your hand. All players compare their current Fortitude Rating. The player(s) with a higher Fortitude Rating must remove maneuver and/or reversal cards from their Ring area, putting them into his Ringside pile, until that player's Fortitude Rating is less than or equal to the others. 
        effects["Comeback!"] = new List<IEffect> { new NoEffect() };
        // TODO : Your next card played is -5F. If opponent forces you to discard a card from your hand, you may choose to discard this card from your hand and then draw up to 2 cards. 
        effects["Ego Boost"] = new List<IEffect> { new NoEffect() };
        // TODO : Draw 4 cards. At end of turn, discard your hand. 
        effects["Deluding Yourself"] = new List<IEffect> { new NoEffect() };
        // TODO : Play after a successfully played maneuver. If your next card played this turn is a maneuver of 7D or less your opponent can not reverse it. 
        effects["Stagger"] = new List<IEffect> { new NoEffect() };
        // TODO : Your next maneuver may not be reversed. 
        effects["Diversion"] = new List<IEffect> { new NoEffect() };
        // TODO : Choose one: Look through your Arsenal and put 1 card in your hand, shuffle it and end your turn; or go through opponent's Arsenal and put any 3 cards into his Ringside pile, then shuffle his Arsenal. 
        effects["Marking Out"] = new List<IEffect> { new NoEffect() };
        // TODO : Shuffle up to 5 cards from your Ringside pile into your Arsenal. Then draw 2 cards. 
        effects["Puppies! Puppies!"] = new List<IEffect> { new NoEffect() };
        // TODO : While this card is in your Ring area, at the start of your turn, before your draw segment, opponent must take the top card from his Arsenal and place it into his Ringside pile. 
        effects["Shane O'Mac"] = new List<IEffect> { new NoEffect() };
        // TODO : Play after a successful Submission maneuver not reversed and end your turn. You and your opponent may not play maneuvers or actions until your opponent reverses the maintained Submission. On your turn, during the main segment, the Submission does its damage, along with any other abilities on the card. If a reversal is played by your opponent or is revealed while applying damage, both Maintain Hold and the Submission maneuver remain in your Ring area, but you may no longer use the ability of this Maintain Hold card. 
        effects["Maintain Hold"] = new List<IEffect> { new NoEffect() };
        // TODO : Opponent skips his next turn. 
        effects["Pat & Gerry"] = new List<IEffect> { new NoEffect() };
        // TODO : May not be reversed. Can only be played after a maneuver that does 5D or greater. 
        effects["Austin Elbow Smash"] = new List<IEffect> { new NoEffect() };
        // TODO : If played from your hand, may reverse a maneuver played after the card titled Irish Whip. End your opponent's turn. You may draw 1 card. 
        effects["Lou Thesz Press"] = new List<IEffect> { new NoEffect() };
        // TODO : Reverse any Strike, Grapple or Submission maneuver. End your opponent's turn. If played from your hand, opponent must discard 2 cards, then take the top 2 cards from his Arsenal and put them into his Ringside pile. 
        effects["Double Digits"] = new List<IEffect> { new NoEffect() };
        // TODO : -6F on this card if played after the maneuver titled Kick. 
        effects["Stone Cold Stunner"] = new List<IEffect> { new NoEffect() };
        // TODO : Your next maneuver this turn is +6D, and your opponent's reversal to it is +20F. Draw a card. 
        effects["Open Up a Can of Whoop-A%$"] = new List<IEffect> { new NoEffect() };
        // TODO : Can only be played after a 5D or greater maneuver. Reversals to this maneuver are +6D. 
        effects["Undertaker's Flying Clothesline"] = new List<IEffect> { new NoEffect() };
        // TODO : Reverse any maneuver and end your opponent's turn. If played from your hand, take the top 4 cards from your Arsenal and put them in your Ringside pile. Opponent must discard 1 card; next turn, all your maneuvers are +2D, and all opponent's reversals are +25F. 
        effects["Undertaker Sits Up!"] = new List<IEffect> { new NoEffect() };
        // TODO : As an action, this card is -30F and -25D, discard this card and draw 1 card. 
        effects["Undertaker's Tombstone Piledriver"] = new List<IEffect> { new NoEffect() };
        // TODO : +5D to all your maneuvers and +20F to all of opponent's reversals for the rest of this turn. 
        effects["Power of Darkness"] = new List<IEffect> { new NoEffect() };
        // TODO : Reverse any Strike, Grapple or Submission maneuver. End your opponent's turn. If played from your hand, opponent discards all cards in his hand. 
        effects["Have a Nice Day!"] = new List<IEffect> { new NoEffect() };
        // TODO : May only reverse the maneuver titled Back Body Drop. 
        effects["Double Arm DDT"] = new List<IEffect> { new NoEffect() };
        // TODO : May not be reversed. When successfully played, opponent must discard 2 cards. 
        effects["Tree of Woe"] = new List<IEffect> { new NoEffect() };
        // TODO : -6F on this card if Mr. Socko card is in your Ring area. You may play the card titled Maintain Hold after this card as if it were a Submission maneuver. 
        effects["Mandible Claw"] = new List<IEffect> { new NoEffect() };
        // TODO : Take 1 card from either your Arsenal or Ringside pile and place it into your hand, then shuffle your Arsenal. While Mr. Socko is in your Ring area, all your maneuvers are +1D. 
        effects["Mr. Socko"] = new List<IEffect> { new NoEffect() };
        // TODO : May not be reversed. You must play the card titled Irish Whip before playing this card. When successfully played, opponent discards 1 card. 
        effects["Leaping Knee to the Face"] = new List<IEffect> { new NoEffect() };
        // TODO : If played from your hand, may reverse a maneuver played after the card titled Irish Whip. End your opponent's turn. You may draw 2 cards. 
        effects["Facebuster"] = new List<IEffect> { new NoEffect() };
        // TODO : All your maneuvers are +3D for the rest of this turn. Draw 2 cards, or force opponent to discard 2 cards. 
        effects["I Am the Game"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, +2D if played after a Strike maneuver. May only reverse the maneuver titled Back Body Drop. 
        effects["Pedigree"] = new List<IEffect> { new NoEffect() };
        // Reverses any maneuver and ends your opponent's turn. If played from your hand, draw 2 cards. 
        effects["Chyna Interferes"] = new List<IEffect> { new DrawEffect(2) };
        // TODO : Draw 1 card. Look at your opponent's hand. Your next maneuver this turn is +6D. 
        effects["Smackdown Hotel"] = new List<IEffect> { new NoEffect() };
        // TODO : Reverse any Strike, Grapple or Submission maneuver. End your opponent's turn. If played from your hand, shuffle up to 5 cards from your Ringside pile into your Arsenal. 
        effects["Take That Move, Shine It Up Real Nice, Turn That Sumb*tch Sideways, and Stick It Straight Up Your Roody Poo Candy A%$!"] = new List<IEffect> { new NoEffect() };
        // TODO : When successfully played, look through your Ringside pile and Arsenal for the card titled The People's Elbow and place that card in your hand, then shuffle your Arsenal. May only reverse a Grapple maneuver, but you must first discard 1 card. 
        effects["Rock Bottom"] = new List<IEffect> { new NoEffect() };
        // TODO : Take any 2 cards from your Ringside pile and put them into your hand. Then take any 2 cards from your Ringside pile and shuffle them back into your Arsenal. 
        effects["The People's Eyebrow"] = new List<IEffect> { new NoEffect() };
        // TODO : As a maneuver, this card can only be played if the card titled Rock Bottom is in your Ring area. As an action, place this card back in your Arsenal, shuffle, then draw 2 cards. Doing this will not cause any damage to opponent. 
        effects["The People's Elbow"] = new List<IEffect> { new NoEffect() };
        // TODO : Can only be played after a 4D or greater maneuver. Reversals to this maneuver are +6D. 
        effects["Kane's Flying Clothesline"] = new List<IEffect> { new NoEffect() };
        // TODO : Reverse any maneuver and end your opponent's turn. If played from your hand, take the top 4 cards from your Arsenal and put them in your Ringside pile; next turn, all your maneuvers are +2D, and all opponents reversals are +15F. 
        effects["Kane's Return!"] = new List<IEffect> { new NoEffect() };
        // TODO : -6F on this card if played after the card titled Kane's Choke Slam. 
        effects["Kane's Tombstone Piledriver"] = new List<IEffect> { new NoEffect() };
        // TODO : All players discard all cards from their hands. Your opponent places the top 5 cards of his Arsenal into his Ringside pile. 
        effects["Hellfire & Brimstone"] = new List<IEffect> { new NoEffect() };
        // TODO : Can only be played after a 4D or greater maneuver. When successfully played, opponent must discard 1 card. 
        effects["Lionsault"] = new List<IEffect> { new NoEffect() };
        // TODO : Draw up to 5 Cards or force opponent to discard up to 5 cards. 
        effects["Y2J"] = new List<IEffect> { new NoEffect() };
        // TODO : Reverse any Strike, Grapple or Submission maneuver. End your opponent's turn. If played from your hand, opponent must discard 2 cards and all your maneuvers next turn are +2D. 
        effects["Don't You Never... EVER!"] = new List<IEffect> { new NoEffect() };
        // TODO : You may play the card titled Maintain Hold after this card as if it were a Submission maneuver. 
        effects["Walls of Jericho"] = new List<IEffect> { new NoEffect() };
        // TODO : Look at your opponent's hand. For the rest of this turn, your opponent's reversals revealed from his Arsenal while applying damage may not reverse your maneuvers. 
        effects["Ayatollah of Rock 'n' Roll-a"] = new List<IEffect> { new NoEffect() };
    }
}