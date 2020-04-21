using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbreviation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.Name = "deer";
            person2.Name = "doe";

            //"GetMarried" could be replaced with "+"
            /*
            List<Person> nation = person1 + person2;
            */
            List<Person> nation = Person.GetMarried(person1, person2);

            foreach (var person in nation)
            {
                Console.WriteLine(person.Name);
            }
            
        }
    }

    class Person
    {
        public string Name;

        //"GetMarried" could be replaced with "operator +"
        /*
        public static List<Person> operator +(Person p1, Person p2) 
        */
        public static List<Person> GetMarried(Person p1, Person p2)
        {
            List<Person> people = new List<Person>();
            people.Add(p1);
            people.Add(p2);

            for (int i = 0; i < 11; i++)
            {
                Person child = new Person();
                child.Name = p1.Name + " & " + p2.Name + "'s child";
                people.Add(child);
            }

            return people;
        }

    }

}
