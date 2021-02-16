using System.Text.Json.Serialization;

namespace Blazor.Extensions.ChartJS
{
    public class ChartConfiguration
    {
        [JsonConverter(typeof(EnumToLowerCaseFirstLetterConverter<ChartType>))]
        [JsonPropertyName("type")]
        public ChartType Type { get; set; }

        [JsonPropertyName("data")]
        public ChartData Data { get; set; } = default!;

        [JsonPropertyName("options")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object? Options { get; set; }
    }
}