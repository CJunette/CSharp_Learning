using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference_parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 1;
            y = SideEffect(ref y);
            Console.WriteLine(y);

            string b = "apple";
            Console.WriteLine("HashCode: {0}, String: {1}.", b.GetHashCode(), b);
            Console.WriteLine();
            SideEffects(ref b);
            Console.WriteLine("HashCode: {0}, String: {1}.", b.GetHashCode(), b);
        }

        static int SideEffect(ref int x)
        {
            return x + 100;
        }
        static string SideEffects(ref string a)
        {
            a = a + "s";
            Console.WriteLine("HashCode: {0}, String: {1}.", a.GetHashCode(), a);
            return a;
        }
    }

}
