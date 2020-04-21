using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace and_or
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int c = 5;
            if (a > b && b++ >= c)
            {
                Console.WriteLine("hello");
            }
            Console.WriteLine(b);
        }
    }
}
