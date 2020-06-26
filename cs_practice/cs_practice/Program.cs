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

            //초기화 및 설정
            answerArr = InitializeGame(windowSizeX, windowSizeY, ref isTestMode);


            //플레이



            //마무리


        }

        private static int[] InitializeGame(int windowSizeX, int windowSizeY, ref bool isTestMode)
        {
            SetWindowSize(windowSizeX, windowSizeY);
            WriteLine("재미있는 야구 게임 시작합니다");


        }

        static int GetRangedIntInput(int min, int max)
        {
            int intInput = -99999999;
            while (true)
            {
                int.TryParse(ReadLine(), out intInput);
                if (intInput >= min && intInput <= max)
                    break;
            }
            return intInput;
        }
    }
}
