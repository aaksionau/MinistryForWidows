using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MinistryForWidows.Domain.Entities;

namespace MinistryForWidows.Persistence
{
    public class MinistryForWidowsDbContext : IdentityDbContext<IdentityUser>
    {
        public MinistryForWidowsDbContext(DbContextOptions<MinistryForWidowsDbContext> options) : base(options)
        {
        }

        public DbSet<Page> Pages { get; set; }
    }
}
