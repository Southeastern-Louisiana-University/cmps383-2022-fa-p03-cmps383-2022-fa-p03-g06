using System.ComponentModel.DataAnnotations;

namespace FA22.P03.Web.Dtos
{
    public class ListingDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public DateTimeOffset StartUtc { get; set; }

        public DateTimeOffset EndUtc { get; set; }

    [Required]
        public decimal Price { get; set; }
    }
}
