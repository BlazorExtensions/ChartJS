namespace Blazor.Extensions.ChartJS
{
    public interface ILineHoverOptions : ICommonHoverOptions
    {
        CanvasLineCap HoverBorderCapStyle { get; set; }
        double[] HoverBorderDash { get; set; }
        double? HoverBorderDashOffset { get; set; }
        CanvasLineJoin HoverBorderJoinStyle { get; set; }
    }
}