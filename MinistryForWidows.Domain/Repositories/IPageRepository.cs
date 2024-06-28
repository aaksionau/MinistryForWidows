using MinistryForWidows.Contracts.Dtos;
using MinistryForWidows.Contracts.Enums;

namespace MinistryForWidows.Domain.Repositories
{
    public interface IPageRepository
    {
        Task<List<MenuItem>> GetMenuItemsAsync(Language language);
    }
}
