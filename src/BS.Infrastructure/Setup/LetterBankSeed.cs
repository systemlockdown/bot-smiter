﻿using BS.Domain.DatabaseObjects;

namespace BS.Infrastructure.Setup;

public class LetterBankSeed
{
    public static List<LetterBank> GetLetterBanks()
    {
        return Generate();
    }

    private static List<LetterBank> Generate()
    {
        var list = new List<LetterBank>();

        var cList = new List<LetterBank>
        {
            new ("C", "\u00A9", "U+00A2", "&#162;")
        };
        list.AddRange(cList);

        return list;
    }
}