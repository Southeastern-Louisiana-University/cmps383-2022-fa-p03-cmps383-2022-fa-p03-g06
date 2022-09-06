using System.ComponentModel.DataAnnotations;

namespace FA22.P03.Web.Dtos
{
    public class ItemDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Condition { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int ProductId { get; set; }
    }
}
