using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace Blazor.Extensions.ChartJS
{
    public class ChartComponent : ComponentBase, IAsyncDisposable
    {
        protected readonly Guid _chartId;

        [Inject] private ILogger<ChartComponent> Logger { get; set; } = default!;
        [Inject] public IChartJSService ChartJSService { get; set; } = default!;

        [Parameter] public ChartConfiguration Configuration { get; set; } = default!;

        private IChartReference _chart = default!;

        public ChartComponent()
        {
            this._chartId = Guid.NewGuid();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                if (this.Configuration == null)
                {
                    this.Logger.LogWarning($"The ChartConfiguration is required. The Chart '{this._chartId}' will not be rendered.");
                    return;
                }

                this._chart = await this.ChartJSService
                    .CreateChart(this._chartId, this.Configuration);
            }
        }

        public ValueTask DisposeAsync()
        {
            if (this._chart != null)
            {
                return this._chart.DisposeAsync();
            }

            return ValueTask.CompletedTask;
        }
    }
}