using System.ComponentModel.DataAnnotations;

namespace FA22.P03.Web.Dtos
{
    public class ProductDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
