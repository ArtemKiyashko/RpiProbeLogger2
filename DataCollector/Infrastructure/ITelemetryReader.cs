using SharedModels.SIM7000E;

namespace DataCollector.Infrastructure
{
	public interface ITelemetryReader
	{
		public GpsData Read();
	}
}

