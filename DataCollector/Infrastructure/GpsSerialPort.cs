using System.IO.Ports;
using DataCollector.Options;
using Microsoft.Extensions.Options;

namespace DataCollector.Infrastructure
{
	public class GpsSerialPort : ISerialPort, IDisposable
	{
        private SerialPortOptions _options;
        private SerialPort _serialPort;

        public GpsSerialPort(IOptionsMonitor<SerialPortOptions> options)
		{
            _options = options.CurrentValue;
            options.OnChange(SerialPortOptionsChanged);
            _serialPort = PortInitialize();
            _serialPort.Open();
        }

        private void SerialPortOptionsChanged(SerialPortOptions options, string? arg2)
        {
            _options = options;
            _serialPort.Close();
            _serialPort.Dispose();
            _serialPort = PortInitialize();
            _serialPort.Open();
        }

        private SerialPort PortInitialize() =>
            new(_options.PortName, _options.BaudRate ?? 115200)
            {
                ReadTimeout = _options.ReadTimeout ?? 500,
                WriteTimeout = _options.WriteTimeout ?? 500,
                NewLine = _options.NewLine ?? "/r"
            };

        public string ReadExisting() => _serialPort.ReadExisting();

        public void WriteLine(string text) => _serialPort.WriteLine(text);

        public void Dispose()
        {
            if (_serialPort.IsOpen)
                _serialPort.Close();
            _serialPort.Dispose();
        }
    }
}

