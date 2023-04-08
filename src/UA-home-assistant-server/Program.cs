using HomeAssistantOPCUAServer;
using HomeAssistantOPCUAServer.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Home Assistant OPC UA Server");

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddOptions<HomeAssistantOptions>()
        .Configure<IConfiguration>((settings, configuration) =>
        {
            configuration.GetSection("HomeAssistant").Bind(settings);
        });
        services.AddSingleton<HomeAssistantManager>();
    })
    .Build();


var homeAssistantManager = host.Services.GetService<HomeAssistantManager>();
await homeAssistantManager.LoginAsync();
await homeAssistantManager.FetchEntityStatesAsync();

await host.RunAsync();
