using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_as
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human();

            //Return True.
            var x1 = h is Human;
            //Return True.
            var x2 = h is Animal;
            //Return False.
            var x3 = h is Teacher;

            Object o = new Teacher();
            //If "o" is "teacher", give address of the instance of "o" to t. Else return null to t.
            Teacher t = o as Teacher;
        }
    }

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    class Human : Animal
    {
        public void Think()
        {
            Console.WriteLine("Who am I?");
        }
    }

    class Teacher : Human
    {
        public void Teach()
        {
            Console.WriteLine("I'm a teacher, I teach programming.");
        }
    }

    class Car
    {
        public void CarRun()
        {
            Console.WriteLine("I'm a car, I run on the street.");
        }
    }
}
