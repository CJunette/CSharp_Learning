using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is an example shows generics in delegation.
namespace Generic5
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> a1 = Say;
            Action<int> a2 = Mul;
            a1.Invoke("Tim");
            a2(2);

            Func<int, int, int> a3 = Add;
            Console.WriteLine(a3(100, 300));

            Func<int, int, int> a4 = Sub;
            Console.WriteLine(Sub(1, 2));
        }

        static void Say(string str)
        {
            Console.WriteLine($"Hello, {str}.");
        }
        static void Mul(int x)
        {
            Console.WriteLine(x * 100);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        //我本来想在这里更进一步直接用泛型方法去成为泛型委托的对象的，但似乎存在一些泛型约束上的问题暂时解决不了。      
        //网上找到的一种方法。
        static T Sub<T>(T a, T b) where T: struct
        {
            dynamic c = a;
            dynamic d = b;
            return c - d;
        }
        
    }
}
