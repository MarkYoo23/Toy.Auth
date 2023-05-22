using Microsoft.AspNetCore.Mvc;
using Toy.Auth.Applications;

namespace Toy.Auth.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly MicrosoftJwtCreateService _loginService;

        public UserController(MicrosoftJwtCreateService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost("ms")]
        public IActionResult Login()
        {
            var token =_loginService.CreateToken();
            return Ok(new { Authrorization  = token});
        }
    }
}
