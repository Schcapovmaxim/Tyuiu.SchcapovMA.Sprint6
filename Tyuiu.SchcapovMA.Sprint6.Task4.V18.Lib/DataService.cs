using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SchcapovMA.Sprint6.Task4.V18.Lib
{
    public class DataService : ISprint6Task4V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = stopValue - startValue + 1;

            valueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {

                if ((x + Math.Cos(x)) == 0)
                {
                    valueArray[count] = 0;
                    count++;
                }
                else
                {
                    y = Math.Round(( (2 * x - 3)/(x + Math.Cos(x)) +5), 2);
                    valueArray[count] = y;
                    count++;
                }
            }
            return valueArray;
        }
    }
}
