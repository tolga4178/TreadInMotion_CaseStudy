using SmartGlove.Model;
using SmartGlove.Model.DTOs;
using SmartGlove.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreadInMotion.SmartGlove.Sdk.Extensions;
using ThreadInMotion.SmartGlove.Sdk.Interfaces.Glove;
using ThreadInMotion.SmartGlove.Sdk.Models.Glove;
using ThreadInMotion.SmartGlove.Sdk.Services.Glove;

namespace SmartGlove.Service.Concrete
{
    public class FormManager : IFormService
    {
        public async Task<ResponseDTO> DisplayFormScreenAsync()
        {
            List<dynamic> formElements = new();
            formElements.Add(new List<string>());
            formElements.Add(new List<string>());
            formElements.Add(new List<dynamic>
            {
              new{Type="text",Value="Input_01",Font_No=2,Align="center" }
            });
            formElements.Add(new List<dynamic>
            {
              new {Type="input",Id="input_01",Font_No=2,Align="center" }
            });

            formElements.Add(new List<dynamic>
            {
              new{Type="text",Value="Input_02",Font_No=2,Align="center" }
            });

            formElements.Add(new List<dynamic>
             {
              new{Type="input",Id="input_02",Font_No=2,Align="center" }
            });

            formElements.Add(new List<string>());

            formElements.Add(new List<dynamic>
             {
              new{Type="button",Id="submitform",Name="SubmitForm",Font_No=2,Align="right",Url="/api/form/submit" }
            });

            return new ResponseDTO {

                Mode = 5,
                Sleep = 0,
                Screen = new()
                {
                    State = "form",
                    Header = "Form",
                    Body = new List<List<dynamic>> { formElements },
                }

            };
        }

        public async Task<ResponseDTO> SubmitFormAsync(FormDTO formDTO)
        {


            List<dynamic> formElements = new();
            formElements.Add(new List<string>());
            formElements.Add(new List<string>());
            formElements.Add(new List<dynamic>
            {
              new{Type="text",Value="First Input Value",Font_No=2,Align="center" }
            });

            formElements.Add(new List<dynamic>
            {
              new{Type="text",Value=formDTO.Input1Value,Font_No=2,Align="center" }
            });

            formElements.Add(new List<dynamic>
            {
              new{Type="text",Value="Second Input Value",Font_No=2,Align="center" }
            });

            formElements.Add(new List<dynamic>
            {
              new{Type="text",Value=formDTO.Input2Value,Font_No=2,Align="center" }
            });


            formElements.Add(new List<string>());

            formElements.Add(new List<dynamic>
             {
              new{Type="button",Id="backform",Name="BackForm",Font_No=2,Align="right",Url="/api/form/diplayformscreen" }
            });



            return new ResponseDTO
            {
                Mode = 5,
                Sleep = 0,
                Screen = new()
                {
                    State = "submit",
                    Header = "Submit",
                    Body = new List<List<dynamic>> { formElements },
                }
            };
        }
    }
}
