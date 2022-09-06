using System.ComponentModel.DataAnnotations;

namespace FA22.P03.Web.Data.Entity
{
    public class Item
    {
        [Required]
        public int Id { get; set; }

        public Product Product { get; set; }

        public string? Condition { get; set; }

        public ICollection<ItemListing> ItemListings { get; set; }
}
}
