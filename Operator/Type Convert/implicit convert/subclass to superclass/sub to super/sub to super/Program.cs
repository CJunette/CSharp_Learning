using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sub_to_super
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            Human h = t;
            Animal a = h;

            //"t" 作为子类变量，有所有3种方法。
            t.Eat();
            t.Think();
            t.Teach();

            //"h" 作为父类变量，本身只有2个成员，所以只能访问到2种方法。
            h.Eat();
            h.Think();

            //"a"作为父类变量，本身只有1个成员，所以只能访问到1种方法。
            a.Eat();
        }
    }

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    class Human: Animal
    {
        public void Think()
        {
            Console.WriteLine("Who am I?");
        }
    }

    class Teacher: Human
    {
        public void Teach()
        {
            Console.WriteLine("I'm a teacher, I teach programming.");
        }
    }
}
