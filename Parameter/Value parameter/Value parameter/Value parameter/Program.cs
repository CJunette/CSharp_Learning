using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 100;
            AddOne(y);
            Console.WriteLine(y);

            string z = "apple";
            AddS(z);
            Console.WriteLine("HashCode: {0}, String: {1}.", z.GetHashCode(), z);

            Student stu = new Student();
            stu.Name = "Steve";
            Student.NextGen(stu);
            Console.WriteLine("HashCode: {0}, String: {1}.", stu.GetHashCode(), stu.Name);
        }

        static public int AddOne(int v)
        {
            int u = v + 1;
            Console.WriteLine(u);
            return u;
        }

        static public string AddS(string s)
        {            
            s = s + "s";
            //"string t = s + "s" equals to codes blow."
            /*
            string r = new string(t.ToCharArray());
            */
            Console.WriteLine("HashCode: {0}, String: {1}.", s.GetHashCode(), s);
            return s;
        }        
    }

    class Student
    {
        public string Name { get; set; }

        public static Student NextGen(Student stu)
        {
            stu.Name = "Tim";
            Console.WriteLine("HashCode: {0}, String: {1}.", stu.GetHashCode(), stu.Name);
            return stu;
        }
    }
}
