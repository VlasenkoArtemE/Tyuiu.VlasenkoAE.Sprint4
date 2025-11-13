using Tyuiu.VlasenkoAE.Sprint4.Task6.V18.Lib;

namespace Tyuiu.VlasenkoAE.Sprint4.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            var mas = new string[] { "Собака", "Кошка", "Кролик", "Хомяк", "Попугай", "Рыбка", "Черепаха" };

            string[] res = ds.Calculate(mas);
            string[] wait = ["Попугай", "Черепаха"];

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
