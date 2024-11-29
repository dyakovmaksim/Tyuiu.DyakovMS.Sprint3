using Tyuiu.DyakovMS.Sprint3.Task1.V29.Lib;

namespace Tyuiu.DyakovMS.Sprint3.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeriesTest()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 11;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 77624971702.813;

            Assert.AreEqual(wait, res);
        }
    }
}