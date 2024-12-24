using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.SchcapovMA.Sprint6.Task7.V19.Lib
{
    public class DataService : ISprint6Task7V19
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int[,] matrix = new int[lines.Length, lines[0].Split(';').Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < values.Length; j++)
                {
                    if (i == 1)
                    {
                        if (Convert.ToInt32(values[j]) % 2 == 0)
                        {
                            matrix[i, j] = 2;
                        }
                        else
                        {
                            matrix[i, j] = Convert.ToInt32(values[j]);
                        }
                    }
                    else
                    {
                        matrix[i, j] = Convert.ToInt32(values[j]);
                    }
                }
            }
            return matrix;
        }
    }
}
