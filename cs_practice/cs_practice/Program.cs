using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace cs_practice
{
    class Program
    {
        enum DialogResult{ Yes, No, Cancel = 10, Confirm, OK = 20}

        static void Main(string[] args)
        {
            /*
            object a = 123;
            object b = 3.1415924567891365416574618913265m;
            object c = true;
            object d = "안녕하세요";
            WriteLine(a);
            WriteLine(b);
            WriteLine(c);
            WriteLine(d);
            
            float a = 0.9f;
            int b = (int)a;
            WriteLine(b);
            float c = 1.1f;
            int d = (int)c;
            WriteLine(d);
            
            int a =123;
            string b = a.ToString();
            WriteLine(b);
            float c = 3.14f;
            string d = c.ToString();
            WriteLine(d);
            string e = "123456";
            int f = int.Parse(e);
            WriteLine(f);
            string g = "1.23456";
            float h = float.Parse(g);
            WriteLine(h);
            */

            WriteLine(DialogResult.Yes);
            WriteLine(DialogResult.No);
            WriteLine(DialogResult.Cancel);
            WriteLine(DialogResult.Confirm);
            WriteLine(DialogResult.OK);

            WriteLine((int)DialogResult.Yes);
            WriteLine((int)DialogResult.No);
            WriteLine((int)DialogResult.Cancel);
            WriteLine((int)DialogResult.Confirm);
            WriteLine((int)DialogResult.OK);
                        
            var a = 20;
            WriteLine(a);
            WriteLine(a.GetType());
            var b = true;
            WriteLine(b);
            WriteLine(b.GetType());
            
        }
    }
}
