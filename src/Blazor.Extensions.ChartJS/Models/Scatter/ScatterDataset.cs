using System.Text.Json.Serialization;

namespace Blazor.Extensions.ChartJS
{
    public class ScatterDataset : LineDatasetBase<ScatterDataPoint>
    {
        [JsonConverter(typeof(EnumToLowerCaseFirstLetterConverter<ChartType>))]
        [JsonPropertyName("type")]
        public override ChartType ChartType { get; set; } = ChartType.Scatter;

        [JsonPropertyName("showLine")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public override bool? ShowLine { get; set; } = false;
    }
}