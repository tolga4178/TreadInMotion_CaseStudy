using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartGlove.Model.DTOs;
using SmartGlove.Service.Abstract;

namespace SmartGlove.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private IFormService _formService;
        public FormController(IFormService formService)
        {
                _formService = formService;
        }

        [HttpGet("DisplayFormScreenAsync")]
        public async Task<IActionResult> DisplayFormScreenAsync()
        {
            var formObject = await _formService.DisplayFormScreenAsync();

            return Ok(formObject);
        }


        [HttpPost("SubmitFormAsync")]
        public async Task<IActionResult> SubmitFormAsync(FormDTO formDTO)
        { 
           
            var submitObject = await _formService.SubmitFormAsync(formDTO);

            return Ok(submitObject);
        }
    }
}
