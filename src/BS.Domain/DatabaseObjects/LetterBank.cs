namespace BS.Domain.DatabaseObjects;

public class LetterBank
{
    public string CorrespondingLetter { get; set; }
    public string EscapeSequence { get; set; }
    public string Unicode { get; set; }
    public string HtmlCode { get; set; }

    public LetterBank(string correspondingLetter, string escapeSequence, string unicode, string htmlCode)
    {
        CorrespondingLetter = correspondingLetter;
        EscapeSequence = escapeSequence;
        Unicode = unicode;
        HtmlCode = htmlCode;
    }
}