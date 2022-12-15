using Microsoft.AspNetCore.Mvc;
using Zaan.Models.Model;
using Zaan.Repositories.Customers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zaan.Controllers
{
    [Route("customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository customer;
        public CustomerController(ICustomerRepository customer)
        {
            this.customer = customer;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        [Route("getall")]
        public async Task<IEnumerable<Customer>> Get()
        {
            return await customer.GetAll();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<Customer> Get(int id)
        {
            return await customer.GetById(id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
