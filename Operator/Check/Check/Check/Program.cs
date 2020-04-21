using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    class Program
    {
        static void Main(string[] args)
        {
            uint x = uint.MaxValue;
            Console.WriteLine(x);
            string BinStr = Convert.ToString(x, 2);
            Console.WriteLine(BinStr);

            //Using "checked" could help to check whether a number is overflowed.
            try
            {
                //If "checked" is replaced with "unchecked", there will be no notice for overflow problem.
                //"unchecked" is the default mode.
                uint y = checked(x + 1);
                Console.WriteLine(y);
            }
            catch (OverflowException ex)
            {

                Console.WriteLine(ex.Message);
            }

            //This is another usage of "checked". Notice here the "check" is not an operator!!!
            checked
            {
                try
                {
                    uint y = x + 1;
                    Console.WriteLine(y);
                }
                catch (OverflowException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
