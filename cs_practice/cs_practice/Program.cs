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
            //int a = 30, b = 8;
            //int q = 0;
            //int r = 0;


            /*
            WriteLine($"{ a },{ b }");
            Swap(ref a, ref b);
            WriteLine($"{ a },{ b }");
            */

            //WriteLine($"{ a },{ b }");
            //Divide(a, b, out q, out r);
            //WriteLine($"{ q },{ r }");

            //WriteLine(Plus(1, 2));
            //WriteLine(Plus(3.14f, 2.5f));
            //WriteLine(Plus(1, 2, 3));

            WriteLine(Sum(1, 2, 3, 4, 5));
            WriteLine(Sum(13, 52));

        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Divide(int a, int b, out int q, out int r)
        {
            //if(b!=0)
            {
                q = a / b;
                r = a % b;
            }            
        }

        static int Plus(int x, int y)
        {
            return x + y;
        }
        static float Plus(float x, float y)
        {
            return x + y;
        }
        static int Plus(int x, int y, int z)
        {
            return x + y + z;
        }
        static int Minus(int x, int y)
        {
            return x - y;
        }
        static float Minus(float x, float y)
        {
            return x - y;
        }
        static int Minus(int x, int y, int z)
        {
            return x - y - z;
        }
        static int Sum(params int[] num)
        {
            int result = 0;
            for(int i = 0; i < num.Length; i++)
            {
                result += num[i];
            }
            return result;
        }

    }
}
