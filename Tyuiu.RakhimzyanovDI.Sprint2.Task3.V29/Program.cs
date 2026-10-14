using Tyuiu.RakhimzyanovDI.Sprint2.Task3.V29.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint2.Task3.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
