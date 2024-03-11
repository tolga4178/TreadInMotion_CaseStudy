using Microsoft.AspNetCore.Http;
using SmartGlove.Model;
using SmartGlove.Model.DTOs;
using SmartGlove.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreadinMotion;

namespace SmartGlove.Service.Concrete
{
    public class LoginManager : ILoginService
    {
     
        public async Task <ResponseDTO> DisplayLoginScreenAsync()
        {

            List<dynamic> formElements = new ();
            formElements.Add(new List<string>());
            formElements.Add(new List<string>());
            formElements.Add(new List<dynamic>
            {
              new{Type="text",Value="Username",Font_No=2,Align="center" }
            });
            formElements.Add(new List<dynamic>
            {
              new {Type="input",Id="username",Font_No=2,Align="center" }
            });

            formElements.Add(new List<dynamic>
            {
              new{Type="text",Value="Password",Font_No=2,Align="center" }
            });

            formElements.Add(new List<dynamic>
             {
              new{Type="input",Id="password",Font_No=2,Align="center" }
            });

            formElements.Add(new List<string>());

            formElements.Add(new List<dynamic>
             {
              new{Type="button",Id="changelang",Name="ChangeLanguage",Font_No=2,Align="right",Url="/api/login/languages" }
            });

            formElements.Add(new List<dynamic>
             {
              new{Type="button",Id="backloginscreen",Name="BackLoginScreen",Font_No=2,Align="right",Url="/api/login/diplayloginscreen" }
            });


            return new ResponseDTO {
                Mode = 5,
                Sleep = 0,
                Screen = new()
                {
                    State = "login",
                    Header = "Login",
                    Body = new List<List<dynamic>> { formElements },
                    Url = "/api/login/authenticate"
                }

              

            };
        }

        public async Task<ResponseDTO> AuthenticateAsync(LoginDTO loginDTO)
        {


            ResponseDTO response = new()
            {
                Mode = 5,
                Sleep = 0,
                Screen = new()
                {
                    State = "authenticate",
                    Header = "Authenticate"
                }
            };


            List<dynamic> formElements = new();
            formElements.Add(new List<string>());
            formElements.Add(new List<string>());

            if (loginDTO.Username == CredentialProvider.Username && loginDTO.Password == CredentialProvider.Password)
            {

                response.StatusCode = StatusCodes.Status200OK;

                formElements.Add(new List<dynamic>
            {
              new{Type="text",Value="Successfully Login",Font_No=4,Align="center" }
            });

            }

            else
            {

                response.StatusCode = StatusCodes.Status401Unauthorized;
                formElements.Add(new List<dynamic>
            {
                new{Type="text",Value="UserName or Password is not correct!",Font_No=4,Align="center" }
            });
            }


            response.Screen.Body = new List<List<dynamic>> { formElements };


            return response;
        }
    }
}
