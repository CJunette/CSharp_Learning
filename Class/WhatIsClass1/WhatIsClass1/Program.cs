using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            //正常的做法
            Student stu1 = new Student(1, "江戸川コナン");
            stu1.Report();
            

            //Reflection 反射（未来会详细讲，这里为了展示如何不用“new”操作符来实现“Student”类型实例的的创建）            
            Type t = typeof(Student);
            object o = Activator.CreateInstance(t, 1, "江戸川コナン");
            Student stu2 = o as Student;
            Student stu3 = (Student)o;
            //Though there are 2 variables ,there will be only 1 destructor, because only 1 instance(which is o) is created.
            Console.WriteLine(stu2.Name);
            Console.WriteLine(stu3.ID);

            //Dynamic programming 动态编程（未来会讲）
            dynamic stu = Activator.CreateInstance(t, 1, "江戸川コナン");
            Console.WriteLine(stu.Name);

            //Though there are 4 variables all together, there are only 3 instances.
            Console.WriteLine($"The number of student is {Student.Amount}.");

            Console.WriteLine();
        }
    }

    class Student
    {
        public string  Name { get; set; }
        public int ID { get; set; }
        public void Report()
        {
            Console.WriteLine($"I am student #{ID}. My name is {Name}");
        }

        public static int Amount { get; set; }
        static Student()
        {
            Amount = 0;
        }

        public Student(int id, string name)
        {
            this.ID = id;
            this.Name = name;
            //Amount is used to calculate the number of instances, not the number of Student variables.
            Amount++;
        }

        //Destructor 析构器
        ~Student()
        {
            Amount--;
            Console.WriteLine($"The number of student is {Amount}.");
            Console.WriteLine("Bye bye! Release teh system resources...");
        }
    }
}
