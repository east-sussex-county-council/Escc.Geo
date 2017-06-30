using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Escc.Geo.Tests
{
    [TestFixture]
    class LatitudeLongitudeToOrdnanceSurveyConverterTests
    {
        [TestCase(50.974494922329455, 0.10229541336124327, 547692, 121558)]
        [TestCase(50.972636748932068, 0.096599216781432962, 547298, 121340)]
        public void ConvertLatitudeLongitudeToEastingNorthing(double latitude, double longitude, double expectedEasting, double expectedNorthing)
        {
            var converter = new LatitudeLongitudeToOrdnanceSurveyConverter();
            
            var ordnanceSurvey = converter.ConvertLatitudeLongitudeToOrdnanceSurvey(latitude, longitude, 0);

            Assert.AreEqual(expectedEasting, ordnanceSurvey.Easting);
            Assert.AreEqual(expectedNorthing, ordnanceSurvey.Northing);
        }
    }
}
