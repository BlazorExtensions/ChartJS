using System;
using System.Text.Json.Serialization;

namespace Blazor.Extensions.ChartJS
{
    public class DoughnutDataset : IChartDataset<double[]>, IArcOptions, IArcHoverOptions
    {
        [JsonConverter(typeof(EnumToLowerCaseFirstLetterConverter<ChartType>))]
        [JsonPropertyName("type")]
        public ChartType ChartType { get; set; } = ChartType.Doughnut;

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
        public int? Order { get; set; }

        [JsonPropertyName("stack")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Stack { get; set; }

        [JsonConverter(typeof(EnumToLowerCaseFirstLetterConverter<BorderAlign>))]
        [JsonPropertyName("borderAlign")]
        public BorderAlign BorderAlign { get; set; }

        [JsonPropertyName("offset")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? Offset { get; set; }

        [JsonPropertyName("borderWidth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? BorderWidth { get; set; } = 2;

        [JsonPropertyName("borderColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object? BorderColor { get; set; }

        [JsonPropertyName("backgroundColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object? BackgroundColor { get; set; } = "rgba(0, 0, 0, 0.1)";

        [JsonPropertyName("hoverOffset")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? HoverOffset { get; set; }

        [JsonPropertyName("hoverBorderWidth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? HoverBorderWidth { get; set; }

        [JsonPropertyName("hoverBorderColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object? HoverBorderColor { get; set; }

        [JsonPropertyName("hoverBackgroundColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object? HoverBackgroundColor { get; set; }

        [JsonPropertyName("cutoutPercentage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double CutOutPercentage { get; set; } = 50;

        [JsonPropertyName("circumference")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double Circumference { get; set; } = 360;

        [JsonPropertyName("rotation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double Rotation { get; set; } = 0;

        [JsonPropertyName("weight")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double Weight { get; set; } = 1;
    }
}