using DataCollector.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DataCollector;

class Program
{
    private static IConfiguration Configuration;

    static async Task Main(string[] args)
    {
        var host = new HostBuilder()
        .ConfigureAppConfiguration((hostContext, builder) =>
        {
            builder.AddJsonFile("appsettings.json", true);
            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        })
        .ConfigureServices((hostContext, services) =>
        {
            services.AddHostedService<DataCollectorService>();
            services.AddSerialPort(Configuration);
        })
        .ConfigureLogging(logConfig =>
        {
            logConfig.SetMinimumLevel(LogLevel.Information);
            logConfig.AddConsole();
        });

        await host.RunConsoleAsync();
    }
}