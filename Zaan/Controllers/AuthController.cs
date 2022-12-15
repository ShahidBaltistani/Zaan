using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Zaan.Repositories.Auth;
using Zaan.ViewModel.DTO;

namespace Zaan.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository authRepository;
        public AuthController(IAuthRepository authRepository)
        {
            this.authRepository = authRepository;
        }
        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpPost]
        [Route("signup")]
        public async Task<IActionResult> SignUp(SignUpDTO model)
        {
            if (model.RoleId == 1)
            {

            }
            else if (model.RoleId == 2)
            {
              
            } 
            else if (model.RoleId == 3)
            {
                await authRepository.SignUpCustomer(model);
            } 
            else
            {

            }
            return Ok();
        }
    }
}
