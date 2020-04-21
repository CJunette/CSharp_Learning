using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @do
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int sum;
            do
            {
                sum = 0;
                Console.WriteLine("Please input the first number.");
                string str1 = Console.ReadLine();

                if (str1.ToLower() == "end")
                {
                    break;
                }

                int x = 0;

                try
                {
                    x = int.Parse(str1);
                }
                catch
                {
                    Console.WriteLine("First input has problem. Please restart");
                    score = 0;
                    sum = 100;
                    continue;
                }


                Console.WriteLine("Please input the second number.");
                string str2 = Console.ReadLine();

                if (str1.ToLower() == "end")
                {
                    break;
                }

                int y = 0;

                try
                {
                    y = int.Parse(str2);
                }
                catch
                {
                    Console.WriteLine("Second input has problem. Please restart");
                    score = 0;
                    sum = 100;
                    continue;
                }


                sum = x + y;
                Console.WriteLine("{0} + {1} = {2}", x, y, sum);
                if (sum == 100)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Error!");                    
                }                                
            } while (sum == 100);

            Console.WriteLine("Your score is {0}", score);
        }
    }
}
