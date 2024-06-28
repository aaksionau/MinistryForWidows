namespace MinistryForWidows.Domain.Entities
{
    public abstract class Audit
    {
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; } = DateTimeOffset.UtcNow;
    }
}
