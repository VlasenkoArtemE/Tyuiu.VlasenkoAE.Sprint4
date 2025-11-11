using Tyuiu.VlasenkoAE.Sprint4.Task1.V8.Lib;

namespace Tyuiu.VlasenkoAE.Sprint4.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numArray = { 8, 4, 7, 7, 3, 8, 8, 5, 8, 7, 2, 4 };

            int res = ds.Calculate(numArray);
            int wait = 29;

            Assert.AreEqual(wait, res);
        }
    }
}
