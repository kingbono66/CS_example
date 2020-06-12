using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace cs_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 3;
            WriteLine(a);
            a++;
            WriteLine(a);
            a--;
            WriteLine(a);
            WriteLine(++a);
            WriteLine(a++);
            WriteLine(a);
            */

            #region 관계연산자
            //WriteLine($"3 > 4 : {3 > 4}");
            //WriteLine($"3 < 4 : {3 < 4}");
            //WriteLine($"3 >= 4 : {3 >= 4}");
            //WriteLine($"3 <= 4 : {3 <= 4}");
            //WriteLine($"3 == 4 : {3 == 4}");
            //WriteLine($"3 != 4 : {3 != 4}");
            #endregion
            #region 관계논리연산자
            //WriteLine($"&&");
            //WriteLine($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}");
            //WriteLine($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}");
            //WriteLine($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}");
            //WriteLine($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}");

            //WriteLine($"||");
            //WriteLine($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}");
            //WriteLine($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}");
            //WriteLine($"1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}");
            //WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}");

            #endregion
            int a = 100;
            a += 90;
            WriteLine(a);
            a -= 80;
            WriteLine(a);
            a *= 70;
            WriteLine(a);
            a /= 60;
            WriteLine(a);
            a %= 50;
            WriteLine(a);
            a &= 40;
            WriteLine(a);
            a |= 30;
            WriteLine(a);
            a ^= 20;
            WriteLine(a);
            a <<= 10;
            WriteLine(a);
            a >>= 1;
            WriteLine(a);
        }
    }
}
