using AgregatesDDD.Models;

namespace AgregatesDDD.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int id);
        ICollection<Customer> GetCustomers();
        void AddCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(Customer customer);
    }
}
