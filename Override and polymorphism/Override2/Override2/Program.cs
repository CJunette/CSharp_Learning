using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            Car c = new Car();
            v.Run();
            c.Run();
        }
    }
    class Vehicle
    {
        private double _speed;
        public virtual double Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }
        public virtual void Run()
        {
            _speed = 100;
            Console.WriteLine("Vehicle is running, the speed is {0}.", Speed);
        }
    }
    class Car : Vehicle
    {
        private double _rpm;
        public override double Speed
        {
            get
            {
                return _rpm / 100;
            }
            set
            {
                _rpm = value;
            }
        }

        public override void Run()
        {
            _rpm = 18000;
            Console.WriteLine("Car is running, the speed is {0}.", Speed);
        }
    }

}
