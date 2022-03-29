using InjecaoDependencia_e_Ioc.Controllers.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InjecaoDependencia_e_Ioc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            this.userService.Test();
            return Ok("Deu certo!");
        }

    }
}
