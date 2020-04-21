using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom
{
    class Program
    {
        static void Main(string[] args)
        {
            DateAdd d1 = new DateAdd();
            DateAdd d2 = new DateAdd();
            d1.Date = 5;
            d2.Date = 27;
            DateAdd d3 = d1 + d2;
            Console.WriteLine(d3.Date);
        }
    }

    class DateAdd
    {
        public int Date;

        //This is the same as 
        //public static DateAdd Add(DateAdd d1, DateAdd d2)
        public static DateAdd operator +(DateAdd d1, DateAdd d2)
        {
            DateAdd d3 = new DateAdd();
            int sum = (d1.Date + d2.Date) % 30;
            d3.Date = sum;
            return d3;
        }
    }
}
