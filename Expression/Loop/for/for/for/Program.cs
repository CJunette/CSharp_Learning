﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= a; b++)
                {                    
                    Console.Write("{0}*{1}={2}\t", a, b, a*b);
                }
                Console.WriteLine();
            }

        }
    }
}
