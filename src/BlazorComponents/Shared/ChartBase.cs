using BlazorComponents.ChartJS;
using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponents.Shared
{
    public abstract class ChartBase : BlazorComponent
    {

        [Parameter]
        protected int Width { get; set; } = 200;

        [Parameter]
        protected int Height { get; set; } = 200;

        protected abstract IChart GetChart();

        /// <summary>
        /// Updates the size of the chart.
        /// </summary>
        /// <param name="newWidth"></param>
        /// <param name="newHeight"></param>
        public void UpdateSize(int newWidth, int newHeight)
        {
            ChartJSInterop.UpdateSize(GetChart().CanvasId, newWidth, newHeight);
        }

    }
}
