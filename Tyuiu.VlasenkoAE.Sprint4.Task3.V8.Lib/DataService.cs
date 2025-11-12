using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VlasenkoAE.Sprint4.Task3.V8.Lib
{
    public class DataService : ISprint4Task3V8
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;   // количество строк
            int columns = array.Length / rows;       // количество столбцов

            int min = 8;

            for (int i = 0; i < rows; i++)
            {
                int j = 3;

                if (array[i, j] < min)
                {
                    min = array[i, j];
                }

            }
            return min;
        }
    }
}
