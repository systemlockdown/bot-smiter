namespace BS.Domain.DatabaseObjects;

public abstract class DbEntity
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime Modified { get; set; }
    public Guid ModifiedBy { get; set; }
}