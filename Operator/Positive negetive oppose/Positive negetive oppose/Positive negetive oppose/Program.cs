using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positive_negetive_oppose
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12345678;
            //To get the opposite number of a certain number, we need to oppose the number bit by bit in binary and plus 1.
            int y = ~x;
            Console.WriteLine(x);
            Console.WriteLine(y);
            string xStr = Convert.ToString(x, 2).PadLeft(32, '0');
            string yStr = Convert.ToString(y, 2).PadLeft(32, '0');
            Console.WriteLine(xStr);
            Console.WriteLine(yStr);
            Console.WriteLine();

            //The opposite value for the MinValue is itself.
            //In detail, the MinValue in binary is always 1000...000, and opposing number bit by bit gets 0111...111, plus 1 equals 1000...000.
            int a = int.MinValue;
            Console.WriteLine(a);
            int b = -a;
            Console.WriteLine(b);
            string aStr = Convert.ToString(a, 2).PadLeft(32, '0');
            Console.WriteLine(aStr);

        }
    }
}
