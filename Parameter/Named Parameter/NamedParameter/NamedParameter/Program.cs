using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo(age: 7, name: "Konan");
        }
        static void PrintInfo(string name, int age)
        {
            Console.WriteLine("Name is {0}, age is {1}.", name, age);
        }
    }
}
