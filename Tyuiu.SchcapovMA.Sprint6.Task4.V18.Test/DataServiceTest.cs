using System.IO;
using Tyuiu.SchcapovMA.Sprint6.Task4.V18.Lib;
namespace Tyuiu.SchcapovMA.Sprint6.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
       
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = -startValue + stopValue + 1;
            double[] valueWaitArray = new double[len];
            valueWaitArray[0] = 7.76;
            valueWaitArray[1] = 7.36;
            valueWaitArray[2] = 7.26;
            valueWaitArray[3] = 7.90;
            valueWaitArray[4] = 15.88;
            valueWaitArray[5] = 2.00;
            valueWaitArray[6] = 4.35;
            valueWaitArray[7] = 5.63;
            valueWaitArray[8] = 6.49;
            valueWaitArray[9] = 6.49;
            valueWaitArray[10] = 6.32;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, valueWaitArray);
        }
    }
}