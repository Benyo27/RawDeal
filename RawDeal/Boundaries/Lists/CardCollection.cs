namespace RawDeal;

public class CardCollection
{
    private List<CardInfo> cards = new List<CardInfo>();

    public CardCollection(List<CardInfo> cards) => this.cards = cards;

    public int Count { get { return cards.Count; } }

    public CardInfo this[int index]
    {
        get => cards[index];
        set => cards[index] = value;
    }

    public IEnumerator<CardInfo> GetEnumerator() => cards.GetEnumerator();

    public CardInfo Find(string cardTitle)
    {
        CardInfo card = cards.Find(card => card.Title == cardTitle) ??
            throw new Exception("Card not found");
        return card;
    }

    public void RemoveAt(int index) => cards.RemoveAt(index);

    public void Add(CardInfo card) => cards.Add(card);

    public void Insert(int index, CardInfo card) => cards.Insert(index, card);

    public bool Any() => cards.Any();
}