namespace BS.Domain.Models;

public record QuestionPromptModel
{
    public Guid QuestionId { get; set; }
    public string Question { get; set; }
}