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
            int currentPointNum = 10;
            int currentXPosition = 0;
            int currentYPosition = 3;
            string character = "';,,;'";
            string pointChar = "*";
            int windowSizeX = 70;
            int windowSizeY = 30;
            int[,] points = new int[currentPointNum, 3];  //x,y,isVisible ( 1=visible 0=invisible)

            InitializeGame(windowSizeX, windowSizeY, points);
            PrintIntro();
            while(currentPointNum > 0)
            {
                PrintCurrentState(currentPointNum, currentXPosition, currentYPosition, character, pointChar, points);
                GetUserAction(ref currentXPosition, ref currentYPosition);                
                MovementVerify(ref currentXPosition, ref currentYPosition, windowSizeX, windowSizeY);
                ColisionVerify(ref currentPointNum, currentXPosition, currentYPosition, points);
            }
            PrintEnding(windowSizeX, windowSizeY);
        }

        private static void ColisionVerify(ref int currentPointNum, int currentXPosition, int currentYPosition, int[,] points )
        {
            for (int i = 0; i < points.GetLength(0); i++)
            {
                if (points[i, 2] == 1 && currentYPosition == points[i, 1] && currentXPosition > (points[i, 0] - 6) && currentXPosition <= points[i, 0])
                {
                    points[i, 2] = 0;
                    SetCursorPosition(points[i, 0], points[i, 1]);
                    currentPointNum--;
                    PrintEffect(currentXPosition, currentYPosition);
                }
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

        private static void PrintCurrentState(int currentPointNum, int currentXPosition, int currentYPosition, string character, string pointChar, int[,] points )
        {
            PrintHeader(currentPointNum);
            SetCursorPosition(currentXPosition, currentYPosition);
            Write(character);
            for( int i = 0; i < points.GetLength(0); i++ )
            {
                if( points[i, 2] == 1)
                {
                    SetCursorPosition(points[i, 0], points[i, 1]);
                    Write(pointChar);
                }
            }
        }

        private static void PrintHeader(int currentPointNum)
        {
            SetCursorPosition(0, 0);
            WriteLine("============================ 팩맨 게임 =============================");
            WriteLine("2020.06.24                v1.0                         개발자:오종근");
            WriteLine($"\t\t 남은 먹이의 갯수는 {currentPointNum}개 입니다");

        }

        private static void InitializeGame(int windowSizeX, int windowSizeY, int[,] points)
        {
            Random random = new Random();
            int i, j;

            CursorVisible = false;
            SetWindowSize(windowSizeX, windowSizeY);
            for( i = 0; i < points.GetLength(0); i++)
            {
                while(true)
                {
                    points[i, 0] = random.Next(5, windowSizeX - 5);
                    points[i, 1] = random.Next(5, windowSizeY - 5);
                    for( j = 0; j < i; j++ )
                    {
                        if (points[j, 0] == points[i, 0] && points[j, 1] == points[i, 1])
                            break;
                    }
                    if (j == i) 
                        break;
                }
                points[i, 2] = 1;
            }
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
