using System;
using System.Collections.Generic;
using System.Text;
using MyLib.MyNamespace;

namespace MyLib.TestInternal
{
    public class Test
    {
        public void ShowStudent()
        {
            Student stu = new Student();
            Console.WriteLine(stu.ID);
        }
    }
}

