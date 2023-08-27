using DataCollector.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DataCollector.Infrastructure;

namespace DataCollector.Extensions
{
	public static class ServiceCollectionExtension
	{
        public static IServiceCollection AddSerialPort(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<SerialPortOptions>(configuration.GetSection($"{nameof(SerialPortOptions)}"));
            services.AddSingleton<ISerialPort, GpsSerialPort>();
            return services;
        }
    }
}

