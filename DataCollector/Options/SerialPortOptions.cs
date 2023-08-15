namespace DataCollector.Options
{
    public class SerialPortOptions
    {
        public required string PortName { get; set; } = "/dev/ttyS0";
        public int? BaudRate { get; set; } = 115200;
        public int? ReadTimeout { get; set; } = 500;
        public int? WriteTimeout { get; set; } = 500;
        public string? NewLine { get; set; } = "\r";
    }
}

