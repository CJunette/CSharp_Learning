using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace block
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //labeled statement
                hello: Console.WriteLine("hello world");
                //declaration statement
                int x;
                //embedded statement (expression statement - assignment)
                x = 100;

                //The using of labeled statement. This will cause an infinitive loop.
                goto hello;
            }
        }
    }
}
