using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

//This is the case where we use the interface "IEnumerable" to simplify the program.
namespace Interface1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = new int[] { 1, 2, 3, 4, 5 };
            ArrayList num2 = new ArrayList { 1, 2, 3, 4, 5 };
            Console.WriteLine(Sum(num1));
            Console.WriteLine(Avg(num1));
            Console.WriteLine(Sum(num2));
            Console.WriteLine(Avg(num2));
        }
        
        //IEnumerable is the interface of both ArrayList(whose base type is array) and int[].
        static int Sum(IEnumerable num)
        {
            int sum = 0;
            foreach (var n in num)
            {
                //Because the member of ArrayList is object, we still have to use the type convert to ensure the data type is right.
                sum += (int)n;
            }
            return sum;
        }

        static double Avg(IEnumerable num)
        {
            double sum = 0;
            int count = 0;
            foreach (var n in num)
            {
                sum += Convert.ToDouble(n);
                count += 1;
            }
            return sum / count;
        }
    }
}
