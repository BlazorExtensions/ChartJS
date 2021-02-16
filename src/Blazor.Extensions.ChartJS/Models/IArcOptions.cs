namespace Blazor.Extensions.ChartJS
{
    public interface IArcOptions : ICommonElementOptions
    {
        BorderAlign BorderAlign { get; set; }
        double? Offset { get; set; }
    }
}