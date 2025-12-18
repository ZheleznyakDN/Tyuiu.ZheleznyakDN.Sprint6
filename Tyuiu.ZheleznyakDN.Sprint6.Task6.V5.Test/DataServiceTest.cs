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

            // Слова из файла, которые содержат 'l' или 'i':
            // ulzPXa - содержит 'l'? НЕТ
            // sMLuPzlvneiTo - содержит 'l'? ДА, и 'i'? ДА
            // tfouGdncXlJ - содержит 'l'? ДА

            // Но тест ожидает: "ulzPXa sMLuPzlvneiTo tfouGdncXlJ"
            // ulzPXa не содержит ни 'l' ни 'i'!

            // Возможно, в файле опечатка и там должно быть другое слово
            // Или условие другое

            string expected = "ulzPXa sMLuPzlvneiTo tfouGdncXlJ";

            File.Delete(path);

            Assert.AreEqual(expected, result,
                $"Ожидалось: '{expected}'\nПолучено: '{result}'");
        }
    }
}
