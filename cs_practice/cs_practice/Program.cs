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
            Random random = new Random();

            /*
            int[] nums = new int[3];
            nums[0] = 3;
            nums[1] = 4;
            nums[2] = -2;

            WriteLine(nums[0]);
            WriteLine(nums[1]);
            WriteLine(nums[2]);

            int[] students = new int[7] { 10, 100, 55, 40, 20, 88, 66 };
            for (int i = 0; i < students.Length; i++)
                WriteLine(students[i]);

            WriteLine("foreach");
            foreach( int s in students)
                WriteLine(s);

            int sum = 0;
            for (int i = 0; i < students.Length; i++)
                sum += students[i];
            WriteLine(sum);
            WriteLine(sum / students.Length);

            int[] scores = new int[30];
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = random.Next(0, 101);
                Write(scores[i] + "\t");
            }
            WriteLine();
            foreach( int e in scores)
            {
                if (e >= 70)
                    WriteLine(e);
            }
            */


            int[] koreanScores = new int[10];
            int[] englishScores = new int[10];
            int[] mathScores = new int[10];

            for (int i = 0; i < koreanScores.Length; i++)
            {
                koreanScores[i] = random.Next(0, 101);
                englishScores[i] = random.Next(0, 101);
                mathScores[i] = random.Next(0, 101);
            }

            for (int i = 0; i < koreanScores.Length; i++)
            {
                WriteLine($"학생{i + 1} 국어: {koreanScores[i]}, 영어:{englishScores[i]}, 수학:{mathScores[i]}, " +
                    $"합계:{koreanScores[i]+ englishScores[i]+ mathScores[i] }, 평균점{(koreanScores[i] + englishScores[i] + mathScores[i]) /3}");
                //Write("학생{0,4}", i); 자릿수지정
            }

            int[] arr1 = new int[3] { 1, 2, 3 };
            int[] arr2 = new int[] { 1, 2, 3 };
            int[] arr3 = { 1, 2, 3 };

            int[,] scores = new int[4, 3]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 },
                {10,11,12 }
            };
            for(int i = 0; i < scores.GetLength(0); i++)
            {
                for (int j = 0; j < scores.GetLength(1); j++)
                    WriteLine($"{scores[i, j]} ");
                WriteLine();
            }




        }



    }
}
