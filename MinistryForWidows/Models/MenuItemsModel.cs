namespace MinistryForWidows.Models
{
    public class MenuItemsModel
    {
        public List<(string, string)> Pages { get; set; } = new List<(string, string)>()
        {
            ("/index", "Home"),
            ("/page/about-us", "About Us"),
            ("/geography", "Geography"),
            ("/page/be-involved", "Be Envolved"),
            ("/contacts", "Contacts"),
        };
    }
}
