using System.Collections.Generic;

namespace BlazorComponents.ChartJS
{
    public class ChartJsPieData
    {
        public List<string> Labels { get; set; } = new List<string>();
        public List<ChartJsPieDataset> Datasets { get; set; }
    }
}
