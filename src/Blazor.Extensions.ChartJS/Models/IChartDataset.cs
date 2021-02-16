using System.Collections;

namespace Blazor.Extensions.ChartJS
{
    public interface IChartDataset : IControllerDatasetOptions
    {
        ChartType ChartType { get; set; }
    }

    public interface IChartDataset<TData> : IChartDataset where TData : IEnumerable
    {
        TData Data { get; set; }
    }
}