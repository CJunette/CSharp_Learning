using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndGeneric1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDele<int> deleAdd = new MyDele<int>(Add);
            int result1 = deleAdd(100, 200);
            Console.WriteLine("The result is {0}.", result1);
            Console.WriteLine(deleAdd.GetType());

            MyDele<double> deleMul = new MyDele<double>(Mul);

            double result2 = deleMul(300, 400);
            Console.WriteLine($"The result is {result2}.");
            Console.WriteLine(deleMul.GetType());            
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

    delegate T MyDele<T>(T a, T b);
}
