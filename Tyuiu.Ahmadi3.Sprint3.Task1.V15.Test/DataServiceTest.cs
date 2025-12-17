using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi3.Sprint3.Task3.V2.Lib;

namespace Tyuiu.Ahmadi3.Sprint3.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            // p = ∏[(x² + i) + 1] for i = 1 to 5, where x = 2
            // Manual calculation:
            // i=1: (4 + 1) + 1 = 6
            // i=2: (4 + 2) + 1 = 7
            // i=3: (4 + 3) + 1 = 8
            // i=4: (4 + 4) + 1 = 9
            // i=5: (4 + 5) + 1 = 10
            // Product: 6 * 7 * 8 * 9 * 10 = 30240

            double result = ds.GetMultiplySeries(2, 1, 5);  
            double wait = 30240;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetMultiplySeriesWithDifferentRange()
        {
            DataService ds = new DataService();

            // Test with different range: i = 2 to 4
            // i=2: (4 + 2) + 1 = 7
            // i=3: (4 + 3) + 1 = 8
            // i=4: (4 + 4) + 1 = 9
            // Product: 7 * 8 * 9 = 504

            double result = ds.GetMultiplySeries(2, 2, 4);
            double wait = 504;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetMultiplySeriesSingleValue()
        {
            DataService ds = new DataService();

            // Test with single value: i = 3 to 3
            // i=3: (4 + 3) + 1 = 8

            double result = ds.GetMultiplySeries(2, 3, 3);
            double wait = 8;
            Assert.AreEqual(wait, result);
        }
    }
}