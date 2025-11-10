using Tyuiu.VlasenkoAE.Sprint4.Task0.V12.Lib;

namespace Tyuiu.VlasenkoAE.Sprint4.Task0.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            int res = ds.GetMultEvenArrEl(numsArray);
            int numsWaitArray = 73728;
            Assert.AreEqual(numsWaitArray, res);

        }
    }
}
