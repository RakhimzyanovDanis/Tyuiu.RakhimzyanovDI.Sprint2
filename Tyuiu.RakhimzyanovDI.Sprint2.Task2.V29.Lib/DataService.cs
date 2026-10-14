using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RakhimzyanovDI.Sprint2.Task2.V29.Lib
{
    public class DataService : ISprint2Task2V29
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((y == 3 && ((x >= 3 && x <= 6) || (x >= 9 && x <= 12))) ||

        ((y == 4 || y == 5) &&
            (x >= 1 && x <= 12)) ||

        ((y == 6 || y == 7) &&
            (x >= 3 && x <= 13)) ||

        (y == 8 &&
            ((x == 6) || (x >= 10 && x <= 13))) ||

        ((y == 9 || y == 10) &&
            ((x == 6) || (x >= 10 && x <= 12))) ||

        (y == 11 &&
            ((x >= 3 && x <= 6) || (x >= 10 && x <= 12))) ||

        (y == 12 &&
            ((x >= 4 && x <= 5) || x == 10)))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;

        }
    }
}
