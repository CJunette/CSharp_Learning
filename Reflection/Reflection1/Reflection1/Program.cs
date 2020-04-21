using System;
using System.Reflection;

//This shows what is reflection.
namespace Reflection1
{
    class Program
    {
        static void Main(string[] args)
        {
            ITank tank = new HeavyTank();
            //.......................
            //Reflection is to craete an object dynamically with the instance of an static class.
            var t = tank.GetType();
            object o = Activator.CreateInstance(t);
            MethodInfo runMI = t.GetMethod("Run");
            MethodInfo fireMI = t.GetMethod("Fire");
            runMI.Invoke(o, null);
            fireMI.Invoke(o, null);
        }
    }

    interface IVehicle
    {
        void Run();
    }

    interface IWeapon
    {
        void Fire();
    }

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
