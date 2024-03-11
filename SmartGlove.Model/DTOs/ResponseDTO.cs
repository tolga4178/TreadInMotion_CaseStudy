using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SmartGlove.Model.DTOs
{
    public class ResponseDTO
    {
        public Indicator? Indicator { get; set; }
        public int Mode { get; set; }
        public Screen? Screen { get; set; }
        public int Sleep { get; set; }
        public int StatusCode { get; set; }
    }


    public class Buzzer
        {
            public string? Control { get; set; }
            public int On_Time { get; set; }
            public int Off_Time { get; set; }
            public int Repeat { get; set; }
        }

        public class Indicator
        {
            public Light? Control { get; set; }
            public Buzzer? Buzzer { get; set; }
            public Vibration? Vibration { get; set; }
        }

        public class Light
        {
            public string? Bottom { get; set; }
            public string? Control { get; set; }
            public int On_Time { get; set; }
            public int Off_Time { get; set; }
            public int Repeat { get; set; }
        }

  
        public class Screen
        {
            public string? Header { get; set; }
            public int Line { get; set; }
            public string? State { get; set; }
            public string? Url { get; set; }
            public List<List<dynamic>>? Body { get; set; }
        }

        public class Vibration
        {
            public string? Control { get; set; }
            public int On_Time { get; set; }
            public int Off_Time { get; set; }
            public int Repeat { get; set; }
        }


    
}
