using MinistryForWidows.Contracts.Enums;
using System.ComponentModel.DataAnnotations;

namespace MinistryForWidows.Domain.Entities
{
    public class Page : Audit
    {
        [Key]
        public int PageId { get; set; }
        [StringLength(256)]
        public required string Title { get; set; }
        [StringLength(256)]
        public required string Alias { get; set; }
        public string? Body { get; set; }
        public Language Language { get; set; }
        public int Order { get; set; }
    }
}
