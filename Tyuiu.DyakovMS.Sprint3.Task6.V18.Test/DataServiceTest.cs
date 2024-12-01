using Tyuiu.DyakovMS.Sprint3.Task6.V18.Lib;

namespace Tyuiu.DyakovMS.Sprint3.Task6.V18.Test
{
    public class DataServiceTest
    {
        public void TestGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 9;
            int stopValue = 18;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 105;

            Assert.AreEqual(wait, res);
        }
    }
}