using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input A");
            //string a = Console.ReadLine();
            
            //Console.WriteLine("Input B");
            //string b = Console.ReadLine();

            //int intA = Convert.ToInt32(a);
            //int intB = Convert.ToInt32(b);

            //Console.WriteLine("A+B =" + (intA + intB));
            //Console.ReadLine();


            //string msg;
            //Add(51, out msg);

            //Console.WriteLine(msg);

            Method2();
        }

        public static int Add(int a)
        {
            if (a > 50)
                throw new Exception("Can't more than 50.");

            return 0;
        }

        public static void Method2()
        {
            try
            {
                Method1(200, 100);
            }
            catch (Exception ex)
            {
                // Log to file
                throw;
            }
        }

        public static void Method1(int a, int b)
        {
            if (a > 50 || b > 40)
                throw new Exception();
        }

        public static int Add(int a, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (a > 50)
            {
                errorMessage = "Can't more than 50";
                return 0;
            }    

            return 0;
        }
    }
}
