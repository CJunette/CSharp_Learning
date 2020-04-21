using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This shows the case of uncoupling with interface and unit testing.
namespace Interface3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DeskFan fan = new DeskFan(new PowerSupply());
            Console.WriteLine(fan.Work());
        }
    }

    //Unit test requires all class to be public.

    public interface IPowerSupply
    {
        int GetPower();
    }

    public class PowerSupply : IPowerSupply
    {
        public int GetPower()
        {
            return 100;
        }
    }

    public class DeskFan
    {
        IPowerSupply _powersupply;
        public DeskFan(IPowerSupply power)
        {
            _powersupply = power;
        }

        public string Work()
        {
            int power = _powersupply.GetPower();
            if (power <= 0)
            {
                return "Can't work";
            }
            else if (power > 0 && power <= 100)
            {
                return "Slow";
            }
            else if (power > 100 && power <= 200)
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
