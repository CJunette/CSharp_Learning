using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            try
            {
                stu["Math"] = null;
                Console.WriteLine(stu["Math"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }

    class Student
    {
        private Dictionary<string, int> scoreDictionary = new Dictionary<string, int>();

        public int? this[string subject]
        {
            get
            {
                if (this.scoreDictionary.ContainsKey(subject.ToLower()))
                {
                    return scoreDictionary[subject.ToLower()];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value.HasValue == false)
                {
                    throw new Exception("Score must have a value!");
                }
                if (this.scoreDictionary.ContainsKey(subject.ToLower()))
                {
                    this.scoreDictionary[subject.ToLower()] = value.Value;
                }
                else
                {
                    this.scoreDictionary.Add(subject.ToLower(), value.Value);
                }
            }
        }
    }
}
