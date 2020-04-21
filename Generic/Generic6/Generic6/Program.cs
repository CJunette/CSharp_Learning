using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is an example shows the lambdt expression.
namespace Generic6
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> func1 = (a, b) => a + b;
            var value = func1(200, 200);
            Console.WriteLine(value);
        }
    }
}
