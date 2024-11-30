using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DyakovMS.Sprint3.Task5.V13.Lib
{
    public class DataService : ISprint3Task5V13
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double SumSeries = 0;

            for (int j = startValue1; j <= stopValue1; j++) 
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    SumSeries = SumSeries + (Math.Cos(x) + k / 2);
                }
            }
            return Math.Round(SumSeries, 3);

        }
    }
}
