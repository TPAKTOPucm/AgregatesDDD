using AgregatesDDD.DTOs;
using AgregatesDDD.Factories;
using AgregatesDDD.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AgregatesDDD.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _repository;
        public OrderController(IOrderRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IActionResult Get() => Ok(_repository.GetOrders());
        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok(_repository.GetOrderById(id));
        [HttpPost]
        public IActionResult Post([FromBody]OrderDTO dto)
        {
            try
            {
                var order = OrderFactory.CreateOrder(dto);
                _repository.AddOrder(order);
                return Ok();
            } catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var order = _repository.GetOrderById(id);
            if(_repository.DeleteOrder(order))
                return Ok(order);
            return BadRequest();
        }
    }
}
