namespace BS.Domain.Models;

public record QuestionPromptModel
{
    public Guid Id { get; set; }
    public string Question { get; set; }
}