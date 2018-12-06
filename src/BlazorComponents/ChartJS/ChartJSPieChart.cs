using System;

namespace BlazorComponents.ChartJS
{
    public class ChartJSPieChart : IChart
    {
        public string ChartType { get; set; } = "pie";
        public ChartJsPieData Data { get; set; }
        public ChartJsOptions Options { get; set; }
        public string CanvasId { get; set; } = $"BlazorChartJS_{new Random().Next(0, 1000000).ToString()}";
    }
}
