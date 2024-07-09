using MinistryForWidows.Contracts.Enums;
using System.ComponentModel.DataAnnotations;

namespace MinistryForWidows.Domain.Entities
{
    public class BlogPost : Audit
    {
        [Key]
        public int BlogPostId { get; set; }
        [StringLength(256)]
        public required string Title { get; set; }
        public string? Body { get; set; }
        public string? MainThumbnailPath { get; set; }
        public List<Country>? Countries { get; set; }
        public string? YoutubeUrl { get; set; }
        public Language Language { get; set; }
    }
}
