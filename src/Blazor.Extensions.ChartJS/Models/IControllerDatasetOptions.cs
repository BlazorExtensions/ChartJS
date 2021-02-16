namespace Blazor.Extensions.ChartJS
{
    public interface IControllerDatasetOptions : IParsingOptions
    {
        ChartArea Clip { get; set; }
        string? Label { get; set; }
        int? Order { get; set; }
        string? Stack { get; set; }
    }
}