using System;
using System.Collections.Generic;
using System.Globalization;
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
            int a = 3, b = 5;

            WriteLine(Plus( a, b));
            WriteLine(Minus(a, b));
            WriteLine(Multi(a, b));

        }
        static int Plus(int x, int y)
        {
            return x+y;
        }
        static int Minus(int x, int y)
        {
            return x-y;
        }
        static int Multi(int x, int y)
        {
            return x*y;
        }
    }
}
