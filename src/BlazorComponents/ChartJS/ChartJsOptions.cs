namespace BlazorComponents.ChartJS
{
    public class ChartJsOptions
    {
        /// <summary>
        /// Text will not be shown if the title is set.
        /// </summary>
        public string Text { get; set; } = "";

        /// <summary>
        /// Show or hide the chart
        /// </summary>
        public bool Display { get; set; } = true;
        public int BorderWidth { get; set; } = 1;
        /// <summary>
        /// Need to be true for resizing functions.
        /// </summary>
        public bool Responsive { get; set; } = true;

        /// <summary>
        /// Options for the axles
        /// </summary>
        public ChartJsScale Scales { get; set; }

        /// <summary>
        /// Plugin options. NOTE: This will be outsourced/refactored in future versions
        /// </summary>
        public ChartJsPlugins Plugins { get; set; }

        /// <summary>
        /// Layout options such as padding for the chart.
        /// </summary>
        public ChartJsLayout Layout { get; set; }

        /// <summary>
        /// Options for the chart legend.
        /// </summary>
        public ChartJsLegend Legend { get; set; }

        /// <summary>
        /// Sets the title and its options like font size.
        /// </summary>
        public ChartJsTitle Title { get; set; }
    }
}
