using SharedModels.SIM7000E;

namespace DataCollector.Infrastructure
{
	public interface ITelemetrySender
	{
		public void Send(GpsData gpsData);
	}
}

