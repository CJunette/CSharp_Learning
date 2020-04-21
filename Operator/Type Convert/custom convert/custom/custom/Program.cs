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
            Stone s = new Stone();
            s.Age = 5000;
            Monkey m = (Monkey)s;
            Console.WriteLine(m.Age);            
        }
    }

    class Stone
    {
        public int Age;

        //Custom convert.
        //"explicit" and "implicit" are both ok.
        public static explicit operator Monkey(Stone stone)
        {
            Monkey monkey = new Monkey();
            monkey.Age = stone.Age / 100;
            return monkey;
        }
    }

    class Monkey
    {
        public int Age;
    }
}
