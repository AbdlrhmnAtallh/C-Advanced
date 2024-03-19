using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced
{
    internal class Recursion
    {
        public static void PrintDirectoryFileSystemEntries(string dirpath,int level)
        {
            foreach (var fileName in Directory.GetFiles(dirpath))
                Console.WriteLine($"{new string('-', level)} {new FileInfo(fileName).Name}");

            foreach (var dirName in Directory.GetDirectories(dirpath))
            {
                Console.WriteLine($"{new string('-', level)} {new DirectoryInfo(dirName).Name}");
                PrintDirectoryFileSystemEntries(dirName,level+1);
            }
                
        }
        public static long CalculateDirectorySize(string dirpath)
        {
            long Size = 0;
            foreach (var fileName in Directory.GetFiles(dirpath))
                Size += new FileInfo(fileName).Length;

            foreach (var dirName in Directory.GetDirectories(dirpath))
                Size += CalculateDirectorySize(dirName);
            return Size;
        }
        public static void Print(int size)
        {
            
            Console.WriteLine("Number "+size);
            if (size > 0)
                Print(size - 1);
        }
    }
}
