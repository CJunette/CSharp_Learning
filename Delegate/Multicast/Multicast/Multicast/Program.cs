using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multicast
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, Pencolor = ConsoleColor.Red};
            Student stu2 = new Student() { ID = 2, Pencolor = ConsoleColor.Green }; 
            Student stu3 = new Student() { ID = 3, Pencolor = ConsoleColor.Blue }; 

            Action act1 = new Action(stu1.DoHomework);
            Action act2 = new Action(stu2.DoHomework);
            Action act3 = new Action(stu3.DoHomework);

            act1 += act2;
            act1 += act3;

            act1.Invoke();
        }
    }

    class Student
    {
        public int ID { get; set; }
        public ConsoleColor Pencolor { get; set; }

        public void DoHomework()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = Pencolor;
                Console.WriteLine("Student {0} is doing homework for {1} hours.", ID, i);
                Thread.Sleep(100);
            }
        }
    }
}
