using Tyuiu.VlasenkoAE.Sprint4.Task4.V20.Lib;

namespace Tyuiu.VlasenkoAE.Sprint4.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]{ { 4, 5, 5, 6, 4 },
                                         { 7, 8, 4, 7, 5 },
                                         { 5, 6, 5, 8, 5 },
                                         { 7, 5, 8, 7, 8 },
                                         { 4, 7, 7, 8, 8 }, };
            
            int[,] res = ds.Calculate(matrix);
            
            int[,] wait = { { 1, 5, 5, 1, 1 },
                            { 7, 1, 1, 7, 5 },
                            { 5, 1, 5, 1, 5 },
                            { 7, 5, 1, 7, 1 },
                            { 1, 7, 7, 1, 1 }, };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
