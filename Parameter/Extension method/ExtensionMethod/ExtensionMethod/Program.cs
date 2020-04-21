using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.1415926;
            double y = Math.Round(x, 4);
            double z = x.Round(4);
        }
    }
    static class DoubleExtension
    {
        public static double Round(this double input, int digit)
        {
            double result = Math.Round(input, digit);
            return result;
        }
    }
}
