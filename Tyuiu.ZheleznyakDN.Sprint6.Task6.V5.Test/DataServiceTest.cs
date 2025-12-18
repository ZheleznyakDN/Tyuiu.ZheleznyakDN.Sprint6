using Tyuiu.ZheleznyakDN.Sprint6.Task6.V5.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint6.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // Создаем временный файл с тестовыми данными
            string path = @"C:\Temp\TestFileTask6V5.txt";

            string[] testData = {
                "UPPfdzU ulzPXa UpGwjzkBH xvfsWpk",
                "BYiySs S OHcr NsMnNzS Y KgepHrKCHa",
                "BXGdYDF brIBPtX vatYxkk gLertvwzs",
                "KyiidnDo FVUh XNQBU sMLuPzlvneiTo",
                "XIpph QN hZznJL bWk Rz tfouGdncXlJ"
            };

            File.WriteAllLines(path, testData);

            string result = ds.CollectTextFromFile(path);

            // В файле слова с заглавной 'I':
            // 1. brIBPtX (строка 3) - содержит 'I'
            // 2. XIpph (строка 5) - содержит 'I'

            // Слова со строчной 'i' НЕ включаются:
            // BYiySs - содержит 'i' (строчную), но не 'I' (заглавную)
            // KyiidnDo - содержит 'i' (строчную), но не 'I'
            // sMLuPzlvneiTo - содержит 'i' (строчную), но не 'I'

            string expected = "brIBPtX XIpph";

            File.Delete(path);

            Assert.AreEqual(expected, result,
                $"Ожидалось: '{expected}'\nПолучено: '{result}'");
        }
    }
}
