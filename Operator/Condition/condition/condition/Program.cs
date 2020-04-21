using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            string a = string.Empty;

            if (x > 60)
            {
                a = "Pass!";
            }
            else
            {
                a = "Fail!";
            }

            //Codes above equals to codes blow.
            a = (x >= 60) ? "Pass!" : "Fail?";
        }
    }
}
