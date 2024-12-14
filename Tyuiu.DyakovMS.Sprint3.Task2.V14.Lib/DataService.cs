using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DyakovMS.Sprint3.Task2.V14.Lib
{
    public class DataService : ISprint3Task2V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            int k = 1;
            do
            {
                MultiplySeries = MultiplySeries * (Math.Pow((double) value/k, 3));
                k++;
            } while (k <= 6);
            return Math.Round(MultiplySeries, 3);
        }
    }
}
