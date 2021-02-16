using System.Collections;

namespace Blazor.Extensions.ChartJS
{
    public interface IChartConfiguration
    {
        ChartType Type { get; }
    }

    public interface IChartConfiguration<TChartData, TData, TDataset, TLabel> : IChartConfiguration
        where TChartData : IChartData<TData, TDataset, TLabel>
        where TDataset : IChartDataset<TData>
        where TData : IEnumerable
    {
        TChartData Data { get; set; }

        // IChartOptions? Options { get; set; }
        object? Options { get; set; }
    }
}