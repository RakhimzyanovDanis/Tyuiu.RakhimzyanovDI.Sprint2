using Tyuiu.RakhimzyanovDI.Sprint2.Task7.V2.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint2.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);
            if (res)
            {
                Console.WriteLine("Находиться");    
            }
            else
            {
                Console.WriteLine("НЕ находится");
            }

            Console.ReadLine();
        }
    }
}
