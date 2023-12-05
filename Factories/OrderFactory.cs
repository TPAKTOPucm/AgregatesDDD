using AgregatesDDD.DTOs;
using AgregatesDDD.Models;
using System.Collections.Immutable;

namespace AgregatesDDD.Factories
{
    public class OrderFactory
    {
        private static int id = 0;
        public static Order CreateOrder(int customerId, ICollection<Product> products, OrderStatus status, Address address) => new()
        {
            Id = id++,
            CustomerId = customerId,
            Products = new(products.ToImmutableList()),
            Status = status,
            Address = address
        };
        public static Order CreateOrder(OrderDTO dto) => CreateOrder(dto.CustomerId, dto.Products, dto.Status, dto.Address);
    }
}
