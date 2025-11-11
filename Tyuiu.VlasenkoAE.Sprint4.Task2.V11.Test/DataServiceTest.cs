using Tyuiu.VlasenkoAE.Sprint4.Task2.V11.Lib;

namespace Tyuiu.VlasenkoAE.Sprint4.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 3, 6, 7, 4, 5, 8, 5, 8, 4, 3, 6, 5, 8, 4, 4 };

            int res = ds.Calculate(numsArray);
            int wait = 52;

            Assert.AreEqual(wait, res);
        }
    }
}
