using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is about using "interface" to substitute an abstract whose methods are all abstract.
namespace AbstractClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Car();
            v.Run();
        }
    }

    //1.No need for keyword "class".
    //2.Interface does not have constructor. So When I tried to use this as a base class for non-abstract class,
    //the "derivative" class reported errors. That means for any direct derivative class of an interface,
    //the abstract method must be override or initialized in constructor.
    //3. Ins, of course, could not create instance of itself.
    interface IVehicleBase
    {
        //Interface requires all the method to be public and abstract.
        //And it bans the use of "public" and "abstract" keyword.
        void Run();
        void Stop();
        void Fill();        
    }

    abstract class Vehicle : IVehicleBase
    {
        abstract public void Run();

        //No Override here.
        public void Stop()
        {
            Console.WriteLine("Car stopped!");
        }
        public void Fill()
        {
            Console.WriteLine("Fill the car");
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

