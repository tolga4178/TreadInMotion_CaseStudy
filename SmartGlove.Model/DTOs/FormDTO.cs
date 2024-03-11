using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace SmartGlove.Model.DTOs
{
    public class FormDTO
    {

        [JsonProperty("input1Value")]
        public string? Input1Value { get; set; }

        [JsonProperty("input2Value")]
        public string? Input2Value { get; set; }
    }
}
