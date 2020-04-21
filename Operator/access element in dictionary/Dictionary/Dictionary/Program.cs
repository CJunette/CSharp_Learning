using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> stuDic = new Dictionary<string, Student>();
            for (int i = 0; i < 100; i++)
            {
                Student stu = new Student();
                stu.Name = "s_" + i.ToString();
                stu.Score = i;
                stuDic.Add(stu.Name, stu);
            }

            Console.WriteLine(stuDic["s_12"].Score);
        }
    }

    class Student
    {
        public string Name;
        public int Score;
    }
}
