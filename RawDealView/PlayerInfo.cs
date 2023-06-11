namespace RawDealView;

public class PlayerInfo
{
    public string _superstarName;
    public int _fortitudeRating;
    public int _numberOfCardsInHand;
    public int _numberOfCardsInArsenal;

    public PlayerInfo(string superstarName, int fortitudeRating, int numberOfCardsInHand, int numberOfCardsInArsenal)
    {
        _superstarName = superstarName;
        _fortitudeRating = fortitudeRating;
        _numberOfCardsInHand = numberOfCardsInHand;
        _numberOfCardsInArsenal = numberOfCardsInArsenal;
    }

    public override string ToString()
        => $"{_superstarName}: {_fortitudeRating}F, tiene {_numberOfCardsInHand} cartas en la mano y {_numberOfCardsInArsenal} en el arsenal.";
}