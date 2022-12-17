using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Zaan.Models.Model;
using Zaan.Repositories.Salers;

namespace Zaan.Controllers
{
    [Route("saler")]
    [ApiController]
    public class SalerController : ControllerBase
    {
        private readonly ISalerRepository salerService;
        public SalerController(ISalerRepository _customer)
        {
            this.salerService = _customer;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> Get()
        {
            return Ok(await salerService.GetAll());
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await salerService.GetById(id);
            if (data != null)
            {
                return Ok();
            }
            return NotFound();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public IActionResult Add([FromBody] Saler model)
        {
            if (model != null)
            {
                salerService.Add(model);
                return Ok();
            }
            return BadRequest(model);
        }

        // PUT api/<CustomerController>/5
        [HttpPut]
        public IActionResult Update([FromBody] Saler model)
        {
            if (model != null)
            {
                salerService.Update(model);
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
                var cust = await salerService.GetById(id);
                if (cust != null)
                {
                    await salerService.Delete(cust);
                    return Ok("Deleted");
                }
            }
            return BadRequest("Id is null");
        }
    }
}
}
