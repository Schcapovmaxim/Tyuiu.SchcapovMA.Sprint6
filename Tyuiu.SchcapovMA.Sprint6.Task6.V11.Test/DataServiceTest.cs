using Tyuiu.SchcapovMA.Sprint6.Task6.V11.Lib;
using System.IO;
namespace Tyuiu.SchcapovMA.Sprint6.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();

            string result = ds.CollectTextFromFile("C:\\Users\\Haier\\AppData\\Local\\Temp\\InPutDataFileTask6V11.txt");
            Assert.AreEqual("btwMCZUcB PADUsjhlu JmjQKHd TMRyztkPxzEVkcarVMlQ EUWCvEgL", result);
        }
    }
}