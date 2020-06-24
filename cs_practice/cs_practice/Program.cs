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
            int windowSizeY = 30;
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
                PrintCurrentState(currentPointNum, currentXPosition, currentYPosition, character, pointChar,
                        point1XPosition, point1YPosition, point2XPosition, point2YPosition, point3XPosition, point3YPosition,
                        isExitstPoint1, isExitstPoint2, isExitstPoint3);
                GetUserAction(ref currentXPosition, ref currentYPosition);                
                MovementVerify(ref currentXPosition, ref currentYPosition, windowSizeX, windowSizeY);
                ColisionVerify(ref currentPointNum, currentXPosition, currentYPosition, 
                    point1XPosition, point1YPosition, point2XPosition, point2YPosition, point3XPosition, point3YPosition,
                        ref isExitstPoint1, ref isExitstPoint2, ref isExitstPoint3);
            }
            PrintEnding(windowSizeX, windowSizeY);
        }

        private static void ColisionVerify(ref int currentPointNum, int currentXPosition, int currentYPosition, 
            int point1XPosition, int point1YPosition, int point2XPosition, int point2YPosition, int point3XPosition, int point3YPosition, 
            ref bool isExitstPoint1, ref bool isExitstPoint2, ref bool isExitstPoint3)
        {
            if(isExitstPoint1 && currentYPosition == point1YPosition && currentXPosition > (point1XPosition - 6 ) && currentXPosition <= point1XPosition)
            {
                isExitstPoint1 = false;
                currentPointNum--;
                PrintEffect(currentXPosition, currentYPosition);
            }
            if (isExitstPoint2 && currentYPosition == point2YPosition && currentXPosition > (point2XPosition - 6) && currentXPosition <= point2XPosition)
            {
                isExitstPoint2 = false;
                currentPointNum--;
                PrintEffect(currentXPosition, currentYPosition);
            }
            if (isExitstPoint3 && currentYPosition == point3YPosition && currentXPosition > (point3XPosition - 6) && currentXPosition <= point3XPosition)
            {
                isExitstPoint3 = false;
                currentPointNum--;
                PrintEffect(currentXPosition, currentYPosition);
            }
        }

        private static void PrintEffect(int currentXPosition, int currentYPosition)
        {
            SetCursorPosition(currentXPosition, currentYPosition  - 1);
            ForegroundColor = ConsoleColor.Red;
            Write("EAT!!");
            ForegroundColor = ConsoleColor.White;
        }

        private static void GetUserAction(ref int currentXPosition, ref int currentYPosition)
        {
            ConsoleKey key = ReadKey(true).Key;
            CharacterClear(currentXPosition, currentYPosition);
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    currentXPosition--;
                    break;
                case ConsoleKey.RightArrow:
                    currentXPosition++;
                    break;
                case ConsoleKey.DownArrow:
                    currentYPosition++;
                    break;
                case ConsoleKey.UpArrow:
                    currentYPosition--;
                    break;
            }
        }

        private static void CharacterClear(int currentXPosition, int currentYPosition)
        {
            SetCursorPosition(currentXPosition, currentYPosition);
            Write("      ");
        }

        private static void MovementVerify(ref int currentXPosition, ref int currentYPosition, int windowSizeX, int windowSizeY)
        {
            if (currentXPosition < 0) currentXPosition = 0;
            if (currentYPosition < 3) currentYPosition = 3;
            if (currentXPosition > (windowSizeX - 6)) currentXPosition = (windowSizeX - 6);
            if (currentYPosition > (windowSizeY - 1)) currentYPosition = (windowSizeY - 1);
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
            SetCursorPosition(0, 0);
            WriteLine("============================ 팩맨 게임 =============================");
            WriteLine("2020.06.24                v1.0                         개발자:오종근");
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

        private static void PrintEnding(int windowSizeX, int windowSizeY)
        {
            Clear();
            SetCursorPosition(windowSizeX/3, windowSizeY/2);
            ForegroundColor = ConsoleColor.Red;
            WriteLine("성공!!! 축하합니다");
            SetCursorPosition(0, windowSizeY-1);
            ForegroundColor = ConsoleColor.White;
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
