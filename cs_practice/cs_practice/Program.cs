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
        enum Days { 월, 화, 수, 목, 금, 토, 일}
        static void Main(string[] args)
        {
            /*
            #region 정수분류
            int input_int = 0;
            string input_string = "";

            Write("정수를 입력하세요 :  ");
            input_string = ReadLine();
            input_int = int.Parse(input_string);

            if(input_int > 0)
            {
                Write("양수 이며 ");
                if(input_int % 2 == 0)
                    WriteLine("짝수 입니다");                
                else
                    WriteLine("홀수 입니다");
            }
            else if (input_int < 0)
            {
                WriteLine("음수 입니다");
            }
            else
                WriteLine("0 입니다");
            #endregion
            
            Random r = new Random();
            int score = r.Next(0, 101);
            WriteLine("점수: " + score);
            if (score > 100 || score < 0)
                WriteLine("0~100 사이의 수를 입력해 주세요");
            else if (score >= 90)
                WriteLine("A");
            else if (score >= 80)
                WriteLine("B");
            else if (score >= 70)
                WriteLine("C");
            else if (score >= 60)
                WriteLine("D");
            else
                WriteLine("F");
            */

            Random r = new Random();
            Days days = (Days)r.Next(0, 7);
            WriteLine(days);
            //Write("요일을 입력하세요(월,화,수,목,금,토,일): ");
            //string day = ReadLine();
            switch (days)
            {
                case Days.월:
                    WriteLine("Monday");
                    break;
                case Days.화:
                    WriteLine("Tuesday");
                    break;
                case Days.수:
                    WriteLine("Wednesday");
                    break;
                case Days.목:
                    WriteLine("Thursday");
                    break;
                case Days.금:
                    WriteLine("Friday");
                    break;
                case Days.토:
                    WriteLine("Saturday");
                    break;
                case Days.일:
                    WriteLine("Sunday");
                    break;
                default:
                    WriteLine($"{days}는 요일이 아닙니다");
                    break;
            }

        }
    }
}
