using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Action act = new Action(calc.Report);

            calc.Report();
            act.Invoke();
            act();

            Func<int, int, int> func1 = new Func<int, int, int>(calc.Add);
            Func<int, int, int> func2 = new Func<int, int, int>(calc.Sub);

            Console.WriteLine(func1.Invoke(1, 2));
            Console.WriteLine(func2(2, 3));            
        }
    }

    class Calculator
    {
        public void Report()
        {
            Console.WriteLine("I have 3 methods.");
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
