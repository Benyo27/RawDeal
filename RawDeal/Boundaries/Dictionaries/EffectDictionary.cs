namespace RawDeal;

public class EffectDictionary
{
    private Dictionary<string, EffectCollection> effects = 
        new Dictionary<string, EffectCollection>();

    public EffectCollection this[string key]
    {
        get { return effects[key]; }
        set { effects[key] = value; }
    }

    public bool ContainsKey(string key) => effects.ContainsKey(key);
}