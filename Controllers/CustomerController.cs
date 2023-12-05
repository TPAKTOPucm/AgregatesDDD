using AgregatesDDD.DTOs;
using AgregatesDDD.Factories;
using AgregatesDDD.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AgregatesDDD.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _repository;
        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IActionResult Get() => Ok(_repository.GetCustomers());
        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok(_repository.GetCustomerById(id));
        [HttpPost]
        public IActionResult Post(CustomerDTO dto)
        {
            var customer = CustomerFactory.CreateCustomer(dto);
            _repository.AddCustomer(customer);
            return Ok(customer);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var customer = _repository.GetCustomerById(id);
            if (_repository.DeleteCustomer(customer))
                return Ok(customer);
            return BadRequest();
        }
        [HttpPut]
        public IActionResult Put(int id, CustomerDTO dto)
        {
            var customer = CustomerFactory.CreateCustomer(id, dto);
            if (_repository.UpdateCustomer(customer))
            {
                return Ok(customer);
            }
            return BadRequest();
        }
    }
}