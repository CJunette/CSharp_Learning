using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is an example to split a "fat" interface into two interfaces, each of which has an unique method.
//This example shows the rule of interface segregation.
namespace InterfaceSegregation1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver Mary = new Driver(new HeavyTank());
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

    //The Fire() method in ITank interface is the limitation that the driver can't change vehicle with tank.
    //So the best way to solve it is to segregate this non-urgent method in a new interface.
    interface IWeapon
    {
        void Fire();
    }

    //A derivative class could only have 1 base class.
    //But a derivative interface could have multiple base classes.
    interface ITank : IVehicle, IWeapon
    {

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
            Console.WriteLine("Ka! Ka! Ka!");
        }
    }
}
