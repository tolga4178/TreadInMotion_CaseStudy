﻿using Microsoft.AspNetCore.Http;
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

        [HttpGet("displayformscreen")]
        public async Task<IActionResult> DisplayFormScreen()
        {
            var formObject = await _formService.DisplayFormScreen();

            return Ok(formObject);
        }


        [HttpPost("submit")]
        public async Task<IActionResult> Submit(FormDTO formDTO)
        { 
           
            var submitObject = await _formService.SubmitForm(formDTO);

            return Ok(submitObject);
        }
    }
}
