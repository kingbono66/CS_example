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
            #region 주사위 게임
            Random random = new Random();

            WriteLine("===  주사위 게임 ===");
            int number = random.Next(0, 6) + 1;
            WriteLine($"{number}이 나왔습니다");
            WriteLine($"반대편 눈은{7-number} 입니다");
            #endregion

            int i = 0;
            int sum = 0;
            while(i < 100)
            {
                i++;
                sum += i;
                WriteLine(sum);
            }
            */

            
            ForegroundColor = ConsoleColor.Red;
            for( int i = 0; i < 10; i++)
            {
                WriteLine(i + 1);
            }
            for (int i = 10; i > 0; i--)
            {
                WriteLine(i);
            }
            ForegroundColor = ConsoleColor.Green;
            for( int sum = 0, i = 0 ; i < 100; i++ )
            {
                WriteLine(sum += (i + 1));
            }
            ForegroundColor = ConsoleColor.Blue;
            for( int i = 0; i < 11; i++)
            {
                WriteLine(1 << i);
                //WriteLine(Math.Pow(2,i));
                
            }
            ForegroundColor = ConsoleColor.White;
            for( int i = 0; i < 5; i++)
            {
                WriteLine(2 * i + 1);
            }

            for( int i = 1; i <= 1024; i *= 2)
            {
                if (i == 64) continue;
                WriteLine(i);
            }

        }
    }
}
