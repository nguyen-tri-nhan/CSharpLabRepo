using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoThread2
{
    public class Printer
    {
        public void PrintNubers()
        {
            lock (this) 
            { 
            // display thread info
            Console.WriteLine("-> {0} is executing PrintNumber()", Thread.CurrentThread.Name);
            // work
            Console.WriteLine("Your num: ");
            for (int i = 0; i < 10; i++)
            {
                Random r = new Random();
                Thread.Sleep(2000 * r.Next(5));
                Console.Write(r.Next(5) + ", ");
            }
            Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Synchnorizing threads\n");
            Printer p = new Printer();
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ThreadStart(p.PrintNubers));
                threads[i].Name = string.Format("Worker thread #{0}", i);
            }
            // start each one
            foreach (Thread thread in threads)
            {
                thread.Start();
            }
            Console.ReadLine();
        }
    }
}
