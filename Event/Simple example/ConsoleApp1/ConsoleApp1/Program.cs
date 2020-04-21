using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Me me = new Me();
            Trigger t = new Trigger();
            me.Hello += t.HelloWorld;
            me.ThisIsMe();
            
        }
    }

    delegate void HelloWorldEventHandler();

    class HelloWorldEventArgs : EventArgs
    { }

    class Me
    {
        internal event HelloWorldEventHandler Hello;
        internal void ThisIsMe()
        {            
            Console.WriteLine("This is me!");
            if (this.Hello != null)
            {
                Hello.Invoke();
            }
        }

    }
}
