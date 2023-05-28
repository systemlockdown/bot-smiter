using BS.Domain.DatabaseObjects;
using Microsoft.EntityFrameworkCore;

namespace BS.Infrastructure;

public class BotSmiterDbContext : DbContext
{
    public DbSet<UnicodeLetter> LetterBank { get; set; }
    public DbSet<QuestionPrompt> QuestionPrompts { get; set; }

    public BotSmiterDbContext(DbContextOptions<BotSmiterDbContext> options)
        : base(options)
    {
        
    }
}