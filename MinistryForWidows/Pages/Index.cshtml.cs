using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MinistryForWidows.Contracts.Dtos;
using MinistryForWidows.Contracts.Enums;
using MinistryForWidows.Domain.Repositories;

namespace MinistryForWidows.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> logger;
        private readonly IPageRepository pageRepository;

        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();

        public IndexModel(ILogger<IndexModel> logger, IPageRepository pageRepository)
        {
            this.logger = logger;
            this.pageRepository = pageRepository;
        }

        public async Task OnGet()
        {
            this.MenuItems = await this.pageRepository.GetMenuItemsAsync(Language.English);
        }
    }
}
