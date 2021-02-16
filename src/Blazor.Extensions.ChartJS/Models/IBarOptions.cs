namespace Blazor.Extensions.ChartJS
{
    public interface IBarOptions : ICommonElementOptions
    {
        double? Base { get; set; }
        BorderSkipped BorderSkipped { get; set; }
        BorderRadius? BorderRadius { get; set; }
    }
}