using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace SmartGlove.Model.DTOs
{
    public class ResponseDTO
    {

        [JsonProperty("indicator")]
        public Indicator? Indicator { get; set; }

        [JsonProperty("mode")]
        public int Mode { get; set; }

        [JsonProperty("screen")]
        public Screen? Screen { get; set; }

        [JsonProperty("sleep")]
        public int Sleep { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }
    }


    public class Buzzer
        {

        [JsonProperty("control")]
        public string? Control { get; set; }

        [JsonProperty("on_Time")]
        public int On_Time { get; set; }

        [JsonProperty("off_Time")]
        public int Off_Time { get; set; }

        [JsonProperty("repeat")]
        public int Repeat { get; set; }
        }

        public class Indicator
        {

        [JsonProperty("control")]
        public Light? Control { get; set; }

        [JsonProperty("buzzer")]
        public Buzzer? Buzzer { get; set; }

        [JsonProperty("vibration")]
        public Vibration? Vibration { get; set; }
        }

        public class Light
        {

        [JsonProperty("bottom")]
        public string? Bottom { get; set; }

        [JsonProperty("control")]
        public string? Control { get; set; }

        [JsonProperty("on_Time")]
        public int On_Time { get; set; }

        [JsonProperty("off_Time")]
        public int Off_Time { get; set; }

        [JsonProperty("repeat")]
        public int Repeat { get; set; }
        }

  
        public class Screen
        {

        [JsonProperty("header")]
        public string? Header { get; set; }

        [JsonProperty("line")]
        public int Line { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("body")]
        public List<List<dynamic>>? Body { get; set; }
        }

        public class Vibration
        {

        [JsonProperty("control")]
        public string? Control { get; set; }

        [JsonProperty("on_Time")]
        public int On_Time { get; set; }

        [JsonProperty("off_Time")]
        public int Off_Time { get; set; }

        [JsonProperty("repeat")]
        public int Repeat { get; set; }
        }


    
}
