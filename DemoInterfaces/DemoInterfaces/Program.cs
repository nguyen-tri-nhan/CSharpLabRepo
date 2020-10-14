using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Boxes boxes = new Boxes(3.2f, 5.5f);
            Console.WriteLine(boxes);
            IDemension demension = new Boxes(5.6f, 2.4f);
            Console.WriteLine(demension.GetLength()+" ," +demension.GetWidth());
        }
    }
}
