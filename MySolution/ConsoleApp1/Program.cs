using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** FUNNN ********");
            //create a new dirInfo obj
            DirectoryInfo dir = new DirectoryInfo(@"E:\Learning\2020_SUMMER\SWE102\");
            // dump dir info
            Console.WriteLine("***** DIR INFO *********");
            Console.WriteLine("Full name: " + dir.FullName);
            Console.WriteLine("Name: " + dir.Name);
            Console.WriteLine("Parent: " + dir.Parent);
            Console.WriteLine("Creation: " + dir.CreationTime);
            Console.WriteLine("Attributes: " + dir.Attributes);
            Console.WriteLine("Root: " + dir.Root);
            Console.WriteLine("**************");

            #region List stats on all *txt file
            FileInfo[] files = dir.GetFiles("*.txt");
            Console.WriteLine("Found " + files.Length + " files");
            foreach (FileInfo f in files)
            {
                Console.WriteLine("**************");
                Console.WriteLine("File name: " + f.Name);
                Console.WriteLine("File size: " + f.Length);
                Console.WriteLine("Creation: " + f.CreationTime);
                Console.WriteLine("Attributes: " + f.Attributes);
                Console.WriteLine("*************");
            }
            #endregion
            #region
            // make dir on root
            DirectoryInfo d = dir.CreateSubdirectory("MyNotee");
            Console.WriteLine("Created: " + d.FullName);
            // create \ \ \
            d = dir.CreateSubdirectory(@"Mynoo\Mynot");
            Console.WriteLine("Created: " + d.FullName);
            #endregion
        }
    }
}
