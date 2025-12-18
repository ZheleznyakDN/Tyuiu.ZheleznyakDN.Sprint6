using Tyuiu.ZheleznyakDN.Sprint6.Task4.V30.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint6.Task4.V30.Test
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

            Assert.IsNotNull(res);
            Assert.AreEqual(11, res.Length);
        }
    }
}
