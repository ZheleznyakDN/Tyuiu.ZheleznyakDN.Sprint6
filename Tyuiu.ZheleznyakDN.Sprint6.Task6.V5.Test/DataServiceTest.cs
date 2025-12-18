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

            // Создаем временный файл с тестовыми данными ИЗ ВАШЕГО ФАЙЛА
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

            // Ожидаемый результат согласно изображению
            string expected = "ulzPXa sMLuPzlvneiTo tfouGdncXlJ";

            // Альтернативный ожидаемый результат, если нужно найти ВСЕ слова с 'I'
            // string expected = "BYiySs brIBPtX KyiidnDo sMLuPzlvneiTo XIpph";

            // Удаляем временный файл
            File.Delete(path);

            Assert.AreEqual(expected, result,
                $"Ожидалось: '{expected}'\nПолучено: '{result}'");
        }
    }
}
