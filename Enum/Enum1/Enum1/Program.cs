using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is an example shows Enum and the value of its object.
namespace Enum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person employee = new Person();
            employee.Level = Rank.Employee;

            Person boss = new Person();
            boss.Level = Rank.Boss;

            Console.WriteLine(boss.Level > employee.Level);

            Console.WriteLine((int)Rank.Employee);
            Console.WriteLine((int)Rank.Manager);
            Console.WriteLine((int)Rank.Boss);
        }
    }

    enum Rank
    {
        Employee = 10,
        Manager,
        Boss = 30,
    }

    class Person
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public Rank Level { get; set; }
    }
}
