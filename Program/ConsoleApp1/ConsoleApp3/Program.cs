using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteInfo();
            WriteInfo();

            Console.WriteLine(Add(1, 3));
            Console.WriteLine(Add(5, 7));
        }

        static void WriteInfo()
        {
            Console.WriteLine("Hi! there~");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
