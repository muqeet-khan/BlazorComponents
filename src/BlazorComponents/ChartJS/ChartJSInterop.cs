using Microsoft.AspNetCore.Blazor;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorComponents.ChartJS
{
    public class ChartJSInterop
    {
        public static Task<bool> InitializeLineChart(ChartJSLineChart lineChart)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorComponents.ChartJSInterop.InitializeLineChart", new[] { lineChart });
        }

        public static Task<bool> UpdateSize(string canvasId, int newWidth, int newHeight)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorComponents.ChartJSInterop.UpdateSize", new object[] { canvasId, newWidth, newHeight });
        }

        public static Task<bool> InitializeBarChart(ChartJSBarChart barChart)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorComponents.ChartJSInterop.InitializeBarChart", new[] { barChart });
        }

        public static Task<bool> UpdateLineChart(ChartJSLineChart lineChart)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorComponents.ChartJSInterop.UpdateLineChart", new[] { lineChart });
        }

        public static Task<bool> UpdateBarChart(ChartJSBarChart barChart)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorComponents.ChartJSInterop.UpdateBarChart", new[] { barChart });
        }

        public static Task<bool> InitializeRadarChart(ChartJSRadarChart radarChart)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorComponents.ChartJSInterop.InitializeRadarChart", new[] { radarChart });
        }

        public static Task<bool> UpdateRadarChart(ChartJSRadarChart radarChart)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorComponents.ChartJSInterop.UpdateRadarChart", new[] { radarChart });
        }

        public static Task<bool> InitializePieChart(ChartJSPieChart pieChart)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorComponents.ChartJSInterop.InitializePieChart", new[] { pieChart });
        }

        public static Task<bool> UpdatePieChart(ChartJSPieChart pieChart)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorComponents.ChartJSInterop.UpdatePieChart", new[] { pieChart });
        }
        public static Task<IEnumerable<ChartJsEventResult>> GetElementsAtEvent(string canvasId, UIMouseEventArgs evt)
        {
            return JSRuntime.Current.InvokeAsync<IEnumerable<ChartJsEventResult>>("BlazorComponents.ChartJSInterop.GetElementsAtEvent", new object[] { canvasId,evt});
        }

    }
}
