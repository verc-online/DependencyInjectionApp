using BlazorServerDemo.Data;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorServerDemo
{
    public static class DemoDISetup
    {
        public static IServiceCollection AddDemoInfo(this IServiceCollection services)
        {

            services.AddSingleton<IDemo, Demo>();
            services.AddSingleton<IUtcDemo, UtcDemo>();
            services.AddSingleton<IProcessDemo, ProcessDemo>();

            return services;
        }
    }
}
