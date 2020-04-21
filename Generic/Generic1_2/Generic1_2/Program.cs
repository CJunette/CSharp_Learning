using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is an example shows the advantages of Generic.
namespace Generic1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple() { Color = "Red" };
            Book book = new Book() { Name = "Harry Potter" };
            Box<Apple> box1 = new Box<Apple>() { Cargo = apple };
            Box<Book> box2 = new Box<Book>() { Cargo = book };
            //使用泛型就可以保证既不会产生类型膨胀也不会产生成员膨胀，同时还能方便地进行调用。
            Console.WriteLine(box1.Cargo.Color);
            Console.WriteLine(box2.Cargo.Name);
        }
    }

    class Apple
    {
        public string Color { get; set; }
    }

    class Book
    {
        public string Name { get; set; }
    }

    class Box<TCargo>
    {
        public TCargo Cargo { get; set; }
    }

    /*
    interface ID
    {
        int MyProperty { get; set; }
    }
    */
}
