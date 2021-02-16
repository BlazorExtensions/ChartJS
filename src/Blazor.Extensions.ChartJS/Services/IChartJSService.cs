using System;
using System.Threading.Tasks;

namespace Blazor.Extensions.ChartJS
{
    public interface IChartJSService
    {
        Task<IChartReference> CreateChart(Guid chartId, ChartConfiguration chartConfiguration);
    }
}