using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = GetCylinderVolume(10, 100);
            Console.WriteLine(result);
        }

        static double GetCylinderVolume(double radius, double height)
        {
            double area = 3.1415926 * radius * radius;
            double volume = area * height;
            return volume;
        }
    }
}
