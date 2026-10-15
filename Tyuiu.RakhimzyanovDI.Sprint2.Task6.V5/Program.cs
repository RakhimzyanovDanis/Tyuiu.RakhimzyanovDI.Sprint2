using Tyuiu.RakhimzyanovDI.Sprint2.Task6.V5.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint2.Task6.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int numCard = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numCard < 5) || (numCard > 15))
            {
                res = "Неверно";
            }
            else
            {
                res = "звание карты " + ds.FindCardValue(numCard);
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
