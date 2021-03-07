using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine(1);
#endif

#if RELEASE
            Console.WriteLine(2);
#endif
        }

    }
}
