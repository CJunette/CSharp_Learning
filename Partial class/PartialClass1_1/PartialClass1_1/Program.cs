using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This example shows how to use the partial Class.
namespace PartialClass1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.Hello();
            stu.World();
        }
    }

    partial class Student
    {
        public void Hello()
        {
            Console.WriteLine("Hello");
        }
    }
}
