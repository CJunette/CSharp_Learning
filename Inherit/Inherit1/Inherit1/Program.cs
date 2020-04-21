using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Car);
            Type tb = t.BaseType.BaseType;
            Console.WriteLine(t);
            Console.WriteLine(tb);

            //“是一个”（is a）概念：一个子类（派生类）的实例，从语义上来讲，也是父类（基类）的一个实例。
            Car car1 = new Car();
            //这里重新提到了之前没有讲到的“is”操作符。
            Console.WriteLine(car1 is Vehicle);

            //一个子类实例一定也是一个父类的实例，但一个父类的实例不一定是子类的实例。
            Vehicle v1 = new Vehicle();
            Console.WriteLine(v1 is Car);

            //一个父类类型的变量，可以引用一个子类类型的实例。
            Vehicle v2 = new Car();
            Console.WriteLine(v2);

        }
    }

    class Vehicle
    {
        public void VehicleMethod()
        {
            Console.WriteLine("I'm a vehicle.");
        }
    }

    class Car : Vehicle
    {
        public void CarMethod()
        {
            Console.WriteLine("I'm a car.");
        }
    }
}
