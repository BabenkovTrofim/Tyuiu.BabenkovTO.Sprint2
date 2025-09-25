using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BabenkovTO.Sprint2.Task0.V17.Lib
{
    public class DataService : ISprint2Task0V17
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            // x = 1065
            // y = 755
            // ==, !=, <, >, <=, >=,
            bool[] result = new bool[6];
            result[0] = y + 310 == x;
            result[1] = x - 310 != y;
            result[2] = x < y;
            result[3] = y > x;
            result[4] = x * 2 <= y;
            result[5] = y / 3 >= x / 3;
            return result;
        }
    }
}
