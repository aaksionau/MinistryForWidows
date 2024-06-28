using Mapster;
using Microsoft.EntityFrameworkCore;
using MinistryForWidows.Contracts.Dtos;
using MinistryForWidows.Contracts.Enums;
using MinistryForWidows.Domain.Repositories;

namespace MinistryForWidows.Persistence.Repositories
{
    public class PageRepository : IPageRepository
    {
        private readonly MinistryForWidowsDbContext dbContext;

        public PageRepository(MinistryForWidowsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<MenuItem>> GetMenuItemsAsync(Language language)
        {
            return await dbContext.Pages
                                  .Where(x => x.Language == language)
                                  .ProjectToType<MenuItem>()
                                  .ToListAsync();
        }
    }
}
