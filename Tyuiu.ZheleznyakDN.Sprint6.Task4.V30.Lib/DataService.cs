using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ZheleznyakDN.Sprint6.Task4.V30.Lib
{
    public class DataService : ISprint6Task4V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] values = new double[length];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                double denominator = Math.Sin(x) + 2;

                if (Math.Abs(denominator) < 0.0001)
                {
                    y = 0;
                }
                else
                {
                    y = (5 * x + 2.5) / denominator + 2 * x + 2;
                }

                values[index] = Math.Round(y, 2);
                index++;
            }

            return values;
        }
    }
}
