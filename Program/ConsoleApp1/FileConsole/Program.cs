using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "F:\\CSharp\\";
            //string path = "Fake\\";
            string fileName = "AAA.txt";


            // Read file
            string content = TestFileReader.ReadFile(path + fileName);

            // Append File
            string content2 =
                "Hello world!!";
            TestFileReader.Append(path + fileName, content2);

            TestFolderReader.ListAllFile(path);
            TestFolderReader.CreateFolder(path + "Temp");
            TestFolderReader.DeleteFolder(path + "Temp");


            string newPath = "F:\\CSharp\\aaa.txt";

            // "F:\\CSharp\\aaa.txt"
            Console.WriteLine(System.IO.Path.Combine("F:\\CSharp", "aaa.txt"));

            //F:\\CSharp
            Console.WriteLine(System.IO.Path.GetDirectoryName(newPath));

            // aaa.txt
            Console.WriteLine(System.IO.Path.GetFileName(newPath));

            Console.ReadLine();
        }

    }
}
