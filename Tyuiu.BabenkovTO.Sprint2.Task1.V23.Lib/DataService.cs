using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BabenkovTO.Sprint2.Task1.V23.Lib
{
    public class DataService : ISprint2Task1V23
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            // {False, False, False, True, True, True}
            // |, &, ||, &&, !, ^
            // a = 242, b = 571, c = 325, d = 155
            bool[] res = new bool[6];
            res[0] = (a > b) | (b / 2 == c);
            res[1] = (c < a) & (b > d);
            res[2] = (b <= c) || (d == a);
            res[3] = (c >= d) && (b / d != 5);
            res[4] = !(res[1]);
            res[5] = (res[0]) ^ (res[3] ^ res[1]);
            return res;
        }
    }
}
