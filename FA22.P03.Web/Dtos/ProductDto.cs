using System.ComponentModel.DataAnnotations;

namespace FA22.P03.Web.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
