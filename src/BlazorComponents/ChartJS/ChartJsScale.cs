using System.Collections.Generic;

namespace BlazorComponents.ChartJS
{
    public class ChartJsScale
    {
        /// <summary>
        ///  Options for the X axis.
        /// </summary>
        public List<ChartJsXAxes> XAxes { get; set; }

        /// <summary>
        /// Options for the Y axis.
        /// </summary>
        public List<ChartJsYAxes> YAxes { get; set; }
    }
}
