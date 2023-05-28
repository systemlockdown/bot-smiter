namespace BS.Domain.DatabaseObjects;

public class LetterBank
{
    public string CorrespondingLetterToLower { get; set; }
    public string CorrespondingLetterToUpper { get; set; }
    public string EscapeSequence { get; set; }
    public string Unicode { get; set; }
    public string HtmlCode { get; set; }
    public string Value { get; set; }

    public LetterBank(string value, string correspondingLetterToLower, string correspondingLetterToUpper, string escapeSequence, string unicode, string htmlCode)
    {
        CorrespondingLetterToLower = correspondingLetterToLower;
        correspondingLetterToUpper = correspondingLetterToUpper;
        EscapeSequence = escapeSequence;
        Unicode = unicode;
        HtmlCode = htmlCode;
        Value = value;
    }
}