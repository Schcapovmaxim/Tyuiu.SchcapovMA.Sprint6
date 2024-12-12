using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SchcapovMA.Sprint6.Task3.V16.Lib
{
    public class DataService : ISprint6Task3V16
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            
            
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[2, j] % 2 == 0)
                    {
                        matrix[2, j] = 0;
                    }
                }
            
            return matrix;
        }
    }
}
