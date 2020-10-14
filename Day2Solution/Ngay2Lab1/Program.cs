using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_3
{

    class Program
    {
        static void Main(string[] args)
        {
            int package, distance, shift, feedback, call, electric, other;
            double salary;
            Console.WriteLine("Enter package name");
            package = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter distance number");
            distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter shift number");
            shift = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter feedback grade");
            feedback = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter call amount");
            call = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the electricity payment");
            electric = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the other payment");
            other = Convert.ToInt32(Console.ReadLine());
            salary = package * 50 + distance * 75 + shift * 50 * 0.1 + feedback + call + electric + other;
            Console.WriteLine("The salary is " + salary);

        }

    }
}
