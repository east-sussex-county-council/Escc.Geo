namespace Escc.Geo
{
    /// <summary>
    /// A point expressed as a WGS84 latitude and longitude
    /// </summary>
    public class LatitudeLongitude
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LatitudeLongitude"/> class.
        /// </summary>
        public LatitudeLongitude()
        {
            Latitude = 0;
            Longitude = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LatitudeLongitude"/> class.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        public LatitudeLongitude(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}