using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponents.ChartJS
{
    public class ChartJsBarChartOptions : ChartJsOptions
    {
        /// <summary>
        /// Percent (0-1) of the available width each bar should be within the category width. 1.0 will take the whole category width and put the bars right next to each other.
        /// Default value 0.9
        /// </summary>
        public double BarPercentage { get; set; } = 0.9;
        /// <summary>
        /// Percent(0-1) of the available width each category should be within the sample width.
        /// Default value 0.8
        /// </summary>
        public double CategoryPercentage { get; set; } = 0.8;
    }
}
