using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConsole
{
    class FolderReader
    {
        public static void ListFolder()
        {
            string folderPath = "F:\\CSharp";

            string[] array = Directory.EnumerateFiles(folderPath).ToArray();

            Console.WriteLine("Read folder: " + folderPath);

            foreach(string fileName in array)
            {
                Console.WriteLine(fileName);
            }
        }

        public static void ListFolder2()
        {
            string folderPath = "F:\\CSharp\\BBB";

            string[] array = Directory.EnumerateFiles(folderPath).ToArray();

            Console.WriteLine("Read folder: " + folderPath);

            foreach (string fileName in array)
            {
                Console.WriteLine(fileName);
            }
        }

        public static void AddFolder()
        { 
            string folderPath = "F:\\CSharp\\BBB";

            Directory.CreateDirectory(folderPath);
        }
    }
}
