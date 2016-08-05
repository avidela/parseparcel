using NUnit.Framework;
using System.Collections.Generic;
using ParcelParser.Model;

namespace ParcelParser.UnitTest
{
    [TestFixture]
    public class ParserTests
    {
        [Test]
        [TestCase(30,20,10,20)]
        public void Build_returns_valid_parcel(int length,int height,int breadth,int weight)
        {
            var dimensions = new List<double> {length, height, breadth};
            var parcel = new Parcel(dimensions,weight);
            Assert.IsNotNull(parcel);
        }
    }
}
