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

        static void Main(string[] args)
        {
            /*
            int[] scores = new int[10];
            bool[] isPass = new bool[10];
            int sum = 0;

            for( int i = 0; i < scores.Length; i++)
            {
                Write($"학생{i + 1} : ");
                //scores[i] = int.Parse(ReadLine());
                while(!int.TryParse(ReadLine(), out scores[i]))
                {
                    Write($"학생{i + 1} : ");
                }
                if( scores[i] < 0 || scores[i] > 100)
                {
                    i--;
                    continue;
                }

                if (scores[i] >= 60)
                    isPass[i] = true;
                else
                    isPass[i] = false;
                Clear();
            }
            foreach(int e in scores)
            {
                sum += e;
            }
            WriteLine($"합계 : {sum}\t\t평균 : {((float)sum/scores.Length).ToString("F2")}");
            WriteLine("합격자");
            WriteLine("---------------------------");
            for( int i = 0; i < isPass.Length; i++)
            {
                if (isPass[i])
                    WriteLine("학생 {0,3}", (i + 1));
            }
            */

            /*
            int[][] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 6, 7 };
            jagged[2] = new int[] { 8 };

            for(int i = 0; i < jagged.Length; i++)
            {
                foreach(int e in jagged[i])
                {
                    WriteLine(e);
                }
                WriteLine();
            }
            */

            /*
            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
                list.Add(i);
            foreach (object obj in list)
                Write($"{obj} ");
            WriteLine();

            list.RemoveAt(2);
            foreach (object obj in list)
                Write($"{obj} ");
            WriteLine();

            list.Insert(2, 2);
            foreach (object obj in list)
                Write($"{obj} ");
            WriteLine();

            list.Add("abc");
            list.Add("def");

            for (int i = 0; i < list.Count; i++)
                Write($"{list[i]} ");
            WriteLine();
            */

            /*
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while(stack.Count > 0)
            {
                WriteLine(stack.Pop());
            }
            */

            /*
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            while (queue.Count > 0)
            {
                WriteLine(queue.Dequeue());
            }
            */

            Hashtable ht = new Hashtable();
            ht["하나"] = "one";
            ht["둘"] = "two";
            ht["셋"] = "three";
            ht["넷"] = "four";
            ht["다섯"] = "five";

            WriteLine(ht["하나"]);
            WriteLine(ht["둘"]);
            WriteLine(ht["셋"]);
            WriteLine(ht["넷"]);
            WriteLine(ht["다섯"] + "\n");
            foreach(object o in ht.Values)
            {
                WriteLine(o);
            }



        }
    }
}
