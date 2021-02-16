namespace Blazor.Extensions.ChartJS
{
    public interface ILineOptions : ICommonElementOptions
    {
        CanvasLineCap BorderCapStyle { get; set; }
        double[] BorderDash { get; set; }
        double? BorderDashOffset { get; set; }
        CanvasLineJoin BorderJoinStyle { get; set; }
        bool? CapBezierPoints { get; set; }
        CubicInterpolationMode CubicInterpolationMode { get; set; }
        double? Tension { get; set; }
        bool? Stepped { get; set; }
    }
}