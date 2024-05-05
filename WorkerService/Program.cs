using DiDemoLib;
using WorkerService;

internal class Program
{
    private static async Task Main(string[] args)
    {
        IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services
            .AddHostedService<Worker>()
            .AddTransient<IMessages, Messages>();
    })
    .Build();

        await host.RunAsync();
    }
}