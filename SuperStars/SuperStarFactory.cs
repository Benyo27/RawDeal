namespace RawDeal;

public static class SuperStarFactory
{
    public static SuperStar makeSuperStar(SuperStarInfo cardInfo)
    {
        switch (cardInfo.Name)
        {
            case "HHH":
                return new HHH(cardInfo);
            case "MANKIND":
                return new Mankind(cardInfo);
            case "KANE":
                return new Kane(cardInfo);
            case "CHRIS JERICHO":
                return new ChrisJericho(cardInfo);
            case "STONE COLD STEVE AUSTIN":
                return new StoneCold(cardInfo);
            case "THE ROCK":
                return new TheRock(cardInfo);
            case "THE UNDERTAKER":
                return new TheUndertaker(cardInfo);
            default:
                throw new NotImplementedException();
        }
    }
}