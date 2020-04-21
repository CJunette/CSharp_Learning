using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_as_a_decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.report();
            CsStudent csstu = new CsStudent();
            csstu.report();
        }
    }

    class Student
    {
        public void report()
        {
            Console.WriteLine("I'm a student!");
        }
    }

    class CsStudent : Student
    {
        //Here "new" is a decorator instead of a operator.
        new public void report()
        {
            Console.WriteLine("I'm a CS student!");
        }
    }
}
