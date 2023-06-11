namespace RawDeal;

static class DeckValidator
{
    public const int ValidDeckLength = 61;
    private static string[] deckLines;

    public static bool IsDeckValid(string deckPath)
    {
        deckLines = File.ReadAllLines(deckPath);
        return (
            IsDeckLengthValid() &&
            AreHeelAndFaceSubtypesValid() &&
            IsSuperstarLogoValid() &&
            IsSetupSubtypeValid() &&
            IsUniqueSubtypeValid()
        );
    }

    private static bool IsDeckLengthValid() => deckLines.Length == ValidDeckLength;

    private static bool AreHeelAndFaceSubtypesValid()
    {
        bool thereIsHeel = false; bool thereIsFace = false;
        foreach (string card in deckLines.Skip(1))
        {
            CardInfo cardToFind = Game.Cards.Find(card);
            if (cardToFind.Subtypes.Contains("Heel")) { thereIsHeel = true; }
            if (cardToFind.Subtypes.Contains("Face")) { thereIsFace = true; }
        }
        return !(thereIsHeel && thereIsFace);
    }

    private static bool IsSuperstarLogoValid()
    {
        foreach (string card in deckLines.Skip(1))
        {
            CardInfo cardToFind = Game.Cards.Find(card);
            if (GetInvalidLogos().Any(logo => cardToFind.Subtypes.Contains(logo)))
            {
                return false;
            }
        }
        return true;
    }

    private static string[] GetInvalidLogos() => 
        Game.SuperStars.SelectWhereLogoIsNot(GetSuperStarLogo());

    private static string GetSuperStarLogo()
    {
        string superStarName = deckLines[0].Split("(")[0].Trim();
        SuperStar superStar = Game.SuperStars.Find(superStarName);
        return superStar.CardInfo.Logo;
    }

    private static bool IsSetupSubtypeValid()
    {
        string[] cardsRepeatedMoreThan3Times = deckLines
            .Where(card => deckLines.Count(line => line == card) > 3).Distinct().ToArray();
        return ValidateUniqueAndSetup(cardsRepeatedMoreThan3Times, "SetUp");
    }

    private static bool IsUniqueSubtypeValid()
    {
        string[] cardsRepeatedMoreThan1Time = deckLines
            .Where(card => deckLines.Count(line => line == card) > 1).Distinct().ToArray();
        return ValidateUniqueAndSetup(cardsRepeatedMoreThan1Time, "Unique");
    }

    private static bool ValidateUniqueAndSetup(string[] cards, string subtype)
    {
        foreach (string card in cards)
        {
            CardInfo cardToFind = Game.Cards.Find(card);
            bool containToCheck = subtype == "Unique" ?
                cardToFind.Subtypes.Contains(subtype) :
                !cardToFind.Subtypes.Contains(subtype);
            if (containToCheck) { return false; }
        }
        return true;
    }
}