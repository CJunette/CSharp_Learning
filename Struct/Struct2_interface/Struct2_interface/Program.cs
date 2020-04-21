using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is an example that shows the struct could have an interface base.
//But struct could not be derivated from a base class.
namespace Struct2_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, Name = "Steve" };
            stu1.Speak();
        }
    }

    interface ISpeak
    {
        void Speak();
    }

    struct Student : ISpeak
    {
        //结构体不允许有无参构造器。即如果写了构造器就必须有参数输入。
        //当然结构体允许有参构造器，或者不写构造器。
        public Student(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public void Speak()
        {
            Console.WriteLine($"I'm Student #{this.ID} {this.Name}");
        }
    }

    
}
