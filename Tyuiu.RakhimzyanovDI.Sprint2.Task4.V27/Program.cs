using Tyuiu.RakhimzyanovDI.Sprint2.Task4.V27.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint2.Task4.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double x = Convert.ToInt32(Console.ReadLine());
            double y = Convert.ToInt32(Console.ReadLine());
            double res = ds.Calculate(x, y);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
