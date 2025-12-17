using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Ahmadi3.Sprint3.Task3.V2.Lib
{
    public class DataService :ISprint3Task1V15
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double product = 1;
            int i = startValue;

            while (i <= stopValue)
            {
                product *= (value * value + i) + 1;
                i++;  
            }

            return product;
        }
    }
}