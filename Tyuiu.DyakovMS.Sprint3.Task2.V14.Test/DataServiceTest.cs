using Tyuiu.DyakovMS.Sprint3.Task2.V14.Lib;

namespace Tyuiu.DyakovMS.Sprint3.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeriesTest()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 6;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 0;

            Assert.AreEqual(wait, res);
        }
    }
}