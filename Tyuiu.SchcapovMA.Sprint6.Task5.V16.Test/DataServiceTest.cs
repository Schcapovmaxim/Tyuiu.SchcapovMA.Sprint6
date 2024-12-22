using Tyuiu.SchcapovMA.Sprint6.Task5.V16.Lib;
using System.IO;
namespace Tyuiu.SchcapovMA.Sprint6.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V16.txt");
            
            double[] wait =ds.LoadFromDataFile(path);
            double[] res = [12, 5, 12.89, 35, 13.83, 12.76, 8.86];
            CollectionAssert.AreEqual(res, wait);
        }
    }
}