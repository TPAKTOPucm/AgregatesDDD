using AgregatesDDD.Models;

namespace AgregatesDDD.Repositories
{
    public interface IOrderRepository
    {
        Order GetOrderById(int id);
        ICollection<Order> GetOrders();
        void AddOrder(Order order);
        bool DeleteOrder(Order order);
    }
}
