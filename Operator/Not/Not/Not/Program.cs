using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student(null);
        }
    }

    class Student
    {
        public Student(string initName)
        {
            if (!string.IsNullOrEmpty(initName))
            {
                this.Name = initName;
            }
            else
            {
                throw new ArgumentException("initName could not be null or empty");
            }
        }
        public string Name;
    }
}
