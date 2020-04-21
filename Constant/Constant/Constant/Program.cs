using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ID = 1;
        }
    }

    class Student
    {
        const int ID = 0;

        //We can't declare const with customized class. The only way is to create a static readonly field.
        static readonly Teacher tea = new Teacher(5);
    }

    class Teacher
    {
        public Teacher(int id)
        {
            this.ID = id;
        }
        public int ID;
    }
}
