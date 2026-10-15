using Tyuiu.RakhimzyanovDI.Sprint2.Task5.V3.Lib;


namespace Tyuiu.RakhimzyanovDI.Sprint2.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int numDay = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numDay < 1) || (numDay > 7))
            {
                res = "Неверно";
            }
            else
            {
                res = "День недели " + ds.FindDayName(numDay);
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
