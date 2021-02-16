using System.Text.Json.Serialization;

namespace Blazor.Extensions.ChartJS
{
    public class BorderRadius
    {
        [JsonPropertyName("topLeft")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double TopLeft { get; set; }

        [JsonPropertyName("topRight")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double TopRight { get; set; }

        [JsonPropertyName("bottomLeft")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double BottomLeft { get; set; }

        [JsonPropertyName("bottomRight")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double BottomRight { get; set; }
    }
}