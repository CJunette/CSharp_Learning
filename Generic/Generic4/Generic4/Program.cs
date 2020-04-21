using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is an example that shows generics in method.
namespace Generic4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            int[] b = new int[] { 1, 2, 3, 4, 5, 6};
            double[] c = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double[] d = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
            int[] z = Zip(a, b);
            Console.WriteLine(string.Join(", ", z));

            //泛型方法的另一个好处是在方法调用时不需要显式地在函数名后写上数据类型。编译器自己会根据传入的参数类型推断出“T”所代表的的数据类型。
            int[] z_generic_1 = Zip(a, b);
            Console.WriteLine(string.Join(", ", z_generic_1));
            double[] z_generic_2 = Zip(c, d);
            Console.WriteLine(string.Join(", ", z_generic_2));

        }

        static int[] Zip(int[] a, int[] b)
        {
            int a_count = 0;
            int b_count = 0;
            int z_count = 0;
            int[] zip = new int[a.Length + b.Length];
            do
            {
                if (a_count < a.Length)
                {
                    zip[z_count++] = a[a_count++];                    
                }
                if (b_count < b.Length)
                {
                    zip[z_count++] = b[b_count++];
                }
            } while (a_count < a.Length || b_count < b.Length);
            return zip;
        }

        //如果我们在这里使用重载重写一个上述方法的“double”版本，就会出现方法膨胀的问题。
        //因为这两个方法从逻辑上来看大部分是重复的。
        static double[] Zip(double[] a, double[] b)
        {
            int a_count = 0;
            int b_count = 0;
            int z_count = 0;
            double[] zip = new double[a.Length + b.Length];
            do
            {
                if (a_count < a.Length)
                {
                    zip[z_count++] = a[a_count++];
                }
                if (b_count < b.Length)
                {
                    zip[z_count++] = b[b_count++];
                }
            } while (a_count < a.Length || b_count < b.Length);
            return zip;
        }

        //使用泛型就可以避免出现一个方法因数据结构不同而需要反复编写需要重载的代码的现象。
        static T[] Zip_Generic<T>(T[] a, T[] b)
        {
            int a_count = 0;
            int b_count = 0;
            int z_count = 0;
            T[] zip = new T[a.Length + b.Length];
            do
            {
                if (a_count < a.Length)
                {
                    zip[z_count++] = a[a_count++];
                }
                if (b_count < b.Length)
                {
                    zip[z_count++] = b[b_count++];
                }
            } while (a_count < a.Length || b_count < b.Length);
            return zip;
        }
    }
}
