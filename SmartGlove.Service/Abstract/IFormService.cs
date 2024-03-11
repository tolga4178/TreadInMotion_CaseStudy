using SmartGlove.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGlove.Service.Abstract
{
    public interface IFormService
    {
        Task<ResponseDTO> DisplayFormScreen();
        Task<ResponseDTO> SubmitForm(FormDTO formDTO);
    }
}
