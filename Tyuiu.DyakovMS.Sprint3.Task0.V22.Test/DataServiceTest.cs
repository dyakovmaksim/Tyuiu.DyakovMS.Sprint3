using Tyuiu.DyakovMS.Sprint3.Task0.V22.Lib;

namespace Tyuiu.DyakovMS.Sprint3.Task0.V22.Test
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
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 19.701;

            Assert.AreEqual(wait, res);
        }
    }
}