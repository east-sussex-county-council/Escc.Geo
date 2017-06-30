using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escc.Geo
{
    /// <summary>
    /// A coordinate using the Ordnance Survey National Grid system, based on the Transverse Mercator projection
    /// </summary>
    public class OrdnanceSurveyCoordinate
    {
        /// <summary>
        /// Gets or sets the easting.
        /// </summary>
        /// <value>
        /// The easting.
        /// </value>
        public double Easting { get; set; }
        
        /// <summary>
        /// Gets or sets the northing.
        /// </summary>
        /// <value>
        /// The northing.
        /// </value>
        public double Northing { get; set; }

        /// <summary>
        /// Gets or sets the grid reference.
        /// </summary>
        /// <value>
        /// The grid reference.
        /// </value>
        public string GridReference { get; set; }
    }
}
