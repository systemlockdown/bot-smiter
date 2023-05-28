using BS.Domain.DatabaseObjects;

namespace BS.Infrastructure.Setup;

public class LetterBankSeed
{
    public static List<LetterBank> GetLetterBanks()
    {
        return Generate();
    }

    private static List<LetterBank> Generate()
    {
        return new List<LetterBank>
        {
            new ("¢", "c", "C", "\u00A9", "U+00A2", "&#162;"),
            new ("¥", "y", "Y", "\u00A5", "U+00A5", "&#165;"),
            new ("©", "c", "C", "\u00A9", "U+00A9", "&#169;"),
            new ("ª", "a", "A", "\u00AA", "U+00AA", "&#170;"),
            new ("®", "r", "R", "\u00AE", "U+00AE", "&#174;"),
            new ("°", "o", "O", "\u00B0", "U+00B0", "&#176;"),
            new ("µ", "u", "U", "\u00B5", "U+00B5", "&#181;")
        };
    }
}