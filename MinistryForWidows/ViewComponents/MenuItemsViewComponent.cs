using Microsoft.AspNetCore.Mvc;
using MinistryForWidows.Models;

namespace MinistryForWidows.ViewComponents
{
    public class MenuItemsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new MenuItemsModel());
        }
    }
}
