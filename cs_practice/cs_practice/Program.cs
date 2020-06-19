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
            for(int i = 10; i < 15; i++)
            {
                for(int j = 4; j < 9; j++)
                {
                    SetCursorPosition(i, j);
                    if(i==10||i==14||j==4||j==8)
                        WriteLine("*");
                }
            }

            WriteLine("*");
            System.Threading.Thread.Sleep(2000);
            WriteLine("*");



            SetCursorPosition(0, 20);
            WriteLine("");
        }
    }
}
