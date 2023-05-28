namespace BS.Domain.DatabaseObjects;

public class QuestionPrompt : DbEntity
{
    public string Question { get; set; }

    public QuestionPrompt(string question)
    {
        Question = question;
    }
}