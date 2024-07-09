using System.ComponentModel.DataAnnotations;

namespace MinistryForWidows.Domain.Entities
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        [StringLength(256)]
        public required string Name { get; set; }
        public double? Lon { get; set; }
        public double? Lat { get; set; }
    }
}
