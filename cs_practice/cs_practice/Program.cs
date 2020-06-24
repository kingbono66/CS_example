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
            int currentPointNum = 3;
            int currentXPosition = 0;
            int currentYPosition = 3;
            string character = "';,,;'";
            string pointChar = "*";
            int windowSizeX = 70;
            int windowSizeY = 40;
            int point1XPosition = 0;
            int point1YPosition = 0;
            int point2XPosition = 0;
            int point2YPosition = 0;
            int point3XPosition = 0;
            int point3YPosition = 0;
            bool isExitstPoint1 = true;
            bool isExitstPoint2 = true;
            bool isExitstPoint3 = true;

            InitializeGame(windowSizeX, windowSizeY, ref point1XPosition, ref point1YPosition, 
                ref point2XPosition, ref point2YPosition, ref point3XPosition, ref point3YPosition);
            PrintIntro();
            while(currentPointNum > 0)
            {
                Clear();
                PrintCurrentState(currentPointNum, currentXPosition, currentYPosition, character, pointChar,
                        point1XPosition, point1YPosition, point2XPosition, point2YPosition, point3XPosition, point3YPosition,
                        isExitstPoint1, isExitstPoint2, isExitstPoint3);
                ConsoleKey key = ReadKey(true).Key;
                switch (key)
                {

                }

                //GetUserAction();
                //RefreshState();
            }

            //PlayGame(maxPoint, baseXPosition, baseYPosition, character, point);
            PrintEnding();
        }

        private static void PrintCurrentState(int currentPointNum, int currentXPosition, int currentYPosition, string character, string pointChar,
            int point1XPosition, int point1YPosition, int point2XPosition, int point2YPosition, int point3XPosition, int point3YPosition,
            bool isExitstPoint1, bool isExitstPoint2, bool isExitstPoint3)
        {
            PrintHeader(currentPointNum);
            SetCursorPosition(currentXPosition, currentYPosition);
            Write(character);
            if( isExitstPoint1)
            {
                SetCursorPosition(point1XPosition, point1YPosition);
                Write(pointChar);
            }
            if (isExitstPoint2)
            {
                SetCursorPosition(point2XPosition, point2YPosition);
                Write(pointChar);
            }
            if (isExitstPoint3)
            {
                SetCursorPosition(point3XPosition, point3YPosition);
                Write(pointChar);
            }


        }

        private static void PrintHeader(int currentPointNum)
        {
            WriteLine("========================== 팩맨 게임 ===========================");
            WriteLine("2020.06.24                                         개발자:오종근");
            WriteLine($"\t\t 남은 먹이의 갯수는 {currentPointNum}개 입니다");

        }

        private static void InitializeGame(int windowSizeX, int windowSizeY, ref int point1XPosition, ref int point1YPosition, 
                                    ref int point2XPosition, ref int point2YPosition, ref int point3XPosition, ref int point3YPosition)
        {
            Random random = new Random();

            CursorVisible = false;
            SetWindowSize(windowSizeX, windowSizeY);
            point1XPosition = random.Next(5, windowSizeX - 5);
            point1YPosition = random.Next(5, windowSizeY - 5);
            point2XPosition = random.Next(5, windowSizeX - 5);
            point2YPosition = random.Next(5, windowSizeY - 5);
            point3XPosition = random.Next(5, windowSizeX - 5);
            point3YPosition = random.Next(5, windowSizeY - 5);

        }

        private static void PlayGame(int maxPoint, int baseXPosition, int baseYPosition, string character, string point)
        {
            ConsoleKey key = ReadKey(true).Key;

        }

        private static void PrintEnding()
        {
            WriteLine("성공!!! 축하합니다");
        }

       
        private static void PrintIntro()
        {
            WriteLine("팩맨 시작합니다");
            WriteLine("아무키나 누르세요");
            ReadKey();
            Clear();
        }



    }
}
