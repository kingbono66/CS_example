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
        //int.TryParse(ReadLine(), out scores[i])
        static void Main(string[] args)
        {
            int windowSizeX = 100;
            int windowSizeY = 40;

            //초기화 및 설정



            //플레이



            //마무리


        }

        static int getRangedIntInput(int min, int max)
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
