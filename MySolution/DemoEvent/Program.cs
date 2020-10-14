using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEvent
{
    class Program
    {
        public delegate void SimpleDele(string msg);
        public event SimpleDele myEvent;
        public void run()
        {
            myEvent += delegate (String msg)
            {
                Console.WriteLine(msg);
            };
            myEvent += delegate
             {
                 Console.WriteLine("This is annon method");
             };
            myEvent("Called by annon method");
        }
        static void Main(string[] args)
        {
            new Program().run();
            Console.ReadLine();
        }
    }
}
