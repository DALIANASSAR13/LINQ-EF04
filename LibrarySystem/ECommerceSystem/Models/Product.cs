
namespace ECommerceSystem.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        // Foreign key
        public int CategoryId { get; set; }

        // Navigation property
        public Category Category { get; set; } = null!;

        // Many-to-many relationship through OrderDetail
        public ICollection<OrderDetail> OrderDetails { get; set; }
            = new List<OrderDetail>();
    }
}
