using System;

namespace Escc.Geo
{
    /// <summary>
    /// Make calculations based on latitude and longitude data
    /// </summary>
    public class DistanceCalculator
    {
        /// <summary>
        /// Calculates the distance in metres between two points expressed as latitudes and longitudes.
        /// </summary>
        /// <param name="from">Point to start from.</param>
        /// <param name="to">Point to end at.</param>
        /// <returns>
        /// Code from http://www.neowin.net/forum/topic/1026398-mathc-check-if-coord-is-inside-bounding-radius/
        /// </returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public double DistanceBetweenTwoPoints(LatitudeLongitude from, LatitudeLongitude to)
        {
            if (from == null) throw new ArgumentNullException("from");
            if (to == null) throw new ArgumentNullException("to");

            const double radiusOfEarth = 6371; 
            double fromLat = DegreesToRadians(from.Latitude - to.Latitude);
            double fromLong = DegreesToRadians(from.Longitude - to.Longitude);
            double toLat = DegreesToRadians(to.Latitude);
            double toLong = DegreesToRadians(from.Latitude);

            double a = Math.Sin(fromLat / 2) * Math.Sin(fromLat / 2) +
                    Math.Sin(fromLong / 2) * Math.Sin(fromLong / 2) * Math.Cos(toLat) * Math.Cos(toLong);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double d = radiusOfEarth * c;

            return d*1000;
        }

        private static double DegreesToRadians(double angle)
        {
            return (Math.PI/180)*angle;
        }
    }

}
