using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]
            {
                1,2,3,4,5,6
            };

            Process(array);
            Process(null);

            Console.Read();
        }

        static void Process(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException();

            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("  " + arr[i]);
                }
            }
        }
    }
}
