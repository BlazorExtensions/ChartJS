using System;
using System.Text.Json.Serialization;

namespace Blazor.Extensions.ChartJS
{
    public class RadarDataset :
        IChartDataset<double[]>,
        IPointPrefixedOptions,
        IPointPrefixedHoverOptions,
        ILineOptions,
        ILineHoverOptions
    {
        [JsonConverter(typeof(EnumToLowerCaseFirstLetterConverter<ChartType>))]
        [JsonPropertyName("type")]
        public ChartType ChartType { get; set; } = ChartType.Radar;

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

        [JsonPropertyName("xAxisId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? XAxisId { get; set; }

        [JsonPropertyName("yAxisId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? YAxisId { get; set; }

        [JsonPropertyName("spanGaps")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool? SpanGaps { get; set; }

        [JsonPropertyName("showLine")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public virtual bool? ShowLine { get; set; } = true;

        [JsonPropertyName("hoverBorderCapStyle")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonConverter(typeof(EnumToLowerCaseFirstLetterConverter<CanvasLineCap>))]
        public CanvasLineCap HoverBorderCapStyle { get; set; }

        [JsonPropertyName("hoverBorderDash")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double[] HoverBorderDash { get; set; } = default!;

        [JsonPropertyName("hoverBorderDashOffset")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? HoverBorderDashOffset { get; set; }

        [JsonPropertyName("hoverBorderJoinStyle")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonConverter(typeof(EnumToLowerCaseFirstLetterConverter<CanvasLineJoin>))]
        public CanvasLineJoin HoverBorderJoinStyle { get; set; }

        [JsonPropertyName("hoverBorderWidth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? HoverBorderWidth { get; set; }

        [JsonPropertyName("hoverBorderColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object? HoverBorderColor { get; set; }

        [JsonPropertyName("hoverBackgroundColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object? HoverBackgroundColor { get; set; }

        [JsonPropertyName("borderCapStyle")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonConverter(typeof(EnumToLowerCaseFirstLetterConverter<CanvasLineCap>))]
        public CanvasLineCap BorderCapStyle { get; set; }

        [JsonPropertyName("borderDash")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double[] BorderDash { get; set; } = Array.Empty<double>();

        [JsonPropertyName("borderDashOffset")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? BorderDashOffset { get; set; } = 0;

        [JsonPropertyName("borderJoinStyle")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonConverter(typeof(EnumToLowerCaseFirstLetterConverter<CanvasLineJoin>))]
        public CanvasLineJoin BorderJoinStyle { get; set; } = CanvasLineJoin.Miter;

        [JsonPropertyName("capBezierPoints")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool? CapBezierPoints { get; set; }

        [JsonPropertyName("cubicInterpolationMode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonConverter(typeof(EnumToLowerCaseFirstLetterConverter<CubicInterpolationMode>))]
        public CubicInterpolationMode CubicInterpolationMode { get; set; }

        [JsonPropertyName("tension")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? Tension { get; set; } = 0;

        [JsonPropertyName("stepped")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool? Stepped { get; set; }

        [JsonPropertyName("borderWidth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? BorderWidth { get; set; } = 3;

        [JsonPropertyName("borderColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object? BorderColor { get; set; } = "rgba(0, 0, 0, 0.1)";

        [JsonPropertyName("backgroundColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object? BackgroundColor { get; set; } = "rgba(0, 0, 0, 0.1)";

        [JsonPropertyName("pointHoverBackgroundColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object? PointHoverBackgroundColor { get; set; }

        [JsonPropertyName("pointHoverBorderColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object? PointHoverBorderColor { get; set; }

        [JsonPropertyName("pointHoverBorderWidth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? PointHoverBorderWidth { get; set; } = 1;

        [JsonPropertyName("pointHoverRadius")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? PointHoverRadius { get; set; } = 4;

        [JsonPropertyName("pointBackgroundColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object? PointBackgroundColor { get; set; } = "rgba(0, 0, 0, 0.1)";

        [JsonPropertyName("pointBorderColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object? PointBorderColor { get; set; } = "rgba(0, 0, 0, 0.1)";

        [JsonPropertyName("pointBorderWidth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? PointBorderWidth { get; set; } = 1;

        [JsonPropertyName("pointHitRadius")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? PointHitRadius { get; set; } = 1;

        [JsonPropertyName("pointRadius")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? PointRadius { get; set; } = 3;

        [JsonPropertyName("pointRotation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double? PointRotation { get; set; } = 0;

        [JsonPropertyName("pointStyle")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonConverter(typeof(EnumToLowerCaseFirstLetterConverter<PointStyle>))]
        public PointStyle PointStyle { get; set; }
    }
}