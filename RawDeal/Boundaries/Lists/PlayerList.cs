namespace RawDeal;

public class PlayerList
{
    private List<Player> list = new List<Player>();

    public Player this[int index]
    {
        get => list[index];
        set => list[index] = value;
    }

    public void Insert(int index, Player PlayerToInsert) => list.Insert(index, PlayerToInsert);
}