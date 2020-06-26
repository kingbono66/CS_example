using System;
using System.Collections;
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
        //야구게임 제한턴수9
        static void Main(string[] args)
        {
            int windowSizeX = 70;
            int windowSizeY = 30;
            int[] answerArr;
            bool isTestMode = true;
            int gameDigit = 3;
            int limitTurn = 9;
            int currentTurn = 0;

            //초기화 및 설정
            InitializeGame(windowSizeX, windowSizeY, ref isTestMode, ref gameDigit);
            answerArr = GetAnswerArr(gameDigit);
            //플레이
            PrintHeader(gameDigit, isTestMode, answerArr);
            for (currentTurn = 1; currentTurn <= limitTurn; currentTurn++)
            {
                if (PlayOneTurn(currentTurn, gameDigit, answerArr ))  //정답을 맞췄을때 true 반환
                    break;
            }
            //마무리
            PrintEnding(currentTurn, limitTurn, answerArr);
        }

        private static void PrintEnding(int currentTurn, int limitTurn, int[] answerArr)
        {
            if (currentTurn <= limitTurn)
                WriteLine($"\n\n******* 축하합니다 {currentTurn}번째만에 맞추었습니다 *******");
            else
            {
                WriteLine(" ㅠㅠ  TOO BAD 대 실패 ㅠㅠ");
                Write($"정답은  ");
                foreach (int e in answerArr)
                    Write(e + "   ");
            }
        }

        private static bool PlayOneTurn(int currentTurn, int gameDigit, int[] answerArr)
        {
            bool isCorrect = false;
            int[] userInput = new int[gameDigit];
            int i,j;
            int strike = 0;
            int ball = 0;

            Write($"{currentTurn}턴째: ");
            for( i = 0; i < gameDigit; i++)
            {
                SetCursorPosition(8 + i * 3, currentTurn + 3);
                userInput[i] = GetRangedIntInput(0, 9);
                //지긋지긋한 중복검사      
                for( j = 0; j < i; j++)
                {
                    if (userInput[i] == userInput[j])
                        break;
                }
                if( i != j)
                {
                    i--;
                    continue;
                }
                SetCursorPosition(8 + i * 3, currentTurn + 3);
                Write(userInput[i]);
                ClearBehind();
            }
            StrikeBallVerify( answerArr, userInput, ref strike, ref ball);
            SetCursorPosition(8 + i * 3, currentTurn + 3);
            Write($"  {strike}S  {ball}B");

            if (strike == gameDigit)
                isCorrect = true;
            SetCursorPosition(0, currentTurn + 4);
            return isCorrect;
        }

        private static void StrikeBallVerify( int[] answerArr, int[] userInput, ref int strike, ref int ball)
        {
            for( int i = 0; i < answerArr.Length; i++)
            {
                for( int j = 0; j < userInput.Length; j++)
                {
                    if( answerArr[i] == userInput[j])
                    {
                        if (i == j)
                            strike++;
                        else
                            ball++;
                    }
                }
            }
        }

        private static void ClearBehind()
        {
            for (int i = 0; i < 10; i++)
                WriteLine("                                                   ");
        }

        private static void PrintHeader(int gameDigit, bool isTestMode, int[] answerArr)
        {
            Clear();
            WriteLine($"=====  {gameDigit}자리 야구게임 =====");
            WriteLine("        developed by 오종근");
            if(isTestMode)
            {
                SetCursorPosition(30, 0);
                Write("테스트모드입니다");
                SetCursorPosition(30, 1);
                Write("정답 : ");
                foreach (int e in answerArr)
                    Write($"{e}  ");
                SetCursorPosition(0, 2);
            }
            WriteLine("===========================");
            WriteLine($"각 턴당 {gameDigit}번씩 숫자(0~9)를 입력하세요");
        }

        private static int[] GetAnswerArr(int gameDigit)
        {
            Random random = new Random();
            int[] answerArr = new int[gameDigit];
            int i, j;
            for( i = 0; i < gameDigit; i++)
            {
                answerArr[i] = random.Next(0, 10);
                for ( j = 0; j < i; j++)
                {
                    if (answerArr[i] == answerArr[j])
                        break;
                }
                if (i != j)
                {
                    i--;
                    continue;
                }
            }
            return answerArr;
        }

        private static void InitializeGame(int windowSizeX, int windowSizeY, ref bool isTestMode, ref int gameDigit)
        {
            SetWindowSize(windowSizeX, windowSizeY);
            WriteLine("재미있는 야구 게임 시작합니다");
            Write("정답이 옆에 표시되도록 하겠습니까? ( y/n ):  ");
            isTestMode = GetChoice();
            Write("몇자리의 야구 게임을 하겠습니까? ( 3 ~ 6 ): ");
            gameDigit = GetRangedIntInput(3, 6, "다시 입력해주세요. ( 3 ~ 6 ): ");
            WriteLine("게임을 시작합니다\n아무키나 누르세요!!");
            ReadKey();
        }

        //오버로딩 활용
        static int GetRangedIntInput(int min, int max, string errorMessage)
        {
            int intInput = -99999999;
            while (true)
            {
                if (!int.TryParse(ReadLine(), out intInput))
                {
                    Write(errorMessage);
                    continue;
                }
                if (intInput >= min && intInput <= max)
                    break;
                Write(errorMessage);
            }
            return intInput;
        }

        static int GetRangedIntInput(int min, int max)
        {
            int intInput = -99999999;
            while (true)
            {
                if (!int.TryParse(ReadLine(), out intInput))
                    continue;
                if (intInput >= min && intInput <= max)
                    break;
            }
            return intInput;
        }

        static bool GetChoice()
        {
            string choice;
            while (true)
            {
                choice = ReadLine().ToLower();
                if (choice == "y")
                    return true;
                else if (choice == "n")
                    return false;
                else
                {
                    WriteLine("잘못 입력하셨습니다. 다시입력해주세요.");
                    Write("정답이 옆에 표시되도록 하겠습니까? ( y/n ):  ");
                }
            }
        }
    }
}
