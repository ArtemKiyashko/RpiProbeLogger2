using DataCollector.Infrastructure;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DataCollector
{
	public class DataCollectorService : BackgroundService
    {
        private readonly ILogger<DataCollectorService> _logger;
        private readonly ITelemetryReader _telemetryReader;
        private readonly ITelemetrySender _telemetrySender;

        public DataCollectorService(
            ILogger<DataCollectorService> logger,
            ITelemetryReader telemetryReader,
            ITelemetrySender telemetrySender)
		{
            _logger = logger;
            _telemetryReader = telemetryReader;
            _telemetrySender = telemetrySender;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            throw new NotImplementedException();
        }
    }
}

