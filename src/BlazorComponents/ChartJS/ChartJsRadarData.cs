using System.Collections.Generic;

namespace BlazorComponents.ChartJS
{
    public class ChartJsRadarData
    {
        public List<string> Labels { get; set; } = new List<string>();
        public List<ChartJSRadarDataset> Datasets { get; set; }
    }
}
