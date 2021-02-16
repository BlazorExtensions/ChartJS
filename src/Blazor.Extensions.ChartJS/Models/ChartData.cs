using System;
using System.Text.Json.Serialization;

namespace Blazor.Extensions.ChartJS
{
    public class ChartData
    {
        [JsonPropertyName("labels")]
        public string[]? Labels { get; set; }

        [JsonPropertyName("datasets")]
        [JsonConverter(typeof(ChartDatasetConverter))]
        public IChartDataset[] Datasets { get; set; } = Array.Empty<IChartDataset>();
    }
}