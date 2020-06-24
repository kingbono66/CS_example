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
            int maxPoint = 3;
            int baseXPosition = 5;
            int baseYPosition = 4;
            string character = "';,,;'";
            string pointChar = "*";
            int windowSizeX = 100;
            int windowSizeY = 40;
            int point1XPosition = 0;
            int point1YPosition = 0;
            int point2XPosition = 0;
            int point2YPosition = 0;
            int point3XPosition = 0;
            int point3YPosition = 0;


            
            InitializeGame(windowSizeX, windowSizeY, ref point1XPosition, ref point1YPosition, 
                ref point2XPosition, ref point2YPosition, ref point3XPosition, ref point3YPosition);
            printIntro();
            //PlayGame(maxPoint, baseXPosition, baseYPosition, character, point);
            printEnding();
        }

        private static void InitializeGame(int windowSizeX, int windowSizeY, ref int point1XPosition, ref int point1YPosition, 
                                    ref int point2XPosition, ref int point2YPosition, ref int point3XPosition, ref int point3YPosition)
        {
            Random random = new Random();

            CursorVisible = false;
            SetWindowSize(windowSizeX, windowSizeY);
            point1XPosition = random.Next(5, 95);
            point1YPosition = random.Next(1, 40);
            point2XPosition = random.Next(5, 95);
            point2YPosition = random.Next(1, 40);
            point3XPosition = random.Next(5, 95);
            point3YPosition = random.Next(1, 40);

        }

        private static void PlayGame(int maxPoint, int baseXPosition, int baseYPosition, string character, string point)
        {
            
        }

        private static void printEnding()
        {
            WriteLine("성공!!! 축하합니다");
        }

       
        private static void printIntro()
        {
            WriteLine("팩맨 시작합니다");
            WriteLine("아무키나 누르세요");
            ReadKey();
        }



    }
}
