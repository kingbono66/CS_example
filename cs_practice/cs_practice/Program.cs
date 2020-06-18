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
            int i = 0;
            int k = 0;
            int j = 0;

            i = 1;
            while(i <= 201 )
            {
                WriteLine(i);
                i += 4;
            }

            for( i = 1; i <= 9; i++ )
            {
                for(k = 1; k <= 9; k++)
                    Write(i*k +"\t");
                WriteLine("");
            }

            for( i = 0; i < 5; i++)
            {
                for( k = 0; k <= i; k++)
                    Write("*");
                WriteLine("");
            }


            WriteLine("111111111");
            for (i = 0; i < 5; i++)
            {
                for (k = 0; k < (5 - i); k++)
                    Write("*");
                WriteLine("");
            }


            WriteLine("22222222222");
            for (i = 0; i < 5; i++)
            {
                for (k = 0; k < 5; k++)
                {
                    if (i < (4-k))
                        Write(" ");
                    else
                        Write("*");
                }
                WriteLine("");
            }


            WriteLine("333333");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < i; j++)
                    Write(" ");
                for (k = 0; k < (5-i); k++)
                    Write("*");
                WriteLine("");
            }


            WriteLine("4444444");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < (3-i); j++)
                    Write(" ");
                for (k = 0; k < (i*2+1); k++)
                    Write("*");
                WriteLine("");
            }

            WriteLine("555555");
            for (i = 0; i < 7; i++)
            {
                for (j = 0; i<4?(j<i):(j<(6-i)); j++)
                    Write(" ");
                for (k = 0; i<4?(k<(4-i)):(k<(i-2)); k++)
                    Write("* ");
                WriteLine("");
            }
        }
    }
}
