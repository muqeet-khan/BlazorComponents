namespace BlazorComponents.ChartJS
{
    public class ChartJsDataLabels
    {
        /// <summary>
        /// Should be displayed or not (the data label)
        /// </summary>
        public bool Display { get; set; } = false;

        /// <summary>
        /// Text Color of the data labels
        /// </summary>
        public string Color { get; set; } = "white";

        /// <summary>
        /// Position of the data label (end means above the bar chart for example).
        /// </summary>
        public string Align { get; set; } = "start";

        public string Anchor { get; set; } = "start";

        /// <summary>
        /// Font of the data label text
        /// </summary>
        public ChartJsDataLabelsFont Font { get; set; } = new ChartJsDataLabelsFont();
    }
}
