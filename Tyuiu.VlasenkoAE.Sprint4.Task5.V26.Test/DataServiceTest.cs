using Tyuiu.VlasenkoAE.Sprint4.Task5.V26.Lib;

namespace Tyuiu.VlasenkoAE.Sprint4.Task5.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]{ { -4, 2, 1, 0, -3 },
                                           { 0, 1, 2, 3, 4 },
                                           { -3, -2, 0, -1, 1 },
                                           { -4, 3, 2, -1, 0 },
                                           { -1, 3, 4, 2, -3 }, };

            int[,] res = ds.Calculate(matrix);

            int[,] wait = { { -4, 1, 1, 0, -3 },
                            { 0, 1, 1, 1, 1 },
                            { -3, -2, 0, -1, 1 },
                            { -4, 1, 1, -1, 0 },
                            { -1, 1, 1, 1, -3 }, };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
