using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ZheleznyakDN.Sprint6.Task6.V5.Lib
{
    public class DataService : ISprint6Task6V5
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    foreach (string w in words)
                    {
                        // Поиск буквы 'I' (латинская i)
                        if (w.Contains("I", StringComparison.OrdinalIgnoreCase))
                        {
                            result += w + " ";
                        }
                    }
                }
            }

            return result.Trim();
        }
    }
}
