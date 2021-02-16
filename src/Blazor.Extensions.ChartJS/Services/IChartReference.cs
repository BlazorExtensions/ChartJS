using System;

namespace Blazor.Extensions.ChartJS
{
    public interface IChartReference : IAsyncDisposable
    {
        Guid ChartId { get; }
    }
}