using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 3];

            foreach (int item in arr1)
            {
                Console.WriteLine(item);
            }
        }

    }
}
