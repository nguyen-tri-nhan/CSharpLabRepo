using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerCallbackDemo
{
    class TimePrinter
    {
        static void PrintTime(object state)
        {
            Console.WriteLine("Time is: {0}, Param is: {1}", DateTime.Now.ToLongTimeString(), state.ToString());
        }
    }
    class Program
    {
        static void PrintTime(object state)
        {
            Console.WriteLine("Time is: {0}, Param is: {1}", DateTime.Now.ToLongTimeString(), state.ToString());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Anything");
            TimerCallback timeCB = new TimerCallback(PrintTime);
            Timer t = new Timer
            (
                timeCB,
                "Hi",
                0,
                1000
            );
            Console.WriteLine("anykey to terminate");
            Console.ReadLine();
        }
    }
}
