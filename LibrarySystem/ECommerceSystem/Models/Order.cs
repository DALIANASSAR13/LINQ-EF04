
namespace ECommerceSystem.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        // Foreign key
        public int CustomerId { get; set; }

        // Navigation property
        public Customer Customer { get; set; } = null!;

        // Many-to-many relationship through OrderDetail
        public ICollection<OrderDetail> OrderDetails { get; set; }
            = new List<OrderDetail>();
    }
}
