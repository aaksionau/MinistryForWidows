using MinistryForWidows.Contracts.Enums;

namespace MinistryForWidows.Contracts.Dtos
{
    public class MenuItem
    {
        public required string Title { get; set; }
        public required string Alias { get; set; }
        public Language Language { get; set; }
    }
}
