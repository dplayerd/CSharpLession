using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasureSpeed2
{
    class SleepHelper
    {
        /// <summary> 暫停程式數秒鐘 </summary>
        /// <param name="second"></param>
        public static void SleepAWhile(int second)
        {
            int ms = second * 1000;

            System.Threading.Thread.Sleep(ms);
        }
    }
}
