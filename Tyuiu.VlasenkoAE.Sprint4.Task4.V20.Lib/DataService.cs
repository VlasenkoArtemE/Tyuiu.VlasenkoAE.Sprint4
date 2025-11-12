using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VlasenkoAE.Sprint4.Task4.V20.Lib
{
    public class DataService : ISprint4Task4V20
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;   // количество строк
            int columns = matrix.Length / rows;       // количество столбцов

            int[,] res = (int[,])matrix.Clone();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        res[i, j] = 1;
                    }
                }
            }
            return res;
        }
    }
}
