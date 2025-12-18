using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ZheleznyakDN.Sprint6.Task6.V5.Lib
{
    public class DataService : ISprint6Task6V5
    {
        public string CollectTextFromFile(string path)
        {
            StringBuilder result = new StringBuilder();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        // ВАЖНО: Возможно в условии опечатка!
                        // Нужно вывести слова, которые НЕ содержат букву 'I'
                        if (!word.Contains("I"))
                        {
                            result.Append(word).Append(" ");
                        }
                    }
                }
            }

            return result.ToString().Trim();
        }
    }
}
