using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class TextParseNumber
    {
        public static int StringToInt(string source)
        {
            if (string.IsNullOrWhiteSpace(source))
                throw new FormatException("input should be an int format text.");

            int temp;
            if (!int.TryParse(source, out temp))
                throw new FormatException("input should be an int format text.");
            
            return temp;
        }
    }
}
