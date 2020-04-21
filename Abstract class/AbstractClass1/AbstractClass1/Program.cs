using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is about why we need abstract class and its features.
namespace AbstractClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            //My question is 
            //why not just use a derivative class to create a derivative instance?
            Vehicle v = new Car();
            v.Run();
            v.Stop();
        }
    }

    //An abstract method requires an abstract class.
    //Abstract class could not create an instance of itself! But is could create instance of its derivative class.
    //Because one of its method is not going to achieve actual function.
    abstract class Vehicle
    {
        //This is a substitute for the virtural codes that will never be used.
        //Abstract method must not be private!
        abstract public void Run();

        //Codes below is a essential part for override. But it will never be used.
        //That's why abstract method is created.
        /*
        public void virtual Run()
        {
            Console.WriteLine("Vehicle is running...");
        }
        */

        //Abstract class could also have non-abstract method!
        public void Stop()
        {
            Console.WriteLine("Stopped!");
        }
    }

    class Car : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Car is running...");
        }
    }

    class Truck : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck is running...");
        }
    }
}

