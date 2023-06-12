namespace RawDeal;

public class ConditionDictionary
{
    private Dictionary<string, ConditionCollection> conditions = 
        new Dictionary<string, ConditionCollection>();

    public ConditionCollection this[string key]
    {
        get { return conditions[key]; }
        set { conditions[key] = value; }
    }

    public bool ContainsKey(string key) => conditions.ContainsKey(key);
}
