using System.Collections;

namespace RawDeal;

public class ConditionCollection : IEnumerable<ICondition>
{
    private List<ICondition> list = new List<ICondition>();

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)list).GetEnumerator();
    }

    public IEnumerator<ICondition> GetEnumerator() => list.GetEnumerator();

    public void Add(ICondition effectToAdd) => list.Add(effectToAdd);
}
