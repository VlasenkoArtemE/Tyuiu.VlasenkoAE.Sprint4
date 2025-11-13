using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VlasenkoAE.Sprint4.Task6.V18.Lib
{
    public class DataService : ISprint4Task6V18
    {
        public string[] Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, mas => mas.Length > 6);
            return res;
        }
    }
}
