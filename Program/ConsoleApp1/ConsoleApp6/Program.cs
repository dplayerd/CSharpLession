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
            Console.WriteLine("App 6");

            int result = MathCore.Add(5, 6);
            Console.WriteLine("5 + 6 =" + result);

            Console.ReadLine();


#if DEBUG
            Console.WriteLine(1);
#endif


#if RELEASE
            Console.WriteLine(2);
#endif
        }

        //private 
        //protected
        //internal
        //public 

        static void GOGOGO()
        {
            int result = MathCore.Add(5, 6);
        }
    }
}
