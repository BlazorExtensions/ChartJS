using System.Collections;
using System.Text.Json.Serialization;

namespace Blazor.Extensions.ChartJS
{
    public interface IChartData<TData, TDataset, TLabel> where TDataset : IChartDataset<TData> where TData : IEnumerable
    {
        [JsonPropertyName("labels")]
        TLabel[] Labels { get; set; }

        [JsonPropertyName("datasets")]
        TDataset[] Datasets { get; set; }
    }
}