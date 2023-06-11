namespace RawDeal;

// No aplica a List<string> pasadas a View
public class StringList
{
    private List<string> list = new List<string>();

    public string this[int index]
    {
        get => list[index];
        set => list[index] = value;
    }

    public void Insert(int index, string stringToInsert) => list.Insert(index, stringToInsert);

    public void Add(string stringToAdd) => list.Add(stringToAdd);
}