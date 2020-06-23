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
            int a = 123, b = 8;

            WriteLine(Plus( a, b));
            WriteLine(Minus(a, b));
            WriteLine(Multi(a, b));
            WriteLine(divide(a, b));

        }
        static int Plus(int x, int y)
        {
            WriteLine("더하기 연산");
            return x+y;
        }
        static int Minus(int x, int y)
        {
            WriteLine("빼기 연산");
            return x-y;
        }
        static int Multi(int x, int y)
        {
            WriteLine("곱하기 연산");
            return x*y;
        }
        static int divide(int x, int y)
        {
            WriteLine("나누기 연산");
            int result = 0;
            if( y != 0 )
                result = x / y;

            return result;
        }
    }
}
