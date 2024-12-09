using Tyuiu.SchcapovMA.Sprint6.Task0.V13.Lib;
namespace Tyuiu.SchcapovMA.Sprint6.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 3.375;
            Assert.AreEqual(res, wait);
            
        }
    }
}