using System.Collections;

namespace RawDeal;

public class ConditionCollection : IEnumerable<IReverseCondition>
{
    private List<IReverseCondition> list = new List<IReverseCondition>();

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)list).GetEnumerator();
    }

    public IEnumerator<IReverseCondition> GetEnumerator() => list.GetEnumerator();

    public void Add(IReverseCondition effectToAdd) => list.Add(effectToAdd);
}
