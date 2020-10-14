using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWriteRead
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******FILE STREAM***********");
            FileStream fileStream = File.Open(@"E:\Learning\2020_SUMMER\SWE102\MyNotee\filetxt.dat", FileMode.Create);
            // encode a string
            string msg = "Hello word!";
            Console.WriteLine(msg);
            byte[] msgAsByte = Encoding.Default.GetBytes(msg);
            //write to file
            fileStream.Write(msgAsByte, 0, msgAsByte.Length);
            //rs internal pos
            fileStream.Position = 0;
            //read types from file and display
            byte[] byteFromFile = new byte[msgAsByte.Length];
            for(int i = 0; i < msgAsByte.Length; i++)
            {
                byteFromFile[i] = (byte)fileStream.ReadByte();
                Console.Write(byteFromFile[i]);
            }
            // display decode msg
            Console.WriteLine("\nDECODED");
            Console.WriteLine(Encoding.Default.GetString(byteFromFile));
            // close stream, del file
            fileStream.Close();
        }
    }
}
