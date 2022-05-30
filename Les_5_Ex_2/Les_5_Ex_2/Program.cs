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
            string name = "startup.txt";
            DateTime dt = DateTime.Now;
            string time = dt.ToShortTimeString();
            File.AppendAllText(name, time);
            File.AppendAllText(name, Environment.NewLine);
        }
    }
}
