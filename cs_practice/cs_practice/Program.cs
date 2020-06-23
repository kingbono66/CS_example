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
        enum Rpc{ 바위 = 1, 보, 가위 }
        enum GameResult{ 승리 = 1, 패배, 무승부 }
        static void Main(string[] args)
        {
            Rpc userAction = 0;
            Rpc comAction = 0;
            Random random = new Random();
            GameResult gameResult = 0;
            bool gameContinueFlag = true;

            WriteLine("===== 가위 바위 보 게임!!!!  =====");
            while( gameContinueFlag )
            {
                //입력
                while(true)
                {
                    Write("무엇을 낼지 숫자로 입력하세요 ( 1.바위\t2.보\t3.가위 ) :  ");
                    userAction = (Rpc)int.Parse(ReadLine());
                    if( (int)userAction > 0 && (int)userAction < 4 )
                        break;
                    else
                       WriteLine("잘못된 입력 입니다!!!!");
                }

                //계산
                comAction = (Rpc)random.Next(1, 4);
                WriteLine($"\n당신의 선택은 {userAction}");
                WriteLine($"컴퓨터의 선택은 {comAction}\n");

                if (userAction == comAction)
                    gameResult = GameResult.무승부;
                else if (((int)userAction - (int)comAction) == 1
                            || ((int)userAction - (int)comAction) == -2)
                    gameResult = GameResult.승리;
                else
                    gameResult = GameResult.패배;

                //출력
                switch (gameResult)
                {
                    case GameResult.승리: WriteLine($"축하합니다 ^0^ 당신은 {gameResult} 하셨습니다!!!\n\n");
                        gameContinueFlag = false;
                        break;
                    case GameResult.패배: WriteLine($"안타깝네요 ㅠㅠ 당신은 {gameResult} 하셨습니다!!!\n\n");
                        gameContinueFlag = false;
                        break;
                    case GameResult.무승부: WriteLine($"{gameResult} 입니다 ~.~\n\n");
                        WriteLine("=======재경기======");
                        break;
                }
            }
        }
    }
}
