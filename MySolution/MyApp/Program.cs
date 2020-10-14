using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Branches and Courses Available Details\n");
            //Console.WriteLine("Name     Fee     Increase(%)");
            //Console.WriteLine("Java     56          0");
            //Console.WriteLine("HDJ      80         20");
            //Console.WriteLine("XML      70         -2");
            //Console.WriteLine("c#       60         10");
            //Console.ReadLine();
            string name;
            uint age;
            String gender;
            DateTime birthday;
            string address;
            string email;
            string fatherName;
            string motherName;

            //Nhap thong tin
            Console.WriteLine("Enter information :");
            Console.WriteLine("-------*****-------");
            Console.Write("Enter student name :");
            name = Console.ReadLine();
            Console.Write("Enter gender (male/female):");
            gender = Console.ReadLine();
            Console.Write("Enter age:");
            age = uint.Parse(Console.ReadLine());
            Console.Write("Enter birthday (MM/dd/yyyy) :");
            birthday = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter address");
            address = Console.ReadLine();

            Console.Write("Enter mail: ");
            email = Console.ReadLine();
            Console.Write("Enter father name: ");
            fatherName = Console.ReadLine();
            Console.Write("Enter mother name: ");
            motherName = Console.ReadLine();
            // output
            Console.WriteLine("*** Student infomation ***\n");
            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Student age: " + age);
            Console.WriteLine("Student gender: " + gender);
            Console.WriteLine("DOB: {0:D}", birthday);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Student's father name: " + fatherName);
            Console.WriteLine("Student's mother name: " + motherName);
            Console.ReadLine();
        }
    }
}
