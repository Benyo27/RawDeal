using System.Collections;

namespace RawDeal;

public class EffectCollection : IEnumerable<IEffect>
{
    private List<IEffect> list = new List<IEffect>();

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)list).GetEnumerator();
    }

    public IEnumerator<IEffect> GetEnumerator() => list.GetEnumerator();

    public void Add(IEffect effectToAdd) => list.Add(effectToAdd);
}
