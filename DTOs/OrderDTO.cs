using AgregatesDDD.Models;

namespace AgregatesDDD.DTOs
{
    public class OrderDTO
    {
        public ICollection<Product> Products { get; set; }
        public int CustomerId { get; set; }
        public OrderStatus Status { get; set; }
        public Address Address { get; set; }
    }
}
