namespace RawDeal;

public class StringArrayList
{
    private List<string[]> list = new List<string[]>();

    public string[] this[int index]
    {
        get => list[index];
        set => list[index] = value;
    }

    public void Insert(int index, string[] stringArrayToInsert) =>
        list.Insert(index, stringArrayToInsert);
}