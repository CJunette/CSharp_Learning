using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member_access
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                Student stu = new Student();
                stu.ID = 0;
                //Using x.y to access the member is the direct access.
                stu.Score = 99;
                //"&" is to get the memory address of stu.
                Student* pStu = &stu;
                //Using x->y to access the member is the indirect access.
                pStu->Score = 100;
                //"*"(point indrection) could obtain the variable pointed by a pointer. 
                //But it is inferior to the operator ".". That's why there is "()";
                (*pStu).Score = 101;
                Console.WriteLine(stu.Score);
            }            
        }
    }

    struct Student
    {
        public int ID;
        public long Score;
    }
}
