using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string, int> act1 = new Action<string, int>(SayHello);
            act1("Tom", 5);

            Func<int, int, int> func1 = new Func<int, int, int>(Add);
            Console.WriteLine(func1(1, 2));
            Func<double, double, double> func2 = new Func<double, double, double>(Mul);
            Console.WriteLine(func2(3.4, 2.3));
        }

        static void SayHello(string Name, int round)
        {
            for (int i = 0; i < round; i++)
            {
                Console.WriteLine($"Hello {Name}.");
            }
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static double Mul(double a, double b)
        {
            return a * b;
        }
    }
}
