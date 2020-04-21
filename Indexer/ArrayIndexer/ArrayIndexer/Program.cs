using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Peter = new Student();
            try
            {
                Peter[9] = 90;
                Console.WriteLine(Peter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Student
    {
        int[] score = new int[9];
        
        public int? this[int index]
        {
            get
            {
                int ListLength = score.Length;
                if (index < ListLength)
                {
                    return score[index];
                }
                else
                {
                    throw new Exception("Index out of range");
                }
            }

            set
            {
                int ListLength = score.Length;
                if (index < ListLength)
                {
                    score[index] = value.Value;
                }
                else
                {
                    throw new Exception("Error!Index out of range!");
                }
            }
        }
    }
}
