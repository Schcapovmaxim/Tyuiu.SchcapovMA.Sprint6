﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SchcapovMA.Sprint6.Task1.V26.Lib
{
    public class DataService : ISprint6Task1V26
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
                try
                {
                    y = Math.Round((2 * Math.Cos(x)+2) / (2*x-1)+Math.Cos(x) - 5 * x + 3, 2);
                    valueArray[count] = y;
                    count++;
                }
                catch (DivideByZeroException ex)
                {
                    valueArray[count] = 0;
                    count++;
                }
            }
            return valueArray;
        }
    }
}
