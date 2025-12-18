using Tyuiu.ZheleznyakDN.Sprint6.Task2.V28.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint6.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            // Должно быть 11 значений: -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5
            Assert.AreEqual(11, res.Length);

            // Проверяем конкретные значения для диапазона [-5, 5]
            // F(-5) = (sin(-5) + 10)/(-15-1) + sin(-5) + 15 + 2
            Assert.AreEqual(22.51, res[0]);  // x = -5

            Assert.AreEqual(15.83, res[1]);  // x = -4
            Assert.AreEqual(10.95, res[2]);  // x = -3
            Assert.AreEqual(6.69, res[3]);   // x = -2
            Assert.AreEqual(4.71, res[4]);   // x = -1
            Assert.AreEqual(2.00, res[5]);   // x = 0
            Assert.AreEqual(-0.93, res[6]);  // x = 1
            Assert.AreEqual(-3.51, res[7]);  // x = 2
            Assert.AreEqual(-5.71, res[8]);  // x = 3
            Assert.AreEqual(-7.67, res[9]);  // x = 4
            Assert.AreEqual(-9.48, res[10]); // x = 5
        }
    }
}
