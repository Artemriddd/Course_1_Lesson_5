using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_5_Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "test.txt";
            File.WriteAllText(test, Console.ReadLine());
        }
    }
}
