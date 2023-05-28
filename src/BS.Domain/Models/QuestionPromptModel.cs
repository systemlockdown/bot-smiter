namespace BS.Domain.Models;

public class QuestionPromptModel
{
    public Guid QuestionId { get; set; }
    public string Question { get; set; }

    public QuestionPromptModel(Guid questionId, string question)
    {
        QuestionId = questionId;
        Question = question;
    }
}