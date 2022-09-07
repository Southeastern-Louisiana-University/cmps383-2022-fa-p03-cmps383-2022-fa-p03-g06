using System.ComponentModel.DataAnnotations;

namespace FA22.P03.Web.Dtos
{
    public class ListingDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public DateTimeOffset StartUtc { get; set; }

        public DateTimeOffset EndUtc { get; set; }

        public decimal Price { get; set; }
    }
}
