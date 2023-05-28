namespace BS.Domain.DatabaseObjects;

public class UnicodeLetter
{
    public string Value { get; set; }
    public string CorrespondingLetterToLower { get; set; }
    public string CorrespondingLetterToUpper { get; set; }
    public string EscapeSequence { get; set; }
    public string Unicode { get; set; }
    public string HtmlCode { get; set; }


    public UnicodeLetter(string value, string correspondingLetterToLower, string correspondingLetterToUpper, string escapeSequence, string unicode, string htmlCode)
    {
        Value = value;
        CorrespondingLetterToLower = correspondingLetterToLower;
        CorrespondingLetterToUpper = correspondingLetterToUpper;
        EscapeSequence = escapeSequence;
        Unicode = unicode;
        HtmlCode = htmlCode;
    }
}