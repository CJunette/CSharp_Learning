using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student stu1 = new Student();
            
            Student stu2 = new Student(1, "No Name");

            Console.WriteLine(stu1.ID);
            Console.WriteLine(stu1.Name);

            Console.WriteLine(stu2.ID);
            Console.WriteLine(stu2.Name);

        }
    }

    class Student
    {
        //This is the constructor!
        //It does not require the type of return value.
        //The name for the method must be exactly same as the name of the class.
        //A faster way to create a constructor in vs is to type "ctor" and hit tab twice.

        public Student()
        {
            this.ID = 1;
            this.Name = "No Name";
        }
        

        //Create a constructor that requires inputs to fulfill the parameters in the class.
        //Constructor with parameters could co-exist with the constructor without parameter.

        public Student(int initID, string initName)
        {
            this.ID = initID;
            this.Name = initName;
        }


        public int ID;
        public string Name;
    }
}
