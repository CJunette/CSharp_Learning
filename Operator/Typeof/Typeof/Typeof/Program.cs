using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typeof
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(int);
            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.Name);
            Console.WriteLine();
                        
            foreach (var m in t.GetMethods())
            {
                Console.WriteLine(m.Name);
            }
            Console.WriteLine(t.GetMethods().Length);
        }
    }
}
