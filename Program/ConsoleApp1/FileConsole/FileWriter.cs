using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConsole
{
    class FileWriter
    {
        public static void WriteFile()
        {
            string path = "F:\\CSharp\\AAA\\AAA.txt";
            string content = "Hello world!!" + Environment.NewLine;

            File.WriteAllText(path, content);
        }

        public static void AppendFile()
        {
            string path = "F:\\CSharp\\AAA\\AAA.txt";
            string content = "Hello world!!" + Environment.NewLine;

            File.AppendAllText(path, content);
        }


    }
}
