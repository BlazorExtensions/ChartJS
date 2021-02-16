using Microsoft.Extensions.DependencyInjection;

namespace Blazor.Extensions.ChartJS
{
    public static class HostingExtensions
    {
        public static IServiceCollection AddChartJS(this IServiceCollection services)
        {
            return services
                .AddScoped<IChartJSService, ChartJSService>();
        }
    }
}