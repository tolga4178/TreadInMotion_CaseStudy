using Newtonsoft.Json;

namespace SmartGlove.Model.DTOs
{
    public class RequestDTO
    {
        [JsonProperty("device")]
        public Device? Device { get; set; }

        [JsonProperty("data")]
        public Data? Data { get; set; }
    }
    
    public class Data
    {

        [JsonProperty("event")]
        public string? Event { get; set; }

        [JsonProperty("input")]
        public List<Input>? Input { get; set; }
    }

    public class Device
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("battery_Level")]
        public int Battery_Level { get; set; }

        [JsonProperty("battery_Health")]
        public int Battery_Health { get; set; }
    }

    public class Input
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }

        [JsonProperty("source")]
        public string? Source { get; set; }
    }

 
}
