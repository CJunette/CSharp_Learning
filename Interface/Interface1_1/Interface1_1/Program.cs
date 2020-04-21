using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

//This is the case where we do not have interface.
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

        //To meet different purposes with different data types, we need all together 4 methods.
        static int Sum(int[] num)
        {
            int sum = 0;
            foreach (var n in num)
            {
                sum += n;
            }
            return sum;
        }

        static double Avg(int[] num)
        {
            double sum = 0;
            int count = 0;
            foreach (var n in num)
            {
                sum += n;
                count += 1;
            }
            return sum / count;
        }

        static int Sum(ArrayList num)
        {
            int sum = 0;
            foreach (var n in num)
            {
                sum += (int)n;
            }
            return sum;
        }

        static double Avg(ArrayList num)
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
