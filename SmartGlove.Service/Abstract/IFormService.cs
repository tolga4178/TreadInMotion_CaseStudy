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
        Task<ResponseDTO> DisplayFormScreenAsync();
        Task<ResponseDTO> SubmitFormAsync(FormDTO formDTO);
    }
}
