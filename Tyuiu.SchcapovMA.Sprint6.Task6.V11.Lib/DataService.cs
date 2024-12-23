using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Tyuiu.SchcapovMA.Sprint6.Task6.V11.Lib
{
    public class DataService : ISprint6Task6V11
    {
        public string CollectTextFromFile(string path)
        {
            string resStr="";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                
                while ((line = reader.ReadLine()) != null) 
                {
                    string[] res = line.Split(" ");
                    int len = 0;
                    foreach (string item in res)
                    {

                        len++;

                    }
                    int cnt = 0;
                    foreach (string item in res)
                    {
                        
                        if (cnt == (len-2))
                        {
                            resStr += " "+item;
                        }
                        cnt++;

                    }
                }
                
            }
            return resStr.Remove(0, 1);
        }
        
    }
}
