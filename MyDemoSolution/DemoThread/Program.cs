using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoThread
{
    public class Printer
    {
        public void PrintNubers()
        {
            // display thread info
            Console.WriteLine("-> {0} is executing PrintNumber()", Thread.CurrentThread.Name);
            // work
            Console.WriteLine("Your num: ");
            for(int i = 0; i < 10; i++)
            {
                Console.Write(i + ", ");
                Thread.Sleep(500);
            }
            Console.WriteLine();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("***** The amazing thread app *****\n");
            //  name current thread
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";
            //display info
            Console.WriteLine("-> {0} is executing Main()", Thread.CurrentThread.Name);
            // mark worker class
            Printer p = new Printer();
            ThreadStart t = new ThreadStart(p.PrintNubers);
            Thread backgroundThread = new Thread(t);
            backgroundThread.Name = "Secondary";
            backgroundThread.Start();
            // do some additional work
            //DoMoreWork();
            Console.ReadLine();
        }
        static void DoMoreWork()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("I am doing whatever i want!");
                Thread.Sleep(1000);
            }
        }
    }
}
