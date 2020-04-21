using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is a case where we don't use generic.
namespace Generic1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //类型膨胀问题，有多少的对象就要创造个类。
            Apple apple = new Apple() { Color = "Red" };
            AppleBox applebox = new AppleBox() { Cargo = apple };
            Book book = new Book() { Name = "Harry Potter" };
            BookBox bookbox = new BookBox() { Cargo = book };

            //成员膨胀问题，一个类中有多个成员，而实际上为类创建实例时，只有一个成员会被用到。
            Box1 box1_apple = new Box1() { Apple = apple };
            Box1 box1_book = new Box1() { Book = book };

            //使用object类作为成员造成的访问权限问题。object类的变量无法访问到子类中的成员。
            Box2 box2_apple = new Box2() { Cargo = apple };
            Box2 box2_book = new Box2() { Cargo = book };
            //这里的“?.”表示如果类型转换可以发生，则返回访问成员；如果不行，则返回“null”。
            Console.WriteLine((box2_apple.Cargo as Apple)?.Color);
            Console.WriteLine((box2_book.Cargo as Book)?.Name);
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

    class AppleBox
    {
        public Apple Cargo { get; set; }
    }

    class BookBox
    {
        public Book Cargo { get; set; }
    }

    class Box1
    {
        public Apple Apple { get; set; }
        public Book Book { get; set; }
    }

    class Box2
    {
        public object Cargo { get; set; }
    }
}
