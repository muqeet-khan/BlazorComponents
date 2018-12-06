using System;

namespace BlazorComponents.ChartJS
{
    public class ChartJSBarChart : IChart
    {
        public string ChartType { get; set; } = "bar";
        public ChartJsBarData Data { get; set; }
        public ChartJsOptions Options { get; set; }
        public string CanvasId { get; set; } = $"BlazorChartJS_{new Random().Next(0, 1000000).ToString()}";
    }
}
