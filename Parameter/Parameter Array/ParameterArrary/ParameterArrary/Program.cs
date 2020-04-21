using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterArrary
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            double[] doubleArray = new double[] { 1, 2, 3 };
            double result = CalculateSum(doubleArray);
            Console.WriteLine(result);
        }
        static double CalculateSum(double[] doubleArray)
        {
            double sum = 0;
            foreach (var item in doubleArray)
            {
                sum += item;
            }
            return sum;
        }
        */
        static void Main(string[] args)
        {
            double result = CalculateSum(1, 2, 3);
            Console.WriteLine(result);
        }

        static double CalculateSum(params double[] doubleArray)
        {
            double sum = 0;
            foreach (var item in doubleArray)
            {
                sum += item;
            }
            return sum;
        }
    }
}
