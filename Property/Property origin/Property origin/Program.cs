using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_origin
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student stu1 = new Student();
                stu1.SetAge(20);

                Student stu2 = new Student();
                stu2.SetAge(20);

                Student stu3 = new Student();
                stu3.SetAge(200);

                int avgAge = (stu1.GetAge() + stu2.GetAge() + stu3.GetAge()) / 3;
                Console.WriteLine("Average age is {0}.", avgAge);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Student
    {
        private int age;

        public int GetAge()
        {
            return this.age;
        }

        public void SetAge(int value)
        {
            if (value >= 0 && value <= 120)
            {
                this.age = value;
            }
            else
            {
                throw new Exception("Age value has error.");
            }
        }
    }
}
