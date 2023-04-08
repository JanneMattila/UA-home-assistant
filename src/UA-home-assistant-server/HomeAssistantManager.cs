using HassClient.WS;
using HomeAssistantOPCUAServer.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace HomeAssistantOPCUAServer;

public class HomeAssistantManager
{
    private readonly ILogger<HomeAssistantManager> _logger;
    private readonly HomeAssistantOptions _options;

    private HassWSApi _client;
    private readonly string _url;
    private readonly string _token;

    public HomeAssistantManager(ILogger<HomeAssistantManager> logger, IOptions<HomeAssistantOptions> options)
    {
        _logger = logger;
        _options = options.Value;
    }

    public async Task LoginAsync()
    {
        _client = new HassWSApi();
        var connectionParameters = ConnectionParameters.CreateFromInstanceBaseUrl(_options.Url, _options.Token);
        await _client.ConnectAsync(connectionParameters);
    }

    public async Task FetchEntityStatesAsync()
    {
        var states = await _client.GetStatesAsync();
        foreach (var state in states)
        {

        }
    }
}
