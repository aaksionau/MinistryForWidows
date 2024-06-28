using Microsoft.EntityFrameworkCore;
using MinistryForWidows.Domain.Entities;

namespace MinistryForWidows.Persistence
{
    public class MinistryForWidowsDbContext : DbContext
    {
        public MinistryForWidowsDbContext(DbContextOptions<MinistryForWidowsDbContext> options) : base(options)
        {
        }

        public DbSet<Page> Pages { get; set; }
    }
}
