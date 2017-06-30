using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Escc.Geo.Tests
{
    [TestFixture]
    class OrdnanceSurveyToLatitudeLongitudeConverterTests
    {
        [TestCase(547691, 121557, 50.974494922329455, 0.10229541336124326)]
        [TestCase(547297, 121339, 50.972636748932061, 0.096599216781432948)]
        public void ConvertEastingNorthingToLatitudeLongitude(double easting, double northing, double expectedLatitude, double expectedLongitude)
        {
            var converter = new OrdnanceSurveyToLatitudeLongitudeConverter();
            
            var latLong = converter.ConvertOrdnanceSurveyToLatitudeLongitude(easting, northing);

            Assert.AreEqual(expectedLatitude, latLong.Latitude);
            Assert.AreEqual(expectedLongitude, latLong.Longitude);
        }
    }
}
