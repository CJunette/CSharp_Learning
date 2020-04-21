using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int x = 1;
            int y = 2;
            int z;

            Calc calc1 = new Calc(calculator.Add);
            Calc calc2 = new Calc(calculator.Sub);
            Calc calc3 = new Calc(calculator.Mul);
            Calc calc4 = new Calc(calculator.Div);

            Console.WriteLine(calc1.Invoke(x, y));
            Console.WriteLine(calc2.Invoke(x, y));
            Console.WriteLine(calc3.Invoke(x, y));
            Console.WriteLine(calc4.Invoke(x, y));
        }
    }

    public delegate double Calc(double x, double y);

    class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public double Mul(double x, double y)
        {
            return x * y;
        }

        public double Div(double x, double y)
        {
            return x / y;
        }
    }
}
