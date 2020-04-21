using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> x = null;
            //Return Ture.
            Console.WriteLine(x.HasValue);
            x = 100;
            //Return Ture.
            Console.WriteLine(x.HasValue);

            int? y = null;

            int z = y ?? 1;
            //Return 1.
            Console.WriteLine(y);
        }
    }
}
