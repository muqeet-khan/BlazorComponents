namespace BlazorComponents.ChartJS
{
    public class ChartJsDataLabels
    {
        public bool Display { get; set; } = false;
        public string Color { get; set; } = "white";
        public string Align { get; set; } = "start";
        public string Anchor { get; set; } = "start";
        public ChartJsDataLabelsFont Font { get; set; } = new ChartJsDataLabelsFont();
    }
}
