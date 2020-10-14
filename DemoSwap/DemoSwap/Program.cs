﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSwap
{
    interface IMath<T>
    {
        T Add(T a, T b);
    }
    class MyClass : IMath<int>
    {
        public int Add(int a, int b) => a + b;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 30;
            Console.WriteLine("Before swap: {0}, {1}" , a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("After swap:{0}, {1}", a, b);

            string s1 = "Hello", s2 = "There";
            Console.WriteLine("Before swap {0} {1}", s1, s2);
            Swap<string>(ref s1, ref s2);
            Console.WriteLine("After swap {0} {1}", s1, s2);
            Console.WriteLine("----------------------------");
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.Add(3,4));
        }
        static void Swap<T>(ref T a, ref T b)
        {
            (a, b) = (b, a);
        }
    }
    
}
