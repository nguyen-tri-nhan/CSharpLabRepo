using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********BINARYFILE");
            // open a binary writer or a file
            FileInfo f = new FileInfo("binfile.dat");
            BinaryWriter bw = new BinaryWriter(f.OpenWrite());
            // print out type
            Console.WriteLine("Base stream is " + bw.BaseStream);
            double adoub = 1234.67;
            int aInt = 34567;
            char[] aCharArr =
            {
                'A',
                'B',
                'C',
            };
            // Write data
            bw.Write(adoub);
            bw.Write(aInt);
            bw.Write(aCharArr);
            bw.Close();

            // read data
            BinaryReader br = new BinaryReader(f.OpenRead());
            int temp = 0;
            while(br.BaseStream.Position != br.BaseStream.Length)
            {
                Console.Write("{0,7:x} ", br.ReadByte());
                if(++temp == 4)
                {
                    Console.WriteLine();
                    temp = 0;
                }
            }
            Console.WriteLine();
        }
    }
}
