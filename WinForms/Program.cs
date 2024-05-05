using DiDemoLib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
                .ConfigureServices((_, services) =>
                {
                    services
                        .AddSingleton<IMessages, Messages>()
                        .AddTransient<Form1>();
                });
            var host = builder.Build();
            using var scope = host.Services.CreateScope();
            try
            {
                var services = scope.ServiceProvider;
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();

                var frm = services.GetRequiredService<Form1>();
                Application.Run(frm);

            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error has occured: {ex.Message}");
                Console.ReadLine();
            }
            
        }
    }
}