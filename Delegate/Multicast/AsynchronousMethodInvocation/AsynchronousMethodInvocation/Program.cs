using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsynchronousMethodInvocation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, PenColor = ConsoleColor.Red };
            Student stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Green };
            Student stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Blue };

            Action act1 = new Action(stu1.DoingHomework);
            Action act2 = new Action(stu2.DoingHomework);
            Action act3 = new Action(stu3.DoingHomework);

            
            //Implicit asynchronous invocation.            
            act1.BeginInvoke(null, null);
            act2.BeginInvoke(null, null);
            act3.BeginInvoke(null, null);
            

            /*
            //Explicit asynchronous invocation with "Thread".
            Thread trd1 = new Thread(new ThreadStart(stu1.DoingHomework));
            Thread trd2 = new Thread(new ThreadStart(stu2.DoingHomework));
            Thread trd3 = new Thread(new ThreadStart(stu3.DoingHomework));
            trd1.Start();
            trd2.Start();
            trd3.Start();
            */

            /*
            //Explicit asynchronous invocation with "Task".
            Task tsk1 = new Task(new Action(stu1.DoingHomework));
            Task tsk2 = new Task(new Action(stu2.DoingHomework));
            Task tsk3 = new Task(new Action(stu3.DoingHomework));
            tsk1.Start();
            tsk2.Start();
            tsk3.Start();
            */

            //Main thread
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Mainthread {0}", i);
                Thread.Sleep(100);
            }
            //Codes above will cause the problem that different threads ask for the same resource(here it is the Console.ForegroundColor).
            //As a result, the color of different Console.Writeline() does not follow the way it is set in method "DoingHomework()".
            //A way to solve it is to lock thread.

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
