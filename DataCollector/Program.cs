using DataCollector;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

IConfiguration Configuration;

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
    })
    .ConfigureLogging(logConfig =>
    {
        logConfig.SetMinimumLevel(LogLevel.Information);
        logConfig.AddConsole();
    });

await host.RunConsoleAsync();