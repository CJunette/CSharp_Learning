using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace Inherit3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Refuel();
            car.Accelerate();
            Console.WriteLine($"Speed is {car.Speed}.");
            car.ShowFuel();
            
            Console.WriteLine("Car start turbo accelerate.");
                        
            car.TurboAccelerate();
            Console.WriteLine($"Speed is {car.Speed}.");
            car.ShowFuel();

            Console.WriteLine();

            Bus bus = new Bus();
            bus.Refuel();
            bus.SlowAccelerate();
            Console.WriteLine($"Speed is {bus.Speed}.");
            bus.ShowFuel();
        }
    }

    class Bus : Vehicle
    {
        public void SlowAccelerate()
        {
            Burn(1);
            //这里就显示出来了被“protected”修饰的字段是可以跨程序集进行访问的。
            _rpm += 500;
        }
    }
}
