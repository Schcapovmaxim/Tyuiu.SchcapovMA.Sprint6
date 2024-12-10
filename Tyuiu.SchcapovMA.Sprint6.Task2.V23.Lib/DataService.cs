using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SchcapovMA.Sprint6.Task2.V23.Lib
{
    public class DataService : ISprint6Task2V23
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

                if ((2 * x - 2)==0)
                {
                    valueArray[count] = 0;
                    count++;
                }
                else
                {
                    y = Math.Round((2 + Math.Cos(x)) / (2 * x - 2) - 2 * x + 4, 2);
                    valueArray[count] = y;
                    count++;
                }
            }
            return valueArray;
        }
    }
}
