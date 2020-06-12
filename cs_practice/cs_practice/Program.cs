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
            WriteLine($"3 > 4 : {3 > 4}");
            WriteLine($"3 < 4 : {3 < 4}");
            WriteLine($"3 >= 4 : {3 >= 4}");
            WriteLine($"3 <= 4 : {3 <= 4}");
            WriteLine($"3 == 4 : {3 == 4}");
            WriteLine($"3 != 4 : {3 != 4}");


            #endregion
        }
    }
}
