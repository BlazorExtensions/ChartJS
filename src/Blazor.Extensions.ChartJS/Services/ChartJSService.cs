using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Blazor.Extensions.ChartJS
{
    internal class ChartJSService : IChartJSService
    {
        private const string ChartJSScriptName = "./_content/Blazor.Extensions.ChartJS/BE.ChartJS.js";
        private const string CreateChartJSMethod = "createBEChart";
        private const string InitializeChartsJSMethod = "initializeChartJS";
        private const string ImportModuleJSMethod = "import";

        private IJSObjectReference _chartJSModule = default!;

        private readonly IJSRuntime _runtime;

        public ChartJSService(IJSRuntime runtime)
        {
            this._runtime = runtime;
        }

        public async Task<IChartReference> CreateChart(Guid chartId, ChartConfiguration chartConfiguration)
        {
            if (chartConfiguration == null)
            {
                throw new ArgumentNullException(nameof(chartConfiguration));
            }

            await this.EnsureModuleLoaded();

            var jsReference = await this._chartJSModule
                    .InvokeAsync<IJSObjectReference>(
                        CreateChartJSMethod,
                        chartId,
                        chartConfiguration
                    );

            return new ChartReference(chartId, jsReference);
        }

        private async ValueTask EnsureModuleLoaded()
        {
            this._chartJSModule = await _runtime.InvokeAsync<IJSObjectReference>(
                    ImportModuleJSMethod, ChartJSScriptName);

            await this._chartJSModule.InvokeVoidAsync(InitializeChartsJSMethod);
        }
    }
}