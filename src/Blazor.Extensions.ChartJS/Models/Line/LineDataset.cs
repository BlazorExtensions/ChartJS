using System.Text.Json.Serialization;

namespace Blazor.Extensions.ChartJS
{
    public class LineDataset : LineDatasetBase<double>
    {
        [JsonConverter(typeof(EnumToLowerCaseFirstLetterConverter<ChartType>))]
        [JsonPropertyName("type")]
        public override ChartType ChartType { get; set; } = ChartType.Line;
    }
}