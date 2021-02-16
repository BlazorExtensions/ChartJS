using System;
using System.Text.Json.Serialization;

namespace Blazor.Extensions.ChartJS
{
    public class BarDataset : IChartDataset<double[]>, IBarOptions, IBarHoverOptions
    {
        [JsonConverter(typeof(EnumToLowerCaseFirstLetterConverter<ChartType>))]
        [JsonPropertyName("type")]
        public ChartType ChartType { get; set; } = ChartType.Bar;

        [JsonPropertyName("data")]
        public double[] Data { get; set; } = Array.Empty<double>();

        [JsonPropertyName("clip")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public ChartArea Clip { get; set; } = default!;

        [JsonPropertyName("label")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Label { get; set; }

        [JsonPropertyName("order")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? Order { get; set; } = 0;

        [JsonPropertyName("stack")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Stack { get; set; }

        [JsonPropertyName("indexAxis")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonConverter(typeof(EnumToLowerCaseFirstLetterConverter<Axis>))]
        public Axis? IndexAxis { get; set; }

        [JsonPropertyName("xAxisId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? XAxisId { get; set; }

        [JsonPropertyName("yAxisId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? YAxisId { get; set; }

        [JsonPropertyName("barPercentage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? BarPercentage { get; set; } = 0.9;

        [JsonPropertyName("categoryPercentage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? CategoryPercentage { get; set; } = 0.8;

        [JsonPropertyName("barThickness")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? BarThickness { get; set; }

        [JsonPropertyName("maxBarThickness")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? MaxBarThickness { get; set; }

        [JsonPropertyName("minBarThickness")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? MinBarThickness { get; set; }

        [JsonPropertyName("minBarLength")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? MinBarLength { get; set; }

        [JsonPropertyName("pointStyle")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public PointStyle PointStyle { get; set; }

        [JsonPropertyName("hoverBorderRadius")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public BorderRadius? HoverBorderRadius { get; set; }

        [JsonPropertyName("hoverBorderWidth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? HoverBorderWidth { get; set; } = 1;

        [JsonPropertyName("hoverBorderColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object? HoverBorderColor { get; set; }

        [JsonPropertyName("hoverBackgroundColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object? HoverBackgroundColor { get; set; }

        [JsonPropertyName("base")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? Base { get; set; }

        [JsonPropertyName("borderSkipped")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonConverter(typeof(EnumToLowerCaseFirstLetterConverter<BorderSkipped>))]
        public BorderSkipped BorderSkipped { get; set; }

        [JsonPropertyName("borderRadius")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public BorderRadius? BorderRadius { get; set; }

        [JsonPropertyName("borderWidth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? BorderWidth { get; set; } = 0;

        [JsonPropertyName("borderColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object? BorderColor { get; set; } = "rgba(0, 0, 0, 0.1)";

        [JsonPropertyName("backgroundColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object? BackgroundColor { get; set; } = "rgba(0, 0, 0, 0.1)";
    }
}