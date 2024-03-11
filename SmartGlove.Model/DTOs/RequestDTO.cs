

namespace SmartGlove.Model.DTOs
{
    public class RequestDTO
    {
        public Device? Device { get; set; }
        public Data? Data { get; set; }
    }
    
    public class Data
    {
        public string? Event { get; set; }
        public List<Input>? Input { get; set; }
    }

    public class Device
    {
        public string? Id { get; set; }
        public int Battery_Level { get; set; }
        public int Battery_Health { get; set; }
    }

    public class Input
    {
        public string? Id { get; set; }
        public string? Value { get; set; }
        public string? Source { get; set; }
    }

 
}
