using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartGlove.Model.DTOs;
using SmartGlove.Service.Abstract;
using ThreadinMotion.SmartGlove.Sdk;
namespace SmartGlove.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }


        [HttpGet("login")]
        public async Task<IActionResult> DisplayLoginScreen()
        {
            var loginObject = await _loginService.DisplayLoginScreen();
            
            return Ok(loginObject);
        }


        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(LoginDTO loginDTO)
        {
            var authenticateObject = await _loginService.Authenticate(loginDTO);

            if (authenticateObject.StatusCode == StatusCodes.Status200OK)
                return Ok(authenticateObject);

            else
                return Unauthorized(authenticateObject);

        }

        [HttpGet("languages")]
        public async Task<IActionResult> Languages()
        {

            return Ok();
        }
    }
}
