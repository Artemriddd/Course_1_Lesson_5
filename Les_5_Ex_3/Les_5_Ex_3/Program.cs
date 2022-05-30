using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_5_Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Byte.bin";
            string number = Console.ReadLine();
            string[] numbers = number.Split(' ');
            Byte[] b = new byte[numbers.Length];
            int i = 0;
            int j = 0;
            foreach (string str in numbers)
            {
                b[i] = byte.Parse(str);
                i++;
            }
            i = 0;
            File.WriteAllBytes(name, b);
            byte[] fromfile = File.ReadAllBytes("Byte.bin");
            foreach(byte bar in fromfile)
            {
                Console.Write(fromfile[i]+" ");
                i++;
            }
            Console.ReadKey(true);
        }
    }
}

