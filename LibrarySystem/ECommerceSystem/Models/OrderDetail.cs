
namespace ECommerceSystem.Models
{
    public class OrderDetail
    {
        // Composite primary key: OrderId + ProductId

        public int OrderId { get; set; }

        public Order Order { get; set; } = null!;

        public int ProductId { get; set; }

        public Product Product { get; set; } = null!;

        public int Quantity { get; set; }
    }
}
