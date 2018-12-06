using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponents.ChartJS
{
    /// <summary>
    /// Contains the minimum rquirements for a chart object.
    /// </summary>
    public interface IChart
    {

        string CanvasId { get; set; }

    }
}
