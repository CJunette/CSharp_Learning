using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SynchronousMethodInvocation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, PenColor = ConsoleColor.Red };
            Student stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Green };
            Student stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Blue };

            //Synchronous direct invocation;
            stu1.DoingHomework();
            stu2.DoingHomework();
            stu3.DoingHomework();

            //Synchronous indirect invocation;
            Action act1 = new Action(stu1.DoingHomework);
            Action act2 = new Action(stu2.DoingHomework);
            Action act3 = new Action(stu3.DoingHomework);
            act1.Invoke();
            act2.Invoke();
            act3.Invoke();

            //Multicast synchronous indirect invocation            
            act1 += act2;
            act1 += act3;
            act1.Invoke();

            //Main thread
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Mainthread {0}", i);
                Thread.Sleep(100);
            }
        }
    }

    class Student
    {
        public int ID { get; set; }
        public ConsoleColor PenColor { get; set; }

        public void DoingHomework()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = PenColor;
                Console.WriteLine("Student {0} is doing homework for {1} hour(s).", ID, i);
                Thread.Sleep(100);
            }
        }
    }
}
