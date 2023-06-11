namespace RawDeal;

public class IntList
{
    private List<int> list = new List<int>();

    public int this[int index]
    {
        get => list[index];
        set => list[index] = value;
    }

    public void Insert(int index, int intToInsert) => list.Insert(index, intToInsert);

    public void Add(int intToAdd) => list.Add(intToAdd);
}