using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 15;
            switch (score/10)
            {
                case 10:
                    if (score == 100)
                    {
                        goto case 9;
                    }
                    else
                    {
                        goto default;
                    }
                case 8:
                case 9:                
                    Console.WriteLine("A");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("B");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("C");
                    break;
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("D");
                    break;
                case 0:
                    if (score > 0)
                    {
                        goto case 1;
                    }
                    else
                    {
                        goto default;
                    }

                default:
                    Console.WriteLine("Error Input!");
                    break;
            }
        }
    }
}
