using Tyuiu.ZheleznyakDN.Sprint6.Task5.V16.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint6.Task5.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Temp\TestDataFile.txt";

            string[] testData = {
                "-17", "0", "12", "-14,32", "5",
                "-7,84", "12,89", "-1,57", "-3,64",
                "-13,26", "-8,91", "-17,77", "35",
                "-9", "13,83", "12,76", "8,86", "0",
                "-1,49", "-7"
            };

            File.WriteAllLines(path, testData);

            DataService ds = new DataService();
            double[] res = ds.LoadFromDataFile(path);

            // Ожидаемые положительные значения (округленные до 3 знаков)
            double[] wait = { 12, 5, 12.89, 35, 13.83, 12.76, 8.86 };

            // Удаляем временный файл
            File.Delete(path);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
