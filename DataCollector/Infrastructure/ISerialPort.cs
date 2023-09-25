namespace DataCollector.Infrastructure
{
	public interface ISerialPort
	{
		void WriteLine(string text);
		string ReadExisting();
	}
}

