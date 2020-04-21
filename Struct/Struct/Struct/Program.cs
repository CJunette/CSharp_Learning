using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This example shows what is struct.
namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, Name = "Steve" };
            //The copy of a struct instance is is to do the copy on stack.
            Student stu2 = stu1;
            //As this is another copy, the value change won't affect stu1.
            stu2.Name = "Tim";
            stu2.ID = 2;
            Console.WriteLine($"Student #{stu1.ID} Name: {stu1.Name}");


            Teacher tea1 = new Teacher() { ID = 1, Name = "Steve" };
            //The copy of a class is to let the variable point to the instance on heap.
            Teacher tea2 = tea1;
            //As this is the same instance on heap, the value change will affect tea1.
            tea2.Name = "Tim";
            tea2.ID = 2;
            Console.WriteLine($"Student #{tea1.ID} Name: {tea1.Name}");

        }
    }

    //The instance of "struct" is on the stack.
    struct Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    //The instance of class is on the heap.
    class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
