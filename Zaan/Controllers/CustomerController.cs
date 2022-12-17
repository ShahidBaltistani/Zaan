using Microsoft.AspNetCore.Mvc;
using Zaan.Models.Model;
using Zaan.Repositories.Customers;
using Zaan.Repositories.Salers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zaan.Controllers
{
    [Route("customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository customerService;
        public CustomerController(ICustomerRepository _customer)
        {
            this.customerService = _customer;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> Get()
        {
            return Ok( await customerService.GetAll());
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await customerService.GetById(id);
            if (data != null)
            {
                return Ok();
            }
            return NotFound();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Customer model)
        {
            if(model != null)
            {
              customerService.Add(model);
                return Ok();
            }
            return BadRequest(model);
        }

        // PUT api/<CustomerController>/5
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Customer model)
        {
                if (model != null)
                {
                     customerService.Update(model);
                    return Ok("Updated");
                }
            return BadRequest("Id is null");
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id > 0)
            {
                var cust = await customerService.GetById(id);
                if (cust != null)
                {
                   await customerService.Delete(cust);
                    return Ok("Deleted");
                }
            }
            return BadRequest("Id is null");
        }
    }
}
