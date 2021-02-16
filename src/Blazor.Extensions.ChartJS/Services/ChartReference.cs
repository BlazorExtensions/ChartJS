using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Blazor.Extensions.ChartJS
{
    internal class ChartReference : IChartReference
    {
        private const string DestroyChartJSMethod = "destroy";
        private readonly IJSObjectReference _jsReference;

        public Guid ChartId { get; private set; }

        public ChartReference(Guid id, IJSObjectReference jsReference)
        {
            this.ChartId = id;
            this._jsReference = jsReference;
        }

        public async ValueTask DisposeAsync()
        {
            try
            {
                await this._jsReference.InvokeVoidAsync(DestroyChartJSMethod);
                await this._jsReference.DisposeAsync();
            }
            catch (TaskCanceledException)
            {
                // The browser refresh and SignalR connection was broken.
            }
        }
    }
}