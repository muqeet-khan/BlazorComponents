using System.Collections.Generic;

namespace BlazorComponents.ChartJS
{
    public class ChartJsLineData
    {
        public List<string> Labels { get; set; } = new List<string>();
        public List<ChartJsLineDataset> Datasets { get; set; }
    }
}
