using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is an example of the binary usage of Enum.
namespace Enum2_the_binary_usage
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tim = new Person() { Name = "Timothy" };
            //"tim.skill" in binary is 1111.
            tim.Skill = Skill.Cook | Skill.Drive | Skill.Program | Skill.Teach;
            Console.WriteLine((tim.Skill & Skill.Cook) == Skill.Cook);
            Console.WriteLine((tim.Skill & Skill.Drive) == Skill.Drive);
            Console.WriteLine((tim.Skill & Skill.Program) == Skill.Program);
            Console.WriteLine((tim.Skill & Skill.Teach) == Skill.Teach);
        }
    }

    enum Skill
    {
        //Binary 0001
        Cook = 1,
        //Binary 0010
        Drive = 2,
        //Binary 0100
        Program = 4,
        //Binary 1000
        Teach = 8,
    }

    class Person
    {
        public string Name { get; set; }
        public Skill Skill { get; set; }
    }
}
