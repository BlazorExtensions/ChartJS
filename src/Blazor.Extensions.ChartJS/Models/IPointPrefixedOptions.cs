namespace Blazor.Extensions.ChartJS
{
    public interface IPointPrefixedOptions
    {
        object? PointBackgroundColor { get; set; }
        object? PointBorderColor { get; set; }
        double? PointBorderWidth { get; set; }
        double? PointHitRadius { get; set; }
        double? PointRadius { get; set; }
        double? PointRotation { get; set; }
        PointStyle PointStyle { get; set; }
    }
}