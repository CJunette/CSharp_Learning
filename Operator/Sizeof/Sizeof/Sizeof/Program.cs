using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sizeof
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = sizeof(int);
            int x2 = sizeof(decimal);

            unsafe
            {
                int y1 = sizeof(Student);
                Console.WriteLine(y1);
            }
        }
    }

    struct Student
    {
        int ID;
        long Score;
    }
}
