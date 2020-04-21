using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Lambda is
//1.anonymous method
//2.inline method
//It is used because we don't want to create too many methods that is only used once for some unimportant purpose.
namespace Lambda1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lambda expression is "(int a, int b) => { return a + b; }".
            Func<int, int, int> func1 = new Func<int, int, int>((int a, int b) => { return a + b; });
            Console.WriteLine(func1(12, 10));

            func1 = new Func<int, int, int>((a, b) => { return a - b; });
            Console.WriteLine(func1(12, 10));

            func1 = (a, b) => { return a * b; };
            Console.WriteLine(func1(12, 10));

            Calc<double>((double x, double y) => { return x / y; }, 12, 10);
            //This are some simplified versions.
            /*
            Calc((x,  y) => { return x / y; }, 12, 10.0);
            
            Calc((x,  y) => x / y, 12, 10.0); 
            */

            Func<int> func2 = () => 0;            
            Console.WriteLine(func2());
        }

        static void Calc<T>(Func<T, T, T> func, T x, T y)
        {
            T result = func(x, y);
            Console.WriteLine(result);
        }
    }
}
