using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Calculator.Add(null, "3");
            Console.WriteLine(a);            
        }
    }

    class Calculator
    {
        public static int Add(string arg1, string arg2)
        {
            int a = 0;
            int b = 0;
            bool hasError = false;
            try
            {
                a = int.Parse(arg1);
                b = int.Parse(arg2);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
                hasError = true;
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                hasError = true;
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
                hasError = true;
            }
            finally
            {
                if (hasError)
                {
                    Console.WriteLine("Excution has error!");
                }
                else
                {
                    Console.WriteLine("Done!");
                }
            }


            int result = a + b;
            return result;
        }
    }
}
