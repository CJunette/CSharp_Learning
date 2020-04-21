using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This case shows the Generics in System.Collections.Generics.
namespace Generic3
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }
            foreach (var l in list)
            {
                Console.WriteLine(l);
            }

            //有两个泛型参数的例子
            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict[1] = "Steve";
            dict[2] = "Tim";
            int j = 0;
            for (int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine($"Boss #{i+1} is {dict[i+1]}.");
            }
        }
    }
}
