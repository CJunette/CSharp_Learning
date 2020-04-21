using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This shows the case of tight coupling.
namespace Interface3
{
    class Program
    {
        static void Main(string[] args)
        {
            DeskFan fan = new DeskFan(new PowerSupply());
            Console.WriteLine(fan.Work());
        }
    }

    class PowerSupply
    {
        public int GetPower()
        {
            return 100;
        }
    }

    class DeskFan
    {
        PowerSupply _powersupply;
        public DeskFan(PowerSupply power)
        {
            _powersupply = power;
        }

        public string Work()
        {
            if (_powersupply.GetPower() < 0)
            {
                return "Can't work";
            }
            else if (_powersupply.GetPower() >= 0 && _powersupply.GetPower() < 100)
            {
                return "Slow";
            }
            else if (_powersupply.GetPower() >= 100 && _powersupply.GetPower() < 200)
            {
                return "Fine";
            }
            else
            {
                return "Warning";
            }
        }
    }
}
