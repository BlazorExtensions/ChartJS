using System.Text.Json.Serialization;

namespace Blazor.Extensions.ChartJS
{
    public interface ICoreScaleOptions
    {
        [JsonPropertyName("display")]
        bool Display { get; set; }

        [JsonPropertyName("reverse")]
        bool Reverse { get; set; }

        [JsonPropertyName("weight")]
        bool Weight { get; set; }
    }
}