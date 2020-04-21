using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student stu1 = new Student();
                stu1.Age = 20;

                Student stu2 = new Student();
                stu2.Age = 20;

                Student stu3 = new Student();
                stu3.Age = 200;

                int avgAge = (stu1.Age + stu2.Age + stu3.Age) / 3;
                Console.WriteLine("Average age is {0}", avgAge);

                Student.Amount = -100;
                Console.WriteLine("Student amount is {0}.", Student.Amount);
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

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.age = value;
                }
                else
                {
                    throw new Exception("Warning! Age value has error.");
                }
            }
        }

        private static int amount;

        public static int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value >= 0)
                {
                    amount = value;
                }
                else
                {
                    throw new Exception("Warning! Amount must be greater than 0.");
                }
            }
        }
        
        private int className;
        public int ClassName
        {
            get
            {
                return className;
            }
            //Private set could only use method in the same class to set the value;
            private set
            {
                className = value;
            }            
        }
        public void ChangeClassName(int newvalue)
        {
            this.ClassName = newvalue;
        }
    }
}
