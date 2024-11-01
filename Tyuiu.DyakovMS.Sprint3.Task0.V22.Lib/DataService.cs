using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DyakovMS.Sprint3.Task0.V22.Lib
{
    public class DataService : ISprint3Task0V22
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double MultiplySeries = 0;

            for (int k = startValue; k <= stopValue; k++)
            {
                MultiplySeries = MultiplySeries + ((Math.Pow(value, k) + 4) * Math.Cos(value));
            }
            return Math.Round(MultiplySeries, 3);
        }
    }
}
