using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new RaceCar();
            v.Run();
        }
    }
    class Vehicle
    {        
        public virtual void Run()
        {
            Console.WriteLine("Vehicle is running.");
        }        
    }
    class Car : Vehicle
    {
        //这里隐藏的做法，而非正确的重写。
        public void Run()
        {
            Console.WriteLine("Car is running.");
        }        
    }
    class RaceCar : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("RaceCar is running.");
        }
    }
}
