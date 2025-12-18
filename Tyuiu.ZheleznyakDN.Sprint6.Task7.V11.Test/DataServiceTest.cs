using Tyuiu.ZheleznyakDN.Sprint6.Task7.V11.Lib;

namespace Tyuiu.ZheleznyakDN.Sprint6.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Дамир\source\repos\Tyuiu.ZheleznyakDN.Sprint6\InPutDataFileTask7V11.csv";
            int[,] wait = new int[,] {
                { 1, 4, 18, 17, 2, 13, 14, -14, 1, -18 },
                { -15, 18, 7, -3, -3, -6, -1, -17, 18, -18 },
                { 10, -15, 2, -2, -8, -16, 1, 3, -2, -13 },
                { -4, -7, 13, -7, -11, 11, 7, -20, -10, -16 },
                { 14, 9, 9, 20, 9, 0, 5, 1, -6, -17 }, 
                { 10, 12, -1, 8, 2, 3, 15, -17, 4, -4 },
                { -14, -15, 6, 1, -11, -9, 11, 13, 0, 13 },
                { -14, 16, -6, 5, 11, -1, -11, -6, 5, -7 },
                { 1, 4, 18, 17, 7, 13, 14, -14, 1, -18 },
                { -17, 17, -8, -20, 5, 12, 20, 13, -7, 15 }
            };
            int[,] result = ds.GetMatrix(path);
            CollectionAssert.AreEqual(wait, result);

        }
    }
}
