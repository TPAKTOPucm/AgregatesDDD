using AgregatesDDD.Models;

namespace AgregatesDDD.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private ICollection<Customer> _customers;
        public CustomerRepository()
        {
            _customers = new HashSet<Customer>();
        }

        public Customer GetCustomerById(int id) => _customers.FirstOrDefault(c => c.Id == id);

        public ICollection<Customer> GetCustomers() => _customers;
        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public bool UpdateCustomer(Customer customer)
        {
            var exist = GetCustomerById(customer.Id);
            if (exist == null)
            {
                return false;
            }
            exist.FirstName = customer.FirstName;
            exist.LastName = customer.LastName;
            exist.CardType = customer.CardType;
            exist.PaymentType = customer.PaymentType;
            return true;
        }

        public bool DeleteCustomer(Customer customer) => _customers.Remove(customer);
    }
}
