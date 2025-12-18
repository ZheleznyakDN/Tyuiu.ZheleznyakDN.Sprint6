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
                    // Разделяем строку на слова
                    string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        // Проверяем, содержит ли слово букву 'I' (именно латинскую I)
                        if (ContainsLetterI(word))
                        {
                            result.Append(word).Append(" ");
                        }
                    }
                }
            }

            return result.ToString().Trim();
        }

        private bool ContainsLetterI(string word)
        {
            // Ищем именно латинскую букву I (большую или маленькую)
            // Игнорируем русскую 'и' и другие символы
            foreach (char c in word)
            {
                if (c == 'I' || c == 'i')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
