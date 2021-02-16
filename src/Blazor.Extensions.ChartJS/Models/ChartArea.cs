using System.Text.Json.Serialization;

namespace Blazor.Extensions.ChartJS
{
    public class ChartArea
    {
        [JsonPropertyName("top")]
        public double Top { get; set; }

        [JsonPropertyName("left")]
        public double Left { get; set; }

        [JsonPropertyName("right")]
        public double Right { get; set; }

        [JsonPropertyName("bottom")]
        public double Bottom { get; set; }
    }
}