using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RakhimzyanovDI.Sprint2.Task4.V27.Lib
{
    public class DataService : ISprint2Task4V29
    {
        public double Calculate(double x, double y)
        {
            double z = (((x - 10) > (y + 2)) ? (x * (Math.Pow(((y + 2) / (x - 1)), 2))) : Math.Pow(y, 2) - (2 / x));
            return Math.Round(z, 3);
        }
    }
}
