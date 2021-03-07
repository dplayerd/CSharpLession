using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConsole
{
    class FileReader
    {
        public static void ReadFile()
        {
            string content = File.ReadAllText("F:\\CSharp\\AAA.txt");
            Console.WriteLine(content);
        }

        public static void ReadFile2()
        {
            string content = File.ReadAllText("F:\\CSharp\\BBB.txt");
            Console.WriteLine(content);
        }
    }
}
