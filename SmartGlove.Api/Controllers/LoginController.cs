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


        [HttpGet("DisplayLoginScreenAsync")]
        public async Task<IActionResult> DisplayLoginScreenAsync()
        {
            var loginObject = await _loginService.DisplayLoginScreenAsync();
            
            return Ok(loginObject);
        }


        [HttpPost("AuthenticateAsync")]
        public async Task<IActionResult> AuthenticateAsync(LoginDTO loginDTO)
        {
            var authenticateObject = await _loginService.AuthenticateAsync(loginDTO);

            if (authenticateObject.StatusCode == StatusCodes.Status200OK)
                return Ok(authenticateObject);

            else
                return Unauthorized(authenticateObject);

        }

        [HttpGet("Languages")]
        public async Task<IActionResult> Languages()
        {
            return Ok();
        }
    }
}
