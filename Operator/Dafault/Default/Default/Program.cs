using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Default
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = default(int);
            Console.WriteLine("The default value is " + x);
            Console.WriteLine();

            Form myForm = default(Form);
            Console.WriteLine("Is the default value for Form is null? " + (myForm == null));
            Console.WriteLine();

            //The default vaule for enum is decided by the numeric order. The first value is the default value.
            Level1 l1 = default(Level1);
            Console.WriteLine("The default value is " + l1);
            Console.WriteLine();

            //The default vaule for enum could be changed by giving different values to different levels.
            Level2 l2 = default(Level2);
            Console.WriteLine("The default value is " + l2);
            Console.WriteLine();

            //If the levels in enum does not have a value of "0", there will be a problem.
            Level3 l3 = default(Level3);
            Console.WriteLine("The default value is " + l3);
            Console.WriteLine();

        }
    }

    enum Level1
    {
        Low,
        Mid,
        High
    }

    enum Level2
    {
        Low = 1,
        Mid = 0,
        High = 2
    }

    enum Level3
    {
        Low = 1,
        Mid = 2,
        High = 3
    }
}
