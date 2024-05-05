using ConsoleUI;
using DiDemoLib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

internal class Program
{
    private static void Main(string[] args)
    {
        using IHost host = CreateHostBuilder(args).Build();
        using var scope = host.Services.CreateScope();

        var services = scope.ServiceProvider;

        try
        {
            services.GetRequiredService<App>().Run();
            
        }
        catch (Exception ex)
        {

            Console.WriteLine($"An error has occured: {ex.Message}");
            Console.ReadLine();
        }
    }

    static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
        .ConfigureServices((_, services) =>
        {
            services.AddTransient<IMessages, Messages>();
            services.AddTransient<App>();
        });
}