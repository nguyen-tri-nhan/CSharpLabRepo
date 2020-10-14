using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    public delegate int MyDelegate(int x);
    public delegate void WhoDele(string s);
    class Program
    {
        static int Square(int x) => x * x;
        static int Sum(int x) => x + x;
        static void Execute(MyDelegate callMethod, int n)
        {
            int r = callMethod.Invoke(n);
            Console.WriteLine(r);
        }
        static void Print(string s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Hello "+s);
        }
        static void Display(string s) => Console.WriteLine("Xin chao " + s);
        static void Main(string[] args)
        {
            int r;
            MyDelegate dele = new MyDelegate(Square);
            r = dele(3);
            //
            Console.WriteLine(r);
            MyDelegate my = Square;
            Console.WriteLine(my.Invoke(4));
            //annon method
            MyDelegate my1 = delegate (int x)
            {
                return x * x;
            };
            Console.WriteLine(my1(5));
            //from .Net 3.5
            MyDelegate my2 = ((x) => x * x);
            Console.WriteLine(my2(6));
            //su dung function delegate
            Func<int, int> my3 = (x => x * x);
            Console.WriteLine(my3(7));
            Func<double, double, string> f = ((a, b) =>
            {
                return (a + b).ToString();
            });
            Console.WriteLine(f(3.4,4.5));
            /**
             * dsad
             */
            MyDelegate delee = new MyDelegate(Square);
            Execute(delee, 3);
            delee = Sum;
            Execute(delee, 5);

            WhoDele dell = new WhoDele(Print);
            //asynchronous Calll
            dell.BeginInvoke("Tom", null, null);
            dell = Display;
            dell("Tommy");
            Console.ReadLine();
        }
    }
}
