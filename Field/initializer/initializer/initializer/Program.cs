using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initializer
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is initialization
            int i = 100;

            //This is create a variable, then assign a value to this variable. It is different from initialization!
            int j;
            j = 100;
        }
    }

    class Student
    {
        //Initialize instance field.
        public int Age = 20;
        //Initialize instance field with constructor. This is the same as the way above.
        public Student()
        {
            this.Age = 20;
        }

        //Initialize static field.
        public static int AverageAge = 20;
        //Initialize static field with constructor. This is the same as the way above.
        static Student()
        {
            Student.AverageAge = 20;
        }

        //For readonly field.
        public readonly int ID = 1;
        public Student(int id)
        {
            this.ID = id;
        }
    }
}
