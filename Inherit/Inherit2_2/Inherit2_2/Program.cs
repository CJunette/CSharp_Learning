using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit2_2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Vehicle
    {
        public string Owner { get; set; }
        public Vehicle(string owner)
        {
            Owner = owner;
        }
    }
    class Car : Vehicle
    {
        public Car(string owner) : base(owner)
        {
        }
    }
}
