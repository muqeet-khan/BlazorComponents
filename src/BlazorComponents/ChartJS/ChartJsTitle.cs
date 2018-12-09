namespace BlazorComponents.ChartJS
{
    public class ChartJsTitle
    {
        /// <summary>
        /// Set true for displaying a title
        /// </summary>
        public bool Display { get; set; } = false;

        /// <summary>
        /// Sets the title
        /// </summary>
        public string Text { get; set; } = string.Empty;
        public int FontSize { get; set; } = 14;
        public string FontColor { get; set; } = "black";
    }
}
