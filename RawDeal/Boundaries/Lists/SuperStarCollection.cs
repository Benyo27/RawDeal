namespace RawDeal;

public class SuperStarCollection
{
    private List<SuperStar> superStars;

    public SuperStarCollection(List<SuperStar> superStars)
    {
        this.superStars = superStars;
    }

    public SuperStar this[int index]
    {
        get => superStars[index];
        set => superStars[index] = value;
    }

    public SuperStar Find(string name)
    {
        SuperStar superStar = superStars.Find(s => s.CardInfo.Name == name) ??
            throw new Exception("Superstar not found");
        return superStar;
    }

    public void Insert(int index, SuperStar superStar) => superStars.Insert(index, superStar);

    public string[] SelectWhereLogoIsNot(string logo) =>
        superStars.Select(s => s.CardInfo.Logo).Where(l => l != logo).ToArray();
}