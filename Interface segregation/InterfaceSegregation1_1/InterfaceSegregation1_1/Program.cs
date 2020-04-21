using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is an example that disobey the rule of interface segregation.
namespace InterfaceSegregation1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver Mary = new Driver(new Truck());
            Mary.Drive();
        }
    }
    class Driver
    {
        private IVehicle _ivehicle;
        public Driver(IVehicle vehicle)
        {
            _ivehicle = vehicle;
        }

        internal void Drive()
        {
            _ivehicle.Run();
        }
    }
    interface IVehicle
    {
        void Run();
    }

    class Car : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is running...");
        }
    }

    class Truck : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Truck is running...");
        }
    }

    //Because it is a different interface, if the driver wants to change the vehicle into a tank, he/she has to change the field inside the class.
    //The ITank actually has a Fire() method that is never going to be used. That disobey the rule of interface segregation.
    interface ITank
    {
        void Fire();
        void Run();
    }

    class LightTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("boom!");
        }

        public void Run()
        {
            Console.WriteLine("ka ka ka");
        }
    }

    class MediumTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!");
        }

        public void Run()
        {
            Console.WriteLine("ka! ka! ka!");
        }
    }

    class HeavyTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!");
        }

        public void Run()
        {
            Console.WriteLine("Ka Ka Ka");
        }
    }
}
