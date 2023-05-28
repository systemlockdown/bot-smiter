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
            new ("¢", "c", "C", "\u00A9", "U+00A2", "&#162;")
        };
    }
}