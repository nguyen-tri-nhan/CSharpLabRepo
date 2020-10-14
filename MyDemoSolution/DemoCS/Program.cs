using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCS
{
    static class Utils
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(this int a, int b) => a - b;
        
    }
    class Program
    {
        static void Calc(ref int a, int b, out int c)
        {
            a += b;
            c = a + b;
            b = a + c;
        }
        static void SumArray(out int s, params int[] arr) => s = arr.Sum();
        static void Main(string[] args)
        {
            int x = 3, y = 2, z = 1, s;
            //int r = Utils.Add(x, y);
            //Console.WriteLine("{0}+{1}={2}", x, y, r);
            //r = x.Sub(y);
            //Console.WriteLine($"{x} - {y} = {r}");
            //Console.ReadLine();
            Calc(ref x, y, out z);
            Console.WriteLine($"x = {x}, y = {y}, z = {z}");
            SumArray(out s, x, y, z);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
