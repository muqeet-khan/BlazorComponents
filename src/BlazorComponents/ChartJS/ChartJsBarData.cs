using System.Collections.Generic;

namespace BlazorComponents.ChartJS
{
    public class ChartJsBarData
    {
        public List<string> Labels { get; set; } = new List<string>();
        public List<ChartJsBarDataset> Datasets { get; set; }
    }
}
