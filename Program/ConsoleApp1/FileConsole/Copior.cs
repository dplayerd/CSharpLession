using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConsole
{
    class Copior
    {
        public static void CopyFile()
        {
            string sourcePath = "F:\\CSharp\\AAA.txt";
            string targetPath = "F:\\CSharp\\BBB.txt";

            System.IO.File.Copy(sourcePath, targetPath);
        }
    }
}
