using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Escc.Geo.Tests
{
    [TestFixture]
    public class DistanceCalculatorTests
    {
        [TestCase(new double[] { 50.972637, 0.096587613 }, new double[] { 50.974495, 0.10228381 }, 449.16581972864759)]
        public void DistanceBetweenTwoPointsCalculated(double[] from, double[] to, double expectedDistance)
        {
            var calc = new DistanceCalculator();
            double dist = calc.DistanceBetweenTwoPoints(new LatitudeLongitude(from[0], from[1]), new LatitudeLongitude(to[0], to[1]));

            Assert.AreEqual(expectedDistance, dist);
        }
    }
}
