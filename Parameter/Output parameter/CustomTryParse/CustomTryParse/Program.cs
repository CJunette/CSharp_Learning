using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "123";
            double? result;
            bool b = DoubleParser.TryParse(str, out result);
            if (b == true)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Input Error!");
            }
        }
    }

    class DoubleParser
    {
        public static bool TryParse(string str, out double? output)
        {
            try
            {
                output = double.Parse(str);
                return true;
            }
            catch
            {
                output = null;
                return false;
            }
        }
    }
}
