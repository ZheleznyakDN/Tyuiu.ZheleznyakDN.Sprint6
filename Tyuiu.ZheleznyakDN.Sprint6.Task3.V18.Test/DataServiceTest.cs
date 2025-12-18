using Tyuiu.ZheleznyakDN.Sprint6.Task3.V18.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint6.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                {-19, -19, 1, 18, 7},
                {5, 3, 4, 6, -12},
                {-15, 6, 2, 2, -14},
                {-9, -10, 15, 5, 6},
                {-13, -15, 9, 7, 1}
            };

            int[,] res = ds.Calculate(matrix);

            // Проверяем, что четвертая строка (индекс 3) изменена правильно
            Assert.AreEqual(-9, res[3, 0]);  // -9 (нечетное) → остается -9
            Assert.AreEqual(0, res[3, 1]);   // -10 (четное) → 0
            Assert.AreEqual(15, res[3, 2]);  // 15 (нечетное) → остается 15
            Assert.AreEqual(5, res[3, 3]);   // 5 (нечетное) → остается 5
            Assert.AreEqual(0, res[3, 4]);   // 6 (четное) → 0

            // Проверяем, что другие строки не изменились
            Assert.AreEqual(-19, res[0, 0]);
            Assert.AreEqual(5, res[1, 0]);
            Assert.AreEqual(-15, res[2, 0]);
            Assert.AreEqual(-13, res[4, 0]);
        }
    }
}
