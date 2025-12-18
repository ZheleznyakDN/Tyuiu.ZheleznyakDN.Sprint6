using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ZheleznyakDN.Sprint6.Task2.V28.Lib
{
    public class DataService : ISprint6Task2V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                // Проверка деления на ноль: если знаменатель (3x - 1) = 0
                if ((3 * x - 1) == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    // Вычисляем F(x) = (sin(x) - 2x) / (3x - 1) + sin(x) - 3x + 2
                    double numerator = Math.Sin(x) - (2 * x);
                    double denominator = (3 * x) - 1;
                    double result = (numerator / denominator) + Math.Sin(x) - (3 * x) + 2;
                    valueArray[count] = Math.Round(result, 2);
                }
                count++;
            }
            return valueArray;
        }
    }
}
