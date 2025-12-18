using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ZheleznyakDN.Sprint6.Task3.V18.Lib
{
    public class DataService : ISprint6Task3V18
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[,] resultMatrix = (int[,])matrix.Clone();

            // Четвертая строка имеет индекс 3 (если считать с 0)
            int fourthRowIndex = 3;

            // Проходим по всем элементам четвертой строки
            for (int j = 0; j < columns; j++)
            {
                // Если значение четное
                if (resultMatrix[fourthRowIndex, j] % 2 == 0)
                {
                    resultMatrix[fourthRowIndex, j] = 0;
                }
            }

            return resultMatrix;
        }
    }
}
