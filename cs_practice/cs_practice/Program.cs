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
            CursorVisible = false;
            //선언부
            int x = 5, y = 2;



            //실행부
            while (true)
            {
                //초기화
                //Clear();

                //위치세팅
                SetCursorPosition(x, y);

                //출력
                Write("^^");

                //키보드입력
                ConsoleKey key = ReadKey(true).Key;
                CharacterClear(x, y);

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                }
                if (x < 0) x = 0;
                if (y < 0) y = 0;

            }
        }

        static void CharacterClear(int x, int y)
        {
            SetCursorPosition(x, y);
            Write("  ");
        }

    }
}
