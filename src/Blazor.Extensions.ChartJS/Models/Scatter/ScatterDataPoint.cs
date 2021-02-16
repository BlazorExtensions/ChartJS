using System.Text.Json.Serialization;

namespace Blazor.Extensions.ChartJS
{
    public class ScatterDataPoint
    {
        [JsonPropertyName("x")]
        public double X { get; set; }

        [JsonPropertyName("y")]
        public double Y { get; set; }
    }
}