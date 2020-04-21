using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit2
{
    class Program
    {
        static void Main(string[] args)
        {
            RaceCar raceCar = new RaceCar();
            //Console.WriteLine(car.Owner);
            Console.WriteLine(raceCar.Owner);
        }
    }

    class Vehicle
    {
        public string Owner { get; set; }
        public Vehicle()
        {
            Owner = "Vehicle Owner";
        }
        ~Vehicle()
        {
            Console.WriteLine("Vehicle Retrieved.");
        }
        public void SayHello()
        {
            Console.WriteLine("Hello, I am a Vehicle.");
        }
    }

    class Car : Vehicle
    {
        public Car()
        {
            Owner = "CarOwner";
        }
        ~Car()
        {
            Console.WriteLine("Car retrieved.");
        }
        public void CarSayHello()
        {
            Console.WriteLine("Hello, I am a Car.");
        }
    }

    class RaceCar : Car
    {
        public RaceCar()
        {
            Console.WriteLine(base.Owner);
            this.Owner = "RaceCar Owner";
            Console.WriteLine(this.Owner);
            base.SayHello();
            base.CarSayHello();
            this.RaceCarSayHello();
        }
        ~RaceCar()
        {
            Console.WriteLine("RaceCar retrieved.");
        }
        public void RaceCarSayHello()
        {
            Console.WriteLine("Hello, I am a RaceCar.");
        }
    }
}
