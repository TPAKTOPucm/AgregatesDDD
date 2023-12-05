using AgregatesDDD.Models;

namespace AgregatesDDD.Repositories
{
    public class OrderRepository: IOrderRepository
    {
        private ICollection<Order> _orders;
        public OrderRepository()
        {
            _orders = new HashSet<Order>();
        }

        public Order GetOrderById(int id) => _orders.FirstOrDefault(o => o.Id == id);

        public ICollection<Order> GetOrders() => _orders;

        public void AddOrder(Order order)
        { 
            _orders.Add(order);
        }

        public bool DeleteOrder(Order order) => _orders.Remove(order);
    }
}
