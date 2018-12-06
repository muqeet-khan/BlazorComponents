namespace BlazorComponents.ChartJS
{
    public class ChartJsOptions
    {
        public string Text { get; set; } = "";
        public bool Display { get; set; } = false;
        public int BorderWidth { get; set; } = 1;
        /// <summary>
        /// Need to be true for resizing functions.
        /// </summary>
        public bool Responsive { get; set; } = true;
        public ChartJsScale Scales { get; set; }
        public ChartJsPlugins Plugins { get; set; }
        public ChartJsLayout Layout { get; set; }
        public ChartJsLegend Legend { get; set; }
        public ChartJsTitle Title { get; set; }
    }
}
