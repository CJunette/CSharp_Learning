using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.HelloWorld();
            Student.HelloYou();
        }
    }

    class Student
    {
        public void HelloWorld()
        {
            Console.WriteLine("hello world!");
        }

        public static void HelloYou()
        {
            Console.WriteLine("hello you!");
        }
    }
}
