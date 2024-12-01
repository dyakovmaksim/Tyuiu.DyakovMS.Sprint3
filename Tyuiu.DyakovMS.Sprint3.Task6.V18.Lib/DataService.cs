using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DyakovMS.Sprint3.Task6.V18.Lib
{
    public class DataService : ISprint3Task6V18
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            for (int i = startValue; i <= stopValue; i++) 
            {
                for (int d = 1; d < 10; d++)
                {
                    if (i % d == 0)
                    {
                        sum += d;
                    }
                }
            }
            return sum;
        }
    }
}
