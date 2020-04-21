using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDele dele1 = new MyDele(M1);
            int res1 = dele1(100, 200);
            Console.WriteLine(res1);
            dele1 += M2;
            int res2 = dele1(200, 300);
            Console.WriteLine(res2);
        }
        static int M1(int x, int y)
        {
            return x + y;
        }
        static int M2(int x, int y)
        {
            return x * y;
        }
    }

    delegate int MyDele(int x, int y);
}
