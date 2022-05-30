using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_5_Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDir(new DirectoryInfo(@"E:\Test"), " ", true);
            Console.ReadKey();
        }
        static void PrintDir(DirectoryInfo dir, string indent, bool lastDirectory)
        {
            Console.Write(indent);
            Console.Write(lastDirectory ? "└─" : "├─");
            indent += lastDirectory ? " " : "│ ";
            Console.WriteLine(dir.Name);
            FileInfo[] subFiles = dir.GetFiles();
            for (int i = 0; i < subFiles.Length; i++)
            {
                if (i == subFiles.Length - 1)
                {
                    Console.Write($"{indent}└─{subFiles[i].Name}\n");
                }
                else
                {
                    Console.Write($"{indent}├─{subFiles[i].Name}\n");
                }
            }
            DirectoryInfo[] subDir = dir.GetDirectories();
            for (int i = 0; i < subDir.Length; i++)
            {
                PrintDir(subDir[i], indent, i == subDir.Length - 1);
            }
        }
    }
}



