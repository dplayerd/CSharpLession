using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt =
                DataBaseExecutor.ReadTestTable1DT();

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine("\t{0}\t{1}",
                    dr["ID"],
                    dr["Name"]
                );
            }

            Console.ReadLine();
        }
    }
}
