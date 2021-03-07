using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = args[0];

            Console.WriteLine(System.IO.File.ReadAllText(a));
        }
    }
}
